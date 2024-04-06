using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Televisor_OpenTK
{
    class Figure
    {
         // Posición base del televisor
        private float baseX = 0.0f;
        private float baseY = 0.0f;
        private float baseZ = 0.0f; 

         // Escala del televisor
        private float scale = 0.5f; // Reducir a la mitad el tamaño original


        // Método para ajustar la posición base
        public void setBasePosition(float x, float y, float z)
        {
            baseX = x;
            baseY = y;
            baseZ = z;
        }

        // Método para ajustar la escala
        public void setScale(float s)
        {
            scale = s;
        }

        // Dibuja un televisor en la posición actual
        public void dibujarTv() 
        {
            
            // Tapas de la caja
            marcoAtrasTv();
            izquierdoTv();
            tapaSuperiorTv();
            tapaInferiorTv();
            derechoTv();
            marcoTv();

            // Complemento
            antenasTv();
            botonesTv();
            marcoVidrioTv1();

            //marcoVidrioTv();
        }

        // Ejemplo de cómo usar la escala en los métodos de dibujo:
private void marcoTv()
{
    GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

    GL.Color3(1.0f, 0.5f, 0.0f); // Color naranja chillón

    // Multiplica las coordenadas por la escala
    GL.Vertex3((baseX - 0.5f) * scale, (baseY - 0.4f) * scale, (baseZ + 0.5f) * scale); // Esquina inferior izquierda
    GL.Vertex3((baseX + 0.5f) * scale, (baseY - 0.4f) * scale, (baseZ + 0.5f) * scale);  // Esquina inferior derecha *
    GL.Vertex3((baseX + 0.5f) * scale, (baseY + 0.4f) * scale, (baseZ + 0.5f) * scale);   // Esquina superior derecha
    GL.Vertex3((baseX - 0.5f) * scale, (baseY + 0.4f) * scale, (baseZ + 0.5f) * scale);  // Esquina superior izquierda

    GL.End();
}

        // Parte trasera de la caja
        // Parte trasera de la caja
private void marcoAtrasTv()
{
    GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

    GL.Color3(0.1f, 0.1f, 0.1f); // Color del marco (gris oscuro)

    GL.Vertex3((baseX - 0.5f) * scale + 0.1f, (baseY - 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale); // Esquina inferior izquierda
    GL.Vertex3((baseX + 0.5f) * scale + 0.1f, (baseY - 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale);  // Esquina inferior derecha 
    GL.Vertex3((baseX + 0.5f) * scale + 0.1f, (baseY + 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale);   // Esquina superior derecha 1
    GL.Vertex3((baseX - 0.5f) * scale + 0.1f, (baseY + 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale);  // Esquina superior izquierda

    GL.End();
}

// Lateral derecho de la caja
private void derechoTv()
{
    GL.Begin(PrimitiveType.Quads);

    GL.Color3(0.0f, 1.0f, 0.0f); // Color verde chillón

    GL.Vertex3((baseX + 0.5f) * scale + 0.1f, (baseY - 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale); // Esquina inferior trasera
    GL.Vertex3((baseX + 0.5f) * scale, (baseY - 0.4f) * scale, (baseZ + 0.5f) * scale); // Esquina inferior delantera
    GL.Vertex3((baseX + 0.5f) * scale, (baseY + 0.4f) * scale, (baseZ + 0.5f) * scale); // Esquina superior delantera 2
    GL.Vertex3((baseX + 0.5f) * scale + 0.1f, (baseY + 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale); // Esquina superior trasera 1

    GL.End();
}

// Lado izquierdo de la caja
private void izquierdoTv()
{
    GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

    GL.Color3(1.0f, 1.0f, 0.0f); // Color amarillo chillón

    GL.Vertex3((baseX - 0.5f) * scale, (baseY - 0.4f) * scale, (baseZ + 0.5f) * scale); // Esquina inferior delantera
    GL.Vertex3((baseX - 0.5f) * scale + 0.1f, (baseY - 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale); // Esquina inferior trasera
    GL.Vertex3((baseX - 0.5f) * scale + 0.1f, (baseY + 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale);  // Esquina superior trasera
    GL.Vertex3((baseX - 0.5f) * scale, (baseY + 0.4f) * scale, (baseZ + 0.5f) * scale);  // Esquina superior delantera

    GL.End();
}

        // Tapa superior de la caja
private void tapaSuperiorTv()
{
    GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

    GL.Color3(1.0f, 0.0f, 1.0f); // Color naranja chillón

    GL.Vertex3((baseX - 0.5f) * scale, (baseY + 0.4f) * scale, (baseZ + 0.5f) * scale);  // Esquina superior izquierda delantera
    GL.Vertex3((baseX + 0.5f) * scale, (baseY + 0.4f) * scale, (baseZ + 0.5f) * scale);   // Esquina superior derecha delantera
    GL.Vertex3((baseX + 0.5f) * scale + 0.1f, (baseY + 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale); // Esquina superior derecha trasera
    GL.Vertex3((baseX - 0.5f) * scale + 0.1f, (baseY + 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale);  // Esquina superior izquierda trasera

    GL.End();
}

// Tapa inferior de la caja
private void tapaInferiorTv()
{
    GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

    GL.Color3(1.0f, 0.0f, 0.0f); // Color rojo chillón

    GL.Vertex3((baseX - 0.5f) * scale, (baseY - 0.4f) * scale, (baseZ + 0.5f) * scale); // Esquina inferior izquierda delantera
    GL.Vertex3((baseX + 0.5f) * scale, (baseY - 0.4f) * scale, (baseZ + 0.5f) * scale); // Esquina inferior derecha delantera
    GL.Vertex3((baseX + 0.5f) * scale + 0.1f, (baseY - 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale); // Esquina inferior derecha trasera
    GL.Vertex3((baseX - 0.5f) * scale + 0.1f, (baseY - 0.4f) * scale + 0.05f, (baseZ - 0.5f) * scale); // Esquina inferior izquierda trasera

    GL.End();
}

// Antenas en forma de V
private void antenasTv()
{
    GL.LineWidth(3.0f); // Hace las líneas más gruesas

    GL.Begin(PrimitiveType.Lines); // Dibuja líneas

    GL.Color3(0.1f, 0.1f, 0.1f); // Color de la base (gris oscuro)

    // Punto medio de la tapa superior
    float midX = (baseX + (0.5f + (-0.5f + 0.1f)) / 2) * scale;
    float midY = (baseY + 0.4f + 0.05f) * scale;
    float midZ = (baseZ + (0.5f + (-0.5f)) / 2) * scale;

    // Antena izquierda
    GL.Vertex3(midX, midY, midZ); // Punto medio
    GL.Vertex3(midX - 0.2f * scale, midY + 0.4f * scale, midZ); // Punto final, más largo

    // Antena derecha
    GL.Vertex3(midX, midY, midZ); // Punto medio
    GL.Vertex3(midX + 0.2f * scale, midY + 0.4f * scale, midZ); // Punto final, más largo

    GL.End();
}

// Marco de vidrio en la parte delantera del televisor
private void marcoVidrioTv1()
{
    GL.Color3(0.1f, 0.1f, 0.1f); // Color de la base (gris oscuro)

    // Dibuja el cuadrilátero central
    GL.Begin(PrimitiveType.Quads);
    GL.Vertex3((baseX - 0.39f) * scale, (baseY - 0.29f) * scale, (baseZ + 0.7f) * scale); // Esquina inferior izquierda
    GL.Vertex3((baseX + 0.29f) * scale, (baseY - 0.29f) * scale, (baseZ + 0.7f) * scale); // Esquina inferior derecha
    GL.Vertex3((baseX + 0.29f) * scale, (baseY + 0.29f) * scale, (baseZ + 0.5f) * scale); // Esquina superior derecha
    GL.Vertex3((baseX - 0.39f) * scale, (baseY + 0.29f) * scale, (baseZ + 0.5f) * scale); // Esquina superior izquierda
    GL.End();

    // Dibuja los círculos en las esquinas
    float radius = 0.05f * scale;
    int numSegments = 100;
    for (int i = 0; i < 4; i++)
    {
        float centerX = (baseX + ((i % 2 == 0) ? -0.35f : 0.25f)) * scale;
        float centerY = (baseY + ((i < 2) ? -0.25f : 0.25f)) * scale;
        GL.Begin(PrimitiveType.TriangleFan);
        GL.Vertex3(centerX, centerY, (baseZ + 0.5f) * scale);
        for (int j = 0; j <= numSegments; j++)
        {
            float theta = 2.0f * (float)Math.PI * j / numSegments;
            float dx = radius * (float)Math.Cos(theta);
            float dy = radius * (float)Math.Sin(theta);
            GL.Vertex3(centerX + dx, centerY + dy, (baseZ + 0.5f) * scale);
        }
        GL.End();
    }
}

// Botones del televisor
private void botonesTv()
{
    int numSegments = 100; // Número de segmentos utilizados para dibujar cada botón
    float radius = 0.05f * scale; // Radio de cada botón
    float buttonSpacing = 0.15f * scale; // Espacio entre los botones

    GL.Color3(0.0f, 0.0f, 1.0f); // Color azul chillón

    for (int i = 0; i < 3; i++) 
    {
        GL.Begin(PrimitiveType.TriangleFan); 

        float centerY = baseY * scale + 0.0f + i * buttonSpacing; // Posición y del centro del botón

        GL.Vertex3((baseX + 0.4f) * scale, centerY, (baseZ + 0.25f) * scale); // Centro del botón

        for (int j = 0; j <= numSegments; j++)
        {
            float theta = 2.0f * (float)Math.PI * j / numSegments; // Ángulo actual
            float dx = radius * (float)Math.Cos(theta);
            float dy = radius * (float)Math.Sin(theta);
            GL.Vertex3((baseX + 0.4f) * scale + dx, centerY + dy, (baseZ + 0.25f) * scale); // Punto en la circunferencia del botón
        }

        GL.End();
    }
}

// Marco de la parte delantera del televisor
private void marcoVidrioTv()
{
    GL.Begin(PrimitiveType.Quads); // Dibuja un cuadrilátero

    GL.Color3(0.1f, 0.1f, 0.1f); // Color de la base (gris oscuro)
    
    GL.Vertex3((baseX - 0.4f) * scale, (baseY - 0.3f) * scale, (baseZ + 0.5f) * scale); // Esquina inferior izquierda
    GL.Vertex3((baseX + 0.3f) * scale, (baseY - 0.3f) * scale, (baseZ + 0.5f) * scale);  // Esquina inferior derecha *
    GL.Vertex3((baseX + 0.3f) * scale, (baseY + 0.3f) * scale, (baseZ + 0.5f) * scale);   // Esquina superior derecha
    GL.Vertex3((baseX - 0.4f) * scale, (baseY + 0.3f) * scale, (baseZ + 0.5f) * scale);  // Esquina superior izquierda

    GL.End();
}
    }
}