local ReplicatedStorage = game:GetService("ReplicatedStorage")
local Players = game:GetService("Players")
local RunService = game:GetService("RunService")

local player = Players.LocalPlayer
local camera = workspace.CurrentCamera
local event = ReplicatedStorage:WaitForChild("EsferaMiradaEvent")

local DISTANCIA_MAXIMA = 150 -- Ajusta este valor a la distancia deseada

local tiempoUltimaBusqueda = 0
local intervaloBusqueda = 0.1

local function detectarMirada()
    local origin = camera.CFrame.Position
    local direction = camera.CFrame.LookVector * 1000 -- sigue largo para que alcance lejos

    local raycastParams = RaycastParams.new()
    raycastParams.FilterDescendantsInstances = {player.Character}
    raycastParams.FilterType = Enum.RaycastFilterType.Exclude

    local result = workspace:Raycast(origin, direction, raycastParams)
    if result and result.Instance and result.Instance.Name:match("^esferaDinamica") then
        local esfera = result.Instance
        -- Verificamos distancia del jugador a la esfera
        local distancia = (player.Character.HumanoidRootPart.Position - esfera.Position).Magnitude
        if distancia <= DISTANCIA_MAXIMA then
            event:FireServer(esfera)
        end
    end
end

RunService.Heartbeat:Connect(function(dt)
    tiempoUltimaBusqueda = tiempoUltimaBusqueda + dt
    if tiempoUltimaBusqueda >= intervaloBusqueda then
        tiempoUltimaBusqueda = 0
        detectarMirada()
    end
end)
