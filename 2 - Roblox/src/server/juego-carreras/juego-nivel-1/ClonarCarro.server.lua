-- src/server/juego-carreras/juego-nivel-1/ClonarCarro.server.lua
local ServerStorage = game:GetService("ServerStorage")
local Workspace = game:GetService("Workspace")
local DataStoreService = game:GetService("DataStoreService")
local HttpService = game:GetService("HttpService")
local ReplicatedStorage = game:GetService("ReplicatedStorage")

-- Crear evento remoto para notificar que los carros están listos
local CarrosListos = Instance.new("RemoteEvent")
CarrosListos.Name = "CarrosListos"
CarrosListos.Parent = ReplicatedStorage

-- Configuración del DataStore
local CarDataStore
local success, errorMessage = pcall(function()
    CarDataStore = DataStoreService:GetDataStore("CarData")
end)
if not success then
    warn("No se puede acceder a DataStore: " .. tostring(errorMessage) .. ". Asegúrate de que el lugar esté publicado.")
end

-- Tabla con los colores para cada carro (arreglo de Color3)
local colores = {
    Color3.fromRGB(255, 0, 0),      -- Rojo
    Color3.fromRGB(255, 255, 0),    -- Amarillo
    Color3.fromRGB(0, 255, 0),      -- Verde
    Color3.fromRGB(0, 0, 255),      -- Azul
}

-- Arreglo (tabla) de posiciones CFrame donde se colocarán los carros
local posicionesBase = {
    CFrame.new(-710, 15, 180),  -- Posición del primer carro
    CFrame.new(-720, 15, 220),  -- Posición del segundo carro
    CFrame.new(-660, 15, 180),  -- Posición del tercer carro
    CFrame.new(-660, 15, 220),  -- Posición del cuarto carro
}

-- Verificar si el modelo existe
local modeloCarro = ServerStorage:WaitForChild("CarroModelo", 10)
if not modeloCarro then
    warn("CarroModelo no encontrado en ServerStorage. Terminando script ClonarCarro.")
    return
end

-- Función para asignar la PrimaryPart al modelo, si no tiene asignada
local function asignarPrimaryPartSiNoExiste(model)
    if not model.PrimaryPart then
        for _, parte in ipairs(model:GetChildren()) do
            if parte:IsA("BasePart") then
                model.PrimaryPart = parte
                print("PrimaryPart asignada a: " .. parte.Name)
                break
            end
        end
        if not model.PrimaryPart then
            warn("No se encontró ninguna BasePart para asignar como PrimaryPart.")
        end
    end
end

-- Función para convertir CFrame a tabla serializable
local function cframeToTable(cframe)
    return {
        Position = {X = cframe.Position.X, Y = cframe.Position.Y, Z = cframe.Position.Z},
        Orientation = {cframe:ToEulerAnglesXYZ()}
    }
end

-- Función para convertir Color3 a tabla serializable
local function color3ToTable(color)
    return {R = color.R, G = color.G, B = color.B}
end

-- Función para convertir tabla serializada a CFrame
local function tableToCFrame(data)
    local pos = data.Position
    local ori = data.Orientation
    return CFrame.new(pos.X, pos.Y, pos.Z) * CFrame.fromEulerAnglesXYZ(ori[1], ori[2], ori[3])
end

-- Función para convertir tabla serializada a Color3
local function tableToColor3(data)
    return Color3.new(data.R, data.G, data.B)
end

-- Función para guardar los datos de los carros en DataStore
local function guardarDatosCarros()
    if not CarDataStore then
        warn("DataStore no disponible. No se pueden guardar los datos.")
        return
    end

    local datosCarros = {
        Colores = {},
        Posiciones = {}
    }

    for i, color in ipairs(colores) do
        datosCarros.Colores[i] = color3ToTable(color)
        datosCarros.Posiciones[i] = cframeToTable(posicionesBase[i])
    end

    local success, errorMessage = pcall(function()
        CarDataStore:SetAsync("CarrosData", HttpService:JSONEncode(datosCarros))
    end)

    if success then
        print("Datos de carros guardados correctamente.")
    else
        warn("Error al guardar los datos: " .. tostring(errorMessage))
    end
end

-- Función para recuperar los datos de los carros desde DataStore
local function recuperarDatosCarros()
    if not CarDataStore then
        warn("DataStore no disponible. No se pueden recuperar los datos.")
        return
    end

    local success, result = pcall(function()
        return CarDataStore:GetAsync("CarrosData")
    end)

    if success and result then
        local datosCarros = HttpService:JSONDecode(result)
        colores = {}
        posicionesBase = {}

        for i, colorData in ipairs(datosCarros.Colores) do
            colores[i] = tableToColor3(colorData)
        end
        for i, posData in ipairs(datosCarros.Posiciones) do
            posicionesBase[i] = tableToCFrame(posData)
        end

        print("Datos de carros recuperados correctamente.")
    else
        warn("No se encontraron datos o hubo un error al recuperar: " .. tostring(result))
    end
end

-- Intentar recuperar datos guardados al iniciar
if CarDataStore then
    success, errorMessage = pcall(recuperarDatosCarros)
    if not success then
        warn("Error al intentar recuperar datos: " .. tostring(errorMessage))
    end
end

-- Asignar PrimaryPart al modelo original antes de clonar
asignarPrimaryPartSiNoExiste(modeloCarro)

-- Bucle para clonar, posicionar y colorear cada carro
for i = 1, #colores do
    local posicion = posicionesBase[i]

    if not posicion then
        warn("No hay posición definida para el índice: " .. tostring(i))
        break
    end

    local carroClonado = modeloCarro:Clone()
    asignarPrimaryPartSiNoExiste(carroClonado)
    carroClonado.Name = "AutoModelo_" .. i -- Asignar un nombre único
    carroClonado.Parent = Workspace

    if carroClonado.PrimaryPart then
        carroClonado:SetPrimaryPartCFrame(posicion)
    else
        warn("El modelo clonado no tiene PrimaryPart asignada.")
    end

    local color = colores[i] or Color3.new(1, 1, 1)
    for _, parte in pairs(carroClonado:GetDescendants()) do
        if parte:IsA("BasePart") then
            parte.Color = color
        end
    end
end

-- Notificar que los carros están listos
CarrosListos:FireAllClients()

-- Guardar los datos después de configurar los carros
if CarDataStore then
    success, errorMessage = pcall(guardarDatosCarros)
    if not success then
        warn("Error al intentar guardar datos: " .. tostring(errorMessage))
    end
end