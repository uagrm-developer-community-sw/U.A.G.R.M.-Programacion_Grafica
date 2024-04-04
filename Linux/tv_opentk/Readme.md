
## Version Instalada

```
TargetFramework:net6.0
```

---

## Comandos Powershell

## Crear proyecto 
```
dotnet new console --output MyConsoleApp
```

## instalar Opentk en su version
```
dotnet add package OpenTK --version 3.3.3
```

## adicionar paquetes
```
dotnet add package Microsoft.Win32.SystemEvents
```

##  adicionar paquetes 
```
dotnet add package System.Drawing.Common
```

## Crear Archivo
```
New-Item -Name "Figure.cs" -ItemType "file"
```

## Ver la lista dotnet
```
dotnet --list-sdks
```


```
dotnet new        # Crea un nuevo proyecto
dotnet build      # Compila un proyecto
dotnet run        # Ejecuta un proyecto
dotnet test       # Ejecuta pruebas en un proyecto
dotnet publish    # Publica un proyecto para su despliegue
dotnet restore    # Restaura las dependencias de un proyecto
dotnet add        # Agrega un paquete o una referencia a un proyecto
dotnet remove     # Elimina un paquete o una referencia de un proyecto
dotnet clean      # Limpia los archivos de compilación de un proyecto
dotnet sln        # Modifica soluciones de .NET
dotnet help       # Muestra información de ayuda para un comando
```

---

## Linux Instalaciones
```
sudo pacman -Syu
sudo pacman -S mono

echo 'set -gx PATH $PATH /usr/bin/mono' >> ~/.config/fish/config.fish
source ~/.config/fish/config.fish
```