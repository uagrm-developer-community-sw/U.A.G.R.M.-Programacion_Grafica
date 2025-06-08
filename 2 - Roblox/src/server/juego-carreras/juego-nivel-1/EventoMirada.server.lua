local ReplicatedStorage = game:GetService("ReplicatedStorage")

local esferaMiradaEvent = ReplicatedStorage:WaitForChild("EsferaMiradaEvent")

esferaMiradaEvent.OnServerEvent:Connect(function(player, esfera)
	if esfera and esfera.Parent then
		esfera:Destroy()
		print(player.Name .. " eliminated a sphere at " .. tostring(esfera.Position))
	end
end)