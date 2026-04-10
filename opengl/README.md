# OpenGL Maven Project

Proyecto base en Java usando **Maven** y **LWJGL (OpenGL)**.

## Ecosistema de Renderizado

### 1. Java (JDK 17 o superior)

Es donde se desarrolla la lógica de la aplicación.

**Funciones:**

- Contiene la lógica principal del programa.
- Maneja la estructura del código.
- Se comunica con bibliotecas externas para acceder al hardware gráfico.

### 2. LWJGL (Lightweight Java Game Library)

Es la biblioteca intermedia que conecta Java con las librerías nativas de gráficos.

**Funciones:**

- Actúa como puente de bindings hacia C.
- Permite que Java utilice librerías nativas.
- Reemplaza GLEW o GLAD en el entorno Java.
- Proporciona acceso a APIs como OpenGL, GLFW, OpenAL, etc.

### 3. GLFW

Se encarga de la gestión de ventana y entrada del usuario.

**Funciones:**

- Crear la ventana de la aplicación.
- Manejar eventos de teclado y mouse.
- Controlar el contexto gráfico.

### 4. OpenGL

Es la API que se comunica directamente con la GPU.

**Funciones:**

- Renderizar gráficos.
- Ejecutar shaders.
- Dibujar objetos en pantalla.

En LWJGL se inicializa con:

```java
GL.createCapabilities()
```

Esto permite que OpenGL pueda utilizar las capacidades de la GPU.

### Flujo del Ecosistema

```
Java (JDK 17 o superior)
      │
      ▼
LWJGL (bindings hacia C)
      │
      ├── GLFW → Gestión de ventana y eventos
      │
      └── OpenGL → Comunicación directa con la GPU
```

## La Ilusión del Doble Búfer

Una aplicación gráfica se actualiza continuamente. Para evitar parpadeos visuales, nunca dibujamos directamente en la pantalla visible.

### Front Buffer (Visible)

Es el búfer frontal, el que se muestra en la pantalla.

### Back Buffer (Oculto)

Es el búfer trasero, donde se dibuja la escena antes de mostrarla.

### glfwSwapBuffers

Dibujamos en el búfer trasero. Cuando el fotograma está 100% terminado, intercambiamos los búferes al instante.

## El Graphics Pipeline: De Datos a Píxeles

El pipeline recibe datos brutos y los transforma paso a paso. La geometría abstracta se convierte en fragmentos físicos.

### Etapas del Pipeline

1. **Vértices**

   Son los puntos en el espacio que definen la geometría de los objetos.

2. **Primitivas**

   Los vértices se conectan para formar figuras geométricas, como:
   - Triángulos
   - Líneas
   - Puntos

3. **Viewport**

   Se define qué parte de la escena será visible en la pantalla. Es la transformación que adapta las coordenadas al tamaño de la ventana.

4. **Rasterización**

   Las primitivas (por ejemplo, triángulos) se convierten en una cuadrícula de píxeles.

5. **Fragmentos**

   Cada píxel generado se convierte en un fragmento, que contiene información como:
   - Color
   - Profundidad
   - Textura

   Luego estos fragmentos se procesan para formar la imagen final en pantalla.

## Estructura sugerida

- `pom.xml` - configuración de Maven y dependencias.
- `src/main/java` - código Java.
- `src/test/java` - pruebas (opcional).

## Ejecutar

Este proyecto debe ejecutarse desde la carpeta `opengl`.

Maven selecciona las librerias nativas correctas automaticamente segun el sistema operativo mediante perfiles en `pom.xml`.

### Requisitos

- Java 17 o superior instalado y disponible en `PATH`
- Maven instalado y disponible en `PATH`

Verifica ambas herramientas con:

```powershell
java -version
mvn -version
```

En `pom.xml` el proyecto esta configurado para compilar con Java 17.

1. Compilar:

```powershell
cd opengl
mvn clean package
```

2. Ejecutar el lanzador visual (usa el main de `com.programaciongrafica.TaskLauncher`):

```powershell
mvn exec:java
```

Desde esa ventana puedes abrir:

- `Hello World`
- `Cuadrado OpenGL`

Si quieres ejecutar una clase concreta sin pasar por el lanzador:

```powershell
mvn exec:java -Dexec.mainClass="com.programaciongrafica.HelloWorldApp"
mvn exec:java -Dexec.mainClass="com.programaciongrafica.App"
```
