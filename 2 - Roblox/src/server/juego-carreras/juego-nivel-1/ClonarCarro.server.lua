local ServerStorage = game:GetService("ServerStorage")
local Workspace = game:GetService("Workspace")

local modeloCarro = ServerStorage:WaitForChild("CarroModelo")

local colores = {
    Color3.fromRGB(255, 0, 0),    -- Rojo
    Color3.fromRGB(255, 255, 0),  -- Amarillo
}

local posicionesBase = {
    CFrame.new(-775, 15, 180),
    CFrame.new(-790, 15, 220),
}

local function asignarPrimaryPartSiNoExiste(model)
    if not model.PrimaryPart then
        for _, parte in ipairs(model:GetChildren()) do
            if parte:IsA("BasePart") then
                model.PrimaryPart = parte
                print("PrimaryPart asignada a: " .. parte.Name)
                break
            end
        end
        if not model.PrimaryPart then
            warn("No se encontró ninguna BasePart para asignar como PrimaryPart.")
        end
    end
end

-- Asignar PrimaryPart al modelo original antes de clonar
asignarPrimaryPartSiNoExiste(modeloCarro)

for i = 1, #colores do
    local posicion = posicionesBase[i]
    if not posicion then
        warn("No hay posición definida para el índice: " .. tostring(i))
        break
    end

    local carroClonado = modeloCarro:Clone()
    asignarPrimaryPartSiNoExiste(carroClonado) -- por si el clon perdió la PrimaryPart

    carroClonado.Parent = Workspace

    if carroClonado.PrimaryPart then
        carroClonado:SetPrimaryPartCFrame(posicion)
    else
        warn("El modelo clonado no tiene PrimaryPart asignada.")
    end

    local color = colores[i] or Color3.new(1, 1, 1)

    for _, parte in pairs(carroClonado:GetDescendants()) do
        if parte:IsA("BasePart") then
            parte.Color = color
        end
    end
end
