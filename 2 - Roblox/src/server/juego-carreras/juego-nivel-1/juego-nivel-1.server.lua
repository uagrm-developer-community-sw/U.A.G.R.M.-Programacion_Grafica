print("Iniciando juego-nivel-1.server.lua")

local Workspace = game:GetService("Workspace")
local ServerStorage = game:GetService("ServerStorage")
local Players = game:GetService("Players")
local Debris = game:GetService("Debris")

-- ================================
-- ARREGLOS (VECTORES)
-- Listas indexadas numéricamente para orden y recorrido
-- ================================

-- Colores para las esferas (arreglo de Color3)
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

-- Posiciones para las esferas (arreglo de Vector3)
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

-- Posiciones para modelos InicioFinJuego (arreglo de CFrame)
local posicionesInicioFin = {
    CFrame.new(-700, 10, 200),
    CFrame.new(869, 6.5, 501),
}

-- Posiciones para flechas Siguiente (arreglo de Vector3)
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

-- Posiciones para flechas Curva (arreglo de Vector3)
local posicionesFlechaCurva = {
    Vector3.new(0, 5, 10),
    Vector3.new(0, 5, 20),
    Vector3.new(0, 5, 30),
}

-- ================================
-- TABLAS TIPO HASH (DICCIONARIOS)
-- Objetos con propiedades nombradas y estados
-- ================================

-- Tabla para almacenar datos de esferas creadas, cada elemento es una tabla hash
local esferasDatos = {}

-- ================================
-- FUNCIONES
-- ================================

-- Función para crear una esfera base con física realista
local function crearEsferaBase()
    local esfera = Instance.new("Part")
    esfera.Shape = Enum.PartType.Ball
    esfera.Size = Vector3.new(5, 5, 5)
    esfera.Anchored = false
    esfera.CanCollide = true
    esfera.Material = Enum.Material.Neon
    esfera.Name = "esferaDinamica"
    esfera.CustomPhysicalProperties = PhysicalProperties.new(0.7, 0.3, 0.5)
    return esfera
end

-- Función para detectar si la parte pertenece a un auto (retorna boolean)
local function esAuto(part)
    local modelo = part:FindFirstAncestorOfClass("Model")
    return modelo and modelo.Name == "CarroModelo"
end

-- Función para clonar y posicionar modelos desde ServerStorage
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

-- ================================
-- CREACIÓN Y CONFIGURACIÓN DE ESFERAS
-- ================================

for i = 1, #colores do
    local esfera = crearEsferaBase()
    esfera.BrickColor = BrickColor.new(colores[i])
    esfera.Position = posiciones[i]
    esfera.Name = "esferaDinamica_" .. i
    esfera.Parent = Workspace

    local velocidadInicial = Vector3.new(
        math.random(-80, 80),
        math.random(40, 70),
        math.random(-80, 80)
    )

    local bodyVelocity = Instance.new("BodyVelocity")
    bodyVelocity.Velocity = velocidadInicial
    bodyVelocity.MaxForce = Vector3.new(1e5, 1e5, 1e5)
    bodyVelocity.Parent = esfera

    Debris:AddItem(bodyVelocity, 1)

    -- Guardamos datos en tabla hash dentro del arreglo
    table.insert(esferasDatos, {
        instancia = esfera,
        color = colores[i],
        posicion = posiciones[i],
        velocidadInicial = velocidadInicial,
        bodyVelocity = bodyVelocity,
        activa = true
    })

    -- Evento de toque para cada esfera
    esfera.Touched:Connect(function(hit)
        if esAuto(hit) then
            esfera:Destroy()
            esferasDatos[i].activa = false
        else
            local humanoid = hit.Parent and hit.Parent:FindFirstChild("Humanoid")
            if humanoid then
                humanoid.Health = 0
            end
        end
    end)
end

-- ================================
-- POSICIÓN INICIAL DE LOS JUGADORES
-- ================================

local posicionInicio = CFrame.new(-685, 8, 180)

Players.PlayerAdded:Connect(function(player)
    player.CharacterAdded:Connect(function(character)
        local humanoidRootPart = character:WaitForChild("HumanoidRootPart")
        humanoidRootPart.CFrame = posicionInicio
    end)
end)

-- ================================
-- CLONAR MODELOS INICIO Y FIN DE JUEGO
-- ================================

local modeloInicioFin = ServerStorage:WaitForChild("InicioFinJuegoModelo")
clonarYPosicionar(modeloInicioFin, posicionesInicioFin, "InicioFinJuego")

-- ================================
-- CLONAR FLECHAS DE INDICACIÓN
-- ================================

local flechaCurvaOriginal = ServerStorage:WaitForChild("FlechaCurva")
local flechaSiguienteOriginal = ServerStorage:WaitForChild("FlechaSiguiente")

clonarYPosicionar(flechaSiguienteOriginal, posicionesFlechaSiguiente, "FlechaSiguiente")
clonarYPosicionar(flechaCurvaOriginal, posicionesFlechaCurva, "FlechaCurva")
