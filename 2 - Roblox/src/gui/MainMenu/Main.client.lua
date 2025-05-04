echo -- Código Lua del menú principal > src/gui/MainMenu/Main.client.lua
print("Menú principal activo")

-- Aquí puedes crear un botón por script, por ejemplo:
local button = Instance.new("TextButton")
button.Text = "Jugar"
button.Size = UDim2.new(0, 200, 0, 50)
button.Position = UDim2.new(0.5, -100, 0.5, -25)
button.Parent = script.Parent
