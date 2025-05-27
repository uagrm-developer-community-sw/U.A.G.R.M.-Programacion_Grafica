local Players = game:GetService("Players")
local RunService = game:GetService("RunService")

local player = Players.LocalPlayer
local camera = workspace.CurrentCamera

-- Crear BillboardGui
local markerGui = Instance.new("BillboardGui")
markerGui.Size = UDim2.new(0, 50, 0, 50)  -- Tamaño del cuadro en pantalla
markerGui.AlwaysOnTop = true
markerGui.Parent = player:WaitForChild("PlayerGui")

-- Crear Frame para el cuadro
local frame = Instance.new("Frame")
frame.Size = UDim2.new(1, 0, 1, 0)
frame.BackgroundColor3 = Color3.new(0, 1, 0)  -- Verde
frame.BackgroundTransparency = 0.3
frame.BorderSizePixel = 0
frame.Parent = markerGui 

local distanciaMarcador = 100  -- Distancia para raycast

local function actualizarMarcador()
    if not camera then return end

    local origin = camera.CFrame.Position
    local lookVector = camera.CFrame.LookVector

    local raycastParams = RaycastParams.new()
    raycastParams.FilterDescendantsInstances = {player.Character}
    raycastParams.FilterType = Enum.RaycastFilterType.Exclude

    local raycastResult = workspace:Raycast(origin, lookVector * distanciaMarcador, raycastParams)

    if raycastResult and raycastResult.Instance then
        -- Ancla el BillboardGui a la parte que fue impactada
        markerGui.Adornee = raycastResult.Instance
    else
        markerGui.Adornee = nil
    end
end

RunService.RenderStepped:Connect(actualizarMarcador)

