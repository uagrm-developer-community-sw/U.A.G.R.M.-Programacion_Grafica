local ReplicatedStorage = game:GetService("ReplicatedStorage")
local Players = game:GetService("Players")
local RunService = game:GetService("RunService")

local player = Players.LocalPlayer
local camera = workspace.CurrentCamera
local event = ReplicatedStorage:WaitForChild("EsferaMiradaEvent")

local secondaryCamera = workspace:WaitForChild("SecondaryCamera") -- Cámara secundaria en Workspace

local DISTANCIA_MAXIMA = 1000

local function detectarDesdeCamara(cam)
    local origin = cam.CFrame.Position
    local direction = cam.CFrame.LookVector

    local raycastParams = RaycastParams.new()
    raycastParams.FilterDescendantsInstances = {player.Character}
    raycastParams.FilterType = Enum.RaycastFilterType.Exclude

    local result = workspace:Raycast(origin, direction * DISTANCIA_MAXIMA, raycastParams)

    if result and result.Instance and result.Instance.Name:match("^esferaDinamica") then
        event:FireServer(result.Instance)
    end
end

RunService.Heartbeat:Connect(function()
    detectarDesdeCamara(camera)           -- Raycast desde cámara principal
    detectarDesdeCamara(secondaryCamera)  -- Raycast desde cámara secundaria
end)