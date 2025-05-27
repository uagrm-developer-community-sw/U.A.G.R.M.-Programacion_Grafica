local Players = game:GetService("Players")
local RunService = game:GetService("RunService")

local player = Players.LocalPlayer
local camera = workspace.CurrentCamera

-- Aquí suponemos que tienes un Part creado como marcador
local marcadorPart = Instance.new("Part")
marcadorPart.Size = Vector3.new(1, 1, 0.1)
marcadorPart.Anchored = true
marcadorPart.CanCollide = false
marcadorPart.Color = Color3.new(0, 1, 0)
marcadorPart.Material = Enum.Material.Neon
marcadorPart.Transparency = 0
marcadorPart.Parent = workspace

local distanciaAdicional = 10 -- metros adelante del avatar

RunService.RenderStepped:Connect(function()
    if player.Character and player.Character:FindFirstChild("HumanoidRootPart") then
        local hrp = player.Character.HumanoidRootPart

        local direccionFrontal = hrp.CFrame.LookVector
        local posicionMarcador = hrp.Position + direccionFrontal * distanciaAdicional

        marcadorPart.CFrame = CFrame.new(posicionMarcador)
    end
end)
