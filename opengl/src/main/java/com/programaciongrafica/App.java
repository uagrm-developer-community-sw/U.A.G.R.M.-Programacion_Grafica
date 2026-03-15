package com.programaciongrafica;

import org.lwjgl.glfw.GLFW;
import org.lwjgl.glfw.GLFWErrorCallback;
import org.lwjgl.opengl.GL;
import org.lwjgl.opengl.GL11;

/**
 * Ejemplo simple de LWJGL + OpenGL.
 *
 * Ejecutar con: mvn compile exec:java
 */
public class App {

    public static void main(String[] args) {
        // Configurar una devolución de llamada de error. La implementación
        // predeterminada
        // imprimirá el mensaje de error en System.err.
        GLFWErrorCallback.createPrint(System.err).set();

        if (!GLFW.glfwInit()) {
            throw new IllegalStateException("No se pudo inicializar GLFW");
        }

        // Configurar ventana GLFW
        GLFW.glfwDefaultWindowHints();
        GLFW.glfwWindowHint(GLFW.GLFW_VISIBLE, GLFW.GLFW_FALSE);
        GLFW.glfwWindowHint(GLFW.GLFW_RESIZABLE, GLFW.GLFW_TRUE);

        long window = GLFW.glfwCreateWindow(800, 600, "Ejemplo OpenGL Maven", 0, 0);
        if (window == 0) {
            throw new RuntimeException("Error al crear la ventana GLFW");
        }

        GLFW.glfwMakeContextCurrent(window);
        GLFW.glfwSwapInterval(1); // Habilitar v-sync
        GLFW.glfwShowWindow(window);

        // Esta línea es crítica para la interoperación de LWJGL con el contexto OpenGL
        // de GLFW.
        // Carga los punteros de función de OpenGL.
        GL.createCapabilities();

        // Configurar proyección ortográfica para 2D
        GL11.glMatrixMode(GL11.GL_PROJECTION);
        GL11.glLoadIdentity();
        GL11.glOrtho(-1.0, 1.0, -1.0, 1.0, -1.0, 1.0);
        GL11.glMatrixMode(GL11.GL_MODELVIEW);
        GL11.glLoadIdentity();

        // Bucle principal (Game Loop)
        // Etapas descritas (Eventos → Lógica → Limpieza → Dibujo → Intercambio)
        // Nota: en este código, el orden real es:
        //   1) Limpieza
        //   2) Dibujo
        //   3) Intercambio
        //   4) Eventos
        while (!GLFW.glfwWindowShouldClose(window)) {
            // Limpieza (glClear): borrar el fotograma anterior
            GL11.glClearColor(0.1f, 0.15f, 0.2f, 1.0f);
            GL11.glClear(GL11.GL_COLOR_BUFFER_BIT);

            // Dibujo (glDrawArrays): enviar geometría a la GPU
            Drawing.drawSquare();

            // Intercambio (glfwSwapBuffers): mostrar el frame dibujado en el back buffer
            GLFW.glfwSwapBuffers(window);

            // Eventos (glfwPollEvents): procesar entrada de teclado/ratón
            GLFW.glfwPollEvents();
        }

        GLFW.glfwDestroyWindow(window);
        GLFW.glfwTerminate();
        GLFW.glfwSetErrorCallback(null).free();
    }
}
