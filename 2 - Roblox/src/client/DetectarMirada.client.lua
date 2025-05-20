local ReplicatedStorage = game:GetService("ReplicatedStorage")
local Players = game:GetService("Players")
local RunService = game:GetService("RunService")

local player = Players.LocalPlayer
local camera = workspace.CurrentCamera
local event = ReplicatedStorage:WaitForChild("EsferaMiradaEvent")

local function detectarMirada()
    local origin = camera.CFrame.Position
    local direction = camera.CFrame.LookVector * 1000

    local raycastParams = RaycastParams.new()
    raycastParams.FilterDescendantsInstances = {player.Character}
    raycastParams.FilterType = Enum.RaycastFilterType.Exclude

    local result = workspace:Raycast(origin, direction, raycastParams)
    if result and result.Instance and result.Instance.Name:match("^esferaDinamica") then
        event:FireServer(result.Instance)
    end
end

RunService.Heartbeat:Connect(detectarMirada)
