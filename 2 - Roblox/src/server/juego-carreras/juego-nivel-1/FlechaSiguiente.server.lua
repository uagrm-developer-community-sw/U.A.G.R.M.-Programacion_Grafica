local ServerStorage = game:GetService("ServerStorage")
local Workspace = game:GetService("Workspace")

local modeloFlecha = ServerStorage:WaitForChild("FlechaSiguiente")

-- Tabla con posiciones
local posicionesFlechas = {
    CFrame.new(-728, 19, 14),
    CFrame.new(-689, 19, -337),
    CFrame.new(-370.612, 30.618, -657.287),
    CFrame.new(-188.612, 30.618, -657.287),
    CFrame.new(108.612, 30.618, -530.287),
    -- más posiciones aquí...
}

-- Tabla con rotaciones en grados para cada posición (X, Y, Z)
local rotacionesGrados = {
    {anguloX = -90, anguloY = -90, anguloZ = 0},  -- para primera posición
    {anguloX = -90,   anguloY = -90,  anguloZ = 0},  -- para segunda posición (ejemplo)
    {anguloX = 0,   anguloY = 180,  anguloZ = 90},
    {anguloX = 0,   anguloY = 180,  anguloZ = 90},
    {anguloX = 0,   anguloY = 90,  anguloZ = 90},
    -- más rotaciones para cada posición...
}

local function buscarPrimeraBasePart(model)
    for _, hijo in ipairs(model:GetDescendants()) do
        if hijo:IsA("BasePart") then
            return hijo
        end
    end
    return nil
end

local function asignarPrimaryPartSiNoExiste(model)
    if not model.PrimaryPart then
        local basePart = buscarPrimeraBasePart(model)
        if basePart then
            model.PrimaryPart = basePart
            print("PrimaryPart asignada a: " .. basePart.Name)
        else
            warn("No se encontró ninguna BasePart para asignar como PrimaryPart.")
        end
    end
end

asignarPrimaryPartSiNoExiste(modeloFlecha)

for i = 1, #posicionesFlechas do
    local posicion = posicionesFlechas[i]
    local rot = rotacionesGrados[i]

    if not posicion or not rot then
        warn("Faltan posición o rotación para índice " .. tostring(i))
        break
    end

    local anguloX = math.rad(rot.anguloX)
    local anguloY = math.rad(rot.anguloY)
    local anguloZ = math.rad(rot.anguloZ)

    local rotacion = CFrame.Angles(anguloX, anguloY, anguloZ)

    local flechaClonada = modeloFlecha:Clone()
    asignarPrimaryPartSiNoExiste(flechaClonada)
    flechaClonada.Parent = Workspace

    if flechaClonada.PrimaryPart then
        flechaClonada:SetPrimaryPartCFrame(posicion * rotacion)
    else
        warn("El modelo clonado 'FlechaSiguiente' no tiene PrimaryPart asignada.")
    end
end
