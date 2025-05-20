local ReplicatedStorage = game:GetService("ReplicatedStorage")
local event = ReplicatedStorage:WaitForChild("EsferaMiradaEvent")

event.OnServerEvent:Connect(function(player, esfera)
    if esfera and esfera:IsDescendantOf(game.Workspace) then
        print(player.Name .. " está mirando la esfera " .. esfera.Name .. ", se eliminará.")
        esfera:Destroy()
    else
        warn("Intento de eliminar una esfera no válida o fuera de Workspace por " .. player.Name)
    end
end)
