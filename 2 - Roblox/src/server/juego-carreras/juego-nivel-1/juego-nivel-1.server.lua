local ServerStorage = game:GetService("ServerStorage")
local Players = game:GetService("Players")
local Workspace = game:GetService("Workspace")
local ReplicatedStorage = game:GetService("ReplicatedStorage")
local Debris = game:GetService("Debris")

-- Limpieza inicial de carros no deseados
for _, obj in pairs(Workspace:GetChildren()) do
    if obj.Name == "CarroModelo" or obj:FindFirstChild("Thruster") then
        obj:Destroy()
    end
end

-- Configuración
local carModel = ServerStorage:WaitForChild("CarroModelo")
local player1Spawn = Workspace:WaitForChild("Player1Spawn") -- Asegúrate de que exista
local player2Spawn = Workspace:WaitForChild("Player2Spawn") -- Asegúrate de que exista
local finishLine = Workspace:WaitForChild("FinishLine") -- Asegúrate de que exista
print("Script iniciado, FinishLine detectado en " .. tostring(finishLine.Position))

-- Variables
local players = {}
local raceStarted = false
local winner = nil

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
    Vector3.new(-10, 10, 0),       -- Ajustado para estar cerca de los spawns
    Vector3.new(-20, 10, 0),
    Vector3.new(0, 10, -10),
    Vector3.new(10, 10, -10),
    Vector3.new(-15, 10, -5),
    Vector3.new(15, 10, -15),
    Vector3.new(-5, 10, -20),
    Vector3.new(20, 10, -20),
    Vector3.new(15, 10, -25),
    Vector3.new(5, 10, -30),
    Vector3.new(10, 10, -35),
    Vector3.new(15, 10, 5),
    Vector3.new(20, 10, 10),
    Vector3.new(25, 10, 15),
    Vector3.new(10, 10, 20),
    Vector3.new(-5, 10, 25),
    Vector3.new(-15, 10, 20),
    Vector3.new(-20, 10, 15),
    Vector3.new(-25, 10, 10),
    Vector3.new(-30, 10, 5)
}

-- Tabla para almacenar datos de esferas creadas
local esferasDatos = {}

-- Función para clonar y asignar un carro a un jugador
local function spawnCarForPlayer(player, spawnPosition)
    if player.Character then
        local carClone = carModel:Clone()
        carClone:SetPrimaryPartCFrame(CFrame.new(spawnPosition + Vector3.new(0, 5, 0)))
        carClone.Parent = Workspace
        return carClone
    end
end

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

-- Función para detectar si la parte pertenece a un auto
local function esAuto(part)
    local modelo = part:FindFirstAncestorOfClass("Model")
    return modelo and modelo.Name == "CarroModelo"
end

-- Crear esferas
local function spawnSpheres()
    print("Intentando crear esferas...")
    for i = 1, #colores do
        local esfera = crearEsferaBase()
        print("Creando esfera " .. i .. " en posición " .. tostring(posiciones[i]))
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

        -- Guardamos datos en tabla
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
    print("Esferas creadas con éxito: " .. #esferasDatos)
end

-- Detectar cuando un jugador se une
Players.PlayerAdded:Connect(function(player)
    player.CharacterAdded:Connect(function(character)
        if not raceStarted then
            if not next(players) then
                -- Primer jugador
                character:MoveTo(player1Spawn.Position)
                spawnCarForPlayer(player, player1Spawn.Position)
                table.insert(players, player)
                print(player.Name .. " (Player 1) has joined and is in position.")
            elseif #players == 1 then
                -- Segundo jugador
                character:MoveTo(player2Spawn.Position)
                spawnCarForPlayer(player, player2Spawn.Position)
                table.insert(players, player)
                print(player.Name .. " (Player 2) has joined and is in position.")
                -- Iniciar la carrera y crear esferas
                raceStarted = true
                spawnSpheres()
                print("The race has started with 2 players!")
            end
        end
    end)
end)

-- Detectar quién cruza la meta
finishLine.Touched:Connect(function(hit)
    local player = Players:GetPlayerFromCharacter(hit.Parent)
    if player and table.find(players, player) and not winner then
        winner = player
        print(player.Name .. " has won the race!")
        -- Eliminar reinicio automático hasta definir lógica de victoria
        -- for _, p in ipairs(players) do
        --     p:LoadCharacter()
        -- end
    end
end)

-- Manejar la eliminación de esferas
local esferaMiradaEvent = ReplicatedStorage:WaitForChild("EsferaMiradaEvent")
esferaMiradaEvent.OnServerEvent:Connect(function(player, esfera)
    if esfera and esfera.Parent then
        esfera:Destroy()
        print(player.Name .. " eliminated a sphere at " .. tostring(esfera.Position))
    end
end)

-- Limpiar al desconectarse (opcional)
Players.PlayerRemoving:Connect(function(player)
    local index = table.find(players, player)
    if index then
        table.remove(players, index)
        print(player.Name .. " has disconnected.")
    end
end)