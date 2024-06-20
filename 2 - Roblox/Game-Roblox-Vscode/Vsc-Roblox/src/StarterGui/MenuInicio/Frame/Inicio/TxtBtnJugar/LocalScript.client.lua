local cam = workspace.CurrentCamera
local player = game.Players.LocalPlayer

repeat wait() until player.Character

cam.CameraType = Enum.CameraType.Scriptable
cam.CFrame = workspace.MenuCam.CFrame

local start = script.Parent

start.MouseButton1Click:Connect(function()
	cam.CameraType = Enum.CameraType.Custom
	script.Parent.Parent.Parent.Parent.Frame.Visible = false
end)