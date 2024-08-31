using OpenTK;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Speaker
    {
        public static List<Face> getFaces()
        {
            List<Face> faces = new List<Face>();

            Color4 Material013 = new Color4(0.01f, 0.01f, 0.01f, 1.0f);
            Color4 BlackStruss = new Color4(0.044f, 0.044f, 0.044f, 1.0f);
            Color4 Material014 = new Color4(0.94f, 0.94f, 0.94f, 1.0f);
            Color4 Material002 = new Color4(0.8f, 0.8f, 0.8f, 1.0f);


            Face f1 = new Face(Material013);
            f1.AddVertex(0.42094f, 0.94721f, -0.36122f);
            f1.AddVertex(-0.42062f, 0.94721f, -0.36122f);
            f1.AddVertex(-0.42062f, 0.94721f, 0.21251f);
            f1.AddVertex(0.42094f, 0.94721f, 0.21251f);
            faces.Add(f1);

            Face f2 = new Face(Material013);
            f2.AddVertex(0.38900f, 0.64291f, -0.36122f);
            f2.AddVertex(0.38900f, -0.11573f, -0.36122f);
            f2.AddVertex(0.38900f, -0.11573f, -0.33235f);
            f2.AddVertex(0.38900f, 0.64291f, -0.33235f);
            faces.Add(f2);

            Face f3 = new Face(Material013);
            f3.AddVertex(0.40271f, 0.64291f, 0.23074f);
            f3.AddVertex(0.40271f, 0.94721f, 0.23074f);
            f3.AddVertex(0.34837f, 0.92108f, 0.23074f);
            f3.AddVertex(0.34837f, 0.66904f, 0.23074f);
            faces.Add(f3);

            Face f4 = new Face(Material013);
            f4.AddVertex(0.37652f, -0.10326f, 0.23074f);
            f4.AddVertex(-0.37620f, -0.10326f, 0.23074f);
            f4.AddVertex(-0.40239f, -0.14768f, 0.23074f);
            f4.AddVertex(0.40271f, -0.14768f, 0.23074f);
            faces.Add(f4);

            Face f5 = new Face(Material013);
            f5.AddVertex(0.40271f, 0.94721f, 0.23074f);
            f5.AddVertex(-0.40239f, 0.94721f, 0.23074f);
            f5.AddVertex(-0.34805f, 0.92108f, 0.23074f);
            f5.AddVertex(0.34837f, 0.92108f, 0.23074f);
            faces.Add(f5);

            Face f6 = new Face(Material013);
            f6.AddVertex(0.38900f, 0.91527f, -0.36122f);
            f6.AddVertex(0.38900f, 0.64291f, -0.36122f);
            f6.AddVertex(0.38900f, 0.64291f, -0.33235f);
            f6.AddVertex(0.38900f, 0.91527f, -0.33235f);
            faces.Add(f6);

            Face f7 = new Face(Material013);
            f7.AddVertex(0.42094f, 0.41820f, 0.02351f);
            f7.AddVertex(0.42094f, 0.51120f, 0.02351f);
            f7.AddVertex(0.42094f, 0.64291f, 0.21251f);
            f7.AddVertex(0.42094f, -0.14768f, 0.21251f);
            faces.Add(f7);

            Face f8 = new Face(Material013);
            f8.AddVertex(-0.42062f, 0.51136f, 0.02436f);
            f8.AddVertex(-0.42062f, 0.41783f, 0.02436f);
            f8.AddVertex(-0.42062f, -0.14768f, 0.21251f);
            f8.AddVertex(-0.42062f, 0.64291f, 0.21251f);
            faces.Add(f8);

            Face f9 = new Face(Material013);
            f9.AddVertex(-0.40239f, 0.64291f, 0.23074f);
            f9.AddVertex(0.40271f, 0.64291f, 0.23074f);
            f9.AddVertex(0.34837f, 0.66904f, 0.23074f);
            f9.AddVertex(-0.34805f, 0.66904f, 0.23074f);
            faces.Add(f9);

            Face f10 = new Face(Material013);
            f10.AddVertex(0.42094f, 0.41820f, -0.15399f);
            f10.AddVertex(0.42094f, 0.41820f, 0.02351f);
            f10.AddVertex(0.42094f, -0.14768f, 0.21251f);
            f10.AddVertex(0.42094f, -0.14768f, -0.36122f);
            faces.Add(f10);

            Face f11 = new Face(Material013);
            f11.AddVertex(-0.42062f, -0.14768f, -0.36122f);
            f11.AddVertex(0.42094f, -0.14768f, -0.36122f);
            f11.AddVertex(0.42094f, -0.14768f, 0.21251f);
            f11.AddVertex(0.40271f, -0.14768f, 0.23074f);
            f11.AddVertex(-0.40239f, -0.14768f, 0.23074f);
            f11.AddVertex(-0.42062f, -0.14768f, 0.21251f);
            faces.Add(f11);

            Face f12 = new Face(Material013);
            f12.AddVertex(-0.42062f, 0.41783f, -0.15484f);
            f12.AddVertex(-0.42062f, 0.51136f, -0.15484f);
            f12.AddVertex(-0.42062f, 0.64291f, -0.36122f);
            f12.AddVertex(-0.42062f, -0.14768f, -0.36122f);
            faces.Add(f12);

            Face f13 = new Face(Material013);
            f13.AddVertex(-0.37620f, -0.10326f, 0.23074f);
            f13.AddVertex(-0.37620f, 0.59849f, 0.23074f);
            f13.AddVertex(-0.40239f, 0.64291f, 0.23074f);
            f13.AddVertex(-0.40239f, -0.14768f, 0.23074f);
            faces.Add(f13);

            Face f14 = new Face(Material013);
            f14.AddVertex(-0.37620f, 0.59849f, 0.23074f);
            f14.AddVertex(0.37652f, 0.59849f, 0.23074f);
            f14.AddVertex(0.40271f, 0.64291f, 0.23074f);
            f14.AddVertex(-0.40239f, 0.64291f, 0.23074f);
            faces.Add(f14);

            Face f15 = new Face(Material013);
            f15.AddVertex(0.42094f, 0.51120f, -0.15399f);
            f15.AddVertex(0.42094f, 0.41820f, -0.15399f);
            f15.AddVertex(0.42094f, -0.14768f, -0.36122f);
            f15.AddVertex(0.42094f, 0.64291f, -0.36122f);
            faces.Add(f15);

            Face f16 = new Face(Material013);
            f16.AddVertex(0.37652f, 0.59849f, 0.23074f);
            f16.AddVertex(0.37652f, -0.10326f, 0.23074f);
            f16.AddVertex(0.40271f, -0.14768f, 0.23074f);
            f16.AddVertex(0.40271f, 0.64291f, 0.23074f);
            faces.Add(f16);

            Face f17 = new Face(Material013);
            f17.AddVertex(0.42094f, 0.51120f, 0.02351f);
            f17.AddVertex(0.42094f, 0.51120f, -0.15399f);
            f17.AddVertex(0.42094f, 0.64291f, -0.36122f);
            f17.AddVertex(0.42094f, 0.64291f, 0.21251f);
            faces.Add(f17);

            Face f18 = new Face(Material013);
            f18.AddVertex(-0.38868f, 0.64291f, -0.36122f);
            f18.AddVertex(-0.38868f, -0.11573f, -0.36122f);
            f18.AddVertex(-0.42062f, -0.14768f, -0.36122f);
            f18.AddVertex(-0.42062f, 0.64291f, -0.36122f);
            faces.Add(f18);

            Face f19 = new Face(Material013);
            f19.AddVertex(-0.38868f, -0.11573f, -0.36122f);
            f19.AddVertex(0.38900f, -0.11573f, -0.36122f);
            f19.AddVertex(0.42094f, -0.14768f, -0.36122f);
            f19.AddVertex(-0.42062f, -0.14768f, -0.36122f);
            faces.Add(f19);

            Face f20 = new Face(Material013);
            f20.AddVertex(0.38900f, 0.91527f, -0.36122f);
            f20.AddVertex(-0.38868f, 0.91527f, -0.36122f);
            f20.AddVertex(-0.42062f, 0.94721f, -0.36122f);
            f20.AddVertex(0.42094f, 0.94721f, -0.36122f);
            faces.Add(f20);

            Face f21 = new Face(Material013);
            f21.AddVertex(0.38900f, -0.11573f, -0.36122f);
            f21.AddVertex(0.38900f, 0.64291f, -0.36122f);
            f21.AddVertex(0.42094f, 0.64291f, -0.36122f);
            f21.AddVertex(0.42094f, -0.14768f, -0.36122f);
            faces.Add(f21);

            Face f22 = new Face(Material013);
            f22.AddVertex(-0.38868f, 0.91527f, -0.36122f);
            f22.AddVertex(-0.38868f, 0.64291f, -0.36122f);
            f22.AddVertex(-0.42062f, 0.64291f, -0.36122f);
            f22.AddVertex(-0.42062f, 0.94721f, -0.36122f);
            faces.Add(f22);

            Face f23 = new Face(Material013);
            f23.AddVertex(0.38900f, 0.64291f, -0.36122f);
            f23.AddVertex(0.38900f, 0.91527f, -0.36122f);
            f23.AddVertex(0.42094f, 0.94721f, -0.36122f);
            f23.AddVertex(0.42094f, 0.64291f, -0.36122f);
            faces.Add(f23);

            Face f24 = new Face(Material013);
            f24.AddVertex(0.38900f, -0.11573f, -0.36122f);
            f24.AddVertex(-0.38868f, -0.11573f, -0.36122f);
            f24.AddVertex(-0.38868f, -0.11573f, -0.33235f);
            f24.AddVertex(0.38900f, -0.11573f, -0.33235f);
            faces.Add(f24);

            Face f25 = new Face(Material013);
            f25.AddVertex(-0.38868f, 0.64291f, -0.36122f);
            f25.AddVertex(-0.38868f, 0.91527f, -0.36122f);
            f25.AddVertex(-0.38868f, 0.91527f, -0.33235f);
            f25.AddVertex(-0.38868f, 0.64291f, -0.33235f);
            faces.Add(f25);

            Face f26 = new Face(Material013);
            f26.AddVertex(-0.38868f, 0.91527f, -0.36122f);
            f26.AddVertex(0.38900f, 0.91527f, -0.36122f);
            f26.AddVertex(0.38900f, 0.91527f, -0.33235f);
            f26.AddVertex(-0.38868f, 0.91527f, -0.33235f);
            faces.Add(f26);

            Face f27 = new Face(Material013);
            f27.AddVertex(-0.38868f, -0.11573f, -0.36122f);
            f27.AddVertex(-0.38868f, 0.64291f, -0.36122f);
            f27.AddVertex(-0.38868f, 0.64291f, -0.33235f);
            f27.AddVertex(-0.38868f, -0.11573f, -0.33235f);
            faces.Add(f27);

            Face f28 = new Face(Material013);
            f28.AddVertex(-0.42062f, 0.64291f, 0.21251f);
            f28.AddVertex(-0.42062f, 0.94721f, 0.21251f);
            f28.AddVertex(-0.42062f, 0.94721f, -0.36122f);
            f28.AddVertex(-0.42062f, 0.64291f, -0.36122f);
            faces.Add(f28);

            Face f29 = new Face(Material013);
            f29.AddVertex(-0.42062f, 0.41783f, 0.02436f);
            f29.AddVertex(-0.42062f, 0.41783f, -0.15484f);
            f29.AddVertex(-0.42062f, -0.14768f, -0.36122f);
            f29.AddVertex(-0.42062f, -0.14768f, 0.21251f);
            faces.Add(f29);

            Face f30 = new Face(Material013);
            f30.AddVertex(0.42094f, 0.64291f, -0.36122f);
            f30.AddVertex(0.42094f, 0.94721f, -0.36122f);
            f30.AddVertex(0.42094f, 0.94721f, 0.21251f);
            f30.AddVertex(0.42094f, 0.64291f, 0.21251f);
            faces.Add(f30);

            Face f31 = new Face(Material013);
            f31.AddVertex(-0.42062f, 0.51136f, -0.15484f);
            f31.AddVertex(-0.42062f, 0.51136f, 0.02436f);
            f31.AddVertex(-0.42062f, 0.64291f, 0.21251f);
            f31.AddVertex(-0.42062f, 0.64291f, -0.36122f);
            faces.Add(f31);

            Face f32 = new Face(Material013);
            f32.AddVertex(-0.42062f, 0.41783f, 0.02436f);
            f32.AddVertex(-0.43021f, 0.41783f, 0.02436f);
            f32.AddVertex(-0.43021f, 0.41783f, -0.15484f);
            f32.AddVertex(-0.42062f, 0.41783f, -0.15484f);
            faces.Add(f32);

            Face f33 = new Face(Material013);
            f33.AddVertex(-0.42062f, 0.51136f, -0.15484f);
            f33.AddVertex(-0.43021f, 0.51136f, -0.15484f);
            f33.AddVertex(-0.43021f, 0.51136f, 0.02436f);
            f33.AddVertex(-0.42062f, 0.51136f, 0.02436f);
            faces.Add(f33);

            Face f34 = new Face(Material013);
            f34.AddVertex(-0.40239f, 0.64291f, 0.23074f);
            f34.AddVertex(-0.40239f, 0.94721f, 0.23074f);
            f34.AddVertex(-0.42062f, 0.94721f, 0.21251f);
            f34.AddVertex(-0.42062f, 0.64291f, 0.21251f);
            faces.Add(f34);

            Face f35 = new Face(Material013);
            f35.AddVertex(0.40271f, 0.64291f, 0.23074f);
            f35.AddVertex(0.40271f, -0.14768f, 0.23074f);
            f35.AddVertex(0.42094f, -0.14768f, 0.21251f);
            f35.AddVertex(0.42094f, 0.64291f, 0.21251f);
            faces.Add(f35);

            Face f36 = new Face(Material013);
            f36.AddVertex(-0.40239f, -0.14768f, 0.23074f);
            f36.AddVertex(-0.40239f, 0.64291f, 0.23074f);
            f36.AddVertex(-0.42062f, 0.64291f, 0.21251f);
            f36.AddVertex(-0.42062f, -0.14768f, 0.21251f);
            faces.Add(f36);

            Face f37 = new Face(Material013);
            f37.AddVertex(0.40271f, 0.94721f, 0.23074f);
            f37.AddVertex(0.40271f, 0.64291f, 0.23074f);
            f37.AddVertex(0.42094f, 0.64291f, 0.21251f);
            f37.AddVertex(0.42094f, 0.94721f, 0.21251f);
            faces.Add(f37);

            Face f38 = new Face(Material013);
            f38.AddVertex(-0.40239f, 0.94721f, 0.23074f);
            f38.AddVertex(-0.40239f, 0.64291f, 0.23074f);
            f38.AddVertex(-0.34805f, 0.66904f, 0.23074f);
            f38.AddVertex(-0.34805f, 0.92108f, 0.23074f);
            faces.Add(f38);

            Face f39 = new Face(Material013);
            f39.AddVertex(0.42094f, 0.94721f, 0.21251f);
            f39.AddVertex(-0.42062f, 0.94721f, 0.21251f);
            f39.AddVertex(-0.40239f, 0.94721f, 0.23074f);
            f39.AddVertex(0.40271f, 0.94721f, 0.23074f);
            faces.Add(f39);

            Face f40 = new Face(BlackStruss);
            f40.AddVertex(0.36479f, 0.58677f, 0.21931f);
            f40.AddVertex(0.36479f, 0.50198f, 0.21931f);
            f40.AddVertex(0.36479f, 0.41719f, 0.21931f);
            f40.AddVertex(0.36479f, 0.33240f, 0.21931f);
            f40.AddVertex(0.36479f, 0.24761f, 0.21931f);
            f40.AddVertex(0.36479f, 0.16282f, 0.21931f);
            f40.AddVertex(0.36479f, 0.07804f, 0.21931f);
            f40.AddVertex(0.36479f, -0.00674f, 0.21931f);
            f40.AddVertex(0.36479f, -0.09153f, 0.21931f);
            f40.AddVertex(0.37652f, -0.10326f, 0.23074f);
            f40.AddVertex(0.37652f, 0.59849f, 0.23074f);
            faces.Add(f40);

            Face f41 = new Face(BlackStruss);
            f41.AddVertex(0.36479f, -0.09153f, 0.21931f);
            f41.AddVertex(0.27363f, -0.09153f, 0.21931f);
            f41.AddVertex(0.18247f, -0.09153f, 0.21931f);
            f41.AddVertex(0.09131f, -0.09153f, 0.21931f);
            f41.AddVertex(0.00015f, -0.09153f, 0.21931f);
            f41.AddVertex(-0.09100f, -0.09153f, 0.21931f);
            f41.AddVertex(-0.18216f, -0.09153f, 0.21931f);
            f41.AddVertex(-0.27332f, -0.09153f, 0.21931f);
            f41.AddVertex(-0.36448f, -0.09153f, 0.21931f);
            f41.AddVertex(-0.37620f, -0.10326f, 0.23074f);
            f41.AddVertex(0.37652f, -0.10326f, 0.23074f);
            faces.Add(f41);

            Face f42 = new Face(BlackStruss);
            f42.AddVertex(-0.36448f, -0.09153f, 0.21931f);
            f42.AddVertex(-0.36448f, -0.00674f, 0.21931f);
            f42.AddVertex(-0.36448f, 0.07804f, 0.21931f);
            f42.AddVertex(-0.36448f, 0.16282f, 0.21931f);
            f42.AddVertex(-0.36448f, 0.24761f, 0.21931f);
            f42.AddVertex(-0.36448f, 0.33240f, 0.21931f);
            f42.AddVertex(-0.36448f, 0.41719f, 0.21931f);
            f42.AddVertex(-0.36448f, 0.50198f, 0.21931f);
            f42.AddVertex(-0.36448f, 0.58677f, 0.21931f);
            f42.AddVertex(-0.37620f, 0.59849f, 0.23074f);
            f42.AddVertex(-0.37620f, -0.10326f, 0.23074f);
            faces.Add(f42);

            Face f43 = new Face(BlackStruss);
            f43.AddVertex(-0.36448f, 0.58677f, 0.21931f);
            f43.AddVertex(-0.27062f, 0.58677f, 0.21931f);
            f43.AddVertex(-0.17923f, 0.58677f, 0.21931f);
            f43.AddVertex(-0.09070f, 0.58677f, 0.21931f);
            f43.AddVertex(0.00015f, 0.58677f, 0.21931f);
            f43.AddVertex(0.09102f, 0.58677f, 0.21931f);
            f43.AddVertex(0.17955f, 0.58677f, 0.21931f);
            f43.AddVertex(0.27094f, 0.58677f, 0.21931f);
            f43.AddVertex(0.36479f, 0.58677f, 0.21931f);
            f43.AddVertex(0.37652f, 0.59849f, 0.23074f);
            f43.AddVertex(-0.37620f, 0.59849f, 0.23074f);
            faces.Add(f43);

            Face f44 = new Face(BlackStruss);
            f44.AddVertex(0.27327f, 0.06512f, 0.21931f);
            f44.AddVertex(0.23242f, 0.01535f, 0.21931f);
            f44.AddVertex(0.36479f, -0.09153f, 0.21931f);
            f44.AddVertex(0.36479f, -0.00674f, 0.21931f);
            faces.Add(f44);

            Face f45 = new Face(BlackStruss);
            f45.AddVertex(0.23242f, 0.01535f, 0.21931f);
            f45.AddVertex(0.18264f, -0.02549f, 0.21931f);
            f45.AddVertex(0.27363f, -0.09153f, 0.21931f);
            f45.AddVertex(0.36479f, -0.09153f, 0.21931f);
            faces.Add(f45);

            Face f46 = new Face(BlackStruss);
            f46.AddVertex(-0.27295f, 0.43010f, 0.21931f);
            f46.AddVertex(-0.23210f, 0.47988f, 0.21931f);
            f46.AddVertex(-0.36448f, 0.58677f, 0.21931f);
            f46.AddVertex(-0.36448f, 0.50198f, 0.21931f);
            faces.Add(f46);

            Face f47 = new Face(BlackStruss);
            f47.AddVertex(-0.23210f, 0.47988f, 0.21931f);
            f47.AddVertex(-0.18219f, 0.52073f, 0.21931f);
            f47.AddVertex(-0.27062f, 0.58677f, 0.21931f);
            f47.AddVertex(-0.36448f, 0.58677f, 0.21931f);
            faces.Add(f47);

            Face f48 = new Face(BlackStruss);
            f48.AddVertex(0.32232f, 0.31169f, 0.21931f);
            f48.AddVertex(0.32863f, 0.24761f, 0.21931f);
            f48.AddVertex(0.36479f, 0.24761f, 0.21931f);
            f48.AddVertex(0.36479f, 0.33240f, 0.21931f);
            faces.Add(f48);

            Face f49 = new Face(BlackStruss);
            f49.AddVertex(0.00015f, -0.08085f, 0.21931f);
            f49.AddVertex(-0.06392f, -0.07454f, 0.21931f);
            f49.AddVertex(-0.09100f, -0.09153f, 0.21931f);
            f49.AddVertex(0.00015f, -0.09153f, 0.21931f);
            faces.Add(f49);

            Face f50 = new Face(BlackStruss);
            f50.AddVertex(-0.32200f, 0.18353f, 0.21931f);
            f50.AddVertex(-0.32831f, 0.24761f, 0.21931f);
            f50.AddVertex(-0.36448f, 0.24761f, 0.21931f);
            f50.AddVertex(-0.36448f, 0.16282f, 0.21931f);
            faces.Add(f50);

            Face f51 = new Face(BlackStruss);
            f51.AddVertex(0.00015f, 0.57608f, 0.21931f);
            f51.AddVertex(0.06424f, 0.56977f, 0.21931f);
            f51.AddVertex(0.09102f, 0.58677f, 0.21931f);
            f51.AddVertex(0.00015f, 0.58677f, 0.21931f);
            faces.Add(f51);

            Face f52 = new Face(BlackStruss);
            f52.AddVertex(0.32232f, 0.18353f, 0.21931f);
            f52.AddVertex(0.30362f, 0.12191f, 0.21931f);
            f52.AddVertex(0.36479f, 0.07804f, 0.21931f);
            f52.AddVertex(0.36479f, 0.16282f, 0.21931f);
            faces.Add(f52);

            Face f53 = new Face(BlackStruss);
            f53.AddVertex(0.12586f, -0.05585f, 0.21931f);
            f53.AddVertex(0.06424f, -0.07454f, 0.21931f);
            f53.AddVertex(0.09131f, -0.09153f, 0.21931f);
            f53.AddVertex(0.18247f, -0.09153f, 0.21931f);
            faces.Add(f53);

            Face f54 = new Face(BlackStruss);
            f54.AddVertex(-0.32200f, 0.31169f, 0.21931f);
            f54.AddVertex(-0.30330f, 0.37331f, 0.21931f);
            f54.AddVertex(-0.36448f, 0.41719f, 0.21931f);
            f54.AddVertex(-0.36448f, 0.33240f, 0.21931f);
            faces.Add(f54);

            Face f55 = new Face(BlackStruss);
            f55.AddVertex(-0.12526f, 0.55108f, 0.21931f);
            f55.AddVertex(-0.06392f, 0.56977f, 0.21931f);
            f55.AddVertex(-0.09070f, 0.58677f, 0.21931f);
            f55.AddVertex(-0.17923f, 0.58677f, 0.21931f);
            faces.Add(f55);

            Face f56 = new Face(BlackStruss);
            f56.AddVertex(0.27327f, 0.43010f, 0.21931f);
            f56.AddVertex(0.30362f, 0.37331f, 0.21931f);
            f56.AddVertex(0.36479f, 0.41719f, 0.21931f);
            f56.AddVertex(0.36479f, 0.50198f, 0.21931f);
            faces.Add(f56);

            Face f57 = new Face(BlackStruss);
            f57.AddVertex(-0.12554f, -0.05585f, 0.21931f);
            f57.AddVertex(-0.18233f, -0.02549f, 0.21931f);
            f57.AddVertex(-0.27332f, -0.09153f, 0.21931f);
            f57.AddVertex(-0.18216f, -0.09153f, 0.21931f);
            faces.Add(f57);

            Face f58 = new Face(BlackStruss);
            f58.AddVertex(-0.27295f, 0.06512f, 0.21931f);
            f58.AddVertex(-0.30330f, 0.12191f, 0.21931f);
            f58.AddVertex(-0.36448f, 0.07804f, 0.21931f);
            f58.AddVertex(-0.36448f, -0.00674f, 0.21931f);
            faces.Add(f58);

            Face f59 = new Face(BlackStruss);
            f59.AddVertex(0.12558f, 0.55108f, 0.21931f);
            f59.AddVertex(0.18251f, 0.52073f, 0.21931f);
            f59.AddVertex(0.27094f, 0.58677f, 0.21931f);
            f59.AddVertex(0.17955f, 0.58677f, 0.21931f);
            faces.Add(f59);

            Face f60 = new Face(BlackStruss);
            f60.AddVertex(0.30362f, 0.12191f, 0.21931f);
            f60.AddVertex(0.27327f, 0.06512f, 0.21931f);
            f60.AddVertex(0.36479f, -0.00674f, 0.21931f);
            f60.AddVertex(0.36479f, 0.07804f, 0.21931f);
            faces.Add(f60);

            Face f61 = new Face(BlackStruss);
            f61.AddVertex(0.18264f, -0.02549f, 0.21931f);
            f61.AddVertex(0.12586f, -0.05585f, 0.21931f);
            f61.AddVertex(0.18247f, -0.09153f, 0.21931f);
            f61.AddVertex(0.27363f, -0.09153f, 0.21931f);
            faces.Add(f61);

            Face f62 = new Face(BlackStruss);
            f62.AddVertex(-0.30330f, 0.37331f, 0.21931f);
            f62.AddVertex(-0.27295f, 0.43010f, 0.21931f);
            f62.AddVertex(-0.36448f, 0.50198f, 0.21931f);
            f62.AddVertex(-0.36448f, 0.41719f, 0.21931f);
            faces.Add(f62);

            Face f63 = new Face(BlackStruss);
            f63.AddVertex(-0.18219f, 0.52073f, 0.21931f);
            f63.AddVertex(-0.12526f, 0.55108f, 0.21931f);
            f63.AddVertex(-0.17923f, 0.58677f, 0.21931f);
            f63.AddVertex(-0.27062f, 0.58677f, 0.21931f);
            faces.Add(f63);

            Face f64 = new Face(BlackStruss);
            f64.AddVertex(0.30362f, 0.37331f, 0.21931f);
            f64.AddVertex(0.32232f, 0.31169f, 0.21931f);
            f64.AddVertex(0.36479f, 0.33240f, 0.21931f);
            f64.AddVertex(0.36479f, 0.41719f, 0.21931f);
            faces.Add(f64);

            Face f65 = new Face(BlackStruss);
            f65.AddVertex(-0.06392f, -0.07454f, 0.21931f);
            f65.AddVertex(-0.12554f, -0.05585f, 0.21931f);
            f65.AddVertex(-0.18216f, -0.09153f, 0.21931f);
            f65.AddVertex(-0.09100f, -0.09153f, 0.21931f);
            faces.Add(f65);

            Face f66 = new Face(BlackStruss);
            f66.AddVertex(-0.30330f, 0.12191f, 0.21931f);
            f66.AddVertex(-0.32200f, 0.18353f, 0.21931f);
            f66.AddVertex(-0.36448f, 0.16282f, 0.21931f);
            f66.AddVertex(-0.36448f, 0.07804f, 0.21931f);
            faces.Add(f66);

            Face f67 = new Face(BlackStruss);
            f67.AddVertex(0.06424f, 0.56977f, 0.21931f);
            f67.AddVertex(0.12558f, 0.55108f, 0.21931f);
            f67.AddVertex(0.17955f, 0.58677f, 0.21931f);
            f67.AddVertex(0.09102f, 0.58677f, 0.21931f);
            faces.Add(f67);

            Face f68 = new Face(BlackStruss);
            f68.AddVertex(0.32863f, 0.24761f, 0.21931f);
            f68.AddVertex(0.32232f, 0.18353f, 0.21931f);
            f68.AddVertex(0.36479f, 0.16282f, 0.21931f);
            f68.AddVertex(0.36479f, 0.24761f, 0.21931f);
            faces.Add(f68);

            Face f69 = new Face(BlackStruss);
            f69.AddVertex(0.06424f, -0.07454f, 0.21931f);
            f69.AddVertex(0.00015f, -0.08085f, 0.21931f);
            f69.AddVertex(0.00015f, -0.09153f, 0.21931f);
            f69.AddVertex(0.09131f, -0.09153f, 0.21931f);
            faces.Add(f69);

            Face f70 = new Face(BlackStruss);
            f70.AddVertex(-0.32831f, 0.24761f, 0.21931f);
            f70.AddVertex(-0.32200f, 0.31169f, 0.21931f);
            f70.AddVertex(-0.36448f, 0.33240f, 0.21931f);
            f70.AddVertex(-0.36448f, 0.24761f, 0.21931f);
            faces.Add(f70);

            Face f71 = new Face(BlackStruss);
            f71.AddVertex(-0.06392f, 0.56977f, 0.21931f);
            f71.AddVertex(0.00015f, 0.57608f, 0.21931f);
            f71.AddVertex(0.00015f, 0.58677f, 0.21931f);
            f71.AddVertex(-0.09070f, 0.58677f, 0.21931f);
            faces.Add(f71);

            Face f72 = new Face(BlackStruss);
            f72.AddVertex(0.23242f, 0.47988f, 0.21931f);
            f72.AddVertex(0.27327f, 0.43010f, 0.21931f);
            f72.AddVertex(0.36479f, 0.50198f, 0.21931f);
            f72.AddVertex(0.36479f, 0.58677f, 0.21931f);
            faces.Add(f72);

            Face f73 = new Face(BlackStruss);
            f73.AddVertex(-0.18233f, -0.02549f, 0.21931f);
            f73.AddVertex(-0.23210f, 0.01535f, 0.21931f);
            f73.AddVertex(-0.36448f, -0.09153f, 0.21931f);
            f73.AddVertex(-0.27332f, -0.09153f, 0.21931f);
            faces.Add(f73);

            Face f74 = new Face(BlackStruss);
            f74.AddVertex(-0.23210f, 0.01535f, 0.21931f);
            f74.AddVertex(-0.27295f, 0.06512f, 0.21931f);
            f74.AddVertex(-0.36448f, -0.00674f, 0.21931f);
            f74.AddVertex(-0.36448f, -0.09153f, 0.21931f);
            faces.Add(f74);

            Face f75 = new Face(BlackStruss);
            f75.AddVertex(0.18251f, 0.52073f, 0.21931f);
            f75.AddVertex(0.23242f, 0.47988f, 0.21931f);
            f75.AddVertex(0.36479f, 0.58677f, 0.21931f);
            f75.AddVertex(0.27094f, 0.58677f, 0.21931f);
            faces.Add(f75);

            Face f76 = new Face(BlackStruss);
            f76.AddVertex(-0.11619f, 0.42174f, 0.15965f);
            f76.AddVertex(-0.14792f, 0.39570f, 0.15965f);
            f76.AddVertex(-0.08005f, 0.32783f, 0.09999f);
            f76.AddVertex(-0.06286f, 0.34194f, 0.09999f);
            faces.Add(f76);

            Face f77 = new Face(BlackStruss);
            f77.AddVertex(-0.17397f, 0.13126f, 0.15965f);
            f77.AddVertex(-0.14792f, 0.09953f, 0.15965f);
            f77.AddVertex(-0.08005f, 0.16739f, 0.09999f);
            f77.AddVertex(-0.09416f, 0.18459f, 0.09999f);
            faces.Add(f77);

            Face f78 = new Face(BlackStruss);
            f78.AddVertex(0.08030f, 0.05413f, 0.15965f);
            f78.AddVertex(0.11650f, 0.07348f, 0.15965f);
            f78.AddVertex(0.06318f, 0.15329f, 0.09999f);
            f78.AddVertex(0.04357f, 0.14280f, 0.09999f);
            faces.Add(f78);

            Face f79 = new Face(BlackStruss);
            f79.AddVertex(0.20958f, 0.24761f, 0.15965f);
            f79.AddVertex(0.20555f, 0.28847f, 0.15965f);
            f79.AddVertex(0.11142f, 0.26974f, 0.09999f);
            f79.AddVertex(0.11360f, 0.24761f, 0.09999f);
            faces.Add(f79);

            Face f80 = new Face(BlackStruss);
            f80.AddVertex(0.14824f, 0.39570f, 0.15965f);
            f80.AddVertex(0.11650f, 0.42174f, 0.15965f);
            f80.AddVertex(0.06318f, 0.34194f, 0.09999f);
            f80.AddVertex(0.08037f, 0.32783f, 0.09999f);
            faces.Add(f80);

            Face f81 = new Face(BlackStruss);
            f81.AddVertex(-0.17397f, 0.36396f, 0.15965f);
            f81.AddVertex(-0.19332f, 0.32776f, 0.15965f);
            f81.AddVertex(-0.10465f, 0.29103f, 0.09999f);
            f81.AddVertex(-0.09416f, 0.31064f, 0.09999f);
            faces.Add(f81);

            Face f82 = new Face(BlackStruss);
            f82.AddVertex(-0.04069f, 0.04221f, 0.15965f);
            f82.AddVertex(0.00015f, 0.03819f, 0.15965f);
            f82.AddVertex(0.00015f, 0.13417f, 0.09999f);
            f82.AddVertex(-0.02197f, 0.13635f, 0.09999f);
            faces.Add(f82);

            Face f83 = new Face(BlackStruss);
            f83.AddVertex(-0.07998f, 0.44109f, 0.15965f);
            f83.AddVertex(-0.11619f, 0.42174f, 0.15965f);
            f83.AddVertex(-0.06286f, 0.34194f, 0.09999f);
            f83.AddVertex(-0.04325f, 0.35242f, 0.09999f);
            faces.Add(f83);

            Face f84 = new Face(BlackStruss);
            f84.AddVertex(-0.20926f, 0.24761f, 0.15965f);
            f84.AddVertex(-0.20524f, 0.20676f, 0.15965f);
            f84.AddVertex(-0.11110f, 0.22548f, 0.09999f);
            f84.AddVertex(-0.11328f, 0.24761f, 0.09999f);
            faces.Add(f84);

            Face f85 = new Face(BlackStruss);
            f85.AddVertex(0.20555f, 0.28847f, 0.15965f);
            f85.AddVertex(0.19364f, 0.32776f, 0.15965f);
            f85.AddVertex(0.10496f, 0.29103f, 0.09999f);
            f85.AddVertex(0.11142f, 0.26974f, 0.09999f);
            faces.Add(f85);

            Face f86 = new Face(BlackStruss);
            f86.AddVertex(0.04101f, 0.45301f, 0.15965f);
            f86.AddVertex(0.00015f, 0.45704f, 0.15965f);
            f86.AddVertex(0.00015f, 0.36106f, 0.09999f);
            f86.AddVertex(0.02229f, 0.35888f, 0.09999f);
            faces.Add(f86);

            Face f87 = new Face(BlackStruss);
            f87.AddVertex(-0.07998f, 0.05413f, 0.15965f);
            f87.AddVertex(-0.04069f, 0.04221f, 0.15965f);
            f87.AddVertex(-0.02197f, 0.13635f, 0.09999f);
            f87.AddVertex(-0.04325f, 0.14280f, 0.09999f);
            faces.Add(f87);

            Face f88 = new Face(BlackStruss);
            f88.AddVertex(0.19364f, 0.16747f, 0.15965f);
            f88.AddVertex(0.20555f, 0.20676f, 0.15965f);
            f88.AddVertex(0.11142f, 0.22548f, 0.09999f);
            f88.AddVertex(0.10496f, 0.20420f, 0.09999f);
            faces.Add(f88);

            Face f89 = new Face(BlackStruss);
            f89.AddVertex(-0.20524f, 0.20676f, 0.15965f);
            f89.AddVertex(-0.19332f, 0.16747f, 0.15965f);
            f89.AddVertex(-0.10465f, 0.20420f, 0.09999f);
            f89.AddVertex(-0.11110f, 0.22548f, 0.09999f);
            faces.Add(f89);

            Face f90 = new Face(BlackStruss);
            f90.AddVertex(0.04101f, 0.04221f, 0.15965f);
            f90.AddVertex(0.08030f, 0.05413f, 0.15965f);
            f90.AddVertex(0.04357f, 0.14280f, 0.09999f);
            f90.AddVertex(0.02229f, 0.13635f, 0.09999f);
            faces.Add(f90);

            Face f91 = new Face(BlackStruss);
            f91.AddVertex(0.08030f, 0.44109f, 0.15965f);
            f91.AddVertex(0.04101f, 0.45301f, 0.15965f);
            f91.AddVertex(0.02229f, 0.35888f, 0.09999f);
            f91.AddVertex(0.04357f, 0.35242f, 0.09999f);
            faces.Add(f91);

            Face f92 = new Face(BlackStruss);
            f92.AddVertex(-0.19332f, 0.32776f, 0.15965f);
            f92.AddVertex(-0.20524f, 0.28847f, 0.15965f);
            f92.AddVertex(-0.11110f, 0.26974f, 0.09999f);
            f92.AddVertex(-0.10465f, 0.29103f, 0.09999f);
            faces.Add(f92);

            Face f93 = new Face(BlackStruss);
            f93.AddVertex(0.20555f, 0.20676f, 0.15965f);
            f93.AddVertex(0.20958f, 0.24761f, 0.15965f);
            f93.AddVertex(0.11360f, 0.24761f, 0.09999f);
            f93.AddVertex(0.11142f, 0.22548f, 0.09999f);
            faces.Add(f93);

            Face f94 = new Face(BlackStruss);
            f94.AddVertex(-0.04069f, 0.45301f, 0.15965f);
            f94.AddVertex(-0.07998f, 0.44109f, 0.15965f);
            f94.AddVertex(-0.04325f, 0.35242f, 0.09999f);
            f94.AddVertex(-0.02197f, 0.35888f, 0.09999f);
            faces.Add(f94);

            Face f95 = new Face(BlackStruss);
            f95.AddVertex(0.00015f, 0.03819f, 0.15965f);
            f95.AddVertex(0.04101f, 0.04221f, 0.15965f);
            f95.AddVertex(0.02229f, 0.13635f, 0.09999f);
            f95.AddVertex(0.00015f, 0.13417f, 0.09999f);
            faces.Add(f95);

            Face f96 = new Face(BlackStruss);
            f96.AddVertex(0.19364f, 0.32776f, 0.15965f);
            f96.AddVertex(0.17428f, 0.36396f, 0.15965f);
            f96.AddVertex(0.09448f, 0.31064f, 0.09999f);
            f96.AddVertex(0.10496f, 0.29103f, 0.09999f);
            faces.Add(f96);

            Face f97 = new Face(BlackStruss);
            f97.AddVertex(-0.20524f, 0.28847f, 0.15965f);
            f97.AddVertex(-0.20926f, 0.24761f, 0.15965f);
            f97.AddVertex(-0.11328f, 0.24761f, 0.09999f);
            f97.AddVertex(-0.11110f, 0.26974f, 0.09999f);
            faces.Add(f97);

            Face f98 = new Face(BlackStruss);
            f98.AddVertex(-0.11619f, 0.07348f, 0.15965f);
            f98.AddVertex(-0.07998f, 0.05413f, 0.15965f);
            f98.AddVertex(-0.04325f, 0.14280f, 0.09999f);
            f98.AddVertex(-0.06286f, 0.15329f, 0.09999f);
            faces.Add(f98);

            Face f99 = new Face(BlackStruss);
            f99.AddVertex(0.14824f, 0.09953f, 0.15965f);
            f99.AddVertex(0.17428f, 0.13126f, 0.15965f);
            f99.AddVertex(0.09448f, 0.18459f, 0.09999f);
            f99.AddVertex(0.08037f, 0.16739f, 0.09999f);
            faces.Add(f99);

            Face f100 = new Face(BlackStruss);
            f100.AddVertex(0.00015f, 0.45704f, 0.15965f);
            f100.AddVertex(-0.04069f, 0.45301f, 0.15965f);
            f100.AddVertex(-0.02197f, 0.35888f, 0.09999f);
            f100.AddVertex(0.00015f, 0.36106f, 0.09999f);
            faces.Add(f100);

            Face f101 = new Face(BlackStruss);
            f101.AddVertex(-0.19332f, 0.16747f, 0.15965f);
            f101.AddVertex(-0.17397f, 0.13126f, 0.15965f);
            f101.AddVertex(-0.09416f, 0.18459f, 0.09999f);
            f101.AddVertex(-0.10465f, 0.20420f, 0.09999f);
            faces.Add(f101);

            Face f102 = new Face(BlackStruss);
            f102.AddVertex(0.11650f, 0.07348f, 0.15965f);
            f102.AddVertex(0.14824f, 0.09953f, 0.15965f);
            f102.AddVertex(0.08037f, 0.16739f, 0.09999f);
            f102.AddVertex(0.06318f, 0.15329f, 0.09999f);
            faces.Add(f102);

            Face f103 = new Face(BlackStruss);
            f103.AddVertex(0.17428f, 0.36396f, 0.15965f);
            f103.AddVertex(0.14824f, 0.39570f, 0.15965f);
            f103.AddVertex(0.08037f, 0.32783f, 0.09999f);
            f103.AddVertex(0.09448f, 0.31064f, 0.09999f);
            faces.Add(f103);

            Face f104 = new Face(BlackStruss);
            f104.AddVertex(0.11650f, 0.42174f, 0.15965f);
            f104.AddVertex(0.08030f, 0.44109f, 0.15965f);
            f104.AddVertex(0.04357f, 0.35242f, 0.09999f);
            f104.AddVertex(0.06318f, 0.34194f, 0.09999f);
            faces.Add(f104);

            Face f105 = new Face(BlackStruss);
            f105.AddVertex(-0.14792f, 0.39570f, 0.15965f);
            f105.AddVertex(-0.17397f, 0.36396f, 0.15965f);
            f105.AddVertex(-0.09416f, 0.31064f, 0.09999f);
            f105.AddVertex(-0.08005f, 0.32783f, 0.09999f);
            faces.Add(f105);

            Face f106 = new Face(BlackStruss);
            f106.AddVertex(-0.14792f, 0.09953f, 0.15965f);
            f106.AddVertex(-0.11619f, 0.07348f, 0.15965f);
            f106.AddVertex(-0.06286f, 0.15329f, 0.09999f);
            f106.AddVertex(-0.08005f, 0.16739f, 0.09999f);
            faces.Add(f106);

            Face f107 = new Face(BlackStruss);
            f107.AddVertex(0.17428f, 0.13126f, 0.15965f);
            f107.AddVertex(0.19364f, 0.16747f, 0.15965f);
            f107.AddVertex(0.10496f, 0.20420f, 0.09999f);
            f107.AddVertex(0.09448f, 0.18459f, 0.09999f);
            faces.Add(f107);

            Face f108 = new Face(BlackStruss);
            f108.AddVertex(0.25409f, 0.07794f, 0.21931f);
            f108.AddVertex(0.28231f, 0.13074f, 0.21931f);
            f108.AddVertex(0.19364f, 0.16747f, 0.15965f);
            f108.AddVertex(0.17428f, 0.13126f, 0.15965f);
            faces.Add(f108);

            Face f109 = new Face(BlackStruss);
            f109.AddVertex(-0.21579f, 0.03166f, 0.21931f);
            f109.AddVertex(-0.16951f, -0.00631f, 0.21931f);
            f109.AddVertex(-0.11619f, 0.07348f, 0.15965f);
            f109.AddVertex(-0.14792f, 0.09953f, 0.15965f);
            faces.Add(f109);

            Face f110 = new Face(BlackStruss);
            f110.AddVertex(-0.21579f, 0.46356f, 0.21931f);
            f110.AddVertex(-0.25377f, 0.41728f, 0.21931f);
            f110.AddVertex(-0.17397f, 0.36396f, 0.15965f);
            f110.AddVertex(-0.14792f, 0.39570f, 0.15965f);
            faces.Add(f110);

            Face f111 = new Face(BlackStruss);
            f111.AddVertex(0.16983f, 0.50154f, 0.21931f);
            f111.AddVertex(0.11702f, 0.52977f, 0.21931f);
            f111.AddVertex(0.08030f, 0.44109f, 0.15965f);
            f111.AddVertex(0.11650f, 0.42174f, 0.15965f);
            faces.Add(f111);

            Face f112 = new Face(BlackStruss);
            f112.AddVertex(0.25409f, 0.41728f, 0.21931f);
            f112.AddVertex(0.21611f, 0.46356f, 0.21931f);
            f112.AddVertex(0.14824f, 0.39570f, 0.15965f);
            f112.AddVertex(0.17428f, 0.36396f, 0.15965f);
            faces.Add(f112);

            Face f113 = new Face(BlackStruss);
            f113.AddVertex(0.16983f, -0.00631f, 0.21931f);
            f113.AddVertex(0.21611f, 0.03166f, 0.21931f);
            f113.AddVertex(0.14824f, 0.09953f, 0.15965f);
            f113.AddVertex(0.11650f, 0.07348f, 0.15965f);
            faces.Add(f113);

            Face f114 = new Face(BlackStruss);
            f114.AddVertex(-0.28199f, 0.13074f, 0.21931f);
            f114.AddVertex(-0.25377f, 0.07794f, 0.21931f);
            f114.AddVertex(-0.17397f, 0.13126f, 0.15965f);
            f114.AddVertex(-0.19332f, 0.16747f, 0.15965f);
            faces.Add(f114);

            Face f115 = new Face(BlackStruss);
            f115.AddVertex(0.00015f, 0.55301f, 0.21931f);
            f115.AddVertex(-0.05942f, 0.54715f, 0.21931f);
            f115.AddVertex(-0.04069f, 0.45301f, 0.15965f);
            f115.AddVertex(0.00015f, 0.45704f, 0.15965f);
            faces.Add(f115);

            Face f116 = new Face(BlackStruss);
            f116.AddVertex(0.21611f, 0.03166f, 0.21931f);
            f116.AddVertex(0.25409f, 0.07794f, 0.21931f);
            f116.AddVertex(0.17428f, 0.13126f, 0.15965f);
            f116.AddVertex(0.14824f, 0.09953f, 0.15965f);
            faces.Add(f116);

            Face f117 = new Face(BlackStruss);
            f117.AddVertex(-0.16951f, -0.00631f, 0.21931f);
            f117.AddVertex(-0.11671f, -0.03453f, 0.21931f);
            f117.AddVertex(-0.07998f, 0.05413f, 0.15965f);
            f117.AddVertex(-0.11619f, 0.07348f, 0.15965f);
            faces.Add(f117);

            Face f118 = new Face(BlackStruss);
            f118.AddVertex(-0.29937f, 0.30719f, 0.21931f);
            f118.AddVertex(-0.30524f, 0.24761f, 0.21931f);
            f118.AddVertex(-0.20926f, 0.24761f, 0.15965f);
            f118.AddVertex(-0.20524f, 0.28847f, 0.15965f);
            faces.Add(f118);

            Face f119 = new Face(BlackStruss);
            f119.AddVertex(0.28231f, 0.36448f, 0.21931f);
            f119.AddVertex(0.25409f, 0.41728f, 0.21931f);
            f119.AddVertex(0.17428f, 0.36396f, 0.15965f);
            f119.AddVertex(0.19364f, 0.32776f, 0.15965f);
            faces.Add(f119);

            Face f120 = new Face(BlackStruss);
            f120.AddVertex(0.00015f, -0.05778f, 0.21931f);
            f120.AddVertex(0.05974f, -0.05191f, 0.21931f);
            f120.AddVertex(0.04101f, 0.04221f, 0.15965f);
            f120.AddVertex(0.00015f, 0.03819f, 0.15965f);
            faces.Add(f120);

            Face f121 = new Face(BlackStruss);
            f121.AddVertex(-0.05942f, 0.54715f, 0.21931f);
            f121.AddVertex(-0.11671f, 0.52977f, 0.21931f);
            f121.AddVertex(-0.07998f, 0.44109f, 0.15965f);
            f121.AddVertex(-0.04069f, 0.45301f, 0.15965f);
            faces.Add(f121);

            Face f122 = new Face(BlackStruss);
            f122.AddVertex(0.29969f, 0.18803f, 0.21931f);
            f122.AddVertex(0.30556f, 0.24761f, 0.21931f);
            f122.AddVertex(0.20958f, 0.24761f, 0.15965f);
            f122.AddVertex(0.20555f, 0.20676f, 0.15965f);
            faces.Add(f122);

            Face f123 = new Face(BlackStruss);
            f123.AddVertex(-0.28199f, 0.36448f, 0.21931f);
            f123.AddVertex(-0.29937f, 0.30719f, 0.21931f);
            f123.AddVertex(-0.20524f, 0.28847f, 0.15965f);
            f123.AddVertex(-0.19332f, 0.32776f, 0.15965f);
            faces.Add(f123);

            Face f124 = new Face(BlackStruss);
            f124.AddVertex(0.11702f, 0.52977f, 0.21931f);
            f124.AddVertex(0.05974f, 0.54715f, 0.21931f);
            f124.AddVertex(0.04101f, 0.45301f, 0.15965f);
            f124.AddVertex(0.08030f, 0.44109f, 0.15965f);
            faces.Add(f124);

            Face f125 = new Face(BlackStruss);
            f125.AddVertex(0.05974f, -0.05191f, 0.21931f);
            f125.AddVertex(0.11703f, -0.03453f, 0.21931f);
            f125.AddVertex(0.08030f, 0.05413f, 0.15965f);
            f125.AddVertex(0.04101f, 0.04221f, 0.15965f);
            faces.Add(f125);

            Face f126 = new Face(BlackStruss);
            f126.AddVertex(-0.29937f, 0.18803f, 0.21931f);
            f126.AddVertex(-0.28199f, 0.13074f, 0.21931f);
            f126.AddVertex(-0.19332f, 0.16747f, 0.15965f);
            f126.AddVertex(-0.20524f, 0.20676f, 0.15965f);
            faces.Add(f126);

            Face f127 = new Face(BlackStruss);
            f127.AddVertex(0.28231f, 0.13074f, 0.21931f);
            f127.AddVertex(0.29969f, 0.18803f, 0.21931f);
            f127.AddVertex(0.20555f, 0.20676f, 0.15965f);
            f127.AddVertex(0.19364f, 0.16747f, 0.15965f);
            faces.Add(f127);

            Face f128 = new Face(BlackStruss);
            f128.AddVertex(-0.11671f, -0.03453f, 0.21931f);
            f128.AddVertex(-0.05942f, -0.05191f, 0.21931f);
            f128.AddVertex(-0.04069f, 0.04221f, 0.15965f);
            f128.AddVertex(-0.07998f, 0.05413f, 0.15965f);
            faces.Add(f128);

            Face f129 = new Face(BlackStruss);
            f129.AddVertex(0.05974f, 0.54715f, 0.21931f);
            f129.AddVertex(0.00015f, 0.55301f, 0.21931f);
            f129.AddVertex(0.00015f, 0.45704f, 0.15965f);
            f129.AddVertex(0.04101f, 0.45301f, 0.15965f);
            faces.Add(f129);

            Face f130 = new Face(BlackStruss);
            f130.AddVertex(0.29969f, 0.30719f, 0.21931f);
            f130.AddVertex(0.28231f, 0.36448f, 0.21931f);
            f130.AddVertex(0.19364f, 0.32776f, 0.15965f);
            f130.AddVertex(0.20555f, 0.28847f, 0.15965f);
            faces.Add(f130);

            Face f131 = new Face(BlackStruss);
            f131.AddVertex(-0.30524f, 0.24761f, 0.21931f);
            f131.AddVertex(-0.29937f, 0.18803f, 0.21931f);
            f131.AddVertex(-0.20524f, 0.20676f, 0.15965f);
            f131.AddVertex(-0.20926f, 0.24761f, 0.15965f);
            faces.Add(f131);

            Face f132 = new Face(BlackStruss);
            f132.AddVertex(-0.11671f, 0.52977f, 0.21931f);
            f132.AddVertex(-0.16951f, 0.50154f, 0.21931f);
            f132.AddVertex(-0.11619f, 0.42174f, 0.15965f);
            f132.AddVertex(-0.07998f, 0.44109f, 0.15965f);
            faces.Add(f132);

            Face f133 = new Face(BlackStruss);
            f133.AddVertex(-0.05942f, -0.05191f, 0.21931f);
            f133.AddVertex(0.00015f, -0.05778f, 0.21931f);
            f133.AddVertex(0.00015f, 0.03819f, 0.15965f);
            f133.AddVertex(-0.04069f, 0.04221f, 0.15965f);
            faces.Add(f133);

            Face f134 = new Face(BlackStruss);
            f134.AddVertex(-0.25377f, 0.41728f, 0.21931f);
            f134.AddVertex(-0.28199f, 0.36448f, 0.21931f);
            f134.AddVertex(-0.19332f, 0.32776f, 0.15965f);
            f134.AddVertex(-0.17397f, 0.36396f, 0.15965f);
            faces.Add(f134);

            Face f135 = new Face(BlackStruss);
            f135.AddVertex(0.21611f, 0.46356f, 0.21931f);
            f135.AddVertex(0.16983f, 0.50154f, 0.21931f);
            f135.AddVertex(0.11650f, 0.42174f, 0.15965f);
            f135.AddVertex(0.14824f, 0.39570f, 0.15965f);
            faces.Add(f135);

            Face f136 = new Face(BlackStruss);
            f136.AddVertex(0.30556f, 0.24761f, 0.21931f);
            f136.AddVertex(0.29969f, 0.30719f, 0.21931f);
            f136.AddVertex(0.20555f, 0.28847f, 0.15965f);
            f136.AddVertex(0.20958f, 0.24761f, 0.15965f);
            faces.Add(f136);

            Face f137 = new Face(BlackStruss);
            f137.AddVertex(0.11703f, -0.03453f, 0.21931f);
            f137.AddVertex(0.16983f, -0.00631f, 0.21931f);
            f137.AddVertex(0.11650f, 0.07348f, 0.15965f);
            f137.AddVertex(0.08030f, 0.05413f, 0.15965f);
            faces.Add(f137);

            Face f138 = new Face(BlackStruss);
            f138.AddVertex(-0.25377f, 0.07794f, 0.21931f);
            f138.AddVertex(-0.21579f, 0.03166f, 0.21931f);
            f138.AddVertex(-0.14792f, 0.09953f, 0.15965f);
            f138.AddVertex(-0.17397f, 0.13126f, 0.15965f);
            faces.Add(f138);

            Face f139 = new Face(BlackStruss);
            f139.AddVertex(-0.16951f, 0.50154f, 0.21931f);
            f139.AddVertex(-0.21579f, 0.46356f, 0.21931f);
            f139.AddVertex(-0.14792f, 0.39570f, 0.15965f);
            f139.AddVertex(-0.11619f, 0.42174f, 0.15965f);
            faces.Add(f139);

            Face f140 = new Face(BlackStruss);
            f140.AddVertex(-0.38868f, 0.64291f, -0.33235f);
            f140.AddVertex(-0.38868f, 0.91527f, -0.33235f);
            f140.AddVertex(0.38900f, 0.91527f, -0.33235f);
            f140.AddVertex(0.38900f, 0.64291f, -0.33235f);
            faces.Add(f140);

            Face f141 = new Face(BlackStruss);
            f141.AddVertex(-0.38868f, -0.11573f, -0.33235f);
            f141.AddVertex(-0.38868f, 0.64291f, -0.33235f);
            f141.AddVertex(0.38900f, 0.64291f, -0.33235f);
            f141.AddVertex(0.38900f, -0.11573f, -0.33235f);
            faces.Add(f141);

            Face f142 = new Face(BlackStruss);
            f142.AddVertex(0.12002f, 0.74220f, -0.11801f);
            f142.AddVertex(0.12002f, 0.84793f, -0.11801f);
            f142.AddVertex(0.10101f, 0.83700f, -0.17919f);
            f142.AddVertex(0.10101f, 0.75312f, -0.17919f);
            faces.Add(f142);

            Face f143 = new Face(BlackStruss);
            f143.AddVertex(-0.11970f, 0.84793f, -0.11801f);
            f143.AddVertex(-0.11970f, 0.74220f, -0.11801f);
            f143.AddVertex(-0.10069f, 0.75312f, -0.17919f);
            f143.AddVertex(-0.10069f, 0.83700f, -0.17919f);
            faces.Add(f143);

            Face f144 = new Face(BlackStruss);
            f144.AddVertex(-0.11970f, 0.74220f, -0.11801f);
            f144.AddVertex(0.12002f, 0.74220f, -0.11801f);
            f144.AddVertex(0.10101f, 0.75312f, -0.17919f);
            f144.AddVertex(-0.10069f, 0.75312f, -0.17919f);
            faces.Add(f144);

            Face f145 = new Face(BlackStruss);
            f145.AddVertex(0.12002f, 0.84793f, -0.11801f);
            f145.AddVertex(-0.11970f, 0.84793f, -0.11801f);
            f145.AddVertex(-0.10069f, 0.83700f, -0.17919f);
            f145.AddVertex(0.10101f, 0.83700f, -0.17919f);
            faces.Add(f145);

            Face f146 = new Face(BlackStruss);
            f146.AddVertex(0.33202f, 0.90590f, 0.24910f);
            f146.AddVertex(-0.33170f, 0.90590f, 0.24910f);
            f146.AddVertex(-0.28680f, 0.90590f, 0.18791f);
            f146.AddVertex(0.28712f, 0.90590f, 0.18791f);
            faces.Add(f146);

            Face f147 = new Face(BlackStruss);
            f147.AddVertex(0.28712f, 0.90590f, 0.18791f);
            f147.AddVertex(-0.28680f, 0.90590f, 0.18791f);
            f147.AddVertex(-0.23247f, 0.90590f, 0.12673f);
            f147.AddVertex(0.23279f, 0.90590f, 0.12673f);
            faces.Add(f147);

            Face f148 = new Face(BlackStruss);
            f148.AddVertex(0.23279f, 0.90590f, 0.12673f);
            f148.AddVertex(-0.23247f, 0.90590f, 0.12673f);
            f148.AddVertex(-0.18400f, 0.90590f, 0.06554f);
            f148.AddVertex(0.18432f, 0.90590f, 0.06554f);
            faces.Add(f148);

            Face f149 = new Face(BlackStruss);
            f149.AddVertex(0.18432f, 0.90590f, 0.06554f);
            f149.AddVertex(-0.18400f, 0.90590f, 0.06554f);
            f149.AddVertex(-0.15069f, 0.89501f, 0.00436f);
            f149.AddVertex(0.15101f, 0.89501f, 0.00436f);
            faces.Add(f149);

            Face f150 = new Face(BlackStruss);
            f150.AddVertex(0.15101f, 0.89501f, 0.00436f);
            f150.AddVertex(-0.15069f, 0.89501f, 0.00436f);
            f150.AddVertex(-0.13320f, 0.87126f, -0.05682f);
            f150.AddVertex(0.13352f, 0.87126f, -0.05682f);
            faces.Add(f150);

            Face f151 = new Face(BlackStruss);
            f151.AddVertex(0.13352f, 0.87126f, -0.05682f);
            f151.AddVertex(-0.13320f, 0.87126f, -0.05682f);
            f151.AddVertex(-0.11970f, 0.84793f, -0.11801f);
            f151.AddVertex(0.12002f, 0.84793f, -0.11801f);
            faces.Add(f151);

            Face f152 = new Face(BlackStruss);
            f152.AddVertex(-0.33170f, 0.68422f, 0.24910f);
            f152.AddVertex(0.33202f, 0.68422f, 0.24910f);
            f152.AddVertex(0.28712f, 0.68422f, 0.18791f);
            f152.AddVertex(-0.28680f, 0.68422f, 0.18791f);
            faces.Add(f152);

            Face f153 = new Face(BlackStruss);
            f153.AddVertex(-0.28680f, 0.68422f, 0.18791f);
            f153.AddVertex(0.28712f, 0.68422f, 0.18791f);
            f153.AddVertex(0.23279f, 0.68422f, 0.12673f);
            f153.AddVertex(-0.23247f, 0.68422f, 0.12673f);
            faces.Add(f153);

            Face f154 = new Face(BlackStruss);
            f154.AddVertex(-0.23247f, 0.68422f, 0.12673f);
            f154.AddVertex(0.23279f, 0.68422f, 0.12673f);
            f154.AddVertex(0.18432f, 0.68422f, 0.06554f);
            f154.AddVertex(-0.18400f, 0.68422f, 0.06554f);
            faces.Add(f154);

            Face f155 = new Face(BlackStruss);
            f155.AddVertex(-0.18400f, 0.68422f, 0.06554f);
            f155.AddVertex(0.18432f, 0.68422f, 0.06554f);
            f155.AddVertex(0.15101f, 0.69511f, 0.00436f);
            f155.AddVertex(-0.15069f, 0.69511f, 0.00436f);
            faces.Add(f155);

            Face f156 = new Face(BlackStruss);
            f156.AddVertex(-0.15069f, 0.69511f, 0.00436f);
            f156.AddVertex(0.15101f, 0.69511f, 0.00436f);
            f156.AddVertex(0.13352f, 0.71887f, -0.05682f);
            f156.AddVertex(-0.13320f, 0.71887f, -0.05682f);
            faces.Add(f156);

            Face f157 = new Face(BlackStruss);
            f157.AddVertex(-0.13320f, 0.71887f, -0.05682f);
            f157.AddVertex(0.13352f, 0.71887f, -0.05682f);
            f157.AddVertex(0.12002f, 0.74220f, -0.11801f);
            f157.AddVertex(-0.11970f, 0.74220f, -0.11801f);
            faces.Add(f157);

            Face f158 = new Face(BlackStruss);
            f158.AddVertex(-0.33170f, 0.90590f, 0.24910f);
            f158.AddVertex(-0.33170f, 0.68422f, 0.24910f);
            f158.AddVertex(-0.28680f, 0.68422f, 0.18791f);
            f158.AddVertex(-0.28680f, 0.90590f, 0.18791f);
            faces.Add(f158);

            Face f159 = new Face(BlackStruss);
            f159.AddVertex(-0.28680f, 0.90590f, 0.18791f);
            f159.AddVertex(-0.28680f, 0.68422f, 0.18791f);
            f159.AddVertex(-0.23247f, 0.68422f, 0.12673f);
            f159.AddVertex(-0.23247f, 0.90590f, 0.12673f);
            faces.Add(f159);

            Face f160 = new Face(BlackStruss);
            f160.AddVertex(-0.23247f, 0.90590f, 0.12673f);
            f160.AddVertex(-0.23247f, 0.68422f, 0.12673f);
            f160.AddVertex(-0.18400f, 0.68422f, 0.06554f);
            f160.AddVertex(-0.18400f, 0.90590f, 0.06554f);
            faces.Add(f160);

            Face f161 = new Face(BlackStruss);
            f161.AddVertex(-0.18400f, 0.90590f, 0.06554f);
            f161.AddVertex(-0.18400f, 0.68422f, 0.06554f);
            f161.AddVertex(-0.15069f, 0.69511f, 0.00436f);
            f161.AddVertex(-0.15069f, 0.89501f, 0.00436f);
            faces.Add(f161);

            Face f162 = new Face(BlackStruss);
            f162.AddVertex(-0.15069f, 0.89501f, 0.00436f);
            f162.AddVertex(-0.15069f, 0.69511f, 0.00436f);
            f162.AddVertex(-0.13320f, 0.71887f, -0.05682f);
            f162.AddVertex(-0.13320f, 0.87126f, -0.05682f);
            faces.Add(f162);

            Face f163 = new Face(BlackStruss);
            f163.AddVertex(-0.13320f, 0.87126f, -0.05682f);
            f163.AddVertex(-0.13320f, 0.71887f, -0.05682f);
            f163.AddVertex(-0.11970f, 0.74220f, -0.11801f);
            f163.AddVertex(-0.11970f, 0.84793f, -0.11801f);
            faces.Add(f163);

            Face f164 = new Face(BlackStruss);
            f164.AddVertex(0.33202f, 0.68422f, 0.24910f);
            f164.AddVertex(0.33202f, 0.90590f, 0.24910f);
            f164.AddVertex(0.28712f, 0.90590f, 0.18791f);
            f164.AddVertex(0.28712f, 0.68422f, 0.18791f);
            faces.Add(f164);

            Face f165 = new Face(BlackStruss);
            f165.AddVertex(0.28712f, 0.68422f, 0.18791f);
            f165.AddVertex(0.28712f, 0.90590f, 0.18791f);
            f165.AddVertex(0.23279f, 0.90590f, 0.12673f);
            f165.AddVertex(0.23279f, 0.68422f, 0.12673f);
            faces.Add(f165);

            Face f166 = new Face(BlackStruss);
            f166.AddVertex(0.23279f, 0.68422f, 0.12673f);
            f166.AddVertex(0.23279f, 0.90590f, 0.12673f);
            f166.AddVertex(0.18432f, 0.90590f, 0.06554f);
            f166.AddVertex(0.18432f, 0.68422f, 0.06554f);
            faces.Add(f166);

            Face f167 = new Face(BlackStruss);
            f167.AddVertex(0.18432f, 0.68422f, 0.06554f);
            f167.AddVertex(0.18432f, 0.90590f, 0.06554f);
            f167.AddVertex(0.15101f, 0.89501f, 0.00436f);
            f167.AddVertex(0.15101f, 0.69511f, 0.00436f);
            faces.Add(f167);

            Face f168 = new Face(BlackStruss);
            f168.AddVertex(0.15101f, 0.69511f, 0.00436f);
            f168.AddVertex(0.15101f, 0.89501f, 0.00436f);
            f168.AddVertex(0.13352f, 0.87126f, -0.05682f);
            f168.AddVertex(0.13352f, 0.71887f, -0.05682f);
            faces.Add(f168);

            Face f169 = new Face(BlackStruss);
            f169.AddVertex(0.13352f, 0.71887f, -0.05682f);
            f169.AddVertex(0.13352f, 0.87126f, -0.05682f);
            f169.AddVertex(0.12002f, 0.84793f, -0.11801f);
            f169.AddVertex(0.12002f, 0.74220f, -0.11801f);
            faces.Add(f169);

            Face f170 = new Face(BlackStruss);
            f170.AddVertex(-0.10069f, 0.75312f, -0.17919f);
            f170.AddVertex(0.10101f, 0.75312f, -0.17919f);
            f170.AddVertex(0.10101f, 0.83700f, -0.17919f);
            f170.AddVertex(-0.10069f, 0.83700f, -0.17919f);
            faces.Add(f170);

            Face f171 = new Face(BlackStruss);
            f171.AddVertex(0.43053f, 0.42434f, 0.01738f);
            f171.AddVertex(0.43053f, 0.42434f, -0.14785f);
            f171.AddVertex(0.39526f, 0.50507f, -0.14785f);
            f171.AddVertex(0.39526f, 0.50507f, 0.01738f);
            faces.Add(f171);

            Face f172 = new Face(BlackStruss);
            f172.AddVertex(0.42094f, 0.41820f, -0.15399f);
            f172.AddVertex(0.43053f, 0.41820f, -0.15399f);
            f172.AddVertex(0.43053f, 0.41820f, 0.02351f);
            f172.AddVertex(0.42094f, 0.41820f, 0.02351f);
            faces.Add(f172);

            Face f173 = new Face(BlackStruss);
            f173.AddVertex(0.42094f, 0.51120f, -0.15399f);
            f173.AddVertex(0.43053f, 0.51120f, -0.15399f);
            f173.AddVertex(0.43053f, 0.41820f, -0.15399f);
            f173.AddVertex(0.42094f, 0.41820f, -0.15399f);
            faces.Add(f173);

            Face f174 = new Face(BlackStruss);
            f174.AddVertex(0.42094f, 0.51120f, 0.02351f);
            f174.AddVertex(0.43053f, 0.51120f, 0.02351f);
            f174.AddVertex(0.43053f, 0.51120f, -0.15399f);
            f174.AddVertex(0.42094f, 0.51120f, -0.15399f);
            faces.Add(f174);

            Face f175 = new Face(BlackStruss);
            f175.AddVertex(0.42094f, 0.41820f, 0.02351f);
            f175.AddVertex(0.43053f, 0.41820f, 0.02351f);
            f175.AddVertex(0.43053f, 0.51120f, 0.02351f);
            f175.AddVertex(0.42094f, 0.51120f, 0.02351f);
            faces.Add(f175);

            Face f176 = new Face(BlackStruss);
            f176.AddVertex(-0.43021f, 0.42397f, -0.14871f);
            f176.AddVertex(-0.43021f, 0.42397f, 0.01823f);
            f176.AddVertex(-0.40174f, 0.50523f, 0.01823f);
            f176.AddVertex(-0.40174f, 0.50523f, -0.14871f);
            faces.Add(f176);

            Face f177 = new Face(BlackStruss);
            f177.AddVertex(-0.42062f, 0.51136f, 0.02436f);
            f177.AddVertex(-0.43021f, 0.51136f, 0.02436f);
            f177.AddVertex(-0.43021f, 0.41783f, 0.02436f);
            f177.AddVertex(-0.42062f, 0.41783f, 0.02436f);
            faces.Add(f177);

            Face f178 = new Face(BlackStruss);
            f178.AddVertex(-0.42062f, 0.41783f, -0.15484f);
            f178.AddVertex(-0.43021f, 0.41783f, -0.15484f);
            f178.AddVertex(-0.43021f, 0.51136f, -0.15484f);
            f178.AddVertex(-0.42062f, 0.51136f, -0.15484f);
            faces.Add(f178);

            Face f179 = new Face(BlackStruss);
            f179.AddVertex(0.43053f, 0.42434f, -0.14785f);
            f179.AddVertex(0.43053f, 0.42434f, 0.01738f);
            f179.AddVertex(0.43053f, 0.41820f, 0.02351f);
            f179.AddVertex(0.43053f, 0.41820f, -0.15399f);
            faces.Add(f179);

            Face f180 = new Face(BlackStruss);
            f180.AddVertex(0.43053f, 0.50507f, -0.14785f);
            f180.AddVertex(0.43053f, 0.42434f, -0.14785f);
            f180.AddVertex(0.43053f, 0.41820f, -0.15399f);
            f180.AddVertex(0.43053f, 0.51120f, -0.15399f);
            faces.Add(f180);

            Face f181 = new Face(BlackStruss);
            f181.AddVertex(0.43053f, 0.50507f, 0.01738f);
            f181.AddVertex(0.43053f, 0.50507f, -0.14785f);
            f181.AddVertex(0.43053f, 0.51120f, -0.15399f);
            f181.AddVertex(0.43053f, 0.51120f, 0.02351f);
            faces.Add(f181);

            Face f182 = new Face(BlackStruss);
            f182.AddVertex(0.43053f, 0.42434f, 0.01738f);
            f182.AddVertex(0.43053f, 0.50507f, 0.01738f);
            f182.AddVertex(0.43053f, 0.51120f, 0.02351f);
            f182.AddVertex(0.43053f, 0.41820f, 0.02351f);
            faces.Add(f182);

            Face f183 = new Face(BlackStruss);
            f183.AddVertex(-0.43021f, 0.42397f, 0.01823f);
            f183.AddVertex(-0.43021f, 0.42397f, -0.14871f);
            f183.AddVertex(-0.43021f, 0.41783f, -0.15484f);
            f183.AddVertex(-0.43021f, 0.41783f, 0.02436f);
            faces.Add(f183);

            Face f184 = new Face(BlackStruss);
            f184.AddVertex(-0.43021f, 0.50523f, 0.01823f);
            f184.AddVertex(-0.43021f, 0.42397f, 0.01823f);
            f184.AddVertex(-0.43021f, 0.41783f, 0.02436f);
            f184.AddVertex(-0.43021f, 0.51136f, 0.02436f);
            faces.Add(f184);

            Face f185 = new Face(BlackStruss);
            f185.AddVertex(-0.43021f, 0.50523f, -0.14871f);
            f185.AddVertex(-0.43021f, 0.50523f, 0.01823f);
            f185.AddVertex(-0.43021f, 0.51136f, 0.02436f);
            f185.AddVertex(-0.43021f, 0.51136f, -0.15484f);
            faces.Add(f185);

            Face f186 = new Face(BlackStruss);
            f186.AddVertex(-0.43021f, 0.42397f, -0.14871f);
            f186.AddVertex(-0.43021f, 0.50523f, -0.14871f);
            f186.AddVertex(-0.43021f, 0.51136f, -0.15484f);
            f186.AddVertex(-0.43021f, 0.41783f, -0.15484f);
            faces.Add(f186);

            Face f187 = new Face(BlackStruss);
            f187.AddVertex(0.43053f, 0.42434f, -0.14785f);
            f187.AddVertex(0.43053f, 0.50507f, -0.14785f);
            f187.AddVertex(0.39526f, 0.50507f, -0.14785f);
            faces.Add(f187);

            Face f188 = new Face(BlackStruss);
            f188.AddVertex(0.43053f, 0.50507f, 0.01738f);
            f188.AddVertex(0.39526f, 0.50507f, 0.01738f);
            f188.AddVertex(0.39526f, 0.50507f, -0.14785f);
            f188.AddVertex(0.43053f, 0.50507f, -0.14785f);
            faces.Add(f188);

            Face f189 = new Face(BlackStruss);
            f189.AddVertex(0.43053f, 0.50507f, 0.01738f);
            f189.AddVertex(0.43053f, 0.42434f, 0.01738f);
            f189.AddVertex(0.39526f, 0.50507f, 0.01738f);
            faces.Add(f189);

            Face f190 = new Face(BlackStruss);
            f190.AddVertex(-0.43021f, 0.42397f, 0.01823f);
            f190.AddVertex(-0.43021f, 0.50523f, 0.01823f);
            f190.AddVertex(-0.40174f, 0.50523f, 0.01823f);
            faces.Add(f190);

            Face f191 = new Face(BlackStruss);
            f191.AddVertex(-0.43021f, 0.50523f, -0.14871f);
            f191.AddVertex(-0.40174f, 0.50523f, -0.14871f);
            f191.AddVertex(-0.40174f, 0.50523f, 0.01823f);
            f191.AddVertex(-0.43021f, 0.50523f, 0.01823f);
            faces.Add(f191);

            Face f192 = new Face(Material014);
            f192.AddVertex(-0.43021f, 0.50523f, -0.14871f);
            f192.AddVertex(-0.43021f, 0.42397f, -0.14871f);
            f192.AddVertex(-0.40174f, 0.50523f, -0.14871f);
            faces.Add(f192);

            Face f193 = new Face(Material014);
            f193.AddVertex(-0.29937f, 0.30719f, 0.21931f);
            f193.AddVertex(-0.28199f, 0.36448f, 0.21931f);
            f193.AddVertex(-0.28199f, 0.36448f, 0.23933f);
            f193.AddVertex(-0.29937f, 0.30719f, 0.23933f);
            faces.Add(f193);

            Face f194 = new Face(Material014);
            f194.AddVertex(-0.12554f, -0.05585f, 0.21931f);
            f194.AddVertex(-0.06392f, -0.07454f, 0.21931f);
            f194.AddVertex(-0.06392f, -0.07454f, 0.23933f);
            f194.AddVertex(-0.12554f, -0.05585f, 0.23933f);
            faces.Add(f194);

            Face f195 = new Face(Material014);
            f195.AddVertex(0.11703f, -0.03453f, 0.21931f);
            f195.AddVertex(0.05974f, -0.05191f, 0.21931f);
            f195.AddVertex(0.05974f, -0.05191f, 0.23933f);
            f195.AddVertex(0.11703f, -0.03453f, 0.23933f);
            faces.Add(f195);

            Face f196 = new Face(Material014);
            f196.AddVertex(0.32232f, 0.31169f, 0.21931f);
            f196.AddVertex(0.30362f, 0.37331f, 0.21931f);
            f196.AddVertex(0.30362f, 0.37331f, 0.23933f);
            f196.AddVertex(0.32232f, 0.31169f, 0.23933f);
            faces.Add(f196);

            Face f197 = new Face(Material014);
            f197.AddVertex(0.29969f, 0.18803f, 0.21931f);
            f197.AddVertex(0.28231f, 0.13074f, 0.21931f);
            f197.AddVertex(0.28231f, 0.13074f, 0.23933f);
            f197.AddVertex(0.29969f, 0.18803f, 0.23933f);
            faces.Add(f197);

            Face f198 = new Face(Material014);
            f198.AddVertex(-0.12526f, 0.55108f, 0.21931f);
            f198.AddVertex(-0.18219f, 0.52073f, 0.21931f);
            f198.AddVertex(-0.18233f, 0.52073f, 0.23933f);
            f198.AddVertex(-0.12554f, 0.55108f, 0.23933f);
            faces.Add(f198);

            Face f199 = new Face(Material014);
            f199.AddVertex(0.00015f, 0.55301f, 0.21931f);
            f199.AddVertex(0.05974f, 0.54715f, 0.21931f);
            f199.AddVertex(0.05974f, 0.54715f, 0.23933f);
            f199.AddVertex(0.00015f, 0.55301f, 0.23933f);
            faces.Add(f199);

            Face f200 = new Face(Material014);
            f200.AddVertex(-0.27295f, 0.43010f, 0.21931f);
            f200.AddVertex(-0.30330f, 0.37331f, 0.21931f);
            f200.AddVertex(-0.30330f, 0.37331f, 0.23933f);
            f200.AddVertex(-0.27295f, 0.43010f, 0.23933f);
            faces.Add(f200);

            Face f201 = new Face(Material014);
            f201.AddVertex(-0.29937f, 0.18803f, 0.21931f);
            f201.AddVertex(-0.30524f, 0.24761f, 0.21931f);
            f201.AddVertex(-0.30524f, 0.24761f, 0.23933f);
            f201.AddVertex(-0.29937f, 0.18803f, 0.23933f);
            faces.Add(f201);

            Face f202 = new Face(Material014);
            f202.AddVertex(0.12586f, -0.05585f, 0.21931f);
            f202.AddVertex(0.18264f, -0.02549f, 0.21931f);
            f202.AddVertex(0.18264f, -0.02549f, 0.23933f);
            f202.AddVertex(0.12586f, -0.05585f, 0.23933f);
            faces.Add(f202);

            Face f203 = new Face(Material014);
            f203.AddVertex(0.00015f, -0.05778f, 0.21931f);
            f203.AddVertex(-0.05942f, -0.05191f, 0.21931f);
            f203.AddVertex(-0.05942f, -0.05191f, 0.23933f);
            f203.AddVertex(0.00015f, -0.05778f, 0.23933f);
            faces.Add(f203);

            Face f204 = new Face(Material014);
            f204.AddVertex(0.16983f, 0.50154f, 0.21931f);
            f204.AddVertex(0.21611f, 0.46356f, 0.21931f);
            f204.AddVertex(0.21611f, 0.46356f, 0.23933f);
            f204.AddVertex(0.16983f, 0.50154f, 0.23933f);
            faces.Add(f204);

            Face f205 = new Face(Material014);
            f205.AddVertex(0.27327f, 0.06512f, 0.21931f);
            f205.AddVertex(0.30362f, 0.12191f, 0.21931f);
            f205.AddVertex(0.30362f, 0.12191f, 0.23933f);
            f205.AddVertex(0.27327f, 0.06512f, 0.23933f);
            faces.Add(f205);

            Face f206 = new Face(Material014);
            f206.AddVertex(0.29969f, 0.30719f, 0.21931f);
            f206.AddVertex(0.30556f, 0.24761f, 0.21931f);
            f206.AddVertex(0.30556f, 0.24761f, 0.23933f);
            f206.AddVertex(0.29969f, 0.30719f, 0.23933f);
            faces.Add(f206);

            Face f207 = new Face(Material014);
            f207.AddVertex(-0.21579f, 0.03166f, 0.21931f);
            f207.AddVertex(-0.25377f, 0.07794f, 0.21931f);
            f207.AddVertex(-0.25377f, 0.07794f, 0.23933f);
            f207.AddVertex(-0.21579f, 0.03166f, 0.23933f);
            faces.Add(f207);

            Face f208 = new Face(Material014);
            f208.AddVertex(0.18251f, 0.52073f, 0.21931f);
            f208.AddVertex(0.12558f, 0.55108f, 0.21931f);
            f208.AddVertex(0.12586f, 0.55108f, 0.23933f);
            f208.AddVertex(0.18264f, 0.52073f, 0.23933f);
            faces.Add(f208);

            Face f209 = new Face(Material014);
            f209.AddVertex(-0.21579f, 0.46356f, 0.21931f);
            f209.AddVertex(-0.16951f, 0.50154f, 0.21931f);
            f209.AddVertex(-0.16951f, 0.50154f, 0.23933f);
            f209.AddVertex(-0.21579f, 0.46356f, 0.23933f);
            faces.Add(f209);

            Face f210 = new Face(Material014);
            f210.AddVertex(-0.16951f, -0.00631f, 0.21931f);
            f210.AddVertex(-0.21579f, 0.03166f, 0.21931f);
            f210.AddVertex(-0.21579f, 0.03166f, 0.23933f);
            f210.AddVertex(-0.16951f, -0.00631f, 0.23933f);
            faces.Add(f210);

            Face f211 = new Face(Material014);
            f211.AddVertex(-0.30330f, 0.12191f, 0.21931f);
            f211.AddVertex(-0.27295f, 0.06512f, 0.21931f);
            f211.AddVertex(-0.27295f, 0.06512f, 0.23933f);
            f211.AddVertex(-0.30330f, 0.12191f, 0.23933f);
            faces.Add(f211);

            Face f212 = new Face(Material014);
            f212.AddVertex(-0.25377f, 0.41728f, 0.21931f);
            f212.AddVertex(-0.21579f, 0.46356f, 0.21931f);
            f212.AddVertex(-0.21579f, 0.46356f, 0.23933f);
            f212.AddVertex(-0.25377f, 0.41728f, 0.23933f);
            faces.Add(f212);

            Face f213 = new Face(Material014);
            f213.AddVertex(0.21611f, 0.46356f, 0.21931f);
            f213.AddVertex(0.25409f, 0.41728f, 0.21931f);
            f213.AddVertex(0.25409f, 0.41728f, 0.23933f);
            f213.AddVertex(0.21611f, 0.46356f, 0.23933f);
            faces.Add(f213);

            Face f214 = new Face(Material014);
            f214.AddVertex(-0.18233f, -0.02549f, 0.21931f);
            f214.AddVertex(-0.12554f, -0.05585f, 0.21931f);
            f214.AddVertex(-0.12554f, -0.05585f, 0.23933f);
            f214.AddVertex(-0.18233f, -0.02549f, 0.23933f);
            faces.Add(f214);

            Face f215 = new Face(Material014);
            f215.AddVertex(0.21611f, 0.03166f, 0.21931f);
            f215.AddVertex(0.16983f, -0.00631f, 0.21931f);
            f215.AddVertex(0.16983f, -0.00631f, 0.23933f);
            f215.AddVertex(0.21611f, 0.03166f, 0.23933f);
            faces.Add(f215);

            Face f216 = new Face(Material014);
            f216.AddVertex(-0.05942f, 0.54715f, 0.21931f);
            f216.AddVertex(0.00015f, 0.55301f, 0.21931f);
            f216.AddVertex(0.00015f, 0.55301f, 0.23933f);
            f216.AddVertex(-0.05942f, 0.54715f, 0.23933f);
            faces.Add(f216);

            Face f217 = new Face(Material014);
            f217.AddVertex(0.30362f, 0.37331f, 0.21931f);
            f217.AddVertex(0.27327f, 0.43010f, 0.21931f);
            f217.AddVertex(0.27327f, 0.43010f, 0.23933f);
            f217.AddVertex(0.30362f, 0.37331f, 0.23933f);
            faces.Add(f217);

            Face f218 = new Face(Material014);
            f218.AddVertex(0.25409f, 0.07794f, 0.21931f);
            f218.AddVertex(0.21611f, 0.03166f, 0.21931f);
            f218.AddVertex(0.21611f, 0.03166f, 0.23933f);
            f218.AddVertex(0.25409f, 0.07794f, 0.23933f);
            faces.Add(f218);

            Face f219 = new Face(Material014);
            f219.AddVertex(-0.30524f, 0.24761f, 0.21931f);
            f219.AddVertex(-0.29937f, 0.30719f, 0.21931f);
            f219.AddVertex(-0.29937f, 0.30719f, 0.23933f);
            f219.AddVertex(-0.30524f, 0.24761f, 0.23933f);
            faces.Add(f219);

            Face f220 = new Face(Material014);
            f220.AddVertex(-0.06392f, 0.56977f, 0.21931f);
            f220.AddVertex(-0.12526f, 0.55108f, 0.21931f);
            f220.AddVertex(-0.12554f, 0.55108f, 0.23933f);
            f220.AddVertex(-0.06392f, 0.56977f, 0.23933f);
            faces.Add(f220);

            Face f221 = new Face(Material014);
            f221.AddVertex(0.05974f, -0.05191f, 0.21931f);
            f221.AddVertex(0.00015f, -0.05778f, 0.21931f);
            f221.AddVertex(0.00015f, -0.05778f, 0.23933f);
            f221.AddVertex(0.05974f, -0.05191f, 0.23933f);
            faces.Add(f221);

            Face f222 = new Face(Material014);
            f222.AddVertex(-0.30330f, 0.37331f, 0.21931f);
            f222.AddVertex(-0.32200f, 0.31169f, 0.21931f);
            f222.AddVertex(-0.32200f, 0.31169f, 0.23933f);
            f222.AddVertex(-0.30330f, 0.37331f, 0.23933f);
            faces.Add(f222);

            Face f223 = new Face(Material014);
            f223.AddVertex(0.30556f, 0.24761f, 0.21931f);
            f223.AddVertex(0.29969f, 0.18803f, 0.21931f);
            f223.AddVertex(0.29969f, 0.18803f, 0.23933f);
            f223.AddVertex(0.30556f, 0.24761f, 0.23933f);
            faces.Add(f223);

            Face f224 = new Face(Material014);
            f224.AddVertex(0.06424f, -0.07454f, 0.21931f);
            f224.AddVertex(0.12586f, -0.05585f, 0.21931f);
            f224.AddVertex(0.12586f, -0.05585f, 0.23933f);
            f224.AddVertex(0.06424f, -0.07454f, 0.23933f);
            faces.Add(f224);

            Face f225 = new Face(Material014);
            f225.AddVertex(0.11360f, 0.24761f, 0.09999f);
            f225.AddVertex(0.10408f, 0.22792f, 0.11305f);
            f225.AddVertex(0.10496f, 0.20420f, 0.09999f);
            f225.AddVertex(0.11142f, 0.22548f, 0.09999f);
            faces.Add(f225);

            Face f226 = new Face(Material014);
            f226.AddVertex(0.10408f, 0.22792f, 0.11305f);
            f226.AddVertex(0.08967f, 0.20838f, 0.12066f);
            f226.AddVertex(0.09448f, 0.18459f, 0.09999f);
            f226.AddVertex(0.10496f, 0.20420f, 0.09999f);
            faces.Add(f226);

            Face f227 = new Face(Material014);
            f227.AddVertex(0.08967f, 0.20838f, 0.12066f);
            f227.AddVertex(0.07119f, 0.18994f, 0.12472f);
            f227.AddVertex(0.08037f, 0.16739f, 0.09999f);
            f227.AddVertex(0.09448f, 0.18459f, 0.09999f);
            faces.Add(f227);

            Face f228 = new Face(Material014);
            f228.AddVertex(0.07119f, 0.18994f, 0.12472f);
            f228.AddVertex(0.04967f, 0.17350f, 0.12604f);
            f228.AddVertex(0.06318f, 0.15329f, 0.09999f);
            f228.AddVertex(0.08037f, 0.16739f, 0.09999f);
            faces.Add(f228);

            Face f229 = new Face(Material014);
            f229.AddVertex(0.04967f, 0.17350f, 0.12604f);
            f229.AddVertex(0.02625f, 0.15991f, 0.12472f);
            f229.AddVertex(0.04357f, 0.14280f, 0.09999f);
            f229.AddVertex(0.06318f, 0.15329f, 0.09999f);
            faces.Add(f229);

            Face f230 = new Face(Material014);
            f230.AddVertex(0.02625f, 0.15991f, 0.12472f);
            f230.AddVertex(0.00214f, 0.14990f, 0.12066f);
            f230.AddVertex(0.02229f, 0.13635f, 0.09999f);
            f230.AddVertex(0.04357f, 0.14280f, 0.09999f);
            faces.Add(f230);

            Face f231 = new Face(Material014);
            f231.AddVertex(0.00214f, 0.14990f, 0.12066f);
            f231.AddVertex(-0.02141f, 0.14406f, 0.11305f);
            f231.AddVertex(0.00015f, 0.13417f, 0.09999f);
            f231.AddVertex(0.02229f, 0.13635f, 0.09999f);
            faces.Add(f231);

            Face f232 = new Face(Material014);
            f232.AddVertex(-0.02141f, 0.14406f, 0.11305f);
            f232.AddVertex(-0.04325f, 0.14280f, 0.09999f);
            f232.AddVertex(-0.02197f, 0.13635f, 0.09999f);
            f232.AddVertex(0.00015f, 0.13417f, 0.09999f);
            faces.Add(f232);

            Face f233 = new Face(Material014);
            f233.AddVertex(0.11142f, 0.26974f, 0.09999f);
            f233.AddVertex(0.09895f, 0.25223f, 0.11976f);
            f233.AddVertex(0.10408f, 0.22792f, 0.11305f);
            f233.AddVertex(0.11360f, 0.24761f, 0.09999f);
            faces.Add(f233);

            Face f234 = new Face(Material014);
            f234.AddVertex(0.09895f, 0.25223f, 0.11976f);
            f234.AddVertex(0.08112f, 0.23349f, 0.12940f);
            f234.AddVertex(0.08967f, 0.20838f, 0.12066f);
            f234.AddVertex(0.10408f, 0.22792f, 0.11305f);
            faces.Add(f234);

            Face f235 = new Face(Material014);
            f235.AddVertex(0.08112f, 0.23349f, 0.12940f);
            f235.AddVertex(0.05910f, 0.21458f, 0.13475f);
            f235.AddVertex(0.07119f, 0.18994f, 0.12472f);
            f235.AddVertex(0.08967f, 0.20838f, 0.12066f);
            faces.Add(f235);

            Face f236 = new Face(Material014);
            f236.AddVertex(0.05910f, 0.21458f, 0.13475f);
            f236.AddVertex(0.03426f, 0.19656f, 0.13650f);
            f236.AddVertex(0.04967f, 0.17350f, 0.12604f);
            f236.AddVertex(0.07119f, 0.18994f, 0.12472f);
            faces.Add(f236);

            Face f237 = new Face(Material014);
            f237.AddVertex(0.03426f, 0.19656f, 0.13650f);
            f237.AddVertex(0.00812f, 0.18051f, 0.13475f);
            f237.AddVertex(0.02625f, 0.15991f, 0.12472f);
            f237.AddVertex(0.04967f, 0.17350f, 0.12604f);
            faces.Add(f237);

            Face f238 = new Face(Material014);
            f238.AddVertex(0.00812f, 0.18051f, 0.13475f);
            f238.AddVertex(-0.01778f, 0.16740f, 0.12940f);
            f238.AddVertex(0.00214f, 0.14990f, 0.12066f);
            f238.AddVertex(0.02625f, 0.15991f, 0.12472f);
            faces.Add(f238);

            Face f239 = new Face(Material014);
            f239.AddVertex(-0.01778f, 0.16740f, 0.12940f);
            f239.AddVertex(-0.04191f, 0.15810f, 0.11976f);
            f239.AddVertex(-0.02141f, 0.14406f, 0.11305f);
            f239.AddVertex(0.00214f, 0.14990f, 0.12066f);
            faces.Add(f239);

            Face f240 = new Face(Material014);
            f240.AddVertex(-0.04191f, 0.15810f, 0.11976f);
            f240.AddVertex(-0.06286f, 0.15329f, 0.09999f);
            f240.AddVertex(-0.04325f, 0.14280f, 0.09999f);
            f240.AddVertex(-0.02141f, 0.14406f, 0.11305f);
            faces.Add(f240);

            Face f241 = new Face(Material014);
            f241.AddVertex(0.10496f, 0.29103f, 0.09999f);
            f241.AddVertex(0.08978f, 0.27620f, 0.12316f);
            f241.AddVertex(0.09895f, 0.25223f, 0.11976f);
            f241.AddVertex(0.11142f, 0.26974f, 0.09999f);
            faces.Add(f241);

            Face f242 = new Face(Material014);
            f242.AddVertex(0.08978f, 0.27620f, 0.12316f);
            f242.AddVertex(0.06918f, 0.25896f, 0.13400f);
            f242.AddVertex(0.08112f, 0.23349f, 0.12940f);
            f242.AddVertex(0.09895f, 0.25223f, 0.11976f);
            faces.Add(f242);

            Face f243 = new Face(Material014);
            f243.AddVertex(0.06918f, 0.25896f, 0.13400f);
            f243.AddVertex(0.04456f, 0.24037f, 0.14007f);
            f243.AddVertex(0.05910f, 0.21458f, 0.13475f);
            f243.AddVertex(0.08112f, 0.23349f, 0.12940f);
            faces.Add(f243);

            Face f244 = new Face(Material014);
            f244.AddVertex(0.04456f, 0.24037f, 0.14007f);
            f244.AddVertex(0.01754f, 0.22159f, 0.14206f);
            f244.AddVertex(0.03426f, 0.19656f, 0.13650f);
            f244.AddVertex(0.05910f, 0.21458f, 0.13475f);
            faces.Add(f244);

            Face f245 = new Face(Material014);
            f245.AddVertex(0.01754f, 0.22159f, 0.14206f);
            f245.AddVertex(-0.01014f, 0.20381f, 0.14007f);
            f245.AddVertex(0.00812f, 0.18051f, 0.13475f);
            f245.AddVertex(0.03426f, 0.19656f, 0.13650f);
            faces.Add(f245);

            Face f246 = new Face(Material014);
            f246.AddVertex(-0.01014f, 0.20381f, 0.14007f);
            f246.AddVertex(-0.03673f, 0.18818f, 0.13400f);
            f246.AddVertex(-0.01778f, 0.16740f, 0.12940f);
            f246.AddVertex(0.00812f, 0.18051f, 0.13475f);
            faces.Add(f246);

            Face f247 = new Face(Material014);
            f247.AddVertex(-0.03673f, 0.18818f, 0.13400f);
            f247.AddVertex(-0.06055f, 0.17575f, 0.12316f);
            f247.AddVertex(-0.04191f, 0.15810f, 0.11976f);
            f247.AddVertex(-0.01778f, 0.16740f, 0.12940f);
            faces.Add(f247);

            Face f248 = new Face(Material014);
            f248.AddVertex(-0.06055f, 0.17575f, 0.12316f);
            f248.AddVertex(-0.08005f, 0.16739f, 0.09999f);
            f248.AddVertex(-0.06286f, 0.15329f, 0.09999f);
            f248.AddVertex(-0.04191f, 0.15810f, 0.11976f);
            faces.Add(f248);

            Face f249 = new Face(Material014);
            f249.AddVertex(0.09448f, 0.31064f, 0.09999f);
            f249.AddVertex(0.07692f, 0.29891f, 0.12424f);
            f249.AddVertex(0.08978f, 0.27620f, 0.12316f);
            f249.AddVertex(0.10496f, 0.29103f, 0.09999f);
            faces.Add(f249);

            Face f250 = new Face(Material014);
            f250.AddVertex(0.07692f, 0.29891f, 0.12424f);
            f250.AddVertex(0.05430f, 0.28379f, 0.13547f);
            f250.AddVertex(0.06918f, 0.25896f, 0.13400f);
            f250.AddVertex(0.08978f, 0.27620f, 0.12316f);
            faces.Add(f250);

            Face f251 = new Face(Material014);
            f251.AddVertex(0.05430f, 0.28379f, 0.13547f);
            f251.AddVertex(0.02814f, 0.26631f, 0.14177f);
            f251.AddVertex(0.04456f, 0.24037f, 0.14007f);
            f251.AddVertex(0.06918f, 0.25896f, 0.13400f);
            faces.Add(f251);

            Face f252 = new Face(Material014);
            f252.AddVertex(0.02814f, 0.26631f, 0.14177f);
            f252.AddVertex(0.00015f, 0.24761f, 0.14385f);
            f252.AddVertex(0.01754f, 0.22159f, 0.14206f);
            f252.AddVertex(0.04456f, 0.24037f, 0.14007f);
            faces.Add(f252);

            Face f253 = new Face(Material014);
            f253.AddVertex(0.00015f, 0.24761f, 0.14385f);
            f253.AddVertex(-0.02782f, 0.22892f, 0.14177f);
            f253.AddVertex(-0.01014f, 0.20381f, 0.14007f);
            f253.AddVertex(0.01754f, 0.22159f, 0.14206f);
            faces.Add(f253);

            Face f254 = new Face(Material014);
            f254.AddVertex(-0.02782f, 0.22892f, 0.14177f);
            f254.AddVertex(-0.05398f, 0.21143f, 0.13547f);
            f254.AddVertex(-0.03673f, 0.18818f, 0.13400f);
            f254.AddVertex(-0.01014f, 0.20381f, 0.14007f);
            faces.Add(f254);

            Face f255 = new Face(Material014);
            f255.AddVertex(-0.05398f, 0.21143f, 0.13547f);
            f255.AddVertex(-0.07661f, 0.19632f, 0.12424f);
            f255.AddVertex(-0.06055f, 0.17575f, 0.12316f);
            f255.AddVertex(-0.03673f, 0.18818f, 0.13400f);
            faces.Add(f255);

            Face f256 = new Face(Material014);
            f256.AddVertex(-0.07661f, 0.19632f, 0.12424f);
            f256.AddVertex(-0.09416f, 0.18459f, 0.09999f);
            f256.AddVertex(-0.08005f, 0.16739f, 0.09999f);
            f256.AddVertex(-0.06055f, 0.17575f, 0.12316f);
            faces.Add(f256);

            Face f257 = new Face(Material014);
            f257.AddVertex(0.08037f, 0.32783f, 0.09999f);
            f257.AddVertex(0.06087f, 0.31948f, 0.12316f);
            f257.AddVertex(0.07692f, 0.29891f, 0.12424f);
            f257.AddVertex(0.09448f, 0.31064f, 0.09999f);
            faces.Add(f257);

            Face f258 = new Face(Material014);
            f258.AddVertex(0.06087f, 0.31948f, 0.12316f);
            f258.AddVertex(0.03705f, 0.30704f, 0.13400f);
            f258.AddVertex(0.05430f, 0.28379f, 0.13547f);
            f258.AddVertex(0.07692f, 0.29891f, 0.12424f);
            faces.Add(f258);

            Face f259 = new Face(Material014);
            f259.AddVertex(0.03705f, 0.30704f, 0.13400f);
            f259.AddVertex(0.01045f, 0.29141f, 0.14007f);
            f259.AddVertex(0.02814f, 0.26631f, 0.14177f);
            f259.AddVertex(0.05430f, 0.28379f, 0.13547f);
            faces.Add(f259);

            Face f260 = new Face(Material014);
            f260.AddVertex(0.01045f, 0.29141f, 0.14007f);
            f260.AddVertex(-0.01723f, 0.27364f, 0.14206f);
            f260.AddVertex(0.00015f, 0.24761f, 0.14385f);
            f260.AddVertex(0.02814f, 0.26631f, 0.14177f);
            faces.Add(f260);

            Face f261 = new Face(Material014);
            f261.AddVertex(-0.01723f, 0.27364f, 0.14206f);
            f261.AddVertex(-0.04425f, 0.25486f, 0.14007f);
            f261.AddVertex(-0.02782f, 0.22892f, 0.14177f);
            f261.AddVertex(0.00015f, 0.24761f, 0.14385f);
            faces.Add(f261);

            Face f262 = new Face(Material014);
            f262.AddVertex(-0.04425f, 0.25486f, 0.14007f);
            f262.AddVertex(-0.06886f, 0.23627f, 0.13400f);
            f262.AddVertex(-0.05398f, 0.21143f, 0.13547f);
            f262.AddVertex(-0.02782f, 0.22892f, 0.14177f);
            faces.Add(f262);

            Face f263 = new Face(Material014);
            f263.AddVertex(-0.06886f, 0.23627f, 0.13400f);
            f263.AddVertex(-0.08947f, 0.21902f, 0.12316f);
            f263.AddVertex(-0.07661f, 0.19632f, 0.12424f);
            f263.AddVertex(-0.05398f, 0.21143f, 0.13547f);
            faces.Add(f263);

            Face f264 = new Face(Material014);
            f264.AddVertex(-0.08947f, 0.21902f, 0.12316f);
            f264.AddVertex(-0.10465f, 0.20420f, 0.09999f);
            f264.AddVertex(-0.09416f, 0.18459f, 0.09999f);
            f264.AddVertex(-0.07661f, 0.19632f, 0.12424f);
            faces.Add(f264);

            Face f265 = new Face(Material014);
            f265.AddVertex(0.06318f, 0.34194f, 0.09999f);
            f265.AddVertex(0.04223f, 0.33712f, 0.11976f);
            f265.AddVertex(0.06087f, 0.31948f, 0.12316f);
            f265.AddVertex(0.08037f, 0.32783f, 0.09999f);
            faces.Add(f265);

            Face f266 = new Face(Material014);
            f266.AddVertex(0.04223f, 0.33712f, 0.11976f);
            f266.AddVertex(0.01810f, 0.32782f, 0.12940f);
            f266.AddVertex(0.03705f, 0.30704f, 0.13400f);
            f266.AddVertex(0.06087f, 0.31948f, 0.12316f);
            faces.Add(f266);

            Face f267 = new Face(Material014);
            f267.AddVertex(0.01810f, 0.32782f, 0.12940f);
            f267.AddVertex(-0.00780f, 0.31471f, 0.13475f);
            f267.AddVertex(0.01045f, 0.29141f, 0.14007f);
            f267.AddVertex(0.03705f, 0.30704f, 0.13400f);
            faces.Add(f267);

            Face f268 = new Face(Material014);
            f268.AddVertex(-0.00780f, 0.31471f, 0.13475f);
            f268.AddVertex(-0.03395f, 0.29866f, 0.13650f);
            f268.AddVertex(-0.01723f, 0.27364f, 0.14206f);
            f268.AddVertex(0.01045f, 0.29141f, 0.14007f);
            faces.Add(f268);

            Face f269 = new Face(Material014);
            f269.AddVertex(-0.03395f, 0.29866f, 0.13650f);
            f269.AddVertex(-0.05878f, 0.28065f, 0.13475f);
            f269.AddVertex(-0.04425f, 0.25486f, 0.14007f);
            f269.AddVertex(-0.01723f, 0.27364f, 0.14206f);
            faces.Add(f269);

            Face f270 = new Face(Material014);
            f270.AddVertex(-0.05878f, 0.28065f, 0.13475f);
            f270.AddVertex(-0.08081f, 0.26173f, 0.12940f);
            f270.AddVertex(-0.06886f, 0.23627f, 0.13400f);
            f270.AddVertex(-0.04425f, 0.25486f, 0.14007f);
            faces.Add(f270);

            Face f271 = new Face(Material014);
            f271.AddVertex(-0.08081f, 0.26173f, 0.12940f);
            f271.AddVertex(-0.09864f, 0.24299f, 0.11976f);
            f271.AddVertex(-0.08947f, 0.21902f, 0.12316f);
            f271.AddVertex(-0.06886f, 0.23627f, 0.13400f);
            faces.Add(f271);

            Face f272 = new Face(Material014);
            f272.AddVertex(-0.09864f, 0.24299f, 0.11976f);
            f272.AddVertex(-0.11110f, 0.22548f, 0.09999f);
            f272.AddVertex(-0.10465f, 0.20420f, 0.09999f);
            f272.AddVertex(-0.08947f, 0.21902f, 0.12316f);
            faces.Add(f272);

            Face f273 = new Face(Material014);
            f273.AddVertex(0.04357f, 0.35242f, 0.09999f);
            f273.AddVertex(0.02173f, 0.35116f, 0.11305f);
            f273.AddVertex(0.04223f, 0.33712f, 0.11976f);
            f273.AddVertex(0.06318f, 0.34194f, 0.09999f);
            faces.Add(f273);

            Face f274 = new Face(Material014);
            f274.AddVertex(0.02173f, 0.35116f, 0.11305f);
            f274.AddVertex(-0.00183f, 0.34532f, 0.12066f);
            f274.AddVertex(0.01810f, 0.32782f, 0.12940f);
            f274.AddVertex(0.04223f, 0.33712f, 0.11976f);
            faces.Add(f274);

            Face f275 = new Face(Material014);
            f275.AddVertex(-0.00183f, 0.34532f, 0.12066f);
            f275.AddVertex(-0.02594f, 0.33531f, 0.12472f);
            f275.AddVertex(-0.00780f, 0.31471f, 0.13475f);
            f275.AddVertex(0.01810f, 0.32782f, 0.12940f);
            faces.Add(f275);

            Face f276 = new Face(Material014);
            f276.AddVertex(-0.02594f, 0.33531f, 0.12472f);
            f276.AddVertex(-0.04936f, 0.32172f, 0.12604f);
            f276.AddVertex(-0.03395f, 0.29866f, 0.13650f);
            f276.AddVertex(-0.00780f, 0.31471f, 0.13475f);
            faces.Add(f276);

            Face f277 = new Face(Material014);
            f277.AddVertex(-0.04936f, 0.32172f, 0.12604f);
            f277.AddVertex(-0.07088f, 0.30529f, 0.12472f);
            f277.AddVertex(-0.05878f, 0.28065f, 0.13475f);
            f277.AddVertex(-0.03395f, 0.29866f, 0.13650f);
            faces.Add(f277);

            Face f278 = new Face(Material014);
            f278.AddVertex(-0.07088f, 0.30529f, 0.12472f);
            f278.AddVertex(-0.08935f, 0.28684f, 0.12066f);
            f278.AddVertex(-0.08081f, 0.26173f, 0.12940f);
            f278.AddVertex(-0.05878f, 0.28065f, 0.13475f);
            faces.Add(f278);

            Face f279 = new Face(Material014);
            f279.AddVertex(-0.08935f, 0.28684f, 0.12066f);
            f279.AddVertex(-0.10376f, 0.26731f, 0.11305f);
            f279.AddVertex(-0.09864f, 0.24299f, 0.11976f);
            f279.AddVertex(-0.08081f, 0.26173f, 0.12940f);
            faces.Add(f279);

            Face f280 = new Face(Material014);
            f280.AddVertex(-0.10376f, 0.26731f, 0.11305f);
            f280.AddVertex(-0.11328f, 0.24761f, 0.09999f);
            f280.AddVertex(-0.11110f, 0.22548f, 0.09999f);
            f280.AddVertex(-0.09864f, 0.24299f, 0.11976f);
            faces.Add(f280);

            Face f281 = new Face(Material014);
            f281.AddVertex(0.02229f, 0.35888f, 0.09999f);
            f281.AddVertex(0.00015f, 0.36106f, 0.09999f);
            f281.AddVertex(0.02173f, 0.35116f, 0.11305f);
            f281.AddVertex(0.04357f, 0.35242f, 0.09999f);
            faces.Add(f281);

            Face f282 = new Face(Material014);
            f282.AddVertex(0.00015f, 0.36106f, 0.09999f);
            f282.AddVertex(-0.02197f, 0.35888f, 0.09999f);
            f282.AddVertex(-0.00183f, 0.34532f, 0.12066f);
            f282.AddVertex(0.02173f, 0.35116f, 0.11305f);
            faces.Add(f282);

            Face f283 = new Face(Material014);
            f283.AddVertex(-0.02197f, 0.35888f, 0.09999f);
            f283.AddVertex(-0.04325f, 0.35242f, 0.09999f);
            f283.AddVertex(-0.02594f, 0.33531f, 0.12472f);
            f283.AddVertex(-0.00183f, 0.34532f, 0.12066f);
            faces.Add(f283);

            Face f284 = new Face(Material014);
            f284.AddVertex(-0.04325f, 0.35242f, 0.09999f);
            f284.AddVertex(-0.06286f, 0.34194f, 0.09999f);
            f284.AddVertex(-0.04936f, 0.32172f, 0.12604f);
            f284.AddVertex(-0.02594f, 0.33531f, 0.12472f);
            faces.Add(f284);

            Face f285 = new Face(Material014);
            f285.AddVertex(-0.06286f, 0.34194f, 0.09999f);
            f285.AddVertex(-0.08005f, 0.32783f, 0.09999f);
            f285.AddVertex(-0.07088f, 0.30529f, 0.12472f);
            f285.AddVertex(-0.04936f, 0.32172f, 0.12604f);
            faces.Add(f285);

            Face f286 = new Face(Material014);
            f286.AddVertex(-0.08005f, 0.32783f, 0.09999f);
            f286.AddVertex(-0.09416f, 0.31064f, 0.09999f);
            f286.AddVertex(-0.08935f, 0.28684f, 0.12066f);
            f286.AddVertex(-0.07088f, 0.30529f, 0.12472f);
            faces.Add(f286);

            Face f287 = new Face(Material014);
            f287.AddVertex(-0.09416f, 0.31064f, 0.09999f);
            f287.AddVertex(-0.10465f, 0.29103f, 0.09999f);
            f287.AddVertex(-0.10376f, 0.26731f, 0.11305f);
            f287.AddVertex(-0.08935f, 0.28684f, 0.12066f);
            faces.Add(f287);

            Face f288 = new Face(Material014);
            f288.AddVertex(-0.10465f, 0.29103f, 0.09999f);
            f288.AddVertex(-0.11110f, 0.26974f, 0.09999f);
            f288.AddVertex(-0.11328f, 0.24761f, 0.09999f);
            f288.AddVertex(-0.10376f, 0.26731f, 0.11305f);
            faces.Add(f288);

            Face f289 = new Face(Material014);
            f289.AddVertex(0.23242f, 0.01535f, 0.23933f);
            f289.AddVertex(0.27327f, 0.06512f, 0.23933f);
            f289.AddVertex(0.25409f, 0.07794f, 0.23933f);
            f289.AddVertex(0.21611f, 0.03166f, 0.23933f);
            faces.Add(f289);

            Face f290 = new Face(Material014);
            f290.AddVertex(0.00015f, 0.57608f, 0.23933f);
            f290.AddVertex(-0.06392f, 0.56977f, 0.23933f);
            f290.AddVertex(-0.05942f, 0.54715f, 0.23933f);
            f290.AddVertex(0.00015f, 0.55301f, 0.23933f);
            faces.Add(f290);

            Face f291 = new Face(Material014);
            f291.AddVertex(-0.30330f, 0.12191f, 0.23933f);
            f291.AddVertex(-0.27295f, 0.06512f, 0.23933f);
            f291.AddVertex(-0.25377f, 0.07794f, 0.23933f);
            f291.AddVertex(-0.28199f, 0.13074f, 0.23933f);
            faces.Add(f291);

            Face f292 = new Face(Material014);
            f292.AddVertex(0.18264f, -0.02549f, 0.23933f);
            f292.AddVertex(0.23242f, 0.01535f, 0.23933f);
            f292.AddVertex(0.21611f, 0.03166f, 0.23933f);
            f292.AddVertex(0.16983f, -0.00631f, 0.23933f);
            faces.Add(f292);

            Face f293 = new Face(Material014);
            f293.AddVertex(0.27327f, 0.43010f, 0.23933f);
            f293.AddVertex(0.23242f, 0.47988f, 0.23933f);
            f293.AddVertex(0.21611f, 0.46356f, 0.23933f);
            f293.AddVertex(0.25409f, 0.41728f, 0.23933f);
            faces.Add(f293);

            Face f294 = new Face(Material014);
            f294.AddVertex(0.18264f, 0.52073f, 0.23933f);
            f294.AddVertex(0.12586f, 0.55108f, 0.23933f);
            f294.AddVertex(0.11703f, 0.52977f, 0.23933f);
            f294.AddVertex(0.16983f, 0.50154f, 0.23933f);
            faces.Add(f294);

            Face f295 = new Face(Material014);
            f295.AddVertex(-0.23210f, 0.47988f, 0.23933f);
            f295.AddVertex(-0.27295f, 0.43010f, 0.23933f);
            f295.AddVertex(-0.25377f, 0.41728f, 0.23933f);
            f295.AddVertex(-0.21579f, 0.46356f, 0.23933f);
            faces.Add(f295);

            Face f296 = new Face(Material014);
            f296.AddVertex(-0.23210f, 0.01535f, 0.23933f);
            f296.AddVertex(-0.18233f, -0.02549f, 0.23933f);
            f296.AddVertex(-0.16951f, -0.00631f, 0.23933f);
            f296.AddVertex(-0.21579f, 0.03166f, 0.23933f);
            faces.Add(f296);

            Face f297 = new Face(Material014);
            f297.AddVertex(0.27327f, 0.06512f, 0.23933f);
            f297.AddVertex(0.30362f, 0.12191f, 0.23933f);
            f297.AddVertex(0.28231f, 0.13074f, 0.23933f);
            f297.AddVertex(0.25409f, 0.07794f, 0.23933f);
            faces.Add(f297);

            Face f298 = new Face(Material014);
            f298.AddVertex(-0.18233f, 0.52073f, 0.23933f);
            f298.AddVertex(-0.23210f, 0.47988f, 0.23933f);
            f298.AddVertex(-0.21579f, 0.46356f, 0.23933f);
            f298.AddVertex(-0.16951f, 0.50154f, 0.23933f);
            faces.Add(f298);

            Face f299 = new Face(Material014);
            f299.AddVertex(-0.27295f, 0.06512f, 0.23933f);
            f299.AddVertex(-0.23210f, 0.01535f, 0.23933f);
            f299.AddVertex(-0.21579f, 0.03166f, 0.23933f);
            f299.AddVertex(-0.25377f, 0.07794f, 0.23933f);
            faces.Add(f299);

            Face f300 = new Face(Material014);
            f300.AddVertex(0.12586f, -0.05585f, 0.23933f);
            f300.AddVertex(0.18264f, -0.02549f, 0.23933f);
            f300.AddVertex(0.16983f, -0.00631f, 0.23933f);
            f300.AddVertex(0.11703f, -0.03453f, 0.23933f);
            faces.Add(f300);

            Face f301 = new Face(Material014);
            f301.AddVertex(0.32863f, 0.24761f, 0.23933f);
            f301.AddVertex(0.32232f, 0.31169f, 0.23933f);
            f301.AddVertex(0.29969f, 0.30719f, 0.23933f);
            f301.AddVertex(0.30556f, 0.24761f, 0.23933f);
            faces.Add(f301);

            Face f302 = new Face(Material014);
            f302.AddVertex(0.23242f, 0.47988f, 0.23933f);
            f302.AddVertex(0.18264f, 0.52073f, 0.23933f);
            f302.AddVertex(0.16983f, 0.50154f, 0.23933f);
            f302.AddVertex(0.21611f, 0.46356f, 0.23933f);
            faces.Add(f302);

            Face f303 = new Face(Material014);
            f303.AddVertex(-0.27295f, 0.43010f, 0.23933f);
            f303.AddVertex(-0.30330f, 0.37331f, 0.23933f);
            f303.AddVertex(-0.28199f, 0.36448f, 0.23933f);
            f303.AddVertex(-0.25377f, 0.41728f, 0.23933f);
            faces.Add(f303);

            Face f304 = new Face(Material014);
            f304.AddVertex(-0.06392f, -0.07454f, 0.23933f);
            f304.AddVertex(0.00015f, -0.08085f, 0.23933f);
            f304.AddVertex(0.00015f, -0.05778f, 0.23933f);
            f304.AddVertex(-0.05942f, -0.05191f, 0.23933f);
            faces.Add(f304);

            Face f305 = new Face(Material014);
            f305.AddVertex(-0.12554f, 0.55108f, 0.23933f);
            f305.AddVertex(-0.18233f, 0.52073f, 0.23933f);
            f305.AddVertex(-0.16951f, 0.50154f, 0.23933f);
            f305.AddVertex(-0.11671f, 0.52977f, 0.23933f);
            faces.Add(f305);

            Face f306 = new Face(Material014);
            f306.AddVertex(-0.32831f, 0.24761f, 0.23933f);
            f306.AddVertex(-0.32200f, 0.18353f, 0.23933f);
            f306.AddVertex(-0.29937f, 0.18803f, 0.23933f);
            f306.AddVertex(-0.30524f, 0.24761f, 0.23933f);
            faces.Add(f306);

            Face f307 = new Face(Material014);
            f307.AddVertex(0.32232f, 0.31169f, 0.23933f);
            f307.AddVertex(0.30362f, 0.37331f, 0.23933f);
            f307.AddVertex(0.28231f, 0.36448f, 0.23933f);
            f307.AddVertex(0.29969f, 0.30719f, 0.23933f);
            faces.Add(f307);

            Face f308 = new Face(Material014);
            f308.AddVertex(0.06424f, 0.56977f, 0.23933f);
            f308.AddVertex(0.00015f, 0.57608f, 0.23933f);
            f308.AddVertex(0.00015f, 0.55301f, 0.23933f);
            f308.AddVertex(0.05974f, 0.54715f, 0.23933f);
            faces.Add(f308);

            Face f309 = new Face(Material014);
            f309.AddVertex(-0.12554f, -0.05585f, 0.23933f);
            f309.AddVertex(-0.06392f, -0.07454f, 0.23933f);
            f309.AddVertex(-0.05942f, -0.05191f, 0.23933f);
            f309.AddVertex(-0.11671f, -0.03453f, 0.23933f);
            faces.Add(f309);

            Face f310 = new Face(Material014);
            f310.AddVertex(0.30362f, 0.12191f, 0.23933f);
            f310.AddVertex(0.32232f, 0.18353f, 0.23933f);
            f310.AddVertex(0.29969f, 0.18803f, 0.23933f);
            f310.AddVertex(0.28231f, 0.13074f, 0.23933f);
            faces.Add(f310);

            Face f311 = new Face(Material014);
            f311.AddVertex(-0.32200f, 0.18353f, 0.23933f);
            f311.AddVertex(-0.30330f, 0.12191f, 0.23933f);
            f311.AddVertex(-0.28199f, 0.13074f, 0.23933f);
            f311.AddVertex(-0.29937f, 0.18803f, 0.23933f);
            faces.Add(f311);

            Face f312 = new Face(Material014);
            f312.AddVertex(0.06424f, -0.07454f, 0.23933f);
            f312.AddVertex(0.12586f, -0.05585f, 0.23933f);
            f312.AddVertex(0.11703f, -0.03453f, 0.23933f);
            f312.AddVertex(0.05974f, -0.05191f, 0.23933f);
            faces.Add(f312);

            Face f313 = new Face(Material014);
            f313.AddVertex(0.12586f, 0.55108f, 0.23933f);
            f313.AddVertex(0.06424f, 0.56977f, 0.23933f);
            f313.AddVertex(0.05974f, 0.54715f, 0.23933f);
            f313.AddVertex(0.11703f, 0.52977f, 0.23933f);
            faces.Add(f313);

            Face f314 = new Face(Material014);
            f314.AddVertex(-0.30330f, 0.37331f, 0.23933f);
            f314.AddVertex(-0.32200f, 0.31169f, 0.23933f);
            f314.AddVertex(-0.29937f, 0.30719f, 0.23933f);
            f314.AddVertex(-0.28199f, 0.36448f, 0.23933f);
            faces.Add(f314);

            Face f315 = new Face(Material014);
            f315.AddVertex(0.32232f, 0.18353f, 0.23933f);
            f315.AddVertex(0.32863f, 0.24761f, 0.23933f);
            f315.AddVertex(0.30556f, 0.24761f, 0.23933f);
            f315.AddVertex(0.29969f, 0.18803f, 0.23933f);
            faces.Add(f315);

            Face f316 = new Face(Material014);
            f316.AddVertex(-0.06392f, 0.56977f, 0.23933f);
            f316.AddVertex(-0.12554f, 0.55108f, 0.23933f);
            f316.AddVertex(-0.11671f, 0.52977f, 0.23933f);
            f316.AddVertex(-0.05942f, 0.54715f, 0.23933f);
            faces.Add(f316);

            Face f317 = new Face(Material014);
            f317.AddVertex(0.00015f, -0.08085f, 0.23933f);
            f317.AddVertex(0.06424f, -0.07454f, 0.23933f);
            f317.AddVertex(0.05974f, -0.05191f, 0.23933f);
            f317.AddVertex(0.00015f, -0.05778f, 0.23933f);
            faces.Add(f317);

            Face f318 = new Face(Material014);
            f318.AddVertex(0.30362f, 0.37331f, 0.23933f);
            f318.AddVertex(0.27327f, 0.43010f, 0.23933f);
            f318.AddVertex(0.25409f, 0.41728f, 0.23933f);
            f318.AddVertex(0.28231f, 0.36448f, 0.23933f);
            faces.Add(f318);

            Face f319 = new Face(Material014);
            f319.AddVertex(-0.32200f, 0.31169f, 0.23933f);
            f319.AddVertex(-0.32831f, 0.24761f, 0.23933f);
            f319.AddVertex(-0.30524f, 0.24761f, 0.23933f);
            f319.AddVertex(-0.29937f, 0.30719f, 0.23933f);
            faces.Add(f319);

            Face f320 = new Face(Material014);
            f320.AddVertex(-0.18233f, -0.02549f, 0.23933f);
            f320.AddVertex(-0.12554f, -0.05585f, 0.23933f);
            f320.AddVertex(-0.11671f, -0.03453f, 0.23933f);
            f320.AddVertex(-0.16951f, -0.00631f, 0.23933f);
            faces.Add(f320);

            Face f321 = new Face(Material014);
            f321.AddVertex(-0.32200f, 0.18353f, 0.21931f);
            f321.AddVertex(-0.30330f, 0.12191f, 0.21931f);
            f321.AddVertex(-0.30330f, 0.12191f, 0.23933f);
            f321.AddVertex(-0.32200f, 0.18353f, 0.23933f);
            faces.Add(f321);

            Face f322 = new Face(Material014);
            f322.AddVertex(-0.11671f, 0.52977f, 0.21931f);
            f322.AddVertex(-0.05942f, 0.54715f, 0.21931f);
            f322.AddVertex(-0.05942f, 0.54715f, 0.23933f);
            f322.AddVertex(-0.11671f, 0.52977f, 0.23933f);
            faces.Add(f322);

            Face f323 = new Face(Material014);
            f323.AddVertex(0.12558f, 0.55108f, 0.21931f);
            f323.AddVertex(0.06424f, 0.56977f, 0.21931f);
            f323.AddVertex(0.06424f, 0.56977f, 0.23933f);
            f323.AddVertex(0.12586f, 0.55108f, 0.23933f);
            faces.Add(f323);

            Face f324 = new Face(Material014);
            f324.AddVertex(0.25409f, 0.41728f, 0.21931f);
            f324.AddVertex(0.28231f, 0.36448f, 0.21931f);
            f324.AddVertex(0.28231f, 0.36448f, 0.23933f);
            f324.AddVertex(0.25409f, 0.41728f, 0.23933f);
            faces.Add(f324);

            Face f325 = new Face(Material014);
            f325.AddVertex(0.32232f, 0.18353f, 0.21931f);
            f325.AddVertex(0.32863f, 0.24761f, 0.21931f);
            f325.AddVertex(0.32863f, 0.24761f, 0.23933f);
            f325.AddVertex(0.32232f, 0.18353f, 0.23933f);
            faces.Add(f325);

            Face f326 = new Face(Material014);
            f326.AddVertex(-0.11671f, -0.03453f, 0.21931f);
            f326.AddVertex(-0.16951f, -0.00631f, 0.21931f);
            f326.AddVertex(-0.16951f, -0.00631f, 0.23933f);
            f326.AddVertex(-0.11671f, -0.03453f, 0.23933f);
            faces.Add(f326);

            Face f327 = new Face(Material014);
            f327.AddVertex(0.00015f, -0.08085f, 0.21931f);
            f327.AddVertex(0.06424f, -0.07454f, 0.21931f);
            f327.AddVertex(0.06424f, -0.07454f, 0.23933f);
            f327.AddVertex(0.00015f, -0.08085f, 0.23933f);
            faces.Add(f327);

            Face f328 = new Face(Material014);
            f328.AddVertex(-0.25377f, 0.07794f, 0.21931f);
            f328.AddVertex(-0.28199f, 0.13074f, 0.21931f);
            f328.AddVertex(-0.28199f, 0.13074f, 0.23933f);
            f328.AddVertex(-0.25377f, 0.07794f, 0.23933f);
            faces.Add(f328);

            Face f329 = new Face(Material014);
            f329.AddVertex(-0.32200f, 0.31169f, 0.21931f);
            f329.AddVertex(-0.32831f, 0.24761f, 0.21931f);
            f329.AddVertex(-0.32831f, 0.24761f, 0.23933f);
            f329.AddVertex(-0.32200f, 0.31169f, 0.23933f);
            faces.Add(f329);

            Face f330 = new Face(Material014);
            f330.AddVertex(0.23242f, 0.01535f, 0.21931f);
            f330.AddVertex(0.27327f, 0.06512f, 0.21931f);
            f330.AddVertex(0.27327f, 0.06512f, 0.23933f);
            f330.AddVertex(0.23242f, 0.01535f, 0.23933f);
            faces.Add(f330);

            Face f331 = new Face(Material014);
            f331.AddVertex(0.11702f, 0.52977f, 0.21931f);
            f331.AddVertex(0.16983f, 0.50154f, 0.21931f);
            f331.AddVertex(0.16983f, 0.50154f, 0.23933f);
            f331.AddVertex(0.11703f, 0.52977f, 0.23933f);
            faces.Add(f331);

            Face f332 = new Face(Material014);
            f332.AddVertex(0.00015f, 0.57608f, 0.21931f);
            f332.AddVertex(-0.06392f, 0.56977f, 0.21931f);
            f332.AddVertex(-0.06392f, 0.56977f, 0.23933f);
            f332.AddVertex(0.00015f, 0.57608f, 0.23933f);
            faces.Add(f332);

            Face f333 = new Face(Material014);
            f333.AddVertex(0.18264f, -0.02549f, 0.21931f);
            f333.AddVertex(0.23242f, 0.01535f, 0.21931f);
            f333.AddVertex(0.23242f, 0.01535f, 0.23933f);
            f333.AddVertex(0.18264f, -0.02549f, 0.23933f);
            faces.Add(f333);

            Face f334 = new Face(Material014);
            f334.AddVertex(0.28231f, 0.13074f, 0.21931f);
            f334.AddVertex(0.25409f, 0.07794f, 0.21931f);
            f334.AddVertex(0.25409f, 0.07794f, 0.23933f);
            f334.AddVertex(0.28231f, 0.13074f, 0.23933f);
            faces.Add(f334);

            Face f335 = new Face(Material014);
            f335.AddVertex(0.27327f, 0.43010f, 0.21931f);
            f335.AddVertex(0.23242f, 0.47988f, 0.21931f);
            f335.AddVertex(0.23242f, 0.47988f, 0.23933f);
            f335.AddVertex(0.27327f, 0.43010f, 0.23933f);
            faces.Add(f335);

            Face f336 = new Face(Material014);
            f336.AddVertex(-0.23210f, 0.47988f, 0.21931f);
            f336.AddVertex(-0.27295f, 0.43010f, 0.21931f);
            f336.AddVertex(-0.27295f, 0.43010f, 0.23933f);
            f336.AddVertex(-0.23210f, 0.47988f, 0.23933f);
            faces.Add(f336);

            Face f337 = new Face(Material014);
            f337.AddVertex(0.16983f, -0.00631f, 0.21931f);
            f337.AddVertex(0.11703f, -0.03453f, 0.21931f);
            f337.AddVertex(0.11703f, -0.03453f, 0.23933f);
            f337.AddVertex(0.16983f, -0.00631f, 0.23933f);
            faces.Add(f337);

            Face f338 = new Face(Material014);
            f338.AddVertex(-0.23210f, 0.01535f, 0.21931f);
            f338.AddVertex(-0.18233f, -0.02549f, 0.21931f);
            f338.AddVertex(-0.18233f, -0.02549f, 0.23933f);
            f338.AddVertex(-0.23210f, 0.01535f, 0.23933f);
            faces.Add(f338);

            Face f339 = new Face(Material014);
            f339.AddVertex(-0.18219f, 0.52073f, 0.21931f);
            f339.AddVertex(-0.23210f, 0.47988f, 0.21931f);
            f339.AddVertex(-0.23210f, 0.47988f, 0.23933f);
            f339.AddVertex(-0.18233f, 0.52073f, 0.23933f);
            faces.Add(f339);

            Face f340 = new Face(Material014);
            f340.AddVertex(-0.28199f, 0.36448f, 0.21931f);
            f340.AddVertex(-0.25377f, 0.41728f, 0.21931f);
            f340.AddVertex(-0.25377f, 0.41728f, 0.23933f);
            f340.AddVertex(-0.28199f, 0.36448f, 0.23933f);
            faces.Add(f340);

            Face f341 = new Face(Material014);
            f341.AddVertex(-0.27295f, 0.06512f, 0.21931f);
            f341.AddVertex(-0.23210f, 0.01535f, 0.21931f);
            f341.AddVertex(-0.23210f, 0.01535f, 0.23933f);
            f341.AddVertex(-0.27295f, 0.06512f, 0.23933f);
            faces.Add(f341);

            Face f342 = new Face(Material014);
            f342.AddVertex(0.32863f, 0.24761f, 0.21931f);
            f342.AddVertex(0.32232f, 0.31169f, 0.21931f);
            f342.AddVertex(0.32232f, 0.31169f, 0.23933f);
            f342.AddVertex(0.32863f, 0.24761f, 0.23933f);
            faces.Add(f342);

            Face f343 = new Face(Material014);
            f343.AddVertex(-0.16951f, 0.50154f, 0.21931f);
            f343.AddVertex(-0.11671f, 0.52977f, 0.21931f);
            f343.AddVertex(-0.11671f, 0.52977f, 0.23933f);
            f343.AddVertex(-0.16951f, 0.50154f, 0.23933f);
            faces.Add(f343);

            Face f344 = new Face(Material014);
            f344.AddVertex(0.23242f, 0.47988f, 0.21931f);
            f344.AddVertex(0.18251f, 0.52073f, 0.21931f);
            f344.AddVertex(0.18264f, 0.52073f, 0.23933f);
            f344.AddVertex(0.23242f, 0.47988f, 0.23933f);
            faces.Add(f344);

            Face f345 = new Face(Material014);
            f345.AddVertex(-0.06392f, -0.07454f, 0.21931f);
            f345.AddVertex(0.00015f, -0.08085f, 0.21931f);
            f345.AddVertex(0.00015f, -0.08085f, 0.23933f);
            f345.AddVertex(-0.06392f, -0.07454f, 0.23933f);
            faces.Add(f345);

            Face f346 = new Face(Material014);
            f346.AddVertex(0.28231f, 0.36448f, 0.21931f);
            f346.AddVertex(0.29969f, 0.30719f, 0.21931f);
            f346.AddVertex(0.29969f, 0.30719f, 0.23933f);
            f346.AddVertex(0.28231f, 0.36448f, 0.23933f);
            faces.Add(f346);

            Face f347 = new Face(Material014);
            f347.AddVertex(-0.32831f, 0.24761f, 0.21931f);
            f347.AddVertex(-0.32200f, 0.18353f, 0.21931f);
            f347.AddVertex(-0.32200f, 0.18353f, 0.23933f);
            f347.AddVertex(-0.32831f, 0.24761f, 0.23933f);
            faces.Add(f347);

            Face f348 = new Face(Material014);
            f348.AddVertex(-0.05942f, -0.05191f, 0.21931f);
            f348.AddVertex(-0.11671f, -0.03453f, 0.21931f);
            f348.AddVertex(-0.11671f, -0.03453f, 0.23933f);
            f348.AddVertex(-0.05942f, -0.05191f, 0.23933f);
            faces.Add(f348);

            Face f349 = new Face(Material014);
            f349.AddVertex(0.06424f, 0.56977f, 0.21931f);
            f349.AddVertex(0.00015f, 0.57608f, 0.21931f);
            f349.AddVertex(0.00015f, 0.57608f, 0.23933f);
            f349.AddVertex(0.06424f, 0.56977f, 0.23933f);
            faces.Add(f349);

            Face f350 = new Face(Material014);
            f350.AddVertex(-0.28199f, 0.13074f, 0.21931f);
            f350.AddVertex(-0.29937f, 0.18803f, 0.21931f);
            f350.AddVertex(-0.29937f, 0.18803f, 0.23933f);
            f350.AddVertex(-0.28199f, 0.13074f, 0.23933f);
            faces.Add(f350);

            Face f351 = new Face(Material014);
            f351.AddVertex(0.30362f, 0.12191f, 0.21931f);
            f351.AddVertex(0.32232f, 0.18353f, 0.21931f);
            f351.AddVertex(0.32232f, 0.18353f, 0.23933f);
            f351.AddVertex(0.30362f, 0.12191f, 0.23933f);
            faces.Add(f351);

            Face f352 = new Face(Material014);
            f352.AddVertex(0.05974f, 0.54715f, 0.21931f);
            f352.AddVertex(0.11702f, 0.52977f, 0.21931f);
            f352.AddVertex(0.11703f, 0.52977f, 0.23933f);
            f352.AddVertex(0.05974f, 0.54715f, 0.23933f);
            faces.Add(f352);

            Face f353 = new Face(Material014);
            f353.AddVertex(-0.34805f, 0.66904f, 0.23074f);
            f353.AddVertex(0.34837f, 0.66904f, 0.23074f);
            f353.AddVertex(0.34869f, 0.66904f, 0.24910f);
            f353.AddVertex(-0.34837f, 0.66904f, 0.24910f);
            faces.Add(f353);

            Face f354 = new Face(Material014);
            f354.AddVertex(0.34837f, 0.92108f, 0.23074f);
            f354.AddVertex(-0.34805f, 0.92108f, 0.23074f);
            f354.AddVertex(-0.34837f, 0.92108f, 0.24910f);
            f354.AddVertex(0.34869f, 0.92108f, 0.24910f);
            faces.Add(f354);

            Face f355 = new Face(Material014);
            f355.AddVertex(0.34837f, 0.66904f, 0.23074f);
            f355.AddVertex(0.34837f, 0.92108f, 0.23074f);
            f355.AddVertex(0.34869f, 0.92108f, 0.24910f);
            f355.AddVertex(0.34869f, 0.66904f, 0.24910f);
            faces.Add(f355);

            Face f356 = new Face(Material014);
            f356.AddVertex(-0.34805f, 0.92108f, 0.23074f);
            f356.AddVertex(-0.34805f, 0.66904f, 0.23074f);
            f356.AddVertex(-0.34837f, 0.66904f, 0.24910f);
            f356.AddVertex(-0.34837f, 0.92108f, 0.24910f);
            faces.Add(f356);

            Face f357 = new Face(Material014);
            f357.AddVertex(0.34869f, 0.66904f, 0.24910f);
            f357.AddVertex(0.34869f, 0.92108f, 0.24910f);
            f357.AddVertex(0.33202f, 0.90590f, 0.24910f);
            f357.AddVertex(0.33202f, 0.68422f, 0.24910f);
            faces.Add(f357);

            Face f358 = new Face(Material014);
            f358.AddVertex(-0.34837f, 0.92108f, 0.24910f);
            f358.AddVertex(-0.34837f, 0.66904f, 0.24910f);
            f358.AddVertex(-0.33170f, 0.68422f, 0.24910f);
            f358.AddVertex(-0.33170f, 0.90590f, 0.24910f);
            faces.Add(f358);

            Face f359 = new Face(Material014);
            f359.AddVertex(-0.34837f, 0.66904f, 0.24910f);
            f359.AddVertex(0.34869f, 0.66904f, 0.24910f);
            f359.AddVertex(0.33202f, 0.68422f, 0.24910f);
            f359.AddVertex(-0.33170f, 0.68422f, 0.24910f);
            faces.Add(f359);

            Face f360 = new Face(Material014);
            f360.AddVertex(0.34869f, 0.92108f, 0.24910f);
            f360.AddVertex(-0.34837f, 0.92108f, 0.24910f);
            f360.AddVertex(-0.33170f, 0.90590f, 0.24910f);
            f360.AddVertex(0.33202f, 0.90590f, 0.24910f);
            faces.Add(f360);

            Face f361 = new Face(Material002);
            f361.AddVertex(-0.36328f, -0.16962f, -0.29323f);
            f361.AddVertex(-0.37045f, -0.12573f, -0.28818f);
            f361.AddVertex(-0.37045f, -0.12573f, -0.32915f);
            f361.AddVertex(-0.36328f, -0.16962f, -0.32410f);
            faces.Add(f361);

            Face f362 = new Face(Material002);
            f362.AddVertex(-0.36328f, -0.16962f, -0.32410f);
            f362.AddVertex(-0.37045f, -0.12573f, -0.32915f);
            f362.AddVertex(-0.31221f, -0.12573f, -0.32915f);
            f362.AddVertex(-0.31939f, -0.16962f, -0.32410f);
            faces.Add(f362);

            Face f363 = new Face(Material002);
            f363.AddVertex(-0.31939f, -0.16962f, -0.32410f);
            f363.AddVertex(-0.31221f, -0.12573f, -0.32915f);
            f363.AddVertex(-0.31221f, -0.12573f, -0.28818f);
            f363.AddVertex(-0.31939f, -0.16962f, -0.29323f);
            faces.Add(f363);

            Face f364 = new Face(Material002);
            f364.AddVertex(-0.31939f, -0.16962f, -0.29323f);
            f364.AddVertex(-0.31221f, -0.12573f, -0.28818f);
            f364.AddVertex(-0.37045f, -0.12573f, -0.28818f);
            f364.AddVertex(-0.36328f, -0.16962f, -0.29323f);
            faces.Add(f364);

            Face f365 = new Face(Material002);
            f365.AddVertex(-0.36328f, -0.16962f, -0.32410f);
            f365.AddVertex(-0.31939f, -0.16962f, -0.32410f);
            f365.AddVertex(-0.31939f, -0.16962f, -0.29323f);
            f365.AddVertex(-0.36328f, -0.16962f, -0.29323f);
            faces.Add(f365);

            Face f366 = new Face(Material002);
            f366.AddVertex(-0.31221f, -0.12573f, -0.32915f);
            f366.AddVertex(-0.37045f, -0.12573f, -0.32915f);
            f366.AddVertex(-0.37045f, -0.12573f, -0.28818f);
            f366.AddVertex(-0.31221f, -0.12573f, -0.28818f);
            faces.Add(f366);

            Face f367 = new Face(Material002);
            f367.AddVertex(0.31170f, -0.16962f, -0.29323f);
            f367.AddVertex(0.30452f, -0.12573f, -0.28818f);
            f367.AddVertex(0.30452f, -0.12573f, -0.32915f);
            f367.AddVertex(0.31170f, -0.16962f, -0.32410f);
            faces.Add(f367);

            Face f368 = new Face(Material002);
            f368.AddVertex(0.31170f, -0.16962f, -0.32410f);
            f368.AddVertex(0.30452f, -0.12573f, -0.32915f);
            f368.AddVertex(0.36277f, -0.12573f, -0.32915f);
            f368.AddVertex(0.35559f, -0.16962f, -0.32410f);
            faces.Add(f368);

            Face f369 = new Face(Material002);
            f369.AddVertex(0.35559f, -0.16962f, -0.32410f);
            f369.AddVertex(0.36277f, -0.12573f, -0.32915f);
            f369.AddVertex(0.36277f, -0.12573f, -0.28818f);
            f369.AddVertex(0.35559f, -0.16962f, -0.29323f);
            faces.Add(f369);

            Face f370 = new Face(Material002);
            f370.AddVertex(0.35559f, -0.16962f, -0.29323f);
            f370.AddVertex(0.36277f, -0.12573f, -0.28818f);
            f370.AddVertex(0.30452f, -0.12573f, -0.28818f);
            f370.AddVertex(0.31170f, -0.16962f, -0.29323f);
            faces.Add(f370);

            Face f371 = new Face(Material002);
            f371.AddVertex(0.31170f, -0.16962f, -0.32410f);
            f371.AddVertex(0.35559f, -0.16962f, -0.32410f);
            f371.AddVertex(0.35559f, -0.16962f, -0.29323f);
            f371.AddVertex(0.31170f, -0.16962f, -0.29323f);
            faces.Add(f371);

            Face f372 = new Face(Material002);
            f372.AddVertex(0.36277f, -0.12573f, -0.32915f);
            f372.AddVertex(0.30452f, -0.12573f, -0.32915f);
            f372.AddVertex(0.30452f, -0.12573f, -0.28818f);
            f372.AddVertex(0.36277f, -0.12573f, -0.28818f);
            faces.Add(f372);

            Face f373 = new Face(Material002);
            f373.AddVertex(-0.36328f, -0.16962f, 0.19563f);
            f373.AddVertex(-0.37045f, -0.12573f, 0.20068f);
            f373.AddVertex(-0.37045f, -0.12573f, 0.15971f);
            f373.AddVertex(-0.36328f, -0.16962f, 0.16476f);
            faces.Add(f373);

            Face f374 = new Face(Material002);
            f374.AddVertex(-0.36328f, -0.16962f, 0.16476f);
            f374.AddVertex(-0.37045f, -0.12573f, 0.15971f);
            f374.AddVertex(-0.31221f, -0.12573f, 0.15971f);
            f374.AddVertex(-0.31939f, -0.16962f, 0.16476f);
            faces.Add(f374);

            Face f375 = new Face(Material002);
            f375.AddVertex(-0.31939f, -0.16962f, 0.16476f);
            f375.AddVertex(-0.31221f, -0.12573f, 0.15971f);
            f375.AddVertex(-0.31221f, -0.12573f, 0.20068f);
            f375.AddVertex(-0.31939f, -0.16962f, 0.19563f);
            faces.Add(f375);

            Face f376 = new Face(Material002);
            f376.AddVertex(-0.31939f, -0.16962f, 0.19563f);
            f376.AddVertex(-0.31221f, -0.12573f, 0.20068f);
            f376.AddVertex(-0.37045f, -0.12573f, 0.20068f);
            f376.AddVertex(-0.36328f, -0.16962f, 0.19563f);
            faces.Add(f376);

            Face f377 = new Face(Material002);
            f377.AddVertex(-0.36328f, -0.16962f, 0.16476f);
            f377.AddVertex(-0.31939f, -0.16962f, 0.16476f);
            f377.AddVertex(-0.31939f, -0.16962f, 0.19563f);
            f377.AddVertex(-0.36328f, -0.16962f, 0.19563f);
            faces.Add(f377);

            Face f378 = new Face(Material002);
            f378.AddVertex(-0.31221f, -0.12573f, 0.15971f);
            f378.AddVertex(-0.37045f, -0.12573f, 0.15971f);
            f378.AddVertex(-0.37045f, -0.12573f, 0.20068f);
            f378.AddVertex(-0.31221f, -0.12573f, 0.20068f);
            faces.Add(f378);

            Face f379 = new Face(Material002);
            f379.AddVertex(0.31170f, -0.16962f, 0.19563f);
            f379.AddVertex(0.30452f, -0.12573f, 0.20068f);
            f379.AddVertex(0.30452f, -0.12573f, 0.15971f);
            f379.AddVertex(0.31170f, -0.16962f, 0.16476f);
            faces.Add(f379);

            Face f380 = new Face(Material002);
            f380.AddVertex(0.31170f, -0.16962f, 0.16476f);
            f380.AddVertex(0.30452f, -0.12573f, 0.15971f);
            f380.AddVertex(0.36277f, -0.12573f, 0.15971f);
            f380.AddVertex(0.35559f, -0.16962f, 0.16476f);
            faces.Add(f380);

            Face f381 = new Face(Material002);
            f381.AddVertex(0.35559f, -0.16962f, 0.16476f);
            f381.AddVertex(0.36277f, -0.12573f, 0.15971f);
            f381.AddVertex(0.36277f, -0.12573f, 0.20068f);
            f381.AddVertex(0.35559f, -0.16962f, 0.19563f);
            faces.Add(f381);

            Face f382 = new Face(Material002);
            f382.AddVertex(0.35559f, -0.16962f, 0.19563f);
            f382.AddVertex(0.36277f, -0.12573f, 0.20068f);
            f382.AddVertex(0.30452f, -0.12573f, 0.20068f);
            f382.AddVertex(0.31170f, -0.16962f, 0.19563f);
            faces.Add(f382);

            Face f383 = new Face(Material002);
            f383.AddVertex(0.31170f, -0.16962f, 0.16476f);
            f383.AddVertex(0.35559f, -0.16962f, 0.16476f);
            f383.AddVertex(0.35559f, -0.16962f, 0.19563f);
            f383.AddVertex(0.31170f, -0.16962f, 0.19563f);
            faces.Add(f383);

            Face f384 = new Face(Material002);
            f384.AddVertex(0.36277f, -0.12573f, 0.15971f);
            f384.AddVertex(0.30452f, -0.12573f, 0.15971f);
            f384.AddVertex(0.30452f, -0.12573f, 0.20068f);
            f384.AddVertex(0.36277f, -0.12573f, 0.20068f);
            faces.Add(f384);

            foreach (Face f in faces)
            {
                for (int i = 0; i < f.vertices.Count; i++)
                {
                    f.vertices[i].x *= 15;
                    f.vertices[i].y *= 15;
                    f.vertices[i].z *= 15;
                }
            }

            return faces;
        }
    }
}
