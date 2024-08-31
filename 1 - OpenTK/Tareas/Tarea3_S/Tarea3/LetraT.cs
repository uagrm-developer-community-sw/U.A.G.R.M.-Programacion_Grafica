using OpenTK.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea3
{
    internal class LetraT
    {
        public static List<Face> GetFaces() // método que devuelve una lista de caras que representan una televisión
        {
            List<Face> faces = new List<Face>(); // lista de caras

            //------------------------------------------------------
            // METODO QUE SE LLAMA AL DIBUJAR EL PROGRAMA (PARTE SUPERIOR T)

            // Parte Superior Frente de la letra T {#e86,6}
            Face parteSuperiorFrente = new Face(new Color4(1.0f, 1.0f, 0.0f, 1.0f)); // Color amarillo
            parteSuperiorFrente.addVertex(new float[3] { -0.3f, 0.55f, 0.1f }); // Esquina superior izquierda
            parteSuperiorFrente.addVertex(new float[3] { 0.5f, 0.55f, 0.1f });  // Esquina superior derecha
            parteSuperiorFrente.addVertex(new float[3] { 0.5f, 0.35f, 0.1f });  // Esquina inferior derecha
            parteSuperiorFrente.addVertex(new float[3] { -0.3f, 0.35f, 0.1f }); // Esquina inferior izquierda
            faces.Add(parteSuperiorFrente); // añadir la cara a la lista de caras

            // Parte Superior Atras de la letra T {#e30,6}
            Face parteSuperiorAtras = new Face(new Color4(0.0f, 1.0f, 0.0f, 1.0f)); // Color verde
            parteSuperiorAtras.addVertex(new float[3] { -0.2f, 0.65f, -0.1f }); // Esquina superior izquierda
            parteSuperiorAtras.addVertex(new float[3] { 0.6f, 0.65f, -0.1f });  // Esquina superior derecha
            parteSuperiorAtras.addVertex(new float[3] { 0.6f, 0.45f, -0.1f });  // Esquina inferior derecha
            parteSuperiorAtras.addVertex(new float[3] { -0.2f, 0.45f, -0.1f }); // Esquina inferior izquierda
            faces.Add(parteSuperiorAtras); // añadir la cara a la lista de caras

            // Parte Lado Izquierdo de la letra T {#2bd,6}
            Face parteLadoIzquierdo = new Face(new Color4(0.0f, 1.0f, 0.0f, 1.0f)); // Color verde
            parteLadoIzquierdo.addVertex(new float[3] { -0.3f, 0.55f, 0.1f }); // Frente superior
            parteLadoIzquierdo.addVertex(new float[3] { -0.2f, 0.65f, -0.1f }); // Atrás superior
            parteLadoIzquierdo.addVertex(new float[3] { -0.2f, 0.45f, -0.1f }); // Atrás inferior
            parteLadoIzquierdo.addVertex(new float[3] { -0.3f, 0.35f, 0.1f }); // Frente inferior
            faces.Add(parteLadoIzquierdo); // añadir la cara a la lista de caras

            // Parte Lado Derecho de la letra T {#c26,6}
            Face parteLadoDerecho = new Face(new Color4(0.0f, 1.0f, 0.0f, 1.0f)); // Color verde
            parteLadoDerecho.addVertex(new float[3] { 0.5f, 0.55f, 0.1f }); // Frente superior
            parteLadoDerecho.addVertex(new float[3] { 0.6f, 0.65f, -0.1f }); // Atrás superior
            parteLadoDerecho.addVertex(new float[3] { 0.6f, 0.45f, -0.1f }); // Atrás inferior
            parteLadoDerecho.addVertex(new float[3] { 0.5f, 0.35f, 0.1f }); // Frente inferior
            faces.Add(parteLadoDerecho); // añadir la cara a la lista de caras

            // Parte Superior de la letra T {#582,6}
            Face parteSuperior = new Face(new Color4(1.0f, 0.0f, 0.0f, 1.0f)); // Color rojo
            parteSuperior.addVertex(new float[3] { -0.3f, 0.55f, 0.1f }); // Frente izquierdo
            parteSuperior.addVertex(new float[3] { 0.5f, 0.55f, 0.1f });  // Frente derecho
            parteSuperior.addVertex(new float[3] { 0.6f, 0.65f, -0.1f }); // Atrás derecho
            parteSuperior.addVertex(new float[3] { -0.2f, 0.65f, -0.1f }); // Atrás izquierdo
            faces.Add(parteSuperior); // añadir la cara a la lista de caras

            // Parte Inferior de la letra T {#0ba,6}
            Face parteInferior = new Face(new Color4(1.0f, 0.0f, 0.0f, 1.0f)); // Color rojo
            parteInferior.addVertex(new float[3] { -0.3f, 0.35f, 0.1f }); // Frente izquierdo
            parteInferior.addVertex(new float[3] { 0.5f, 0.35f, 0.1f });  // Frente derecho
            parteInferior.addVertex(new float[3] { 0.6f, 0.45f, -0.1f }); // Atrás derecho
            parteInferior.addVertex(new float[3] { -0.2f, 0.45f, -0.1f }); // Atrás izquierdo
            faces.Add(parteInferior); // añadir la cara a la lista de caras

            //------------------------------------------------------
            // METODO QUE SE LLAMA AL DIBUJAR EL PROGRAMA (PARTE CUERPO T)

            // Cuerpo T Frente de la letra T {#e86,6}
            Face cuerpoTFrente = new Face(new Color4(1.0f, 0.0f, 0.0f, 1.0f)); // Color rojo
            cuerpoTFrente.addVertex(new float[3] { -0.1f, 0.3f, 0.0f }); // Esquina superior izquierda
            cuerpoTFrente.addVertex(new float[3] { 0.1f, 0.3f, 0.0f });  // Esquina superior derecha
            cuerpoTFrente.addVertex(new float[3] { 0.1f, -0.5f, 0.0f }); // Esquina inferior derecha
            cuerpoTFrente.addVertex(new float[3] { -0.1f, -0.5f, 0.0f }); // Esquina inferior izquierda
            faces.Add(cuerpoTFrente); // añadir la cara a la lista de caras

            // Cuerpo T Atras de la letra T {#e30,6}
            Face cuerpoTAtras = new Face(new Color4(0.0f, 0.0f, 1.0f, 1.0f)); // Color azul
            cuerpoTAtras.addVertex(new float[3] { -0.1f, 0.4f, -0.2f }); // Esquina superior izquierda
            cuerpoTAtras.addVertex(new float[3] { 0.2f, 0.4f, -0.2f });  // Esquina superior derecha
            cuerpoTAtras.addVertex(new float[3] { 0.2f, -0.4f, -0.2f }); // Esquina inferior derecha
            cuerpoTAtras.addVertex(new float[3] { -0.1f, -0.4f, -0.2f }); // Esquina inferior izquierda
            faces.Add(cuerpoTAtras); // añadir la cara a la lista de caras

            // Cuerpo T Lado Izquierdo de la letra T {#2bd,6}
            Face cuerpoTLadoIzquierda = new Face(new Color4(0.0f, 0.0f, 1.0f, 1.0f)); // Color azul
            cuerpoTLadoIzquierda.addVertex(new float[3] { -0.1f, 0.3f, 0.0f }); // Frente superior
            cuerpoTLadoIzquierda.addVertex(new float[3] { -0.1f, 0.4f, -0.2f }); // Atrás superior
            cuerpoTLadoIzquierda.addVertex(new float[3] { -0.1f, -0.4f, -0.2f }); // Atrás inferior
            cuerpoTLadoIzquierda.addVertex(new float[3] { -0.1f, -0.5f, 0.0f }); // Frente inferior
            faces.Add(cuerpoTLadoIzquierda); // añadir la cara a la lista de caras

            // Cuerpo T Lado Derecho de la letra T {#c26,6}
            Face cuerpoTLadoDerecho = new Face(new Color4(0.0f, 0.0f, 1.0f, 1.0f)); // Color azul
            cuerpoTLadoDerecho.addVertex(new float[3] { 0.1f, 0.3f, 0.0f }); // Frente superior
            cuerpoTLadoDerecho.addVertex(new float[3] { 0.2f, 0.4f, -0.2f }); // Atrás superior
            cuerpoTLadoDerecho.addVertex(new float[3] { 0.2f, -0.4f, -0.2f }); // Atrás inferior
            cuerpoTLadoDerecho.addVertex(new float[3] { 0.1f, -0.5f, 0.0f }); // Frente inferior
            faces.Add(cuerpoTLadoDerecho); // añadir la cara a la lista de caras

            // Cuerpo T Superior de la letra T {#582,6}
            Face cuerpoSuperior = new Face(new Color4(0.0f, 0.0f, 1.0f, 1.0f)); // Color azul
            cuerpoSuperior.addVertex(new float[3] { -0.1f, 0.3f, 0.0f }); // Frente izquierdo
            cuerpoSuperior.addVertex(new float[3] { 0.1f, 0.3f, 0.0f });  // Frente derecho
            cuerpoSuperior.addVertex(new float[3] { 0.2f, 0.4f, -0.2f }); // Atrás derecho
            cuerpoSuperior.addVertex(new float[3] { -0.1f, 0.4f, -0.2f }); // Atrás izquierdo
            faces.Add(cuerpoSuperior); // añadir la cara a la lista de caras

            // Cuerpo T Inferior de la letra T {#0ba,6}
            Face cuerpoInferior = new Face(new Color4(0.0f, 0.0f, 1.0f, 1.0f)); // Color azul
            cuerpoInferior.addVertex(new float[3] { -0.1f, -0.5f, 0.0f }); // Frente izquierdo
            cuerpoInferior.addVertex(new float[3] { 0.1f, -0.5f, 0.0f });  // Frente derecho
            cuerpoInferior.addVertex(new float[3] { 0.2f, -0.4f, -0.2f }); // Atrás derecho
            cuerpoInferior.addVertex(new float[3] { -0.1f, -0.4f, -0.2f }); // Atrás izquierdo
            faces.Add(cuerpoInferior); // añadir la cara a la lista de caras

            return faces; // devolver la lista de caras
        }
    }
}
