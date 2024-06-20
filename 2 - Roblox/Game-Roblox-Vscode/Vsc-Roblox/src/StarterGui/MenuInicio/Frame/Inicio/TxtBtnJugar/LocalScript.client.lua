local cam = workspace.CurrentCamera -- Obtenga el objeto de cámara actual en el espacio de trabajo (el espacio de trabajo es el mundo en el que se ejecuta el juego)
local player = game.Players.LocalPlayer -- Obtenga el objeto de jugador del reproductor local (el jugador que ejecuta el script)

repeat wait() until player.Character -- Espere hasta que el personaje del jugador esté disponible (el personaje es el modelo 3D del jugador en el juego)

cam.CameraType = Enum.CameraType.Scriptable -- Establezca el tipo de cámara en Scriptable (Scriptable significa que el script controla la cámara)
cam.CFrame = workspace.MenuCam.CFrame -- Establezca la posición y la rotación de la cámara en la posición y la rotación de la cámara de menú en el espacio de trabajo

local start = script.Parent -- Obtenga el objeto de la instancia de script (el objeto de la instancia de script es el objeto de la instancia de script que contiene el script)

start.MouseButton1Click:Connect(function() -- Conecte una función a la señal MouseButton1Click del objeto de la instancia de script (MouseButton1Click es la señal que se activa cuando se hace clic en el objeto de la instancia de script)
	cam.CameraType = Enum.CameraType.Custom -- Establezca el tipo de cámara en Personalizado (Personalizado significa que el jugador controla la cámara)
	script.Parent.Parent.Parent.Parent.Frame.Visible = false -- Establezca la propiedad Visible del objeto de la instancia de script en falso (Visible es la propiedad que controla si el objeto de la instancia de script es visible)
end) -- Termine la función