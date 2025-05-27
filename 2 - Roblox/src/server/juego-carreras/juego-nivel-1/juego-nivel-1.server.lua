print("Iniciando juego-nivel-1.server.lua")

local Workspace = game:GetService("Workspace")
local ServerStorage = game:GetService("ServerStorage")
local Players = game:GetService("Players")
local Debris = game:GetService("Debris")

-- Función para crear una esfera base con física realista
local function crearEsferaBase()
    local esfera = Instance.new("Part")
    esfera.Shape = Enum.PartType.Ball
    esfera.Size = Vector3.new(5, 5, 5)
    esfera.Anchored = false               -- Física activa
    esfera.CanCollide = true
    esfera.Material = Enum.Material.Neon
    esfera.Name = "esferaDinamica"
    -- Propiedades físicas: densidad, fricción, rebote
    esfera.CustomPhysicalProperties = PhysicalProperties.new(0.7, 0.3, 0.5)
    return esfera
end

-- Función para detectar si la parte pertenece a un auto
local function esAuto(part)
    local modelo = part:FindFirstAncestorOfClass("Model")
    if modelo and modelo.Name == "CarroModelo" then
        return true
    end
    return false
end

-- Colores para 20 esferas
local colores = {
    Color3.fromRGB(255, 0, 0),     -- rojo
    Color3.fromRGB(0, 255, 0),     -- verde
    Color3.fromRGB(0, 0, 255),     -- azul
    Color3.fromRGB(255, 255, 0),   -- amarillo
    Color3.fromRGB(255, 0, 255),   -- magenta
    Color3.fromRGB(0, 255, 255),   -- cian
    Color3.fromRGB(255, 165, 0),   -- naranja
    Color3.fromRGB(128, 0, 128),   -- púrpura
    Color3.fromRGB(0, 128, 128),   -- verde azulado
    Color3.fromRGB(128, 128, 0),   -- oliva
    Color3.fromRGB(192, 192, 192), -- gris claro
    Color3.fromRGB(255, 192, 203), -- rosa
    Color3.fromRGB(139, 69, 19),   -- marrón
    Color3.fromRGB(0, 0, 0),       -- negro
    Color3.fromRGB(255, 255, 255), -- blanco
    Color3.fromRGB(105, 105, 105), -- gris oscuro
    Color3.fromRGB(173, 216, 230), -- azul claro
    Color3.fromRGB(240, 230, 140), -- amarillo pálido
    Color3.fromRGB(60, 179, 113),  -- verde medio
    Color3.fromRGB(123, 104, 238)  -- azul violeta
}

-- Posiciones para las 20 esferas
local posiciones = {
    Vector3.new(-600, 8.5, -336),
    Vector3.new(-651, 8.5, -400),
    Vector3.new(-365, 8.5, -596),
    Vector3.new(-185, 8.5, -629),
    Vector3.new(-602, 8.5, -387),
    Vector3.new(14.171, 8.751, -551.234),
    Vector3.new(-64, 8, -468),
    Vector3.new(111, 8, -377),
    Vector3.new(88, 8, -270),
    Vector3.new(48, 8, -175),
    Vector3.new(99, 8, -75),
    Vector3.new(-560, 6.5, -387),
    Vector3.new(-554, 6.5, -387),
    Vector3.new(-548, 6.5, -387),
    Vector3.new(-542, 6.5, -387),
    Vector3.new(-536, 6.5, -387),
    Vector3.new(-530, 6.5, -387),
    Vector3.new(-524, 6.5, -387),
    Vector3.new(-518, 6.5, -387),
    Vector3.new(-512, 6.5, -387)
}

