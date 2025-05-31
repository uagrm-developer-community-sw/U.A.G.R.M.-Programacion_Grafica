local ServerStorage = game:GetService("ServerStorage")
local Workspace = game:GetService("Workspace")

local modeloCarro = ServerStorage:WaitForChild("CarroModelo")

-- Tabla con los colores para cada carro (arreglo de Color3)
local colores = {
    Color3.fromRGB(255, 0, 0),      -- Rojo
    Color3.fromRGB(255, 255, 0),    -- Amarillo
    Color3.fromRGB(0, 255, 0),      -- Verde
    Color3.fromRGB(0, 0, 255),      -- Azul
}

-- Arreglo (tabla) de posiciones CFrame donde se colocarán los carros
local posicionesBase = {
    CFrame.new(-710, 15, 180),  -- Posición del primer carro
    CFrame.new(-720, 15, 220),  -- Posición del segundo carro
    CFrame.new(-660, 15, 180),  -- Posición del tercer carro
    CFrame.new(-660, 15, 220),  -- Posición del cuarto carro
}

-- Función para asignar la PrimaryPart al modelo, si no tiene asignada
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

-- Bucle para clonar, posicionar y colorear cada carro
for i = 1, #colores do
    -- Obtener la posición correspondiente del arreglo de posiciones
    local posicion = posicionesBase[i]

    if not posicion then
        warn("No hay posición definida para el índice: " .. tostring(i))
        break
    end

    -- Clonar el modelo
    local carroClonado = modeloCarro:Clone()
    
    -- Asignar PrimaryPart al clon si es necesario
    asignarPrimaryPartSiNoExiste(carroClonado)

    carroClonado.Parent = Workspace

    -- Posicionar el modelo usando la PrimaryPart y el CFrame correspondiente
    if carroClonado.PrimaryPart then
        carroClonado:SetPrimaryPartCFrame(posicion)
    else
        warn("El modelo clonado no tiene PrimaryPart asignada.")
    end

    -- Asignar el color definido para este índice
    local color = colores[i] or Color3.new(1, 1, 1)

    -- Cambiar color de todas las partes BasePart del modelo clonado
    for _, parte in pairs(carroClonado:GetDescendants()) do
        if parte:IsA("BasePart") then
            parte.Color = color
        end
    end
end
