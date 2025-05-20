local ServerStorage = game:GetService("ServerStorage")
local Workspace = game:GetService("Workspace")

local modeloCarro = ServerStorage:WaitForChild("CarroModelo")

local posiciones = {
    CFrame.new(-685, 8, 180),
    CFrame.new(-680, 8, 180),
    CFrame.new(-675, 8, 180),
    CFrame.new(-670, 8, 180),
}

local colores = {
    Color3.fromRGB(255, 0, 0),    -- Rojo
    Color3.fromRGB(0, 255, 0),    -- Verde
    Color3.fromRGB(0, 0, 255),    -- Azul
    Color3.fromRGB(255, 255, 0),  -- Amarillo
}

for i, posicion in ipairs(posiciones) do
    local carroClonado = modeloCarro:Clone()
    carroClonado.Parent = Workspace

    if carroClonado.PrimaryPart then
        carroClonado:SetPrimaryPartCFrame(posicion)
    else
        warn("El modelo del carro no tiene PrimaryPart asignada.")
    end

    local color = colores[i] or Color3.new(1,1,1) -- blanco por defecto

    for _, parte in pairs(carroClonado:GetChildren()) do
        if parte:IsA("BasePart") then
            parte.Color = color
        end
    end
end
