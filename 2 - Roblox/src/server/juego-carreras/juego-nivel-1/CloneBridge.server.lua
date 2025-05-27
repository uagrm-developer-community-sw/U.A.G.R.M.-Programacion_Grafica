--local ServerStorage = game:GetService("ServerStorage")
--local Workspace = game:GetService("Workspace")

-- Espera el modelo BridgeModelo dentro de ServerStorage
--local modeloBridge = ServerStorage:WaitForChild("BridgeModelo")

-- Función para clonar y posicionar el modelo
--local function clonarYPosicionarBridge(posicionCFrame)
--    local clon = modeloBridge:Clone()
--    clon.Parent = Workspace

--    if clon.PrimaryPart then
--        clon:SetPrimaryPartCFrame(posicionCFrame)
--    else
--        local anyPart = clon:FindFirstChildWhichIsA("BasePart")
--        if anyPart then
--            anyPart.CFrame = posicionCFrame
--        end
--    end

--    -- Desactivar colisión para todas las partes
--    for _, parte in ipairs(clon:GetDescendants()) do
--        if parte:IsA("BasePart") then
--            parte.CanCollide = false
--        end
--   end
--end

-- Posición con altura menor
--clonarYPosicionarBridge(posicionEjemplo)
--local posicionEjemplo = CFrame.new(0, -45, 0)

