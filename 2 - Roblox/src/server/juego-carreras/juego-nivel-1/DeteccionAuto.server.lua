-- src/server/juego-carreras/juego-nivel-1/DeteccionAuto.server.lua
local RunService = game:GetService("RunService")
local Workspace = game:GetService("Workspace")
local ReplicatedStorage = game:GetService("ReplicatedStorage")

-- Esperar a que los carros estén listos
local CarrosListos = ReplicatedStorage:WaitForChild("CarrosListos", 10)
if not CarrosListos then
    warn("CarrosListos no encontrado en ReplicatedStorage. Terminando script DeteccionAuto.")
    return
end

CarrosListos.OnServerEvent:Wait()

-- Buscar todos los carros clonados
local carros = {}
for i = 1, 4 do -- Ajusta según el número de carros (4 en este caso, basado en ClonarCarro)
    local carro = Workspace:WaitForChild("AutoModelo_" .. i, 10)
    if carro then
        table.insert(carros, carro)
    else
        warn("AutoModelo_" .. i .. " no encontrado en Workspace.")
    end
end

if #carros == 0 then
    warn("No se encontraron carros en Workspace. Terminando script DeteccionAuto.")
    return
end

-- Configurar raycast params para cada carro
local DISTANCIA_DETECCION = 50 -- distancia máxima para detectar esferas
local raycastParams = RaycastParams.new()
raycastParams.FilterType = Enum.RaycastFilterType.Exclude

-- Conectar el raycast a cada carro
for _, auto in ipairs(carros) do
    local chasis = auto:WaitForChild("Chasis", 10) -- Ajusta el nombre si tu parte principal se llama distinto
    if not chasis then
        warn("Chasis no encontrado en " .. auto.Name .. ". Saltando este carro.")
        continue
    end

    raycastParams.FilterDescendantsInstances = {auto} -- Evitar detectar partes del mismo auto

    RunService.Heartbeat:Connect(function()
        local origin = chasis.Position
        local directions = {
            chasis.CFrame.LookVector,
            chasis.CFrame.RightVector,
            -chasis.CFrame.RightVector,
        }

        for _, dir in pairs(directions) do
            local result = Workspace:Raycast(origin, dir * DISTANCIA_DETECCION, raycastParams)
            if result and result.Instance and result.Instance.Name:match("esferaDinamica") then
                print("Esfera detectada y destruida desde el auto " .. auto.Name .. ": " .. result.Instance.Name)
                result.Instance:Destroy()
            end
        end
    end)
end