-- Crear y posicionar las esferas con impulso inicial
for i = 1, #colores do
    local esfera = crearEsferaBase()
    esfera.BrickColor = BrickColor.new(colores[i])
    esfera.Position = posiciones[i]
    esfera.Name = "esferaDinamica_" .. i
    esfera.Parent = Workspace

    -- Impulso inicial aleatorio para movimiento
    local bodyVelocity = Instance.new("BodyVelocity")
    bodyVelocity.Velocity = Vector3.new(
        math.random(-80, 80),
        math.random(40, 70),
        math.random(-80, 80)
    )
    bodyVelocity.MaxForce = Vector3.new(1e5, 1e5, 1e5)
    bodyVelocity.Parent = esfera

    -- Duración del impulso inicial: 1 segundo para que tomen movimiento
    Debris:AddItem(bodyVelocity, 1)

    -- Detectar toque
    esfera.Touched:Connect(function(hit)
        local partParent = hit.Parent
        if not partParent then return end

        -- Si toca el auto, destruye la esfera
        if esAuto(hit) then
            esfera:Destroy()
            return
        end

        -- Si no es auto, revisa si toca humanoide para matarlo
        local humanoid = partParent:FindFirstChild("Humanoid")
        if humanoid then
            humanoid.Health = 0
            return
        end
    end)
end

-- Posicionar al jugador al inicio
local posicionInicio = CFrame.new(-685, 8, 180)

Players.PlayerAdded:Connect(function(player)
    player.CharacterAdded:Connect(function(character)
        local humanoidRootPart = character:WaitForChild("HumanoidRootPart")
        humanoidRootPart.CFrame = posicionInicio
    end)
end)

-- Clonar y posicionar modelos InicioFinJuegoModelo
local modeloInicioFin = ServerStorage:WaitForChild("InicioFinJuegoModelo")

local posicionesInicioFin = {
    CFrame.new(-700, 10, 200),
    CFrame.new(869, 6.5, 501),
}

local function clonarMultiplesInicioFin()
    for i, posicion in ipairs(posicionesInicioFin) do
        local clon = modeloInicioFin:Clone()
        clon.Parent = Workspace

        if clon.PrimaryPart then
            clon:SetPrimaryPartCFrame(posicion)
        else
            warn("El modelo InicioFinJuegoModelo no tiene PrimaryPart asignada.")
            local anyPart = clon:FindFirstChildWhichIsA("BasePart")
            if anyPart then
                anyPart.CFrame = posicion
            end
        end
    end
end

clonarMultiplesInicioFin()

-- Clonar FlechaCurva y FlechaSiguiente desde ServerStorage
local flechaCurvaOriginal = ServerStorage:WaitForChild("FlechaCurva")
local flechaSiguienteOriginal = ServerStorage:WaitForChild("FlechaSiguiente")

local posicionesFlechaSiguiente = {
    Vector3.new(-695, 6.5, 66),
    Vector3.new(20, 5, 0),
    Vector3.new(30, 5, 0),
    Vector3.new(40, 5, 0),
    Vector3.new(50, 5, 0),
    Vector3.new(60, 5, 0),
    Vector3.new(70, 5, 0),
    Vector3.new(80, 5, 0),
    Vector3.new(90, 5, 0),
    Vector3.new(100, 5, 0),
}

local posicionesFlechaCurva = {
    Vector3.new(0, 5, 10),
    Vector3.new(0, 5, 20),
    Vector3.new(0, 5, 30),
}

local function clonarYPosicionar(modeloOriginal, posiciones, nombreBase)
    for i, pos in ipairs(posiciones) do
        local clon = modeloOriginal:Clone()
        clon.Name = nombreBase .. "_" .. i
        clon.Parent = Workspace

        if clon.PrimaryPart then
            clon:SetPrimaryPartCFrame(CFrame.new(pos))
        else
            warn("El modelo " .. clon.Name .. " no tiene PrimaryPart asignada.")
            local anyPart = clon:FindFirstChildWhichIsA("BasePart")
            if anyPart then
                anyPart.CFrame = CFrame.new(pos)
            end
        end
    end
end

clonarYPosicionar(flechaSiguienteOriginal, posicionesFlechaSiguiente, "FlechaSiguiente")
clonarYPosicionar(flechaCurvaOriginal, posicionesFlechaCurva, "FlechaCurva")
