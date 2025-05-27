local ServerStorage = game:GetService("ServerStorage")
local Workspace = game:GetService("Workspace")

local modeloCarro = ServerStorage:WaitForChild("CarroModelo")

-- Posición base para el primer carro
local posicionBase = CFrame.new(-775, 15, 180)

local colores = {
    Color3.fromRGB(255, 0, 0),    -- Rojo
    Color3.fromRGB(255, 255, 0),  -- Amarillo
}

local function getModelSizeX(model)
    if not model.PrimaryPart then
        warn("El modelo no tiene PrimaryPart asignada.")
        return 10
    end
    local _, size = model:GetBoundingBox()
    return size.X
end

local carroSizeX = getModelSizeX(modeloCarro)
local separacion = 2

local posicionesAjustadas = {}

for i = 1, #colores do
    local offsetX = (i - 1) * (carroSizeX + separacion)
    local nuevaPos = posicionBase.Position + Vector3.new(offsetX, 0, 0)
    posicionesAjustadas[i] = CFrame.new(nuevaPos)
end

for i, posicion in ipairs(posicionesAjustadas) do
    local carroClonado = modeloCarro:Clone()
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

