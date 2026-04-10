package com.programaciongrafica;

import org.lwjgl.opengl.GL11;
import java.nio.FloatBuffer;
import org.lwjgl.BufferUtils;

/**
 * Clase para manejar los dibujos en OpenGL.
 */
public class Drawing {

    private static FloatBuffer vertexBuffer;

    static {
        // Definir los vértices del cuadrado (x, y, z)
        float[] vertices = {
                -0.5f, -0.5f, 0.0f, // Vértice inferior izquierdo
                0.5f, -0.5f, 0.0f, // Vértice inferior derecho
                0.5f, 0.5f, 0.0f, // Vértice superior derecho
                -0.5f, 0.5f, 0.0f // Vértice superior izquierdo
        };

        vertexBuffer = BufferUtils.createFloatBuffer(vertices.length);
        vertexBuffer.put(vertices);
        vertexBuffer.flip();
    }

    /**
     * Dibuja un cuadrado blanco en el centro de la pantalla usando vértices.
     */
    public static void drawSquare() {
        GL11.glColor3f(1.0f, 1.0f, 1.0f); // Color blanco

        GL11.glEnableClientState(GL11.GL_VERTEX_ARRAY);
        GL11.glVertexPointer(3, GL11.GL_FLOAT, 0, vertexBuffer);

        GL11.glDrawArrays(GL11.GL_QUADS, 0, 4);

        GL11.glDisableClientState(GL11.GL_VERTEX_ARRAY);
    }
}