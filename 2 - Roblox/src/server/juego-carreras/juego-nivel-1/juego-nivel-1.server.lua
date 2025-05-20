print("Iniciando juego-nivel-1.server.lua")

local Workspace = game:GetService("Workspace")

local function crearEsferaBase()
    local esfera = Instance.new("Part")
    esfera.Shape = Enum.PartType.Ball
    esfera.Size = Vector3.new(5, 5, 5)
    esfera.Anchored = true  -- Para que no se muevan al inicio
    esfera.CanCollide = true
    esfera.Material = Enum.Material.Neon
    esfera.Name = "esferaDinamica"
    return esfera
end

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

local posiciones = {
    Vector3.new(-600, 8.5, -336),
    Vector3.new(-651, 8.5, -400),
    Vector3.new(-365, 8.5, -596),
    Vector3.new(-185, 8.5, -629),
    Vector3.new(-602, 8.5, -387),
    Vector3.new(14.171, 8.751, -551.234),
    Vector3.new(-590, 8.5, -387),
    Vector3.new(-584, 8.5, -387),
    Vector3.new(-578, 6.5, -387),
    Vector3.new(-572, 6.5, -387),
    Vector3.new(-566, 6.5, -387),
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

for i = 1, 20 do
    local esfera = crearEsferaBase()
    esfera.BrickColor = BrickColor.new(colores[i])
    esfera.Position = posiciones[i]
    esfera.Name = "esferaDinamica_" .. i
    esfera.Parent = Workspace

    esfera.Touched:Connect(function(hit)
        print("Esfera " .. esfera.Name .. " tocada por " .. hit.Name)

        local character = hit.Parent
        if character and character:FindFirstChild("HumanoidRootPart") then
            esfera.Anchored = false
            local bodyVelocity = Instance.new("BodyVelocity")
            bodyVelocity.Velocity = Vector3.new(0, 50, 0)
            bodyVelocity.MaxForce = Vector3.new(100000, 100000, 100000)
            bodyVelocity.Parent = esfera

            game:GetService("Debris"):AddItem(bodyVelocity, 0.5)
        end
    end)
end

-- ===========================================================================

local Players = game:GetService("Players")

local posicionInicio = CFrame.new(-685, 8, 180)

Players.PlayerAdded:Connect(function(player)
    player.CharacterAdded:Connect(function(character)
        local humanoidRootPart = character:WaitForChild("HumanoidRootPart")
        humanoidRootPart.CFrame = posicionInicio
    end)
end)

-- ===========================================================================

local ServerStorage = game:GetService("ServerStorage")
local Workspace = game:GetService("Workspace")

-- Esperamos que el modelo esté en ServerStorage
local modeloInicioFin = ServerStorage:WaitForChild("InicioFinJuegoModelo")

-- Lista de posiciones donde quieres clonar el modelo
local posicionesInicioFin = {
    CFrame.new(-700, 10, 200),
    CFrame.new(869, 6.5, 501),
    --CFrame.new(-720, 10, 220),
    --CFrame.new(-730, 10, 230),
    -- Agrega más posiciones según necesites
}

-- Función para clonar el modelo y posicionarlo
local function clonarMultiplesInicioFin()
    for i, posicion in ipairs(posicionesInicioFin) do
        local clon = modeloInicioFin:Clone()
        clon.Parent = Workspace

        if clon.PrimaryPart then
            clon:SetPrimaryPartCFrame(posicion)
        else
            warn("El modelo InicioFinJuegoModelo no tiene PrimaryPart asignada.")
        end
    end
end

-- Ejecutar la función para clonar y posicionar los modelos
clonarMultiplesInicioFin()
