local ReplicatedStorage = game:GetService("ReplicatedStorage")
local eventoMirada = ReplicatedStorage:WaitForChild("EsferaMiradaEvent")

eventoMirada.OnServerEvent:Connect(function(player, esfera)
    if esfera and esfera.Parent then
        print(player.Name .. " ha eliminado la esfera " .. esfera.Name)
        esfera:Destroy()
    end
end)
