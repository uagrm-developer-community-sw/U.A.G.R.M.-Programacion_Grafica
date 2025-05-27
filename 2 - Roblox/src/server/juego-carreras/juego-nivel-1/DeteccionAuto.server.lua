local RunService = game:GetService("RunService")
local Workspace = game:GetService("Workspace")

-- Cambia el nombre 'AutoModelo' por el nombre real de tu modelo de auto en Workspace
local auto = Workspace:WaitForChild("AutoModelo")  
local chasis = auto:WaitForChild("Chassis")  -- Ajusta el nombre si tu parte principal se llama distinto

local DISTANCIA_DETECCION = 50 -- distancia máxima para detectar esferas

local raycastParams = RaycastParams.new()
raycastParams.FilterDescendantsInstances = {auto}  -- Evitar detectar partes del mismo auto
raycastParams.FilterType = Enum.RaycastFilterType.Exclude

RunService.Heartbeat:Connect(function()
    local origin = chasis.Position
    local directions = {
        chasis.CFrame.LookVector,
        -chasis.CFrame.LookVector,
        chasis.CFrame.RightVector,
        -chasis.CFrame.RightVector,
    }

    for _, dir in pairs(directions) do
        local result = Workspace:Raycast(origin, dir * DISTANCIA_DETECCION, raycastParams)
        if result and result.Instance and result.Instance.Name:match("^esferaDinamica") then
            print("Esfera detectada y destruida desde el auto: " .. result.Instance.Name)
            result.Instance:Destroy()
        end
    end
end)
