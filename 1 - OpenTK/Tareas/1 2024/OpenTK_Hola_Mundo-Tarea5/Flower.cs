using OpenTK;
using OpenTK.Graphics;
using System.Collections.Generic;

namespace OpenTK_Hola_Mundo
{
    internal class Flower
    {
        public static List<Face> getFaces()
        {
            List<Face> faces = new List<Face>();

            Color4 m05___Default = new Color4(0.02f, 0.063f, 0.0f, 1.0f);
            Color4 m04___Default = new Color4(0.027f, 0.114f, 0.016f, 1.0f);
            Color4 m03___Default = new Color4(0.314f, 0.055f, 0.071f, 1.0f);
            Color4 m02___Default = new Color4(0.674f, 0.459f, 0.620f, 1.0f);
            Color4 m07___Default = new Color4(0.153f, 0.031f, 0.0f, 1.0f);
            Color4 Material__289 = new Color4(0.788f, 0.788f, 0.788f, 1.0f);

            Face f1 = new Face(m05___Default);
            f1.AddVertex(-0.04755f, 2.32064f, -0.17606f);
            f1.AddVertex(-0.11533f, 1.69003f, -0.04737f);
            f1.AddVertex(0.00757f, 1.69003f, -0.03382f);
            f1.AddVertex(0.07535f, 2.32064f, -0.16251f);
            faces.Add(f1);

            Face f2 = new Face(m05___Default);
            f2.AddVertex(-0.04344f, 2.31007f, -0.21337f);
            f2.AddVertex(-0.11122f, 1.67947f, -0.08467f);
            f2.AddVertex(-0.23412f, 1.67947f, -0.09822f);
            f2.AddVertex(-0.16634f, 2.31007f, -0.22692f);
            faces.Add(f2);

            Face f3 = new Face(m05___Default);
            f3.AddVertex(-0.13749f, 0.95470f, 0.08425f);
            f3.AddVertex(-0.25815f, 0.94942f, 0.05207f);
            f3.AddVertex(-0.13338f, 0.94415f, 0.04694f);
            f3.AddVertex(-0.01272f, 0.94942f, 0.07912f);
            faces.Add(f3);

            Face f4 = new Face(m05___Default);
            f4.AddVertex(-0.29131f, 2.31536f, -0.22181f);
            f4.AddVertex(-0.35908f, 1.68475f, -0.09311f);
            f4.AddVertex(-0.36012f, 1.68739f, -0.08379f);
            f4.AddVertex(-0.29234f, 2.31800f, -0.21249f);
            faces.Add(f4);

            Face f5 = new Face(m05___Default);
            f5.AddVertex(0.49550f, 3.64388f, -1.21311f);
            f5.AddVertex(0.54662f, 3.63861f, -1.22635f);
            f5.AddVertex(0.49962f, 3.63333f, -1.25041f);
            f5.AddVertex(0.44849f, 3.63861f, -1.23717f);
            faces.Add(f5);

            Face f6 = new Face(m05___Default);
            f6.AddVertex(0.20032f, 2.31536f, -0.16762f);
            f6.AddVertex(0.38137f, 2.93529f, -0.49049f);
            f6.AddVertex(0.38035f, 2.93793f, -0.48117f);
            f6.AddVertex(0.19928f, 2.31800f, -0.15829f);
            faces.Add(f6);

            Face f7 = new Face(m05___Default);
            f7.AddVertex(0.52004f, 3.64389f, -1.21040f);
            f7.AddVertex(0.49550f, 3.64388f, -1.21311f);
            f7.AddVertex(0.13350f, 2.94057f, -0.49894f);
            f7.AddVertex(0.25641f, 2.94057f, -0.48539f);
            faces.Add(f7);

            Face f8 = new Face(m05___Default);
            f8.AddVertex(0.13350f, 2.94057f, -0.49894f);
            f8.AddVertex(-0.04755f, 2.32064f, -0.17606f);
            f8.AddVertex(0.07535f, 2.32064f, -0.16251f);
            f8.AddVertex(0.25641f, 2.94057f, -0.48539f);
            faces.Add(f8);

            Face f9 = new Face(m05___Default);
            f9.AddVertex(-0.19885f, 0.95470f, 0.07749f);
            f9.AddVertex(-0.13749f, 0.95470f, 0.08425f);
            f9.AddVertex(-0.11533f, 1.69003f, -0.04737f);
            f9.AddVertex(-0.23824f, 1.69003f, -0.06091f);
            faces.Add(f9);

            Face f10 = new Face(m05___Default);
            f10.AddVertex(0.47508f, 3.63333f, -1.25312f);
            f10.AddVertex(0.49962f, 3.63333f, -1.25041f);
            f10.AddVertex(0.13761f, 2.93001f, -0.53625f);
            f10.AddVertex(0.01471f, 2.93001f, -0.54979f);
            faces.Add(f10);

            Face f11 = new Face(m05___Default);
            f11.AddVertex(0.13761f, 2.93001f, -0.53625f);
            f11.AddVertex(-0.04344f, 2.31007f, -0.21337f);
            f11.AddVertex(-0.16634f, 2.31007f, -0.22692f);
            f11.AddVertex(0.01471f, 2.93001f, -0.54979f);
            faces.Add(f11);

            Face f12 = new Face(m05___Default);
            f12.AddVertex(-0.07202f, 0.94415f, 0.05371f);
            f12.AddVertex(-0.13338f, 0.94415f, 0.04694f);
            f12.AddVertex(-0.11122f, 1.67947f, -0.08467f);
            f12.AddVertex(0.01168f, 1.67947f, -0.07112f);
            faces.Add(f12);

            Face f13 = new Face(m05___Default);
            f13.AddVertex(0.44849f, 3.63861f, -1.23717f);
            f13.AddVertex(-0.11025f, 2.93529f, -0.54469f);
            f13.AddVertex(-0.11128f, 2.93793f, -0.53536f);
            f13.AddVertex(0.44747f, 3.64125f, -1.22784f);
            faces.Add(f13);

            Face f14 = new Face(m05___Default);
            f14.AddVertex(-0.11025f, 2.93529f, -0.54469f);
            f14.AddVertex(-0.29131f, 2.31536f, -0.22181f);
            f14.AddVertex(-0.29234f, 2.31800f, -0.21249f);
            f14.AddVertex(-0.11128f, 2.93793f, -0.53536f);
            faces.Add(f14);

            Face f15 = new Face(m05___Default);
            f15.AddVertex(-0.25815f, 0.94942f, 0.05207f);
            f15.AddVertex(-0.35908f, 1.68475f, -0.09311f);
            f15.AddVertex(-0.35806f, 1.68211f, -0.10244f);
            f15.AddVertex(-0.25713f, 0.94679f, 0.04274f);
            faces.Add(f15);

            Face f16 = new Face(m05___Default);
            f16.AddVertex(-0.01272f, 0.94942f, 0.07912f);
            f16.AddVertex(0.13254f, 1.68475f, -0.03893f);
            f16.AddVertex(0.13151f, 1.68739f, -0.02960f);
            f16.AddVertex(-0.01374f, 0.95206f, 0.08845f);
            faces.Add(f16);

            Face f17 = new Face(m05___Default);
            f17.AddVertex(0.13254f, 1.68475f, -0.03893f);
            f17.AddVertex(0.20032f, 2.31536f, -0.16762f);
            f17.AddVertex(0.19928f, 2.31800f, -0.15829f);
            f17.AddVertex(0.13151f, 1.68739f, -0.02960f);
            faces.Add(f17);

            Face f18 = new Face(m05___Default);
            f18.AddVertex(0.54662f, 3.63861f, -1.22635f);
            f18.AddVertex(0.38137f, 2.93529f, -0.49049f);
            f18.AddVertex(0.38240f, 2.93265f, -0.49982f);
            f18.AddVertex(0.54765f, 3.63597f, -1.23568f);
            faces.Add(f18);

            Face f19 = new Face(m05___Default);
            f19.AddVertex(-0.29336f, 2.32064f, -0.20316f);
            f19.AddVertex(-0.36114f, 1.69003f, -0.07446f);
            f19.AddVertex(-0.23824f, 1.69003f, -0.06091f);
            f19.AddVertex(-0.17046f, 2.32064f, -0.18961f);
            faces.Add(f19);

            Face f20 = new Face(m05___Default);
            f20.AddVertex(-0.17046f, 2.32064f, -0.18961f);
            f20.AddVertex(-0.23824f, 1.69003f, -0.06091f);
            f20.AddVertex(-0.11533f, 1.69003f, -0.04737f);
            f20.AddVertex(-0.04755f, 2.32064f, -0.17606f);
            faces.Add(f20);

            Face f21 = new Face(m05___Default);
            f21.AddVertex(0.13048f, 1.69003f, -0.02027f);
            f21.AddVertex(0.19826f, 2.32064f, -0.14896f);
            f21.AddVertex(0.07535f, 2.32064f, -0.16251f);
            f21.AddVertex(0.00757f, 1.69003f, -0.03382f);
            faces.Add(f21);

            Face f22 = new Face(m05___Default);
            f22.AddVertex(0.20237f, 2.31007f, -0.18627f);
            f22.AddVertex(0.13459f, 1.67947f, -0.05758f);
            f22.AddVertex(0.01168f, 1.67947f, -0.07112f);
            f22.AddVertex(0.07946f, 2.31007f, -0.19982f);
            faces.Add(f22);

            Face f23 = new Face(m05___Default);
            f23.AddVertex(0.07946f, 2.31007f, -0.19982f);
            f23.AddVertex(0.01168f, 1.67947f, -0.07112f);
            f23.AddVertex(-0.11122f, 1.67947f, -0.08467f);
            f23.AddVertex(-0.04344f, 2.31007f, -0.21337f);
            faces.Add(f23);

            Face f24 = new Face(m05___Default);
            f24.AddVertex(-0.35703f, 1.67947f, -0.11177f);
            f24.AddVertex(-0.28925f, 2.31007f, -0.24047f);
            f24.AddVertex(-0.16634f, 2.31007f, -0.22692f);
            f24.AddVertex(-0.23412f, 1.67947f, -0.09822f);
            faces.Add(f24);

            Face f25 = new Face(m05___Default);
            f25.AddVertex(-0.07202f, 0.94415f, 0.05371f);
            f25.AddVertex(-0.01066f, 0.94415f, 0.06047f);
            f25.AddVertex(-0.01169f, 0.94679f, 0.06979f);
            faces.Add(f25);

            Face f26 = new Face(m05___Default);
            f26.AddVertex(-0.07202f, 0.94415f, 0.05371f);
            f26.AddVertex(-0.01169f, 0.94679f, 0.06979f);
            f26.AddVertex(-0.01272f, 0.94942f, 0.07912f);
            f26.AddVertex(-0.13338f, 0.94415f, 0.04694f);
            faces.Add(f26);

            Face f27 = new Face(m05___Default);
            f27.AddVertex(-0.25713f, 0.94679f, 0.04274f);
            f27.AddVertex(-0.25610f, 0.94415f, 0.03341f);
            f27.AddVertex(-0.19474f, 0.94415f, 0.04018f);
            faces.Add(f27);

            Face f28 = new Face(m05___Default);
            f28.AddVertex(-0.25815f, 0.94942f, 0.05207f);
            f28.AddVertex(-0.25713f, 0.94679f, 0.04274f);
            f28.AddVertex(-0.19474f, 0.94415f, 0.04018f);
            f28.AddVertex(-0.13338f, 0.94415f, 0.04694f);
            faces.Add(f28);

            Face f29 = new Face(m05___Default);
            f29.AddVertex(-0.19885f, 0.95470f, 0.07749f);
            f29.AddVertex(-0.26021f, 0.95470f, 0.07072f);
            f29.AddVertex(-0.25919f, 0.95206f, 0.06139f);
            faces.Add(f29);

            Face f30 = new Face(m05___Default);
            f30.AddVertex(-0.19885f, 0.95470f, 0.07749f);
            f30.AddVertex(-0.25919f, 0.95206f, 0.06139f);
            f30.AddVertex(-0.25815f, 0.94942f, 0.05207f);
            f30.AddVertex(-0.13749f, 0.95470f, 0.08425f);
            faces.Add(f30);

            Face f31 = new Face(m05___Default);
            f31.AddVertex(-0.01374f, 0.95206f, 0.08845f);
            f31.AddVertex(-0.01477f, 0.95470f, 0.09777f);
            f31.AddVertex(-0.07613f, 0.95470f, 0.09101f);
            faces.Add(f31);

            Face f32 = new Face(m05___Default);
            f32.AddVertex(-0.01272f, 0.94942f, 0.07912f);
            f32.AddVertex(-0.01374f, 0.95206f, 0.08845f);
            f32.AddVertex(-0.07613f, 0.95470f, 0.09101f);
            f32.AddVertex(-0.13749f, 0.95470f, 0.08425f);
            faces.Add(f32);

            Face f33 = new Face(m05___Default);
            f33.AddVertex(-0.28925f, 2.31007f, -0.24047f);
            f33.AddVertex(-0.35703f, 1.67947f, -0.11177f);
            f33.AddVertex(-0.35806f, 1.68211f, -0.10244f);
            f33.AddVertex(-0.29028f, 2.31272f, -0.23114f);
            faces.Add(f33);

            Face f34 = new Face(m05___Default);
            f34.AddVertex(-0.29028f, 2.31272f, -0.23114f);
            f34.AddVertex(-0.35806f, 1.68211f, -0.10244f);
            f34.AddVertex(-0.35908f, 1.68475f, -0.09311f);
            f34.AddVertex(-0.29131f, 2.31536f, -0.22181f);
            faces.Add(f34);

            Face f35 = new Face(m05___Default);
            f35.AddVertex(-0.36114f, 1.69003f, -0.07446f);
            f35.AddVertex(-0.29336f, 2.32064f, -0.20316f);
            f35.AddVertex(-0.29234f, 2.31800f, -0.21249f);
            f35.AddVertex(-0.36012f, 1.68739f, -0.08379f);
            faces.Add(f35);

            Face f36 = new Face(m05___Default);
            f36.AddVertex(0.47508f, 3.63333f, -1.25312f);
            f36.AddVertex(0.45055f, 3.63333f, -1.25582f);
            f36.AddVertex(0.44952f, 3.63597f, -1.24650f);
            faces.Add(f36);

            Face f37 = new Face(m05___Default);
            f37.AddVertex(0.47508f, 3.63333f, -1.25312f);
            f37.AddVertex(0.44952f, 3.63597f, -1.24650f);
            f37.AddVertex(0.44849f, 3.63861f, -1.23717f);
            f37.AddVertex(0.49962f, 3.63333f, -1.25041f);
            faces.Add(f37);

            Face f38 = new Face(m05___Default);
            f38.AddVertex(0.54765f, 3.63597f, -1.23568f);
            f38.AddVertex(0.54868f, 3.63333f, -1.24501f);
            f38.AddVertex(0.52415f, 3.63333f, -1.24771f);
            faces.Add(f38);

            Face f39 = new Face(m05___Default);
            f39.AddVertex(0.54662f, 3.63861f, -1.22635f);
            f39.AddVertex(0.54765f, 3.63597f, -1.23568f);
            f39.AddVertex(0.52415f, 3.63333f, -1.24771f);
            f39.AddVertex(0.49962f, 3.63333f, -1.25041f);
            faces.Add(f39);

            Face f40 = new Face(m05___Default);
            f40.AddVertex(0.52004f, 3.64389f, -1.21040f);
            f40.AddVertex(0.54457f, 3.64389f, -1.20770f);
            f40.AddVertex(0.54560f, 3.64125f, -1.21702f);
            faces.Add(f40);

            Face f41 = new Face(m05___Default);
            f41.AddVertex(0.52004f, 3.64389f, -1.21040f);
            f41.AddVertex(0.54560f, 3.64125f, -1.21702f);
            f41.AddVertex(0.54662f, 3.63861f, -1.22635f);
            f41.AddVertex(0.49550f, 3.64388f, -1.21311f);
            faces.Add(f41);

            Face f42 = new Face(m05___Default);
            f42.AddVertex(0.44747f, 3.64125f, -1.22784f);
            f42.AddVertex(0.44644f, 3.64389f, -1.21852f);
            f42.AddVertex(0.47097f, 3.64389f, -1.21581f);
            faces.Add(f42);

            Face f43 = new Face(m05___Default);
            f43.AddVertex(0.44849f, 3.63861f, -1.23717f);
            f43.AddVertex(0.44747f, 3.64125f, -1.22784f);
            f43.AddVertex(0.47097f, 3.64389f, -1.21581f);
            f43.AddVertex(0.49550f, 3.64388f, -1.21311f);
            faces.Add(f43);

            Face f44 = new Face(m05___Default);
            f44.AddVertex(0.20237f, 2.31007f, -0.18627f);
            f44.AddVertex(0.38343f, 2.93001f, -0.50915f);
            f44.AddVertex(0.38240f, 2.93265f, -0.49982f);
            f44.AddVertex(0.20134f, 2.31272f, -0.17695f);
            faces.Add(f44);

            Face f45 = new Face(m05___Default);
            f45.AddVertex(0.20134f, 2.31272f, -0.17695f);
            f45.AddVertex(0.38240f, 2.93265f, -0.49982f);
            f45.AddVertex(0.38137f, 2.93529f, -0.49049f);
            f45.AddVertex(0.20032f, 2.31536f, -0.16762f);
            faces.Add(f45);

            Face f46 = new Face(m05___Default);
            f46.AddVertex(0.37932f, 2.94057f, -0.47184f);
            f46.AddVertex(0.19826f, 2.32064f, -0.14896f);
            f46.AddVertex(0.19928f, 2.31800f, -0.15829f);
            f46.AddVertex(0.38035f, 2.93793f, -0.48117f);
            faces.Add(f46);

            Face f47 = new Face(m05___Default);
            f47.AddVertex(0.44644f, 3.64389f, -1.21852f);
            f47.AddVertex(-0.11231f, 2.94057f, -0.52603f);
            f47.AddVertex(0.01059f, 2.94057f, -0.51249f);
            f47.AddVertex(0.47097f, 3.64389f, -1.21581f);
            faces.Add(f47);

            Face f48 = new Face(m05___Default);
            f48.AddVertex(0.47097f, 3.64389f, -1.21581f);
            f48.AddVertex(0.01059f, 2.94057f, -0.51249f);
            f48.AddVertex(0.13350f, 2.94057f, -0.49894f);
            f48.AddVertex(0.49550f, 3.64388f, -1.21311f);
            faces.Add(f48);

            Face f49 = new Face(m05___Default);
            f49.AddVertex(0.25641f, 2.94057f, -0.48539f);
            f49.AddVertex(0.37932f, 2.94057f, -0.47184f);
            f49.AddVertex(0.54457f, 3.64389f, -1.20770f);
            f49.AddVertex(0.52004f, 3.64389f, -1.21040f);
            faces.Add(f49);

            Face f50 = new Face(m05___Default);
            f50.AddVertex(-0.11231f, 2.94057f, -0.52603f);
            f50.AddVertex(-0.29336f, 2.32064f, -0.20316f);
            f50.AddVertex(-0.17046f, 2.32064f, -0.18961f);
            f50.AddVertex(0.01059f, 2.94057f, -0.51249f);
            faces.Add(f50);

            Face f51 = new Face(m05___Default);
            f51.AddVertex(0.01059f, 2.94057f, -0.51249f);
            f51.AddVertex(-0.17046f, 2.32064f, -0.18961f);
            f51.AddVertex(-0.04755f, 2.32064f, -0.17606f);
            f51.AddVertex(0.13350f, 2.94057f, -0.49894f);
            faces.Add(f51);

            Face f52 = new Face(m05___Default);
            f52.AddVertex(0.19826f, 2.32064f, -0.14896f);
            f52.AddVertex(0.37932f, 2.94057f, -0.47184f);
            f52.AddVertex(0.25641f, 2.94057f, -0.48539f);
            f52.AddVertex(0.07535f, 2.32064f, -0.16251f);
            faces.Add(f52);

            Face f53 = new Face(m05___Default);
            f53.AddVertex(-0.01477f, 0.95470f, 0.09777f);
            f53.AddVertex(0.13048f, 1.69003f, -0.02027f);
            f53.AddVertex(0.00757f, 1.69003f, -0.03382f);
            f53.AddVertex(-0.07613f, 0.95470f, 0.09101f);
            faces.Add(f53);

            Face f54 = new Face(m05___Default);
            f54.AddVertex(-0.07613f, 0.95470f, 0.09101f);
            f54.AddVertex(0.00757f, 1.69003f, -0.03382f);
            f54.AddVertex(-0.11533f, 1.69003f, -0.04737f);
            f54.AddVertex(-0.13749f, 0.95470f, 0.08425f);
            faces.Add(f54);

            Face f55 = new Face(m05___Default);
            f55.AddVertex(-0.23824f, 1.69003f, -0.06091f);
            f55.AddVertex(-0.36114f, 1.69003f, -0.07446f);
            f55.AddVertex(-0.26021f, 0.95470f, 0.07072f);
            f55.AddVertex(-0.19885f, 0.95470f, 0.07749f);
            faces.Add(f55);

            Face f56 = new Face(m05___Default);
            f56.AddVertex(0.54868f, 3.63333f, -1.24501f);
            f56.AddVertex(0.38343f, 2.93001f, -0.50915f);
            f56.AddVertex(0.26052f, 2.93001f, -0.52270f);
            f56.AddVertex(0.52415f, 3.63333f, -1.24771f);
            faces.Add(f56);

            Face f57 = new Face(m05___Default);
            f57.AddVertex(0.52415f, 3.63333f, -1.24771f);
            f57.AddVertex(0.26052f, 2.93001f, -0.52270f);
            f57.AddVertex(0.13761f, 2.93001f, -0.53625f);
            f57.AddVertex(0.49962f, 3.63333f, -1.25041f);
            faces.Add(f57);

            Face f58 = new Face(m05___Default);
            f58.AddVertex(0.01471f, 2.93001f, -0.54979f);
            f58.AddVertex(-0.10819f, 2.93001f, -0.56334f);
            f58.AddVertex(0.45055f, 3.63333f, -1.25582f);
            f58.AddVertex(0.47508f, 3.63333f, -1.25312f);
            faces.Add(f58);

            Face f59 = new Face(m05___Default);
            f59.AddVertex(0.38343f, 2.93001f, -0.50915f);
            f59.AddVertex(0.20237f, 2.31007f, -0.18627f);
            f59.AddVertex(0.07946f, 2.31007f, -0.19982f);
            f59.AddVertex(0.26052f, 2.93001f, -0.52270f);
            faces.Add(f59);

            Face f60 = new Face(m05___Default);
            f60.AddVertex(0.26052f, 2.93001f, -0.52270f);
            f60.AddVertex(0.07946f, 2.31007f, -0.19982f);
            f60.AddVertex(-0.04344f, 2.31007f, -0.21337f);
            f60.AddVertex(0.13761f, 2.93001f, -0.53625f);
            faces.Add(f60);

            Face f61 = new Face(m05___Default);
            f61.AddVertex(-0.28925f, 2.31007f, -0.24047f);
            f61.AddVertex(-0.10819f, 2.93001f, -0.56334f);
            f61.AddVertex(0.01471f, 2.93001f, -0.54979f);
            f61.AddVertex(-0.16634f, 2.31007f, -0.22692f);
            faces.Add(f61);

            Face f62 = new Face(m05___Default);
            f62.AddVertex(-0.25610f, 0.94415f, 0.03341f);
            f62.AddVertex(-0.35703f, 1.67947f, -0.11177f);
            f62.AddVertex(-0.23412f, 1.67947f, -0.09822f);
            f62.AddVertex(-0.19474f, 0.94415f, 0.04018f);
            faces.Add(f62);

            Face f63 = new Face(m05___Default);
            f63.AddVertex(-0.19474f, 0.94415f, 0.04018f);
            f63.AddVertex(-0.23412f, 1.67947f, -0.09822f);
            f63.AddVertex(-0.11122f, 1.67947f, -0.08467f);
            f63.AddVertex(-0.13338f, 0.94415f, 0.04694f);
            faces.Add(f63);

            Face f64 = new Face(m05___Default);
            f64.AddVertex(0.01168f, 1.67947f, -0.07112f);
            f64.AddVertex(0.13459f, 1.67947f, -0.05758f);
            f64.AddVertex(-0.01066f, 0.94415f, 0.06047f);
            f64.AddVertex(-0.07202f, 0.94415f, 0.05371f);
            faces.Add(f64);

            Face f65 = new Face(m05___Default);
            f65.AddVertex(0.45055f, 3.63333f, -1.25582f);
            f65.AddVertex(-0.10819f, 2.93001f, -0.56334f);
            f65.AddVertex(-0.10922f, 2.93265f, -0.55401f);
            f65.AddVertex(0.44952f, 3.63597f, -1.24650f);
            faces.Add(f65);

            Face f66 = new Face(m05___Default);
            f66.AddVertex(0.44952f, 3.63597f, -1.24650f);
            f66.AddVertex(-0.10922f, 2.93265f, -0.55401f);
            f66.AddVertex(-0.11025f, 2.93529f, -0.54469f);
            f66.AddVertex(0.44849f, 3.63861f, -1.23717f);
            faces.Add(f66);

            Face f67 = new Face(m05___Default);
            f67.AddVertex(-0.11231f, 2.94057f, -0.52603f);
            f67.AddVertex(0.44644f, 3.64389f, -1.21852f);
            f67.AddVertex(0.44747f, 3.64125f, -1.22784f);
            f67.AddVertex(-0.11128f, 2.93793f, -0.53536f);
            faces.Add(f67);

            Face f68 = new Face(m05___Default);
            f68.AddVertex(-0.10819f, 2.93001f, -0.56334f);
            f68.AddVertex(-0.28925f, 2.31007f, -0.24047f);
            f68.AddVertex(-0.29028f, 2.31272f, -0.23114f);
            f68.AddVertex(-0.10922f, 2.93265f, -0.55401f);
            faces.Add(f68);

            Face f69 = new Face(m05___Default);
            f69.AddVertex(-0.10922f, 2.93265f, -0.55401f);
            f69.AddVertex(-0.29028f, 2.31272f, -0.23114f);
            f69.AddVertex(-0.29131f, 2.31536f, -0.22181f);
            f69.AddVertex(-0.11025f, 2.93529f, -0.54469f);
            faces.Add(f69);

            Face f70 = new Face(m05___Default);
            f70.AddVertex(-0.29336f, 2.32064f, -0.20316f);
            f70.AddVertex(-0.11231f, 2.94057f, -0.52603f);
            f70.AddVertex(-0.11128f, 2.93793f, -0.53536f);
            f70.AddVertex(-0.29234f, 2.31800f, -0.21249f);
            faces.Add(f70);

            Face f71 = new Face(m05___Default);
            f71.AddVertex(-0.26021f, 0.95470f, 0.07072f);
            f71.AddVertex(-0.36114f, 1.69003f, -0.07446f);
            f71.AddVertex(-0.36012f, 1.68739f, -0.08379f);
            f71.AddVertex(-0.25919f, 0.95206f, 0.06139f);
            faces.Add(f71);

            Face f72 = new Face(m05___Default);
            f72.AddVertex(-0.25919f, 0.95206f, 0.06139f);
            f72.AddVertex(-0.36012f, 1.68739f, -0.08379f);
            f72.AddVertex(-0.35908f, 1.68475f, -0.09311f);
            f72.AddVertex(-0.25815f, 0.94942f, 0.05207f);
            faces.Add(f72);

            Face f73 = new Face(m05___Default);
            f73.AddVertex(-0.35703f, 1.67947f, -0.11177f);
            f73.AddVertex(-0.25610f, 0.94415f, 0.03341f);
            f73.AddVertex(-0.25713f, 0.94679f, 0.04274f);
            f73.AddVertex(-0.35806f, 1.68211f, -0.10244f);
            faces.Add(f73);

            Face f74 = new Face(m05___Default);
            f74.AddVertex(-0.01066f, 0.94415f, 0.06047f);
            f74.AddVertex(0.13459f, 1.67947f, -0.05758f);
            f74.AddVertex(0.13356f, 1.68211f, -0.04825f);
            f74.AddVertex(-0.01169f, 0.94679f, 0.06979f);
            faces.Add(f74);

            Face f75 = new Face(m05___Default);
            f75.AddVertex(-0.01169f, 0.94679f, 0.06979f);
            f75.AddVertex(0.13356f, 1.68211f, -0.04825f);
            f75.AddVertex(0.13254f, 1.68475f, -0.03893f);
            f75.AddVertex(-0.01272f, 0.94942f, 0.07912f);
            faces.Add(f75);

            Face f76 = new Face(m05___Default);
            f76.AddVertex(0.13048f, 1.69003f, -0.02027f);
            f76.AddVertex(-0.01477f, 0.95470f, 0.09777f);
            f76.AddVertex(-0.01374f, 0.95206f, 0.08845f);
            f76.AddVertex(0.13151f, 1.68739f, -0.02960f);
            faces.Add(f76);

            Face f77 = new Face(m05___Default);
            f77.AddVertex(0.13459f, 1.67947f, -0.05758f);
            f77.AddVertex(0.20237f, 2.31007f, -0.18627f);
            f77.AddVertex(0.20134f, 2.31272f, -0.17695f);
            f77.AddVertex(0.13356f, 1.68211f, -0.04825f);
            faces.Add(f77);

            Face f78 = new Face(m05___Default);
            f78.AddVertex(0.13356f, 1.68211f, -0.04825f);
            f78.AddVertex(0.20134f, 2.31272f, -0.17695f);
            f78.AddVertex(0.20032f, 2.31536f, -0.16762f);
            f78.AddVertex(0.13254f, 1.68475f, -0.03893f);
            faces.Add(f78);

            Face f79 = new Face(m05___Default);
            f79.AddVertex(0.19826f, 2.32064f, -0.14896f);
            f79.AddVertex(0.13048f, 1.69003f, -0.02027f);
            f79.AddVertex(0.13151f, 1.68739f, -0.02960f);
            f79.AddVertex(0.19928f, 2.31800f, -0.15829f);
            faces.Add(f79);

            Face f80 = new Face(m05___Default);
            f80.AddVertex(0.54457f, 3.64389f, -1.20770f);
            f80.AddVertex(0.37932f, 2.94057f, -0.47184f);
            f80.AddVertex(0.38035f, 2.93793f, -0.48117f);
            f80.AddVertex(0.54560f, 3.64125f, -1.21702f);
            faces.Add(f80);

            Face f81 = new Face(m05___Default);
            f81.AddVertex(0.54560f, 3.64125f, -1.21702f);
            f81.AddVertex(0.38035f, 2.93793f, -0.48117f);
            f81.AddVertex(0.38137f, 2.93529f, -0.49049f);
            f81.AddVertex(0.54662f, 3.63861f, -1.22635f);
            faces.Add(f81);

            Face f82 = new Face(m05___Default);
            f82.AddVertex(0.38343f, 2.93001f, -0.50915f);
            f82.AddVertex(0.54868f, 3.63333f, -1.24501f);
            f82.AddVertex(0.54765f, 3.63597f, -1.23568f);
            f82.AddVertex(0.38240f, 2.93265f, -0.49982f);
            faces.Add(f82);

            Face f83 = new Face(m05___Default);
            f83.AddVertex(0.16796f, 2.31766f, -0.03165f);
            f83.AddVertex(0.02156f, 1.68935f, -0.00437f);
            f83.AddVertex(-0.01995f, 1.68653f, 0.10493f);
            f83.AddVertex(0.10705f, 2.31353f, 0.12869f);
            faces.Add(f83);

            Face f84 = new Face(m05___Default);
            f84.AddVertex(0.21397f, 2.30627f, -0.03077f);
            f84.AddVertex(0.05291f, 1.67792f, -0.00360f);
            f84.AddVertex(0.09443f, 1.68073f, -0.11291f);
            f84.AddVertex(0.27489f, 2.31040f, -0.19113f);
            faces.Add(f84);

            Face f85 = new Face(m05___Default);
            f85.AddVertex(-0.10082f, 0.95620f, 0.02785f);
            f85.AddVertex(-0.06285f, 0.95234f, -0.04436f);
            f85.AddVertex(-0.08000f, 0.94475f, 0.02853f);
            f85.AddVertex(-0.11797f, 0.94861f, 0.10075f);
            faces.Add(f85);

            Face f86 = new Face(m05___Default);
            f86.AddVertex(0.31280f, 2.32022f, -0.35192f);
            f86.AddVertex(0.12028f, 1.68926f, -0.22260f);
            f86.AddVertex(0.11244f, 1.69211f, -0.22279f);
            f86.AddVertex(0.30130f, 2.32306f, -0.35214f);
            faces.Add(f86);

            Face f87 = new Face(m05___Default);
            f87.AddVertex(1.59368f, 3.61888f, -0.07921f);
            f87.AddVertex(1.59237f, 3.61154f, -0.01476f);
            f87.AddVertex(1.63969f, 3.60749f, -0.07833f);
            f87.AddVertex(1.64100f, 3.61483f, -0.14278f);
            faces.Add(f87);

            Face f88 = new Face(m05___Default);
            f88.AddVertex(0.06913f, 2.30371f, 0.28950f);
            f88.AddVertex(0.50895f, 2.91698f, 0.26523f);
            f88.AddVertex(0.49745f, 2.91982f, 0.26501f);
            f88.AddVertex(0.05763f, 2.30656f, 0.28927f);
            faces.Add(f88);

            Face f89 = new Face(m05___Default);
            f89.AddVertex(1.58152f, 3.61805f, -0.04721f);
            f89.AddVertex(1.59368f, 3.61888f, -0.07921f);
            f89.AddVertex(0.60778f, 2.93092f, -0.05592f);
            f89.AddVertex(0.54686f, 2.92680f, 0.10443f);
            faces.Add(f89);

            Face f90 = new Face(m05___Default);
            f90.AddVertex(0.60778f, 2.93092f, -0.05592f);
            f90.AddVertex(0.16796f, 2.31766f, -0.03165f);
            f90.AddVertex(0.10705f, 2.31353f, 0.12869f);
            f90.AddVertex(0.54686f, 2.92680f, 0.10443f);
            faces.Add(f90);

            Face f91 = new Face(m05___Default);
            f91.AddVertex(-0.08704f, 0.95713f, -0.00843f);
            f91.AddVertex(-0.10082f, 0.95620f, 0.02785f);
            f91.AddVertex(0.02156f, 1.68935f, -0.00437f);
            f91.AddVertex(0.06308f, 1.69216f, -0.11367f);
            faces.Add(f91);

            Face f92 = new Face(m05___Default);
            f92.AddVertex(1.65185f, 3.60831f, -0.11034f);
            f92.AddVertex(1.63969f, 3.60749f, -0.07833f);
            f92.AddVertex(0.65379f, 2.91953f, -0.05504f);
            f92.AddVertex(0.71470f, 2.92366f, -0.21539f);
            faces.Add(f92);

            Face f93 = new Face(m05___Default);
            f93.AddVertex(0.65379f, 2.91953f, -0.05504f);
            f93.AddVertex(0.21397f, 2.30627f, -0.03077f);
            f93.AddVertex(0.27489f, 2.31040f, -0.19113f);
            f93.AddVertex(0.71470f, 2.92366f, -0.21539f);
            faces.Add(f93);

            Face f94 = new Face(m05___Default);
            f94.AddVertex(-0.09378f, 0.94381f, 0.06481f);
            f94.AddVertex(-0.08000f, 0.94475f, 0.02853f);
            f94.AddVertex(0.05291f, 1.67792f, -0.00360f);
            f94.AddVertex(0.01139f, 1.67510f, 0.10570f);
            faces.Add(f94);

            Face f95 = new Face(m05___Default);
            f95.AddVertex(1.64100f, 3.61483f, -0.14278f);
            f95.AddVertex(0.75262f, 2.93348f, -0.37619f);
            f95.AddVertex(0.74111f, 2.93633f, -0.37641f);
            f95.AddVertex(1.62950f, 3.61767f, -0.14301f);
            faces.Add(f95);

            Face f96 = new Face(m05___Default);
            f96.AddVertex(0.75262f, 2.93348f, -0.37619f);
            f96.AddVertex(0.31280f, 2.32022f, -0.35192f);
            f96.AddVertex(0.30130f, 2.32306f, -0.35214f);
            f96.AddVertex(0.74111f, 2.93633f, -0.37641f);
            faces.Add(f96);

            Face f97 = new Face(m05___Default);
            f97.AddVertex(-0.06285f, 0.95234f, -0.04436f);
            f97.AddVertex(0.12028f, 1.68926f, -0.22260f);
            f97.AddVertex(0.12812f, 1.68640f, -0.22241f);
            f97.AddVertex(-0.05764f, 0.94948f, -0.04419f);
            faces.Add(f97);

            Face f98 = new Face(m05___Default);
            f98.AddVertex(-0.11797f, 0.94861f, 0.10075f);
            f98.AddVertex(-0.04580f, 1.67801f, 0.21462f);
            f98.AddVertex(-0.05364f, 1.68086f, 0.21443f);
            f98.AddVertex(-0.12318f, 0.95147f, 0.10058f);
            faces.Add(f98);

            Face f99 = new Face(m05___Default);
            f99.AddVertex(-0.04580f, 1.67801f, 0.21462f);
            f99.AddVertex(0.06913f, 2.30371f, 0.28950f);
            f99.AddVertex(0.05763f, 2.30656f, 0.28927f);
            f99.AddVertex(-0.05364f, 1.68086f, 0.21443f);
            faces.Add(f99);

            Face f100 = new Face(m05___Default);
            f100.AddVertex(1.59237f, 3.61154f, -0.01476f);
            f100.AddVertex(0.50895f, 2.91698f, 0.26523f);
            f100.AddVertex(0.52045f, 2.91413f, 0.26545f);
            f100.AddVertex(1.60387f, 3.60869f, -0.01454f);
            faces.Add(f100);

            Face f101 = new Face(m05___Default);
            f101.AddVertex(0.28979f, 2.32591f, -0.35236f);
            f101.AddVertex(0.10461f, 1.69497f, -0.22298f);
            f101.AddVertex(0.06308f, 1.69216f, -0.11367f);
            f101.AddVertex(0.22888f, 2.32178f, -0.19201f);
            faces.Add(f101);

            Face f102 = new Face(m05___Default);
            f102.AddVertex(0.22888f, 2.32178f, -0.19201f);
            f102.AddVertex(0.06308f, 1.69216f, -0.11367f);
            f102.AddVertex(0.02156f, 1.68935f, -0.00437f);
            f102.AddVertex(0.16796f, 2.31766f, -0.03165f);
            faces.Add(f102);

            Face f103 = new Face(m05___Default);
            f103.AddVertex(-0.06148f, 1.68372f, 0.21424f);
            f103.AddVertex(0.04612f, 2.30941f, 0.28905f);
            f103.AddVertex(0.10705f, 2.31353f, 0.12869f);
            f103.AddVertex(-0.01995f, 1.68653f, 0.10493f);
            faces.Add(f103);

            Face f104 = new Face(m05___Default);
            f104.AddVertex(0.09214f, 2.29802f, 0.28994f);
            f104.AddVertex(-0.03013f, 1.67229f, 0.21501f);
            f104.AddVertex(0.01139f, 1.67510f, 0.10570f);
            f104.AddVertex(0.15306f, 2.30214f, 0.12958f);
            faces.Add(f104);

            Face f105 = new Face(m05___Default);
            f105.AddVertex(0.15306f, 2.30214f, 0.12958f);
            f105.AddVertex(0.01139f, 1.67510f, 0.10570f);
            f105.AddVertex(0.05291f, 1.67792f, -0.00360f);
            f105.AddVertex(0.21397f, 2.30627f, -0.03077f);
            faces.Add(f105);

            Face f106 = new Face(m05___Default);
            f106.AddVertex(0.13596f, 1.68354f, -0.22221f);
            f106.AddVertex(0.33581f, 2.31452f, -0.35148f);
            f106.AddVertex(0.27489f, 2.31040f, -0.19113f);
            f106.AddVertex(0.09443f, 1.68073f, -0.11291f);
            faces.Add(f106);

            Face f107 = new Face(m05___Default);
            f107.AddVertex(-0.09378f, 0.94381f, 0.06481f);
            f107.AddVertex(-0.10756f, 0.94288f, 0.10109f);
            f107.AddVertex(-0.11277f, 0.94574f, 0.10092f);
            faces.Add(f107);

            Face f108 = new Face(m05___Default);
            f108.AddVertex(-0.09378f, 0.94381f, 0.06481f);
            f108.AddVertex(-0.11277f, 0.94574f, 0.10092f);
            f108.AddVertex(-0.11797f, 0.94861f, 0.10075f);
            f108.AddVertex(-0.08000f, 0.94475f, 0.02853f);
            faces.Add(f108);

            Face f109 = new Face(m05___Default);
            f109.AddVertex(-0.05764f, 0.94948f, -0.04419f);
            f109.AddVertex(-0.05244f, 0.94661f, -0.04402f);
            f109.AddVertex(-0.06622f, 0.94568f, -0.00774f);
            faces.Add(f109);

            Face f110 = new Face(m05___Default);
            f110.AddVertex(-0.06285f, 0.95234f, -0.04436f);
            f110.AddVertex(-0.05764f, 0.94948f, -0.04419f);
            f110.AddVertex(-0.06622f, 0.94568f, -0.00774f);
            f110.AddVertex(-0.08000f, 0.94475f, 0.02853f);
            faces.Add(f110);

            Face f111 = new Face(m05___Default);
            f111.AddVertex(-0.08704f, 0.95713f, -0.00843f);
            f111.AddVertex(-0.07326f, 0.95807f, -0.04471f);
            f111.AddVertex(-0.06805f, 0.95520f, -0.04453f);
            faces.Add(f111);

            Face f112 = new Face(m05___Default);
            f112.AddVertex(-0.08704f, 0.95713f, -0.00843f);
            f112.AddVertex(-0.06805f, 0.95520f, -0.04453f);
            f112.AddVertex(-0.06285f, 0.95234f, -0.04436f);
            f112.AddVertex(-0.10082f, 0.95620f, 0.02785f);
            faces.Add(f112);

            Face f113 = new Face(m05___Default);
            f113.AddVertex(-0.12318f, 0.95147f, 0.10058f);
            f113.AddVertex(-0.12839f, 0.95433f, 0.10041f);
            f113.AddVertex(-0.11460f, 0.95526f, 0.06413f);
            faces.Add(f113);

            Face f114 = new Face(m05___Default);
            f114.AddVertex(-0.11797f, 0.94861f, 0.10075f);
            f114.AddVertex(-0.12318f, 0.95147f, 0.10058f);
            f114.AddVertex(-0.11460f, 0.95526f, 0.06413f);
            f114.AddVertex(-0.10082f, 0.95620f, 0.02785f);
            faces.Add(f114);

            Face f115 = new Face(m05___Default);
            f115.AddVertex(0.33581f, 2.31452f, -0.35148f);
            f115.AddVertex(0.13596f, 1.68354f, -0.22221f);
            f115.AddVertex(0.12812f, 1.68640f, -0.22241f);
            f115.AddVertex(0.32430f, 2.31737f, -0.35170f);
            faces.Add(f115);

            Face f116 = new Face(m05___Default);
            f116.AddVertex(0.32430f, 2.31737f, -0.35170f);
            f116.AddVertex(0.12812f, 1.68640f, -0.22241f);
            f116.AddVertex(0.12028f, 1.68926f, -0.22260f);
            f116.AddVertex(0.31280f, 2.32022f, -0.35192f);
            faces.Add(f116);

            Face f117 = new Face(m05___Default);
            f117.AddVertex(0.10461f, 1.69497f, -0.22298f);
            f117.AddVertex(0.28979f, 2.32591f, -0.35236f);
            f117.AddVertex(0.30130f, 2.32306f, -0.35214f);
            f117.AddVertex(0.11244f, 1.69211f, -0.22279f);
            faces.Add(f117);

            Face f118 = new Face(m05___Default);
            f118.AddVertex(1.65185f, 3.60831f, -0.11034f);
            f118.AddVertex(1.66401f, 3.60913f, -0.14234f);
            f118.AddVertex(1.65251f, 3.61198f, -0.14256f);
            faces.Add(f118);

            Face f119 = new Face(m05___Default);
            f119.AddVertex(1.65185f, 3.60831f, -0.11034f);
            f119.AddVertex(1.65251f, 3.61198f, -0.14256f);
            f119.AddVertex(1.64100f, 3.61483f, -0.14278f);
            f119.AddVertex(1.63969f, 3.60749f, -0.07833f);
            faces.Add(f119);

            Face f120 = new Face(m05___Default);
            f120.AddVertex(1.60387f, 3.60869f, -0.01454f);
            f120.AddVertex(1.61537f, 3.60585f, -0.01432f);
            f120.AddVertex(1.62753f, 3.60667f, -0.04633f);
            faces.Add(f120);

            Face f121 = new Face(m05___Default);
            f121.AddVertex(1.59237f, 3.61154f, -0.01476f);
            f121.AddVertex(1.60387f, 3.60869f, -0.01454f);
            f121.AddVertex(1.62753f, 3.60667f, -0.04633f);
            f121.AddVertex(1.63969f, 3.60749f, -0.07833f);
            faces.Add(f121);

            Face f122 = new Face(m05___Default);
            f122.AddVertex(1.58152f, 3.61805f, -0.04721f);
            f122.AddVertex(1.56936f, 3.61723f, -0.01520f);
            f122.AddVertex(1.58086f, 3.61439f, -0.01498f);
            faces.Add(f122);

            Face f123 = new Face(m05___Default);
            f123.AddVertex(1.58152f, 3.61805f, -0.04721f);
            f123.AddVertex(1.58086f, 3.61439f, -0.01498f);
            f123.AddVertex(1.59237f, 3.61154f, -0.01476f);
            f123.AddVertex(1.59368f, 3.61888f, -0.07921f);
            faces.Add(f123);

            Face f124 = new Face(m05___Default);
            f124.AddVertex(1.62950f, 3.61767f, -0.14301f);
            f124.AddVertex(1.61800f, 3.62052f, -0.14323f);
            f124.AddVertex(1.60583f, 3.61970f, -0.11122f);
            faces.Add(f124);

            Face f125 = new Face(m05___Default);
            f125.AddVertex(1.64100f, 3.61483f, -0.14278f);
            f125.AddVertex(1.62950f, 3.61767f, -0.14301f);
            f125.AddVertex(1.60583f, 3.61970f, -0.11122f);
            f125.AddVertex(1.59368f, 3.61888f, -0.07921f);
            faces.Add(f125);

            Face f126 = new Face(m05___Default);
            f126.AddVertex(0.09214f, 2.29802f, 0.28994f);
            f126.AddVertex(0.53196f, 2.91128f, 0.26567f);
            f126.AddVertex(0.52045f, 2.91413f, 0.26545f);
            f126.AddVertex(0.08064f, 2.30086f, 0.28972f);
            faces.Add(f126);

            Face f127 = new Face(m05___Default);
            f127.AddVertex(0.08064f, 2.30086f, 0.28972f);
            f127.AddVertex(0.52045f, 2.91413f, 0.26545f);
            f127.AddVertex(0.50895f, 2.91698f, 0.26523f);
            f127.AddVertex(0.06913f, 2.30371f, 0.28950f);
            faces.Add(f127);

            Face f128 = new Face(m05___Default);
            f128.AddVertex(0.48594f, 2.92267f, 0.26479f);
            f128.AddVertex(0.04612f, 2.30941f, 0.28905f);
            f128.AddVertex(0.05763f, 2.30656f, 0.28927f);
            f128.AddVertex(0.49745f, 2.91982f, 0.26501f);
            faces.Add(f128);

            Face f129 = new Face(m05___Default);
            f129.AddVertex(1.61800f, 3.62052f, -0.14323f);
            f129.AddVertex(0.72961f, 2.93917f, -0.37663f);
            f129.AddVertex(0.66869f, 2.93505f, -0.21627f);
            f129.AddVertex(1.60583f, 3.61970f, -0.11122f);
            faces.Add(f129);

            Face f130 = new Face(m05___Default);
            f130.AddVertex(1.60583f, 3.61970f, -0.11122f);
            f130.AddVertex(0.66869f, 2.93505f, -0.21627f);
            f130.AddVertex(0.60778f, 2.93092f, -0.05592f);
            f130.AddVertex(1.59368f, 3.61888f, -0.07921f);
            faces.Add(f130);

            Face f131 = new Face(m05___Default);
            f131.AddVertex(0.54686f, 2.92680f, 0.10443f);
            f131.AddVertex(0.48594f, 2.92267f, 0.26479f);
            f131.AddVertex(1.56936f, 3.61723f, -0.01520f);
            f131.AddVertex(1.58152f, 3.61805f, -0.04721f);
            faces.Add(f131);

            Face f132 = new Face(m05___Default);
            f132.AddVertex(0.72961f, 2.93917f, -0.37663f);
            f132.AddVertex(0.28979f, 2.32591f, -0.35236f);
            f132.AddVertex(0.22888f, 2.32178f, -0.19201f);
            f132.AddVertex(0.66869f, 2.93505f, -0.21627f);
            faces.Add(f132);

            Face f133 = new Face(m05___Default);
            f133.AddVertex(0.66869f, 2.93505f, -0.21627f);
            f133.AddVertex(0.22888f, 2.32178f, -0.19201f);
            f133.AddVertex(0.16796f, 2.31766f, -0.03165f);
            f133.AddVertex(0.60778f, 2.93092f, -0.05592f);
            faces.Add(f133);

            Face f134 = new Face(m05___Default);
            f134.AddVertex(0.04612f, 2.30941f, 0.28905f);
            f134.AddVertex(0.48594f, 2.92267f, 0.26479f);
            f134.AddVertex(0.54686f, 2.92680f, 0.10443f);
            f134.AddVertex(0.10705f, 2.31353f, 0.12869f);
            faces.Add(f134);

            Face f135 = new Face(m05___Default);
            f135.AddVertex(-0.12839f, 0.95433f, 0.10041f);
            f135.AddVertex(-0.06148f, 1.68372f, 0.21424f);
            f135.AddVertex(-0.01995f, 1.68653f, 0.10493f);
            f135.AddVertex(-0.11460f, 0.95526f, 0.06413f);
            faces.Add(f135);

            Face f136 = new Face(m05___Default);
            f136.AddVertex(-0.11460f, 0.95526f, 0.06413f);
            f136.AddVertex(-0.01995f, 1.68653f, 0.10493f);
            f136.AddVertex(0.02156f, 1.68935f, -0.00437f);
            f136.AddVertex(-0.10082f, 0.95620f, 0.02785f);
            faces.Add(f136);

            Face f137 = new Face(m05___Default);
            f137.AddVertex(0.06308f, 1.69216f, -0.11367f);
            f137.AddVertex(0.10461f, 1.69497f, -0.22298f);
            f137.AddVertex(-0.07326f, 0.95807f, -0.04471f);
            f137.AddVertex(-0.08704f, 0.95713f, -0.00843f);
            faces.Add(f137);

            Face f138 = new Face(m05___Default);
            f138.AddVertex(1.61537f, 3.60585f, -0.01432f);
            f138.AddVertex(0.53196f, 2.91128f, 0.26567f);
            f138.AddVertex(0.59287f, 2.91541f, 0.10531f);
            f138.AddVertex(1.62753f, 3.60667f, -0.04633f);
            faces.Add(f138);

            Face f139 = new Face(m05___Default);
            f139.AddVertex(1.62753f, 3.60667f, -0.04633f);
            f139.AddVertex(0.59287f, 2.91541f, 0.10531f);
            f139.AddVertex(0.65379f, 2.91953f, -0.05504f);
            f139.AddVertex(1.63969f, 3.60749f, -0.07833f);
            faces.Add(f139);

            Face f140 = new Face(m05___Default);
            f140.AddVertex(0.71470f, 2.92366f, -0.21539f);
            f140.AddVertex(0.77563f, 2.92779f, -0.37575f);
            f140.AddVertex(1.66401f, 3.60913f, -0.14234f);
            f140.AddVertex(1.65185f, 3.60831f, -0.11034f);
            faces.Add(f140);

            Face f141 = new Face(m05___Default);
            f141.AddVertex(0.53196f, 2.91128f, 0.26567f);
            f141.AddVertex(0.09214f, 2.29802f, 0.28994f);
            f141.AddVertex(0.15306f, 2.30214f, 0.12958f);
            f141.AddVertex(0.59287f, 2.91541f, 0.10531f);
            faces.Add(f141);

            Face f142 = new Face(m05___Default);
            f142.AddVertex(0.59287f, 2.91541f, 0.10531f);
            f142.AddVertex(0.15306f, 2.30214f, 0.12958f);
            f142.AddVertex(0.21397f, 2.30627f, -0.03077f);
            f142.AddVertex(0.65379f, 2.91953f, -0.05504f);
            faces.Add(f142);

            Face f143 = new Face(m05___Default);
            f143.AddVertex(0.33581f, 2.31452f, -0.35148f);
            f143.AddVertex(0.77563f, 2.92779f, -0.37575f);
            f143.AddVertex(0.71470f, 2.92366f, -0.21539f);
            f143.AddVertex(0.27489f, 2.31040f, -0.19113f);
            faces.Add(f143);

            Face f144 = new Face(m05___Default);
            f144.AddVertex(-0.05244f, 0.94661f, -0.04402f);
            f144.AddVertex(0.13596f, 1.68354f, -0.22221f);
            f144.AddVertex(0.09443f, 1.68073f, -0.11291f);
            f144.AddVertex(-0.06622f, 0.94568f, -0.00774f);
            faces.Add(f144);

            Face f145 = new Face(m05___Default);
            f145.AddVertex(-0.06622f, 0.94568f, -0.00774f);
            f145.AddVertex(0.09443f, 1.68073f, -0.11291f);
            f145.AddVertex(0.05291f, 1.67792f, -0.00360f);
            f145.AddVertex(-0.08000f, 0.94475f, 0.02853f);
            faces.Add(f145);

            Face f146 = new Face(m05___Default);
            f146.AddVertex(0.01139f, 1.67510f, 0.10570f);
            f146.AddVertex(-0.03013f, 1.67229f, 0.21501f);
            f146.AddVertex(-0.10756f, 0.94288f, 0.10109f);
            f146.AddVertex(-0.09378f, 0.94381f, 0.06481f);
            faces.Add(f146);

            Face f147 = new Face(m05___Default);
            f147.AddVertex(1.66401f, 3.60913f, -0.14234f);
            f147.AddVertex(0.77563f, 2.92779f, -0.37575f);
            f147.AddVertex(0.76412f, 2.93063f, -0.37597f);
            f147.AddVertex(1.65251f, 3.61198f, -0.14256f);
            faces.Add(f147);

            Face f148 = new Face(m05___Default);
            f148.AddVertex(1.65251f, 3.61198f, -0.14256f);
            f148.AddVertex(0.76412f, 2.93063f, -0.37597f);
            f148.AddVertex(0.75262f, 2.93348f, -0.37619f);
            f148.AddVertex(1.64100f, 3.61483f, -0.14278f);
            faces.Add(f148);

            Face f149 = new Face(m05___Default);
            f149.AddVertex(0.72961f, 2.93917f, -0.37663f);
            f149.AddVertex(1.61800f, 3.62052f, -0.14323f);
            f149.AddVertex(1.62950f, 3.61767f, -0.14301f);
            f149.AddVertex(0.74111f, 2.93633f, -0.37641f);
            faces.Add(f149);

            Face f150 = new Face(m05___Default);
            f150.AddVertex(0.77563f, 2.92779f, -0.37575f);
            f150.AddVertex(0.33581f, 2.31452f, -0.35148f);
            f150.AddVertex(0.32430f, 2.31737f, -0.35170f);
            f150.AddVertex(0.76412f, 2.93063f, -0.37597f);
            faces.Add(f150);

            Face f151 = new Face(m05___Default);
            f151.AddVertex(0.76412f, 2.93063f, -0.37597f);
            f151.AddVertex(0.32430f, 2.31737f, -0.35170f);
            f151.AddVertex(0.31280f, 2.32022f, -0.35192f);
            f151.AddVertex(0.75262f, 2.93348f, -0.37619f);
            faces.Add(f151);

            Face f152 = new Face(m05___Default);
            f152.AddVertex(0.28979f, 2.32591f, -0.35236f);
            f152.AddVertex(0.72961f, 2.93917f, -0.37663f);
            f152.AddVertex(0.74111f, 2.93633f, -0.37641f);
            f152.AddVertex(0.30130f, 2.32306f, -0.35214f);
            faces.Add(f152);

            Face f153 = new Face(m05___Default);
            f153.AddVertex(-0.07326f, 0.95807f, -0.04471f);
            f153.AddVertex(0.10461f, 1.69497f, -0.22298f);
            f153.AddVertex(0.11244f, 1.69211f, -0.22279f);
            f153.AddVertex(-0.06805f, 0.95520f, -0.04453f);
            faces.Add(f153);

            Face f154 = new Face(m05___Default);
            f154.AddVertex(-0.06805f, 0.95520f, -0.04453f);
            f154.AddVertex(0.11244f, 1.69211f, -0.22279f);
            f154.AddVertex(0.12028f, 1.68926f, -0.22260f);
            f154.AddVertex(-0.06285f, 0.95234f, -0.04436f);
            faces.Add(f154);

            Face f155 = new Face(m05___Default);
            f155.AddVertex(0.13596f, 1.68354f, -0.22221f);
            f155.AddVertex(-0.05244f, 0.94661f, -0.04402f);
            f155.AddVertex(-0.05764f, 0.94948f, -0.04419f);
            f155.AddVertex(0.12812f, 1.68640f, -0.22241f);
            faces.Add(f155);

            Face f156 = new Face(m05___Default);
            f156.AddVertex(-0.10756f, 0.94288f, 0.10109f);
            f156.AddVertex(-0.03013f, 1.67229f, 0.21501f);
            f156.AddVertex(-0.03797f, 1.67515f, 0.21481f);
            f156.AddVertex(-0.11277f, 0.94574f, 0.10092f);
            faces.Add(f156);

            Face f157 = new Face(m05___Default);
            f157.AddVertex(-0.11277f, 0.94574f, 0.10092f);
            f157.AddVertex(-0.03797f, 1.67515f, 0.21481f);
            f157.AddVertex(-0.04580f, 1.67801f, 0.21462f);
            f157.AddVertex(-0.11797f, 0.94861f, 0.10075f);
            faces.Add(f157);

            Face f158 = new Face(m05___Default);
            f158.AddVertex(-0.06148f, 1.68372f, 0.21424f);
            f158.AddVertex(-0.12839f, 0.95433f, 0.10041f);
            f158.AddVertex(-0.12318f, 0.95147f, 0.10058f);
            f158.AddVertex(-0.05364f, 1.68086f, 0.21443f);
            faces.Add(f158);

            Face f159 = new Face(m05___Default);
            f159.AddVertex(-0.03013f, 1.67229f, 0.21501f);
            f159.AddVertex(0.09214f, 2.29802f, 0.28994f);
            f159.AddVertex(0.08064f, 2.30086f, 0.28972f);
            f159.AddVertex(-0.03797f, 1.67515f, 0.21481f);
            faces.Add(f159);

            Face f160 = new Face(m05___Default);
            f160.AddVertex(-0.03797f, 1.67515f, 0.21481f);
            f160.AddVertex(0.08064f, 2.30086f, 0.28972f);
            f160.AddVertex(0.06913f, 2.30371f, 0.28950f);
            f160.AddVertex(-0.04580f, 1.67801f, 0.21462f);
            faces.Add(f160);

            Face f161 = new Face(m05___Default);
            f161.AddVertex(0.04612f, 2.30941f, 0.28905f);
            f161.AddVertex(-0.06148f, 1.68372f, 0.21424f);
            f161.AddVertex(-0.05364f, 1.68086f, 0.21443f);
            f161.AddVertex(0.05763f, 2.30656f, 0.28927f);
            faces.Add(f161);

            Face f162 = new Face(m05___Default);
            f162.AddVertex(1.56936f, 3.61723f, -0.01520f);
            f162.AddVertex(0.48594f, 2.92267f, 0.26479f);
            f162.AddVertex(0.49745f, 2.91982f, 0.26501f);
            f162.AddVertex(1.58086f, 3.61439f, -0.01498f);
            faces.Add(f162);

            Face f163 = new Face(m05___Default);
            f163.AddVertex(1.58086f, 3.61439f, -0.01498f);
            f163.AddVertex(0.49745f, 2.91982f, 0.26501f);
            f163.AddVertex(0.50895f, 2.91698f, 0.26523f);
            f163.AddVertex(1.59237f, 3.61154f, -0.01476f);
            faces.Add(f163);

            Face f164 = new Face(m05___Default);
            f164.AddVertex(0.53196f, 2.91128f, 0.26567f);
            f164.AddVertex(1.61537f, 3.60585f, -0.01432f);
            f164.AddVertex(1.60387f, 3.60869f, -0.01454f);
            f164.AddVertex(0.52045f, 2.91413f, 0.26545f);
            faces.Add(f164);

            Face f165 = new Face(m05___Default);
            f165.AddVertex(-0.58947f, 4.97377f, 0.40858f);
            f165.AddVertex(-0.51873f, 4.81606f, 0.37585f);
            f165.AddVertex(-0.51653f, 4.81524f, 0.38201f);
            f165.AddVertex(-0.58021f, 4.96918f, 0.41998f);
            faces.Add(f165);

            Face f166 = new Face(m05___Default);
            f166.AddVertex(-0.58979f, 4.98599f, 0.39363f);
            f166.AddVertex(-0.51731f, 4.81811f, 0.36752f);
            f166.AddVertex(-0.51873f, 4.81606f, 0.37585f);
            f166.AddVertex(-0.58947f, 4.97377f, 0.40858f);
            faces.Add(f166);

            Face f167 = new Face(m05___Default);
            f167.AddVertex(-0.58110f, 5.00256f, 0.37915f);
            f167.AddVertex(-0.51265f, 4.82084f, 0.35924f);
            f167.AddVertex(-0.51731f, 4.81811f, 0.36752f);
            f167.AddVertex(-0.58979f, 4.98599f, 0.39363f);
            faces.Add(f167);

            Face f168 = new Face(m05___Default);
            f168.AddVertex(-0.56571f, 5.01905f, 0.36901f);
            f168.AddVertex(-0.50600f, 4.82353f, 0.35325f);
            f168.AddVertex(-0.51265f, 4.82084f, 0.35924f);
            f168.AddVertex(-0.58110f, 5.00256f, 0.37915f);
            faces.Add(f168);

            Face f169 = new Face(m05___Default);
            f169.AddVertex(-0.54776f, 5.03102f, 0.36593f);
            f169.AddVertex(-0.49914f, 4.82545f, 0.35114f);
            f169.AddVertex(-0.50600f, 4.82353f, 0.35325f);
            f169.AddVertex(-0.56571f, 5.01905f, 0.36901f);
            faces.Add(f169);

            Face f170 = new Face(m05___Default);
            f170.AddVertex(-0.53206f, 5.03528f, 0.37074f);
            f170.AddVertex(-0.49391f, 4.82608f, 0.35348f);
            f170.AddVertex(-0.49914f, 4.82545f, 0.35114f);
            f170.AddVertex(-0.54776f, 5.03102f, 0.36593f);
            faces.Add(f170);

            Face f171 = new Face(m05___Default);
            f171.AddVertex(-0.52281f, 5.03069f, 0.38214f);
            f171.AddVertex(-0.49172f, 4.82526f, 0.35964f);
            f171.AddVertex(-0.49391f, 4.82608f, 0.35348f);
            f171.AddVertex(-0.53206f, 5.03528f, 0.37074f);
            faces.Add(f171);

            Face f172 = new Face(m05___Default);
            f172.AddVertex(-0.52248f, 5.01847f, 0.39709f);
            f172.AddVertex(-0.49313f, 4.82320f, 0.36797f);
            f172.AddVertex(-0.49172f, 4.82526f, 0.35964f);
            f172.AddVertex(-0.52281f, 5.03069f, 0.38214f);
            faces.Add(f172);

            Face f173 = new Face(m05___Default);
            f173.AddVertex(-0.53117f, 5.00189f, 0.41157f);
            f173.AddVertex(-0.49779f, 4.82046f, 0.37624f);
            f173.AddVertex(-0.49313f, 4.82320f, 0.36797f);
            f173.AddVertex(-0.52248f, 5.01847f, 0.39709f);
            faces.Add(f173);

            Face f174 = new Face(m05___Default);
            f174.AddVertex(-0.54656f, 4.98542f, 0.42171f);
            f174.AddVertex(-0.50444f, 4.81778f, 0.38223f);
            f174.AddVertex(-0.49779f, 4.82046f, 0.37624f);
            f174.AddVertex(-0.53117f, 5.00189f, 0.41157f);
            faces.Add(f174);

            Face f175 = new Face(m05___Default);
            f175.AddVertex(-0.56451f, 4.97344f, 0.42479f);
            f175.AddVertex(-0.51130f, 4.81587f, 0.38435f);
            f175.AddVertex(-0.50444f, 4.81778f, 0.38223f);
            f175.AddVertex(-0.54656f, 4.98542f, 0.42171f);
            faces.Add(f175);

            Face f176 = new Face(m05___Default);
            f176.AddVertex(-0.58021f, 4.96918f, 0.41998f);
            f176.AddVertex(-0.51653f, 4.81524f, 0.38201f);
            f176.AddVertex(-0.51130f, 4.81587f, 0.38435f);
            f176.AddVertex(-0.56451f, 4.97344f, 0.42479f);
            faces.Add(f176);

            Face f177 = new Face(m05___Default);
            f177.AddVertex(-0.68918f, 5.12743f, 0.49880f);
            f177.AddVertex(-0.58947f, 4.97377f, 0.40858f);
            f177.AddVertex(-0.58021f, 4.96918f, 0.41998f);
            f177.AddVertex(-0.67921f, 5.12175f, 0.50957f);
            faces.Add(f177);

            Face f178 = new Face(m05___Default);
            f178.AddVertex(-0.69143f, 5.14263f, 0.48561f);
            f178.AddVertex(-0.58979f, 4.98599f, 0.39363f);
            f178.AddVertex(-0.58947f, 4.97377f, 0.40858f);
            f178.AddVertex(-0.68918f, 5.12743f, 0.49880f);
            faces.Add(f178);

            Face f179 = new Face(m05___Default);
            f179.AddVertex(-0.68538f, 5.16327f, 0.47351f);
            f179.AddVertex(-0.58110f, 5.00256f, 0.37915f);
            f179.AddVertex(-0.58979f, 4.98599f, 0.39363f);
            f179.AddVertex(-0.69143f, 5.14263f, 0.48561f);
            faces.Add(f179);

            Face f180 = new Face(m05___Default);
            f180.AddVertex(-0.67264f, 5.18383f, 0.46577f);
            f180.AddVertex(-0.56571f, 5.01905f, 0.36901f);
            f180.AddVertex(-0.58110f, 5.00256f, 0.37915f);
            f180.AddVertex(-0.68538f, 5.16327f, 0.47351f);
            faces.Add(f180);

            Face f181 = new Face(m05___Default);
            f181.AddVertex(-0.65662f, 5.19878f, 0.46444f);
            f181.AddVertex(-0.54776f, 5.03102f, 0.36593f);
            f181.AddVertex(-0.56571f, 5.01905f, 0.36901f);
            f181.AddVertex(-0.67264f, 5.18383f, 0.46577f);
            faces.Add(f181);

            Face f182 = new Face(m05___Default);
            f182.AddVertex(-0.64163f, 5.20413f, 0.46989f);
            f182.AddVertex(-0.53206f, 5.03528f, 0.37074f);
            f182.AddVertex(-0.54776f, 5.03102f, 0.36593f);
            f182.AddVertex(-0.65662f, 5.19878f, 0.46444f);
            faces.Add(f182);

            Face f183 = new Face(m05___Default);
            f183.AddVertex(-0.63167f, 5.19845f, 0.48065f);
            f183.AddVertex(-0.52281f, 5.03069f, 0.38214f);
            f183.AddVertex(-0.53206f, 5.03528f, 0.37074f);
            f183.AddVertex(-0.64163f, 5.20413f, 0.46989f);
            faces.Add(f183);

            Face f184 = new Face(m05___Default);
            f184.AddVertex(-0.62941f, 5.18325f, 0.49385f);
            f184.AddVertex(-0.52248f, 5.01847f, 0.39709f);
            f184.AddVertex(-0.52281f, 5.03069f, 0.38214f);
            f184.AddVertex(-0.63167f, 5.19845f, 0.48065f);
            faces.Add(f184);

            Face f185 = new Face(m05___Default);
            f185.AddVertex(-0.63546f, 5.16261f, 0.50594f);
            f185.AddVertex(-0.53117f, 5.00189f, 0.41157f);
            f185.AddVertex(-0.52248f, 5.01847f, 0.39709f);
            f185.AddVertex(-0.62941f, 5.18325f, 0.49385f);
            faces.Add(f185);

            Face f186 = new Face(m05___Default);
            f186.AddVertex(-0.64820f, 5.14205f, 0.51369f);
            f186.AddVertex(-0.54656f, 4.98542f, 0.42171f);
            f186.AddVertex(-0.53117f, 5.00189f, 0.41157f);
            f186.AddVertex(-0.63546f, 5.16261f, 0.50594f);
            faces.Add(f186);

            Face f187 = new Face(m05___Default);
            f187.AddVertex(-0.66421f, 5.12710f, 0.51502f);
            f187.AddVertex(-0.56451f, 4.97344f, 0.42479f);
            f187.AddVertex(-0.54656f, 4.98542f, 0.42171f);
            f187.AddVertex(-0.64820f, 5.14205f, 0.51369f);
            faces.Add(f187);

            Face f188 = new Face(m05___Default);
            f188.AddVertex(-0.67921f, 5.12175f, 0.50957f);
            f188.AddVertex(-0.58021f, 4.96918f, 0.41998f);
            f188.AddVertex(-0.56451f, 4.97344f, 0.42479f);
            f188.AddVertex(-0.66421f, 5.12710f, 0.51502f);
            faces.Add(f188);

            Face f189 = new Face(m05___Default);
            f189.AddVertex(-0.92882f, 5.28722f, 0.70559f);
            f189.AddVertex(-0.68918f, 5.12743f, 0.49880f);
            f189.AddVertex(-0.67921f, 5.12175f, 0.50957f);
            f189.AddVertex(-0.90700f, 5.27571f, 0.72364f);
            faces.Add(f189);

            Face f190 = new Face(m05___Default);
            f190.AddVertex(-0.94057f, 5.31803f, 0.68737f);
            f190.AddVertex(-0.69143f, 5.14263f, 0.48561f);
            f190.AddVertex(-0.68918f, 5.12743f, 0.49880f);
            f190.AddVertex(-0.92882f, 5.28722f, 0.70559f);
            faces.Add(f190);

            Face f191 = new Face(m05___Default);
            f191.AddVertex(-0.93907f, 5.35990f, 0.67386f);
            f191.AddVertex(-0.68538f, 5.16327f, 0.47351f);
            f191.AddVertex(-0.69143f, 5.14263f, 0.48561f);
            f191.AddVertex(-0.94057f, 5.31803f, 0.68737f);
            faces.Add(f191);

            Face f192 = new Face(m05___Default);
            f192.AddVertex(-0.92475f, 5.40158f, 0.66869f);
            f192.AddVertex(-0.67264f, 5.18383f, 0.46577f);
            f192.AddVertex(-0.68538f, 5.16327f, 0.47351f);
            f192.AddVertex(-0.93907f, 5.35990f, 0.67386f);
            faces.Add(f192);

            Face f193 = new Face(m05___Default);
            f193.AddVertex(-0.90142f, 5.43193f, 0.67324f);
            f193.AddVertex(-0.65662f, 5.19878f, 0.46444f);
            f193.AddVertex(-0.67264f, 5.18383f, 0.46577f);
            f193.AddVertex(-0.92475f, 5.40158f, 0.66869f);
            faces.Add(f193);

            Face f194 = new Face(m05___Default);
            f194.AddVertex(-0.87536f, 5.44281f, 0.68630f);
            f194.AddVertex(-0.64163f, 5.20413f, 0.46989f);
            f194.AddVertex(-0.65662f, 5.19878f, 0.46444f);
            f194.AddVertex(-0.90142f, 5.43193f, 0.67324f);
            faces.Add(f194);

            Face f195 = new Face(m05___Default);
            f195.AddVertex(-0.85354f, 5.43129f, 0.70435f);
            f195.AddVertex(-0.63167f, 5.19845f, 0.48065f);
            f195.AddVertex(-0.64163f, 5.20413f, 0.46989f);
            f195.AddVertex(-0.87536f, 5.44281f, 0.68630f);
            faces.Add(f195);

            Face f196 = new Face(m05___Default);
            f196.AddVertex(-0.84179f, 5.40048f, 0.72257f);
            f196.AddVertex(-0.62941f, 5.18325f, 0.49385f);
            f196.AddVertex(-0.63167f, 5.19845f, 0.48065f);
            f196.AddVertex(-0.85354f, 5.43129f, 0.70435f);
            faces.Add(f196);

            Face f197 = new Face(m05___Default);
            f197.AddVertex(-0.84329f, 5.35862f, 0.73608f);
            f197.AddVertex(-0.63546f, 5.16261f, 0.50594f);
            f197.AddVertex(-0.62941f, 5.18325f, 0.49385f);
            f197.AddVertex(-0.84179f, 5.40048f, 0.72257f);
            faces.Add(f197);

            Face f198 = new Face(m05___Default);
            f198.AddVertex(-0.85761f, 5.31693f, 0.74125f);
            f198.AddVertex(-0.64820f, 5.14205f, 0.51369f);
            f198.AddVertex(-0.63546f, 5.16261f, 0.50594f);
            f198.AddVertex(-0.84329f, 5.35862f, 0.73608f);
            faces.Add(f198);

            Face f199 = new Face(m05___Default);
            f199.AddVertex(-0.88093f, 5.28658f, 0.73670f);
            f199.AddVertex(-0.66421f, 5.12710f, 0.51502f);
            f199.AddVertex(-0.64820f, 5.14205f, 0.51369f);
            f199.AddVertex(-0.85761f, 5.31693f, 0.74125f);
            faces.Add(f199);

            Face f200 = new Face(m05___Default);
            f200.AddVertex(-0.90700f, 5.27571f, 0.72364f);
            f200.AddVertex(-0.67921f, 5.12175f, 0.50957f);
            f200.AddVertex(-0.66421f, 5.12710f, 0.51502f);
            f200.AddVertex(-0.88093f, 5.28658f, 0.73670f);
            faces.Add(f200);

            Face f201 = new Face(m05___Default);
            f201.AddVertex(-0.41240f, 4.98366f, 0.38153f);
            f201.AddVertex(-0.48915f, 4.86988f, 0.38607f);
            f201.AddVertex(-0.47902f, 4.86793f, 0.37024f);
            f201.AddVertex(-0.40185f, 4.98235f, 0.36567f);
            faces.Add(f201);

            Face f202 = new Face(m05___Default);
            f202.AddVertex(-0.42910f, 4.98807f, 0.39290f);
            f202.AddVertex(-0.50467f, 4.87603f, 0.39737f);
            f202.AddVertex(-0.48915f, 4.86988f, 0.38607f);
            f202.AddVertex(-0.41240f, 4.98366f, 0.38153f);
            faces.Add(f202);

            Face f203 = new Face(m05___Default);
            f203.AddVertex(-0.44747f, 4.99439f, 0.39676f);
            f203.AddVertex(-0.52144f, 4.88473f, 0.40113f);
            f203.AddVertex(-0.50467f, 4.87603f, 0.39737f);
            f203.AddVertex(-0.42910f, 4.98807f, 0.39290f);
            faces.Add(f203);

            Face f204 = new Face(m05___Default);
            f204.AddVertex(-0.46260f, 5.00094f, 0.39205f);
            f204.AddVertex(-0.53496f, 4.89365f, 0.39634f);
            f204.AddVertex(-0.52144f, 4.88473f, 0.40113f);
            f204.AddVertex(-0.44747f, 4.99439f, 0.39676f);
            faces.Add(f204);

            Face f205 = new Face(m05___Default);
            f205.AddVertex(-0.47041f, 5.00595f, 0.38005f);
            f205.AddVertex(-0.54161f, 4.90040f, 0.38427f);
            f205.AddVertex(-0.53496f, 4.89365f, 0.39634f);
            f205.AddVertex(-0.46260f, 5.00094f, 0.39205f);
            faces.Add(f205);

            Face f206 = new Face(m05___Default);
            f206.AddVertex(-0.46883f, 5.00809f, 0.36397f);
            f206.AddVertex(-0.53961f, 4.90317f, 0.36816f);
            f206.AddVertex(-0.54161f, 4.90040f, 0.38427f);
            f206.AddVertex(-0.47041f, 5.00595f, 0.38005f);
            faces.Add(f206);

            Face f207 = new Face(m05___Default);
            f207.AddVertex(-0.45828f, 5.00678f, 0.34812f);
            f207.AddVertex(-0.52948f, 4.90122f, 0.35233f);
            f207.AddVertex(-0.53961f, 4.90317f, 0.36816f);
            f207.AddVertex(-0.46883f, 5.00809f, 0.36397f);
            faces.Add(f207);

            Face f208 = new Face(m05___Default);
            f208.AddVertex(-0.44158f, 5.00236f, 0.33674f);
            f208.AddVertex(-0.51395f, 4.89507f, 0.34102f);
            f208.AddVertex(-0.52948f, 4.90122f, 0.35233f);
            f208.AddVertex(-0.45828f, 5.00678f, 0.34812f);
            faces.Add(f208);

            Face f209 = new Face(m05___Default);
            f209.AddVertex(-0.42321f, 4.99604f, 0.33289f);
            f209.AddVertex(-0.49718f, 4.88637f, 0.33727f);
            f209.AddVertex(-0.51395f, 4.89507f, 0.34102f);
            f209.AddVertex(-0.44158f, 5.00236f, 0.33674f);
            faces.Add(f209);

            Face f210 = new Face(m05___Default);
            f210.AddVertex(-0.40809f, 4.98949f, 0.33759f);
            f210.AddVertex(-0.48366f, 4.87745f, 0.34206f);
            f210.AddVertex(-0.49718f, 4.88637f, 0.33727f);
            f210.AddVertex(-0.42321f, 4.99604f, 0.33289f);
            faces.Add(f210);

            Face f211 = new Face(m05___Default);
            f211.AddVertex(-0.40027f, 4.98448f, 0.34959f);
            f211.AddVertex(-0.47702f, 4.87070f, 0.35413f);
            f211.AddVertex(-0.48366f, 4.87745f, 0.34206f);
            f211.AddVertex(-0.40809f, 4.98949f, 0.33759f);
            faces.Add(f211);

            Face f212 = new Face(m05___Default);
            f212.AddVertex(-0.40185f, 4.98235f, 0.36567f);
            f212.AddVertex(-0.47902f, 4.86793f, 0.37024f);
            f212.AddVertex(-0.47702f, 4.87070f, 0.35413f);
            f212.AddVertex(-0.40027f, 4.98448f, 0.34959f);
            faces.Add(f212);

            Face f213 = new Face(m05___Default);
            f213.AddVertex(-0.36789f, 5.15998f, 0.37389f);
            f213.AddVertex(-0.41240f, 4.98366f, 0.38153f);
            f213.AddVertex(-0.40185f, 4.98235f, 0.36567f);
            f213.AddVertex(-0.35740f, 5.15840f, 0.35805f);
            faces.Add(f213);

            Face f214 = new Face(m05___Default);
            f214.AddVertex(-0.38441f, 5.16511f, 0.38524f);
            f214.AddVertex(-0.42910f, 4.98807f, 0.39290f);
            f214.AddVertex(-0.41240f, 4.98366f, 0.38153f);
            f214.AddVertex(-0.36789f, 5.15998f, 0.37389f);
            faces.Add(f214);

            Face f215 = new Face(m05___Default);
            f215.AddVertex(-0.40253f, 5.17241f, 0.38905f);
            f215.AddVertex(-0.44747f, 4.99439f, 0.39676f);
            f215.AddVertex(-0.42910f, 4.98807f, 0.39290f);
            f215.AddVertex(-0.38441f, 5.16511f, 0.38524f);
            faces.Add(f215);

            Face f216 = new Face(m05___Default);
            f216.AddVertex(-0.33299f, 6.19042f, 0.12980f);
            f216.AddVertex(-0.46260f, 5.00094f, 0.39205f);
            f216.AddVertex(-0.44747f, 4.99439f, 0.39676f);
            f216.AddVertex(-0.40253f, 5.17241f, 0.38905f);
            faces.Add(f216);

            Face f217 = new Face(m05___Default);
            f217.AddVertex(-0.34063f, 6.19614f, 0.11777f);
            f217.AddVertex(-0.47041f, 5.00595f, 0.38005f);
            f217.AddVertex(-0.46260f, 5.00094f, 0.39205f);
            f217.AddVertex(-0.33299f, 6.19042f, 0.12980f);
            faces.Add(f217);

            Face f218 = new Face(m05___Default);
            f218.AddVertex(-0.33898f, 6.19854f, 0.10168f);
            f218.AddVertex(-0.46883f, 5.00809f, 0.36397f);
            f218.AddVertex(-0.47041f, 5.00595f, 0.38005f);
            f218.AddVertex(-0.34063f, 6.19614f, 0.11777f);
            faces.Add(f218);

            Face f219 = new Face(m05___Default);
            f219.AddVertex(-0.32849f, 6.19697f, 0.08584f);
            f219.AddVertex(-0.45828f, 5.00678f, 0.34812f);
            f219.AddVertex(-0.46883f, 5.00809f, 0.36397f);
            f219.AddVertex(-0.33898f, 6.19854f, 0.10168f);
            faces.Add(f219);

            Face f220 = new Face(m05___Default);
            f220.AddVertex(-0.31198f, 6.19184f, 0.07449f);
            f220.AddVertex(-0.44158f, 5.00236f, 0.33674f);
            f220.AddVertex(-0.45828f, 5.00678f, 0.34812f);
            f220.AddVertex(-0.32849f, 6.19697f, 0.08584f);
            faces.Add(f220);

            Face f221 = new Face(m05___Default);
            f221.AddVertex(-0.37827f, 5.17406f, 0.32518f);
            f221.AddVertex(-0.42321f, 4.99604f, 0.33289f);
            f221.AddVertex(-0.44158f, 5.00236f, 0.33674f);
            f221.AddVertex(-0.31198f, 6.19184f, 0.07449f);
            faces.Add(f221);

            Face f222 = new Face(m05___Default);
            f222.AddVertex(-0.36339f, 5.16653f, 0.32993f);
            f222.AddVertex(-0.40809f, 4.98949f, 0.33759f);
            f222.AddVertex(-0.42321f, 4.99604f, 0.33289f);
            f222.AddVertex(-0.37827f, 5.17406f, 0.32518f);
            faces.Add(f222);

            Face f223 = new Face(m05___Default);
            f223.AddVertex(-0.35576f, 5.16080f, 0.34196f);
            f223.AddVertex(-0.40027f, 4.98448f, 0.34959f);
            f223.AddVertex(-0.40809f, 4.98949f, 0.33759f);
            f223.AddVertex(-0.36339f, 5.16653f, 0.32993f);
            faces.Add(f223);

            Face f224 = new Face(m05___Default);
            f224.AddVertex(-0.35740f, 5.15840f, 0.35805f);
            f224.AddVertex(-0.40185f, 4.98235f, 0.36567f);
            f224.AddVertex(-0.40027f, 4.98448f, 0.34959f);
            f224.AddVertex(-0.35576f, 5.16080f, 0.34196f);
            faces.Add(f224);

            Face f225 = new Face(m05___Default);
            f225.AddVertex(-0.23454f, 6.22725f, 0.11721f);
            f225.AddVertex(-0.36789f, 5.15998f, 0.37389f);
            f225.AddVertex(-0.35740f, 5.15840f, 0.35805f);
            f225.AddVertex(-0.22562f, 6.22385f, 0.10144f);
            faces.Add(f225);

            Face f226 = new Face(m05___Default);
            f226.AddVertex(-0.24677f, 6.23735f, 0.12837f);
            f226.AddVertex(-0.38441f, 5.16511f, 0.38524f);
            f226.AddVertex(-0.36789f, 5.15998f, 0.37389f);
            f226.AddVertex(-0.23454f, 6.22725f, 0.11721f);
            faces.Add(f226);

            Face f227 = new Face(m05___Default);
            f227.AddVertex(-0.25903f, 6.25146f, 0.13192f);
            f227.AddVertex(-0.40253f, 5.17241f, 0.38905f);
            f227.AddVertex(-0.38441f, 5.16511f, 0.38524f);
            f227.AddVertex(-0.24677f, 6.23735f, 0.12837f);
            faces.Add(f227);

            Face f228 = new Face(m05___Default);
            f228.AddVertex(-0.26805f, 6.26579f, 0.12691f);
            f228.AddVertex(-0.33299f, 6.19042f, 0.12980f);
            f228.AddVertex(-0.40253f, 5.17241f, 0.38905f);
            f228.AddVertex(-0.25903f, 6.25146f, 0.13192f);
            faces.Add(f228);

            Face f229 = new Face(m05___Default);
            f229.AddVertex(-0.27140f, 6.27649f, 0.11469f);
            f229.AddVertex(-0.34063f, 6.19614f, 0.11777f);
            f229.AddVertex(-0.33299f, 6.19042f, 0.12980f);
            f229.AddVertex(-0.26805f, 6.26579f, 0.12691f);
            faces.Add(f229);

            Face f230 = new Face(m05___Default);
            f230.AddVertex(-0.26818f, 6.28072f, 0.09852f);
            f230.AddVertex(-0.33898f, 6.19854f, 0.10168f);
            f230.AddVertex(-0.34063f, 6.19614f, 0.11777f);
            f230.AddVertex(-0.27140f, 6.27649f, 0.11469f);
            faces.Add(f230);

            Face f231 = new Face(m05___Default);
            f231.AddVertex(-0.25927f, 6.27732f, 0.08275f);
            f231.AddVertex(-0.32849f, 6.19697f, 0.08584f);
            f231.AddVertex(-0.33898f, 6.19854f, 0.10168f);
            f231.AddVertex(-0.26818f, 6.28072f, 0.09852f);
            faces.Add(f231);

            Face f232 = new Face(m05___Default);
            f232.AddVertex(-0.24704f, 6.26721f, 0.07160f);
            f232.AddVertex(-0.31198f, 6.19184f, 0.07449f);
            f232.AddVertex(-0.32849f, 6.19697f, 0.08584f);
            f232.AddVertex(-0.25927f, 6.27732f, 0.08275f);
            faces.Add(f232);

            Face f233 = new Face(m05___Default);
            f233.AddVertex(-0.23477f, 6.25310f, 0.06805f);
            f233.AddVertex(-0.37827f, 5.17406f, 0.32518f);
            f233.AddVertex(-0.31198f, 6.19184f, 0.07449f);
            f233.AddVertex(-0.24704f, 6.26721f, 0.07160f);
            faces.Add(f233);

            Face f234 = new Face(m05___Default);
            f234.AddVertex(-0.22576f, 6.23878f, 0.07305f);
            f234.AddVertex(-0.36339f, 5.16653f, 0.32993f);
            f234.AddVertex(-0.37827f, 5.17406f, 0.32518f);
            f234.AddVertex(-0.23477f, 6.25310f, 0.06805f);
            faces.Add(f234);

            Face f235 = new Face(m05___Default);
            f235.AddVertex(-0.22241f, 6.22807f, 0.08528f);
            f235.AddVertex(-0.35576f, 5.16080f, 0.34196f);
            f235.AddVertex(-0.36339f, 5.16653f, 0.32993f);
            f235.AddVertex(-0.22576f, 6.23878f, 0.07305f);
            faces.Add(f235);

            Face f236 = new Face(m05___Default);
            f236.AddVertex(-0.22562f, 6.22385f, 0.10144f);
            f236.AddVertex(-0.35740f, 5.15840f, 0.35805f);
            f236.AddVertex(-0.35576f, 5.16080f, 0.34196f);
            f236.AddVertex(-0.22241f, 6.22807f, 0.08528f);
            faces.Add(f236);

            Face f237 = new Face(m05___Default);
            f237.AddVertex(-0.23325f, 6.22765f, 0.11721f);
            f237.AddVertex(-0.23454f, 6.22725f, 0.11721f);
            f237.AddVertex(-0.22562f, 6.22385f, 0.10144f);
            f237.AddVertex(-0.22561f, 6.22385f, 0.10144f);
            faces.Add(f237);

            Face f238 = new Face(m05___Default);
            f238.AddVertex(-0.24202f, 6.23887f, 0.12834f);
            f238.AddVertex(-0.24677f, 6.23735f, 0.12837f);
            f238.AddVertex(-0.23454f, 6.22725f, 0.11721f);
            f238.AddVertex(-0.23325f, 6.22765f, 0.11721f);
            faces.Add(f238);

            Face f239 = new Face(m05___Default);
            f239.AddVertex(-0.24954f, 6.25448f, 0.13186f);
            f239.AddVertex(-0.25903f, 6.25146f, 0.13192f);
            f239.AddVertex(-0.24677f, 6.23735f, 0.12837f);
            f239.AddVertex(-0.24202f, 6.23887f, 0.12834f);
            faces.Add(f239);

            Face f240 = new Face(m05___Default);
            f240.AddVertex(-0.25381f, 6.27031f, 0.12682f);
            f240.AddVertex(-0.26805f, 6.26579f, 0.12691f);
            f240.AddVertex(-0.25903f, 6.25146f, 0.13192f);
            f240.AddVertex(-0.24954f, 6.25448f, 0.13186f);
            faces.Add(f240);

            Face f241 = new Face(m05___Default);
            f241.AddVertex(-0.25369f, 6.28212f, 0.11457f);
            f241.AddVertex(-0.27140f, 6.27649f, 0.11469f);
            f241.AddVertex(-0.26805f, 6.26579f, 0.12691f);
            f241.AddVertex(-0.25381f, 6.27031f, 0.12682f);
            faces.Add(f241);

            Face f242 = new Face(m05___Default);
            f242.AddVertex(-0.24920f, 6.28674f, 0.09840f);
            f242.AddVertex(-0.26818f, 6.28072f, 0.09852f);
            f242.AddVertex(-0.27140f, 6.27649f, 0.11469f);
            f242.AddVertex(-0.25369f, 6.28212f, 0.11457f);
            faces.Add(f242);

            Face f243 = new Face(m05___Default);
            f243.AddVertex(-0.24156f, 6.28294f, 0.08264f);
            f243.AddVertex(-0.25927f, 6.27732f, 0.08275f);
            f243.AddVertex(-0.26818f, 6.28072f, 0.09852f);
            f243.AddVertex(-0.24920f, 6.28674f, 0.09840f);
            faces.Add(f243);

            Face f244 = new Face(m05___Default);
            f244.AddVertex(-0.23279f, 6.27173f, 0.07151f);
            f244.AddVertex(-0.24704f, 6.26721f, 0.07160f);
            f244.AddVertex(-0.25927f, 6.27732f, 0.08275f);
            f244.AddVertex(-0.24156f, 6.28294f, 0.08264f);
            faces.Add(f244);

            Face f245 = new Face(m05___Default);
            f245.AddVertex(-0.22527f, 6.25612f, 0.06799f);
            f245.AddVertex(-0.23477f, 6.25310f, 0.06805f);
            f245.AddVertex(-0.24704f, 6.26721f, 0.07160f);
            f245.AddVertex(-0.23279f, 6.27173f, 0.07151f);
            faces.Add(f245);

            Face f246 = new Face(m05___Default);
            f246.AddVertex(-0.22100f, 6.24029f, 0.07303f);
            f246.AddVertex(-0.22576f, 6.23878f, 0.07305f);
            f246.AddVertex(-0.23477f, 6.25310f, 0.06805f);
            f246.AddVertex(-0.22527f, 6.25612f, 0.06799f);
            faces.Add(f246);

            Face f247 = new Face(m05___Default);
            f247.AddVertex(-0.22112f, 6.22847f, 0.08527f);
            f247.AddVertex(-0.22241f, 6.22807f, 0.08528f);
            f247.AddVertex(-0.22576f, 6.23878f, 0.07305f);
            f247.AddVertex(-0.22100f, 6.24029f, 0.07303f);
            faces.Add(f247);

            Face f248 = new Face(m05___Default);
            f248.AddVertex(-0.22561f, 6.22385f, 0.10144f);
            f248.AddVertex(-0.22562f, 6.22385f, 0.10144f);
            f248.AddVertex(-0.22241f, 6.22807f, 0.08528f);
            f248.AddVertex(-0.22112f, 6.22847f, 0.08527f);
            faces.Add(f248);

            Face f249 = new Face(m05___Default);
            f249.AddVertex(-0.22239f, 6.23142f, 0.11712f);
            f249.AddVertex(-0.23325f, 6.22765f, 0.11721f);
            f249.AddVertex(-0.22561f, 6.22385f, 0.10144f);
            f249.AddVertex(-0.21457f, 6.22767f, 0.10135f);
            faces.Add(f249);

            Face f250 = new Face(m05___Default);
            f250.AddVertex(-0.23162f, 6.24246f, 0.12825f);
            f250.AddVertex(-0.24202f, 6.23887f, 0.12834f);
            f250.AddVertex(-0.23325f, 6.22765f, 0.11721f);
            f250.AddVertex(-0.22239f, 6.23142f, 0.11712f);
            faces.Add(f250);

            Face f251 = new Face(m05___Default);
            f251.AddVertex(-0.23978f, 6.25785f, 0.13178f);
            f251.AddVertex(-0.24954f, 6.25448f, 0.13186f);
            f251.AddVertex(-0.24202f, 6.23887f, 0.12834f);
            f251.AddVertex(-0.23162f, 6.24246f, 0.12825f);
            faces.Add(f251);

            Face f252 = new Face(m05___Default);
            f252.AddVertex(-0.24469f, 6.27346f, 0.12675f);
            f252.AddVertex(-0.25381f, 6.27031f, 0.12682f);
            f252.AddVertex(-0.24954f, 6.25448f, 0.13186f);
            f252.AddVertex(-0.23978f, 6.25785f, 0.13178f);
            faces.Add(f252);

            Face f253 = new Face(m05___Default);
            f253.AddVertex(-0.24504f, 6.28511f, 0.11451f);
            f253.AddVertex(-0.25369f, 6.28212f, 0.11457f);
            f253.AddVertex(-0.25381f, 6.27031f, 0.12682f);
            f253.AddVertex(-0.24469f, 6.27346f, 0.12675f);
            faces.Add(f253);

            Face f254 = new Face(m05___Default);
            f254.AddVertex(-0.24072f, 6.28968f, 0.09834f);
            f254.AddVertex(-0.24920f, 6.28674f, 0.09840f);
            f254.AddVertex(-0.25369f, 6.28212f, 0.11457f);
            f254.AddVertex(-0.24504f, 6.28511f, 0.11451f);
            faces.Add(f254);

            Face f255 = new Face(m05___Default);
            f255.AddVertex(-0.23291f, 6.28594f, 0.08258f);
            f255.AddVertex(-0.24156f, 6.28294f, 0.08264f);
            f255.AddVertex(-0.24920f, 6.28674f, 0.09840f);
            f255.AddVertex(-0.24072f, 6.28968f, 0.09834f);
            faces.Add(f255);

            Face f256 = new Face(m05___Default);
            f256.AddVertex(-0.22368f, 6.27489f, 0.07143f);
            f256.AddVertex(-0.23279f, 6.27173f, 0.07151f);
            f256.AddVertex(-0.24156f, 6.28294f, 0.08264f);
            f256.AddVertex(-0.23291f, 6.28594f, 0.08258f);
            faces.Add(f256);

            Face f257 = new Face(m05___Default);
            f257.AddVertex(-0.21552f, 6.25949f, 0.06791f);
            f257.AddVertex(-0.22527f, 6.25612f, 0.06799f);
            f257.AddVertex(-0.23279f, 6.27173f, 0.07151f);
            f257.AddVertex(-0.22368f, 6.27489f, 0.07143f);
            faces.Add(f257);

            Face f258 = new Face(m05___Default);
            f258.AddVertex(-0.21060f, 6.24389f, 0.07295f);
            f258.AddVertex(-0.22100f, 6.24029f, 0.07303f);
            f258.AddVertex(-0.22527f, 6.25612f, 0.06799f);
            f258.AddVertex(-0.21552f, 6.25949f, 0.06791f);
            faces.Add(f258);

            Face f259 = new Face(m05___Default);
            f259.AddVertex(-0.21026f, 6.23223f, 0.08518f);
            f259.AddVertex(-0.22112f, 6.22847f, 0.08527f);
            f259.AddVertex(-0.22100f, 6.24029f, 0.07303f);
            f259.AddVertex(-0.21060f, 6.24389f, 0.07295f);
            faces.Add(f259);

            Face f260 = new Face(m05___Default);
            f260.AddVertex(-0.21457f, 6.22767f, 0.10135f);
            f260.AddVertex(-0.22561f, 6.22385f, 0.10144f);
            f260.AddVertex(-0.22112f, 6.22847f, 0.08527f);
            f260.AddVertex(-0.21026f, 6.23223f, 0.08518f);
            faces.Add(f260);

            Face f261 = new Face(m05___Default);
            f261.AddVertex(-0.21053f, 6.23614f, 0.11700f);
            f261.AddVertex(-0.22239f, 6.23142f, 0.11712f);
            f261.AddVertex(-0.21457f, 6.22767f, 0.10135f);
            f261.AddVertex(-0.20247f, 6.23250f, 0.10123f);
            faces.Add(f261);

            Face f262 = new Face(m05___Default);
            f262.AddVertex(-0.22043f, 6.24692f, 0.12815f);
            f262.AddVertex(-0.23162f, 6.24246f, 0.12825f);
            f262.AddVertex(-0.22239f, 6.23142f, 0.11712f);
            f262.AddVertex(-0.21053f, 6.23614f, 0.11700f);
            faces.Add(f262);

            Face f263 = new Face(m05___Default);
            f263.AddVertex(-0.22951f, 6.26195f, 0.13168f);
            f263.AddVertex(-0.23978f, 6.25785f, 0.13178f);
            f263.AddVertex(-0.23162f, 6.24246f, 0.12825f);
            f263.AddVertex(-0.22043f, 6.24692f, 0.12815f);
            faces.Add(f263);

            Face f264 = new Face(m05___Default);
            f264.AddVertex(-0.23533f, 6.27719f, 0.12665f);
            f264.AddVertex(-0.24469f, 6.27346f, 0.12675f);
            f264.AddVertex(-0.23978f, 6.25785f, 0.13178f);
            f264.AddVertex(-0.22951f, 6.26195f, 0.13168f);
            faces.Add(f264);

            Face f265 = new Face(m05___Default);
            f265.AddVertex(-0.23635f, 6.28858f, 0.11442f);
            f265.AddVertex(-0.24504f, 6.28511f, 0.11451f);
            f265.AddVertex(-0.24469f, 6.27346f, 0.12675f);
            f265.AddVertex(-0.23533f, 6.27719f, 0.12665f);
            faces.Add(f265);

            Face f266 = new Face(m05___Default);
            f266.AddVertex(-0.23228f, 6.29305f, 0.09825f);
            f266.AddVertex(-0.24072f, 6.28968f, 0.09834f);
            f266.AddVertex(-0.24504f, 6.28511f, 0.11451f);
            f266.AddVertex(-0.23635f, 6.28858f, 0.11442f);
            faces.Add(f266);

            Face f267 = new Face(m05___Default);
            f267.AddVertex(-0.22422f, 6.28940f, 0.08249f);
            f267.AddVertex(-0.23291f, 6.28594f, 0.08258f);
            f267.AddVertex(-0.24072f, 6.28968f, 0.09834f);
            f267.AddVertex(-0.23228f, 6.29305f, 0.09825f);
            faces.Add(f267);

            Face f268 = new Face(m05___Default);
            f268.AddVertex(-0.21432f, 6.27862f, 0.07134f);
            f268.AddVertex(-0.22368f, 6.27489f, 0.07143f);
            f268.AddVertex(-0.23291f, 6.28594f, 0.08258f);
            f268.AddVertex(-0.22422f, 6.28940f, 0.08249f);
            faces.Add(f268);

            Face f269 = new Face(m05___Default);
            f269.AddVertex(-0.20524f, 6.26359f, 0.06781f);
            f269.AddVertex(-0.21552f, 6.25949f, 0.06791f);
            f269.AddVertex(-0.22368f, 6.27489f, 0.07143f);
            f269.AddVertex(-0.21432f, 6.27862f, 0.07134f);
            faces.Add(f269);

            Face f270 = new Face(m05___Default);
            f270.AddVertex(-0.19942f, 6.24835f, 0.07283f);
            f270.AddVertex(-0.21060f, 6.24389f, 0.07295f);
            f270.AddVertex(-0.21552f, 6.25949f, 0.06791f);
            f270.AddVertex(-0.20524f, 6.26359f, 0.06781f);
            faces.Add(f270);

            Face f271 = new Face(m05___Default);
            f271.AddVertex(-0.19840f, 6.23696f, 0.08506f);
            f271.AddVertex(-0.21026f, 6.23223f, 0.08518f);
            f271.AddVertex(-0.21060f, 6.24389f, 0.07295f);
            f271.AddVertex(-0.19942f, 6.24835f, 0.07283f);
            faces.Add(f271);

            Face f272 = new Face(m05___Default);
            f272.AddVertex(-0.20247f, 6.23250f, 0.10123f);
            f272.AddVertex(-0.21457f, 6.22767f, 0.10135f);
            f272.AddVertex(-0.21026f, 6.23223f, 0.08518f);
            f272.AddVertex(-0.19840f, 6.23696f, 0.08506f);
            faces.Add(f272);

            Face f273 = new Face(m05___Default);
            f273.AddVertex(-0.19771f, 6.24215f, 0.11683f);
            f273.AddVertex(-0.21053f, 6.23614f, 0.11700f);
            f273.AddVertex(-0.20247f, 6.23250f, 0.10123f);
            f273.AddVertex(-0.18937f, 6.23863f, 0.10106f);
            faces.Add(f273);

            Face f274 = new Face(m05___Default);
            f274.AddVertex(-0.20836f, 6.25258f, 0.12798f);
            f274.AddVertex(-0.22043f, 6.24692f, 0.12815f);
            f274.AddVertex(-0.21053f, 6.23614f, 0.11700f);
            f274.AddVertex(-0.19771f, 6.24215f, 0.11683f);
            faces.Add(f274);

            Face f275 = new Face(m05___Default);
            f275.AddVertex(-0.21846f, 6.26712f, 0.13153f);
            f275.AddVertex(-0.22951f, 6.26195f, 0.13168f);
            f275.AddVertex(-0.22043f, 6.24692f, 0.12815f);
            f275.AddVertex(-0.20836f, 6.25258f, 0.12798f);
            faces.Add(f275);

            Face f276 = new Face(m05___Default);
            f276.AddVertex(-0.22530f, 6.28189f, 0.12652f);
            f276.AddVertex(-0.23533f, 6.27719f, 0.12665f);
            f276.AddVertex(-0.22951f, 6.26195f, 0.13168f);
            f276.AddVertex(-0.21846f, 6.26712f, 0.13153f);
            faces.Add(f276);

            Face f277 = new Face(m05___Default);
            f277.AddVertex(-0.22707f, 6.29292f, 0.11430f);
            f277.AddVertex(-0.23635f, 6.28858f, 0.11442f);
            f277.AddVertex(-0.23533f, 6.27719f, 0.12665f);
            f277.AddVertex(-0.22530f, 6.28189f, 0.12652f);
            faces.Add(f277);

            Face f278 = new Face(m05___Default);
            f278.AddVertex(-0.22328f, 6.29726f, 0.09813f);
            f278.AddVertex(-0.23228f, 6.29305f, 0.09825f);
            f278.AddVertex(-0.23635f, 6.28858f, 0.11442f);
            f278.AddVertex(-0.22707f, 6.29292f, 0.11430f);
            faces.Add(f278);

            Face f279 = new Face(m05___Default);
            f279.AddVertex(-0.21494f, 6.29374f, 0.08236f);
            f279.AddVertex(-0.22422f, 6.28940f, 0.08249f);
            f279.AddVertex(-0.23228f, 6.29305f, 0.09825f);
            f279.AddVertex(-0.22328f, 6.29726f, 0.09813f);
            faces.Add(f279);

            Face f280 = new Face(m05___Default);
            f280.AddVertex(-0.20429f, 6.28332f, 0.07121f);
            f280.AddVertex(-0.21432f, 6.27862f, 0.07134f);
            f280.AddVertex(-0.22422f, 6.28940f, 0.08249f);
            f280.AddVertex(-0.21494f, 6.29374f, 0.08236f);
            faces.Add(f280);

            Face f281 = new Face(m05___Default);
            f281.AddVertex(-0.19420f, 6.26877f, 0.06766f);
            f281.AddVertex(-0.20524f, 6.26359f, 0.06781f);
            f281.AddVertex(-0.21432f, 6.27862f, 0.07134f);
            f281.AddVertex(-0.20429f, 6.28332f, 0.07121f);
            faces.Add(f281);

            Face f282 = new Face(m05___Default);
            f282.AddVertex(-0.18734f, 6.25400f, 0.07267f);
            f282.AddVertex(-0.19942f, 6.24835f, 0.07283f);
            f282.AddVertex(-0.20524f, 6.26359f, 0.06781f);
            f282.AddVertex(-0.19420f, 6.26877f, 0.06766f);
            faces.Add(f282);

            Face f283 = new Face(m05___Default);
            f283.AddVertex(-0.18558f, 6.24297f, 0.08489f);
            f283.AddVertex(-0.19840f, 6.23696f, 0.08506f);
            f283.AddVertex(-0.19942f, 6.24835f, 0.07283f);
            f283.AddVertex(-0.18734f, 6.25400f, 0.07267f);
            faces.Add(f283);

            Face f284 = new Face(m05___Default);
            f284.AddVertex(-0.18937f, 6.23863f, 0.10106f);
            f284.AddVertex(-0.20247f, 6.23250f, 0.10123f);
            f284.AddVertex(-0.19840f, 6.23696f, 0.08506f);
            f284.AddVertex(-0.18558f, 6.24297f, 0.08489f);
            faces.Add(f284);

            Face f285 = new Face(m05___Default);
            f285.AddVertex(-0.18390f, 6.24971f, 0.11660f);
            f285.AddVertex(-0.19771f, 6.24215f, 0.11683f);
            f285.AddVertex(-0.18937f, 6.23863f, 0.10106f);
            f285.AddVertex(-0.17529f, 6.24634f, 0.10082f);
            faces.Add(f285);

            Face f286 = new Face(m05___Default);
            f286.AddVertex(-0.19527f, 6.25973f, 0.12776f);
            f286.AddVertex(-0.20836f, 6.25258f, 0.12798f);
            f286.AddVertex(-0.19771f, 6.24215f, 0.11683f);
            f286.AddVertex(-0.18390f, 6.24971f, 0.11660f);
            faces.Add(f286);

            Face f287 = new Face(m05___Default);
            f287.AddVertex(-0.20637f, 6.27374f, 0.13133f);
            f287.AddVertex(-0.21846f, 6.26712f, 0.13153f);
            f287.AddVertex(-0.20836f, 6.25258f, 0.12798f);
            f287.AddVertex(-0.19527f, 6.25973f, 0.12776f);
            faces.Add(f287);

            Face f288 = new Face(m05___Default);
            f288.AddVertex(-0.21422f, 6.28796f, 0.12633f);
            f288.AddVertex(-0.22530f, 6.28189f, 0.12652f);
            f288.AddVertex(-0.21846f, 6.26712f, 0.13153f);
            f288.AddVertex(-0.20637f, 6.27374f, 0.13133f);
            faces.Add(f288);

            Face f289 = new Face(m05___Default);
            f289.AddVertex(-0.21671f, 6.29859f, 0.11413f);
            f289.AddVertex(-0.22707f, 6.29292f, 0.11430f);
            f289.AddVertex(-0.22530f, 6.28189f, 0.12652f);
            f289.AddVertex(-0.21422f, 6.28796f, 0.12633f);
            faces.Add(f289);

            Face f290 = new Face(m05___Default);
            f290.AddVertex(-0.21319f, 6.30278f, 0.09796f);
            f290.AddVertex(-0.22328f, 6.29726f, 0.09813f);
            f290.AddVertex(-0.22707f, 6.29292f, 0.11430f);
            f290.AddVertex(-0.21671f, 6.29859f, 0.11413f);
            faces.Add(f290);

            Face f291 = new Face(m05___Default);
            f291.AddVertex(-0.20458f, 6.29941f, 0.08219f);
            f291.AddVertex(-0.21494f, 6.29374f, 0.08236f);
            f291.AddVertex(-0.22328f, 6.29726f, 0.09813f);
            f291.AddVertex(-0.21319f, 6.30278f, 0.09796f);
            faces.Add(f291);

            Face f292 = new Face(m05___Default);
            f292.AddVertex(-0.19321f, 6.28938f, 0.07102f);
            f292.AddVertex(-0.20429f, 6.28332f, 0.07121f);
            f292.AddVertex(-0.21494f, 6.29374f, 0.08236f);
            f292.AddVertex(-0.20458f, 6.29941f, 0.08219f);
            faces.Add(f292);

            Face f293 = new Face(m05___Default);
            f293.AddVertex(-0.18211f, 6.27538f, 0.06746f);
            f293.AddVertex(-0.19420f, 6.26877f, 0.06766f);
            f293.AddVertex(-0.20429f, 6.28332f, 0.07121f);
            f293.AddVertex(-0.19321f, 6.28938f, 0.07102f);
            faces.Add(f293);

            Face f294 = new Face(m05___Default);
            f294.AddVertex(-0.17426f, 6.26116f, 0.07245f);
            f294.AddVertex(-0.18734f, 6.25400f, 0.07267f);
            f294.AddVertex(-0.19420f, 6.26877f, 0.06766f);
            f294.AddVertex(-0.18211f, 6.27538f, 0.06746f);
            faces.Add(f294);

            Face f295 = new Face(m05___Default);
            f295.AddVertex(-0.17177f, 6.25052f, 0.08467f);
            f295.AddVertex(-0.18558f, 6.24297f, 0.08489f);
            f295.AddVertex(-0.18734f, 6.25400f, 0.07267f);
            f295.AddVertex(-0.17426f, 6.26116f, 0.07245f);
            faces.Add(f295);

            Face f296 = new Face(m05___Default);
            f296.AddVertex(-0.17529f, 6.24634f, 0.10082f);
            f296.AddVertex(-0.18937f, 6.23863f, 0.10106f);
            f296.AddVertex(-0.18558f, 6.24297f, 0.08489f);
            f296.AddVertex(-0.17177f, 6.25052f, 0.08467f);
            faces.Add(f296);

            Face f297 = new Face(m05___Default);
            f297.AddVertex(-0.16898f, 6.25909f, 0.11629f);
            f297.AddVertex(-0.18390f, 6.24971f, 0.11660f);
            f297.AddVertex(-0.17529f, 6.24634f, 0.10082f);
            f297.AddVertex(-0.16013f, 6.25587f, 0.10051f);
            faces.Add(f297);

            Face f298 = new Face(m05___Default);
            f298.AddVertex(-0.18100f, 6.26871f, 0.12747f);
            f298.AddVertex(-0.19527f, 6.25973f, 0.12776f);
            f298.AddVertex(-0.18390f, 6.24971f, 0.11660f);
            f298.AddVertex(-0.16898f, 6.25909f, 0.11629f);
            faces.Add(f298);

            Face f299 = new Face(m05___Default);
            f299.AddVertex(-0.19299f, 6.28215f, 0.13106f);
            f299.AddVertex(-0.20637f, 6.27374f, 0.13133f);
            f299.AddVertex(-0.19527f, 6.25973f, 0.12776f);
            f299.AddVertex(-0.18100f, 6.26871f, 0.12747f);
            faces.Add(f299);

            Face f300 = new Face(m05___Default);
            f300.AddVertex(-0.20173f, 6.29581f, 0.12608f);
            f300.AddVertex(-0.21422f, 6.28796f, 0.12633f);
            f300.AddVertex(-0.20637f, 6.27374f, 0.13133f);
            f300.AddVertex(-0.19299f, 6.28215f, 0.13106f);
            faces.Add(f300);

            Face f301 = new Face(m05___Default);
            f301.AddVertex(-0.20488f, 6.30603f, 0.11388f);
            f301.AddVertex(-0.21671f, 6.29859f, 0.11413f);
            f301.AddVertex(-0.21422f, 6.28796f, 0.12633f);
            f301.AddVertex(-0.20173f, 6.29581f, 0.12608f);
            faces.Add(f301);

            Face f302 = new Face(m05___Default);
            f302.AddVertex(-0.20159f, 6.31007f, 0.09772f);
            f302.AddVertex(-0.21319f, 6.30278f, 0.09796f);
            f302.AddVertex(-0.21671f, 6.29859f, 0.11413f);
            f302.AddVertex(-0.20488f, 6.30603f, 0.11388f);
            faces.Add(f302);

            Face f303 = new Face(m05___Default);
            f303.AddVertex(-0.19275f, 6.30685f, 0.08195f);
            f303.AddVertex(-0.20458f, 6.29941f, 0.08219f);
            f303.AddVertex(-0.21319f, 6.30278f, 0.09796f);
            f303.AddVertex(-0.20159f, 6.31007f, 0.09772f);
            faces.Add(f303);

            Face f304 = new Face(m05___Default);
            f304.AddVertex(-0.18072f, 6.29724f, 0.07077f);
            f304.AddVertex(-0.19321f, 6.28938f, 0.07102f);
            f304.AddVertex(-0.20458f, 6.29941f, 0.08219f);
            f304.AddVertex(-0.19275f, 6.30685f, 0.08195f);
            faces.Add(f304);

            Face f305 = new Face(m05___Default);
            f305.AddVertex(-0.16873f, 6.28380f, 0.06718f);
            f305.AddVertex(-0.18211f, 6.27538f, 0.06746f);
            f305.AddVertex(-0.19321f, 6.28938f, 0.07102f);
            f305.AddVertex(-0.18072f, 6.29724f, 0.07077f);
            faces.Add(f305);

            Face f306 = new Face(m05___Default);
            f306.AddVertex(-0.15999f, 6.27013f, 0.07216f);
            f306.AddVertex(-0.17426f, 6.26116f, 0.07245f);
            f306.AddVertex(-0.18211f, 6.27538f, 0.06746f);
            f306.AddVertex(-0.16873f, 6.28380f, 0.06718f);
            faces.Add(f306);

            Face f307 = new Face(m05___Default);
            f307.AddVertex(-0.15684f, 6.25991f, 0.08436f);
            f307.AddVertex(-0.17177f, 6.25052f, 0.08467f);
            f307.AddVertex(-0.17426f, 6.26116f, 0.07245f);
            f307.AddVertex(-0.15999f, 6.27013f, 0.07216f);
            faces.Add(f307);

            Face f308 = new Face(m05___Default);
            f308.AddVertex(-0.16013f, 6.25587f, 0.10051f);
            f308.AddVertex(-0.17529f, 6.24634f, 0.10082f);
            f308.AddVertex(-0.17177f, 6.25052f, 0.08467f);
            f308.AddVertex(-0.15684f, 6.25991f, 0.08436f);
            faces.Add(f308);

            Face f309 = new Face(m05___Default);
            f309.AddVertex(-0.15317f, 6.27028f, 0.11592f);
            f309.AddVertex(-0.16898f, 6.25909f, 0.11629f);
            f309.AddVertex(-0.16013f, 6.25587f, 0.10051f);
            f309.AddVertex(-0.14419f, 6.26715f, 0.10013f);
            faces.Add(f309);

            Face f310 = new Face(m05___Default);
            f310.AddVertex(-0.16557f, 6.27964f, 0.12710f);
            f310.AddVertex(-0.18100f, 6.26871f, 0.12747f);
            f310.AddVertex(-0.16898f, 6.25909f, 0.11629f);
            f310.AddVertex(-0.15317f, 6.27028f, 0.11592f);
            faces.Add(f310);

            Face f311 = new Face(m05___Default);
            f311.AddVertex(-0.17806f, 6.29272f, 0.13069f);
            f311.AddVertex(-0.19299f, 6.28215f, 0.13106f);
            f311.AddVertex(-0.18100f, 6.26871f, 0.12747f);
            f311.AddVertex(-0.16557f, 6.27964f, 0.12710f);
            faces.Add(f311);

            Face f312 = new Face(m05___Default);
            f312.AddVertex(-0.18731f, 6.30602f, 0.12573f);
            f312.AddVertex(-0.20173f, 6.29581f, 0.12608f);
            f312.AddVertex(-0.19299f, 6.28215f, 0.13106f);
            f312.AddVertex(-0.17806f, 6.29272f, 0.13069f);
            faces.Add(f312);

            Face f313 = new Face(m05___Default);
            f313.AddVertex(-0.19083f, 6.31598f, 0.11354f);
            f313.AddVertex(-0.20488f, 6.30603f, 0.11388f);
            f313.AddVertex(-0.20173f, 6.29581f, 0.12608f);
            f313.AddVertex(-0.18731f, 6.30602f, 0.12573f);
            faces.Add(f313);

            Face f314 = new Face(m05___Default);
            f314.AddVertex(-0.18767f, 6.31993f, 0.09739f);
            f314.AddVertex(-0.20159f, 6.31007f, 0.09772f);
            f314.AddVertex(-0.20488f, 6.30603f, 0.11388f);
            f314.AddVertex(-0.19083f, 6.31598f, 0.11354f);
            faces.Add(f314);

            Face f315 = new Face(m05___Default);
            f315.AddVertex(-0.17869f, 6.31681f, 0.08161f);
            f315.AddVertex(-0.19275f, 6.30685f, 0.08195f);
            f315.AddVertex(-0.20159f, 6.31007f, 0.09772f);
            f315.AddVertex(-0.18767f, 6.31993f, 0.09739f);
            faces.Add(f315);

            Face f316 = new Face(m05___Default);
            f316.AddVertex(-0.16630f, 6.30745f, 0.07042f);
            f316.AddVertex(-0.18072f, 6.29724f, 0.07077f);
            f316.AddVertex(-0.19275f, 6.30685f, 0.08195f);
            f316.AddVertex(-0.17869f, 6.31681f, 0.08161f);
            faces.Add(f316);

            Face f317 = new Face(m05___Default);
            f317.AddVertex(-0.15380f, 6.29436f, 0.06682f);
            f317.AddVertex(-0.16873f, 6.28380f, 0.06718f);
            f317.AddVertex(-0.18072f, 6.29724f, 0.07077f);
            f317.AddVertex(-0.16630f, 6.30745f, 0.07042f);
            faces.Add(f317);

            Face f318 = new Face(m05___Default);
            f318.AddVertex(-0.14456f, 6.28106f, 0.07179f);
            f318.AddVertex(-0.15999f, 6.27013f, 0.07216f);
            f318.AddVertex(-0.16873f, 6.28380f, 0.06718f);
            f318.AddVertex(-0.15380f, 6.29436f, 0.06682f);
            faces.Add(f318);

            Face f319 = new Face(m05___Default);
            f319.AddVertex(-0.14103f, 6.27110f, 0.08397f);
            f319.AddVertex(-0.15684f, 6.25991f, 0.08436f);
            f319.AddVertex(-0.15999f, 6.27013f, 0.07216f);
            f319.AddVertex(-0.14456f, 6.28106f, 0.07179f);
            faces.Add(f319);

            Face f320 = new Face(m05___Default);
            f320.AddVertex(-0.14419f, 6.26715f, 0.10013f);
            f320.AddVertex(-0.16013f, 6.25587f, 0.10051f);
            f320.AddVertex(-0.15684f, 6.25991f, 0.08436f);
            f320.AddVertex(-0.14103f, 6.27110f, 0.08397f);
            faces.Add(f320);

            Face f321 = new Face(m05___Default);
            f321.AddVertex(-0.13882f, 6.28074f, 0.11555f);
            f321.AddVertex(-0.15317f, 6.27028f, 0.11592f);
            f321.AddVertex(-0.14419f, 6.26715f, 0.10013f);
            f321.AddVertex(-0.12986f, 6.27760f, 0.09977f);
            faces.Add(f321);

            Face f322 = new Face(m05___Default);
            f322.AddVertex(-0.15115f, 6.29014f, 0.12674f);
            f322.AddVertex(-0.16557f, 6.27964f, 0.12710f);
            f322.AddVertex(-0.15317f, 6.27028f, 0.11592f);
            f322.AddVertex(-0.13882f, 6.28074f, 0.11555f);
            faces.Add(f322);

            Face f323 = new Face(m05___Default);
            f323.AddVertex(-0.16356f, 6.30329f, 0.13033f);
            f323.AddVertex(-0.17806f, 6.29272f, 0.13069f);
            f323.AddVertex(-0.16557f, 6.27964f, 0.12710f);
            f323.AddVertex(-0.15115f, 6.29014f, 0.12674f);
            faces.Add(f323);

            Face f324 = new Face(m05___Default);
            f324.AddVertex(-0.17272f, 6.31666f, 0.12537f);
            f324.AddVertex(-0.18731f, 6.30602f, 0.12573f);
            f324.AddVertex(-0.17806f, 6.29272f, 0.13069f);
            f324.AddVertex(-0.16356f, 6.30329f, 0.13033f);
            faces.Add(f324);

            Face f325 = new Face(m05___Default);
            f325.AddVertex(-0.17617f, 6.32666f, 0.11318f);
            f325.AddVertex(-0.19083f, 6.31598f, 0.11354f);
            f325.AddVertex(-0.18731f, 6.30602f, 0.12573f);
            f325.AddVertex(-0.17272f, 6.31666f, 0.12537f);
            faces.Add(f325);

            Face f326 = new Face(m05___Default);
            f326.AddVertex(-0.17300f, 6.33063f, 0.09703f);
            f326.AddVertex(-0.18767f, 6.31993f, 0.09739f);
            f326.AddVertex(-0.19083f, 6.31598f, 0.11354f);
            f326.AddVertex(-0.17617f, 6.32666f, 0.11318f);
            faces.Add(f326);

            Face f327 = new Face(m05___Default);
            f327.AddVertex(-0.16404f, 6.32748f, 0.08124f);
            f327.AddVertex(-0.17869f, 6.31681f, 0.08161f);
            f327.AddVertex(-0.18767f, 6.31993f, 0.09739f);
            f327.AddVertex(-0.17300f, 6.33063f, 0.09703f);
            faces.Add(f327);

            Face f328 = new Face(m05___Default);
            f328.AddVertex(-0.15171f, 6.31808f, 0.07005f);
            f328.AddVertex(-0.16630f, 6.30745f, 0.07042f);
            f328.AddVertex(-0.17869f, 6.31681f, 0.08161f);
            f328.AddVertex(-0.16404f, 6.32748f, 0.08124f);
            faces.Add(f328);

            Face f329 = new Face(m05___Default);
            f329.AddVertex(-0.13930f, 6.30493f, 0.06646f);
            f329.AddVertex(-0.15380f, 6.29436f, 0.06682f);
            f329.AddVertex(-0.16630f, 6.30745f, 0.07042f);
            f329.AddVertex(-0.15171f, 6.31808f, 0.07005f);
            faces.Add(f329);

            Face f330 = new Face(m05___Default);
            f330.AddVertex(-0.13014f, 6.29157f, 0.07143f);
            f330.AddVertex(-0.14456f, 6.28106f, 0.07179f);
            f330.AddVertex(-0.15380f, 6.29436f, 0.06682f);
            f330.AddVertex(-0.13930f, 6.30493f, 0.06646f);
            faces.Add(f330);

            Face f331 = new Face(m05___Default);
            f331.AddVertex(-0.12669f, 6.28156f, 0.08362f);
            f331.AddVertex(-0.14103f, 6.27110f, 0.08397f);
            f331.AddVertex(-0.14456f, 6.28106f, 0.07179f);
            f331.AddVertex(-0.13014f, 6.29157f, 0.07143f);
            faces.Add(f331);

            Face f332 = new Face(m05___Default);
            f332.AddVertex(-0.12986f, 6.27760f, 0.09977f);
            f332.AddVertex(-0.14419f, 6.26715f, 0.10013f);
            f332.AddVertex(-0.14103f, 6.27110f, 0.08397f);
            f332.AddVertex(-0.12669f, 6.28156f, 0.08362f);
            faces.Add(f332);

            Face f333 = new Face(m05___Default);
            f333.AddVertex(-0.12737f, 6.28865f, 0.11529f);
            f333.AddVertex(-0.13882f, 6.28074f, 0.11555f);
            f333.AddVertex(-0.12986f, 6.27760f, 0.09977f);
            f333.AddVertex(-0.11853f, 6.28543f, 0.09951f);
            faces.Add(f333);

            Face f334 = new Face(m05___Default);
            f334.AddVertex(-0.13940f, 6.29826f, 0.12647f);
            f334.AddVertex(-0.15115f, 6.29014f, 0.12674f);
            f334.AddVertex(-0.13882f, 6.28074f, 0.11555f);
            f334.AddVertex(-0.12737f, 6.28865f, 0.11529f);
            faces.Add(f334);

            Face f335 = new Face(m05___Default);
            f335.AddVertex(-0.15138f, 6.31170f, 0.13005f);
            f335.AddVertex(-0.16356f, 6.30329f, 0.13033f);
            f335.AddVertex(-0.15115f, 6.29014f, 0.12674f);
            f335.AddVertex(-0.13940f, 6.29826f, 0.12647f);
            faces.Add(f335);

            Face f336 = new Face(m05___Default);
            f336.AddVertex(-0.16012f, 6.32536f, 0.12507f);
            f336.AddVertex(-0.17272f, 6.31666f, 0.12537f);
            f336.AddVertex(-0.16356f, 6.30329f, 0.13033f);
            f336.AddVertex(-0.15138f, 6.31170f, 0.13005f);
            faces.Add(f336);

            Face f337 = new Face(m05___Default);
            f337.AddVertex(-0.16326f, 6.33558f, 0.11287f);
            f337.AddVertex(-0.17617f, 6.32666f, 0.11318f);
            f337.AddVertex(-0.17272f, 6.31666f, 0.12537f);
            f337.AddVertex(-0.16012f, 6.32536f, 0.12507f);
            faces.Add(f337);

            Face f338 = new Face(m05___Default);
            f338.AddVertex(-0.15997f, 6.33962f, 0.09672f);
            f338.AddVertex(-0.17300f, 6.33063f, 0.09703f);
            f338.AddVertex(-0.17617f, 6.32666f, 0.11318f);
            f338.AddVertex(-0.16326f, 6.33558f, 0.11287f);
            faces.Add(f338);

            Face f339 = new Face(m05___Default);
            f339.AddVertex(-0.15113f, 6.33640f, 0.08094f);
            f339.AddVertex(-0.16404f, 6.32748f, 0.08124f);
            f339.AddVertex(-0.17300f, 6.33063f, 0.09703f);
            f339.AddVertex(-0.15997f, 6.33962f, 0.09672f);
            faces.Add(f339);

            Face f340 = new Face(m05___Default);
            f340.AddVertex(-0.13911f, 6.32678f, 0.06976f);
            f340.AddVertex(-0.15171f, 6.31808f, 0.07005f);
            f340.AddVertex(-0.16404f, 6.32748f, 0.08124f);
            f340.AddVertex(-0.15113f, 6.33640f, 0.08094f);
            faces.Add(f340);

            Face f341 = new Face(m05___Default);
            f341.AddVertex(-0.12712f, 6.31334f, 0.06618f);
            f341.AddVertex(-0.13930f, 6.30493f, 0.06646f);
            f341.AddVertex(-0.15171f, 6.31808f, 0.07005f);
            f341.AddVertex(-0.13911f, 6.32678f, 0.06976f);
            faces.Add(f341);

            Face f342 = new Face(m05___Default);
            f342.AddVertex(-0.11838f, 6.29969f, 0.07115f);
            f342.AddVertex(-0.13014f, 6.29157f, 0.07143f);
            f342.AddVertex(-0.13930f, 6.30493f, 0.06646f);
            f342.AddVertex(-0.12712f, 6.31334f, 0.06618f);
            faces.Add(f342);

            Face f343 = new Face(m05___Default);
            f343.AddVertex(-0.11524f, 6.28946f, 0.08335f);
            f343.AddVertex(-0.12669f, 6.28156f, 0.08362f);
            f343.AddVertex(-0.13014f, 6.29157f, 0.07143f);
            f343.AddVertex(-0.11838f, 6.29969f, 0.07115f);
            faces.Add(f343);

            Face f344 = new Face(m05___Default);
            f344.AddVertex(-0.11853f, 6.28543f, 0.09951f);
            f344.AddVertex(-0.12986f, 6.27760f, 0.09977f);
            f344.AddVertex(-0.12669f, 6.28156f, 0.08362f);
            f344.AddVertex(-0.11524f, 6.28946f, 0.08335f);
            faces.Add(f344);

            Face f345 = new Face(m05___Default);
            f345.AddVertex(-0.11802f, 6.29467f, 0.11509f);
            f345.AddVertex(-0.12737f, 6.28865f, 0.11529f);
            f345.AddVertex(-0.11853f, 6.28543f, 0.09951f);
            f345.AddVertex(-0.10933f, 6.29137f, 0.09931f);
            faces.Add(f345);

            Face f346 = new Face(m05___Default);
            f346.AddVertex(-0.12967f, 6.30454f, 0.12626f);
            f346.AddVertex(-0.13940f, 6.29826f, 0.12647f);
            f346.AddVertex(-0.12737f, 6.28865f, 0.11529f);
            f346.AddVertex(-0.11802f, 6.29467f, 0.11509f);
            faces.Add(f346);

            Face f347 = new Face(m05___Default);
            f347.AddVertex(-0.14114f, 6.31831f, 0.12983f);
            f347.AddVertex(-0.15138f, 6.31170f, 0.13005f);
            f347.AddVertex(-0.13940f, 6.29826f, 0.12647f);
            f347.AddVertex(-0.12967f, 6.30454f, 0.12626f);
            faces.Add(f347);

            Face f348 = new Face(m05___Default);
            f348.AddVertex(-0.14935f, 6.33230f, 0.12485f);
            f348.AddVertex(-0.16012f, 6.32536f, 0.12507f);
            f348.AddVertex(-0.15138f, 6.31170f, 0.13005f);
            f348.AddVertex(-0.14114f, 6.31831f, 0.12983f);
            faces.Add(f348);

            Face f349 = new Face(m05___Default);
            f349.AddVertex(-0.15212f, 6.34277f, 0.11264f);
            f349.AddVertex(-0.16326f, 6.33558f, 0.11287f);
            f349.AddVertex(-0.16012f, 6.32536f, 0.12507f);
            f349.AddVertex(-0.14935f, 6.33230f, 0.12485f);
            faces.Add(f349);

            Face f350 = new Face(m05___Default);
            f350.AddVertex(-0.14869f, 6.34690f, 0.09648f);
            f350.AddVertex(-0.15997f, 6.33962f, 0.09672f);
            f350.AddVertex(-0.16326f, 6.33558f, 0.11287f);
            f350.AddVertex(-0.15212f, 6.34277f, 0.11264f);
            faces.Add(f350);

            Face f351 = new Face(m05___Default);
            f351.AddVertex(-0.13999f, 6.34359f, 0.08071f);
            f351.AddVertex(-0.15113f, 6.33640f, 0.08094f);
            f351.AddVertex(-0.15997f, 6.33962f, 0.09672f);
            f351.AddVertex(-0.14869f, 6.34690f, 0.09648f);
            faces.Add(f351);

            Face f352 = new Face(m05___Default);
            f352.AddVertex(-0.12834f, 6.33373f, 0.06953f);
            f352.AddVertex(-0.13911f, 6.32678f, 0.06976f);
            f352.AddVertex(-0.15113f, 6.33640f, 0.08094f);
            f352.AddVertex(-0.13999f, 6.34359f, 0.08071f);
            faces.Add(f352);

            Face f353 = new Face(m05___Default);
            f353.AddVertex(-0.11687f, 6.31995f, 0.06596f);
            f353.AddVertex(-0.12712f, 6.31334f, 0.06618f);
            f353.AddVertex(-0.13911f, 6.32678f, 0.06976f);
            f353.AddVertex(-0.12834f, 6.33373f, 0.06953f);
            faces.Add(f353);

            Face f354 = new Face(m05___Default);
            f354.AddVertex(-0.10866f, 6.30596f, 0.07095f);
            f354.AddVertex(-0.11838f, 6.29969f, 0.07115f);
            f354.AddVertex(-0.12712f, 6.31334f, 0.06618f);
            f354.AddVertex(-0.11687f, 6.31995f, 0.06596f);
            faces.Add(f354);

            Face f355 = new Face(m05___Default);
            f355.AddVertex(-0.10589f, 6.29549f, 0.08316f);
            f355.AddVertex(-0.11524f, 6.28946f, 0.08335f);
            f355.AddVertex(-0.11838f, 6.29969f, 0.07115f);
            f355.AddVertex(-0.10866f, 6.30596f, 0.07095f);
            faces.Add(f355);

            Face f356 = new Face(m05___Default);
            f356.AddVertex(-0.10933f, 6.29137f, 0.09931f);
            f356.AddVertex(-0.11853f, 6.28543f, 0.09951f);
            f356.AddVertex(-0.11524f, 6.28946f, 0.08335f);
            f356.AddVertex(-0.10589f, 6.29549f, 0.08316f);
            faces.Add(f356);

            Face f357 = new Face(m05___Default);
            f357.AddVertex(-0.11037f, 6.29923f, 0.11495f);
            f357.AddVertex(-0.11802f, 6.29467f, 0.11509f);
            f357.AddVertex(-0.10933f, 6.29137f, 0.09931f);
            f357.AddVertex(-0.10182f, 6.29582f, 0.09917f);
            faces.Add(f357);

            Face f358 = new Face(m05___Default);
            f358.AddVertex(-0.12157f, 6.30935f, 0.12611f);
            f358.AddVertex(-0.12967f, 6.30454f, 0.12626f);
            f358.AddVertex(-0.11802f, 6.29467f, 0.11509f);
            f358.AddVertex(-0.11037f, 6.29923f, 0.11495f);
            faces.Add(f358);

            Face f359 = new Face(m05___Default);
            f359.AddVertex(-0.13244f, 6.32348f, 0.12967f);
            f359.AddVertex(-0.14114f, 6.31831f, 0.12983f);
            f359.AddVertex(-0.12967f, 6.30454f, 0.12626f);
            f359.AddVertex(-0.12157f, 6.30935f, 0.12611f);
            faces.Add(f359);

            Face f360 = new Face(m05___Default);
            f360.AddVertex(-0.14006f, 6.33783f, 0.12467f);
            f360.AddVertex(-0.14935f, 6.33230f, 0.12485f);
            f360.AddVertex(-0.14114f, 6.31831f, 0.12983f);
            f360.AddVertex(-0.13244f, 6.32348f, 0.12967f);
            faces.Add(f360);

            Face f361 = new Face(m05___Default);
            f361.AddVertex(-0.14239f, 6.34855f, 0.11246f);
            f361.AddVertex(-0.15212f, 6.34277f, 0.11264f);
            f361.AddVertex(-0.14935f, 6.33230f, 0.12485f);
            f361.AddVertex(-0.14006f, 6.33783f, 0.12467f);
            faces.Add(f361);

            Face f362 = new Face(m05___Default);
            f362.AddVertex(-0.13880f, 6.35278f, 0.09629f);
            f362.AddVertex(-0.14869f, 6.34690f, 0.09648f);
            f362.AddVertex(-0.15212f, 6.34277f, 0.11264f);
            f362.AddVertex(-0.14239f, 6.34855f, 0.11246f);
            faces.Add(f362);

            Face f363 = new Face(m05___Default);
            f363.AddVertex(-0.13026f, 6.34937f, 0.08052f);
            f363.AddVertex(-0.13999f, 6.34359f, 0.08071f);
            f363.AddVertex(-0.14869f, 6.34690f, 0.09648f);
            f363.AddVertex(-0.13880f, 6.35278f, 0.09629f);
            faces.Add(f363);

            Face f364 = new Face(m05___Default);
            f364.AddVertex(-0.11905f, 6.33925f, 0.06935f);
            f364.AddVertex(-0.12834f, 6.33373f, 0.06953f);
            f364.AddVertex(-0.13999f, 6.34359f, 0.08071f);
            f364.AddVertex(-0.13026f, 6.34937f, 0.08052f);
            faces.Add(f364);

            Face f365 = new Face(m05___Default);
            f365.AddVertex(-0.10818f, 6.32512f, 0.06580f);
            f365.AddVertex(-0.11687f, 6.31995f, 0.06596f);
            f365.AddVertex(-0.12834f, 6.33373f, 0.06953f);
            f365.AddVertex(-0.11905f, 6.33925f, 0.06935f);
            faces.Add(f365);

            Face f366 = new Face(m05___Default);
            f366.AddVertex(-0.10056f, 6.31077f, 0.07079f);
            f366.AddVertex(-0.10866f, 6.30596f, 0.07095f);
            f366.AddVertex(-0.11687f, 6.31995f, 0.06596f);
            f366.AddVertex(-0.10818f, 6.32512f, 0.06580f);
            faces.Add(f366);

            Face f367 = new Face(m05___Default);
            f367.AddVertex(-0.09823f, 6.30005f, 0.08301f);
            f367.AddVertex(-0.10589f, 6.29549f, 0.08316f);
            f367.AddVertex(-0.10866f, 6.30596f, 0.07095f);
            f367.AddVertex(-0.10056f, 6.31077f, 0.07079f);
            faces.Add(f367);

            Face f368 = new Face(m05___Default);
            f368.AddVertex(-0.10182f, 6.29582f, 0.09917f);
            f368.AddVertex(-0.10933f, 6.29137f, 0.09931f);
            f368.AddVertex(-0.10589f, 6.29549f, 0.08316f);
            f368.AddVertex(-0.09823f, 6.30005f, 0.08301f);
            faces.Add(f368);

            Face f369 = new Face(m05___Default);
            f369.AddVertex(-0.12491f, 6.32757f, 0.12954f);
            f369.AddVertex(-0.13244f, 6.32348f, 0.12967f);
            f369.AddVertex(-0.12157f, 6.30935f, 0.12611f);
            f369.AddVertex(-0.11464f, 6.31311f, 0.12599f);
            faces.Add(f369);

            Face f370 = new Face(m05___Default);
            f370.AddVertex(-0.13193f, 6.34224f, 0.12453f);
            f370.AddVertex(-0.14006f, 6.33783f, 0.12467f);
            f370.AddVertex(-0.13244f, 6.32348f, 0.12967f);
            f370.AddVertex(-0.12491f, 6.32757f, 0.12954f);
            faces.Add(f370);

            Face f371 = new Face(m05___Default);
            f371.AddVertex(-0.13382f, 6.35320f, 0.11231f);
            f371.AddVertex(-0.14239f, 6.34855f, 0.11246f);
            f371.AddVertex(-0.14006f, 6.33783f, 0.12467f);
            f371.AddVertex(-0.13193f, 6.34224f, 0.12453f);
            faces.Add(f371);

            Face f372 = new Face(m05___Default);
            f372.AddVertex(-0.13007f, 6.35752f, 0.09615f);
            f372.AddVertex(-0.13880f, 6.35278f, 0.09629f);
            f372.AddVertex(-0.14239f, 6.34855f, 0.11246f);
            f372.AddVertex(-0.13382f, 6.35320f, 0.11231f);
            faces.Add(f372);

            Face f373 = new Face(m05___Default);
            f373.AddVertex(-0.12168f, 6.35402f, 0.08038f);
            f373.AddVertex(-0.13026f, 6.34937f, 0.08052f);
            f373.AddVertex(-0.13880f, 6.35278f, 0.09629f);
            f373.AddVertex(-0.13007f, 6.35752f, 0.09615f);
            faces.Add(f373);

            Face f374 = new Face(m05___Default);
            f374.AddVertex(-0.11092f, 6.34366f, 0.06922f);
            f374.AddVertex(-0.11905f, 6.33925f, 0.06935f);
            f374.AddVertex(-0.13026f, 6.34937f, 0.08052f);
            f374.AddVertex(-0.12168f, 6.35402f, 0.08038f);
            faces.Add(f374);

            Face f375 = new Face(m05___Default);
            f375.AddVertex(-0.10065f, 6.32921f, 0.06567f);
            f375.AddVertex(-0.10818f, 6.32512f, 0.06580f);
            f375.AddVertex(-0.11905f, 6.33925f, 0.06935f);
            f375.AddVertex(-0.11092f, 6.34366f, 0.06922f);
            faces.Add(f375);

            Face f376 = new Face(m05___Default);
            f376.AddVertex(-0.09362f, 6.31453f, 0.07068f);
            f376.AddVertex(-0.10056f, 6.31077f, 0.07079f);
            f376.AddVertex(-0.10818f, 6.32512f, 0.06580f);
            f376.AddVertex(-0.10065f, 6.32921f, 0.06567f);
            faces.Add(f376);

            Face f377 = new Face(m05___Default);
            f377.AddVertex(-0.09174f, 6.30357f, 0.08290f);
            f377.AddVertex(-0.09823f, 6.30005f, 0.08301f);
            f377.AddVertex(-0.10056f, 6.31077f, 0.07079f);
            f377.AddVertex(-0.09362f, 6.31453f, 0.07068f);
            faces.Add(f377);

            Face f378 = new Face(m05___Default);
            f378.AddVertex(-0.09549f, 6.29926f, 0.09906f);
            f378.AddVertex(-0.10182f, 6.29582f, 0.09917f);
            f378.AddVertex(-0.09823f, 6.30005f, 0.08301f);
            f378.AddVertex(-0.09174f, 6.30357f, 0.08290f);
            faces.Add(f378);

            Face f379 = new Face(m05___Default);
            f379.AddVertex(-0.12470f, 6.34584f, 0.12443f);
            f379.AddVertex(-0.13193f, 6.34224f, 0.12453f);
            f379.AddVertex(-0.12491f, 6.32757f, 0.12954f);
            f379.AddVertex(-0.11815f, 6.33094f, 0.12944f);
            faces.Add(f379);

            Face f380 = new Face(m05___Default);
            f380.AddVertex(-0.12625f, 6.35697f, 0.11220f);
            f380.AddVertex(-0.13382f, 6.35320f, 0.11231f);
            f380.AddVertex(-0.13193f, 6.34224f, 0.12453f);
            f380.AddVertex(-0.12470f, 6.34584f, 0.12443f);
            faces.Add(f380);

            Face f381 = new Face(m05___Default);
            f381.AddVertex(-0.12238f, 6.36135f, 0.09604f);
            f381.AddVertex(-0.13007f, 6.35752f, 0.09615f);
            f381.AddVertex(-0.13382f, 6.35320f, 0.11231f);
            f381.AddVertex(-0.12625f, 6.35697f, 0.11220f);
            faces.Add(f381);

            Face f382 = new Face(m05___Default);
            f382.AddVertex(-0.11412f, 6.35779f, 0.08026f);
            f382.AddVertex(-0.12168f, 6.35402f, 0.08038f);
            f382.AddVertex(-0.13007f, 6.35752f, 0.09615f);
            f382.AddVertex(-0.12238f, 6.36135f, 0.09604f);
            faces.Add(f382);

            Face f383 = new Face(m05___Default);
            f383.AddVertex(-0.10369f, 6.34726f, 0.06912f);
            f383.AddVertex(-0.11092f, 6.34366f, 0.06922f);
            f383.AddVertex(-0.12168f, 6.35402f, 0.08038f);
            f383.AddVertex(-0.11412f, 6.35779f, 0.08026f);
            faces.Add(f383);

            Face f384 = new Face(m05___Default);
            f384.AddVertex(-0.09389f, 6.33258f, 0.06557f);
            f384.AddVertex(-0.10065f, 6.32921f, 0.06567f);
            f384.AddVertex(-0.11092f, 6.34366f, 0.06922f);
            f384.AddVertex(-0.10369f, 6.34726f, 0.06912f);
            faces.Add(f384);

            Face f385 = new Face(m05___Default);
            f385.AddVertex(-0.08733f, 6.31767f, 0.07058f);
            f385.AddVertex(-0.09362f, 6.31453f, 0.07068f);
            f385.AddVertex(-0.10065f, 6.32921f, 0.06567f);
            f385.AddVertex(-0.09389f, 6.33258f, 0.06557f);
            faces.Add(f385);

            Face f386 = new Face(m05___Default);
            f386.AddVertex(-0.08578f, 6.30654f, 0.08282f);
            f386.AddVertex(-0.09174f, 6.30357f, 0.08290f);
            f386.AddVertex(-0.09362f, 6.31453f, 0.07068f);
            f386.AddVertex(-0.08733f, 6.31767f, 0.07058f);
            faces.Add(f386);

            Face f387 = new Face(m05___Default);
            f387.AddVertex(-0.12327f, 6.35838f, 0.11216f);
            f387.AddVertex(-0.12625f, 6.35697f, 0.11220f);
            f387.AddVertex(-0.12470f, 6.34584f, 0.12443f);
            f387.AddVertex(-0.12029f, 6.34792f, 0.12437f);
            faces.Add(f387);

            Face f388 = new Face(m05___Default);
            f388.AddVertex(-0.11992f, 6.36251f, 0.09600f);
            f388.AddVertex(-0.12238f, 6.36135f, 0.09604f);
            f388.AddVertex(-0.12625f, 6.35697f, 0.11220f);
            f388.AddVertex(-0.12327f, 6.35838f, 0.11216f);
            faces.Add(f388);

            Face f389 = new Face(m05___Default);
            f389.AddVertex(-0.11114f, 6.35920f, 0.08023f);
            f389.AddVertex(-0.11412f, 6.35779f, 0.08026f);
            f389.AddVertex(-0.12238f, 6.36135f, 0.09604f);
            f389.AddVertex(-0.11992f, 6.36251f, 0.09600f);
            faces.Add(f389);

            Face f390 = new Face(m05___Default);
            f390.AddVertex(-0.09928f, 6.34935f, 0.06906f);
            f390.AddVertex(-0.10369f, 6.34726f, 0.06912f);
            f390.AddVertex(-0.11412f, 6.35779f, 0.08026f);
            f390.AddVertex(-0.11114f, 6.35920f, 0.08023f);
            faces.Add(f390);

            Face f391 = new Face(m05___Default);
            f391.AddVertex(-0.08751f, 6.33558f, 0.06549f);
            f391.AddVertex(-0.09389f, 6.33258f, 0.06557f);
            f391.AddVertex(-0.10369f, 6.34726f, 0.06912f);
            f391.AddVertex(-0.09928f, 6.34935f, 0.06906f);
            faces.Add(f391);

            Face f392 = new Face(m05___Default);
            f392.AddVertex(-0.07900f, 6.32161f, 0.07048f);
            f392.AddVertex(-0.08733f, 6.31767f, 0.07058f);
            f392.AddVertex(-0.09389f, 6.33258f, 0.06557f);
            f392.AddVertex(-0.08751f, 6.33558f, 0.06549f);
            faces.Add(f392);

            Face f393 = new Face(m05___Default);
            f393.AddVertex(-0.05262f, 6.41756f, 0.11004f);
            f393.AddVertex(-0.12327f, 6.35838f, 0.11216f);
            f393.AddVertex(-0.12029f, 6.34792f, 0.12437f);
            f393.AddVertex(-0.04834f, 6.40820f, 0.12221f);
            faces.Add(f393);

            Face f394 = new Face(m05___Default);
            f394.AddVertex(-0.04976f, 6.42129f, 0.09390f);
            f394.AddVertex(-0.11992f, 6.36251f, 0.09600f);
            f394.AddVertex(-0.12327f, 6.35838f, 0.11216f);
            f394.AddVertex(-0.05262f, 6.41756f, 0.11004f);
            faces.Add(f394);

            Face f395 = new Face(m05___Default);
            f395.AddVertex(-0.04049f, 6.41838f, 0.07811f);
            f395.AddVertex(-0.11114f, 6.35920f, 0.08023f);
            f395.AddVertex(-0.11992f, 6.36251f, 0.09600f);
            f395.AddVertex(-0.04976f, 6.42129f, 0.09390f);
            faces.Add(f395);

            Face f396 = new Face(m05___Default);
            f396.AddVertex(-0.02733f, 6.40962f, 0.06690f);
            f396.AddVertex(-0.09928f, 6.34935f, 0.06906f);
            f396.AddVertex(-0.11114f, 6.35920f, 0.08023f);
            f396.AddVertex(-0.04049f, 6.41838f, 0.07811f);
            faces.Add(f396);

            Face f397 = new Face(m05___Default);
            f397.AddVertex(-0.01378f, 6.39736f, 0.06328f);
            f397.AddVertex(-0.08751f, 6.33558f, 0.06549f);
            f397.AddVertex(-0.09928f, 6.34935f, 0.06906f);
            f397.AddVertex(-0.02733f, 6.40962f, 0.06690f);
            faces.Add(f397);

            Face f398 = new Face(m05___Default);
            f398.AddVertex(-0.00349f, 6.38487f, 0.06821f);
            f398.AddVertex(-0.07900f, 6.32161f, 0.07048f);
            f398.AddVertex(-0.08751f, 6.33558f, 0.06549f);
            f398.AddVertex(-0.01378f, 6.39736f, 0.06328f);
            faces.Add(f398);

            Face f399 = new Face(m05___Default);
            f399.AddVertex(-0.48366f, 4.87745f, 0.34206f);
            f399.AddVertex(-0.47702f, 4.87070f, 0.35413f);
            f399.AddVertex(-0.47902f, 4.86793f, 0.37024f);
            f399.AddVertex(-0.49718f, 4.88637f, 0.33727f);
            faces.Add(f399);

            Face f400 = new Face(m05___Default);
            f400.AddVertex(-0.51395f, 4.89507f, 0.34102f);
            f400.AddVertex(-0.49718f, 4.88637f, 0.33727f);
            f400.AddVertex(-0.47902f, 4.86793f, 0.37024f);
            f400.AddVertex(-0.52948f, 4.90122f, 0.35233f);
            faces.Add(f400);

            Face f401 = new Face(m05___Default);
            f401.AddVertex(-0.53961f, 4.90317f, 0.36816f);
            f401.AddVertex(-0.52948f, 4.90122f, 0.35233f);
            f401.AddVertex(-0.47902f, 4.86793f, 0.37024f);
            f401.AddVertex(-0.54161f, 4.90040f, 0.38427f);
            faces.Add(f401);

            Face f402 = new Face(m05___Default);
            f402.AddVertex(-0.53496f, 4.89365f, 0.39634f);
            f402.AddVertex(-0.54161f, 4.90040f, 0.38427f);
            f402.AddVertex(-0.47902f, 4.86793f, 0.37024f);
            f402.AddVertex(-0.52144f, 4.88473f, 0.40113f);
            faces.Add(f402);

            Face f403 = new Face(m05___Default);
            f403.AddVertex(-0.50467f, 4.87603f, 0.39737f);
            f403.AddVertex(-0.52144f, 4.88473f, 0.40113f);
            f403.AddVertex(-0.47902f, 4.86793f, 0.37024f);
            f403.AddVertex(-0.48915f, 4.86988f, 0.38607f);
            faces.Add(f403);

            Face f404 = new Face(m05___Default);
            f404.AddVertex(-0.29629f, 4.33536f, 0.41180f);
            f404.AddVertex(-0.29472f, 3.77116f, 0.43386f);
            f404.AddVertex(-0.28699f, 3.77160f, 0.42141f);
            f404.AddVertex(-0.28543f, 4.33639f, 0.39585f);
            faces.Add(f404);

            Face f405 = new Face(m05___Default);
            f405.AddVertex(-0.31381f, 4.33338f, 0.42347f);
            f405.AddVertex(-0.30634f, 3.77061f, 0.44293f);
            f405.AddVertex(-0.29472f, 3.77116f, 0.43386f);
            f405.AddVertex(-0.29629f, 4.33536f, 0.41180f);
            faces.Add(f405);

            Face f406 = new Face(m05___Default);
            f406.AddVertex(-0.33330f, 4.33096f, 0.42771f);
            f406.AddVertex(-0.31875f, 3.77009f, 0.44620f);
            f406.AddVertex(-0.30634f, 3.77061f, 0.44293f);
            f406.AddVertex(-0.31381f, 4.33338f, 0.42347f);
            faces.Add(f406);

            Face f407 = new Face(m05___Default);
            f407.AddVertex(-0.34955f, 4.32877f, 0.42339f);
            f407.AddVertex(-0.32864f, 3.76974f, 0.44279f);
            f407.AddVertex(-0.31875f, 3.77009f, 0.44620f);
            f407.AddVertex(-0.33330f, 4.33096f, 0.42771f);
            faces.Add(f407);

            Face f408 = new Face(m05___Default);
            f408.AddVertex(-0.35819f, 4.32739f, 0.41167f);
            f408.AddVertex(-0.33333f, 3.76966f, 0.43362f);
            f408.AddVertex(-0.32864f, 3.76974f, 0.44279f);
            f408.AddVertex(-0.34955f, 4.32877f, 0.42339f);
            faces.Add(f408);

            Face f409 = new Face(m05___Default);
            f409.AddVertex(-0.35691f, 4.32718f, 0.39570f);
            f409.AddVertex(-0.33158f, 3.76986f, 0.42113f);
            f409.AddVertex(-0.33333f, 3.76966f, 0.43362f);
            f409.AddVertex(-0.35819f, 4.32739f, 0.41167f);
            faces.Add(f409);

            Face f410 = new Face(m05___Default);
            f410.AddVertex(-0.34606f, 4.32821f, 0.37974f);
            f410.AddVertex(-0.32386f, 3.77030f, 0.40869f);
            f410.AddVertex(-0.33158f, 3.76986f, 0.42113f);
            f410.AddVertex(-0.35691f, 4.32718f, 0.39570f);
            faces.Add(f410);

            Face f411 = new Face(m05___Default);
            f411.AddVertex(-0.32854f, 4.33020f, 0.36808f);
            f411.AddVertex(-0.31223f, 3.77085f, 0.39962f);
            f411.AddVertex(-0.32386f, 3.77030f, 0.40869f);
            f411.AddVertex(-0.34606f, 4.32821f, 0.37974f);
            faces.Add(f411);

            Face f412 = new Face(m05___Default);
            f412.AddVertex(-0.30904f, 4.33261f, 0.36384f);
            f412.AddVertex(-0.29982f, 3.77137f, 0.39635f);
            f412.AddVertex(-0.31223f, 3.77085f, 0.39962f);
            f412.AddVertex(-0.32854f, 4.33020f, 0.36808f);
            faces.Add(f412);

            Face f413 = new Face(m05___Default);
            f413.AddVertex(-0.29280f, 4.33479f, 0.36815f);
            f413.AddVertex(-0.28994f, 3.77172f, 0.39976f);
            f413.AddVertex(-0.29982f, 3.77137f, 0.39635f);
            f413.AddVertex(-0.30904f, 4.33261f, 0.36384f);
            faces.Add(f413);

            Face f414 = new Face(m05___Default);
            f414.AddVertex(-0.28415f, 4.33618f, 0.37987f);
            f414.AddVertex(-0.28525f, 3.77181f, 0.40893f);
            f414.AddVertex(-0.28994f, 3.77172f, 0.39976f);
            f414.AddVertex(-0.29280f, 4.33479f, 0.36815f);
            faces.Add(f414);

            Face f415 = new Face(m05___Default);
            f415.AddVertex(-0.28543f, 4.33639f, 0.39585f);
            f415.AddVertex(-0.28699f, 3.77160f, 0.42141f);
            f415.AddVertex(-0.28525f, 3.77181f, 0.40893f);
            f415.AddVertex(-0.28415f, 4.33618f, 0.37987f);
            faces.Add(f415);

            Face f416 = new Face(m05___Default);
            f416.AddVertex(-0.35513f, 4.55870f, 0.40122f);
            f416.AddVertex(-0.29629f, 4.33536f, 0.41180f);
            f416.AddVertex(-0.28543f, 4.33639f, 0.39585f);
            f416.AddVertex(-0.34446f, 4.56043f, 0.38523f);
            faces.Add(f416);

            Face f417 = new Face(m05___Default);
            f417.AddVertex(-0.37215f, 4.55480f, 0.41298f);
            f417.AddVertex(-0.31381f, 4.33338f, 0.42347f);
            f417.AddVertex(-0.29629f, 4.33536f, 0.41180f);
            f417.AddVertex(-0.35513f, 4.55870f, 0.40122f);
            faces.Add(f417);

            Face f418 = new Face(m05___Default);
            f418.AddVertex(-0.39096f, 4.54978f, 0.41734f);
            f418.AddVertex(-0.33330f, 4.33096f, 0.42771f);
            f418.AddVertex(-0.31381f, 4.33338f, 0.42347f);
            f418.AddVertex(-0.37215f, 4.55480f, 0.41298f);
            faces.Add(f418);

            Face f419 = new Face(m05___Default);
            f419.AddVertex(-0.40651f, 4.54497f, 0.41315f);
            f419.AddVertex(-0.34955f, 4.32877f, 0.42339f);
            f419.AddVertex(-0.33330f, 4.33096f, 0.42771f);
            f419.AddVertex(-0.39096f, 4.54978f, 0.41734f);
            faces.Add(f419);

            Face f420 = new Face(m05___Default);
            f420.AddVertex(-0.41465f, 4.54168f, 0.40152f);
            f420.AddVertex(-0.35819f, 4.32739f, 0.41167f);
            f420.AddVertex(-0.34955f, 4.32877f, 0.42339f);
            f420.AddVertex(-0.40651f, 4.54497f, 0.41315f);
            faces.Add(f420);

            Face f421 = new Face(m05___Default);
            f421.AddVertex(-0.41318f, 4.54077f, 0.38558f);
            f421.AddVertex(-0.35691f, 4.32718f, 0.39570f);
            f421.AddVertex(-0.35819f, 4.32739f, 0.41167f);
            f421.AddVertex(-0.41465f, 4.54168f, 0.40152f);
            faces.Add(f421);

            Face f422 = new Face(m05___Default);
            f422.AddVertex(-0.40251f, 4.54250f, 0.36958f);
            f422.AddVertex(-0.34606f, 4.32821f, 0.37974f);
            f422.AddVertex(-0.35691f, 4.32718f, 0.39570f);
            f422.AddVertex(-0.41318f, 4.54077f, 0.38558f);
            faces.Add(f422);

            Face f423 = new Face(m05___Default);
            f423.AddVertex(-0.38549f, 4.54639f, 0.35783f);
            f423.AddVertex(-0.32854f, 4.33020f, 0.36808f);
            f423.AddVertex(-0.34606f, 4.32821f, 0.37974f);
            f423.AddVertex(-0.40251f, 4.54250f, 0.36958f);
            faces.Add(f423);

            Face f424 = new Face(m05___Default);
            f424.AddVertex(-0.36669f, 4.55142f, 0.35347f);
            f424.AddVertex(-0.30904f, 4.33261f, 0.36384f);
            f424.AddVertex(-0.32854f, 4.33020f, 0.36808f);
            f424.AddVertex(-0.38549f, 4.54639f, 0.35783f);
            faces.Add(f424);

            Face f425 = new Face(m05___Default);
            f425.AddVertex(-0.35114f, 4.55623f, 0.35766f);
            f425.AddVertex(-0.29280f, 4.33479f, 0.36815f);
            f425.AddVertex(-0.30904f, 4.33261f, 0.36384f);
            f425.AddVertex(-0.36669f, 4.55142f, 0.35347f);
            faces.Add(f425);

            Face f426 = new Face(m05___Default);
            f426.AddVertex(-0.34300f, 4.55952f, 0.36929f);
            f426.AddVertex(-0.28415f, 4.33618f, 0.37987f);
            f426.AddVertex(-0.29280f, 4.33479f, 0.36815f);
            f426.AddVertex(-0.35114f, 4.55623f, 0.35766f);
            faces.Add(f426);

            Face f427 = new Face(m05___Default);
            f427.AddVertex(-0.34446f, 4.56043f, 0.38523f);
            f427.AddVertex(-0.28543f, 4.33639f, 0.39585f);
            f427.AddVertex(-0.28415f, 4.33618f, 0.37987f);
            f427.AddVertex(-0.34300f, 4.55952f, 0.36929f);
            faces.Add(f427);

            Face f428 = new Face(m05___Default);
            f428.AddVertex(-0.45069f, 4.80828f, 0.38916f);
            f428.AddVertex(-0.35513f, 4.55870f, 0.40122f);
            f428.AddVertex(-0.34446f, 4.56043f, 0.38523f);
            f428.AddVertex(-0.44022f, 4.81055f, 0.37314f);
            faces.Add(f428);

            Face f429 = new Face(m05___Default);
            f429.AddVertex(-0.46714f, 4.80291f, 0.40098f);
            f429.AddVertex(-0.37215f, 4.55480f, 0.41298f);
            f429.AddVertex(-0.35513f, 4.55870f, 0.40122f);
            f429.AddVertex(-0.45069f, 4.80828f, 0.38916f);
            faces.Add(f429);

            Face f430 = new Face(m05___Default);
            f430.AddVertex(-0.48517f, 4.79587f, 0.40544f);
            f430.AddVertex(-0.39096f, 4.54978f, 0.41734f);
            f430.AddVertex(-0.37215f, 4.55480f, 0.41298f);
            f430.AddVertex(-0.46714f, 4.80291f, 0.40098f);
            faces.Add(f430);

            Face f431 = new Face(m05___Default);
            f431.AddVertex(-0.49996f, 4.78905f, 0.40135f);
            f431.AddVertex(-0.40651f, 4.54497f, 0.41315f);
            f431.AddVertex(-0.39096f, 4.54978f, 0.41734f);
            f431.AddVertex(-0.48517f, 4.79587f, 0.40544f);
            faces.Add(f431);

            Face f432 = new Face(m05___Default);
            f432.AddVertex(-0.50753f, 4.78427f, 0.38980f);
            f432.AddVertex(-0.41465f, 4.54168f, 0.40152f);
            f432.AddVertex(-0.40651f, 4.54497f, 0.41315f);
            f432.AddVertex(-0.49996f, 4.78905f, 0.40135f);
            faces.Add(f432);

            Face f433 = new Face(m05___Default);
            f433.AddVertex(-0.50586f, 4.78283f, 0.37387f);
            f433.AddVertex(-0.41318f, 4.54077f, 0.38558f);
            f433.AddVertex(-0.41465f, 4.54168f, 0.40152f);
            f433.AddVertex(-0.50753f, 4.78427f, 0.38980f);
            faces.Add(f433);

            Face f434 = new Face(m05___Default);
            f434.AddVertex(-0.49540f, 4.78510f, 0.35786f);
            f434.AddVertex(-0.40251f, 4.54250f, 0.36958f);
            f434.AddVertex(-0.41318f, 4.54077f, 0.38558f);
            f434.AddVertex(-0.50586f, 4.78283f, 0.37387f);
            faces.Add(f434);

            Face f435 = new Face(m05___Default);
            f435.AddVertex(-0.47895f, 4.79047f, 0.34604f);
            f435.AddVertex(-0.38549f, 4.54639f, 0.35783f);
            f435.AddVertex(-0.40251f, 4.54250f, 0.36958f);
            f435.AddVertex(-0.49540f, 4.78510f, 0.35786f);
            faces.Add(f435);

            Face f436 = new Face(m05___Default);
            f436.AddVertex(-0.46091f, 4.79751f, 0.34157f);
            f436.AddVertex(-0.36669f, 4.55142f, 0.35347f);
            f436.AddVertex(-0.38549f, 4.54639f, 0.35783f);
            f436.AddVertex(-0.47895f, 4.79047f, 0.34604f);
            faces.Add(f436);

            Face f437 = new Face(m05___Default);
            f437.AddVertex(-0.44613f, 4.80433f, 0.34567f);
            f437.AddVertex(-0.35114f, 4.55623f, 0.35766f);
            f437.AddVertex(-0.36669f, 4.55142f, 0.35347f);
            f437.AddVertex(-0.46091f, 4.79751f, 0.34157f);
            faces.Add(f437);

            Face f438 = new Face(m05___Default);
            f438.AddVertex(-0.43856f, 4.80910f, 0.35723f);
            f438.AddVertex(-0.34300f, 4.55952f, 0.36929f);
            f438.AddVertex(-0.35114f, 4.55623f, 0.35766f);
            f438.AddVertex(-0.44613f, 4.80433f, 0.34567f);
            faces.Add(f438);

            Face f439 = new Face(m05___Default);
            f439.AddVertex(-0.44022f, 4.81055f, 0.37314f);
            f439.AddVertex(-0.34446f, 4.56043f, 0.38523f);
            f439.AddVertex(-0.34300f, 4.55952f, 0.36929f);
            f439.AddVertex(-0.43856f, 4.80910f, 0.35723f);
            faces.Add(f439);

            Face f440 = new Face(m05___Default);
            f440.AddVertex(-0.57567f, 5.02218f, 0.37848f);
            f440.AddVertex(-0.45069f, 4.80828f, 0.38916f);
            f440.AddVertex(-0.44022f, 4.81055f, 0.37314f);
            f440.AddVertex(-0.56540f, 5.02476f, 0.36245f);
            faces.Add(f440);

            Face f441 = new Face(m05___Default);
            f441.AddVertex(-0.59161f, 5.01592f, 0.39034f);
            f441.AddVertex(-0.46714f, 4.80291f, 0.40098f);
            f441.AddVertex(-0.45069f, 4.80828f, 0.38916f);
            f441.AddVertex(-0.57567f, 5.02218f, 0.37848f);
            faces.Add(f441);

            Face f442 = new Face(m05___Default);
            f442.AddVertex(-0.60894f, 5.00767f, 0.39487f);
            f442.AddVertex(-0.48517f, 4.79587f, 0.40544f);
            f442.AddVertex(-0.46714f, 4.80291f, 0.40098f);
            f442.AddVertex(-0.59161f, 5.01592f, 0.39034f);
            faces.Add(f442);

            Face f443 = new Face(m05___Default);
            f443.AddVertex(-0.62302f, 4.99965f, 0.39084f);
            f443.AddVertex(-0.49996f, 4.78905f, 0.40135f);
            f443.AddVertex(-0.48517f, 4.79587f, 0.40544f);
            f443.AddVertex(-0.60894f, 5.00767f, 0.39487f);
            faces.Add(f443);

            Face f444 = new Face(m05___Default);
            f444.AddVertex(-0.63008f, 4.99399f, 0.37932f);
            f444.AddVertex(-0.50753f, 4.78427f, 0.38980f);
            f444.AddVertex(-0.49996f, 4.78905f, 0.40135f);
            f444.AddVertex(-0.62302f, 4.99965f, 0.39084f);
            faces.Add(f444);

            Face f445 = new Face(m05___Default);
            f445.AddVertex(-0.62822f, 4.99222f, 0.36342f);
            f445.AddVertex(-0.50586f, 4.78283f, 0.37387f);
            f445.AddVertex(-0.50753f, 4.78427f, 0.38980f);
            f445.AddVertex(-0.63008f, 4.99399f, 0.37932f);
            faces.Add(f445);

            Face f446 = new Face(m05___Default);
            f446.AddVertex(-0.61794f, 4.99481f, 0.34739f);
            f446.AddVertex(-0.49540f, 4.78510f, 0.35786f);
            f446.AddVertex(-0.50586f, 4.78283f, 0.37387f);
            f446.AddVertex(-0.62822f, 4.99222f, 0.36342f);
            faces.Add(f446);

            Face f447 = new Face(m05___Default);
            f447.AddVertex(-0.60201f, 5.00107f, 0.33552f);
            f447.AddVertex(-0.47895f, 4.79047f, 0.34604f);
            f447.AddVertex(-0.49540f, 4.78510f, 0.35786f);
            f447.AddVertex(-0.61794f, 4.99481f, 0.34739f);
            faces.Add(f447);

            Face f448 = new Face(m05___Default);
            f448.AddVertex(-0.58467f, 5.00931f, 0.33100f);
            f448.AddVertex(-0.46091f, 4.79751f, 0.34157f);
            f448.AddVertex(-0.47895f, 4.79047f, 0.34604f);
            f448.AddVertex(-0.60201f, 5.00107f, 0.33552f);
            faces.Add(f448);

            Face f449 = new Face(m05___Default);
            f449.AddVertex(-0.57060f, 5.01734f, 0.33504f);
            f449.AddVertex(-0.44613f, 4.80433f, 0.34567f);
            f449.AddVertex(-0.46091f, 4.79751f, 0.34157f);
            f449.AddVertex(-0.58467f, 5.00931f, 0.33100f);
            faces.Add(f449);

            Face f450 = new Face(m05___Default);
            f450.AddVertex(-0.56354f, 5.02300f, 0.34654f);
            f450.AddVertex(-0.43856f, 4.80910f, 0.35723f);
            f450.AddVertex(-0.44613f, 4.80433f, 0.34567f);
            f450.AddVertex(-0.57060f, 5.01734f, 0.33504f);
            faces.Add(f450);

            Face f451 = new Face(m05___Default);
            f451.AddVertex(-0.56540f, 5.02476f, 0.36245f);
            f451.AddVertex(-0.44022f, 4.81055f, 0.37314f);
            f451.AddVertex(-0.43856f, 4.80910f, 0.35723f);
            f451.AddVertex(-0.56354f, 5.02300f, 0.34654f);
            faces.Add(f451);

            Face f452 = new Face(m05___Default);
            f452.AddVertex(-0.65960f, 6.31423f, 0.10989f);
            f452.AddVertex(-0.57567f, 5.02218f, 0.37848f);
            f452.AddVertex(-0.56540f, 5.02476f, 0.36245f);
            f452.AddVertex(-0.64946f, 6.31705f, 0.09384f);
            faces.Add(f452);

            Face f453 = new Face(m05___Default);
            f453.AddVertex(-0.67517f, 6.30735f, 0.12179f);
            f453.AddVertex(-0.59161f, 5.01592f, 0.39034f);
            f453.AddVertex(-0.57567f, 5.02218f, 0.37848f);
            f453.AddVertex(-0.65960f, 6.31423f, 0.10989f);
            faces.Add(f453);

            Face f454 = new Face(m05___Default);
            f454.AddVertex(-0.69200f, 6.29826f, 0.12635f);
            f454.AddVertex(-0.60894f, 5.00767f, 0.39487f);
            f454.AddVertex(-0.59161f, 5.01592f, 0.39034f);
            f454.AddVertex(-0.67517f, 6.30735f, 0.12179f);
            faces.Add(f454);

            Face f455 = new Face(m05___Default);
            f455.AddVertex(-0.70557f, 6.28940f, 0.12236f);
            f455.AddVertex(-0.62302f, 4.99965f, 0.39084f);
            f455.AddVertex(-0.60894f, 5.00767f, 0.39487f);
            f455.AddVertex(-0.69200f, 6.29826f, 0.12635f);
            faces.Add(f455);

            Face f456 = new Face(m05___Default);
            f456.AddVertex(-0.71225f, 6.28311f, 0.11088f);
            f456.AddVertex(-0.63008f, 4.99399f, 0.37932f);
            f456.AddVertex(-0.62302f, 4.99965f, 0.39084f);
            f456.AddVertex(-0.70557f, 6.28940f, 0.12236f);
            faces.Add(f456);

            Face f457 = new Face(m05___Default);
            f457.AddVertex(-0.71026f, 6.28112f, 0.09498f);
            f457.AddVertex(-0.62822f, 4.99222f, 0.36342f);
            f457.AddVertex(-0.63008f, 4.99399f, 0.37932f);
            f457.AddVertex(-0.71225f, 6.28311f, 0.11088f);
            faces.Add(f457);

            Face f458 = new Face(m05___Default);
            f458.AddVertex(-0.70012f, 6.28394f, 0.07894f);
            f458.AddVertex(-0.61794f, 4.99481f, 0.34739f);
            f458.AddVertex(-0.62822f, 4.99222f, 0.36342f);
            f458.AddVertex(-0.71026f, 6.28112f, 0.09498f);
            faces.Add(f458);

            Face f459 = new Face(m05___Default);
            f459.AddVertex(-0.68456f, 6.29082f, 0.06704f);
            f459.AddVertex(-0.60201f, 5.00107f, 0.33552f);
            f459.AddVertex(-0.61794f, 4.99481f, 0.34739f);
            f459.AddVertex(-0.70012f, 6.28394f, 0.07894f);
            faces.Add(f459);

            Face f460 = new Face(m05___Default);
            f460.AddVertex(-0.66774f, 6.29991f, 0.06248f);
            f460.AddVertex(-0.58467f, 5.00931f, 0.33100f);
            f460.AddVertex(-0.60201f, 5.00107f, 0.33552f);
            f460.AddVertex(-0.68456f, 6.29082f, 0.06704f);
            faces.Add(f460);

            Face f461 = new Face(m05___Default);
            f461.AddVertex(-0.65416f, 6.30878f, 0.06647f);
            f461.AddVertex(-0.57060f, 5.01734f, 0.33504f);
            f461.AddVertex(-0.58467f, 5.00931f, 0.33100f);
            f461.AddVertex(-0.66774f, 6.29991f, 0.06248f);
            faces.Add(f461);

            Face f462 = new Face(m05___Default);
            f462.AddVertex(-0.64747f, 6.31505f, 0.07795f);
            f462.AddVertex(-0.56354f, 5.02300f, 0.34654f);
            f462.AddVertex(-0.57060f, 5.01734f, 0.33504f);
            f462.AddVertex(-0.65416f, 6.30878f, 0.06647f);
            faces.Add(f462);

            Face f463 = new Face(m05___Default);
            f463.AddVertex(-0.64946f, 6.31705f, 0.09384f);
            f463.AddVertex(-0.56540f, 5.02476f, 0.36245f);
            f463.AddVertex(-0.56354f, 5.02300f, 0.34654f);
            f463.AddVertex(-0.64747f, 6.31505f, 0.07795f);
            faces.Add(f463);

            Face f464 = new Face(m05___Default);
            f464.AddVertex(-0.85479f, 6.57143f, 0.09669f);
            f464.AddVertex(-0.65960f, 6.31423f, 0.10989f);
            f464.AddVertex(-0.64946f, 6.31705f, 0.09384f);
            f464.AddVertex(-0.84438f, 6.57389f, 0.08066f);
            faces.Add(f464);

            Face f465 = new Face(m05___Default);
            f465.AddVertex(-0.87110f, 6.56553f, 0.10853f);
            f465.AddVertex(-0.67517f, 6.30735f, 0.12179f);
            f465.AddVertex(-0.65960f, 6.31423f, 0.10989f);
            f465.AddVertex(-0.85479f, 6.57143f, 0.09669f);
            faces.Add(f465);

            Face f466 = new Face(m05___Default);
            f466.AddVertex(-0.88894f, 6.55778f, 0.11303f);
            f466.AddVertex(-0.69200f, 6.29826f, 0.12635f);
            f466.AddVertex(-0.67517f, 6.30735f, 0.12179f);
            f466.AddVertex(-0.87110f, 6.56553f, 0.10853f);
            faces.Add(f466);

            Face f467 = new Face(m05___Default);
            f467.AddVertex(-0.90354f, 6.55024f, 0.10897f);
            f467.AddVertex(-0.70557f, 6.28940f, 0.12236f);
            f467.AddVertex(-0.69200f, 6.29826f, 0.12635f);
            f467.AddVertex(-0.88894f, 6.55778f, 0.11303f);
            faces.Add(f467);

            Face f468 = new Face(m05___Default);
            f468.AddVertex(-0.91096f, 6.54495f, 0.09743f);
            f468.AddVertex(-0.71225f, 6.28311f, 0.11088f);
            f468.AddVertex(-0.70557f, 6.28940f, 0.12236f);
            f468.AddVertex(-0.90354f, 6.55024f, 0.10897f);
            faces.Add(f468);

            Face f469 = new Face(m05___Default);
            f469.AddVertex(-0.90924f, 6.54332f, 0.08152f);
            f469.AddVertex(-0.71026f, 6.28112f, 0.09498f);
            f469.AddVertex(-0.71225f, 6.28311f, 0.11088f);
            f469.AddVertex(-0.91096f, 6.54495f, 0.09743f);
            faces.Add(f469);

            Face f470 = new Face(m05___Default);
            f470.AddVertex(-0.89883f, 6.54577f, 0.06550f);
            f470.AddVertex(-0.70012f, 6.28394f, 0.07894f);
            f470.AddVertex(-0.71026f, 6.28112f, 0.09498f);
            f470.AddVertex(-0.90924f, 6.54332f, 0.08152f);
            faces.Add(f470);

            Face f471 = new Face(m05___Default);
            f471.AddVertex(-0.88252f, 6.55167f, 0.05365f);
            f471.AddVertex(-0.68456f, 6.29082f, 0.06704f);
            f471.AddVertex(-0.70012f, 6.28394f, 0.07894f);
            f471.AddVertex(-0.89883f, 6.54577f, 0.06550f);
            faces.Add(f471);

            Face f472 = new Face(m05___Default);
            f472.AddVertex(-0.86468f, 6.55942f, 0.04915f);
            f472.AddVertex(-0.66774f, 6.29991f, 0.06248f);
            f472.AddVertex(-0.68456f, 6.29082f, 0.06704f);
            f472.AddVertex(-0.88252f, 6.55167f, 0.05365f);
            faces.Add(f472);

            Face f473 = new Face(m05___Default);
            f473.AddVertex(-0.85009f, 6.56696f, 0.05322f);
            f473.AddVertex(-0.65416f, 6.30878f, 0.06647f);
            f473.AddVertex(-0.66774f, 6.29991f, 0.06248f);
            f473.AddVertex(-0.86468f, 6.55942f, 0.04915f);
            faces.Add(f473);

            Face f474 = new Face(m05___Default);
            f474.AddVertex(-0.84266f, 6.57225f, 0.06475f);
            f474.AddVertex(-0.64747f, 6.31505f, 0.07795f);
            f474.AddVertex(-0.65416f, 6.30878f, 0.06647f);
            f474.AddVertex(-0.85009f, 6.56696f, 0.05322f);
            faces.Add(f474);

            Face f475 = new Face(m05___Default);
            f475.AddVertex(-0.84438f, 6.57389f, 0.08066f);
            f475.AddVertex(-0.64946f, 6.31705f, 0.09384f);
            f475.AddVertex(-0.64747f, 6.31505f, 0.07795f);
            f475.AddVertex(-0.84266f, 6.57225f, 0.06475f);
            faces.Add(f475);

            Face f476 = new Face(m05___Default);
            f476.AddVertex(-0.98118f, 6.93619f, 0.07916f);
            f476.AddVertex(-0.85479f, 6.57143f, 0.09669f);
            f476.AddVertex(-0.84438f, 6.57389f, 0.08066f);
            f476.AddVertex(-0.97017f, 6.93691f, 0.06322f);
            faces.Add(f476);

            Face f477 = new Face(m05___Default);
            f477.AddVertex(-0.99914f, 6.93505f, 0.09078f);
            f477.AddVertex(-0.87110f, 6.56553f, 0.10853f);
            f477.AddVertex(-0.85479f, 6.57143f, 0.09669f);
            f477.AddVertex(-0.98118f, 6.93619f, 0.07916f);
            faces.Add(f477);

            Face f478 = new Face(m05___Default);
            f478.AddVertex(-1.01923f, 6.93379f, 0.09497f);
            f478.AddVertex(-0.88894f, 6.55778f, 0.11303f);
            f478.AddVertex(-0.87110f, 6.56553f, 0.10853f);
            f478.AddVertex(-0.99914f, 6.93505f, 0.09078f);
            faces.Add(f478);

            Face f479 = new Face(m05___Default);
            f479.AddVertex(-1.03607f, 6.93275f, 0.09059f);
            f479.AddVertex(-0.90354f, 6.55024f, 0.10897f);
            f479.AddVertex(-0.88894f, 6.55778f, 0.11303f);
            f479.AddVertex(-1.01923f, 6.93379f, 0.09497f);
            faces.Add(f479);

            Face f480 = new Face(m05___Default);
            f480.AddVertex(-1.04514f, 6.93221f, 0.07883f);
            f480.AddVertex(-0.91096f, 6.54495f, 0.09743f);
            f480.AddVertex(-0.90354f, 6.55024f, 0.10897f);
            f480.AddVertex(-1.03607f, 6.93275f, 0.09059f);
            faces.Add(f480);

            Face f481 = new Face(m05___Default);
            f481.AddVertex(-1.04403f, 6.93231f, 0.06284f);
            f481.AddVertex(-0.90924f, 6.54332f, 0.08152f);
            f481.AddVertex(-0.91096f, 6.54495f, 0.09743f);
            f481.AddVertex(-1.04514f, 6.93221f, 0.07883f);
            faces.Add(f481);

            Face f482 = new Face(m05___Default);
            f482.AddVertex(-1.03301f, 6.93303f, 0.04689f);
            f482.AddVertex(-0.89883f, 6.54577f, 0.06550f);
            f482.AddVertex(-0.90924f, 6.54332f, 0.08152f);
            f482.AddVertex(-1.04403f, 6.93231f, 0.06284f);
            faces.Add(f482);

            Face f483 = new Face(m05___Default);
            f483.AddVertex(-1.01505f, 6.93417f, 0.03528f);
            f483.AddVertex(-0.88252f, 6.55167f, 0.05365f);
            f483.AddVertex(-0.89883f, 6.54577f, 0.06550f);
            f483.AddVertex(-1.03301f, 6.93303f, 0.04689f);
            faces.Add(f483);

            Face f484 = new Face(m05___Default);
            f484.AddVertex(-0.99497f, 6.93543f, 0.03110f);
            f484.AddVertex(-0.86468f, 6.55942f, 0.04915f);
            f484.AddVertex(-0.88252f, 6.55167f, 0.05365f);
            f484.AddVertex(-1.01505f, 6.93417f, 0.03528f);
            faces.Add(f484);

            Face f485 = new Face(m05___Default);
            f485.AddVertex(-0.97812f, 6.93647f, 0.03547f);
            f485.AddVertex(-0.85009f, 6.56696f, 0.05322f);
            f485.AddVertex(-0.86468f, 6.55942f, 0.04915f);
            f485.AddVertex(-0.99497f, 6.93543f, 0.03110f);
            faces.Add(f485);

            Face f486 = new Face(m05___Default);
            f486.AddVertex(-0.96905f, 6.93701f, 0.04723f);
            f486.AddVertex(-0.84266f, 6.57225f, 0.06475f);
            f486.AddVertex(-0.85009f, 6.56696f, 0.05322f);
            f486.AddVertex(-0.97812f, 6.93647f, 0.03547f);
            faces.Add(f486);

            Face f487 = new Face(m05___Default);
            f487.AddVertex(-0.97017f, 6.93691f, 0.06322f);
            f487.AddVertex(-0.84438f, 6.57389f, 0.08066f);
            f487.AddVertex(-0.84266f, 6.57225f, 0.06475f);
            f487.AddVertex(-0.96905f, 6.93701f, 0.04723f);
            faces.Add(f487);

            Face f488 = new Face(m05___Default);
            f488.AddVertex(-0.28994f, 3.77172f, 0.39976f);
            f488.AddVertex(-0.28525f, 3.77181f, 0.40893f);
            f488.AddVertex(-0.28699f, 3.77160f, 0.42141f);
            f488.AddVertex(-0.29982f, 3.77137f, 0.39635f);
            faces.Add(f488);

            Face f489 = new Face(m05___Default);
            f489.AddVertex(-0.31223f, 3.77085f, 0.39962f);
            f489.AddVertex(-0.29982f, 3.77137f, 0.39635f);
            f489.AddVertex(-0.28699f, 3.77160f, 0.42141f);
            f489.AddVertex(-0.32386f, 3.77030f, 0.40869f);
            faces.Add(f489);

            Face f490 = new Face(m05___Default);
            f490.AddVertex(-0.33158f, 3.76986f, 0.42113f);
            f490.AddVertex(-0.32386f, 3.77030f, 0.40869f);
            f490.AddVertex(-0.28699f, 3.77160f, 0.42141f);
            f490.AddVertex(-0.33333f, 3.76966f, 0.43362f);
            faces.Add(f490);

            Face f491 = new Face(m05___Default);
            f491.AddVertex(-0.32864f, 3.76974f, 0.44279f);
            f491.AddVertex(-0.33333f, 3.76966f, 0.43362f);
            f491.AddVertex(-0.28699f, 3.77160f, 0.42141f);
            f491.AddVertex(-0.31875f, 3.77009f, 0.44620f);
            faces.Add(f491);

            Face f492 = new Face(m05___Default);
            f492.AddVertex(-0.30634f, 3.77061f, 0.44293f);
            f492.AddVertex(-0.31875f, 3.77009f, 0.44620f);
            f492.AddVertex(-0.28699f, 3.77160f, 0.42141f);
            f492.AddVertex(-0.29472f, 3.77116f, 0.43386f);
            faces.Add(f492);

            Face f493 = new Face(m05___Default);
            f493.AddVertex(-0.99298f, 6.62532f, 0.09315f);
            f493.AddVertex(-0.88936f, 6.59980f, 0.09512f);
            f493.AddVertex(-0.88204f, 6.60453f, 0.07897f);
            f493.AddVertex(-0.98467f, 6.62981f, 0.07701f);
            faces.Add(f493);

            Face f494 = new Face(m05___Default);
            f494.AddVertex(-1.00355f, 6.61386f, 0.10529f);
            f494.AddVertex(-0.89724f, 6.58768f, 0.10732f);
            f494.AddVertex(-0.88936f, 6.59980f, 0.09512f);
            f494.AddVertex(-0.99298f, 6.62532f, 0.09315f);
            faces.Add(f494);

            Face f495 = new Face(m05___Default);
            f495.AddVertex(-1.01356f, 6.59852f, 0.11019f);
            f495.AddVertex(-0.90356f, 6.57143f, 0.11229f);
            f495.AddVertex(-0.89724f, 6.58768f, 0.10732f);
            f495.AddVertex(-1.00355f, 6.61386f, 0.10529f);
            faces.Add(f495);

            Face f496 = new Face(m05___Default);
            f496.AddVertex(-1.02031f, 6.58340f, 0.10654f);
            f496.AddVertex(-0.90663f, 6.55540f, 0.10871f);
            f496.AddVertex(-0.90356f, 6.57143f, 0.11229f);
            f496.AddVertex(-1.01356f, 6.59852f, 0.11019f);
            faces.Add(f496);

            Face f497 = new Face(m05___Default);
            f497.AddVertex(-1.02201f, 6.57254f, 0.09530f);
            f497.AddVertex(-0.90563f, 6.54388f, 0.09753f);
            f497.AddVertex(-0.90663f, 6.55540f, 0.10871f);
            f497.AddVertex(-1.02031f, 6.58340f, 0.10654f);
            faces.Add(f497);

            Face f498 = new Face(m05___Default);
            f498.AddVertex(-1.01818f, 6.56888f, 0.07950f);
            f498.AddVertex(-0.90082f, 6.53996f, 0.08174f);
            f498.AddVertex(-0.90563f, 6.54388f, 0.09753f);
            f498.AddVertex(-1.02201f, 6.57254f, 0.09530f);
            faces.Add(f498);

            Face f499 = new Face(m05___Default);
            f499.AddVertex(-1.00988f, 6.57337f, 0.06336f);
            f499.AddVertex(-0.89349f, 6.54470f, 0.06559f);
            f499.AddVertex(-0.90082f, 6.53996f, 0.08174f);
            f499.AddVertex(-1.01818f, 6.56888f, 0.07950f);
            faces.Add(f499);

            Face f500 = new Face(m05___Default);
            f500.AddVertex(-0.99930f, 6.58482f, 0.05122f);
            f500.AddVertex(-0.88562f, 6.55682f, 0.05339f);
            f500.AddVertex(-0.89349f, 6.54470f, 0.06559f);
            f500.AddVertex(-1.00988f, 6.57337f, 0.06336f);
            faces.Add(f500);

            Face f501 = new Face(m05___Default);
            f501.AddVertex(-0.98929f, 6.60016f, 0.04632f);
            f501.AddVertex(-0.87930f, 6.57307f, 0.04842f);
            f501.AddVertex(-0.88562f, 6.55682f, 0.05339f);
            f501.AddVertex(-0.99930f, 6.58482f, 0.05122f);
            faces.Add(f501);

            Face f502 = new Face(m05___Default);
            f502.AddVertex(-0.98254f, 6.61529f, 0.04997f);
            f502.AddVertex(-0.87622f, 6.58910f, 0.05201f);
            f502.AddVertex(-0.87930f, 6.57307f, 0.04842f);
            f502.AddVertex(-0.98929f, 6.60016f, 0.04632f);
            faces.Add(f502);

            Face f503 = new Face(m05___Default);
            f503.AddVertex(-0.98085f, 6.62614f, 0.06121f);
            f503.AddVertex(-0.87723f, 6.60062f, 0.06319f);
            f503.AddVertex(-0.87622f, 6.58910f, 0.05201f);
            f503.AddVertex(-0.98254f, 6.61529f, 0.04997f);
            faces.Add(f503);

            Face f504 = new Face(m05___Default);
            f504.AddVertex(-0.98467f, 6.62981f, 0.07701f);
            f504.AddVertex(-0.88204f, 6.60453f, 0.07897f);
            f504.AddVertex(-0.87723f, 6.60062f, 0.06319f);
            f504.AddVertex(-0.98085f, 6.62614f, 0.06121f);
            faces.Add(f504);

            Face f505 = new Face(m05___Default);
            f505.AddVertex(-1.13608f, 6.73332f, 0.08711f);
            f505.AddVertex(-0.99298f, 6.62532f, 0.09315f);
            f505.AddVertex(-0.98467f, 6.62981f, 0.07701f);
            f505.AddVertex(-1.12614f, 6.73658f, 0.07105f);
            faces.Add(f505);

            Face f506 = new Face(m05___Default);
            f506.AddVertex(-1.15109f, 6.72522f, 0.09907f);
            f506.AddVertex(-1.00355f, 6.61386f, 0.10529f);
            f506.AddVertex(-0.99298f, 6.62532f, 0.09315f);
            f506.AddVertex(-1.13608f, 6.73332f, 0.08711f);
            faces.Add(f506);

            Face f507 = new Face(m05___Default);
            f507.AddVertex(-1.16717f, 6.71445f, 0.10371f);
            f507.AddVertex(-1.01356f, 6.59852f, 0.11019f);
            f507.AddVertex(-1.00355f, 6.61386f, 0.10529f);
            f507.AddVertex(-1.15109f, 6.72522f, 0.09907f);
            faces.Add(f507);

            Face f508 = new Face(m05___Default);
            f508.AddVertex(-1.17999f, 6.70391f, 0.09980f);
            f508.AddVertex(-1.02031f, 6.58340f, 0.10654f);
            f508.AddVertex(-1.01356f, 6.59852f, 0.11019f);
            f508.AddVertex(-1.16717f, 6.71445f, 0.10371f);
            faces.Add(f508);

            Face f509 = new Face(m05___Default);
            f509.AddVertex(-1.18613f, 6.69641f, 0.08838f);
            f509.AddVertex(-1.02201f, 6.57254f, 0.09530f);
            f509.AddVertex(-1.02031f, 6.58340f, 0.10654f);
            f509.AddVertex(-1.17999f, 6.70391f, 0.09980f);
            faces.Add(f509);

            Face f510 = new Face(m05___Default);
            f510.AddVertex(-1.18393f, 6.69397f, 0.07252f);
            f510.AddVertex(-1.01818f, 6.56888f, 0.07950f);
            f510.AddVertex(-1.02201f, 6.57254f, 0.09530f);
            f510.AddVertex(-1.18613f, 6.69641f, 0.08838f);
            faces.Add(f510);

            Face f511 = new Face(m05___Default);
            f511.AddVertex(-1.17400f, 6.69723f, 0.05645f);
            f511.AddVertex(-1.00988f, 6.57337f, 0.06336f);
            f511.AddVertex(-1.01818f, 6.56888f, 0.07950f);
            f511.AddVertex(-1.18393f, 6.69397f, 0.07252f);
            faces.Add(f511);

            Face f512 = new Face(m05___Default);
            f512.AddVertex(-1.15898f, 6.70533f, 0.04449f);
            f512.AddVertex(-0.99930f, 6.58482f, 0.05122f);
            f512.AddVertex(-1.00988f, 6.57337f, 0.06336f);
            f512.AddVertex(-1.17400f, 6.69723f, 0.05645f);
            faces.Add(f512);

            Face f513 = new Face(m05___Default);
            f513.AddVertex(-1.14291f, 6.71610f, 0.03985f);
            f513.AddVertex(-0.98929f, 6.60016f, 0.04632f);
            f513.AddVertex(-0.99930f, 6.58482f, 0.05122f);
            f513.AddVertex(-1.15898f, 6.70533f, 0.04449f);
            faces.Add(f513);

            Face f514 = new Face(m05___Default);
            f514.AddVertex(-1.13008f, 6.72664f, 0.04376f);
            f514.AddVertex(-0.98254f, 6.61529f, 0.04997f);
            f514.AddVertex(-0.98929f, 6.60016f, 0.04632f);
            f514.AddVertex(-1.14291f, 6.71610f, 0.03985f);
            faces.Add(f514);

            Face f515 = new Face(m05___Default);
            f515.AddVertex(-1.12395f, 6.73414f, 0.05518f);
            f515.AddVertex(-0.98085f, 6.62614f, 0.06121f);
            f515.AddVertex(-0.98254f, 6.61529f, 0.04997f);
            f515.AddVertex(-1.13008f, 6.72664f, 0.04376f);
            faces.Add(f515);

            Face f516 = new Face(m05___Default);
            f516.AddVertex(-1.12614f, 6.73658f, 0.07105f);
            f516.AddVertex(-0.98467f, 6.62981f, 0.07701f);
            f516.AddVertex(-0.98085f, 6.62614f, 0.06121f);
            f516.AddVertex(-1.12395f, 6.73414f, 0.05518f);
            faces.Add(f516);

            Face f517 = new Face(m05___Default);
            f517.AddVertex(-1.22966f, 6.91597f, 0.07810f);
            f517.AddVertex(-1.13608f, 6.73332f, 0.08711f);
            f517.AddVertex(-1.12614f, 6.73658f, 0.07105f);
            f517.AddVertex(-1.21957f, 6.91896f, 0.06204f);
            faces.Add(f517);

            Face f518 = new Face(m05___Default);
            f518.AddVertex(-1.24508f, 6.90866f, 0.09001f);
            f518.AddVertex(-1.15109f, 6.72522f, 0.09907f);
            f518.AddVertex(-1.13608f, 6.73332f, 0.08711f);
            f518.AddVertex(-1.22966f, 6.91597f, 0.07810f);
            faces.Add(f518);

            Face f519 = new Face(m05___Default);
            f519.AddVertex(-1.26170f, 6.89896f, 0.09461f);
            f519.AddVertex(-1.16717f, 6.71445f, 0.10371f);
            f519.AddVertex(-1.15109f, 6.72522f, 0.09907f);
            f519.AddVertex(-1.24508f, 6.90866f, 0.09001f);
            faces.Add(f519);

            Face f520 = new Face(m05___Default);
            f520.AddVertex(-1.27507f, 6.88949f, 0.09064f);
            f520.AddVertex(-1.17999f, 6.70391f, 0.09980f);
            f520.AddVertex(-1.16717f, 6.71445f, 0.10371f);
            f520.AddVertex(-1.26170f, 6.89896f, 0.09461f);
            faces.Add(f520);

            Face f521 = new Face(m05___Default);
            f521.AddVertex(-1.28160f, 6.88277f, 0.07919f);
            f521.AddVertex(-1.18613f, 6.69641f, 0.08838f);
            f521.AddVertex(-1.17999f, 6.70391f, 0.09980f);
            f521.AddVertex(-1.27507f, 6.88949f, 0.09064f);
            faces.Add(f521);

            Face f522 = new Face(m05___Default);
            f522.AddVertex(-1.27956f, 6.88061f, 0.06330f);
            f522.AddVertex(-1.18393f, 6.69397f, 0.07252f);
            f522.AddVertex(-1.18613f, 6.69641f, 0.08838f);
            f522.AddVertex(-1.28160f, 6.88277f, 0.07919f);
            faces.Add(f522);

            Face f523 = new Face(m05___Default);
            f523.AddVertex(-1.26947f, 6.88359f, 0.04725f);
            f523.AddVertex(-1.17400f, 6.69723f, 0.05645f);
            f523.AddVertex(-1.18393f, 6.69397f, 0.07252f);
            f523.AddVertex(-1.27956f, 6.88061f, 0.06330f);
            faces.Add(f523);

            Face f524 = new Face(m05___Default);
            f524.AddVertex(-1.25405f, 6.89091f, 0.03533f);
            f524.AddVertex(-1.15898f, 6.70533f, 0.04449f);
            f524.AddVertex(-1.17400f, 6.69723f, 0.05645f);
            f524.AddVertex(-1.26947f, 6.88359f, 0.04725f);
            faces.Add(f524);

            Face f525 = new Face(m05___Default);
            f525.AddVertex(-1.23744f, 6.90061f, 0.03074f);
            f525.AddVertex(-1.14291f, 6.71610f, 0.03985f);
            f525.AddVertex(-1.15898f, 6.70533f, 0.04449f);
            f525.AddVertex(-1.25405f, 6.89091f, 0.03533f);
            faces.Add(f525);

            Face f526 = new Face(m05___Default);
            f526.AddVertex(-1.22407f, 6.91008f, 0.03470f);
            f526.AddVertex(-1.13008f, 6.72664f, 0.04376f);
            f526.AddVertex(-1.14291f, 6.71610f, 0.03985f);
            f526.AddVertex(-1.23744f, 6.90061f, 0.03074f);
            faces.Add(f526);

            Face f527 = new Face(m05___Default);
            f527.AddVertex(-1.21753f, 6.91680f, 0.04616f);
            f527.AddVertex(-1.12395f, 6.73414f, 0.05518f);
            f527.AddVertex(-1.13008f, 6.72664f, 0.04376f);
            f527.AddVertex(-1.22407f, 6.91008f, 0.03470f);
            faces.Add(f527);

            Face f528 = new Face(m05___Default);
            f528.AddVertex(-1.21957f, 6.91896f, 0.06204f);
            f528.AddVertex(-1.12614f, 6.73658f, 0.07105f);
            f528.AddVertex(-1.12395f, 6.73414f, 0.05518f);
            f528.AddVertex(-1.21753f, 6.91680f, 0.04616f);
            faces.Add(f528);

            Face f529 = new Face(m05___Default);
            f529.AddVertex(-1.38279f, 6.99683f, 0.08493f);
            f529.AddVertex(-1.27507f, 6.88949f, 0.09064f);
            f529.AddVertex(-1.26170f, 6.89896f, 0.09461f);
            f529.AddVertex(-1.37129f, 7.00816f, 0.08879f);
            faces.Add(f529);

            Face f530 = new Face(m05___Default);
            f530.AddVertex(-1.38795f, 6.98874f, 0.07354f);
            f530.AddVertex(-1.28160f, 6.88277f, 0.07919f);
            f530.AddVertex(-1.27507f, 6.88949f, 0.09064f);
            f530.AddVertex(-1.38279f, 6.99683f, 0.08493f);
            faces.Add(f530);

            Face f531 = new Face(m05___Default);
            f531.AddVertex(-1.38541f, 6.98609f, 0.05768f);
            f531.AddVertex(-1.27956f, 6.88061f, 0.06330f);
            f531.AddVertex(-1.28160f, 6.88277f, 0.07919f);
            f531.AddVertex(-1.38795f, 6.98874f, 0.07354f);
            faces.Add(f531);

            Face f532 = new Face(m05___Default);
            f532.AddVertex(-1.37582f, 6.98956f, 0.04160f);
            f532.AddVertex(-1.26947f, 6.88359f, 0.04725f);
            f532.AddVertex(-1.27956f, 6.88061f, 0.06330f);
            f532.AddVertex(-1.38541f, 6.98609f, 0.05768f);
            faces.Add(f532);

            Face f533 = new Face(m05___Default);
            f533.AddVertex(-1.36177f, 6.99825f, 0.02961f);
            f533.AddVertex(-1.25405f, 6.89091f, 0.03533f);
            f533.AddVertex(-1.26947f, 6.88359f, 0.04725f);
            f533.AddVertex(-1.37582f, 6.98956f, 0.04160f);
            faces.Add(f533);

            Face f534 = new Face(m05___Default);
            f534.AddVertex(-1.34702f, 7.00981f, 0.02492f);
            f534.AddVertex(-1.23744f, 6.90061f, 0.03074f);
            f534.AddVertex(-1.25405f, 6.89091f, 0.03533f);
            f534.AddVertex(-1.36177f, 6.99825f, 0.02961f);
            faces.Add(f534);

            Face f535 = new Face(m05___Default);
            f535.AddVertex(-0.87622f, 6.58910f, 0.05201f);
            f535.AddVertex(-0.87723f, 6.60062f, 0.06319f);
            f535.AddVertex(-0.88204f, 6.60453f, 0.07897f);
            f535.AddVertex(-0.87930f, 6.57307f, 0.04842f);
            faces.Add(f535);

            Face f536 = new Face(m05___Default);
            f536.AddVertex(-0.88562f, 6.55682f, 0.05339f);
            f536.AddVertex(-0.87930f, 6.57307f, 0.04842f);
            f536.AddVertex(-0.88204f, 6.60453f, 0.07897f);
            f536.AddVertex(-0.89349f, 6.54470f, 0.06559f);
            faces.Add(f536);

            Face f537 = new Face(m05___Default);
            f537.AddVertex(-0.90082f, 6.53996f, 0.08174f);
            f537.AddVertex(-0.89349f, 6.54470f, 0.06559f);
            f537.AddVertex(-0.88204f, 6.60453f, 0.07897f);
            f537.AddVertex(-0.90563f, 6.54388f, 0.09753f);
            faces.Add(f537);

            Face f538 = new Face(m05___Default);
            f538.AddVertex(-0.90663f, 6.55540f, 0.10871f);
            f538.AddVertex(-0.90563f, 6.54388f, 0.09753f);
            f538.AddVertex(-0.88204f, 6.60453f, 0.07897f);
            f538.AddVertex(-0.90356f, 6.57143f, 0.11229f);
            faces.Add(f538);

            Face f539 = new Face(m05___Default);
            f539.AddVertex(-0.89724f, 6.58768f, 0.10732f);
            f539.AddVertex(-0.90356f, 6.57143f, 0.11229f);
            f539.AddVertex(-0.88204f, 6.60453f, 0.07897f);
            f539.AddVertex(-0.88936f, 6.59980f, 0.09512f);
            faces.Add(f539);

            Face f540 = new Face(m05___Default);
            f540.AddVertex(-0.15886f, 1.32343f, 0.04531f);
            f540.AddVertex(-0.17079f, 0.91844f, 0.08969f);
            f540.AddVertex(-0.15452f, 0.91816f, 0.09417f);
            f540.AddVertex(-0.14260f, 1.32287f, 0.04982f);
            faces.Add(f540);

            Face f541 = new Face(m05___Default);
            f541.AddVertex(-0.16745f, 1.32506f, 0.03326f);
            f541.AddVertex(-0.17941f, 0.91927f, 0.07774f);
            f541.AddVertex(-0.17079f, 0.91844f, 0.08969f);
            f541.AddVertex(-0.15886f, 1.32343f, 0.04531f);
            faces.Add(f541);

            Face f542 = new Face(m05___Default);
            f542.AddVertex(-0.16608f, 1.32733f, 0.01692f);
            f542.AddVertex(-0.17806f, 0.92044f, 0.06151f);
            f542.AddVertex(-0.17941f, 0.91927f, 0.07774f);
            f542.AddVertex(-0.16745f, 1.32506f, 0.03326f);
            faces.Add(f542);

            Face f543 = new Face(m05___Default);
            f543.AddVertex(-0.15511f, 1.32962f, 0.00065f);
            f543.AddVertex(-0.16713f, 0.92165f, 0.04536f);
            f543.AddVertex(-0.17806f, 0.92044f, 0.06151f);
            f543.AddVertex(-0.16608f, 1.32733f, 0.01692f);
            faces.Add(f543);

            Face f544 = new Face(m05___Default);
            f544.AddVertex(-0.13748f, 1.33132f, -0.01117f);
            f544.AddVertex(-0.14952f, 0.92255f, 0.03361f);
            f544.AddVertex(-0.16713f, 0.92165f, 0.04536f);
            f544.AddVertex(-0.15511f, 1.32962f, 0.00065f);
            faces.Add(f544);

            Face f545 = new Face(m05___Default);
            f545.AddVertex(-0.11791f, 1.33197f, -0.01541f);
            f545.AddVertex(-0.12996f, 0.92291f, 0.02942f);
            f545.AddVertex(-0.14952f, 0.92255f, 0.03361f);
            f545.AddVertex(-0.13748f, 1.33132f, -0.01117f);
            faces.Add(f545);

            Face f546 = new Face(m05___Default);
            f546.AddVertex(-0.10165f, 1.33141f, -0.01090f);
            f546.AddVertex(-0.11369f, 0.92264f, 0.03390f);
            f546.AddVertex(-0.12996f, 0.92291f, 0.02942f);
            f546.AddVertex(-0.11791f, 1.33197f, -0.01541f);
            faces.Add(f546);

            Face f547 = new Face(m05___Default);
            f547.AddVertex(-0.09306f, 1.32978f, 0.00114f);
            f547.AddVertex(-0.10507f, 0.92181f, 0.04585f);
            f547.AddVertex(-0.11369f, 0.92264f, 0.03390f);
            f547.AddVertex(-0.10165f, 1.33141f, -0.01090f);
            faces.Add(f547);

            Face f548 = new Face(m05___Default);
            f548.AddVertex(-0.09443f, 1.32751f, 0.01748f);
            f548.AddVertex(-0.10642f, 0.92063f, 0.06208f);
            f548.AddVertex(-0.10507f, 0.92181f, 0.04585f);
            f548.AddVertex(-0.09306f, 1.32978f, 0.00114f);
            faces.Add(f548);

            Face f549 = new Face(m05___Default);
            f549.AddVertex(-0.10540f, 1.32522f, 0.03375f);
            f549.AddVertex(-0.11736f, 0.91943f, 0.07823f);
            f549.AddVertex(-0.10642f, 0.92063f, 0.06208f);
            f549.AddVertex(-0.09443f, 1.32751f, 0.01748f);
            faces.Add(f549);

            Face f550 = new Face(m05___Default);
            f550.AddVertex(-0.12303f, 1.32352f, 0.04559f);
            f550.AddVertex(-0.13496f, 0.91853f, 0.08998f);
            f550.AddVertex(-0.11736f, 0.91943f, 0.07823f);
            f550.AddVertex(-0.10540f, 1.32522f, 0.03375f);
            faces.Add(f550);

            Face f551 = new Face(m05___Default);
            f551.AddVertex(-0.14260f, 1.32287f, 0.04982f);
            f551.AddVertex(-0.15452f, 0.91816f, 0.09417f);
            f551.AddVertex(-0.13496f, 0.91853f, 0.08998f);
            f551.AddVertex(-0.12303f, 1.32352f, 0.04559f);
            faces.Add(f551);

            Face f552 = new Face(m05___Default);
            f552.AddVertex(-0.15682f, 1.66105f, 0.02909f);
            f552.AddVertex(-0.15886f, 1.32343f, 0.04531f);
            f552.AddVertex(-0.14260f, 1.32287f, 0.04982f);
            f552.AddVertex(-0.14056f, 1.66011f, 0.03361f);
            faces.Add(f552);

            Face f553 = new Face(m05___Default);
            f553.AddVertex(-0.16540f, 1.66370f, 0.01700f);
            f553.AddVertex(-0.16745f, 1.32506f, 0.03326f);
            f553.AddVertex(-0.15886f, 1.32343f, 0.04531f);
            f553.AddVertex(-0.15682f, 1.66105f, 0.02909f);
            faces.Add(f553);

            Face f554 = new Face(m05___Default);
            f554.AddVertex(-0.16402f, 1.66735f, 0.00058f);
            f554.AddVertex(-0.16608f, 1.32733f, 0.01692f);
            f554.AddVertex(-0.16745f, 1.32506f, 0.03326f);
            f554.AddVertex(-0.16540f, 1.66370f, 0.01700f);
            faces.Add(f554);

            Face f555 = new Face(m05___Default);
            f555.AddVertex(-0.15305f, 1.67103f, -0.01574f);
            f555.AddVertex(-0.15511f, 1.32962f, 0.00065f);
            f555.AddVertex(-0.16608f, 1.32733f, 0.01692f);
            f555.AddVertex(-0.16402f, 1.66735f, 0.00058f);
            faces.Add(f555);

            Face f556 = new Face(m05___Default);
            f556.AddVertex(-0.13541f, 1.67374f, -0.02763f);
            f556.AddVertex(-0.13748f, 1.33132f, -0.01117f);
            f556.AddVertex(-0.15511f, 1.32962f, 0.00065f);
            f556.AddVertex(-0.15305f, 1.67103f, -0.01574f);
            faces.Add(f556);

            Face f557 = new Face(m05___Default);
            f557.AddVertex(-0.11584f, 1.67477f, -0.03187f);
            f557.AddVertex(-0.11791f, 1.33197f, -0.01541f);
            f557.AddVertex(-0.13748f, 1.33132f, -0.01117f);
            f557.AddVertex(-0.13541f, 1.67374f, -0.02763f);
            faces.Add(f557);

            Face f558 = new Face(m05___Default);
            f558.AddVertex(-0.09958f, 1.67383f, -0.02734f);
            f558.AddVertex(-0.10165f, 1.33141f, -0.01090f);
            f558.AddVertex(-0.11791f, 1.33197f, -0.01541f);
            f558.AddVertex(-0.11584f, 1.67477f, -0.03187f);
            faces.Add(f558);

            Face f559 = new Face(m05___Default);
            f559.AddVertex(-0.09100f, 1.67119f, -0.01525f);
            f559.AddVertex(-0.09306f, 1.32978f, 0.00114f);
            f559.AddVertex(-0.10165f, 1.33141f, -0.01090f);
            f559.AddVertex(-0.09958f, 1.67383f, -0.02734f);
            faces.Add(f559);

            Face f560 = new Face(m05___Default);
            f560.AddVertex(-0.09238f, 1.66753f, 0.00115f);
            f560.AddVertex(-0.09443f, 1.32751f, 0.01748f);
            f560.AddVertex(-0.09306f, 1.32978f, 0.00114f);
            f560.AddVertex(-0.09100f, 1.67119f, -0.01525f);
            faces.Add(f560);

            Face f561 = new Face(m05___Default);
            f561.AddVertex(-0.10335f, 1.66385f, 0.01748f);
            f561.AddVertex(-0.10540f, 1.32522f, 0.03375f);
            f561.AddVertex(-0.09443f, 1.32751f, 0.01748f);
            f561.AddVertex(-0.09238f, 1.66753f, 0.00115f);
            faces.Add(f561);

            Face f562 = new Face(m05___Default);
            f562.AddVertex(-0.12099f, 1.66114f, 0.02937f);
            f562.AddVertex(-0.12303f, 1.32352f, 0.04559f);
            f562.AddVertex(-0.10540f, 1.32522f, 0.03375f);
            f562.AddVertex(-0.10335f, 1.66385f, 0.01748f);
            faces.Add(f562);

            Face f563 = new Face(m05___Default);
            f563.AddVertex(-0.14056f, 1.66011f, 0.03361f);
            f563.AddVertex(-0.14260f, 1.32287f, 0.04982f);
            f563.AddVertex(-0.12303f, 1.32352f, 0.04559f);
            f563.AddVertex(-0.12099f, 1.66114f, 0.02937f);
            faces.Add(f563);

            Face f564 = new Face(m05___Default);
            f564.AddVertex(-0.15700f, 1.91507f, 0.02141f);
            f564.AddVertex(-0.15682f, 1.66105f, 0.02909f);
            f564.AddVertex(-0.14056f, 1.66011f, 0.03361f);
            f564.AddVertex(-0.14074f, 1.91386f, 0.02594f);
            faces.Add(f564);

            Face f565 = new Face(m05___Default);
            f565.AddVertex(-0.16559f, 1.91844f, 0.00930f);
            f565.AddVertex(-0.16540f, 1.66370f, 0.01700f);
            f565.AddVertex(-0.15682f, 1.66105f, 0.02909f);
            f565.AddVertex(-0.15700f, 1.91507f, 0.02141f);
            faces.Add(f565);

            Face f566 = new Face(m05___Default);
            f566.AddVertex(-0.16421f, 1.92309f, -0.00714f);
            f566.AddVertex(-0.16402f, 1.66735f, 0.00058f);
            f566.AddVertex(-0.16540f, 1.66370f, 0.01700f);
            f566.AddVertex(-0.16559f, 1.91844f, 0.00930f);
            faces.Add(f566);

            Face f567 = new Face(m05___Default);
            f567.AddVertex(-0.15323f, 1.92776f, -0.02350f);
            f567.AddVertex(-0.15305f, 1.67103f, -0.01574f);
            f567.AddVertex(-0.16402f, 1.66735f, 0.00058f);
            f567.AddVertex(-0.16421f, 1.92309f, -0.00714f);
            faces.Add(f567);

            Face f568 = new Face(m05___Default);
            f568.AddVertex(-0.13559f, 1.93120f, -0.03540f);
            f568.AddVertex(-0.13541f, 1.67374f, -0.02763f);
            f568.AddVertex(-0.15305f, 1.67103f, -0.01574f);
            f568.AddVertex(-0.15323f, 1.92776f, -0.02350f);
            faces.Add(f568);

            Face f569 = new Face(m05___Default);
            f569.AddVertex(-0.11603f, 1.93250f, -0.03966f);
            f569.AddVertex(-0.11584f, 1.67477f, -0.03187f);
            f569.AddVertex(-0.13541f, 1.67374f, -0.02763f);
            f569.AddVertex(-0.13559f, 1.93120f, -0.03540f);
            faces.Add(f569);

            Face f570 = new Face(m05___Default);
            f570.AddVertex(-0.09977f, 1.93129f, -0.03512f);
            f570.AddVertex(-0.09958f, 1.67383f, -0.02734f);
            f570.AddVertex(-0.11584f, 1.67477f, -0.03187f);
            f570.AddVertex(-0.11603f, 1.93250f, -0.03966f);
            faces.Add(f570);

            Face f571 = new Face(m05___Default);
            f571.AddVertex(-0.09118f, 1.92792f, -0.02301f);
            f571.AddVertex(-0.09100f, 1.67119f, -0.01525f);
            f571.AddVertex(-0.09958f, 1.67383f, -0.02734f);
            f571.AddVertex(-0.09977f, 1.93129f, -0.03512f);
            faces.Add(f571);

            Face f572 = new Face(m05___Default);
            f572.AddVertex(-0.09256f, 1.92327f, -0.00657f);
            f572.AddVertex(-0.09238f, 1.66753f, 0.00115f);
            f572.AddVertex(-0.09100f, 1.67119f, -0.01525f);
            f572.AddVertex(-0.09118f, 1.92792f, -0.02301f);
            faces.Add(f572);

            Face f573 = new Face(m05___Default);
            f573.AddVertex(-0.10354f, 1.91860f, 0.00979f);
            f573.AddVertex(-0.10335f, 1.66385f, 0.01748f);
            f573.AddVertex(-0.09238f, 1.66753f, 0.00115f);
            f573.AddVertex(-0.09256f, 1.92327f, -0.00657f);
            faces.Add(f573);

            Face f574 = new Face(m05___Default);
            f574.AddVertex(-0.12117f, 1.91516f, 0.02169f);
            f574.AddVertex(-0.12099f, 1.66114f, 0.02937f);
            f574.AddVertex(-0.10335f, 1.66385f, 0.01748f);
            f574.AddVertex(-0.10354f, 1.91860f, 0.00979f);
            faces.Add(f574);

            Face f575 = new Face(m05___Default);
            f575.AddVertex(-0.14074f, 1.91386f, 0.02594f);
            f575.AddVertex(-0.14056f, 1.66011f, 0.03361f);
            f575.AddVertex(-0.12099f, 1.66114f, 0.02937f);
            f575.AddVertex(-0.12117f, 1.91516f, 0.02169f);
            faces.Add(f575);

            Face f576 = new Face(m05___Default);
            f576.AddVertex(-0.16164f, 2.20352f, 0.02436f);
            f576.AddVertex(-0.15700f, 1.91507f, 0.02141f);
            f576.AddVertex(-0.14074f, 1.91386f, 0.02594f);
            f576.AddVertex(-0.14537f, 2.20159f, 0.02889f);
            faces.Add(f576);

            Face f577 = new Face(m05___Default);
            f577.AddVertex(-0.17027f, 2.20888f, 0.01227f);
            f577.AddVertex(-0.16559f, 1.91844f, 0.00930f);
            f577.AddVertex(-0.15700f, 1.91507f, 0.02141f);
            f577.AddVertex(-0.16164f, 2.20352f, 0.02436f);
            faces.Add(f577);

            Face f578 = new Face(m05___Default);
            f578.AddVertex(-0.16893f, 2.21624f, -0.00414f);
            f578.AddVertex(-0.16421f, 1.92309f, -0.00714f);
            f578.AddVertex(-0.16559f, 1.91844f, 0.00930f);
            f578.AddVertex(-0.17027f, 2.20888f, 0.01227f);
            faces.Add(f578);

            Face f579 = new Face(m05___Default);
            f579.AddVertex(-0.15800f, 2.22362f, -0.02048f);
            f579.AddVertex(-0.15323f, 1.92776f, -0.02350f);
            f579.AddVertex(-0.16421f, 1.92309f, -0.00714f);
            f579.AddVertex(-0.16893f, 2.21624f, -0.00414f);
            faces.Add(f579);

            Face f580 = new Face(m05___Default);
            f580.AddVertex(-0.14039f, 2.22905f, -0.03236f);
            f580.AddVertex(-0.13559f, 1.93120f, -0.03540f);
            f580.AddVertex(-0.15323f, 1.92776f, -0.02350f);
            f580.AddVertex(-0.15800f, 2.22362f, -0.02048f);
            faces.Add(f580);

            Face f581 = new Face(m05___Default);
            f581.AddVertex(-0.12083f, 2.23106f, -0.03661f);
            f581.AddVertex(-0.11603f, 1.93250f, -0.03966f);
            f581.AddVertex(-0.13559f, 1.93120f, -0.03540f);
            f581.AddVertex(-0.14039f, 2.22905f, -0.03236f);
            faces.Add(f581);

            Face f582 = new Face(m05___Default);
            f582.AddVertex(-0.10456f, 2.22913f, -0.03208f);
            f582.AddVertex(-0.09977f, 1.93129f, -0.03512f);
            f582.AddVertex(-0.11603f, 1.93250f, -0.03966f);
            f582.AddVertex(-0.12083f, 2.23106f, -0.03661f);
            faces.Add(f582);

            Face f583 = new Face(m05___Default);
            f583.AddVertex(-0.09594f, 2.22378f, -0.01998f);
            f583.AddVertex(-0.09118f, 1.92792f, -0.02301f);
            f583.AddVertex(-0.09977f, 1.93129f, -0.03512f);
            f583.AddVertex(-0.10456f, 2.22913f, -0.03208f);
            faces.Add(f583);

            Face f584 = new Face(m05___Default);
            f584.AddVertex(-0.09728f, 2.21642f, -0.00357f);
            f584.AddVertex(-0.09256f, 1.92327f, -0.00657f);
            f584.AddVertex(-0.09118f, 1.92792f, -0.02301f);
            f584.AddVertex(-0.09594f, 2.22378f, -0.01998f);
            faces.Add(f584);

            Face f585 = new Face(m05___Default);
            f585.AddVertex(-0.10822f, 2.20904f, 0.01275f);
            f585.AddVertex(-0.10354f, 1.91860f, 0.00979f);
            f585.AddVertex(-0.09256f, 1.92327f, -0.00657f);
            f585.AddVertex(-0.09728f, 2.21642f, -0.00357f);
            faces.Add(f585);

            Face f586 = new Face(m05___Default);
            f586.AddVertex(-0.12582f, 2.20361f, 0.02464f);
            f586.AddVertex(-0.12117f, 1.91516f, 0.02169f);
            f586.AddVertex(-0.10354f, 1.91860f, 0.00979f);
            f586.AddVertex(-0.10822f, 2.20904f, 0.01275f);
            faces.Add(f586);

            Face f587 = new Face(m05___Default);
            f587.AddVertex(-0.14537f, 2.20159f, 0.02889f);
            f587.AddVertex(-0.14074f, 1.91386f, 0.02594f);
            f587.AddVertex(-0.12117f, 1.91516f, 0.02169f);
            f587.AddVertex(-0.12582f, 2.20361f, 0.02464f);
            faces.Add(f587);

            Face f588 = new Face(m05___Default);
            f588.AddVertex(-0.18012f, 2.48721f, 0.06383f);
            f588.AddVertex(-0.16164f, 2.20352f, 0.02436f);
            f588.AddVertex(-0.14537f, 2.20159f, 0.02889f);
            f588.AddVertex(-0.16376f, 2.48399f, 0.06818f);
            faces.Add(f588);

            Face f589 = new Face(m05___Default);
            f589.AddVertex(-0.18897f, 2.49609f, 0.05223f);
            f589.AddVertex(-0.17027f, 2.20888f, 0.01227f);
            f589.AddVertex(-0.16164f, 2.20352f, 0.02436f);
            f589.AddVertex(-0.18012f, 2.48721f, 0.06383f);
            faces.Add(f589);

            Face f590 = new Face(m05___Default);
            f590.AddVertex(-0.18794f, 2.50826f, 0.03648f);
            f590.AddVertex(-0.16893f, 2.21624f, -0.00414f);
            f590.AddVertex(-0.17027f, 2.20888f, 0.01227f);
            f590.AddVertex(-0.18897f, 2.49609f, 0.05223f);
            faces.Add(f590);

            Face f591 = new Face(m05___Default);
            f591.AddVertex(-0.17732f, 2.52046f, 0.02082f);
            f591.AddVertex(-0.15800f, 2.22362f, -0.02048f);
            f591.AddVertex(-0.16893f, 2.21624f, -0.00414f);
            f591.AddVertex(-0.18794f, 2.50826f, 0.03648f);
            faces.Add(f591);

            Face f592 = new Face(m05___Default);
            f592.AddVertex(-0.15994f, 2.52941f, 0.00942f);
            f592.AddVertex(-0.14039f, 2.22905f, -0.03236f);
            f592.AddVertex(-0.15800f, 2.22362f, -0.02048f);
            f592.AddVertex(-0.17732f, 2.52046f, 0.02082f);
            faces.Add(f592);

            Face f593 = new Face(m05___Default);
            f593.AddVertex(-0.14047f, 2.53272f, 0.00535f);
            f593.AddVertex(-0.12083f, 2.23106f, -0.03661f);
            f593.AddVertex(-0.14039f, 2.22905f, -0.03236f);
            f593.AddVertex(-0.15994f, 2.52941f, 0.00942f);
            faces.Add(f593);

            Face f594 = new Face(m05___Default);
            f594.AddVertex(-0.12412f, 2.52950f, 0.00970f);
            f594.AddVertex(-0.10456f, 2.22913f, -0.03208f);
            f594.AddVertex(-0.12083f, 2.23106f, -0.03661f);
            f594.AddVertex(-0.14047f, 2.53272f, 0.00535f);
            faces.Add(f594);

            Face f595 = new Face(m05___Default);
            f595.AddVertex(-0.11527f, 2.52061f, 0.02130f);
            f595.AddVertex(-0.09594f, 2.22378f, -0.01998f);
            f595.AddVertex(-0.10456f, 2.22913f, -0.03208f);
            f595.AddVertex(-0.12412f, 2.52950f, 0.00970f);
            faces.Add(f595);

            Face f596 = new Face(m05___Default);
            f596.AddVertex(-0.11629f, 2.50845f, 0.03705f);
            f596.AddVertex(-0.09728f, 2.21642f, -0.00357f);
            f596.AddVertex(-0.09594f, 2.22378f, -0.01998f);
            f596.AddVertex(-0.11527f, 2.52061f, 0.02130f);
            faces.Add(f596);

            Face f597 = new Face(m05___Default);
            f597.AddVertex(-0.12691f, 2.49625f, 0.05271f);
            f597.AddVertex(-0.10822f, 2.20904f, 0.01275f);
            f597.AddVertex(-0.09728f, 2.21642f, -0.00357f);
            f597.AddVertex(-0.11629f, 2.50845f, 0.03705f);
            faces.Add(f597);

            Face f598 = new Face(m05___Default);
            f598.AddVertex(-0.14429f, 2.48730f, 0.06411f);
            f598.AddVertex(-0.12582f, 2.20361f, 0.02464f);
            f598.AddVertex(-0.10822f, 2.20904f, 0.01275f);
            f598.AddVertex(-0.12691f, 2.49625f, 0.05271f);
            faces.Add(f598);

            Face f599 = new Face(m05___Default);
            f599.AddVertex(-0.16376f, 2.48399f, 0.06818f);
            f599.AddVertex(-0.14537f, 2.20159f, 0.02889f);
            f599.AddVertex(-0.12582f, 2.20361f, 0.02464f);
            f599.AddVertex(-0.14429f, 2.48730f, 0.06411f);
            faces.Add(f599);

            Face f600 = new Face(m05___Default);
            f600.AddVertex(-0.20667f, 2.65848f, 0.12817f);
            f600.AddVertex(-0.18012f, 2.48721f, 0.06383f);
            f600.AddVertex(-0.16376f, 2.48399f, 0.06818f);
            f600.AddVertex(-0.19023f, 2.65474f, 0.13232f);
            faces.Add(f600);

            Face f601 = new Face(m05___Default);
            f601.AddVertex(-0.21574f, 2.66881f, 0.11711f);
            f601.AddVertex(-0.18897f, 2.49609f, 0.05223f);
            f601.AddVertex(-0.18012f, 2.48721f, 0.06383f);
            f601.AddVertex(-0.20667f, 2.65848f, 0.12817f);
            faces.Add(f601);

            Face f602 = new Face(m05___Default);
            f602.AddVertex(-0.21503f, 2.68294f, 0.10210f);
            f602.AddVertex(-0.18794f, 2.50826f, 0.03648f);
            f602.AddVertex(-0.18897f, 2.49609f, 0.05223f);
            f602.AddVertex(-0.21574f, 2.66881f, 0.11711f);
            faces.Add(f602);

            Face f603 = new Face(m05___Default);
            f603.AddVertex(-0.20471f, 2.69709f, 0.08717f);
            f603.AddVertex(-0.17732f, 2.52046f, 0.02082f);
            f603.AddVertex(-0.18794f, 2.50826f, 0.03648f);
            f603.AddVertex(-0.21503f, 2.68294f, 0.10210f);
            faces.Add(f603);

            Face f604 = new Face(m05___Default);
            f604.AddVertex(-0.18756f, 2.70748f, 0.07631f);
            f604.AddVertex(-0.15994f, 2.52941f, 0.00942f);
            f604.AddVertex(-0.17732f, 2.52046f, 0.02082f);
            f604.AddVertex(-0.20471f, 2.69709f, 0.08717f);
            faces.Add(f604);

            Face f605 = new Face(m05___Default);
            f605.AddVertex(-0.16816f, 2.71132f, 0.07245f);
            f605.AddVertex(-0.14047f, 2.53272f, 0.00535f);
            f605.AddVertex(-0.15994f, 2.52941f, 0.00942f);
            f605.AddVertex(-0.18756f, 2.70748f, 0.07631f);
            faces.Add(f605);

            Face f606 = new Face(m05___Default);
            f606.AddVertex(-0.15173f, 2.70757f, 0.07660f);
            f606.AddVertex(-0.12412f, 2.52950f, 0.00970f);
            f606.AddVertex(-0.14047f, 2.53272f, 0.00535f);
            f606.AddVertex(-0.16816f, 2.71132f, 0.07245f);
            faces.Add(f606);

            Face f607 = new Face(m05___Default);
            f607.AddVertex(-0.14266f, 2.69725f, 0.08766f);
            f607.AddVertex(-0.11527f, 2.52061f, 0.02130f);
            f607.AddVertex(-0.12412f, 2.52950f, 0.00970f);
            f607.AddVertex(-0.15173f, 2.70757f, 0.07660f);
            faces.Add(f607);

            Face f608 = new Face(m05___Default);
            f608.AddVertex(-0.14338f, 2.68312f, 0.10267f);
            f608.AddVertex(-0.11629f, 2.50845f, 0.03705f);
            f608.AddVertex(-0.11527f, 2.52061f, 0.02130f);
            f608.AddVertex(-0.14266f, 2.69725f, 0.08766f);
            faces.Add(f608);

            Face f609 = new Face(m05___Default);
            f609.AddVertex(-0.15369f, 2.66896f, 0.11760f);
            f609.AddVertex(-0.12691f, 2.49625f, 0.05271f);
            f609.AddVertex(-0.11629f, 2.50845f, 0.03705f);
            f609.AddVertex(-0.14338f, 2.68312f, 0.10267f);
            faces.Add(f609);

            Face f610 = new Face(m05___Default);
            f610.AddVertex(-0.17085f, 2.65858f, 0.12846f);
            f610.AddVertex(-0.14429f, 2.48730f, 0.06411f);
            f610.AddVertex(-0.12691f, 2.49625f, 0.05271f);
            f610.AddVertex(-0.15369f, 2.66896f, 0.11760f);
            faces.Add(f610);

            Face f611 = new Face(m05___Default);
            f611.AddVertex(-0.19023f, 2.65474f, 0.13232f);
            f611.AddVertex(-0.16376f, 2.48399f, 0.06818f);
            f611.AddVertex(-0.14429f, 2.48730f, 0.06411f);
            f611.AddVertex(-0.17085f, 2.65858f, 0.12846f);
            faces.Add(f611);

            Face f612 = new Face(m05___Default);
            f612.AddVertex(-0.22762f, 2.81515f, 0.17823f);
            f612.AddVertex(-0.20667f, 2.65848f, 0.12817f);
            f612.AddVertex(-0.19023f, 2.65474f, 0.13232f);
            f612.AddVertex(-0.21116f, 2.81120f, 0.18232f);
            faces.Add(f612);

            Face f613 = new Face(m05___Default);
            f613.AddVertex(-0.23676f, 2.82602f, 0.16735f);
            f613.AddVertex(-0.21574f, 2.66881f, 0.11711f);
            f613.AddVertex(-0.20667f, 2.65848f, 0.12817f);
            f613.AddVertex(-0.22762f, 2.81515f, 0.17823f);
            faces.Add(f613);

            Face f614 = new Face(m05___Default);
            f614.AddVertex(-0.23615f, 2.84091f, 0.15259f);
            f614.AddVertex(-0.21503f, 2.68294f, 0.10210f);
            f614.AddVertex(-0.21574f, 2.66881f, 0.11711f);
            f614.AddVertex(-0.23676f, 2.82602f, 0.16735f);
            faces.Add(f614);

            Face f615 = new Face(m05___Default);
            f615.AddVertex(-0.22593f, 2.85583f, 0.13790f);
            f615.AddVertex(-0.20471f, 2.69709f, 0.08717f);
            f615.AddVertex(-0.21503f, 2.68294f, 0.10210f);
            f615.AddVertex(-0.23615f, 2.84091f, 0.15259f);
            faces.Add(f615);

            Face f616 = new Face(m05___Default);
            f616.AddVertex(-0.20885f, 2.86677f, 0.12722f);
            f616.AddVertex(-0.18756f, 2.70748f, 0.07631f);
            f616.AddVertex(-0.20471f, 2.69709f, 0.08717f);
            f616.AddVertex(-0.22593f, 2.85583f, 0.13790f);
            faces.Add(f616);

            Face f617 = new Face(m05___Default);
            f617.AddVertex(-0.18949f, 2.87081f, 0.12341f);
            f617.AddVertex(-0.16816f, 2.71132f, 0.07245f);
            f617.AddVertex(-0.18756f, 2.70748f, 0.07631f);
            f617.AddVertex(-0.20885f, 2.86677f, 0.12722f);
            faces.Add(f617);

            Face f618 = new Face(m05___Default);
            f618.AddVertex(-0.17303f, 2.86686f, 0.12750f);
            f618.AddVertex(-0.15173f, 2.70757f, 0.07660f);
            f618.AddVertex(-0.16816f, 2.71132f, 0.07245f);
            f618.AddVertex(-0.18949f, 2.87081f, 0.12341f);
            faces.Add(f618);

            Face f619 = new Face(m05___Default);
            f619.AddVertex(-0.16388f, 2.85599f, 0.13838f);
            f619.AddVertex(-0.14266f, 2.69725f, 0.08766f);
            f619.AddVertex(-0.15173f, 2.70757f, 0.07660f);
            f619.AddVertex(-0.17303f, 2.86686f, 0.12750f);
            faces.Add(f619);

            Face f620 = new Face(m05___Default);
            f620.AddVertex(-0.16450f, 2.84110f, 0.15315f);
            f620.AddVertex(-0.14338f, 2.68312f, 0.10267f);
            f620.AddVertex(-0.14266f, 2.69725f, 0.08766f);
            f620.AddVertex(-0.16388f, 2.85599f, 0.13838f);
            faces.Add(f620);

            Face f621 = new Face(m05___Default);
            f621.AddVertex(-0.17471f, 2.82618f, 0.16784f);
            f621.AddVertex(-0.15369f, 2.66896f, 0.11760f);
            f621.AddVertex(-0.14338f, 2.68312f, 0.10267f);
            f621.AddVertex(-0.16450f, 2.84110f, 0.15315f);
            faces.Add(f621);

            Face f622 = new Face(m05___Default);
            f622.AddVertex(-0.19180f, 2.81524f, 0.17852f);
            f622.AddVertex(-0.17085f, 2.65858f, 0.12846f);
            f622.AddVertex(-0.15369f, 2.66896f, 0.11760f);
            f622.AddVertex(-0.17471f, 2.82618f, 0.16784f);
            faces.Add(f622);

            Face f623 = new Face(m05___Default);
            f623.AddVertex(-0.21116f, 2.81120f, 0.18232f);
            f623.AddVertex(-0.19023f, 2.65474f, 0.13232f);
            f623.AddVertex(-0.17085f, 2.65858f, 0.12846f);
            f623.AddVertex(-0.19180f, 2.81524f, 0.17852f);
            faces.Add(f623);

            Face f624 = new Face(m05___Default);
            f624.AddVertex(-0.26572f, 3.01744f, 0.27194f);
            f624.AddVertex(-0.22762f, 2.81515f, 0.17823f);
            f624.AddVertex(-0.21116f, 2.81120f, 0.18232f);
            f624.AddVertex(-0.24931f, 3.01378f, 0.27616f);
            faces.Add(f624);

            Face f625 = new Face(m05___Default);
            f625.AddVertex(-0.27471f, 3.02754f, 0.26069f);
            f625.AddVertex(-0.23676f, 2.82602f, 0.16735f);
            f625.AddVertex(-0.22762f, 2.81515f, 0.17823f);
            f625.AddVertex(-0.26572f, 3.01744f, 0.27194f);
            faces.Add(f625);

            Face f626 = new Face(m05___Default);
            f626.AddVertex(-0.27389f, 3.04136f, 0.24544f);
            f626.AddVertex(-0.23615f, 2.84091f, 0.15259f);
            f626.AddVertex(-0.23676f, 2.82602f, 0.16735f);
            f626.AddVertex(-0.27471f, 3.02754f, 0.26069f);
            faces.Add(f626);

            Face f627 = new Face(m05___Default);
            f627.AddVertex(-0.26348f, 3.05520f, 0.23025f);
            f627.AddVertex(-0.22593f, 2.85583f, 0.13790f);
            f627.AddVertex(-0.23615f, 2.84091f, 0.15259f);
            f627.AddVertex(-0.27389f, 3.04136f, 0.24544f);
            faces.Add(f627);

            Face f628 = new Face(m05___Default);
            f628.AddVertex(-0.24625f, 3.06536f, 0.21921f);
            f628.AddVertex(-0.20885f, 2.86677f, 0.12722f);
            f628.AddVertex(-0.22593f, 2.85583f, 0.13790f);
            f628.AddVertex(-0.26348f, 3.05520f, 0.23025f);
            faces.Add(f628);

            Face f629 = new Face(m05___Default);
            f629.AddVertex(-0.22684f, 3.06911f, 0.21527f);
            f629.AddVertex(-0.18949f, 2.87081f, 0.12341f);
            f629.AddVertex(-0.20885f, 2.86677f, 0.12722f);
            f629.AddVertex(-0.24625f, 3.06536f, 0.21921f);
            faces.Add(f629);

            Face f630 = new Face(m05___Default);
            f630.AddVertex(-0.21043f, 3.06545f, 0.21949f);
            f630.AddVertex(-0.17303f, 2.86686f, 0.12750f);
            f630.AddVertex(-0.18949f, 2.87081f, 0.12341f);
            f630.AddVertex(-0.22684f, 3.06911f, 0.21527f);
            faces.Add(f630);

            Face f631 = new Face(m05___Default);
            f631.AddVertex(-0.20143f, 3.05536f, 0.23073f);
            f631.AddVertex(-0.16388f, 2.85599f, 0.13838f);
            f631.AddVertex(-0.17303f, 2.86686f, 0.12750f);
            f631.AddVertex(-0.21043f, 3.06545f, 0.21949f);
            faces.Add(f631);

            Face f632 = new Face(m05___Default);
            f632.AddVertex(-0.20225f, 3.04154f, 0.24600f);
            f632.AddVertex(-0.16450f, 2.84110f, 0.15315f);
            f632.AddVertex(-0.16388f, 2.85599f, 0.13838f);
            f632.AddVertex(-0.20143f, 3.05536f, 0.23073f);
            faces.Add(f632);

            Face f633 = new Face(m05___Default);
            f633.AddVertex(-0.21266f, 3.02770f, 0.26118f);
            f633.AddVertex(-0.17471f, 2.82618f, 0.16784f);
            f633.AddVertex(-0.16450f, 2.84110f, 0.15315f);
            f633.AddVertex(-0.20225f, 3.04154f, 0.24600f);
            faces.Add(f633);

            Face f634 = new Face(m05___Default);
            f634.AddVertex(-0.22989f, 3.01754f, 0.27222f);
            f634.AddVertex(-0.19180f, 2.81524f, 0.17852f);
            f634.AddVertex(-0.17471f, 2.82618f, 0.16784f);
            f634.AddVertex(-0.21266f, 3.02770f, 0.26118f);
            faces.Add(f634);

            Face f635 = new Face(m05___Default);
            f635.AddVertex(-0.24931f, 3.01378f, 0.27616f);
            f635.AddVertex(-0.21116f, 2.81120f, 0.18232f);
            f635.AddVertex(-0.19180f, 2.81524f, 0.17852f);
            f635.AddVertex(-0.22989f, 3.01754f, 0.27222f);
            faces.Add(f635);

            Face f636 = new Face(m05___Default);
            f636.AddVertex(-0.29241f, 3.30718f, 0.33282f);
            f636.AddVertex(-0.26572f, 3.01744f, 0.27194f);
            f636.AddVertex(-0.24931f, 3.01378f, 0.27616f);
            f636.AddVertex(-0.27610f, 3.30461f, 0.33728f);
            faces.Add(f636);

            Face f637 = new Face(m05___Default);
            f637.AddVertex(-0.30113f, 3.31430f, 0.32096f);
            f637.AddVertex(-0.27471f, 3.02754f, 0.26069f);
            f637.AddVertex(-0.26572f, 3.01744f, 0.27194f);
            f637.AddVertex(-0.29241f, 3.30718f, 0.33282f);
            faces.Add(f637);

            Face f638 = new Face(m05___Default);
            f638.AddVertex(-0.29994f, 3.32405f, 0.30485f);
            f638.AddVertex(-0.27389f, 3.04136f, 0.24544f);
            f638.AddVertex(-0.27471f, 3.02754f, 0.26069f);
            f638.AddVertex(-0.30113f, 3.31430f, 0.32096f);
            faces.Add(f638);

            Face f639 = new Face(m05___Default);
            f639.AddVertex(-0.28914f, 3.33383f, 0.28880f);
            f639.AddVertex(-0.26348f, 3.05520f, 0.23025f);
            f639.AddVertex(-0.27389f, 3.04136f, 0.24544f);
            f639.AddVertex(-0.29994f, 3.32405f, 0.30485f);
            faces.Add(f639);

            Face f640 = new Face(m05___Default);
            f640.AddVertex(-0.27164f, 3.34102f, 0.27714f);
            f640.AddVertex(-0.24625f, 3.06536f, 0.21921f);
            f640.AddVertex(-0.26348f, 3.05520f, 0.23025f);
            f640.AddVertex(-0.28914f, 3.33383f, 0.28880f);
            faces.Add(f640);

            Face f641 = new Face(m05___Default);
            f641.AddVertex(-0.25213f, 3.34369f, 0.27297f);
            f641.AddVertex(-0.22684f, 3.06911f, 0.21527f);
            f641.AddVertex(-0.24625f, 3.06536f, 0.21921f);
            f641.AddVertex(-0.27164f, 3.34102f, 0.27714f);
            faces.Add(f641);

            Face f642 = new Face(m05___Default);
            f642.AddVertex(-0.23582f, 3.34111f, 0.27742f);
            f642.AddVertex(-0.21043f, 3.06545f, 0.21949f);
            f642.AddVertex(-0.22684f, 3.06911f, 0.21527f);
            f642.AddVertex(-0.25213f, 3.34369f, 0.27297f);
            faces.Add(f642);

            Face f643 = new Face(m05___Default);
            f643.AddVertex(-0.22709f, 3.33399f, 0.28929f);
            f643.AddVertex(-0.20143f, 3.05536f, 0.23073f);
            f643.AddVertex(-0.21043f, 3.06545f, 0.21949f);
            f643.AddVertex(-0.23582f, 3.34111f, 0.27742f);
            faces.Add(f643);

            Face f644 = new Face(m05___Default);
            f644.AddVertex(-0.22828f, 3.32424f, 0.30541f);
            f644.AddVertex(-0.20225f, 3.04154f, 0.24600f);
            f644.AddVertex(-0.20143f, 3.05536f, 0.23073f);
            f644.AddVertex(-0.22709f, 3.33399f, 0.28929f);
            faces.Add(f644);

            Face f645 = new Face(m05___Default);
            f645.AddVertex(-0.23908f, 3.31445f, 0.32144f);
            f645.AddVertex(-0.21266f, 3.02770f, 0.26118f);
            f645.AddVertex(-0.20225f, 3.04154f, 0.24600f);
            f645.AddVertex(-0.22828f, 3.32424f, 0.30541f);
            faces.Add(f645);

            Face f646 = new Face(m05___Default);
            f646.AddVertex(-0.25658f, 3.30727f, 0.33311f);
            f646.AddVertex(-0.22989f, 3.01754f, 0.27222f);
            f646.AddVertex(-0.21266f, 3.02770f, 0.26118f);
            f646.AddVertex(-0.23908f, 3.31445f, 0.32144f);
            faces.Add(f646);

            Face f647 = new Face(m05___Default);
            f647.AddVertex(-0.27610f, 3.30461f, 0.33728f);
            f647.AddVertex(-0.24931f, 3.01378f, 0.27616f);
            f647.AddVertex(-0.22989f, 3.01754f, 0.27222f);
            f647.AddVertex(-0.25658f, 3.30727f, 0.33311f);
            faces.Add(f647);

            Face f648 = new Face(m05___Default);
            f648.AddVertex(-0.30467f, 3.54377f, 0.35749f);
            f648.AddVertex(-0.29241f, 3.30718f, 0.33282f);
            f648.AddVertex(-0.27610f, 3.30461f, 0.33728f);
            f648.AddVertex(-0.28834f, 3.54080f, 0.36190f);
            faces.Add(f648);

            Face f649 = new Face(m05___Default);
            f649.AddVertex(-0.31345f, 3.55197f, 0.34573f);
            f649.AddVertex(-0.30113f, 3.31430f, 0.32096f);
            f649.AddVertex(-0.29241f, 3.30718f, 0.33282f);
            f649.AddVertex(-0.30467f, 3.54377f, 0.35749f);
            faces.Add(f649);

            Face f650 = new Face(m05___Default);
            f650.AddVertex(-0.31233f, 3.56319f, 0.32978f);
            f650.AddVertex(-0.29994f, 3.32405f, 0.30485f);
            f650.AddVertex(-0.30113f, 3.31430f, 0.32096f);
            f650.AddVertex(-0.31345f, 3.55197f, 0.34573f);
            faces.Add(f650);

            Face f651 = new Face(m05___Default);
            f651.AddVertex(-0.30162f, 3.57444f, 0.31389f);
            f651.AddVertex(-0.28914f, 3.33383f, 0.28880f);
            f651.AddVertex(-0.29994f, 3.32405f, 0.30485f);
            f651.AddVertex(-0.31233f, 3.56319f, 0.32978f);
            faces.Add(f651);

            Face f652 = new Face(m05___Default);
            f652.AddVertex(-0.28417f, 3.58270f, 0.30233f);
            f652.AddVertex(-0.27164f, 3.34102f, 0.27714f);
            f652.AddVertex(-0.28914f, 3.33383f, 0.28880f);
            f652.AddVertex(-0.30162f, 3.57444f, 0.31389f);
            faces.Add(f652);

            Face f653 = new Face(m05___Default);
            f653.AddVertex(-0.26468f, 3.58576f, 0.29821f);
            f653.AddVertex(-0.25213f, 3.34369f, 0.27297f);
            f653.AddVertex(-0.27164f, 3.34102f, 0.27714f);
            f653.AddVertex(-0.28417f, 3.58270f, 0.30233f);
            faces.Add(f653);

            Face f654 = new Face(m05___Default);
            f654.AddVertex(-0.24835f, 3.58279f, 0.30262f);
            f654.AddVertex(-0.23582f, 3.34111f, 0.27742f);
            f654.AddVertex(-0.25213f, 3.34369f, 0.27297f);
            f654.AddVertex(-0.26468f, 3.58576f, 0.29821f);
            faces.Add(f654);

            Face f655 = new Face(m05___Default);
            f655.AddVertex(-0.23957f, 3.57460f, 0.31438f);
            f655.AddVertex(-0.22709f, 3.33399f, 0.28929f);
            f655.AddVertex(-0.23582f, 3.34111f, 0.27742f);
            f655.AddVertex(-0.24835f, 3.58279f, 0.30262f);
            faces.Add(f655);

            Face f656 = new Face(m05___Default);
            f656.AddVertex(-0.24069f, 3.56337f, 0.33034f);
            f656.AddVertex(-0.22828f, 3.32424f, 0.30541f);
            f656.AddVertex(-0.22709f, 3.33399f, 0.28929f);
            f656.AddVertex(-0.23957f, 3.57460f, 0.31438f);
            faces.Add(f656);

            Face f657 = new Face(m05___Default);
            f657.AddVertex(-0.25140f, 3.55212f, 0.34622f);
            f657.AddVertex(-0.23908f, 3.31445f, 0.32144f);
            f657.AddVertex(-0.22828f, 3.32424f, 0.30541f);
            f657.AddVertex(-0.24069f, 3.56337f, 0.33034f);
            faces.Add(f657);

            Face f658 = new Face(m05___Default);
            f658.AddVertex(-0.26885f, 3.54386f, 0.35777f);
            f658.AddVertex(-0.25658f, 3.30727f, 0.33311f);
            f658.AddVertex(-0.23908f, 3.31445f, 0.32144f);
            f658.AddVertex(-0.25140f, 3.55212f, 0.34622f);
            faces.Add(f658);

            Face f659 = new Face(m05___Default);
            f659.AddVertex(-0.28834f, 3.54080f, 0.36190f);
            f659.AddVertex(-0.27610f, 3.30461f, 0.33728f);
            f659.AddVertex(-0.25658f, 3.30727f, 0.33311f);
            f659.AddVertex(-0.26885f, 3.54386f, 0.35777f);
            faces.Add(f659);

            Face f660 = new Face(m05___Default);
            f660.AddVertex(-0.32828f, 3.71542f, 0.41408f);
            f660.AddVertex(-0.30467f, 3.54377f, 0.35749f);
            f660.AddVertex(-0.28834f, 3.54080f, 0.36190f);
            f660.AddVertex(-0.31176f, 3.71103f, 0.41803f);
            faces.Add(f660);

            Face f661 = new Face(m05___Default);
            f661.AddVertex(-0.33760f, 3.72751f, 0.40361f);
            f661.AddVertex(-0.31345f, 3.55197f, 0.34573f);
            f661.AddVertex(-0.30467f, 3.54377f, 0.35749f);
            f661.AddVertex(-0.32828f, 3.71542f, 0.41408f);
            faces.Add(f661);

            Face f662 = new Face(m05___Default);
            f662.AddVertex(-0.33721f, 3.74405f, 0.38941f);
            f662.AddVertex(-0.31233f, 3.56319f, 0.32978f);
            f662.AddVertex(-0.31345f, 3.55197f, 0.34573f);
            f662.AddVertex(-0.33760f, 3.72751f, 0.40361f);
            faces.Add(f662);

            Face f663 = new Face(m05___Default);
            f663.AddVertex(-0.32723f, 3.76061f, 0.37527f);
            f663.AddVertex(-0.30162f, 3.57444f, 0.31389f);
            f663.AddVertex(-0.31233f, 3.56319f, 0.32978f);
            f663.AddVertex(-0.33721f, 3.74405f, 0.38941f);
            faces.Add(f663);

            Face f664 = new Face(m05___Default);
            f664.AddVertex(-0.31032f, 3.77276f, 0.36500f);
            f664.AddVertex(-0.28417f, 3.58270f, 0.30233f);
            f664.AddVertex(-0.30162f, 3.57444f, 0.31389f);
            f664.AddVertex(-0.32723f, 3.76061f, 0.37527f);
            faces.Add(f664);

            Face f665 = new Face(m05___Default);
            f665.AddVertex(-0.29102f, 3.77724f, 0.36135f);
            f665.AddVertex(-0.26468f, 3.58576f, 0.29821f);
            f665.AddVertex(-0.28417f, 3.58270f, 0.30233f);
            f665.AddVertex(-0.31032f, 3.77276f, 0.36500f);
            faces.Add(f665);

            Face f666 = new Face(m05___Default);
            f666.AddVertex(-0.27450f, 3.77285f, 0.36528f);
            f666.AddVertex(-0.24835f, 3.58279f, 0.30262f);
            f666.AddVertex(-0.26468f, 3.58576f, 0.29821f);
            f666.AddVertex(-0.29102f, 3.77724f, 0.36135f);
            faces.Add(f666);

            Face f667 = new Face(m05___Default);
            f667.AddVertex(-0.26518f, 3.76077f, 0.37576f);
            f667.AddVertex(-0.23957f, 3.57460f, 0.31438f);
            f667.AddVertex(-0.24835f, 3.58279f, 0.30262f);
            f667.AddVertex(-0.27450f, 3.77285f, 0.36528f);
            faces.Add(f667);

            Face f668 = new Face(m05___Default);
            f668.AddVertex(-0.26557f, 3.74423f, 0.38997f);
            f668.AddVertex(-0.24069f, 3.56337f, 0.33034f);
            f668.AddVertex(-0.23957f, 3.57460f, 0.31438f);
            f668.AddVertex(-0.26518f, 3.76077f, 0.37576f);
            faces.Add(f668);

            Face f669 = new Face(m05___Default);
            f669.AddVertex(-0.27555f, 3.72766f, 0.40410f);
            f669.AddVertex(-0.25140f, 3.55212f, 0.34622f);
            f669.AddVertex(-0.24069f, 3.56337f, 0.33034f);
            f669.AddVertex(-0.26557f, 3.74423f, 0.38997f);
            faces.Add(f669);

            Face f670 = new Face(m05___Default);
            f670.AddVertex(-0.29246f, 3.71551f, 0.41437f);
            f670.AddVertex(-0.26885f, 3.54386f, 0.35777f);
            f670.AddVertex(-0.25140f, 3.55212f, 0.34622f);
            f670.AddVertex(-0.27555f, 3.72766f, 0.40410f);
            faces.Add(f670);

            Face f671 = new Face(m05___Default);
            f671.AddVertex(-0.31176f, 3.71103f, 0.41803f);
            f671.AddVertex(-0.28834f, 3.54080f, 0.36190f);
            f671.AddVertex(-0.26885f, 3.54386f, 0.35777f);
            f671.AddVertex(-0.29246f, 3.71551f, 0.41437f);
            faces.Add(f671);

            Face f672 = new Face(m05___Default);
            f672.AddVertex(-0.37040f, 3.86885f, 0.51994f);
            f672.AddVertex(-0.32828f, 3.71542f, 0.41408f);
            f672.AddVertex(-0.31176f, 3.71103f, 0.41803f);
            f672.AddVertex(-0.35358f, 3.86337f, 0.52312f);
            faces.Add(f672);

            Face f673 = new Face(m05___Default);
            f673.AddVertex(-0.38054f, 3.88391f, 0.51151f);
            f673.AddVertex(-0.33760f, 3.72751f, 0.40361f);
            f673.AddVertex(-0.32828f, 3.71542f, 0.41408f);
            f673.AddVertex(-0.37040f, 3.86885f, 0.51994f);
            faces.Add(f673);

            Face f674 = new Face(m05___Default);
            f674.AddVertex(-0.38127f, 3.90452f, 0.50011f);
            f674.AddVertex(-0.33721f, 3.74405f, 0.38941f);
            f674.AddVertex(-0.33760f, 3.72751f, 0.40361f);
            f674.AddVertex(-0.38054f, 3.88391f, 0.51151f);
            faces.Add(f674);

            Face f675 = new Face(m05___Default);
            f675.AddVertex(-0.37240f, 3.92515f, 0.48879f);
            f675.AddVertex(-0.32723f, 3.76061f, 0.37527f);
            f675.AddVertex(-0.33721f, 3.74405f, 0.38941f);
            f675.AddVertex(-0.38127f, 3.90452f, 0.50011f);
            faces.Add(f675);

            Face f676 = new Face(m05___Default);
            f676.AddVertex(-0.35631f, 3.94027f, 0.48057f);
            f676.AddVertex(-0.31032f, 3.77276f, 0.36500f);
            f676.AddVertex(-0.32723f, 3.76061f, 0.37527f);
            f676.AddVertex(-0.37240f, 3.92515f, 0.48879f);
            faces.Add(f676);

            Face f677 = new Face(m05___Default);
            f677.AddVertex(-0.33730f, 3.94585f, 0.47766f);
            f677.AddVertex(-0.29102f, 3.77724f, 0.36135f);
            f677.AddVertex(-0.31032f, 3.77276f, 0.36500f);
            f677.AddVertex(-0.35631f, 3.94027f, 0.48057f);
            faces.Add(f677);

            Face f678 = new Face(m05___Default);
            f678.AddVertex(-0.32048f, 3.94037f, 0.48085f);
            f678.AddVertex(-0.27450f, 3.77285f, 0.36528f);
            f678.AddVertex(-0.29102f, 3.77724f, 0.36135f);
            f678.AddVertex(-0.33730f, 3.94585f, 0.47766f);
            faces.Add(f678);

            Face f679 = new Face(m05___Default);
            f679.AddVertex(-0.31034f, 3.92531f, 0.48927f);
            f679.AddVertex(-0.26518f, 3.76077f, 0.37576f);
            f679.AddVertex(-0.27450f, 3.77285f, 0.36528f);
            f679.AddVertex(-0.32048f, 3.94037f, 0.48085f);
            faces.Add(f679);

            Face f680 = new Face(m05___Default);
            f680.AddVertex(-0.30962f, 3.90470f, 0.50067f);
            f680.AddVertex(-0.26557f, 3.74423f, 0.38997f);
            f680.AddVertex(-0.26518f, 3.76077f, 0.37576f);
            f680.AddVertex(-0.31034f, 3.92531f, 0.48927f);
            faces.Add(f680);

            Face f681 = new Face(m05___Default);
            f681.AddVertex(-0.31849f, 3.88407f, 0.51201f);
            f681.AddVertex(-0.27555f, 3.72766f, 0.40410f);
            f681.AddVertex(-0.26557f, 3.74423f, 0.38997f);
            f681.AddVertex(-0.30962f, 3.90470f, 0.50067f);
            faces.Add(f681);

            Face f682 = new Face(m05___Default);
            f682.AddVertex(-0.33458f, 3.86894f, 0.52022f);
            f682.AddVertex(-0.29246f, 3.71551f, 0.41437f);
            f682.AddVertex(-0.27555f, 3.72766f, 0.40410f);
            f682.AddVertex(-0.31849f, 3.88407f, 0.51201f);
            faces.Add(f682);

            Face f683 = new Face(m05___Default);
            f683.AddVertex(-0.35358f, 3.86337f, 0.52312f);
            f683.AddVertex(-0.31176f, 3.71103f, 0.41803f);
            f683.AddVertex(-0.29246f, 3.71551f, 0.41437f);
            f683.AddVertex(-0.33458f, 3.86894f, 0.52022f);
            faces.Add(f683);

            Face f684 = new Face(m05___Default);
            f684.AddVertex(-0.48379f, 4.02792f, 0.76966f);
            f684.AddVertex(-0.37040f, 3.86885f, 0.51994f);
            f684.AddVertex(-0.35358f, 3.86337f, 0.52312f);
            f684.AddVertex(-0.45036f, 4.01681f, 0.77275f);
            faces.Add(f684);

            Face f685 = new Face(m05___Default);
            f685.AddVertex(-0.50640f, 4.05845f, 0.76175f);
            f685.AddVertex(-0.38054f, 3.88391f, 0.51151f);
            f685.AddVertex(-0.37040f, 3.86885f, 0.51994f);
            f685.AddVertex(-0.48379f, 4.02792f, 0.76966f);
            faces.Add(f685);

            Face f686 = new Face(m05___Default);
            f686.AddVertex(-0.51211f, 4.10022f, 0.75114f);
            f686.AddVertex(-0.38127f, 3.90452f, 0.50011f);
            f686.AddVertex(-0.38054f, 3.88391f, 0.51151f);
            f686.AddVertex(-0.50640f, 4.05845f, 0.76175f);
            faces.Add(f686);

            Face f687 = new Face(m05___Default);
            f687.AddVertex(-0.49941f, 4.14204f, 0.74067f);
            f687.AddVertex(-0.37240f, 3.92515f, 0.48879f);
            f687.AddVertex(-0.38127f, 3.90452f, 0.50011f);
            f687.AddVertex(-0.51211f, 4.10022f, 0.75114f);
            faces.Add(f687);

            Face f688 = new Face(m05___Default);
            f688.AddVertex(-0.47169f, 4.17270f, 0.73316f);
            f688.AddVertex(-0.35631f, 3.94027f, 0.48057f);
            f688.AddVertex(-0.37240f, 3.92515f, 0.48879f);
            f688.AddVertex(-0.49941f, 4.14204f, 0.74067f);
            faces.Add(f688);

            Face f689 = new Face(m05___Default);
            f689.AddVertex(-0.43638f, 4.18398f, 0.73061f);
            f689.AddVertex(-0.33730f, 3.94585f, 0.47766f);
            f689.AddVertex(-0.35631f, 3.94027f, 0.48057f);
            f689.AddVertex(-0.47169f, 4.17270f, 0.73316f);
            faces.Add(f689);

            Face f690 = new Face(m05___Default);
            f690.AddVertex(-0.40295f, 4.17287f, 0.73370f);
            f690.AddVertex(-0.32048f, 3.94037f, 0.48085f);
            f690.AddVertex(-0.33730f, 3.94585f, 0.47766f);
            f690.AddVertex(-0.43638f, 4.18398f, 0.73061f);
            faces.Add(f690);

            Face f691 = new Face(m05___Default);
            f691.AddVertex(-0.38034f, 4.14234f, 0.74161f);
            f691.AddVertex(-0.31034f, 3.92531f, 0.48927f);
            f691.AddVertex(-0.32048f, 3.94037f, 0.48085f);
            f691.AddVertex(-0.40295f, 4.17287f, 0.73370f);
            faces.Add(f691);

            Face f692 = new Face(m05___Default);
            f692.AddVertex(-0.37463f, 4.10057f, 0.75222f);
            f692.AddVertex(-0.30962f, 3.90470f, 0.50067f);
            f692.AddVertex(-0.31034f, 3.92531f, 0.48927f);
            f692.AddVertex(-0.38034f, 4.14234f, 0.74161f);
            faces.Add(f692);

            Face f693 = new Face(m05___Default);
            f693.AddVertex(-0.38733f, 4.05876f, 0.76268f);
            f693.AddVertex(-0.31849f, 3.88407f, 0.51201f);
            f693.AddVertex(-0.30962f, 3.90470f, 0.50067f);
            f693.AddVertex(-0.37463f, 4.10057f, 0.75222f);
            faces.Add(f693);

            Face f694 = new Face(m05___Default);
            f694.AddVertex(-0.41505f, 4.02809f, 0.77020f);
            f694.AddVertex(-0.33458f, 3.86894f, 0.52022f);
            f694.AddVertex(-0.31849f, 3.88407f, 0.51201f);
            f694.AddVertex(-0.38733f, 4.05876f, 0.76268f);
            faces.Add(f694);

            Face f695 = new Face(m05___Default);
            f695.AddVertex(-0.45036f, 4.01681f, 0.77275f);
            f695.AddVertex(-0.35358f, 3.86337f, 0.52312f);
            f695.AddVertex(-0.33458f, 3.86894f, 0.52022f);
            f695.AddVertex(-0.41505f, 4.02809f, 0.77020f);
            faces.Add(f695);

            Face f696 = new Face(m05___Default);
            f696.AddVertex(-0.11736f, 0.91943f, 0.07823f);
            f696.AddVertex(-0.13496f, 0.91853f, 0.08998f);
            f696.AddVertex(-0.15452f, 0.91816f, 0.09417f);
            f696.AddVertex(-0.10642f, 0.92063f, 0.06208f);
            faces.Add(f696);

            Face f697 = new Face(m05___Default);
            f697.AddVertex(-0.10507f, 0.92181f, 0.04585f);
            f697.AddVertex(-0.10642f, 0.92063f, 0.06208f);
            f697.AddVertex(-0.15452f, 0.91816f, 0.09417f);
            f697.AddVertex(-0.11369f, 0.92264f, 0.03390f);
            faces.Add(f697);

            Face f698 = new Face(m05___Default);
            f698.AddVertex(-0.12996f, 0.92291f, 0.02942f);
            f698.AddVertex(-0.11369f, 0.92264f, 0.03390f);
            f698.AddVertex(-0.15452f, 0.91816f, 0.09417f);
            f698.AddVertex(-0.14952f, 0.92255f, 0.03361f);
            faces.Add(f698);

            Face f699 = new Face(m05___Default);
            f699.AddVertex(-0.16713f, 0.92165f, 0.04536f);
            f699.AddVertex(-0.14952f, 0.92255f, 0.03361f);
            f699.AddVertex(-0.15452f, 0.91816f, 0.09417f);
            f699.AddVertex(-0.17806f, 0.92044f, 0.06151f);
            faces.Add(f699);

            Face f700 = new Face(m05___Default);
            f700.AddVertex(-0.17941f, 0.91927f, 0.07774f);
            f700.AddVertex(-0.17806f, 0.92044f, 0.06151f);
            f700.AddVertex(-0.15452f, 0.91816f, 0.09417f);
            f700.AddVertex(-0.17079f, 0.91844f, 0.08969f);
            faces.Add(f700);

            Face f701 = new Face(m05___Default);
            f701.AddVertex(-0.35443f, 1.82266f, -0.18247f);
            f701.AddVertex(-0.32625f, 1.44577f, -0.09374f);
            f701.AddVertex(-0.25644f, 1.44681f, -0.12795f);
            f701.AddVertex(-0.22520f, 1.82458f, -0.24581f);
            faces.Add(f701);

            Face f702 = new Face(m05___Default);
            f702.AddVertex(-0.36436f, 1.81637f, -0.20578f);
            f702.AddVertex(-0.33161f, 1.44238f, -0.10632f);
            f702.AddVertex(-0.40141f, 1.44134f, -0.07211f);
            f702.AddVertex(-0.49359f, 1.81446f, -0.14244f);
            faces.Add(f702);

            Face f703 = new Face(m05___Default);
            f703.AddVertex(-0.30357f, 1.00992f, -0.01476f);
            f703.AddVertex(-0.32782f, 1.00620f, -0.00530f);
            f703.AddVertex(-0.30539f, 1.00317f, -0.01873f);
            f703.AddVertex(-0.28114f, 1.00689f, -0.02818f);
            faces.Add(f703);

            Face f704 = new Face(m05___Default);
            f704.AddVertex(-0.61787f, 1.81569f, -0.06745f);
            f704.AddVertex(-0.46854f, 1.44201f, -0.03161f);
            f704.AddVertex(-0.46720f, 1.44286f, -0.02846f);
            f704.AddVertex(-0.61539f, 1.81726f, -0.06163f);
            faces.Add(f704);

            Face f705 = new Face(m05___Default);
            f705.AddVertex(-0.65526f, 2.61187f, -0.94489f);
            f705.AddVertex(-0.60863f, 2.60949f, -0.98182f);
            f705.AddVertex(-0.66518f, 2.60559f, -0.96819f);
            f705.AddVertex(-0.71181f, 2.60796f, -0.93126f);
            faces.Add(f705);

            Face f706 = new Face(m05___Default);
            f706.AddVertex(-0.10092f, 1.82335f, -0.32080f);
            f706.AddVertex(-0.19287f, 2.19285f, -0.56115f);
            f706.AddVertex(-0.19038f, 2.19442f, -0.55533f);
            f706.AddVertex(-0.09844f, 1.82492f, -0.31497f);
            faces.Add(f706);

            Face f707 = new Face(m05___Default);
            f707.AddVertex(-0.62946f, 2.61226f, -0.95753f);
            f707.AddVertex(-0.65526f, 2.61187f, -0.94489f);
            f707.AddVertex(-0.44638f, 2.19216f, -0.42283f);
            f707.AddVertex(-0.31714f, 2.19408f, -0.48617f);
            faces.Add(f707);

            Face f708 = new Face(m05___Default);
            f708.AddVertex(-0.44638f, 2.19216f, -0.42283f);
            f708.AddVertex(-0.35443f, 1.82266f, -0.18247f);
            f708.AddVertex(-0.22520f, 1.82458f, -0.24581f);
            f708.AddVertex(-0.31714f, 2.19408f, -0.48617f);
            faces.Add(f708);

            Face f709 = new Face(m05___Default);
            f709.AddVertex(-0.31524f, 1.00974f, -0.00904f);
            f709.AddVertex(-0.30357f, 1.00992f, -0.01476f);
            f709.AddVertex(-0.32625f, 1.44577f, -0.09374f);
            f709.AddVertex(-0.39605f, 1.44474f, -0.05952f);
            faces.Add(f709);

            Face f710 = new Face(m05___Default);
            f710.AddVertex(-0.69098f, 2.60520f, -0.95555f);
            f710.AddVertex(-0.66518f, 2.60559f, -0.96819f);
            f710.AddVertex(-0.45630f, 2.18588f, -0.44614f);
            f710.AddVertex(-0.58554f, 2.18396f, -0.38280f);
            faces.Add(f710);

            Face f711 = new Face(m05___Default);
            f711.AddVertex(-0.45630f, 2.18588f, -0.44614f);
            f711.AddVertex(-0.36436f, 1.81637f, -0.20578f);
            f711.AddVertex(-0.49359f, 1.81446f, -0.14244f);
            f711.AddVertex(-0.58554f, 2.18396f, -0.38280f);
            faces.Add(f711);

            Face f712 = new Face(m05___Default);
            f712.AddVertex(-0.29372f, 1.00334f, -0.02444f);
            f712.AddVertex(-0.30539f, 1.00317f, -0.01873f);
            f712.AddVertex(-0.33161f, 1.44238f, -0.10632f);
            f712.AddVertex(-0.26180f, 1.44341f, -0.14053f);
            faces.Add(f712);

            Face f713 = new Face(m05___Default);
            f713.AddVertex(-0.71181f, 2.60796f, -0.93126f);
            f713.AddVertex(-0.70981f, 2.18519f, -0.30781f);
            f713.AddVertex(-0.70733f, 2.18676f, -0.30198f);
            f713.AddVertex(-0.70933f, 2.60954f, -0.92543f);
            faces.Add(f713);

            Face f714 = new Face(m05___Default);
            f714.AddVertex(-0.70981f, 2.18519f, -0.30781f);
            f714.AddVertex(-0.61787f, 1.81569f, -0.06745f);
            f714.AddVertex(-0.61539f, 1.81726f, -0.06163f);
            f714.AddVertex(-0.70733f, 2.18676f, -0.30198f);
            faces.Add(f714);

            Face f715 = new Face(m05___Default);
            f715.AddVertex(-0.32782f, 1.00620f, -0.00530f);
            f715.AddVertex(-0.46854f, 1.44201f, -0.03161f);
            f715.AddVertex(-0.46988f, 1.44116f, -0.03476f);
            f715.AddVertex(-0.32828f, 1.00451f, -0.00629f);
            faces.Add(f715);

            Face f716 = new Face(m05___Default);
            f716.AddVertex(-0.28114f, 1.00689f, -0.02818f);
            f716.AddVertex(-0.18932f, 1.44614f, -0.16845f);
            f716.AddVertex(-0.18798f, 1.44699f, -0.16530f);
            f716.AddVertex(-0.28068f, 1.00858f, -0.02719f);
            faces.Add(f716);

            Face f717 = new Face(m05___Default);
            f717.AddVertex(-0.18932f, 1.44614f, -0.16845f);
            f717.AddVertex(-0.10092f, 1.82335f, -0.32080f);
            f717.AddVertex(-0.09844f, 1.82492f, -0.31497f);
            f717.AddVertex(-0.18798f, 1.44699f, -0.16530f);
            faces.Add(f717);

            Face f718 = new Face(m05___Default);
            f718.AddVertex(-0.60863f, 2.60949f, -0.98182f);
            f718.AddVertex(-0.19287f, 2.19285f, -0.56115f);
            f718.AddVertex(-0.19535f, 2.19128f, -0.56698f);
            f718.AddVertex(-0.61111f, 2.60792f, -0.98765f);
            faces.Add(f718);

            Face f719 = new Face(m05___Default);
            f719.AddVertex(-0.61290f, 1.81883f, -0.05580f);
            f719.AddVertex(-0.46585f, 1.44371f, -0.02531f);
            f719.AddVertex(-0.39605f, 1.44474f, -0.05952f);
            f719.AddVertex(-0.48367f, 1.82075f, -0.11914f);
            faces.Add(f719);

            Face f720 = new Face(m05___Default);
            f720.AddVertex(-0.48367f, 1.82075f, -0.11914f);
            f720.AddVertex(-0.39605f, 1.44474f, -0.05952f);
            f720.AddVertex(-0.32625f, 1.44577f, -0.09374f);
            f720.AddVertex(-0.35443f, 1.82266f, -0.18247f);
            faces.Add(f720);

            Face f721 = new Face(m05___Default);
            f721.AddVertex(-0.18664f, 1.44784f, -0.16215f);
            f721.AddVertex(-0.09596f, 1.82649f, -0.30915f);
            f721.AddVertex(-0.22520f, 1.82458f, -0.24581f);
            f721.AddVertex(-0.25644f, 1.44681f, -0.12795f);
            faces.Add(f721);

            Face f722 = new Face(m05___Default);
            f722.AddVertex(-0.10588f, 1.82020f, -0.33245f);
            f722.AddVertex(-0.19200f, 1.44444f, -0.17474f);
            f722.AddVertex(-0.26180f, 1.44341f, -0.14053f);
            f722.AddVertex(-0.23512f, 1.81829f, -0.26912f);
            faces.Add(f722);

            Face f723 = new Face(m05___Default);
            f723.AddVertex(-0.23512f, 1.81829f, -0.26912f);
            f723.AddVertex(-0.26180f, 1.44341f, -0.14053f);
            f723.AddVertex(-0.33161f, 1.44238f, -0.10632f);
            f723.AddVertex(-0.36436f, 1.81637f, -0.20578f);
            faces.Add(f723);

            Face f724 = new Face(m05___Default);
            f724.AddVertex(-0.47121f, 1.44031f, -0.03790f);
            f724.AddVertex(-0.62283f, 1.81254f, -0.07910f);
            f724.AddVertex(-0.49359f, 1.81446f, -0.14244f);
            f724.AddVertex(-0.40141f, 1.44134f, -0.07211f);
            faces.Add(f724);

            Face f725 = new Face(m05___Default);
            f725.AddVertex(-0.29372f, 1.00334f, -0.02444f);
            f725.AddVertex(-0.28205f, 1.00352f, -0.03016f);
            f725.AddVertex(-0.28160f, 1.00520f, -0.02917f);
            faces.Add(f725);

            Face f726 = new Face(m05___Default);
            f726.AddVertex(-0.29372f, 1.00334f, -0.02444f);
            f726.AddVertex(-0.28160f, 1.00520f, -0.02917f);
            f726.AddVertex(-0.28114f, 1.00689f, -0.02818f);
            f726.AddVertex(-0.30539f, 1.00317f, -0.01873f);
            faces.Add(f726);

            Face f727 = new Face(m05___Default);
            f727.AddVertex(-0.32828f, 1.00451f, -0.00629f);
            f727.AddVertex(-0.32874f, 1.00283f, -0.00728f);
            f727.AddVertex(-0.31707f, 1.00300f, -0.01300f);
            faces.Add(f727);

            Face f728 = new Face(m05___Default);
            f728.AddVertex(-0.32782f, 1.00620f, -0.00530f);
            f728.AddVertex(-0.32828f, 1.00451f, -0.00629f);
            f728.AddVertex(-0.31707f, 1.00300f, -0.01300f);
            f728.AddVertex(-0.30539f, 1.00317f, -0.01873f);
            faces.Add(f728);

            Face f729 = new Face(m05___Default);
            f729.AddVertex(-0.31524f, 1.00974f, -0.00904f);
            f729.AddVertex(-0.32692f, 1.00957f, -0.00332f);
            f729.AddVertex(-0.32737f, 1.00788f, -0.00431f);
            faces.Add(f729);

            Face f730 = new Face(m05___Default);
            f730.AddVertex(-0.31524f, 1.00974f, -0.00904f);
            f730.AddVertex(-0.32737f, 1.00788f, -0.00431f);
            f730.AddVertex(-0.32782f, 1.00620f, -0.00530f);
            f730.AddVertex(-0.30357f, 1.00992f, -0.01476f);
            faces.Add(f730);

            Face f731 = new Face(m05___Default);
            f731.AddVertex(-0.28068f, 1.00858f, -0.02719f);
            f731.AddVertex(-0.28023f, 1.01026f, -0.02620f);
            f731.AddVertex(-0.29190f, 1.01009f, -0.02048f);
            faces.Add(f731);

            Face f732 = new Face(m05___Default);
            f732.AddVertex(-0.28114f, 1.00689f, -0.02818f);
            f732.AddVertex(-0.28068f, 1.00858f, -0.02719f);
            f732.AddVertex(-0.29190f, 1.01009f, -0.02048f);
            f732.AddVertex(-0.30357f, 1.00992f, -0.01476f);
            faces.Add(f732);

            Face f733 = new Face(m05___Default);
            f733.AddVertex(-0.62283f, 1.81254f, -0.07910f);
            f733.AddVertex(-0.47121f, 1.44031f, -0.03790f);
            f733.AddVertex(-0.46988f, 1.44116f, -0.03476f);
            f733.AddVertex(-0.62035f, 1.81412f, -0.07328f);
            faces.Add(f733);

            Face f734 = new Face(m05___Default);
            f734.AddVertex(-0.62035f, 1.81412f, -0.07328f);
            f734.AddVertex(-0.46988f, 1.44116f, -0.03476f);
            f734.AddVertex(-0.46854f, 1.44201f, -0.03161f);
            f734.AddVertex(-0.61787f, 1.81569f, -0.06745f);
            faces.Add(f734);

            Face f735 = new Face(m05___Default);
            f735.AddVertex(-0.46585f, 1.44371f, -0.02531f);
            f735.AddVertex(-0.61290f, 1.81883f, -0.05580f);
            f735.AddVertex(-0.61539f, 1.81726f, -0.06163f);
            f735.AddVertex(-0.46720f, 1.44286f, -0.02846f);
            faces.Add(f735);

            Face f736 = new Face(m05___Default);
            f736.AddVertex(-0.69098f, 2.60520f, -0.95555f);
            f736.AddVertex(-0.71677f, 2.60482f, -0.94291f);
            f736.AddVertex(-0.71429f, 2.60639f, -0.93708f);
            faces.Add(f736);

            Face f737 = new Face(m05___Default);
            f737.AddVertex(-0.69098f, 2.60520f, -0.95555f);
            f737.AddVertex(-0.71429f, 2.60639f, -0.93708f);
            f737.AddVertex(-0.71181f, 2.60796f, -0.93126f);
            f737.AddVertex(-0.66518f, 2.60559f, -0.96819f);
            faces.Add(f737);

            Face f738 = new Face(m05___Default);
            f738.AddVertex(-0.61111f, 2.60792f, -0.98765f);
            f738.AddVertex(-0.61359f, 2.60635f, -0.99347f);
            f738.AddVertex(-0.63938f, 2.60596f, -0.98083f);
            faces.Add(f738);

            Face f739 = new Face(m05___Default);
            f739.AddVertex(-0.60863f, 2.60949f, -0.98182f);
            f739.AddVertex(-0.61111f, 2.60792f, -0.98765f);
            f739.AddVertex(-0.63938f, 2.60596f, -0.98083f);
            f739.AddVertex(-0.66518f, 2.60559f, -0.96819f);
            faces.Add(f739);

            Face f740 = new Face(m05___Default);
            f740.AddVertex(-0.62946f, 2.61226f, -0.95753f);
            f740.AddVertex(-0.60366f, 2.61264f, -0.97017f);
            f740.AddVertex(-0.60615f, 2.61107f, -0.97600f);
            faces.Add(f740);

            Face f741 = new Face(m05___Default);
            f741.AddVertex(-0.62946f, 2.61226f, -0.95753f);
            f741.AddVertex(-0.60615f, 2.61107f, -0.97600f);
            f741.AddVertex(-0.60863f, 2.60949f, -0.98182f);
            f741.AddVertex(-0.65526f, 2.61187f, -0.94489f);
            faces.Add(f741);

            Face f742 = new Face(m05___Default);
            f742.AddVertex(-0.70933f, 2.60954f, -0.92543f);
            f742.AddVertex(-0.70685f, 2.61111f, -0.91960f);
            f742.AddVertex(-0.68105f, 2.61149f, -0.93224f);
            faces.Add(f742);

            Face f743 = new Face(m05___Default);
            f743.AddVertex(-0.71181f, 2.60796f, -0.93126f);
            f743.AddVertex(-0.70933f, 2.60954f, -0.92543f);
            f743.AddVertex(-0.68105f, 2.61149f, -0.93224f);
            f743.AddVertex(-0.65526f, 2.61187f, -0.94489f);
            faces.Add(f743);

            Face f744 = new Face(m05___Default);
            f744.AddVertex(-0.10588f, 1.82020f, -0.33245f);
            f744.AddVertex(-0.19783f, 2.18971f, -0.57281f);
            f744.AddVertex(-0.19535f, 2.19128f, -0.56698f);
            f744.AddVertex(-0.10340f, 1.82178f, -0.32663f);
            faces.Add(f744);

            Face f745 = new Face(m05___Default);
            f745.AddVertex(-0.10340f, 1.82178f, -0.32663f);
            f745.AddVertex(-0.19535f, 2.19128f, -0.56698f);
            f745.AddVertex(-0.19287f, 2.19285f, -0.56115f);
            f745.AddVertex(-0.10092f, 1.82335f, -0.32080f);
            faces.Add(f745);

            Face f746 = new Face(m05___Default);
            f746.AddVertex(-0.18790f, 2.19600f, -0.54950f);
            f746.AddVertex(-0.09596f, 1.82649f, -0.30915f);
            f746.AddVertex(-0.09844f, 1.82492f, -0.31497f);
            f746.AddVertex(-0.19038f, 2.19442f, -0.55533f);
            faces.Add(f746);

            Face f747 = new Face(m05___Default);
            f747.AddVertex(-0.70685f, 2.61111f, -0.91960f);
            f747.AddVertex(-0.70485f, 2.18833f, -0.29615f);
            f747.AddVertex(-0.57562f, 2.19025f, -0.35949f);
            f747.AddVertex(-0.68105f, 2.61149f, -0.93224f);
            faces.Add(f747);

            Face f748 = new Face(m05___Default);
            f748.AddVertex(-0.68105f, 2.61149f, -0.93224f);
            f748.AddVertex(-0.57562f, 2.19025f, -0.35949f);
            f748.AddVertex(-0.44638f, 2.19216f, -0.42283f);
            f748.AddVertex(-0.65526f, 2.61187f, -0.94489f);
            faces.Add(f748);

            Face f749 = new Face(m05___Default);
            f749.AddVertex(-0.31714f, 2.19408f, -0.48617f);
            f749.AddVertex(-0.18790f, 2.19600f, -0.54950f);
            f749.AddVertex(-0.60366f, 2.61264f, -0.97017f);
            f749.AddVertex(-0.62946f, 2.61226f, -0.95753f);
            faces.Add(f749);

            Face f750 = new Face(m05___Default);
            f750.AddVertex(-0.70485f, 2.18833f, -0.29615f);
            f750.AddVertex(-0.61290f, 1.81883f, -0.05580f);
            f750.AddVertex(-0.48367f, 1.82075f, -0.11914f);
            f750.AddVertex(-0.57562f, 2.19025f, -0.35949f);
            faces.Add(f750);

            Face f751 = new Face(m05___Default);
            f751.AddVertex(-0.57562f, 2.19025f, -0.35949f);
            f751.AddVertex(-0.48367f, 1.82075f, -0.11914f);
            f751.AddVertex(-0.35443f, 1.82266f, -0.18247f);
            f751.AddVertex(-0.44638f, 2.19216f, -0.42283f);
            faces.Add(f751);

            Face f752 = new Face(m05___Default);
            f752.AddVertex(-0.09596f, 1.82649f, -0.30915f);
            f752.AddVertex(-0.18790f, 2.19600f, -0.54950f);
            f752.AddVertex(-0.31714f, 2.19408f, -0.48617f);
            f752.AddVertex(-0.22520f, 1.82458f, -0.24581f);
            faces.Add(f752);

            Face f753 = new Face(m05___Default);
            f753.AddVertex(-0.28023f, 1.01026f, -0.02620f);
            f753.AddVertex(-0.18664f, 1.44784f, -0.16215f);
            f753.AddVertex(-0.25644f, 1.44681f, -0.12795f);
            f753.AddVertex(-0.29190f, 1.01009f, -0.02048f);
            faces.Add(f753);

            Face f754 = new Face(m05___Default);
            f754.AddVertex(-0.29190f, 1.01009f, -0.02048f);
            f754.AddVertex(-0.25644f, 1.44681f, -0.12795f);
            f754.AddVertex(-0.32625f, 1.44577f, -0.09374f);
            f754.AddVertex(-0.30357f, 1.00992f, -0.01476f);
            faces.Add(f754);

            Face f755 = new Face(m05___Default);
            f755.AddVertex(-0.39605f, 1.44474f, -0.05952f);
            f755.AddVertex(-0.46585f, 1.44371f, -0.02531f);
            f755.AddVertex(-0.32692f, 1.00957f, -0.00332f);
            f755.AddVertex(-0.31524f, 1.00974f, -0.00904f);
            faces.Add(f755);

            Face f756 = new Face(m05___Default);
            f756.AddVertex(-0.61359f, 2.60635f, -0.99347f);
            f756.AddVertex(-0.19783f, 2.18971f, -0.57281f);
            f756.AddVertex(-0.32707f, 2.18779f, -0.50947f);
            f756.AddVertex(-0.63938f, 2.60596f, -0.98083f);
            faces.Add(f756);

            Face f757 = new Face(m05___Default);
            f757.AddVertex(-0.63938f, 2.60596f, -0.98083f);
            f757.AddVertex(-0.32707f, 2.18779f, -0.50947f);
            f757.AddVertex(-0.45630f, 2.18588f, -0.44614f);
            f757.AddVertex(-0.66518f, 2.60559f, -0.96819f);
            faces.Add(f757);

            Face f758 = new Face(m05___Default);
            f758.AddVertex(-0.58554f, 2.18396f, -0.38280f);
            f758.AddVertex(-0.71477f, 2.18205f, -0.31946f);
            f758.AddVertex(-0.71677f, 2.60482f, -0.94291f);
            f758.AddVertex(-0.69098f, 2.60520f, -0.95555f);
            faces.Add(f758);

            Face f759 = new Face(m05___Default);
            f759.AddVertex(-0.19783f, 2.18971f, -0.57281f);
            f759.AddVertex(-0.10588f, 1.82020f, -0.33245f);
            f759.AddVertex(-0.23512f, 1.81829f, -0.26912f);
            f759.AddVertex(-0.32707f, 2.18779f, -0.50947f);
            faces.Add(f759);

            Face f760 = new Face(m05___Default);
            f760.AddVertex(-0.32707f, 2.18779f, -0.50947f);
            f760.AddVertex(-0.23512f, 1.81829f, -0.26912f);
            f760.AddVertex(-0.36436f, 1.81637f, -0.20578f);
            f760.AddVertex(-0.45630f, 2.18588f, -0.44614f);
            faces.Add(f760);

            Face f761 = new Face(m05___Default);
            f761.AddVertex(-0.62283f, 1.81254f, -0.07910f);
            f761.AddVertex(-0.71477f, 2.18205f, -0.31946f);
            f761.AddVertex(-0.58554f, 2.18396f, -0.38280f);
            f761.AddVertex(-0.49359f, 1.81446f, -0.14244f);
            faces.Add(f761);

            Face f762 = new Face(m05___Default);
            f762.AddVertex(-0.32874f, 1.00283f, -0.00728f);
            f762.AddVertex(-0.47121f, 1.44031f, -0.03790f);
            f762.AddVertex(-0.40141f, 1.44134f, -0.07211f);
            f762.AddVertex(-0.31707f, 1.00300f, -0.01300f);
            faces.Add(f762);

            Face f763 = new Face(m05___Default);
            f763.AddVertex(-0.31707f, 1.00300f, -0.01300f);
            f763.AddVertex(-0.40141f, 1.44134f, -0.07211f);
            f763.AddVertex(-0.33161f, 1.44238f, -0.10632f);
            f763.AddVertex(-0.30539f, 1.00317f, -0.01873f);
            faces.Add(f763);

            Face f764 = new Face(m05___Default);
            f764.AddVertex(-0.26180f, 1.44341f, -0.14053f);
            f764.AddVertex(-0.19200f, 1.44444f, -0.17474f);
            f764.AddVertex(-0.28205f, 1.00352f, -0.03016f);
            f764.AddVertex(-0.29372f, 1.00334f, -0.02444f);
            faces.Add(f764);

            Face f765 = new Face(m05___Default);
            f765.AddVertex(-0.71677f, 2.60482f, -0.94291f);
            f765.AddVertex(-0.71477f, 2.18205f, -0.31946f);
            f765.AddVertex(-0.71229f, 2.18361f, -0.31363f);
            f765.AddVertex(-0.71429f, 2.60639f, -0.93708f);
            faces.Add(f765);

            Face f766 = new Face(m05___Default);
            f766.AddVertex(-0.71429f, 2.60639f, -0.93708f);
            f766.AddVertex(-0.71229f, 2.18361f, -0.31363f);
            f766.AddVertex(-0.70981f, 2.18519f, -0.30781f);
            f766.AddVertex(-0.71181f, 2.60796f, -0.93126f);
            faces.Add(f766);

            Face f767 = new Face(m05___Default);
            f767.AddVertex(-0.70485f, 2.18833f, -0.29615f);
            f767.AddVertex(-0.70685f, 2.61111f, -0.91960f);
            f767.AddVertex(-0.70933f, 2.60954f, -0.92543f);
            f767.AddVertex(-0.70733f, 2.18676f, -0.30198f);
            faces.Add(f767);

            Face f768 = new Face(m05___Default);
            f768.AddVertex(-0.71477f, 2.18205f, -0.31946f);
            f768.AddVertex(-0.62283f, 1.81254f, -0.07910f);
            f768.AddVertex(-0.62035f, 1.81412f, -0.07328f);
            f768.AddVertex(-0.71229f, 2.18361f, -0.31363f);
            faces.Add(f768);

            Face f769 = new Face(m05___Default);
            f769.AddVertex(-0.71229f, 2.18361f, -0.31363f);
            f769.AddVertex(-0.62035f, 1.81412f, -0.07328f);
            f769.AddVertex(-0.61787f, 1.81569f, -0.06745f);
            f769.AddVertex(-0.70981f, 2.18519f, -0.30781f);
            faces.Add(f769);

            Face f770 = new Face(m05___Default);
            f770.AddVertex(-0.61290f, 1.81883f, -0.05580f);
            f770.AddVertex(-0.70485f, 2.18833f, -0.29615f);
            f770.AddVertex(-0.70733f, 2.18676f, -0.30198f);
            f770.AddVertex(-0.61539f, 1.81726f, -0.06163f);
            faces.Add(f770);

            Face f771 = new Face(m05___Default);
            f771.AddVertex(-0.32692f, 1.00957f, -0.00332f);
            f771.AddVertex(-0.46585f, 1.44371f, -0.02531f);
            f771.AddVertex(-0.46720f, 1.44286f, -0.02846f);
            f771.AddVertex(-0.32737f, 1.00788f, -0.00431f);
            faces.Add(f771);

            Face f772 = new Face(m05___Default);
            f772.AddVertex(-0.32737f, 1.00788f, -0.00431f);
            f772.AddVertex(-0.46720f, 1.44286f, -0.02846f);
            f772.AddVertex(-0.46854f, 1.44201f, -0.03161f);
            f772.AddVertex(-0.32782f, 1.00620f, -0.00530f);
            faces.Add(f772);

            Face f773 = new Face(m05___Default);
            f773.AddVertex(-0.47121f, 1.44031f, -0.03790f);
            f773.AddVertex(-0.32874f, 1.00283f, -0.00728f);
            f773.AddVertex(-0.32828f, 1.00451f, -0.00629f);
            f773.AddVertex(-0.46988f, 1.44116f, -0.03476f);
            faces.Add(f773);

            Face f774 = new Face(m05___Default);
            f774.AddVertex(-0.28205f, 1.00352f, -0.03016f);
            f774.AddVertex(-0.19200f, 1.44444f, -0.17474f);
            f774.AddVertex(-0.19066f, 1.44529f, -0.17160f);
            f774.AddVertex(-0.28160f, 1.00520f, -0.02917f);
            faces.Add(f774);

            Face f775 = new Face(m05___Default);
            f775.AddVertex(-0.28160f, 1.00520f, -0.02917f);
            f775.AddVertex(-0.19066f, 1.44529f, -0.17160f);
            f775.AddVertex(-0.18932f, 1.44614f, -0.16845f);
            f775.AddVertex(-0.28114f, 1.00689f, -0.02818f);
            faces.Add(f775);

            Face f776 = new Face(m05___Default);
            f776.AddVertex(-0.18664f, 1.44784f, -0.16215f);
            f776.AddVertex(-0.28023f, 1.01026f, -0.02620f);
            f776.AddVertex(-0.28068f, 1.00858f, -0.02719f);
            f776.AddVertex(-0.18798f, 1.44699f, -0.16530f);
            faces.Add(f776);

            Face f777 = new Face(m05___Default);
            f777.AddVertex(-0.19200f, 1.44444f, -0.17474f);
            f777.AddVertex(-0.10588f, 1.82020f, -0.33245f);
            f777.AddVertex(-0.10340f, 1.82178f, -0.32663f);
            f777.AddVertex(-0.19066f, 1.44529f, -0.17160f);
            faces.Add(f777);

            Face f778 = new Face(m05___Default);
            f778.AddVertex(-0.19066f, 1.44529f, -0.17160f);
            f778.AddVertex(-0.10340f, 1.82178f, -0.32663f);
            f778.AddVertex(-0.10092f, 1.82335f, -0.32080f);
            f778.AddVertex(-0.18932f, 1.44614f, -0.16845f);
            faces.Add(f778);

            Face f779 = new Face(m05___Default);
            f779.AddVertex(-0.09596f, 1.82649f, -0.30915f);
            f779.AddVertex(-0.18664f, 1.44784f, -0.16215f);
            f779.AddVertex(-0.18798f, 1.44699f, -0.16530f);
            f779.AddVertex(-0.09844f, 1.82492f, -0.31497f);
            faces.Add(f779);

            Face f780 = new Face(m05___Default);
            f780.AddVertex(-0.60366f, 2.61264f, -0.97017f);
            f780.AddVertex(-0.18790f, 2.19600f, -0.54950f);
            f780.AddVertex(-0.19038f, 2.19442f, -0.55533f);
            f780.AddVertex(-0.60615f, 2.61107f, -0.97600f);
            faces.Add(f780);

            Face f781 = new Face(m05___Default);
            f781.AddVertex(-0.60615f, 2.61107f, -0.97600f);
            f781.AddVertex(-0.19038f, 2.19442f, -0.55533f);
            f781.AddVertex(-0.19287f, 2.19285f, -0.56115f);
            f781.AddVertex(-0.60863f, 2.60949f, -0.98182f);
            faces.Add(f781);

            Face f782 = new Face(m05___Default);
            f782.AddVertex(-0.19783f, 2.18971f, -0.57281f);
            f782.AddVertex(-0.61359f, 2.60635f, -0.99347f);
            f782.AddVertex(-0.61111f, 2.60792f, -0.98765f);
            f782.AddVertex(-0.19535f, 2.19128f, -0.56698f);
            faces.Add(f782);

            Face f783 = new Face(m05___Default);
            f783.AddVertex(-0.40098f, 1.81327f, 0.19257f);
            f783.AddVertex(-0.28612f, 1.43988f, 0.17593f);
            f783.AddVertex(-0.30334f, 1.44165f, 0.10215f);
            f783.AddVertex(-0.42453f, 1.81570f, 0.09166f);
            faces.Add(f783);

            Face f784 = new Face(m05___Default);
            f784.AddVertex(-0.44090f, 1.80561f, 0.22173f);
            f784.AddVertex(-0.31532f, 1.43427f, 0.19725f);
            f784.AddVertex(-0.29810f, 1.43250f, 0.27103f);
            f784.AddVertex(-0.41735f, 1.80318f, 0.32264f);
            faces.Add(f784);

            Face f785 = new Face(m05___Default);
            f785.AddVertex(-0.18586f, 1.00513f, 0.12887f);
            f785.AddVertex(-0.18393f, 1.00173f, 0.19150f);
            f785.AddVertex(-0.20754f, 1.00096f, 0.14471f);
            f785.AddVertex(-0.20947f, 1.00436f, 0.08208f);
            faces.Add(f785);

            Face f786 = new Face(m05___Default);
            f786.AddVertex(-0.37384f, 1.80459f, 0.40897f);
            f786.AddVertex(-0.26628f, 1.43352f, 0.33415f);
            f786.AddVertex(-0.25898f, 1.43493f, 0.32882f);
            f786.AddVertex(-0.36385f, 1.80650f, 0.40168f);
            faces.Add(f786);

            Face f787 = new Face(m05___Default);
            f787.AddVertex(-1.55949f, 2.57147f, 0.59165f);
            f787.AddVertex(-1.58886f, 2.56861f, 0.56594f);
            f787.AddVertex(-1.59943f, 2.56381f, 0.62080f);
            f787.AddVertex(-1.57006f, 2.56667f, 0.64651f);
            faces.Add(f787);

            Face f788 = new Face(m05___Default);
            f788.AddVertex(-0.46805f, 1.81430f, 0.00533f);
            f788.AddVertex(-0.82184f, 2.17461f, 0.10808f);
            f788.AddVertex(-0.81186f, 2.17653f, 0.10078f);
            f788.AddVertex(-0.45806f, 1.81622f, -0.00195f);
            faces.Add(f788);

            Face f789 = new Face(m05___Default);
            f789.AddVertex(-1.56419f, 2.57196f, 0.57150f);
            f789.AddVertex(-1.55949f, 2.57147f, 0.59165f);
            f789.AddVertex(-0.75477f, 2.17359f, 0.29532f);
            f789.AddVertex(-0.77832f, 2.17602f, 0.19440f);
            faces.Add(f789);

            Face f790 = new Face(m05___Default);
            f790.AddVertex(-0.75477f, 2.17359f, 0.29532f);
            f790.AddVertex(-0.40098f, 1.81327f, 0.19257f);
            f790.AddVertex(-0.42453f, 1.81570f, 0.09166f);
            f790.AddVertex(-0.77832f, 2.17602f, 0.19440f);
            faces.Add(f790);

            Face f791 = new Face(m05___Default);
            f791.AddVertex(-0.17948f, 1.00447f, 0.15623f);
            f791.AddVertex(-0.18586f, 1.00513f, 0.12887f);
            f791.AddVertex(-0.28612f, 1.43988f, 0.17593f);
            f791.AddVertex(-0.26890f, 1.43810f, 0.24971f);
            faces.Add(f791);

            Face f792 = new Face(m05___Default);
            f792.AddVertex(-1.59472f, 2.56332f, 0.64095f);
            f792.AddVertex(-1.59943f, 2.56381f, 0.62080f);
            f792.AddVertex(-0.79470f, 2.16593f, 0.32447f);
            f792.AddVertex(-0.77114f, 2.16350f, 0.42538f);
            faces.Add(f792);

            Face f793 = new Face(m05___Default);
            f793.AddVertex(-0.79470f, 2.16593f, 0.32447f);
            f793.AddVertex(-0.44090f, 1.80561f, 0.22173f);
            f793.AddVertex(-0.41735f, 1.80318f, 0.32264f);
            f793.AddVertex(-0.77114f, 2.16350f, 0.42538f);
            faces.Add(f793);

            Face f794 = new Face(m05___Default);
            f794.AddVertex(-0.21393f, 1.00162f, 0.11736f);
            f794.AddVertex(-0.20754f, 1.00096f, 0.14471f);
            f794.AddVertex(-0.31532f, 1.43427f, 0.19725f);
            f794.AddVertex(-0.33254f, 1.43605f, 0.12347f);
            faces.Add(f794);

            Face f795 = new Face(m05___Default);
            f795.AddVertex(-1.57006f, 2.56667f, 0.64651f);
            f795.AddVertex(-0.72762f, 2.16491f, 0.51171f);
            f795.AddVertex(-0.71764f, 2.16682f, 0.50442f);
            f795.AddVertex(-1.56007f, 2.56859f, 0.63921f);
            faces.Add(f795);

            Face f796 = new Face(m05___Default);
            f796.AddVertex(-0.72762f, 2.16491f, 0.51171f);
            f796.AddVertex(-0.37384f, 1.80459f, 0.40897f);
            f796.AddVertex(-0.36385f, 1.80650f, 0.40168f);
            f796.AddVertex(-0.71764f, 2.16682f, 0.50442f);
            faces.Add(f796);

            Face f797 = new Face(m05___Default);
            f797.AddVertex(-0.18393f, 1.00173f, 0.19150f);
            f797.AddVertex(-0.26628f, 1.43352f, 0.33415f);
            f797.AddVertex(-0.27358f, 1.43212f, 0.33948f);
            f797.AddVertex(-0.18935f, 1.00069f, 0.19545f);
            faces.Add(f797);

            Face f798 = new Face(m05___Default);
            f798.AddVertex(-0.20947f, 1.00436f, 0.08208f);
            f798.AddVertex(-0.33516f, 1.44063f, 0.03903f);
            f798.AddVertex(-0.32786f, 1.44202f, 0.03370f);
            f798.AddVertex(-0.20405f, 1.00540f, 0.07813f);
            faces.Add(f798);

            Face f799 = new Face(m05___Default);
            f799.AddVertex(-0.33516f, 1.44063f, 0.03903f);
            f799.AddVertex(-0.46805f, 1.81430f, 0.00533f);
            f799.AddVertex(-0.45806f, 1.81622f, -0.00195f);
            f799.AddVertex(-0.32786f, 1.44202f, 0.03370f);
            faces.Add(f799);

            Face f800 = new Face(m05___Default);
            f800.AddVertex(-1.58886f, 2.56861f, 0.56594f);
            f800.AddVertex(-0.82184f, 2.17461f, 0.10808f);
            f800.AddVertex(-0.83182f, 2.17270f, 0.11537f);
            f800.AddVertex(-1.59884f, 2.56669f, 0.57323f);
            faces.Add(f800);

            Face f801 = new Face(m05___Default);
            f801.AddVertex(-0.35387f, 1.80842f, 0.39439f);
            f801.AddVertex(-0.25168f, 1.43632f, 0.32350f);
            f801.AddVertex(-0.26890f, 1.43810f, 0.24971f);
            f801.AddVertex(-0.37742f, 1.81085f, 0.29348f);
            faces.Add(f801);

            Face f802 = new Face(m05___Default);
            f802.AddVertex(-0.37742f, 1.81085f, 0.29348f);
            f802.AddVertex(-0.26890f, 1.43810f, 0.24971f);
            f802.AddVertex(-0.28612f, 1.43988f, 0.17593f);
            f802.AddVertex(-0.40098f, 1.81327f, 0.19257f);
            faces.Add(f802);

            Face f803 = new Face(m05___Default);
            f803.AddVertex(-0.32057f, 1.44343f, 0.02837f);
            f803.AddVertex(-0.44808f, 1.81813f, -0.00923f);
            f803.AddVertex(-0.42453f, 1.81570f, 0.09166f);
            f803.AddVertex(-0.30334f, 1.44165f, 0.10215f);
            faces.Add(f803);

            Face f804 = new Face(m05___Default);
            f804.AddVertex(-0.48801f, 1.81046f, 0.01992f);
            f804.AddVertex(-0.34976f, 1.43782f, 0.04969f);
            f804.AddVertex(-0.33254f, 1.43605f, 0.12347f);
            f804.AddVertex(-0.46446f, 1.80804f, 0.12083f);
            faces.Add(f804);

            Face f805 = new Face(m05___Default);
            f805.AddVertex(-0.46446f, 1.80804f, 0.12083f);
            f805.AddVertex(-0.33254f, 1.43605f, 0.12347f);
            f805.AddVertex(-0.31532f, 1.43427f, 0.19725f);
            f805.AddVertex(-0.44090f, 1.80561f, 0.22173f);
            faces.Add(f805);

            Face f806 = new Face(m05___Default);
            f806.AddVertex(-0.28087f, 1.43072f, 0.34482f);
            f806.AddVertex(-0.39380f, 1.80075f, 0.42355f);
            f806.AddVertex(-0.41735f, 1.80318f, 0.32264f);
            f806.AddVertex(-0.29810f, 1.43250f, 0.27103f);
            faces.Add(f806);

            Face f807 = new Face(m05___Default);
            f807.AddVertex(-0.21393f, 1.00162f, 0.11736f);
            f807.AddVertex(-0.22031f, 1.00228f, 0.09000f);
            f807.AddVertex(-0.21489f, 1.00332f, 0.08604f);
            faces.Add(f807);

            Face f808 = new Face(m05___Default);
            f808.AddVertex(-0.21393f, 1.00162f, 0.11736f);
            f808.AddVertex(-0.21489f, 1.00332f, 0.08604f);
            f808.AddVertex(-0.20947f, 1.00436f, 0.08208f);
            f808.AddVertex(-0.20754f, 1.00096f, 0.14471f);
            faces.Add(f808);

            Face f809 = new Face(m05___Default);
            f809.AddVertex(-0.18935f, 1.00069f, 0.19545f);
            f809.AddVertex(-0.19478f, 0.99964f, 0.19941f);
            f809.AddVertex(-0.20116f, 1.00031f, 0.17206f);
            faces.Add(f809);

            Face f810 = new Face(m05___Default);
            f810.AddVertex(-0.18393f, 1.00173f, 0.19150f);
            f810.AddVertex(-0.18935f, 1.00069f, 0.19545f);
            f810.AddVertex(-0.20116f, 1.00031f, 0.17206f);
            f810.AddVertex(-0.20754f, 1.00096f, 0.14471f);
            faces.Add(f810);

            Face f811 = new Face(m05___Default);
            f811.AddVertex(-0.17948f, 1.00447f, 0.15623f);
            f811.AddVertex(-0.17309f, 1.00381f, 0.18358f);
            f811.AddVertex(-0.17851f, 1.00277f, 0.18754f);
            faces.Add(f811);

            Face f812 = new Face(m05___Default);
            f812.AddVertex(-0.17948f, 1.00447f, 0.15623f);
            f812.AddVertex(-0.17851f, 1.00277f, 0.18754f);
            f812.AddVertex(-0.18393f, 1.00173f, 0.19150f);
            f812.AddVertex(-0.18586f, 1.00513f, 0.12887f);
            faces.Add(f812);

            Face f813 = new Face(m05___Default);
            f813.AddVertex(-0.20405f, 1.00540f, 0.07813f);
            f813.AddVertex(-0.19863f, 1.00644f, 0.07417f);
            f813.AddVertex(-0.19224f, 1.00579f, 0.10152f);
            faces.Add(f813);

            Face f814 = new Face(m05___Default);
            f814.AddVertex(-0.20947f, 1.00436f, 0.08208f);
            f814.AddVertex(-0.20405f, 1.00540f, 0.07813f);
            f814.AddVertex(-0.19224f, 1.00579f, 0.10152f);
            f814.AddVertex(-0.18586f, 1.00513f, 0.12887f);
            faces.Add(f814);

            Face f815 = new Face(m05___Default);
            f815.AddVertex(-0.39380f, 1.80075f, 0.42355f);
            f815.AddVertex(-0.28087f, 1.43072f, 0.34482f);
            f815.AddVertex(-0.27358f, 1.43212f, 0.33948f);
            f815.AddVertex(-0.38382f, 1.80267f, 0.41626f);
            faces.Add(f815);

            Face f816 = new Face(m05___Default);
            f816.AddVertex(-0.38382f, 1.80267f, 0.41626f);
            f816.AddVertex(-0.27358f, 1.43212f, 0.33948f);
            f816.AddVertex(-0.26628f, 1.43352f, 0.33415f);
            f816.AddVertex(-0.37384f, 1.80459f, 0.40897f);
            faces.Add(f816);

            Face f817 = new Face(m05___Default);
            f817.AddVertex(-0.25168f, 1.43632f, 0.32350f);
            f817.AddVertex(-0.35387f, 1.80842f, 0.39439f);
            f817.AddVertex(-0.36385f, 1.80650f, 0.40168f);
            f817.AddVertex(-0.25898f, 1.43493f, 0.32882f);
            faces.Add(f817);

            Face f818 = new Face(m05___Default);
            f818.AddVertex(-1.59472f, 2.56332f, 0.64095f);
            f818.AddVertex(-1.59002f, 2.56284f, 0.66108f);
            f818.AddVertex(-1.58004f, 2.56475f, 0.65380f);
            faces.Add(f818);

            Face f819 = new Face(m05___Default);
            f819.AddVertex(-1.59472f, 2.56332f, 0.64095f);
            f819.AddVertex(-1.58004f, 2.56475f, 0.65380f);
            f819.AddVertex(-1.57006f, 2.56667f, 0.64651f);
            f819.AddVertex(-1.59943f, 2.56381f, 0.62080f);
            faces.Add(f819);

            Face f820 = new Face(m05___Default);
            f820.AddVertex(-1.59884f, 2.56669f, 0.57323f);
            f820.AddVertex(-1.60882f, 2.56478f, 0.58052f);
            f820.AddVertex(-1.60413f, 2.56429f, 0.60067f);
            faces.Add(f820);

            Face f821 = new Face(m05___Default);
            f821.AddVertex(-1.58886f, 2.56861f, 0.56594f);
            f821.AddVertex(-1.59884f, 2.56669f, 0.57323f);
            f821.AddVertex(-1.60413f, 2.56429f, 0.60067f);
            f821.AddVertex(-1.59943f, 2.56381f, 0.62080f);
            faces.Add(f821);

            Face f822 = new Face(m05___Default);
            f822.AddVertex(-1.56419f, 2.57196f, 0.57150f);
            f822.AddVertex(-1.56890f, 2.57244f, 0.55136f);
            f822.AddVertex(-1.57888f, 2.57053f, 0.55865f);
            faces.Add(f822);

            Face f823 = new Face(m05___Default);
            f823.AddVertex(-1.56419f, 2.57196f, 0.57150f);
            f823.AddVertex(-1.57888f, 2.57053f, 0.55865f);
            f823.AddVertex(-1.58886f, 2.56861f, 0.56594f);
            f823.AddVertex(-1.55949f, 2.57147f, 0.59165f);
            faces.Add(f823);

            Face f824 = new Face(m05___Default);
            f824.AddVertex(-1.56007f, 2.56859f, 0.63921f);
            f824.AddVertex(-1.55009f, 2.57050f, 0.63193f);
            f824.AddVertex(-1.55479f, 2.57099f, 0.61178f);
            faces.Add(f824);

            Face f825 = new Face(m05___Default);
            f825.AddVertex(-1.57006f, 2.56667f, 0.64651f);
            f825.AddVertex(-1.56007f, 2.56859f, 0.63921f);
            f825.AddVertex(-1.55479f, 2.57099f, 0.61178f);
            f825.AddVertex(-1.55949f, 2.57147f, 0.59165f);
            faces.Add(f825);

            Face f826 = new Face(m05___Default);
            f826.AddVertex(-0.48801f, 1.81046f, 0.01992f);
            f826.AddVertex(-0.84181f, 2.17078f, 0.12265f);
            f826.AddVertex(-0.83182f, 2.17270f, 0.11537f);
            f826.AddVertex(-0.47803f, 1.81238f, 0.01263f);
            faces.Add(f826);

            Face f827 = new Face(m05___Default);
            f827.AddVertex(-0.47803f, 1.81238f, 0.01263f);
            f827.AddVertex(-0.83182f, 2.17270f, 0.11537f);
            f827.AddVertex(-0.82184f, 2.17461f, 0.10808f);
            f827.AddVertex(-0.46805f, 1.81430f, 0.00533f);
            faces.Add(f827);

            Face f828 = new Face(m05___Default);
            f828.AddVertex(-0.80187f, 2.17845f, 0.09350f);
            f828.AddVertex(-0.44808f, 1.81813f, -0.00923f);
            f828.AddVertex(-0.45806f, 1.81622f, -0.00195f);
            f828.AddVertex(-0.81186f, 2.17653f, 0.10078f);
            faces.Add(f828);

            Face f829 = new Face(m05___Default);
            f829.AddVertex(-1.55009f, 2.57050f, 0.63193f);
            f829.AddVertex(-0.70766f, 2.16874f, 0.49713f);
            f829.AddVertex(-0.73121f, 2.17116f, 0.39622f);
            f829.AddVertex(-1.55479f, 2.57099f, 0.61178f);
            faces.Add(f829);

            Face f830 = new Face(m05___Default);
            f830.AddVertex(-1.55479f, 2.57099f, 0.61178f);
            f830.AddVertex(-0.73121f, 2.17116f, 0.39622f);
            f830.AddVertex(-0.75477f, 2.17359f, 0.29532f);
            f830.AddVertex(-1.55949f, 2.57147f, 0.59165f);
            faces.Add(f830);

            Face f831 = new Face(m05___Default);
            f831.AddVertex(-0.77832f, 2.17602f, 0.19440f);
            f831.AddVertex(-0.80187f, 2.17845f, 0.09350f);
            f831.AddVertex(-1.56890f, 2.57244f, 0.55136f);
            f831.AddVertex(-1.56419f, 2.57196f, 0.57150f);
            faces.Add(f831);

            Face f832 = new Face(m05___Default);
            f832.AddVertex(-0.70766f, 2.16874f, 0.49713f);
            f832.AddVertex(-0.35387f, 1.80842f, 0.39439f);
            f832.AddVertex(-0.37742f, 1.81085f, 0.29348f);
            f832.AddVertex(-0.73121f, 2.17116f, 0.39622f);
            faces.Add(f832);

            Face f833 = new Face(m05___Default);
            f833.AddVertex(-0.73121f, 2.17116f, 0.39622f);
            f833.AddVertex(-0.37742f, 1.81085f, 0.29348f);
            f833.AddVertex(-0.40098f, 1.81327f, 0.19257f);
            f833.AddVertex(-0.75477f, 2.17359f, 0.29532f);
            faces.Add(f833);

            Face f834 = new Face(m05___Default);
            f834.AddVertex(-0.44808f, 1.81813f, -0.00923f);
            f834.AddVertex(-0.80187f, 2.17845f, 0.09350f);
            f834.AddVertex(-0.77832f, 2.17602f, 0.19440f);
            f834.AddVertex(-0.42453f, 1.81570f, 0.09166f);
            faces.Add(f834);

            Face f835 = new Face(m05___Default);
            f835.AddVertex(-0.19863f, 1.00644f, 0.07417f);
            f835.AddVertex(-0.32057f, 1.44343f, 0.02837f);
            f835.AddVertex(-0.30334f, 1.44165f, 0.10215f);
            f835.AddVertex(-0.19224f, 1.00579f, 0.10152f);
            faces.Add(f835);

            Face f836 = new Face(m05___Default);
            f836.AddVertex(-0.19224f, 1.00579f, 0.10152f);
            f836.AddVertex(-0.30334f, 1.44165f, 0.10215f);
            f836.AddVertex(-0.28612f, 1.43988f, 0.17593f);
            f836.AddVertex(-0.18586f, 1.00513f, 0.12887f);
            faces.Add(f836);

            Face f837 = new Face(m05___Default);
            f837.AddVertex(-0.26890f, 1.43810f, 0.24971f);
            f837.AddVertex(-0.25168f, 1.43632f, 0.32350f);
            f837.AddVertex(-0.17309f, 1.00381f, 0.18358f);
            f837.AddVertex(-0.17948f, 1.00447f, 0.15623f);
            faces.Add(f837);

            Face f838 = new Face(m05___Default);
            f838.AddVertex(-1.60882f, 2.56478f, 0.58052f);
            f838.AddVertex(-0.84181f, 2.17078f, 0.12265f);
            f838.AddVertex(-0.81825f, 2.16835f, 0.22357f);
            f838.AddVertex(-1.60413f, 2.56429f, 0.60067f);
            faces.Add(f838);

            Face f839 = new Face(m05___Default);
            f839.AddVertex(-1.60413f, 2.56429f, 0.60067f);
            f839.AddVertex(-0.81825f, 2.16835f, 0.22357f);
            f839.AddVertex(-0.79470f, 2.16593f, 0.32447f);
            f839.AddVertex(-1.59943f, 2.56381f, 0.62080f);
            faces.Add(f839);

            Face f840 = new Face(m05___Default);
            f840.AddVertex(-0.77114f, 2.16350f, 0.42538f);
            f840.AddVertex(-0.74759f, 2.16107f, 0.52629f);
            f840.AddVertex(-1.59002f, 2.56284f, 0.66108f);
            f840.AddVertex(-1.59472f, 2.56332f, 0.64095f);
            faces.Add(f840);

            Face f841 = new Face(m05___Default);
            f841.AddVertex(-0.84181f, 2.17078f, 0.12265f);
            f841.AddVertex(-0.48801f, 1.81046f, 0.01992f);
            f841.AddVertex(-0.46446f, 1.80804f, 0.12083f);
            f841.AddVertex(-0.81825f, 2.16835f, 0.22357f);
            faces.Add(f841);

            Face f842 = new Face(m05___Default);
            f842.AddVertex(-0.81825f, 2.16835f, 0.22357f);
            f842.AddVertex(-0.46446f, 1.80804f, 0.12083f);
            f842.AddVertex(-0.44090f, 1.80561f, 0.22173f);
            f842.AddVertex(-0.79470f, 2.16593f, 0.32447f);
            faces.Add(f842);

            Face f843 = new Face(m05___Default);
            f843.AddVertex(-0.39380f, 1.80075f, 0.42355f);
            f843.AddVertex(-0.74759f, 2.16107f, 0.52629f);
            f843.AddVertex(-0.77114f, 2.16350f, 0.42538f);
            f843.AddVertex(-0.41735f, 1.80318f, 0.32264f);
            faces.Add(f843);

            Face f844 = new Face(m05___Default);
            f844.AddVertex(-0.19478f, 0.99964f, 0.19941f);
            f844.AddVertex(-0.28087f, 1.43072f, 0.34482f);
            f844.AddVertex(-0.29810f, 1.43250f, 0.27103f);
            f844.AddVertex(-0.20116f, 1.00031f, 0.17206f);
            faces.Add(f844);

            Face f845 = new Face(m05___Default);
            f845.AddVertex(-0.20116f, 1.00031f, 0.17206f);
            f845.AddVertex(-0.29810f, 1.43250f, 0.27103f);
            f845.AddVertex(-0.31532f, 1.43427f, 0.19725f);
            f845.AddVertex(-0.20754f, 1.00096f, 0.14471f);
            faces.Add(f845);

            Face f846 = new Face(m05___Default);
            f846.AddVertex(-0.33254f, 1.43605f, 0.12347f);
            f846.AddVertex(-0.34976f, 1.43782f, 0.04969f);
            f846.AddVertex(-0.22031f, 1.00228f, 0.09000f);
            f846.AddVertex(-0.21393f, 1.00162f, 0.11736f);
            faces.Add(f846);

            Face f847 = new Face(m05___Default);
            f847.AddVertex(-1.59002f, 2.56284f, 0.66108f);
            f847.AddVertex(-0.74759f, 2.16107f, 0.52629f);
            f847.AddVertex(-0.73761f, 2.16299f, 0.51900f);
            f847.AddVertex(-1.58004f, 2.56475f, 0.65380f);
            faces.Add(f847);

            Face f848 = new Face(m05___Default);
            f848.AddVertex(-1.58004f, 2.56475f, 0.65380f);
            f848.AddVertex(-0.73761f, 2.16299f, 0.51900f);
            f848.AddVertex(-0.72762f, 2.16491f, 0.51171f);
            f848.AddVertex(-1.57006f, 2.56667f, 0.64651f);
            faces.Add(f848);

            Face f849 = new Face(m05___Default);
            f849.AddVertex(-0.70766f, 2.16874f, 0.49713f);
            f849.AddVertex(-1.55009f, 2.57050f, 0.63193f);
            f849.AddVertex(-1.56007f, 2.56859f, 0.63921f);
            f849.AddVertex(-0.71764f, 2.16682f, 0.50442f);
            faces.Add(f849);

            Face f850 = new Face(m05___Default);
            f850.AddVertex(-0.74759f, 2.16107f, 0.52629f);
            f850.AddVertex(-0.39380f, 1.80075f, 0.42355f);
            f850.AddVertex(-0.38382f, 1.80267f, 0.41626f);
            f850.AddVertex(-0.73761f, 2.16299f, 0.51900f);
            faces.Add(f850);

            Face f851 = new Face(m05___Default);
            f851.AddVertex(-0.73761f, 2.16299f, 0.51900f);
            f851.AddVertex(-0.38382f, 1.80267f, 0.41626f);
            f851.AddVertex(-0.37384f, 1.80459f, 0.40897f);
            f851.AddVertex(-0.72762f, 2.16491f, 0.51171f);
            faces.Add(f851);

            Face f852 = new Face(m05___Default);
            f852.AddVertex(-0.35387f, 1.80842f, 0.39439f);
            f852.AddVertex(-0.70766f, 2.16874f, 0.49713f);
            f852.AddVertex(-0.71764f, 2.16682f, 0.50442f);
            f852.AddVertex(-0.36385f, 1.80650f, 0.40168f);
            faces.Add(f852);

            Face f853 = new Face(m05___Default);
            f853.AddVertex(-0.17309f, 1.00381f, 0.18358f);
            f853.AddVertex(-0.25168f, 1.43632f, 0.32350f);
            f853.AddVertex(-0.25898f, 1.43493f, 0.32882f);
            f853.AddVertex(-0.17851f, 1.00277f, 0.18754f);
            faces.Add(f853);

            Face f854 = new Face(m05___Default);
            f854.AddVertex(-0.17851f, 1.00277f, 0.18754f);
            f854.AddVertex(-0.25898f, 1.43493f, 0.32882f);
            f854.AddVertex(-0.26628f, 1.43352f, 0.33415f);
            f854.AddVertex(-0.18393f, 1.00173f, 0.19150f);
            faces.Add(f854);

            Face f855 = new Face(m05___Default);
            f855.AddVertex(-0.28087f, 1.43072f, 0.34482f);
            f855.AddVertex(-0.19478f, 0.99964f, 0.19941f);
            f855.AddVertex(-0.18935f, 1.00069f, 0.19545f);
            f855.AddVertex(-0.27358f, 1.43212f, 0.33948f);
            faces.Add(f855);

            Face f856 = new Face(m05___Default);
            f856.AddVertex(-0.22031f, 1.00228f, 0.09000f);
            f856.AddVertex(-0.34976f, 1.43782f, 0.04969f);
            f856.AddVertex(-0.34246f, 1.43922f, 0.04435f);
            f856.AddVertex(-0.21489f, 1.00332f, 0.08604f);
            faces.Add(f856);

            Face f857 = new Face(m05___Default);
            f857.AddVertex(-0.21489f, 1.00332f, 0.08604f);
            f857.AddVertex(-0.34246f, 1.43922f, 0.04435f);
            f857.AddVertex(-0.33516f, 1.44063f, 0.03903f);
            f857.AddVertex(-0.20947f, 1.00436f, 0.08208f);
            faces.Add(f857);

            Face f858 = new Face(m05___Default);
            f858.AddVertex(-0.32057f, 1.44343f, 0.02837f);
            f858.AddVertex(-0.19863f, 1.00644f, 0.07417f);
            f858.AddVertex(-0.20405f, 1.00540f, 0.07813f);
            f858.AddVertex(-0.32786f, 1.44202f, 0.03370f);
            faces.Add(f858);

            Face f859 = new Face(m05___Default);
            f859.AddVertex(-0.34976f, 1.43782f, 0.04969f);
            f859.AddVertex(-0.48801f, 1.81046f, 0.01992f);
            f859.AddVertex(-0.47803f, 1.81238f, 0.01263f);
            f859.AddVertex(-0.34246f, 1.43922f, 0.04435f);
            faces.Add(f859);

            Face f860 = new Face(m05___Default);
            f860.AddVertex(-0.34246f, 1.43922f, 0.04435f);
            f860.AddVertex(-0.47803f, 1.81238f, 0.01263f);
            f860.AddVertex(-0.46805f, 1.81430f, 0.00533f);
            f860.AddVertex(-0.33516f, 1.44063f, 0.03903f);
            faces.Add(f860);

            Face f861 = new Face(m05___Default);
            f861.AddVertex(-0.44808f, 1.81813f, -0.00923f);
            f861.AddVertex(-0.32057f, 1.44343f, 0.02837f);
            f861.AddVertex(-0.32786f, 1.44202f, 0.03370f);
            f861.AddVertex(-0.45806f, 1.81622f, -0.00195f);
            faces.Add(f861);

            Face f862 = new Face(m05___Default);
            f862.AddVertex(-1.56890f, 2.57244f, 0.55136f);
            f862.AddVertex(-0.80187f, 2.17845f, 0.09350f);
            f862.AddVertex(-0.81186f, 2.17653f, 0.10078f);
            f862.AddVertex(-1.57888f, 2.57053f, 0.55865f);
            faces.Add(f862);

            Face f863 = new Face(m05___Default);
            f863.AddVertex(-1.57888f, 2.57053f, 0.55865f);
            f863.AddVertex(-0.81186f, 2.17653f, 0.10078f);
            f863.AddVertex(-0.82184f, 2.17461f, 0.10808f);
            f863.AddVertex(-1.58886f, 2.56861f, 0.56594f);
            faces.Add(f863);

            Face f864 = new Face(m05___Default);
            f864.AddVertex(-0.84181f, 2.17078f, 0.12265f);
            f864.AddVertex(-1.60882f, 2.56478f, 0.58052f);
            f864.AddVertex(-1.59884f, 2.56669f, 0.57323f);
            f864.AddVertex(-0.83182f, 2.17270f, 0.11537f);
            faces.Add(f864);

            Face f865 = new Face(m04___Default);
            f865.AddVertex(-0.94057f, 5.31803f, 0.68737f);
            f865.AddVertex(-0.92882f, 5.28722f, 0.70559f);
            f865.AddVertex(-0.90700f, 5.27571f, 0.72364f);
            faces.Add(f865);

            Face f866 = new Face(m04___Default);
            f866.AddVertex(-0.93907f, 5.35990f, 0.67386f);
            f866.AddVertex(-0.94057f, 5.31803f, 0.68737f);
            f866.AddVertex(-0.90700f, 5.27571f, 0.72364f);
            f866.AddVertex(-0.92475f, 5.40158f, 0.66869f);
            faces.Add(f866);

            Face f867 = new Face(m04___Default);
            f867.AddVertex(-0.90142f, 5.43193f, 0.67324f);
            f867.AddVertex(-0.92475f, 5.40158f, 0.66869f);
            f867.AddVertex(-0.90700f, 5.27571f, 0.72364f);
            f867.AddVertex(-0.87536f, 5.44281f, 0.68630f);
            faces.Add(f867);

            Face f868 = new Face(m04___Default);
            f868.AddVertex(-0.85354f, 5.43129f, 0.70435f);
            f868.AddVertex(-0.87536f, 5.44281f, 0.68630f);
            f868.AddVertex(-0.90700f, 5.27571f, 0.72364f);
            f868.AddVertex(-0.84179f, 5.40048f, 0.72257f);
            faces.Add(f868);

            Face f869 = new Face(m04___Default);
            f869.AddVertex(-0.84329f, 5.35862f, 0.73608f);
            f869.AddVertex(-0.84179f, 5.40048f, 0.72257f);
            f869.AddVertex(-0.90700f, 5.27571f, 0.72364f);
            f869.AddVertex(-0.85761f, 5.31693f, 0.74125f);
            faces.Add(f869);

            Face f870 = new Face(m04___Default);
            f870.AddVertex(-0.88093f, 5.28658f, 0.73670f);
            f870.AddVertex(-0.85761f, 5.31693f, 0.74125f);
            f870.AddVertex(-0.90700f, 5.27571f, 0.72364f);
            faces.Add(f870);

            Face f871 = new Face(m04___Default);
            f871.AddVertex(-0.10387f, 6.30275f, 0.11483f);
            f871.AddVertex(-0.11037f, 6.29923f, 0.11495f);
            f871.AddVertex(-0.10182f, 6.29582f, 0.09917f);
            f871.AddVertex(-0.09549f, 6.29926f, 0.09906f);
            faces.Add(f871);

            Face f872 = new Face(m04___Default);
            f872.AddVertex(-0.11464f, 6.31311f, 0.12599f);
            f872.AddVertex(-0.12157f, 6.30935f, 0.12611f);
            f872.AddVertex(-0.11037f, 6.29923f, 0.11495f);
            f872.AddVertex(-0.10387f, 6.30275f, 0.11483f);
            faces.Add(f872);

            Face f873 = new Face(m04___Default);
            f873.AddVertex(-0.09791f, 6.30572f, 0.11475f);
            f873.AddVertex(-0.10387f, 6.30275f, 0.11483f);
            f873.AddVertex(-0.09549f, 6.29926f, 0.09906f);
            f873.AddVertex(-0.08966f, 6.30216f, 0.09898f);
            faces.Add(f873);

            Face f874 = new Face(m04___Default);
            f874.AddVertex(-0.10834f, 6.31625f, 0.12590f);
            f874.AddVertex(-0.11464f, 6.31311f, 0.12599f);
            f874.AddVertex(-0.10387f, 6.30275f, 0.11483f);
            f874.AddVertex(-0.09791f, 6.30572f, 0.11475f);
            faces.Add(f874);

            Face f875 = new Face(m04___Default);
            f875.AddVertex(-0.11815f, 6.33094f, 0.12944f);
            f875.AddVertex(-0.12491f, 6.32757f, 0.12954f);
            f875.AddVertex(-0.11464f, 6.31311f, 0.12599f);
            f875.AddVertex(-0.10834f, 6.31625f, 0.12590f);
            faces.Add(f875);

            Face f876 = new Face(m04___Default);
            f876.AddVertex(-0.08966f, 6.30216f, 0.09898f);
            f876.AddVertex(-0.09549f, 6.29926f, 0.09906f);
            f876.AddVertex(-0.09174f, 6.30357f, 0.08290f);
            f876.AddVertex(-0.08578f, 6.30654f, 0.08282f);
            faces.Add(f876);

            Face f877 = new Face(m04___Default);
            f877.AddVertex(-0.08815f, 6.31032f, 0.11462f);
            f877.AddVertex(-0.09791f, 6.30572f, 0.11475f);
            f877.AddVertex(-0.08966f, 6.30216f, 0.09898f);
            f877.AddVertex(-0.07937f, 6.30702f, 0.09884f);
            faces.Add(f877);

            Face f878 = new Face(m04___Default);
            f878.AddVertex(-0.10002f, 6.32018f, 0.12579f);
            f878.AddVertex(-0.10834f, 6.31625f, 0.12590f);
            f878.AddVertex(-0.09791f, 6.30572f, 0.11475f);
            f878.AddVertex(-0.08815f, 6.31032f, 0.11462f);
            faces.Add(f878);

            Face f879 = new Face(m04___Default);
            f879.AddVertex(-0.11178f, 6.33394f, 0.12936f);
            f879.AddVertex(-0.11815f, 6.33094f, 0.12944f);
            f879.AddVertex(-0.10834f, 6.31625f, 0.12590f);
            f879.AddVertex(-0.10002f, 6.32018f, 0.12579f);
            faces.Add(f879);

            Face f880 = new Face(m04___Default);
            f880.AddVertex(-0.12029f, 6.34792f, 0.12437f);
            f880.AddVertex(-0.12470f, 6.34584f, 0.12443f);
            f880.AddVertex(-0.11815f, 6.33094f, 0.12944f);
            f880.AddVertex(-0.11178f, 6.33394f, 0.12936f);
            faces.Add(f880);

            Face f881 = new Face(m04___Default);
            f881.AddVertex(-0.07602f, 6.31115f, 0.08268f);
            f881.AddVertex(-0.08578f, 6.30654f, 0.08282f);
            f881.AddVertex(-0.08733f, 6.31767f, 0.07058f);
            f881.AddVertex(-0.07900f, 6.32161f, 0.07048f);
            faces.Add(f881);

            Face f882 = new Face(m04___Default);
            f882.AddVertex(-0.07937f, 6.30702f, 0.09884f);
            f882.AddVertex(-0.08966f, 6.30216f, 0.09898f);
            f882.AddVertex(-0.08578f, 6.30654f, 0.08282f);
            f882.AddVertex(-0.07602f, 6.31115f, 0.08268f);
            faces.Add(f882);

            Face f883 = new Face(m04___Default);
            f883.AddVertex(-0.01133f, 6.37469f, 0.11231f);
            f883.AddVertex(-0.08815f, 6.31032f, 0.11462f);
            f883.AddVertex(-0.07937f, 6.30702f, 0.09884f);
            f883.AddVertex(-0.00207f, 6.37178f, 0.09652f);
            faces.Add(f883);

            Face f884 = new Face(m04___Default);
            f884.AddVertex(-0.02450f, 6.38344f, 0.12352f);
            f884.AddVertex(-0.10002f, 6.32018f, 0.12579f);
            f884.AddVertex(-0.08815f, 6.31032f, 0.11462f);
            f884.AddVertex(-0.01133f, 6.37469f, 0.11231f);
            faces.Add(f884);

            Face f885 = new Face(m04___Default);
            f885.AddVertex(-0.03804f, 6.39571f, 0.12715f);
            f885.AddVertex(-0.11178f, 6.33394f, 0.12936f);
            f885.AddVertex(-0.10002f, 6.32018f, 0.12579f);
            f885.AddVertex(-0.02450f, 6.38344f, 0.12352f);
            faces.Add(f885);

            Face f886 = new Face(m04___Default);
            f886.AddVertex(-0.04834f, 6.40820f, 0.12221f);
            f886.AddVertex(-0.12029f, 6.34792f, 0.12437f);
            f886.AddVertex(-0.11178f, 6.33394f, 0.12936f);
            f886.AddVertex(-0.03804f, 6.39571f, 0.12715f);
            faces.Add(f886);

            Face f887 = new Face(m04___Default);
            f887.AddVertex(0.00079f, 6.37550f, 0.08038f);
            f887.AddVertex(-0.07602f, 6.31115f, 0.08268f);
            f887.AddVertex(-0.07900f, 6.32161f, 0.07048f);
            f887.AddVertex(-0.00349f, 6.38487f, 0.06821f);
            faces.Add(f887);

            Face f888 = new Face(m04___Default);
            f888.AddVertex(-0.00207f, 6.37178f, 0.09652f);
            f888.AddVertex(-0.07937f, 6.30702f, 0.09884f);
            f888.AddVertex(-0.07602f, 6.31115f, 0.08268f);
            f888.AddVertex(0.00079f, 6.37550f, 0.08038f);
            faces.Add(f888);

            Face f889 = new Face(m04___Default);
            f889.AddVertex(-0.02450f, 6.38344f, 0.12352f);
            f889.AddVertex(-0.01133f, 6.37469f, 0.11231f);
            f889.AddVertex(-0.00207f, 6.37178f, 0.09652f);
            faces.Add(f889);

            Face f890 = new Face(m04___Default);
            f890.AddVertex(-0.03804f, 6.39571f, 0.12715f);
            f890.AddVertex(-0.02450f, 6.38344f, 0.12352f);
            f890.AddVertex(-0.00207f, 6.37178f, 0.09652f);
            f890.AddVertex(-0.04834f, 6.40820f, 0.12221f);
            faces.Add(f890);

            Face f891 = new Face(m04___Default);
            f891.AddVertex(-0.05262f, 6.41756f, 0.11004f);
            f891.AddVertex(-0.04834f, 6.40820f, 0.12221f);
            f891.AddVertex(-0.00207f, 6.37178f, 0.09652f);
            f891.AddVertex(-0.04976f, 6.42129f, 0.09390f);
            faces.Add(f891);

            Face f892 = new Face(m04___Default);
            f892.AddVertex(-0.04049f, 6.41838f, 0.07811f);
            f892.AddVertex(-0.04976f, 6.42129f, 0.09390f);
            f892.AddVertex(-0.00207f, 6.37178f, 0.09652f);
            f892.AddVertex(-0.02733f, 6.40962f, 0.06690f);
            faces.Add(f892);

            Face f893 = new Face(m04___Default);
            f893.AddVertex(-0.01378f, 6.39736f, 0.06328f);
            f893.AddVertex(-0.02733f, 6.40962f, 0.06690f);
            f893.AddVertex(-0.00207f, 6.37178f, 0.09652f);
            f893.AddVertex(-0.00349f, 6.38487f, 0.06821f);
            faces.Add(f893);

            Face f894 = new Face(m04___Default);
            f894.AddVertex(0.00079f, 6.37550f, 0.08038f);
            f894.AddVertex(-0.00349f, 6.38487f, 0.06821f);
            f894.AddVertex(-0.00207f, 6.37178f, 0.09652f);
            faces.Add(f894);

            Face f895 = new Face(m04___Default);
            f895.AddVertex(-0.95263f, 7.07263f, 0.07321f);
            f895.AddVertex(-0.98118f, 6.93619f, 0.07916f);
            f895.AddVertex(-0.97017f, 6.93691f, 0.06322f);
            f895.AddVertex(-0.94185f, 7.07222f, 0.05732f);
            faces.Add(f895);

            Face f896 = new Face(m04___Default);
            f896.AddVertex(-0.96994f, 7.07458f, 0.08469f);
            f896.AddVertex(-0.99914f, 6.93505f, 0.09078f);
            f896.AddVertex(-0.98118f, 6.93619f, 0.07916f);
            f896.AddVertex(-0.95263f, 7.07263f, 0.07321f);
            faces.Add(f896);

            Face f897 = new Face(m04___Default);
            f897.AddVertex(-0.98914f, 7.07756f, 0.08869f);
            f897.AddVertex(-1.01923f, 6.93379f, 0.09497f);
            f897.AddVertex(-0.99914f, 6.93505f, 0.09078f);
            f897.AddVertex(-0.96994f, 7.07458f, 0.08469f);
            faces.Add(f897);

            Face f898 = new Face(m04___Default);
            f898.AddVertex(-1.00510f, 7.08074f, 0.08414f);
            f898.AddVertex(-1.03607f, 6.93275f, 0.09059f);
            f898.AddVertex(-1.01923f, 6.93379f, 0.09497f);
            f898.AddVertex(-0.98914f, 7.07756f, 0.08869f);
            faces.Add(f898);

            Face f899 = new Face(m04___Default);
            f899.AddVertex(-1.01353f, 7.08330f, 0.07224f);
            f899.AddVertex(-1.04514f, 6.93221f, 0.07883f);
            f899.AddVertex(-1.03607f, 6.93275f, 0.09059f);
            f899.AddVertex(-1.00510f, 7.08074f, 0.08414f);
            faces.Add(f899);

            Face f900 = new Face(m04___Default);
            f900.AddVertex(-1.01217f, 7.08454f, 0.05620f);
            f900.AddVertex(-1.04403f, 6.93231f, 0.06284f);
            f900.AddVertex(-1.04514f, 6.93221f, 0.07883f);
            f900.AddVertex(-1.01353f, 7.08330f, 0.07224f);
            faces.Add(f900);

            Face f901 = new Face(m04___Default);
            f901.AddVertex(-1.00140f, 7.08412f, 0.04031f);
            f901.AddVertex(-1.03301f, 6.93303f, 0.04689f);
            f901.AddVertex(-1.04403f, 6.93231f, 0.06284f);
            f901.AddVertex(-1.01217f, 7.08454f, 0.05620f);
            faces.Add(f901);

            Face f902 = new Face(m04___Default);
            f902.AddVertex(-0.98408f, 7.08217f, 0.02882f);
            f902.AddVertex(-1.01505f, 6.93417f, 0.03528f);
            f902.AddVertex(-1.03301f, 6.93303f, 0.04689f);
            f902.AddVertex(-1.00140f, 7.08412f, 0.04031f);
            faces.Add(f902);

            Face f903 = new Face(m04___Default);
            f903.AddVertex(-0.96488f, 7.07920f, 0.02482f);
            f903.AddVertex(-0.99497f, 6.93543f, 0.03110f);
            f903.AddVertex(-1.01505f, 6.93417f, 0.03528f);
            f903.AddVertex(-0.98408f, 7.08217f, 0.02882f);
            faces.Add(f903);

            Face f904 = new Face(m04___Default);
            f904.AddVertex(-0.94892f, 7.07601f, 0.02938f);
            f904.AddVertex(-0.97812f, 6.93647f, 0.03547f);
            f904.AddVertex(-0.99497f, 6.93543f, 0.03110f);
            f904.AddVertex(-0.96488f, 7.07920f, 0.02482f);
            faces.Add(f904);

            Face f905 = new Face(m04___Default);
            f905.AddVertex(-0.94050f, 7.07346f, 0.04128f);
            f905.AddVertex(-0.96905f, 6.93701f, 0.04723f);
            f905.AddVertex(-0.97812f, 6.93647f, 0.03547f);
            f905.AddVertex(-0.94892f, 7.07601f, 0.02938f);
            faces.Add(f905);

            Face f906 = new Face(m04___Default);
            f906.AddVertex(-0.94185f, 7.07222f, 0.05732f);
            f906.AddVertex(-0.97017f, 6.93691f, 0.06322f);
            f906.AddVertex(-0.96905f, 6.93701f, 0.04723f);
            f906.AddVertex(-0.94050f, 7.07346f, 0.04128f);
            faces.Add(f906);

            Face f907 = new Face(m04___Default);
            f907.AddVertex(-0.96994f, 7.07458f, 0.08469f);
            f907.AddVertex(-0.95263f, 7.07263f, 0.07321f);
            f907.AddVertex(-0.94185f, 7.07222f, 0.05732f);
            faces.Add(f907);

            Face f908 = new Face(m04___Default);
            f908.AddVertex(-0.98914f, 7.07756f, 0.08869f);
            f908.AddVertex(-0.96994f, 7.07458f, 0.08469f);
            f908.AddVertex(-0.94185f, 7.07222f, 0.05732f);
            f908.AddVertex(-1.00510f, 7.08074f, 0.08414f);
            faces.Add(f908);

            Face f909 = new Face(m04___Default);
            f909.AddVertex(-1.01353f, 7.08330f, 0.07224f);
            f909.AddVertex(-1.00510f, 7.08074f, 0.08414f);
            f909.AddVertex(-0.94185f, 7.07222f, 0.05732f);
            f909.AddVertex(-1.01217f, 7.08454f, 0.05620f);
            faces.Add(f909);

            Face f910 = new Face(m04___Default);
            f910.AddVertex(-1.00140f, 7.08412f, 0.04031f);
            f910.AddVertex(-1.01217f, 7.08454f, 0.05620f);
            f910.AddVertex(-0.94185f, 7.07222f, 0.05732f);
            f910.AddVertex(-0.98408f, 7.08217f, 0.02882f);
            faces.Add(f910);

            Face f911 = new Face(m04___Default);
            f911.AddVertex(-0.96488f, 7.07920f, 0.02482f);
            f911.AddVertex(-0.98408f, 7.08217f, 0.02882f);
            f911.AddVertex(-0.94185f, 7.07222f, 0.05732f);
            f911.AddVertex(-0.94892f, 7.07601f, 0.02938f);
            faces.Add(f911);

            Face f912 = new Face(m04___Default);
            f912.AddVertex(-0.94050f, 7.07346f, 0.04128f);
            f912.AddVertex(-0.94892f, 7.07601f, 0.02938f);
            f912.AddVertex(-0.94185f, 7.07222f, 0.05732f);
            faces.Add(f912);

            Face f913 = new Face(m04___Default);
            f913.AddVertex(-1.34249f, 7.02841f, 0.07211f);
            f913.AddVertex(-1.22966f, 6.91597f, 0.07810f);
            f913.AddVertex(-1.21957f, 6.91896f, 0.06204f);
            f913.AddVertex(-1.33291f, 7.03188f, 0.05603f);
            faces.Add(f913);

            Face f914 = new Face(m04___Default);
            f914.AddVertex(-1.35654f, 7.01973f, 0.08410f);
            f914.AddVertex(-1.24508f, 6.90866f, 0.09001f);
            f914.AddVertex(-1.22966f, 6.91597f, 0.07810f);
            f914.AddVertex(-1.34249f, 7.02841f, 0.07211f);
            faces.Add(f914);

            Face f915 = new Face(m04___Default);
            f915.AddVertex(-1.37129f, 7.00816f, 0.08879f);
            f915.AddVertex(-1.26170f, 6.89896f, 0.09461f);
            f915.AddVertex(-1.24508f, 6.90866f, 0.09001f);
            f915.AddVertex(-1.35654f, 7.01973f, 0.08410f);
            faces.Add(f915);

            Face f916 = new Face(m04___Default);
            f916.AddVertex(-1.33553f, 7.02115f, 0.02878f);
            f916.AddVertex(-1.22407f, 6.91008f, 0.03470f);
            f916.AddVertex(-1.23744f, 6.90061f, 0.03074f);
            f916.AddVertex(-1.34702f, 7.00981f, 0.02492f);
            faces.Add(f916);

            Face f917 = new Face(m04___Default);
            f917.AddVertex(-1.33036f, 7.02923f, 0.04017f);
            f917.AddVertex(-1.21753f, 6.91680f, 0.04616f);
            f917.AddVertex(-1.22407f, 6.91008f, 0.03470f);
            f917.AddVertex(-1.33553f, 7.02115f, 0.02878f);
            faces.Add(f917);

            Face f918 = new Face(m04___Default);
            f918.AddVertex(-1.33291f, 7.03188f, 0.05603f);
            f918.AddVertex(-1.21957f, 6.91896f, 0.06204f);
            f918.AddVertex(-1.21753f, 6.91680f, 0.04616f);
            f918.AddVertex(-1.33036f, 7.02923f, 0.04017f);
            faces.Add(f918);

            Face f919 = new Face(m04___Default);
            f919.AddVertex(-1.35654f, 7.01973f, 0.08410f);
            f919.AddVertex(-1.34249f, 7.02841f, 0.07211f);
            f919.AddVertex(-1.33291f, 7.03188f, 0.05603f);
            faces.Add(f919);

            Face f920 = new Face(m04___Default);
            f920.AddVertex(-1.37129f, 7.00816f, 0.08879f);
            f920.AddVertex(-1.35654f, 7.01973f, 0.08410f);
            f920.AddVertex(-1.33291f, 7.03188f, 0.05603f);
            f920.AddVertex(-1.38279f, 6.99683f, 0.08493f);
            faces.Add(f920);

            Face f921 = new Face(m04___Default);
            f921.AddVertex(-1.38795f, 6.98874f, 0.07354f);
            f921.AddVertex(-1.38279f, 6.99683f, 0.08493f);
            f921.AddVertex(-1.33291f, 7.03188f, 0.05603f);
            f921.AddVertex(-1.38541f, 6.98609f, 0.05768f);
            faces.Add(f921);

            Face f922 = new Face(m04___Default);
            f922.AddVertex(-1.37582f, 6.98956f, 0.04160f);
            f922.AddVertex(-1.38541f, 6.98609f, 0.05768f);
            f922.AddVertex(-1.33291f, 7.03188f, 0.05603f);
            f922.AddVertex(-1.36177f, 6.99825f, 0.02961f);
            faces.Add(f922);

            Face f923 = new Face(m04___Default);
            f923.AddVertex(-1.34702f, 7.00981f, 0.02492f);
            f923.AddVertex(-1.36177f, 6.99825f, 0.02961f);
            f923.AddVertex(-1.33291f, 7.03188f, 0.05603f);
            f923.AddVertex(-1.33553f, 7.02115f, 0.02878f);
            faces.Add(f923);

            Face f924 = new Face(m04___Default);
            f924.AddVertex(-1.33036f, 7.02923f, 0.04017f);
            f924.AddVertex(-1.33553f, 7.02115f, 0.02878f);
            f924.AddVertex(-1.33291f, 7.03188f, 0.05603f);
            faces.Add(f924);

            Face f925 = new Face(m04___Default);
            f925.AddVertex(-0.50640f, 4.05845f, 0.76175f);
            f925.AddVertex(-0.48379f, 4.02792f, 0.76966f);
            f925.AddVertex(-0.45036f, 4.01681f, 0.77275f);
            faces.Add(f925);

            Face f926 = new Face(m04___Default);
            f926.AddVertex(-0.51211f, 4.10022f, 0.75114f);
            f926.AddVertex(-0.50640f, 4.05845f, 0.76175f);
            f926.AddVertex(-0.45036f, 4.01681f, 0.77275f);
            f926.AddVertex(-0.49941f, 4.14204f, 0.74067f);
            faces.Add(f926);

            Face f927 = new Face(m04___Default);
            f927.AddVertex(-0.47169f, 4.17270f, 0.73316f);
            f927.AddVertex(-0.49941f, 4.14204f, 0.74067f);
            f927.AddVertex(-0.45036f, 4.01681f, 0.77275f);
            f927.AddVertex(-0.43638f, 4.18398f, 0.73061f);
            faces.Add(f927);

            Face f928 = new Face(m04___Default);
            f928.AddVertex(-0.40295f, 4.17287f, 0.73370f);
            f928.AddVertex(-0.43638f, 4.18398f, 0.73061f);
            f928.AddVertex(-0.45036f, 4.01681f, 0.77275f);
            f928.AddVertex(-0.38034f, 4.14234f, 0.74161f);
            faces.Add(f928);

            Face f929 = new Face(m04___Default);
            f929.AddVertex(-0.37463f, 4.10057f, 0.75222f);
            f929.AddVertex(-0.38034f, 4.14234f, 0.74161f);
            f929.AddVertex(-0.45036f, 4.01681f, 0.77275f);
            f929.AddVertex(-0.38733f, 4.05876f, 0.76268f);
            faces.Add(f929);

            Face f930 = new Face(m04___Default);
            f930.AddVertex(-0.41505f, 4.02809f, 0.77020f);
            f930.AddVertex(-0.38733f, 4.05876f, 0.76268f);
            f930.AddVertex(-0.45036f, 4.01681f, 0.77275f);
            faces.Add(f930);

            Face f931 = new Face(m02___Default);
            f931.AddVertex(-0.86924f, 5.44438f, 0.75818f);
            f931.AddVertex(-0.71644f, 5.26189f, 0.83473f);
            f931.AddVertex(-0.61150f, 5.13511f, 0.90346f);
            f931.AddVertex(-0.50564f, 5.10904f, 1.02913f);
            faces.Add(f931);

            Face f932 = new Face(m02___Default);
            f932.AddVertex(-0.61150f, 5.13511f, 0.90346f);
            f932.AddVertex(-0.55644f, 5.11517f, 0.96111f);
            f932.AddVertex(-0.50564f, 5.10904f, 1.02913f);
            faces.Add(f932);

            Face f933 = new Face(m02___Default);
            f933.AddVertex(-0.45849f, 5.53385f, 1.31197f);
            f933.AddVertex(-0.86924f, 5.44438f, 0.75818f);
            f933.AddVertex(-0.50564f, 5.10904f, 1.02913f);
            f933.AddVertex(-0.43841f, 5.26172f, 1.22376f);
            faces.Add(f933);

            Face f934 = new Face(m02___Default);
            f934.AddVertex(-0.50564f, 5.10904f, 1.02913f);
            f934.AddVertex(-0.46672f, 5.15700f, 1.11284f);
            f934.AddVertex(-0.43841f, 5.26172f, 1.22376f);
            faces.Add(f934);

            Face f935 = new Face(m02___Default);
            f935.AddVertex(-0.43841f, 5.26172f, 1.22376f);
            f935.AddVertex(-0.44296f, 5.39129f, 1.27986f);
            f935.AddVertex(-0.45849f, 5.53385f, 1.31197f);
            faces.Add(f935);

            Face f936 = new Face(m02___Default);
            f936.AddVertex(-0.62088f, 5.97627f, 1.13366f);
            f936.AddVertex(-0.86924f, 5.44438f, 0.75818f);
            f936.AddVertex(-0.45849f, 5.53385f, 1.31197f);
            f936.AddVertex(-0.56573f, 5.89142f, 1.20264f);
            faces.Add(f936);

            Face f937 = new Face(m02___Default);
            f937.AddVertex(-0.56573f, 5.89142f, 1.20264f);
            f937.AddVertex(-0.45849f, 5.53385f, 1.31197f);
            f937.AddVertex(-0.48702f, 5.67563f, 1.29990f);
            f937.AddVertex(-0.52615f, 5.80015f, 1.25326f);
            faces.Add(f937);

            Face f938 = new Face(m02___Default);
            f938.AddVertex(-0.86924f, 5.44438f, 0.75818f);
            f938.AddVertex(-0.62088f, 5.97627f, 1.13366f);
            f938.AddVertex(-0.70357f, 6.03576f, 1.03777f);
            f938.AddVertex(-0.83249f, 5.62365f, 0.82073f);
            faces.Add(f938);

            Face f939 = new Face(m02___Default);
            f939.AddVertex(-0.84266f, 5.69345f, 0.82774f);
            f939.AddVertex(-0.83249f, 5.62365f, 0.82073f);
            f939.AddVertex(-0.70357f, 6.03576f, 1.03777f);
            f939.AddVertex(-0.75931f, 6.03702f, 0.97719f);
            faces.Add(f939);

            Face f940 = new Face(m02___Default);
            f940.AddVertex(-0.75931f, 6.03702f, 0.97719f);
            f940.AddVertex(-0.86027f, 5.79042f, 0.83489f);
            f940.AddVertex(-0.84266f, 5.69345f, 0.82774f);
            faces.Add(f940);

            Face f941 = new Face(m02___Default);
            f941.AddVertex(-0.75931f, 6.03702f, 0.97719f);
            f941.AddVertex(-0.81264f, 6.01673f, 0.92244f);
            f941.AddVertex(-0.85379f, 5.97467f, 0.87893f);
            f941.AddVertex(-0.86027f, 5.79042f, 0.83489f);
            faces.Add(f941);

            Face f942 = new Face(m02___Default);
            f942.AddVertex(-0.88338f, 5.85632f, 0.83160f);
            f942.AddVertex(-0.86027f, 5.79042f, 0.83489f);
            f942.AddVertex(-0.85379f, 5.97467f, 0.87893f);
            f942.AddVertex(-0.88710f, 5.92437f, 0.84297f);
            faces.Add(f942);

            Face f943 = new Face(m02___Default);
            f943.AddVertex(-0.41745f, 5.39725f, 1.25496f);
            f943.AddVertex(-0.41291f, 5.26767f, 1.19885f);
            f943.AddVertex(-0.44123f, 5.16295f, 1.08794f);
            f943.AddVertex(-0.58600f, 5.14106f, 0.87856f);
            faces.Add(f943);

            Face f944 = new Face(m02___Default);
            f944.AddVertex(-0.58600f, 5.14106f, 0.87856f);
            f944.AddVertex(-0.44123f, 5.16295f, 1.08794f);
            f944.AddVertex(-0.48014f, 5.11499f, 1.00423f);
            f944.AddVertex(-0.53095f, 5.12112f, 0.93621f);
            faces.Add(f944);

            Face f945 = new Face(m02___Default);
            f945.AddVertex(-0.67723f, 6.04158f, 1.01383f);
            f945.AddVertex(-0.41745f, 5.39725f, 1.25496f);
            f945.AddVertex(-0.58600f, 5.14106f, 0.87856f);
            f945.AddVertex(-0.84374f, 5.45033f, 0.73327f);
            faces.Add(f945);

            Face f946 = new Face(m02___Default);
            f946.AddVertex(-0.58600f, 5.14106f, 0.87856f);
            f946.AddVertex(-0.69094f, 5.26785f, 0.80983f);
            f946.AddVertex(-0.84374f, 5.45033f, 0.73327f);
            faces.Add(f946);

            Face f947 = new Face(m02___Default);
            f947.AddVertex(-0.67723f, 6.04158f, 1.01383f);
            f947.AddVertex(-0.84374f, 5.45033f, 0.73327f);
            f947.AddVertex(-0.80699f, 5.62961f, 0.79583f);
            f947.AddVertex(-0.81716f, 5.69940f, 0.80284f);
            faces.Add(f947);

            Face f948 = new Face(m02___Default);
            f948.AddVertex(-0.78713f, 6.02268f, 0.89753f);
            f948.AddVertex(-0.67723f, 6.04158f, 1.01383f);
            f948.AddVertex(-0.81716f, 5.69940f, 0.80284f);
            f948.AddVertex(-0.83477f, 5.79637f, 0.80999f);
            faces.Add(f948);

            Face f949 = new Face(m02___Default);
            f949.AddVertex(-0.78713f, 6.02268f, 0.89753f);
            f949.AddVertex(-0.83477f, 5.79637f, 0.80999f);
            f949.AddVertex(-0.85788f, 5.86228f, 0.80670f);
            f949.AddVertex(-0.82820f, 5.98076f, 0.85413f);
            faces.Add(f949);

            Face f950 = new Face(m02___Default);
            f950.AddVertex(-0.85788f, 5.86228f, 0.80670f);
            f950.AddVertex(-0.86159f, 5.93033f, 0.81806f);
            f950.AddVertex(-0.82820f, 5.98076f, 0.85413f);
            faces.Add(f950);

            Face f951 = new Face(m02___Default);
            f951.AddVertex(-0.78713f, 6.02268f, 0.89753f);
            f951.AddVertex(-0.73381f, 6.04297f, 0.95229f);
            f951.AddVertex(-0.67723f, 6.04158f, 1.01383f);
            faces.Add(f951);

            Face f952 = new Face(m02___Default);
            f952.AddVertex(-0.54023f, 5.89737f, 1.17775f);
            f952.AddVertex(-0.41745f, 5.39725f, 1.25496f);
            f952.AddVertex(-0.67723f, 6.04158f, 1.01383f);
            f952.AddVertex(-0.59538f, 5.98222f, 1.10875f);
            faces.Add(f952);

            Face f953 = new Face(m02___Default);
            f953.AddVertex(-0.43299f, 5.53980f, 1.28707f);
            f953.AddVertex(-0.41745f, 5.39725f, 1.25496f);
            f953.AddVertex(-0.54023f, 5.89737f, 1.17775f);
            f953.AddVertex(-0.46153f, 5.68158f, 1.27500f);
            faces.Add(f953);

            Face f954 = new Face(m02___Default);
            f954.AddVertex(-0.54023f, 5.89737f, 1.17775f);
            f954.AddVertex(-0.50065f, 5.80610f, 1.22836f);
            f954.AddVertex(-0.46153f, 5.68158f, 1.27500f);
            faces.Add(f954);

            Face f955 = new Face(m02___Default);
            f955.AddVertex(-0.86027f, 5.79042f, 0.83489f);
            f955.AddVertex(-0.83477f, 5.79637f, 0.80999f);
            f955.AddVertex(-0.81716f, 5.69940f, 0.80284f);
            f955.AddVertex(-0.84266f, 5.69345f, 0.82774f);
            faces.Add(f955);

            Face f956 = new Face(m02___Default);
            f956.AddVertex(-0.88710f, 5.92437f, 0.84297f);
            f956.AddVertex(-0.86159f, 5.93033f, 0.81806f);
            f956.AddVertex(-0.85788f, 5.86228f, 0.80670f);
            f956.AddVertex(-0.88338f, 5.85632f, 0.83160f);
            faces.Add(f956);

            Face f957 = new Face(m02___Default);
            f957.AddVertex(-0.81264f, 6.01673f, 0.92244f);
            f957.AddVertex(-0.78713f, 6.02268f, 0.89753f);
            f957.AddVertex(-0.82820f, 5.98076f, 0.85413f);
            f957.AddVertex(-0.85362f, 5.97493f, 0.87912f);
            faces.Add(f957);

            Face f958 = new Face(m02___Default);
            f958.AddVertex(-0.70182f, 6.03518f, 1.03971f);
            f958.AddVertex(-0.67723f, 6.04158f, 1.01383f);
            f958.AddVertex(-0.73381f, 6.04297f, 0.95229f);
            f958.AddVertex(-0.75931f, 6.03702f, 0.97719f);
            faces.Add(f958);

            Face f959 = new Face(m02___Default);
            f959.AddVertex(-0.56573f, 5.89142f, 1.20264f);
            f959.AddVertex(-0.54023f, 5.89737f, 1.17775f);
            f959.AddVertex(-0.59538f, 5.98222f, 1.10875f);
            f959.AddVertex(-0.62088f, 5.97627f, 1.13366f);
            faces.Add(f959);

            Face f960 = new Face(m02___Default);
            f960.AddVertex(-0.48702f, 5.67563f, 1.29990f);
            f960.AddVertex(-0.46153f, 5.68158f, 1.27500f);
            f960.AddVertex(-0.50065f, 5.80610f, 1.22836f);
            f960.AddVertex(-0.52615f, 5.80015f, 1.25326f);
            faces.Add(f960);

            Face f961 = new Face(m02___Default);
            f961.AddVertex(-0.44296f, 5.39129f, 1.27986f);
            f961.AddVertex(-0.41745f, 5.39725f, 1.25496f);
            f961.AddVertex(-0.43299f, 5.53980f, 1.28707f);
            f961.AddVertex(-0.45849f, 5.53385f, 1.31197f);
            faces.Add(f961);

            Face f962 = new Face(m02___Default);
            f962.AddVertex(-0.46672f, 5.15700f, 1.11284f);
            f962.AddVertex(-0.44123f, 5.16295f, 1.08794f);
            f962.AddVertex(-0.41291f, 5.26767f, 1.19885f);
            f962.AddVertex(-0.43841f, 5.26172f, 1.22376f);
            faces.Add(f962);

            Face f963 = new Face(m02___Default);
            f963.AddVertex(-0.55644f, 5.11517f, 0.96111f);
            f963.AddVertex(-0.53095f, 5.12112f, 0.93621f);
            f963.AddVertex(-0.48014f, 5.11499f, 1.00423f);
            f963.AddVertex(-0.50564f, 5.10904f, 1.02913f);
            faces.Add(f963);

            Face f964 = new Face(m02___Default);
            f964.AddVertex(-0.71644f, 5.26189f, 0.83473f);
            f964.AddVertex(-0.69094f, 5.26785f, 0.80983f);
            f964.AddVertex(-0.58600f, 5.14106f, 0.87856f);
            f964.AddVertex(-0.61150f, 5.13511f, 0.90346f);
            faces.Add(f964);

            Face f965 = new Face(m02___Default);
            f965.AddVertex(-0.84266f, 5.69345f, 0.82774f);
            f965.AddVertex(-0.81716f, 5.69940f, 0.80284f);
            f965.AddVertex(-0.80699f, 5.62961f, 0.79583f);
            f965.AddVertex(-0.83249f, 5.62365f, 0.82073f);
            faces.Add(f965);

            Face f966 = new Face(m02___Default);
            f966.AddVertex(-0.88338f, 5.85632f, 0.83160f);
            f966.AddVertex(-0.85788f, 5.86228f, 0.80670f);
            f966.AddVertex(-0.83477f, 5.79637f, 0.80999f);
            f966.AddVertex(-0.86027f, 5.79042f, 0.83489f);
            faces.Add(f966);

            Face f967 = new Face(m02___Default);
            f967.AddVertex(-0.85362f, 5.97493f, 0.87912f);
            f967.AddVertex(-0.82820f, 5.98076f, 0.85413f);
            f967.AddVertex(-0.86159f, 5.93033f, 0.81806f);
            f967.AddVertex(-0.88710f, 5.92437f, 0.84297f);
            faces.Add(f967);

            Face f968 = new Face(m02___Default);
            f968.AddVertex(-0.75931f, 6.03702f, 0.97719f);
            f968.AddVertex(-0.73381f, 6.04297f, 0.95229f);
            f968.AddVertex(-0.78713f, 6.02268f, 0.89753f);
            f968.AddVertex(-0.81264f, 6.01673f, 0.92244f);
            faces.Add(f968);

            Face f969 = new Face(m02___Default);
            f969.AddVertex(-0.62088f, 5.97627f, 1.13366f);
            f969.AddVertex(-0.59538f, 5.98222f, 1.10875f);
            f969.AddVertex(-0.67723f, 6.04158f, 1.01383f);
            f969.AddVertex(-0.70182f, 6.03518f, 1.03971f);
            faces.Add(f969);

            Face f970 = new Face(m02___Default);
            f970.AddVertex(-0.52615f, 5.80015f, 1.25326f);
            f970.AddVertex(-0.50065f, 5.80610f, 1.22836f);
            f970.AddVertex(-0.54023f, 5.89737f, 1.17775f);
            f970.AddVertex(-0.56573f, 5.89142f, 1.20264f);
            faces.Add(f970);

            Face f971 = new Face(m02___Default);
            f971.AddVertex(-0.45849f, 5.53385f, 1.31197f);
            f971.AddVertex(-0.43299f, 5.53980f, 1.28707f);
            f971.AddVertex(-0.46153f, 5.68158f, 1.27500f);
            f971.AddVertex(-0.48702f, 5.67563f, 1.29990f);
            faces.Add(f971);

            Face f972 = new Face(m02___Default);
            f972.AddVertex(-0.43841f, 5.26172f, 1.22376f);
            f972.AddVertex(-0.41291f, 5.26767f, 1.19885f);
            f972.AddVertex(-0.41745f, 5.39725f, 1.25496f);
            f972.AddVertex(-0.44296f, 5.39129f, 1.27986f);
            faces.Add(f972);

            Face f973 = new Face(m02___Default);
            f973.AddVertex(-0.50564f, 5.10904f, 1.02913f);
            f973.AddVertex(-0.48014f, 5.11499f, 1.00423f);
            f973.AddVertex(-0.44123f, 5.16295f, 1.08794f);
            f973.AddVertex(-0.46672f, 5.15700f, 1.11284f);
            faces.Add(f973);

            Face f974 = new Face(m02___Default);
            f974.AddVertex(-0.61150f, 5.13511f, 0.90346f);
            f974.AddVertex(-0.58600f, 5.14106f, 0.87856f);
            f974.AddVertex(-0.53095f, 5.12112f, 0.93621f);
            f974.AddVertex(-0.55644f, 5.11517f, 0.96111f);
            faces.Add(f974);

            Face f975 = new Face(m02___Default);
            f975.AddVertex(-0.85577f, 5.38535f, 0.72392f);
            f975.AddVertex(-0.88982f, 5.19144f, 0.67683f);
            f975.AddVertex(-0.89506f, 5.18998f, 0.68110f);
            f975.AddVertex(-0.86038f, 5.38433f, 0.72783f);
            faces.Add(f975);

            Face f976 = new Face(m02___Default);
            f976.AddVertex(-0.88982f, 5.19144f, 0.67683f);
            f976.AddVertex(-0.84149f, 5.10858f, 0.71207f);
            f976.AddVertex(-0.84699f, 5.10695f, 0.71647f);
            f976.AddVertex(-0.89506f, 5.18998f, 0.68110f);
            faces.Add(f976);

            Face f977 = new Face(m02___Default);
            f977.AddVertex(-0.84149f, 5.10858f, 0.71207f);
            f977.AddVertex(-0.79562f, 5.02429f, 0.75770f);
            f977.AddVertex(-0.80117f, 5.02263f, 0.76213f);
            f977.AddVertex(-0.84699f, 5.10695f, 0.71647f);
            faces.Add(f977);

            Face f978 = new Face(m02___Default);
            f978.AddVertex(-0.79562f, 5.02429f, 0.75770f);
            f978.AddVertex(-0.74729f, 4.94822f, 0.80543f);
            f978.AddVertex(-0.75266f, 4.94667f, 0.80977f);
            f978.AddVertex(-0.80117f, 5.02263f, 0.76213f);
            faces.Add(f978);

            Face f979 = new Face(m02___Default);
            f979.AddVertex(-0.74729f, 4.94822f, 0.80543f);
            f979.AddVertex(-0.69809f, 4.88712f, 0.85149f);
            f979.AddVertex(-0.70318f, 4.88577f, 0.85566f);
            f979.AddVertex(-0.75266f, 4.94667f, 0.80977f);
            faces.Add(f979);

            Face f980 = new Face(m02___Default);
            f980.AddVertex(-0.69809f, 4.88712f, 0.85149f);
            f980.AddVertex(-0.65258f, 4.84464f, 0.89518f);
            f980.AddVertex(-0.65742f, 4.84347f, 0.89921f);
            f980.AddVertex(-0.70318f, 4.88577f, 0.85566f);
            faces.Add(f980);

            Face f981 = new Face(m02___Default);
            f981.AddVertex(-0.65258f, 4.84464f, 0.89518f);
            f981.AddVertex(-0.61376f, 4.82245f, 0.93621f);
            f981.AddVertex(-0.61844f, 4.82138f, 0.94015f);
            f981.AddVertex(-0.65742f, 4.84347f, 0.89921f);
            faces.Add(f981);

            Face f982 = new Face(m02___Default);
            f982.AddVertex(-0.61376f, 4.82245f, 0.93621f);
            f982.AddVertex(-0.58161f, 4.82072f, 0.97328f);
            f982.AddVertex(-0.58623f, 4.81970f, 0.97719f);
            f982.AddVertex(-0.61844f, 4.82138f, 0.94015f);
            faces.Add(f982);

            Face f983 = new Face(m02___Default);
            f983.AddVertex(-0.58161f, 4.82072f, 0.97328f);
            f983.AddVertex(-0.55410f, 4.83826f, 1.00401f);
            f983.AddVertex(-0.55872f, 4.83724f, 1.00792f);
            f983.AddVertex(-0.58623f, 4.81970f, 0.97719f);
            faces.Add(f983);

            Face f984 = new Face(m02___Default);
            f984.AddVertex(-0.55410f, 4.83826f, 1.00401f);
            f984.AddVertex(-0.52877f, 4.87291f, 1.02535f);
            f984.AddVertex(-0.53341f, 4.87187f, 1.02926f);
            f984.AddVertex(-0.55872f, 4.83724f, 1.00792f);
            faces.Add(f984);

            Face f985 = new Face(m02___Default);
            f985.AddVertex(-0.52877f, 4.87291f, 1.02535f);
            f985.AddVertex(-0.50388f, 4.92204f, 1.03416f);
            f985.AddVertex(-0.50853f, 4.92099f, 1.03809f);
            f985.AddVertex(-0.53341f, 4.87187f, 1.02926f);
            faces.Add(f985);

            Face f986 = new Face(m02___Default);
            f986.AddVertex(-0.50388f, 4.92204f, 1.03416f);
            f986.AddVertex(-0.47914f, 4.98272f, 1.02809f);
            f986.AddVertex(-0.48379f, 4.98167f, 1.03202f);
            f986.AddVertex(-0.50853f, 4.92099f, 1.03809f);
            faces.Add(f986);

            Face f987 = new Face(m02___Default);
            f987.AddVertex(-0.47914f, 4.98272f, 1.02809f);
            f987.AddVertex(-0.45620f, 5.05162f, 1.00643f);
            f987.AddVertex(-0.46084f, 5.05058f, 1.01035f);
            f987.AddVertex(-0.48379f, 4.98167f, 1.03202f);
            faces.Add(f987);

            Face f988 = new Face(m02___Default);
            f988.AddVertex(-0.45620f, 5.05162f, 1.00643f);
            f988.AddVertex(-0.43895f, 5.12495f, 0.97118f);
            f988.AddVertex(-0.44358f, 5.12392f, 0.97509f);
            f988.AddVertex(-0.46084f, 5.05058f, 1.01035f);
            faces.Add(f988);

            Face f989 = new Face(m02___Default);
            f989.AddVertex(-0.43895f, 5.12495f, 0.97118f);
            f989.AddVertex(-0.43415f, 5.19865f, 0.92799f);
            f989.AddVertex(-0.43878f, 5.19762f, 0.93190f);
            f989.AddVertex(-0.44358f, 5.12392f, 0.97509f);
            faces.Add(f989);

            Face f990 = new Face(m02___Default);
            f990.AddVertex(-0.43415f, 5.19865f, 0.92799f);
            f990.AddVertex(-0.45185f, 5.26863f, 0.88654f);
            f990.AddVertex(-0.45647f, 5.26761f, 0.89045f);
            f990.AddVertex(-0.43878f, 5.19762f, 0.93190f);
            faces.Add(f990);

            Face f991 = new Face(m02___Default);
            f991.AddVertex(-0.45185f, 5.26863f, 0.88654f);
            f991.AddVertex(-0.72177f, 5.40499f, 0.77885f);
            f991.AddVertex(-0.72639f, 5.40396f, 0.78275f);
            f991.AddVertex(-0.45647f, 5.26761f, 0.89045f);
            faces.Add(f991);

            Face f992 = new Face(m02___Default);
            f992.AddVertex(-0.72177f, 5.40499f, 0.77885f);
            f992.AddVertex(-0.78540f, 5.39964f, 0.74934f);
            f992.AddVertex(-0.79002f, 5.39862f, 0.75325f);
            f992.AddVertex(-0.72639f, 5.40396f, 0.78275f);
            faces.Add(f992);

            Face f993 = new Face(m02___Default);
            f993.AddVertex(-0.78540f, 5.39964f, 0.74934f);
            f993.AddVertex(-0.85577f, 5.38535f, 0.72392f);
            f993.AddVertex(-0.86038f, 5.38433f, 0.72783f);
            f993.AddVertex(-0.79002f, 5.39862f, 0.75325f);
            faces.Add(f993);

            Face f994 = new Face(m02___Default);
            f994.AddVertex(-0.86038f, 5.38433f, 0.72783f);
            f994.AddVertex(-0.89506f, 5.18998f, 0.68110f);
            f994.AddVertex(-0.90034f, 5.18850f, 0.68537f);
            f994.AddVertex(-0.86500f, 5.38331f, 0.73174f);
            faces.Add(f994);

            Face f995 = new Face(m02___Default);
            f995.AddVertex(-0.89506f, 5.18998f, 0.68110f);
            f995.AddVertex(-0.84699f, 5.10695f, 0.71647f);
            f995.AddVertex(-0.85253f, 5.10530f, 0.72089f);
            f995.AddVertex(-0.90034f, 5.18850f, 0.68537f);
            faces.Add(f995);

            Face f996 = new Face(m02___Default);
            f996.AddVertex(-0.84699f, 5.10695f, 0.71647f);
            f996.AddVertex(-0.80117f, 5.02263f, 0.76213f);
            f996.AddVertex(-0.80675f, 5.02094f, 0.76658f);
            f996.AddVertex(-0.85253f, 5.10530f, 0.72089f);
            faces.Add(f996);

            Face f997 = new Face(m02___Default);
            f997.AddVertex(-0.80117f, 5.02263f, 0.76213f);
            f997.AddVertex(-0.75266f, 4.94667f, 0.80977f);
            f997.AddVertex(-0.75806f, 4.94511f, 0.81411f);
            f997.AddVertex(-0.80675f, 5.02094f, 0.76658f);
            faces.Add(f997);

            Face f998 = new Face(m02___Default);
            f998.AddVertex(-0.75266f, 4.94667f, 0.80977f);
            f998.AddVertex(-0.70318f, 4.88577f, 0.85566f);
            f998.AddVertex(-0.70828f, 4.88442f, 0.85984f);
            f998.AddVertex(-0.75806f, 4.94511f, 0.81411f);
            faces.Add(f998);

            Face f999 = new Face(m02___Default);
            f999.AddVertex(-0.70318f, 4.88577f, 0.85566f);
            f999.AddVertex(-0.65742f, 4.84347f, 0.89921f);
            f999.AddVertex(-0.66226f, 4.84229f, 0.90324f);
            f999.AddVertex(-0.70828f, 4.88442f, 0.85984f);
            faces.Add(f999);

            Face f1000 = new Face(m02___Default);
            f1000.AddVertex(-0.65742f, 4.84347f, 0.89921f);
            f1000.AddVertex(-0.61844f, 4.82138f, 0.94015f);
            f1000.AddVertex(-0.62312f, 4.82031f, 0.94409f);
            f1000.AddVertex(-0.66226f, 4.84229f, 0.90324f);
            faces.Add(f1000);

            Face f1001 = new Face(m02___Default);
            f1001.AddVertex(-0.61844f, 4.82138f, 0.94015f);
            f1001.AddVertex(-0.58623f, 4.81970f, 0.97719f);
            f1001.AddVertex(-0.59085f, 4.81868f, 0.98110f);
            f1001.AddVertex(-0.62312f, 4.82031f, 0.94409f);
            faces.Add(f1001);

            Face f1002 = new Face(m02___Default);
            f1002.AddVertex(-0.58623f, 4.81970f, 0.97719f);
            f1002.AddVertex(-0.55872f, 4.83724f, 1.00792f);
            f1002.AddVertex(-0.56334f, 4.83621f, 1.01183f);
            f1002.AddVertex(-0.59085f, 4.81868f, 0.98110f);
            faces.Add(f1002);

            Face f1003 = new Face(m02___Default);
            f1003.AddVertex(-0.55872f, 4.83724f, 1.00792f);
            f1003.AddVertex(-0.53341f, 4.87187f, 1.02926f);
            f1003.AddVertex(-0.53805f, 4.87083f, 1.03318f);
            f1003.AddVertex(-0.56334f, 4.83621f, 1.01183f);
            faces.Add(f1003);

            Face f1004 = new Face(m02___Default);
            f1004.AddVertex(-0.53341f, 4.87187f, 1.02926f);
            f1004.AddVertex(-0.50853f, 4.92099f, 1.03809f);
            f1004.AddVertex(-0.51318f, 4.91994f, 1.04201f);
            f1004.AddVertex(-0.53805f, 4.87083f, 1.03318f);
            faces.Add(f1004);

            Face f1005 = new Face(m02___Default);
            f1005.AddVertex(-0.50853f, 4.92099f, 1.03809f);
            f1005.AddVertex(-0.48379f, 4.98167f, 1.03202f);
            f1005.AddVertex(-0.48845f, 4.98063f, 1.03594f);
            f1005.AddVertex(-0.51318f, 4.91994f, 1.04201f);
            faces.Add(f1005);

            Face f1006 = new Face(m02___Default);
            f1006.AddVertex(-0.48379f, 4.98167f, 1.03202f);
            f1006.AddVertex(-0.46084f, 5.05058f, 1.01035f);
            f1006.AddVertex(-0.46548f, 5.04954f, 1.01427f);
            f1006.AddVertex(-0.48845f, 4.98063f, 1.03594f);
            faces.Add(f1006);

            Face f1007 = new Face(m02___Default);
            f1007.AddVertex(-0.46084f, 5.05058f, 1.01035f);
            f1007.AddVertex(-0.44358f, 5.12392f, 0.97509f);
            f1007.AddVertex(-0.44820f, 5.12289f, 0.97900f);
            f1007.AddVertex(-0.46548f, 5.04954f, 1.01427f);
            faces.Add(f1007);

            Face f1008 = new Face(m02___Default);
            f1008.AddVertex(-0.44358f, 5.12392f, 0.97509f);
            f1008.AddVertex(-0.43878f, 5.19762f, 0.93190f);
            f1008.AddVertex(-0.44339f, 5.19660f, 0.93580f);
            f1008.AddVertex(-0.44820f, 5.12289f, 0.97900f);
            faces.Add(f1008);

            Face f1009 = new Face(m02___Default);
            f1009.AddVertex(-0.43878f, 5.19762f, 0.93190f);
            f1009.AddVertex(-0.45647f, 5.26761f, 0.89045f);
            f1009.AddVertex(-0.46109f, 5.26658f, 0.89436f);
            f1009.AddVertex(-0.44339f, 5.19660f, 0.93580f);
            faces.Add(f1009);

            Face f1010 = new Face(m02___Default);
            f1010.AddVertex(-0.45647f, 5.26761f, 0.89045f);
            f1010.AddVertex(-0.72639f, 5.40396f, 0.78275f);
            f1010.AddVertex(-0.73101f, 5.40294f, 0.78666f);
            f1010.AddVertex(-0.46109f, 5.26658f, 0.89436f);
            faces.Add(f1010);

            Face f1011 = new Face(m02___Default);
            f1011.AddVertex(-0.72639f, 5.40396f, 0.78275f);
            f1011.AddVertex(-0.79002f, 5.39862f, 0.75325f);
            f1011.AddVertex(-0.79464f, 5.39759f, 0.75716f);
            f1011.AddVertex(-0.73101f, 5.40294f, 0.78666f);
            faces.Add(f1011);

            Face f1012 = new Face(m02___Default);
            f1012.AddVertex(-0.79002f, 5.39862f, 0.75325f);
            f1012.AddVertex(-0.86038f, 5.38433f, 0.72783f);
            f1012.AddVertex(-0.86500f, 5.38331f, 0.73174f);
            f1012.AddVertex(-0.79464f, 5.39759f, 0.75716f);
            faces.Add(f1012);

            Face f1013 = new Face(m02___Default);
            f1013.AddVertex(-0.86500f, 5.38331f, 0.73174f);
            f1013.AddVertex(-0.90034f, 5.18850f, 0.68537f);
            f1013.AddVertex(-0.90565f, 5.18700f, 0.68966f);
            f1013.AddVertex(-0.86962f, 5.38228f, 0.73564f);
            faces.Add(f1013);

            Face f1014 = new Face(m02___Default);
            f1014.AddVertex(-0.90034f, 5.18850f, 0.68537f);
            f1014.AddVertex(-0.85253f, 5.10530f, 0.72089f);
            f1014.AddVertex(-0.85810f, 5.10362f, 0.72533f);
            f1014.AddVertex(-0.90565f, 5.18700f, 0.68966f);
            faces.Add(f1014);

            Face f1015 = new Face(m02___Default);
            f1015.AddVertex(-0.85253f, 5.10530f, 0.72089f);
            f1015.AddVertex(-0.80675f, 5.02094f, 0.76658f);
            f1015.AddVertex(-0.81235f, 5.01923f, 0.77104f);
            f1015.AddVertex(-0.85810f, 5.10362f, 0.72533f);
            faces.Add(f1015);

            Face f1016 = new Face(m02___Default);
            f1016.AddVertex(-0.80675f, 5.02094f, 0.76658f);
            f1016.AddVertex(-0.75806f, 4.94511f, 0.81411f);
            f1016.AddVertex(-0.76348f, 4.94354f, 0.81846f);
            f1016.AddVertex(-0.81235f, 5.01923f, 0.77104f);
            faces.Add(f1016);

            Face f1017 = new Face(m02___Default);
            f1017.AddVertex(-0.75806f, 4.94511f, 0.81411f);
            f1017.AddVertex(-0.70828f, 4.88442f, 0.85984f);
            f1017.AddVertex(-0.71339f, 4.88305f, 0.86403f);
            f1017.AddVertex(-0.76348f, 4.94354f, 0.81846f);
            faces.Add(f1017);

            Face f1018 = new Face(m02___Default);
            f1018.AddVertex(-0.70828f, 4.88442f, 0.85984f);
            f1018.AddVertex(-0.66226f, 4.84229f, 0.90324f);
            f1018.AddVertex(-0.66711f, 4.84110f, 0.90728f);
            f1018.AddVertex(-0.71339f, 4.88305f, 0.86403f);
            faces.Add(f1018);

            Face f1019 = new Face(m02___Default);
            f1019.AddVertex(-0.66226f, 4.84229f, 0.90324f);
            f1019.AddVertex(-0.62312f, 4.82031f, 0.94409f);
            f1019.AddVertex(-0.62781f, 4.81924f, 0.94804f);
            f1019.AddVertex(-0.66711f, 4.84110f, 0.90728f);
            faces.Add(f1019);

            Face f1020 = new Face(m02___Default);
            f1020.AddVertex(-0.62312f, 4.82031f, 0.94409f);
            f1020.AddVertex(-0.59085f, 4.81868f, 0.98110f);
            f1020.AddVertex(-0.59546f, 4.81765f, 0.98500f);
            f1020.AddVertex(-0.62781f, 4.81924f, 0.94804f);
            faces.Add(f1020);

            Face f1021 = new Face(m02___Default);
            f1021.AddVertex(-0.59085f, 4.81868f, 0.98110f);
            f1021.AddVertex(-0.56334f, 4.83621f, 1.01183f);
            f1021.AddVertex(-0.56796f, 4.83519f, 1.01574f);
            f1021.AddVertex(-0.59546f, 4.81765f, 0.98500f);
            faces.Add(f1021);

            Face f1022 = new Face(m02___Default);
            f1022.AddVertex(-0.56334f, 4.83621f, 1.01183f);
            f1022.AddVertex(-0.53805f, 4.87083f, 1.03318f);
            f1022.AddVertex(-0.54269f, 4.86979f, 1.03711f);
            f1022.AddVertex(-0.56796f, 4.83519f, 1.01574f);
            faces.Add(f1022);

            Face f1023 = new Face(m02___Default);
            f1023.AddVertex(-0.53805f, 4.87083f, 1.03318f);
            f1023.AddVertex(-0.51318f, 4.91994f, 1.04201f);
            f1023.AddVertex(-0.51784f, 4.91889f, 1.04594f);
            f1023.AddVertex(-0.54269f, 4.86979f, 1.03711f);
            faces.Add(f1023);

            Face f1024 = new Face(m02___Default);
            f1024.AddVertex(-0.51318f, 4.91994f, 1.04201f);
            f1024.AddVertex(-0.48845f, 4.98063f, 1.03594f);
            f1024.AddVertex(-0.49310f, 4.97958f, 1.03987f);
            f1024.AddVertex(-0.51784f, 4.91889f, 1.04594f);
            faces.Add(f1024);

            Face f1025 = new Face(m02___Default);
            f1025.AddVertex(-0.48845f, 4.98063f, 1.03594f);
            f1025.AddVertex(-0.46548f, 5.04954f, 1.01427f);
            f1025.AddVertex(-0.47011f, 5.04851f, 1.01819f);
            f1025.AddVertex(-0.49310f, 4.97958f, 1.03987f);
            faces.Add(f1025);

            Face f1026 = new Face(m02___Default);
            f1026.AddVertex(-0.46548f, 5.04954f, 1.01427f);
            f1026.AddVertex(-0.44820f, 5.12289f, 0.97900f);
            f1026.AddVertex(-0.45282f, 5.12187f, 0.98291f);
            f1026.AddVertex(-0.47011f, 5.04851f, 1.01819f);
            faces.Add(f1026);

            Face f1027 = new Face(m02___Default);
            f1027.AddVertex(-0.44820f, 5.12289f, 0.97900f);
            f1027.AddVertex(-0.44339f, 5.19660f, 0.93580f);
            f1027.AddVertex(-0.44801f, 5.19557f, 0.93972f);
            f1027.AddVertex(-0.45282f, 5.12187f, 0.98291f);
            faces.Add(f1027);

            Face f1028 = new Face(m02___Default);
            f1028.AddVertex(-0.44339f, 5.19660f, 0.93580f);
            f1028.AddVertex(-0.46109f, 5.26658f, 0.89436f);
            f1028.AddVertex(-0.46571f, 5.26556f, 0.89826f);
            f1028.AddVertex(-0.44801f, 5.19557f, 0.93972f);
            faces.Add(f1028);

            Face f1029 = new Face(m02___Default);
            f1029.AddVertex(-0.46109f, 5.26658f, 0.89436f);
            f1029.AddVertex(-0.73101f, 5.40294f, 0.78666f);
            f1029.AddVertex(-0.73563f, 5.40191f, 0.79057f);
            f1029.AddVertex(-0.46571f, 5.26556f, 0.89826f);
            faces.Add(f1029);

            Face f1030 = new Face(m02___Default);
            f1030.AddVertex(-0.73101f, 5.40294f, 0.78666f);
            f1030.AddVertex(-0.79464f, 5.39759f, 0.75716f);
            f1030.AddVertex(-0.79926f, 5.39657f, 0.76107f);
            f1030.AddVertex(-0.73563f, 5.40191f, 0.79057f);
            faces.Add(f1030);

            Face f1031 = new Face(m02___Default);
            f1031.AddVertex(-0.79464f, 5.39759f, 0.75716f);
            f1031.AddVertex(-0.86500f, 5.38331f, 0.73174f);
            f1031.AddVertex(-0.86962f, 5.38228f, 0.73564f);
            f1031.AddVertex(-0.79926f, 5.39657f, 0.76107f);
            faces.Add(f1031);

            Face f1032 = new Face(m02___Default);
            f1032.AddVertex(-0.86962f, 5.38228f, 0.73564f);
            f1032.AddVertex(-0.90565f, 5.18700f, 0.68966f);
            f1032.AddVertex(-0.91099f, 5.18548f, 0.69398f);
            f1032.AddVertex(-0.87424f, 5.38125f, 0.73955f);
            faces.Add(f1032);

            Face f1033 = new Face(m02___Default);
            f1033.AddVertex(-0.90565f, 5.18700f, 0.68966f);
            f1033.AddVertex(-0.85810f, 5.10362f, 0.72533f);
            f1033.AddVertex(-0.86370f, 5.10192f, 0.72979f);
            f1033.AddVertex(-0.91099f, 5.18548f, 0.69398f);
            faces.Add(f1033);

            Face f1034 = new Face(m02___Default);
            f1034.AddVertex(-0.85810f, 5.10362f, 0.72533f);
            f1034.AddVertex(-0.81235f, 5.01923f, 0.77104f);
            f1034.AddVertex(-0.81800f, 5.01751f, 0.77552f);
            f1034.AddVertex(-0.86370f, 5.10192f, 0.72979f);
            faces.Add(f1034);

            Face f1035 = new Face(m02___Default);
            f1035.AddVertex(-0.81235f, 5.01923f, 0.77104f);
            f1035.AddVertex(-0.76348f, 4.94354f, 0.81846f);
            f1035.AddVertex(-0.76891f, 4.94195f, 0.82284f);
            f1035.AddVertex(-0.81800f, 5.01751f, 0.77552f);
            faces.Add(f1035);

            Face f1036 = new Face(m02___Default);
            f1036.AddVertex(-0.76348f, 4.94354f, 0.81846f);
            f1036.AddVertex(-0.71339f, 4.88305f, 0.86403f);
            f1036.AddVertex(-0.71853f, 4.88167f, 0.86822f);
            f1036.AddVertex(-0.76891f, 4.94195f, 0.82284f);
            faces.Add(f1036);

            Face f1037 = new Face(m02___Default);
            f1037.AddVertex(-0.71339f, 4.88305f, 0.86403f);
            f1037.AddVertex(-0.66711f, 4.84110f, 0.90728f);
            f1037.AddVertex(-0.67196f, 4.83992f, 0.91132f);
            f1037.AddVertex(-0.71853f, 4.88167f, 0.86822f);
            faces.Add(f1037);

            Face f1038 = new Face(m02___Default);
            f1038.AddVertex(-0.66711f, 4.84110f, 0.90728f);
            f1038.AddVertex(-0.62781f, 4.81924f, 0.94804f);
            f1038.AddVertex(-0.63249f, 4.81817f, 0.95198f);
            f1038.AddVertex(-0.67196f, 4.83992f, 0.91132f);
            faces.Add(f1038);

            Face f1039 = new Face(m02___Default);
            f1039.AddVertex(-0.62781f, 4.81924f, 0.94804f);
            f1039.AddVertex(-0.59546f, 4.81765f, 0.98500f);
            f1039.AddVertex(-0.60008f, 4.81662f, 0.98891f);
            f1039.AddVertex(-0.63249f, 4.81817f, 0.95198f);
            faces.Add(f1039);

            Face f1040 = new Face(m02___Default);
            f1040.AddVertex(-0.59546f, 4.81765f, 0.98500f);
            f1040.AddVertex(-0.56796f, 4.83519f, 1.01574f);
            f1040.AddVertex(-0.57257f, 4.83416f, 1.01965f);
            f1040.AddVertex(-0.60008f, 4.81662f, 0.98891f);
            faces.Add(f1040);

            Face f1041 = new Face(m02___Default);
            f1041.AddVertex(-0.56796f, 4.83519f, 1.01574f);
            f1041.AddVertex(-0.54269f, 4.86979f, 1.03711f);
            f1041.AddVertex(-0.54733f, 4.86875f, 1.04102f);
            f1041.AddVertex(-0.57257f, 4.83416f, 1.01965f);
            faces.Add(f1041);

            Face f1042 = new Face(m02___Default);
            f1042.AddVertex(-0.54269f, 4.86979f, 1.03711f);
            f1042.AddVertex(-0.51784f, 4.91889f, 1.04594f);
            f1042.AddVertex(-0.52249f, 4.91784f, 1.04987f);
            f1042.AddVertex(-0.54733f, 4.86875f, 1.04102f);
            faces.Add(f1042);

            Face f1043 = new Face(m02___Default);
            f1043.AddVertex(-0.51784f, 4.91889f, 1.04594f);
            f1043.AddVertex(-0.49310f, 4.97958f, 1.03987f);
            f1043.AddVertex(-0.49774f, 4.97853f, 1.04379f);
            f1043.AddVertex(-0.52249f, 4.91784f, 1.04987f);
            faces.Add(f1043);

            Face f1044 = new Face(m02___Default);
            f1044.AddVertex(-0.49310f, 4.97958f, 1.03987f);
            f1044.AddVertex(-0.47011f, 5.04851f, 1.01819f);
            f1044.AddVertex(-0.47475f, 5.04747f, 1.02210f);
            f1044.AddVertex(-0.49774f, 4.97853f, 1.04379f);
            faces.Add(f1044);

            Face f1045 = new Face(m02___Default);
            f1045.AddVertex(-0.47011f, 5.04851f, 1.01819f);
            f1045.AddVertex(-0.45282f, 5.12187f, 0.98291f);
            f1045.AddVertex(-0.45745f, 5.12083f, 0.98682f);
            f1045.AddVertex(-0.47475f, 5.04747f, 1.02210f);
            faces.Add(f1045);

            Face f1046 = new Face(m02___Default);
            f1046.AddVertex(-0.45282f, 5.12187f, 0.98291f);
            f1046.AddVertex(-0.44801f, 5.19557f, 0.93972f);
            f1046.AddVertex(-0.45263f, 5.19455f, 0.94362f);
            f1046.AddVertex(-0.45745f, 5.12083f, 0.98682f);
            faces.Add(f1046);

            Face f1047 = new Face(m02___Default);
            f1047.AddVertex(-0.44801f, 5.19557f, 0.93972f);
            f1047.AddVertex(-0.46571f, 5.26556f, 0.89826f);
            f1047.AddVertex(-0.47033f, 5.26453f, 0.90217f);
            f1047.AddVertex(-0.45263f, 5.19455f, 0.94362f);
            faces.Add(f1047);

            Face f1048 = new Face(m02___Default);
            f1048.AddVertex(-0.46571f, 5.26556f, 0.89826f);
            f1048.AddVertex(-0.73563f, 5.40191f, 0.79057f);
            f1048.AddVertex(-0.74025f, 5.40089f, 0.79448f);
            f1048.AddVertex(-0.47033f, 5.26453f, 0.90217f);
            faces.Add(f1048);

            Face f1049 = new Face(m02___Default);
            f1049.AddVertex(-0.73563f, 5.40191f, 0.79057f);
            f1049.AddVertex(-0.79926f, 5.39657f, 0.76107f);
            f1049.AddVertex(-0.80388f, 5.39554f, 0.76498f);
            f1049.AddVertex(-0.74025f, 5.40089f, 0.79448f);
            faces.Add(f1049);

            Face f1050 = new Face(m02___Default);
            f1050.AddVertex(-0.79926f, 5.39657f, 0.76107f);
            f1050.AddVertex(-0.86962f, 5.38228f, 0.73564f);
            f1050.AddVertex(-0.87424f, 5.38125f, 0.73955f);
            f1050.AddVertex(-0.80388f, 5.39554f, 0.76498f);
            faces.Add(f1050);

            Face f1051 = new Face(m02___Default);
            f1051.AddVertex(-0.87424f, 5.38125f, 0.73955f);
            f1051.AddVertex(-0.91099f, 5.18548f, 0.69398f);
            f1051.AddVertex(-0.91636f, 5.18394f, 0.69831f);
            f1051.AddVertex(-0.87886f, 5.38023f, 0.74346f);
            faces.Add(f1051);

            Face f1052 = new Face(m02___Default);
            f1052.AddVertex(-0.91099f, 5.18548f, 0.69398f);
            f1052.AddVertex(-0.86370f, 5.10192f, 0.72979f);
            f1052.AddVertex(-0.86934f, 5.10018f, 0.73428f);
            f1052.AddVertex(-0.91636f, 5.18394f, 0.69831f);
            faces.Add(f1052);

            Face f1053 = new Face(m02___Default);
            f1053.AddVertex(-0.86370f, 5.10192f, 0.72979f);
            f1053.AddVertex(-0.81800f, 5.01751f, 0.77552f);
            f1053.AddVertex(-0.82367f, 5.01576f, 0.78002f);
            f1053.AddVertex(-0.86934f, 5.10018f, 0.73428f);
            faces.Add(f1053);

            Face f1054 = new Face(m02___Default);
            f1054.AddVertex(-0.81800f, 5.01751f, 0.77552f);
            f1054.AddVertex(-0.76891f, 4.94195f, 0.82284f);
            f1054.AddVertex(-0.77438f, 4.94034f, 0.82721f);
            f1054.AddVertex(-0.82367f, 5.01576f, 0.78002f);
            faces.Add(f1054);

            Face f1055 = new Face(m02___Default);
            f1055.AddVertex(-0.76891f, 4.94195f, 0.82284f);
            f1055.AddVertex(-0.71853f, 4.88167f, 0.86822f);
            f1055.AddVertex(-0.72367f, 4.88028f, 0.87243f);
            f1055.AddVertex(-0.77438f, 4.94034f, 0.82721f);
            faces.Add(f1055);

            Face f1056 = new Face(m02___Default);
            f1056.AddVertex(-0.71853f, 4.88167f, 0.86822f);
            f1056.AddVertex(-0.67196f, 4.83992f, 0.91132f);
            f1056.AddVertex(-0.67682f, 4.83873f, 0.91536f);
            f1056.AddVertex(-0.72367f, 4.88028f, 0.87243f);
            faces.Add(f1056);

            Face f1057 = new Face(m02___Default);
            f1057.AddVertex(-0.67196f, 4.83992f, 0.91132f);
            f1057.AddVertex(-0.63249f, 4.81817f, 0.95198f);
            f1057.AddVertex(-0.63717f, 4.81710f, 0.95592f);
            f1057.AddVertex(-0.67682f, 4.83873f, 0.91536f);
            faces.Add(f1057);

            Face f1058 = new Face(m02___Default);
            f1058.AddVertex(-0.63249f, 4.81817f, 0.95198f);
            f1058.AddVertex(-0.60008f, 4.81662f, 0.98891f);
            f1058.AddVertex(-0.60470f, 4.81560f, 0.99282f);
            f1058.AddVertex(-0.63717f, 4.81710f, 0.95592f);
            faces.Add(f1058);

            Face f1059 = new Face(m02___Default);
            f1059.AddVertex(-0.60008f, 4.81662f, 0.98891f);
            f1059.AddVertex(-0.57257f, 4.83416f, 1.01965f);
            f1059.AddVertex(-0.57719f, 4.83314f, 1.02356f);
            f1059.AddVertex(-0.60470f, 4.81560f, 0.99282f);
            faces.Add(f1059);

            Face f1060 = new Face(m02___Default);
            f1060.AddVertex(-0.57257f, 4.83416f, 1.01965f);
            f1060.AddVertex(-0.54733f, 4.86875f, 1.04102f);
            f1060.AddVertex(-0.55197f, 4.86770f, 1.04495f);
            f1060.AddVertex(-0.57719f, 4.83314f, 1.02356f);
            faces.Add(f1060);

            Face f1061 = new Face(m02___Default);
            f1061.AddVertex(-0.54733f, 4.86875f, 1.04102f);
            f1061.AddVertex(-0.52249f, 4.91784f, 1.04987f);
            f1061.AddVertex(-0.52715f, 4.91678f, 1.05380f);
            f1061.AddVertex(-0.55197f, 4.86770f, 1.04495f);
            faces.Add(f1061);

            Face f1062 = new Face(m02___Default);
            f1062.AddVertex(-0.52249f, 4.91784f, 1.04987f);
            f1062.AddVertex(-0.49774f, 4.97853f, 1.04379f);
            f1062.AddVertex(-0.50240f, 4.97749f, 1.04772f);
            f1062.AddVertex(-0.52715f, 4.91678f, 1.05380f);
            faces.Add(f1062);

            Face f1063 = new Face(m02___Default);
            f1063.AddVertex(-0.49774f, 4.97853f, 1.04379f);
            f1063.AddVertex(-0.47475f, 5.04747f, 1.02210f);
            f1063.AddVertex(-0.47938f, 5.04643f, 1.02602f);
            f1063.AddVertex(-0.50240f, 4.97749f, 1.04772f);
            faces.Add(f1063);

            Face f1064 = new Face(m02___Default);
            f1064.AddVertex(-0.47475f, 5.04747f, 1.02210f);
            f1064.AddVertex(-0.45745f, 5.12083f, 0.98682f);
            f1064.AddVertex(-0.46207f, 5.11981f, 0.99073f);
            f1064.AddVertex(-0.47938f, 5.04643f, 1.02602f);
            faces.Add(f1064);

            Face f1065 = new Face(m02___Default);
            f1065.AddVertex(-0.45745f, 5.12083f, 0.98682f);
            f1065.AddVertex(-0.45263f, 5.19455f, 0.94362f);
            f1065.AddVertex(-0.45725f, 5.19352f, 0.94753f);
            f1065.AddVertex(-0.46207f, 5.11981f, 0.99073f);
            faces.Add(f1065);

            Face f1066 = new Face(m02___Default);
            f1066.AddVertex(-0.45263f, 5.19455f, 0.94362f);
            f1066.AddVertex(-0.47033f, 5.26453f, 0.90217f);
            f1066.AddVertex(-0.47494f, 5.26351f, 0.90608f);
            f1066.AddVertex(-0.45725f, 5.19352f, 0.94753f);
            faces.Add(f1066);

            Face f1067 = new Face(m02___Default);
            f1067.AddVertex(-0.47033f, 5.26453f, 0.90217f);
            f1067.AddVertex(-0.74025f, 5.40089f, 0.79448f);
            f1067.AddVertex(-0.74486f, 5.39986f, 0.79838f);
            f1067.AddVertex(-0.47494f, 5.26351f, 0.90608f);
            faces.Add(f1067);

            Face f1068 = new Face(m02___Default);
            f1068.AddVertex(-0.74025f, 5.40089f, 0.79448f);
            f1068.AddVertex(-0.80388f, 5.39554f, 0.76498f);
            f1068.AddVertex(-0.80850f, 5.39451f, 0.76889f);
            f1068.AddVertex(-0.74486f, 5.39986f, 0.79838f);
            faces.Add(f1068);

            Face f1069 = new Face(m02___Default);
            f1069.AddVertex(-0.80388f, 5.39554f, 0.76498f);
            f1069.AddVertex(-0.87424f, 5.38125f, 0.73955f);
            f1069.AddVertex(-0.87886f, 5.38023f, 0.74346f);
            f1069.AddVertex(-0.80850f, 5.39451f, 0.76889f);
            faces.Add(f1069);

            Face f1070 = new Face(m02___Default);
            f1070.AddVertex(-0.78540f, 5.39964f, 0.74934f);
            f1070.AddVertex(-0.72177f, 5.40499f, 0.77885f);
            f1070.AddVertex(-0.45185f, 5.26863f, 0.88654f);
            f1070.AddVertex(-0.43895f, 5.12495f, 0.97118f);
            faces.Add(f1070);

            Face f1071 = new Face(m02___Default);
            f1071.AddVertex(-0.45185f, 5.26863f, 0.88654f);
            f1071.AddVertex(-0.43415f, 5.19865f, 0.92799f);
            f1071.AddVertex(-0.43895f, 5.12495f, 0.97118f);
            faces.Add(f1071);

            Face f1072 = new Face(m02___Default);
            f1072.AddVertex(-0.84149f, 5.10858f, 0.71207f);
            f1072.AddVertex(-0.78540f, 5.39964f, 0.74934f);
            f1072.AddVertex(-0.43895f, 5.12495f, 0.97118f);
            f1072.AddVertex(-0.65258f, 4.84464f, 0.89518f);
            faces.Add(f1072);

            Face f1073 = new Face(m02___Default);
            f1073.AddVertex(-0.52877f, 4.87291f, 1.02535f);
            f1073.AddVertex(-0.65258f, 4.84464f, 0.89518f);
            f1073.AddVertex(-0.43895f, 5.12495f, 0.97118f);
            f1073.AddVertex(-0.47914f, 4.98272f, 1.02809f);
            faces.Add(f1073);

            Face f1074 = new Face(m02___Default);
            f1074.AddVertex(-0.43895f, 5.12495f, 0.97118f);
            f1074.AddVertex(-0.45620f, 5.05162f, 1.00643f);
            f1074.AddVertex(-0.47914f, 4.98272f, 1.02809f);
            faces.Add(f1074);

            Face f1075 = new Face(m02___Default);
            f1075.AddVertex(-0.47914f, 4.98272f, 1.02809f);
            f1075.AddVertex(-0.50388f, 4.92204f, 1.03416f);
            f1075.AddVertex(-0.52877f, 4.87291f, 1.02535f);
            faces.Add(f1075);

            Face f1076 = new Face(m02___Default);
            f1076.AddVertex(-0.58161f, 4.82072f, 0.97328f);
            f1076.AddVertex(-0.65258f, 4.84464f, 0.89518f);
            f1076.AddVertex(-0.52877f, 4.87291f, 1.02535f);
            f1076.AddVertex(-0.55410f, 4.83826f, 1.00401f);
            faces.Add(f1076);

            Face f1077 = new Face(m02___Default);
            f1077.AddVertex(-0.58161f, 4.82072f, 0.97328f);
            f1077.AddVertex(-0.61376f, 4.82245f, 0.93621f);
            f1077.AddVertex(-0.65258f, 4.84464f, 0.89518f);
            faces.Add(f1077);

            Face f1078 = new Face(m02___Default);
            f1078.AddVertex(-0.74729f, 4.94822f, 0.80543f);
            f1078.AddVertex(-0.84149f, 5.10858f, 0.71207f);
            f1078.AddVertex(-0.65258f, 4.84464f, 0.89518f);
            f1078.AddVertex(-0.69809f, 4.88712f, 0.85149f);
            faces.Add(f1078);

            Face f1079 = new Face(m02___Default);
            f1079.AddVertex(-0.74729f, 4.94822f, 0.80543f);
            f1079.AddVertex(-0.79562f, 5.02429f, 0.75770f);
            f1079.AddVertex(-0.84149f, 5.10858f, 0.71207f);
            faces.Add(f1079);

            Face f1080 = new Face(m02___Default);
            f1080.AddVertex(-0.78540f, 5.39964f, 0.74934f);
            f1080.AddVertex(-0.84149f, 5.10858f, 0.71207f);
            f1080.AddVertex(-0.88982f, 5.19144f, 0.67683f);
            f1080.AddVertex(-0.85577f, 5.38535f, 0.72392f);
            faces.Add(f1080);

            Face f1081 = new Face(m02___Default);
            f1081.AddVertex(-0.91636f, 5.18394f, 0.69831f);
            f1081.AddVertex(-0.86934f, 5.10018f, 0.73428f);
            f1081.AddVertex(-0.82367f, 5.01576f, 0.78002f);
            f1081.AddVertex(-0.72367f, 4.88028f, 0.87243f);
            faces.Add(f1081);

            Face f1082 = new Face(m02___Default);
            f1082.AddVertex(-0.82367f, 5.01576f, 0.78002f);
            f1082.AddVertex(-0.77438f, 4.94034f, 0.82721f);
            f1082.AddVertex(-0.72367f, 4.88028f, 0.87243f);
            faces.Add(f1082);

            Face f1083 = new Face(m02___Default);
            f1083.AddVertex(-0.74486f, 5.39986f, 0.79838f);
            f1083.AddVertex(-0.91636f, 5.18394f, 0.69831f);
            f1083.AddVertex(-0.72367f, 4.88028f, 0.87243f);
            f1083.AddVertex(-0.47938f, 5.04643f, 1.02602f);
            faces.Add(f1083);

            Face f1084 = new Face(m02___Default);
            f1084.AddVertex(-0.57719f, 4.83314f, 1.02356f);
            f1084.AddVertex(-0.47938f, 5.04643f, 1.02602f);
            f1084.AddVertex(-0.72367f, 4.88028f, 0.87243f);
            f1084.AddVertex(-0.63717f, 4.81710f, 0.95592f);
            faces.Add(f1084);

            Face f1085 = new Face(m02___Default);
            f1085.AddVertex(-0.72367f, 4.88028f, 0.87243f);
            f1085.AddVertex(-0.67682f, 4.83873f, 0.91536f);
            f1085.AddVertex(-0.63717f, 4.81710f, 0.95592f);
            faces.Add(f1085);

            Face f1086 = new Face(m02___Default);
            f1086.AddVertex(-0.63717f, 4.81710f, 0.95592f);
            f1086.AddVertex(-0.60470f, 4.81560f, 0.99282f);
            f1086.AddVertex(-0.57719f, 4.83314f, 1.02356f);
            faces.Add(f1086);

            Face f1087 = new Face(m02___Default);
            f1087.AddVertex(-0.52715f, 4.91678f, 1.05380f);
            f1087.AddVertex(-0.47938f, 5.04643f, 1.02602f);
            f1087.AddVertex(-0.57719f, 4.83314f, 1.02356f);
            f1087.AddVertex(-0.55197f, 4.86770f, 1.04495f);
            faces.Add(f1087);

            Face f1088 = new Face(m02___Default);
            f1088.AddVertex(-0.52715f, 4.91678f, 1.05380f);
            f1088.AddVertex(-0.50240f, 4.97749f, 1.04772f);
            f1088.AddVertex(-0.47938f, 5.04643f, 1.02602f);
            faces.Add(f1088);

            Face f1089 = new Face(m02___Default);
            f1089.AddVertex(-0.45725f, 5.19352f, 0.94753f);
            f1089.AddVertex(-0.74486f, 5.39986f, 0.79838f);
            f1089.AddVertex(-0.47938f, 5.04643f, 1.02602f);
            f1089.AddVertex(-0.46207f, 5.11981f, 0.99073f);
            faces.Add(f1089);

            Face f1090 = new Face(m02___Default);
            f1090.AddVertex(-0.45725f, 5.19352f, 0.94753f);
            f1090.AddVertex(-0.47494f, 5.26351f, 0.90608f);
            f1090.AddVertex(-0.74486f, 5.39986f, 0.79838f);
            faces.Add(f1090);

            Face f1091 = new Face(m02___Default);
            f1091.AddVertex(-0.91636f, 5.18394f, 0.69831f);
            f1091.AddVertex(-0.74486f, 5.39986f, 0.79838f);
            f1091.AddVertex(-0.80850f, 5.39451f, 0.76889f);
            f1091.AddVertex(-0.87886f, 5.38023f, 0.74346f);
            faces.Add(f1091);

            Face f1092 = new Face(m02___Default);
            f1092.AddVertex(-0.79201f, 5.42148f, 0.70663f);
            f1092.AddVertex(-0.66375f, 5.69440f, 0.81171f);
            f1092.AddVertex(-0.66821f, 5.69428f, 0.81601f);
            f1092.AddVertex(-0.79646f, 5.42136f, 0.71094f);
            faces.Add(f1092);

            Face f1093 = new Face(m02___Default);
            f1093.AddVertex(-0.66375f, 5.69440f, 0.81171f);
            f1093.AddVertex(-0.67313f, 5.81262f, 0.79809f);
            f1093.AddVertex(-0.67758f, 5.81250f, 0.80240f);
            f1093.AddVertex(-0.66821f, 5.69428f, 0.81601f);
            faces.Add(f1093);

            Face f1094 = new Face(m02___Default);
            f1094.AddVertex(-0.67313f, 5.81262f, 0.79809f);
            f1094.AddVertex(-0.69759f, 5.92254f, 0.78816f);
            f1094.AddVertex(-0.70204f, 5.92242f, 0.79247f);
            f1094.AddVertex(-0.67758f, 5.81250f, 0.80240f);
            faces.Add(f1094);

            Face f1095 = new Face(m02___Default);
            f1095.AddVertex(-0.69759f, 5.92254f, 0.78816f);
            f1095.AddVertex(-0.73831f, 6.02035f, 0.78418f);
            f1095.AddVertex(-0.74277f, 6.02023f, 0.78850f);
            f1095.AddVertex(-0.70204f, 5.92242f, 0.79247f);
            faces.Add(f1095);

            Face f1096 = new Face(m02___Default);
            f1096.AddVertex(-0.73831f, 6.02035f, 0.78418f);
            f1096.AddVertex(-0.79424f, 6.10273f, 0.78662f);
            f1096.AddVertex(-0.79869f, 6.10261f, 0.79093f);
            f1096.AddVertex(-0.74277f, 6.02023f, 0.78850f);
            faces.Add(f1096);

            Face f1097 = new Face(m02___Default);
            f1097.AddVertex(-0.79424f, 6.10273f, 0.78662f);
            f1097.AddVertex(-0.86011f, 6.16695f, 0.79213f);
            f1097.AddVertex(-0.86456f, 6.16683f, 0.79644f);
            f1097.AddVertex(-0.79869f, 6.10261f, 0.79093f);
            faces.Add(f1097);

            Face f1098 = new Face(m02___Default);
            f1098.AddVertex(-0.86011f, 6.16695f, 0.79213f);
            f1098.AddVertex(-0.92705f, 6.21100f, 0.79411f);
            f1098.AddVertex(-0.93150f, 6.21088f, 0.79842f);
            f1098.AddVertex(-0.86456f, 6.16683f, 0.79644f);
            faces.Add(f1098);

            Face f1099 = new Face(m02___Default);
            f1099.AddVertex(-0.92705f, 6.21100f, 0.79411f);
            f1099.AddVertex(-0.98551f, 6.23358f, 0.78545f);
            f1099.AddVertex(-0.98996f, 6.23346f, 0.78976f);
            f1099.AddVertex(-0.93150f, 6.21088f, 0.79842f);
            faces.Add(f1099);

            Face f1100 = new Face(m02___Default);
            f1100.AddVertex(-0.98551f, 6.23358f, 0.78545f);
            f1100.AddVertex(-1.02909f, 6.23404f, 0.76219f);
            f1100.AddVertex(-1.03354f, 6.23392f, 0.76650f);
            f1100.AddVertex(-0.98996f, 6.23346f, 0.78976f);
            faces.Add(f1100);

            Face f1101 = new Face(m02___Default);
            f1101.AddVertex(-1.02909f, 6.23404f, 0.76219f);
            f1101.AddVertex(-1.05699f, 6.21234f, 0.72577f);
            f1101.AddVertex(-1.06144f, 6.21222f, 0.73008f);
            f1101.AddVertex(-1.03354f, 6.23392f, 0.76650f);
            faces.Add(f1101);

            Face f1102 = new Face(m02___Default);
            f1102.AddVertex(-1.05699f, 6.21234f, 0.72577f);
            f1102.AddVertex(-1.07359f, 6.16907f, 0.68260f);
            f1102.AddVertex(-1.07805f, 6.16895f, 0.68691f);
            f1102.AddVertex(-1.06144f, 6.21222f, 0.73008f);
            faces.Add(f1102);

            Face f1103 = new Face(m02___Default);
            f1103.AddVertex(-1.07359f, 6.16907f, 0.68260f);
            f1103.AddVertex(-1.08534f, 6.10553f, 0.64092f);
            f1103.AddVertex(-1.08978f, 6.10541f, 0.64523f);
            f1103.AddVertex(-1.07805f, 6.16895f, 0.68691f);
            faces.Add(f1103);

            Face f1104 = new Face(m02___Default);
            f1104.AddVertex(-1.08534f, 6.10553f, 0.64092f);
            f1104.AddVertex(-1.09674f, 6.02375f, 0.60693f);
            f1104.AddVertex(-1.10120f, 6.02363f, 0.61124f);
            f1104.AddVertex(-1.08978f, 6.10541f, 0.64523f);
            faces.Add(f1104);

            Face f1105 = new Face(m02___Default);
            f1105.AddVertex(-1.09674f, 6.02375f, 0.60693f);
            f1105.AddVertex(-1.10834f, 5.92649f, 0.58266f);
            f1105.AddVertex(-1.11279f, 5.92637f, 0.58698f);
            f1105.AddVertex(-1.10120f, 6.02363f, 0.61124f);
            faces.Add(f1105);

            Face f1106 = new Face(m02___Default);
            f1106.AddVertex(-1.10834f, 5.92649f, 0.58266f);
            f1106.AddVertex(-1.11765f, 5.81711f, 0.56694f);
            f1106.AddVertex(-1.12210f, 5.81700f, 0.57125f);
            f1106.AddVertex(-1.11279f, 5.92637f, 0.58698f);
            faces.Add(f1106);

            Face f1107 = new Face(m02___Default);
            f1107.AddVertex(-1.11765f, 5.81711f, 0.56694f);
            f1107.AddVertex(-1.12274f, 5.69939f, 0.55874f);
            f1107.AddVertex(-1.12720f, 5.69927f, 0.56304f);
            f1107.AddVertex(-1.12210f, 5.81700f, 0.57125f);
            faces.Add(f1107);

            Face f1108 = new Face(m02___Default);
            f1108.AddVertex(-1.12274f, 5.69939f, 0.55874f);
            f1108.AddVertex(-0.92904f, 5.42318f, 0.62271f);
            f1108.AddVertex(-0.93350f, 5.42306f, 0.62701f);
            f1108.AddVertex(-1.12720f, 5.69927f, 0.56304f);
            faces.Add(f1108);

            Face f1109 = new Face(m02___Default);
            f1109.AddVertex(-0.92904f, 5.42318f, 0.62271f);
            f1109.AddVertex(-0.84113f, 5.39140f, 0.64716f);
            f1109.AddVertex(-0.84558f, 5.39128f, 0.65147f);
            f1109.AddVertex(-0.93350f, 5.42306f, 0.62701f);
            faces.Add(f1109);

            Face f1110 = new Face(m02___Default);
            f1110.AddVertex(-0.84113f, 5.39140f, 0.64716f);
            f1110.AddVertex(-0.79201f, 5.42148f, 0.70663f);
            f1110.AddVertex(-0.79646f, 5.42136f, 0.71094f);
            f1110.AddVertex(-0.84558f, 5.39128f, 0.65147f);
            faces.Add(f1110);

            Face f1111 = new Face(m02___Default);
            f1111.AddVertex(-0.79646f, 5.42136f, 0.71094f);
            f1111.AddVertex(-0.66821f, 5.69428f, 0.81601f);
            f1111.AddVertex(-0.67266f, 5.69416f, 0.82033f);
            f1111.AddVertex(-0.80092f, 5.42125f, 0.71525f);
            faces.Add(f1111);

            Face f1112 = new Face(m02___Default);
            f1112.AddVertex(-0.66821f, 5.69428f, 0.81601f);
            f1112.AddVertex(-0.67758f, 5.81250f, 0.80240f);
            f1112.AddVertex(-0.68203f, 5.81238f, 0.80672f);
            f1112.AddVertex(-0.67266f, 5.69416f, 0.82033f);
            faces.Add(f1112);

            Face f1113 = new Face(m02___Default);
            f1113.AddVertex(-0.67758f, 5.81250f, 0.80240f);
            f1113.AddVertex(-0.70204f, 5.92242f, 0.79247f);
            f1113.AddVertex(-0.70649f, 5.92230f, 0.79678f);
            f1113.AddVertex(-0.68203f, 5.81238f, 0.80672f);
            faces.Add(f1113);

            Face f1114 = new Face(m02___Default);
            f1114.AddVertex(-0.70204f, 5.92242f, 0.79247f);
            f1114.AddVertex(-0.74277f, 6.02023f, 0.78850f);
            f1114.AddVertex(-0.74722f, 6.02011f, 0.79280f);
            f1114.AddVertex(-0.70649f, 5.92230f, 0.79678f);
            faces.Add(f1114);

            Face f1115 = new Face(m02___Default);
            f1115.AddVertex(-0.74277f, 6.02023f, 0.78850f);
            f1115.AddVertex(-0.79869f, 6.10261f, 0.79093f);
            f1115.AddVertex(-0.80315f, 6.10249f, 0.79524f);
            f1115.AddVertex(-0.74722f, 6.02011f, 0.79280f);
            faces.Add(f1115);

            Face f1116 = new Face(m02___Default);
            f1116.AddVertex(-0.79869f, 6.10261f, 0.79093f);
            f1116.AddVertex(-0.86456f, 6.16683f, 0.79644f);
            f1116.AddVertex(-0.86902f, 6.16671f, 0.80075f);
            f1116.AddVertex(-0.80315f, 6.10249f, 0.79524f);
            faces.Add(f1116);

            Face f1117 = new Face(m02___Default);
            f1117.AddVertex(-0.86456f, 6.16683f, 0.79644f);
            f1117.AddVertex(-0.93150f, 6.21088f, 0.79842f);
            f1117.AddVertex(-0.93595f, 6.21077f, 0.80273f);
            f1117.AddVertex(-0.86902f, 6.16671f, 0.80075f);
            faces.Add(f1117);

            Face f1118 = new Face(m02___Default);
            f1118.AddVertex(-0.93150f, 6.21088f, 0.79842f);
            f1118.AddVertex(-0.98996f, 6.23346f, 0.78976f);
            f1118.AddVertex(-0.99441f, 6.23335f, 0.79408f);
            f1118.AddVertex(-0.93595f, 6.21077f, 0.80273f);
            faces.Add(f1118);

            Face f1119 = new Face(m02___Default);
            f1119.AddVertex(-0.98996f, 6.23346f, 0.78976f);
            f1119.AddVertex(-1.03354f, 6.23392f, 0.76650f);
            f1119.AddVertex(-1.03799f, 6.23380f, 0.77081f);
            f1119.AddVertex(-0.99441f, 6.23335f, 0.79408f);
            faces.Add(f1119);

            Face f1120 = new Face(m02___Default);
            f1120.AddVertex(-1.03354f, 6.23392f, 0.76650f);
            f1120.AddVertex(-1.06144f, 6.21222f, 0.73008f);
            f1120.AddVertex(-1.06590f, 6.21210f, 0.73439f);
            f1120.AddVertex(-1.03799f, 6.23380f, 0.77081f);
            faces.Add(f1120);

            Face f1121 = new Face(m02___Default);
            f1121.AddVertex(-1.06144f, 6.21222f, 0.73008f);
            f1121.AddVertex(-1.07805f, 6.16895f, 0.68691f);
            f1121.AddVertex(-1.08250f, 6.16884f, 0.69122f);
            f1121.AddVertex(-1.06590f, 6.21210f, 0.73439f);
            faces.Add(f1121);

            Face f1122 = new Face(m02___Default);
            f1122.AddVertex(-1.07805f, 6.16895f, 0.68691f);
            f1122.AddVertex(-1.08978f, 6.10541f, 0.64523f);
            f1122.AddVertex(-1.09424f, 6.10530f, 0.64954f);
            f1122.AddVertex(-1.08250f, 6.16884f, 0.69122f);
            faces.Add(f1122);

            Face f1123 = new Face(m02___Default);
            f1123.AddVertex(-1.08978f, 6.10541f, 0.64523f);
            f1123.AddVertex(-1.10120f, 6.02363f, 0.61124f);
            f1123.AddVertex(-1.10565f, 6.02352f, 0.61556f);
            f1123.AddVertex(-1.09424f, 6.10530f, 0.64954f);
            faces.Add(f1123);

            Face f1124 = new Face(m02___Default);
            f1124.AddVertex(-1.10120f, 6.02363f, 0.61124f);
            f1124.AddVertex(-1.11279f, 5.92637f, 0.58698f);
            f1124.AddVertex(-1.11725f, 5.92625f, 0.59129f);
            f1124.AddVertex(-1.10565f, 6.02352f, 0.61556f);
            faces.Add(f1124);

            Face f1125 = new Face(m02___Default);
            f1125.AddVertex(-1.11279f, 5.92637f, 0.58698f);
            f1125.AddVertex(-1.12210f, 5.81700f, 0.57125f);
            f1125.AddVertex(-1.12655f, 5.81688f, 0.57557f);
            f1125.AddVertex(-1.11725f, 5.92625f, 0.59129f);
            faces.Add(f1125);

            Face f1126 = new Face(m02___Default);
            f1126.AddVertex(-1.12210f, 5.81700f, 0.57125f);
            f1126.AddVertex(-1.12720f, 5.69927f, 0.56304f);
            f1126.AddVertex(-1.13165f, 5.69915f, 0.56736f);
            f1126.AddVertex(-1.12655f, 5.81688f, 0.57557f);
            faces.Add(f1126);

            Face f1127 = new Face(m02___Default);
            f1127.AddVertex(-1.12720f, 5.69927f, 0.56304f);
            f1127.AddVertex(-0.93350f, 5.42306f, 0.62701f);
            f1127.AddVertex(-0.93795f, 5.42294f, 0.63133f);
            f1127.AddVertex(-1.13165f, 5.69915f, 0.56736f);
            faces.Add(f1127);

            Face f1128 = new Face(m02___Default);
            f1128.AddVertex(-0.93350f, 5.42306f, 0.62701f);
            f1128.AddVertex(-0.84558f, 5.39128f, 0.65147f);
            f1128.AddVertex(-0.85003f, 5.39116f, 0.65578f);
            f1128.AddVertex(-0.93795f, 5.42294f, 0.63133f);
            faces.Add(f1128);

            Face f1129 = new Face(m02___Default);
            f1129.AddVertex(-0.84558f, 5.39128f, 0.65147f);
            f1129.AddVertex(-0.79646f, 5.42136f, 0.71094f);
            f1129.AddVertex(-0.80092f, 5.42125f, 0.71525f);
            f1129.AddVertex(-0.85003f, 5.39116f, 0.65578f);
            faces.Add(f1129);

            Face f1130 = new Face(m02___Default);
            f1130.AddVertex(-0.80092f, 5.42125f, 0.71525f);
            f1130.AddVertex(-0.67266f, 5.69416f, 0.82033f);
            f1130.AddVertex(-0.67711f, 5.69404f, 0.82464f);
            f1130.AddVertex(-0.80537f, 5.42113f, 0.71956f);
            faces.Add(f1130);

            Face f1131 = new Face(m02___Default);
            f1131.AddVertex(-0.67266f, 5.69416f, 0.82033f);
            f1131.AddVertex(-0.68203f, 5.81238f, 0.80672f);
            f1131.AddVertex(-0.68649f, 5.81226f, 0.81103f);
            f1131.AddVertex(-0.67711f, 5.69404f, 0.82464f);
            faces.Add(f1131);

            Face f1132 = new Face(m02___Default);
            f1132.AddVertex(-0.68203f, 5.81238f, 0.80672f);
            f1132.AddVertex(-0.70649f, 5.92230f, 0.79678f);
            f1132.AddVertex(-0.71094f, 5.92218f, 0.80109f);
            f1132.AddVertex(-0.68649f, 5.81226f, 0.81103f);
            faces.Add(f1132);

            Face f1133 = new Face(m02___Default);
            f1133.AddVertex(-0.70649f, 5.92230f, 0.79678f);
            f1133.AddVertex(-0.74722f, 6.02011f, 0.79280f);
            f1133.AddVertex(-0.75167f, 6.02000f, 0.79712f);
            f1133.AddVertex(-0.71094f, 5.92218f, 0.80109f);
            faces.Add(f1133);

            Face f1134 = new Face(m02___Default);
            f1134.AddVertex(-0.74722f, 6.02011f, 0.79280f);
            f1134.AddVertex(-0.80315f, 6.10249f, 0.79524f);
            f1134.AddVertex(-0.80760f, 6.10237f, 0.79955f);
            f1134.AddVertex(-0.75167f, 6.02000f, 0.79712f);
            faces.Add(f1134);

            Face f1135 = new Face(m02___Default);
            f1135.AddVertex(-0.80315f, 6.10249f, 0.79524f);
            f1135.AddVertex(-0.86902f, 6.16671f, 0.80075f);
            f1135.AddVertex(-0.87347f, 6.16659f, 0.80506f);
            f1135.AddVertex(-0.80760f, 6.10237f, 0.79955f);
            faces.Add(f1135);

            Face f1136 = new Face(m02___Default);
            f1136.AddVertex(-0.86902f, 6.16671f, 0.80075f);
            f1136.AddVertex(-0.93595f, 6.21077f, 0.80273f);
            f1136.AddVertex(-0.94041f, 6.21065f, 0.80704f);
            f1136.AddVertex(-0.87347f, 6.16659f, 0.80506f);
            faces.Add(f1136);

            Face f1137 = new Face(m02___Default);
            f1137.AddVertex(-0.93595f, 6.21077f, 0.80273f);
            f1137.AddVertex(-0.99441f, 6.23335f, 0.79408f);
            f1137.AddVertex(-0.99887f, 6.23323f, 0.79838f);
            f1137.AddVertex(-0.94041f, 6.21065f, 0.80704f);
            faces.Add(f1137);

            Face f1138 = new Face(m02___Default);
            f1138.AddVertex(-0.99441f, 6.23335f, 0.79408f);
            f1138.AddVertex(-1.03799f, 6.23380f, 0.77081f);
            f1138.AddVertex(-1.04245f, 6.23368f, 0.77512f);
            f1138.AddVertex(-0.99887f, 6.23323f, 0.79838f);
            faces.Add(f1138);

            Face f1139 = new Face(m02___Default);
            f1139.AddVertex(-1.03799f, 6.23380f, 0.77081f);
            f1139.AddVertex(-1.06590f, 6.21210f, 0.73439f);
            f1139.AddVertex(-1.07035f, 6.21198f, 0.73870f);
            f1139.AddVertex(-1.04245f, 6.23368f, 0.77512f);
            faces.Add(f1139);

            Face f1140 = new Face(m02___Default);
            f1140.AddVertex(-1.06590f, 6.21210f, 0.73439f);
            f1140.AddVertex(-1.08250f, 6.16884f, 0.69122f);
            f1140.AddVertex(-1.08695f, 6.16872f, 0.69553f);
            f1140.AddVertex(-1.07035f, 6.21198f, 0.73870f);
            faces.Add(f1140);

            Face f1141 = new Face(m02___Default);
            f1141.AddVertex(-1.08250f, 6.16884f, 0.69122f);
            f1141.AddVertex(-1.09424f, 6.10530f, 0.64954f);
            f1141.AddVertex(-1.09869f, 6.10518f, 0.65385f);
            f1141.AddVertex(-1.08695f, 6.16872f, 0.69553f);
            faces.Add(f1141);

            Face f1142 = new Face(m02___Default);
            f1142.AddVertex(-1.09424f, 6.10530f, 0.64954f);
            f1142.AddVertex(-1.10565f, 6.02352f, 0.61556f);
            f1142.AddVertex(-1.11010f, 6.02340f, 0.61987f);
            f1142.AddVertex(-1.09869f, 6.10518f, 0.65385f);
            faces.Add(f1142);

            Face f1143 = new Face(m02___Default);
            f1143.AddVertex(-1.10565f, 6.02352f, 0.61556f);
            f1143.AddVertex(-1.11725f, 5.92625f, 0.59129f);
            f1143.AddVertex(-1.12170f, 5.92613f, 0.59560f);
            f1143.AddVertex(-1.11010f, 6.02340f, 0.61987f);
            faces.Add(f1143);

            Face f1144 = new Face(m02___Default);
            f1144.AddVertex(-1.11725f, 5.92625f, 0.59129f);
            f1144.AddVertex(-1.12655f, 5.81688f, 0.57557f);
            f1144.AddVertex(-1.13101f, 5.81676f, 0.57987f);
            f1144.AddVertex(-1.12170f, 5.92613f, 0.59560f);
            faces.Add(f1144);

            Face f1145 = new Face(m02___Default);
            f1145.AddVertex(-1.12655f, 5.81688f, 0.57557f);
            f1145.AddVertex(-1.13165f, 5.69915f, 0.56736f);
            f1145.AddVertex(-1.13610f, 5.69904f, 0.57167f);
            f1145.AddVertex(-1.13101f, 5.81676f, 0.57987f);
            faces.Add(f1145);

            Face f1146 = new Face(m02___Default);
            f1146.AddVertex(-1.13165f, 5.69915f, 0.56736f);
            f1146.AddVertex(-0.93795f, 5.42294f, 0.63133f);
            f1146.AddVertex(-0.94240f, 5.42282f, 0.63564f);
            f1146.AddVertex(-1.13610f, 5.69904f, 0.57167f);
            faces.Add(f1146);

            Face f1147 = new Face(m02___Default);
            f1147.AddVertex(-0.93795f, 5.42294f, 0.63133f);
            f1147.AddVertex(-0.85003f, 5.39116f, 0.65578f);
            f1147.AddVertex(-0.85449f, 5.39104f, 0.66009f);
            f1147.AddVertex(-0.94240f, 5.42282f, 0.63564f);
            faces.Add(f1147);

            Face f1148 = new Face(m02___Default);
            f1148.AddVertex(-0.85003f, 5.39116f, 0.65578f);
            f1148.AddVertex(-0.80092f, 5.42125f, 0.71525f);
            f1148.AddVertex(-0.80537f, 5.42113f, 0.71956f);
            f1148.AddVertex(-0.85449f, 5.39104f, 0.66009f);
            faces.Add(f1148);

            Face f1149 = new Face(m02___Default);
            f1149.AddVertex(-0.80537f, 5.42113f, 0.71956f);
            f1149.AddVertex(-0.67711f, 5.69404f, 0.82464f);
            f1149.AddVertex(-0.68157f, 5.69392f, 0.82895f);
            f1149.AddVertex(-0.80982f, 5.42101f, 0.72388f);
            faces.Add(f1149);

            Face f1150 = new Face(m02___Default);
            f1150.AddVertex(-0.67711f, 5.69404f, 0.82464f);
            f1150.AddVertex(-0.68649f, 5.81226f, 0.81103f);
            f1150.AddVertex(-0.69094f, 5.81214f, 0.81534f);
            f1150.AddVertex(-0.68157f, 5.69392f, 0.82895f);
            faces.Add(f1150);

            Face f1151 = new Face(m02___Default);
            f1151.AddVertex(-0.68649f, 5.81226f, 0.81103f);
            f1151.AddVertex(-0.71094f, 5.92218f, 0.80109f);
            f1151.AddVertex(-0.71540f, 5.92206f, 0.80540f);
            f1151.AddVertex(-0.69094f, 5.81214f, 0.81534f);
            faces.Add(f1151);

            Face f1152 = new Face(m02___Default);
            f1152.AddVertex(-0.71094f, 5.92218f, 0.80109f);
            f1152.AddVertex(-0.75167f, 6.02000f, 0.79712f);
            f1152.AddVertex(-0.75613f, 6.01988f, 0.80143f);
            f1152.AddVertex(-0.71540f, 5.92206f, 0.80540f);
            faces.Add(f1152);

            Face f1153 = new Face(m02___Default);
            f1153.AddVertex(-0.75167f, 6.02000f, 0.79712f);
            f1153.AddVertex(-0.80760f, 6.10237f, 0.79955f);
            f1153.AddVertex(-0.81205f, 6.10225f, 0.80386f);
            f1153.AddVertex(-0.75613f, 6.01988f, 0.80143f);
            faces.Add(f1153);

            Face f1154 = new Face(m02___Default);
            f1154.AddVertex(-0.80760f, 6.10237f, 0.79955f);
            f1154.AddVertex(-0.87347f, 6.16659f, 0.80506f);
            f1154.AddVertex(-0.87792f, 6.16647f, 0.80938f);
            f1154.AddVertex(-0.81205f, 6.10225f, 0.80386f);
            faces.Add(f1154);

            Face f1155 = new Face(m02___Default);
            f1155.AddVertex(-0.87347f, 6.16659f, 0.80506f);
            f1155.AddVertex(-0.94041f, 6.21065f, 0.80704f);
            f1155.AddVertex(-0.94486f, 6.21053f, 0.81135f);
            f1155.AddVertex(-0.87792f, 6.16647f, 0.80938f);
            faces.Add(f1155);

            Face f1156 = new Face(m02___Default);
            f1156.AddVertex(-0.94041f, 6.21065f, 0.80704f);
            f1156.AddVertex(-0.99887f, 6.23323f, 0.79838f);
            f1156.AddVertex(-1.00332f, 6.23311f, 0.80270f);
            f1156.AddVertex(-0.94486f, 6.21053f, 0.81135f);
            faces.Add(f1156);

            Face f1157 = new Face(m02___Default);
            f1157.AddVertex(-0.99887f, 6.23323f, 0.79838f);
            f1157.AddVertex(-1.04245f, 6.23368f, 0.77512f);
            f1157.AddVertex(-1.04690f, 6.23356f, 0.77943f);
            f1157.AddVertex(-1.00332f, 6.23311f, 0.80270f);
            faces.Add(f1157);

            Face f1158 = new Face(m02___Default);
            f1158.AddVertex(-1.04245f, 6.23368f, 0.77512f);
            f1158.AddVertex(-1.07035f, 6.21198f, 0.73870f);
            f1158.AddVertex(-1.07480f, 6.21186f, 0.74301f);
            f1158.AddVertex(-1.04690f, 6.23356f, 0.77943f);
            faces.Add(f1158);

            Face f1159 = new Face(m02___Default);
            f1159.AddVertex(-1.07035f, 6.21198f, 0.73870f);
            f1159.AddVertex(-1.08695f, 6.16872f, 0.69553f);
            f1159.AddVertex(-1.09141f, 6.16860f, 0.69985f);
            f1159.AddVertex(-1.07480f, 6.21186f, 0.74301f);
            faces.Add(f1159);

            Face f1160 = new Face(m02___Default);
            f1160.AddVertex(-1.08695f, 6.16872f, 0.69553f);
            f1160.AddVertex(-1.09869f, 6.10518f, 0.65385f);
            f1160.AddVertex(-1.10314f, 6.10506f, 0.65816f);
            f1160.AddVertex(-1.09141f, 6.16860f, 0.69985f);
            faces.Add(f1160);

            Face f1161 = new Face(m02___Default);
            f1161.AddVertex(-1.09869f, 6.10518f, 0.65385f);
            f1161.AddVertex(-1.11010f, 6.02340f, 0.61987f);
            f1161.AddVertex(-1.11456f, 6.02328f, 0.62418f);
            f1161.AddVertex(-1.10314f, 6.10506f, 0.65816f);
            faces.Add(f1161);

            Face f1162 = new Face(m02___Default);
            f1162.AddVertex(-1.11010f, 6.02340f, 0.61987f);
            f1162.AddVertex(-1.12170f, 5.92613f, 0.59560f);
            f1162.AddVertex(-1.12615f, 5.92601f, 0.59991f);
            f1162.AddVertex(-1.11456f, 6.02328f, 0.62418f);
            faces.Add(f1162);

            Face f1163 = new Face(m02___Default);
            f1163.AddVertex(-1.12170f, 5.92613f, 0.59560f);
            f1163.AddVertex(-1.13101f, 5.81676f, 0.57987f);
            f1163.AddVertex(-1.13546f, 5.81664f, 0.58419f);
            f1163.AddVertex(-1.12615f, 5.92601f, 0.59991f);
            faces.Add(f1163);

            Face f1164 = new Face(m02___Default);
            f1164.AddVertex(-1.13101f, 5.81676f, 0.57987f);
            f1164.AddVertex(-1.13610f, 5.69904f, 0.57167f);
            f1164.AddVertex(-1.14056f, 5.69892f, 0.57598f);
            f1164.AddVertex(-1.13546f, 5.81664f, 0.58419f);
            faces.Add(f1164);

            Face f1165 = new Face(m02___Default);
            f1165.AddVertex(-1.13610f, 5.69904f, 0.57167f);
            f1165.AddVertex(-0.94240f, 5.42282f, 0.63564f);
            f1165.AddVertex(-0.94685f, 5.42271f, 0.63995f);
            f1165.AddVertex(-1.14056f, 5.69892f, 0.57598f);
            faces.Add(f1165);

            Face f1166 = new Face(m02___Default);
            f1166.AddVertex(-0.94240f, 5.42282f, 0.63564f);
            f1166.AddVertex(-0.85449f, 5.39104f, 0.66009f);
            f1166.AddVertex(-0.85894f, 5.39092f, 0.66440f);
            f1166.AddVertex(-0.94685f, 5.42271f, 0.63995f);
            faces.Add(f1166);

            Face f1167 = new Face(m02___Default);
            f1167.AddVertex(-0.85449f, 5.39104f, 0.66009f);
            f1167.AddVertex(-0.80537f, 5.42113f, 0.71956f);
            f1167.AddVertex(-0.80982f, 5.42101f, 0.72388f);
            f1167.AddVertex(-0.85894f, 5.39092f, 0.66440f);
            faces.Add(f1167);

            Face f1168 = new Face(m02___Default);
            f1168.AddVertex(-0.80982f, 5.42101f, 0.72388f);
            f1168.AddVertex(-0.68157f, 5.69392f, 0.82895f);
            f1168.AddVertex(-0.68602f, 5.69380f, 0.83326f);
            f1168.AddVertex(-0.81428f, 5.42089f, 0.72818f);
            faces.Add(f1168);

            Face f1169 = new Face(m02___Default);
            f1169.AddVertex(-0.68157f, 5.69392f, 0.82895f);
            f1169.AddVertex(-0.69094f, 5.81214f, 0.81534f);
            f1169.AddVertex(-0.69539f, 5.81203f, 0.81965f);
            f1169.AddVertex(-0.68602f, 5.69380f, 0.83326f);
            faces.Add(f1169);

            Face f1170 = new Face(m02___Default);
            f1170.AddVertex(-0.69094f, 5.81214f, 0.81534f);
            f1170.AddVertex(-0.71540f, 5.92206f, 0.80540f);
            f1170.AddVertex(-0.71985f, 5.92194f, 0.80971f);
            f1170.AddVertex(-0.69539f, 5.81203f, 0.81965f);
            faces.Add(f1170);

            Face f1171 = new Face(m02___Default);
            f1171.AddVertex(-0.71540f, 5.92206f, 0.80540f);
            f1171.AddVertex(-0.75613f, 6.01988f, 0.80143f);
            f1171.AddVertex(-0.76058f, 6.01976f, 0.80574f);
            f1171.AddVertex(-0.71985f, 5.92194f, 0.80971f);
            faces.Add(f1171);

            Face f1172 = new Face(m02___Default);
            f1172.AddVertex(-0.75613f, 6.01988f, 0.80143f);
            f1172.AddVertex(-0.81205f, 6.10225f, 0.80386f);
            f1172.AddVertex(-0.81651f, 6.10213f, 0.80817f);
            f1172.AddVertex(-0.76058f, 6.01976f, 0.80574f);
            faces.Add(f1172);

            Face f1173 = new Face(m02___Default);
            f1173.AddVertex(-0.81205f, 6.10225f, 0.80386f);
            f1173.AddVertex(-0.87792f, 6.16647f, 0.80938f);
            f1173.AddVertex(-0.88238f, 6.16636f, 0.81368f);
            f1173.AddVertex(-0.81651f, 6.10213f, 0.80817f);
            faces.Add(f1173);

            Face f1174 = new Face(m02___Default);
            f1174.AddVertex(-0.87792f, 6.16647f, 0.80938f);
            f1174.AddVertex(-0.94486f, 6.21053f, 0.81135f);
            f1174.AddVertex(-0.94931f, 6.21041f, 0.81566f);
            f1174.AddVertex(-0.88238f, 6.16636f, 0.81368f);
            faces.Add(f1174);

            Face f1175 = new Face(m02___Default);
            f1175.AddVertex(-0.94486f, 6.21053f, 0.81135f);
            f1175.AddVertex(-1.00332f, 6.23311f, 0.80270f);
            f1175.AddVertex(-1.00777f, 6.23299f, 0.80701f);
            f1175.AddVertex(-0.94931f, 6.21041f, 0.81566f);
            faces.Add(f1175);

            Face f1176 = new Face(m02___Default);
            f1176.AddVertex(-1.00332f, 6.23311f, 0.80270f);
            f1176.AddVertex(-1.04690f, 6.23356f, 0.77943f);
            f1176.AddVertex(-1.05135f, 6.23344f, 0.78375f);
            f1176.AddVertex(-1.00777f, 6.23299f, 0.80701f);
            faces.Add(f1176);

            Face f1177 = new Face(m02___Default);
            f1177.AddVertex(-1.04690f, 6.23356f, 0.77943f);
            f1177.AddVertex(-1.07480f, 6.21186f, 0.74301f);
            f1177.AddVertex(-1.07926f, 6.21174f, 0.74733f);
            f1177.AddVertex(-1.05135f, 6.23344f, 0.78375f);
            faces.Add(f1177);

            Face f1178 = new Face(m02___Default);
            f1178.AddVertex(-1.07480f, 6.21186f, 0.74301f);
            f1178.AddVertex(-1.09141f, 6.16860f, 0.69985f);
            f1178.AddVertex(-1.09586f, 6.16848f, 0.70415f);
            f1178.AddVertex(-1.07926f, 6.21174f, 0.74733f);
            faces.Add(f1178);

            Face f1179 = new Face(m02___Default);
            f1179.AddVertex(-1.09141f, 6.16860f, 0.69985f);
            f1179.AddVertex(-1.10314f, 6.10506f, 0.65816f);
            f1179.AddVertex(-1.10760f, 6.10494f, 0.66248f);
            f1179.AddVertex(-1.09586f, 6.16848f, 0.70415f);
            faces.Add(f1179);

            Face f1180 = new Face(m02___Default);
            f1180.AddVertex(-1.10314f, 6.10506f, 0.65816f);
            f1180.AddVertex(-1.11456f, 6.02328f, 0.62418f);
            f1180.AddVertex(-1.11901f, 6.02316f, 0.62849f);
            f1180.AddVertex(-1.10760f, 6.10494f, 0.66248f);
            faces.Add(f1180);

            Face f1181 = new Face(m02___Default);
            f1181.AddVertex(-1.11456f, 6.02328f, 0.62418f);
            f1181.AddVertex(-1.12615f, 5.92601f, 0.59991f);
            f1181.AddVertex(-1.13060f, 5.92589f, 0.60423f);
            f1181.AddVertex(-1.11901f, 6.02316f, 0.62849f);
            faces.Add(f1181);

            Face f1182 = new Face(m02___Default);
            f1182.AddVertex(-1.12615f, 5.92601f, 0.59991f);
            f1182.AddVertex(-1.13546f, 5.81664f, 0.58419f);
            f1182.AddVertex(-1.13991f, 5.81652f, 0.58850f);
            f1182.AddVertex(-1.13060f, 5.92589f, 0.60423f);
            faces.Add(f1182);

            Face f1183 = new Face(m02___Default);
            f1183.AddVertex(-1.13546f, 5.81664f, 0.58419f);
            f1183.AddVertex(-1.14056f, 5.69892f, 0.57598f);
            f1183.AddVertex(-1.14501f, 5.69880f, 0.58029f);
            f1183.AddVertex(-1.13991f, 5.81652f, 0.58850f);
            faces.Add(f1183);

            Face f1184 = new Face(m02___Default);
            f1184.AddVertex(-1.14056f, 5.69892f, 0.57598f);
            f1184.AddVertex(-0.94685f, 5.42271f, 0.63995f);
            f1184.AddVertex(-0.95130f, 5.42259f, 0.64426f);
            f1184.AddVertex(-1.14501f, 5.69880f, 0.58029f);
            faces.Add(f1184);

            Face f1185 = new Face(m02___Default);
            f1185.AddVertex(-0.94685f, 5.42271f, 0.63995f);
            f1185.AddVertex(-0.85894f, 5.39092f, 0.66440f);
            f1185.AddVertex(-0.86339f, 5.39080f, 0.66871f);
            f1185.AddVertex(-0.95130f, 5.42259f, 0.64426f);
            faces.Add(f1185);

            Face f1186 = new Face(m02___Default);
            f1186.AddVertex(-0.85894f, 5.39092f, 0.66440f);
            f1186.AddVertex(-0.80982f, 5.42101f, 0.72388f);
            f1186.AddVertex(-0.81428f, 5.42089f, 0.72818f);
            f1186.AddVertex(-0.86339f, 5.39080f, 0.66871f);
            faces.Add(f1186);

            Face f1187 = new Face(m02___Default);
            f1187.AddVertex(-0.92904f, 5.42318f, 0.62271f);
            f1187.AddVertex(-1.12274f, 5.69939f, 0.55874f);
            f1187.AddVertex(-1.11765f, 5.81711f, 0.56694f);
            f1187.AddVertex(-0.79201f, 5.42148f, 0.70663f);
            faces.Add(f1187);

            Face f1188 = new Face(m02___Default);
            f1188.AddVertex(-0.67313f, 5.81262f, 0.79809f);
            f1188.AddVertex(-0.79201f, 5.42148f, 0.70663f);
            f1188.AddVertex(-1.11765f, 5.81711f, 0.56694f);
            f1188.AddVertex(-1.05699f, 6.21234f, 0.72577f);
            faces.Add(f1188);

            Face f1189 = new Face(m02___Default);
            f1189.AddVertex(-1.09674f, 6.02375f, 0.60693f);
            f1189.AddVertex(-1.05699f, 6.21234f, 0.72577f);
            f1189.AddVertex(-1.11765f, 5.81711f, 0.56694f);
            f1189.AddVertex(-1.10834f, 5.92649f, 0.58266f);
            faces.Add(f1189);

            Face f1190 = new Face(m02___Default);
            f1190.AddVertex(-1.05699f, 6.21234f, 0.72577f);
            f1190.AddVertex(-1.09674f, 6.02375f, 0.60693f);
            f1190.AddVertex(-1.08534f, 6.10553f, 0.64092f);
            f1190.AddVertex(-1.07359f, 6.16907f, 0.68260f);
            faces.Add(f1190);

            Face f1191 = new Face(m02___Default);
            f1191.AddVertex(-0.86011f, 6.16695f, 0.79213f);
            f1191.AddVertex(-0.67313f, 5.81262f, 0.79809f);
            f1191.AddVertex(-1.05699f, 6.21234f, 0.72577f);
            f1191.AddVertex(-0.98551f, 6.23358f, 0.78545f);
            faces.Add(f1191);

            Face f1192 = new Face(m02___Default);
            f1192.AddVertex(-1.05699f, 6.21234f, 0.72577f);
            f1192.AddVertex(-1.02909f, 6.23404f, 0.76219f);
            f1192.AddVertex(-0.98551f, 6.23358f, 0.78545f);
            faces.Add(f1192);

            Face f1193 = new Face(m02___Default);
            f1193.AddVertex(-0.98551f, 6.23358f, 0.78545f);
            f1193.AddVertex(-0.92705f, 6.21100f, 0.79411f);
            f1193.AddVertex(-0.86011f, 6.16695f, 0.79213f);
            faces.Add(f1193);

            Face f1194 = new Face(m02___Default);
            f1194.AddVertex(-0.73831f, 6.02035f, 0.78418f);
            f1194.AddVertex(-0.67313f, 5.81262f, 0.79809f);
            f1194.AddVertex(-0.86011f, 6.16695f, 0.79213f);
            f1194.AddVertex(-0.79424f, 6.10273f, 0.78662f);
            faces.Add(f1194);

            Face f1195 = new Face(m02___Default);
            f1195.AddVertex(-0.73831f, 6.02035f, 0.78418f);
            f1195.AddVertex(-0.69759f, 5.92254f, 0.78816f);
            f1195.AddVertex(-0.67313f, 5.81262f, 0.79809f);
            faces.Add(f1195);

            Face f1196 = new Face(m02___Default);
            f1196.AddVertex(-0.67313f, 5.81262f, 0.79809f);
            f1196.AddVertex(-0.66375f, 5.69440f, 0.81171f);
            f1196.AddVertex(-0.79201f, 5.42148f, 0.70663f);
            faces.Add(f1196);

            Face f1197 = new Face(m02___Default);
            f1197.AddVertex(-0.84113f, 5.39140f, 0.64716f);
            f1197.AddVertex(-0.92904f, 5.42318f, 0.62271f);
            f1197.AddVertex(-0.79201f, 5.42148f, 0.70663f);
            faces.Add(f1197);

            Face f1198 = new Face(m02___Default);
            f1198.AddVertex(-0.81428f, 5.42089f, 0.72818f);
            f1198.AddVertex(-0.68602f, 5.69380f, 0.83326f);
            f1198.AddVertex(-0.69539f, 5.81203f, 0.81965f);
            f1198.AddVertex(-0.95130f, 5.42259f, 0.64426f);
            faces.Add(f1198);

            Face f1199 = new Face(m02___Default);
            f1199.AddVertex(-0.88238f, 6.16636f, 0.81368f);
            f1199.AddVertex(-0.95130f, 5.42259f, 0.64426f);
            f1199.AddVertex(-0.69539f, 5.81203f, 0.81965f);
            f1199.AddVertex(-0.76058f, 6.01976f, 0.80574f);
            faces.Add(f1199);

            Face f1200 = new Face(m02___Default);
            f1200.AddVertex(-0.69539f, 5.81203f, 0.81965f);
            f1200.AddVertex(-0.71985f, 5.92194f, 0.80971f);
            f1200.AddVertex(-0.76058f, 6.01976f, 0.80574f);
            faces.Add(f1200);

            Face f1201 = new Face(m02___Default);
            f1201.AddVertex(-0.76058f, 6.01976f, 0.80574f);
            f1201.AddVertex(-0.81651f, 6.10213f, 0.80817f);
            f1201.AddVertex(-0.88238f, 6.16636f, 0.81368f);
            faces.Add(f1201);

            Face f1202 = new Face(m02___Default);
            f1202.AddVertex(-1.11901f, 6.02316f, 0.62849f);
            f1202.AddVertex(-0.95130f, 5.42259f, 0.64426f);
            f1202.AddVertex(-0.88238f, 6.16636f, 0.81368f);
            f1202.AddVertex(-1.07926f, 6.21174f, 0.74733f);
            faces.Add(f1202);

            Face f1203 = new Face(m02___Default);
            f1203.AddVertex(-1.00777f, 6.23299f, 0.80701f);
            f1203.AddVertex(-1.07926f, 6.21174f, 0.74733f);
            f1203.AddVertex(-0.88238f, 6.16636f, 0.81368f);
            f1203.AddVertex(-0.94931f, 6.21041f, 0.81566f);
            faces.Add(f1203);

            Face f1204 = new Face(m02___Default);
            f1204.AddVertex(-1.00777f, 6.23299f, 0.80701f);
            f1204.AddVertex(-1.05135f, 6.23344f, 0.78375f);
            f1204.AddVertex(-1.07926f, 6.21174f, 0.74733f);
            faces.Add(f1204);

            Face f1205 = new Face(m02___Default);
            f1205.AddVertex(-1.10760f, 6.10494f, 0.66248f);
            f1205.AddVertex(-1.11901f, 6.02316f, 0.62849f);
            f1205.AddVertex(-1.07926f, 6.21174f, 0.74733f);
            f1205.AddVertex(-1.09586f, 6.16848f, 0.70415f);
            faces.Add(f1205);

            Face f1206 = new Face(m02___Default);
            f1206.AddVertex(-1.13991f, 5.81652f, 0.58850f);
            f1206.AddVertex(-0.95130f, 5.42259f, 0.64426f);
            f1206.AddVertex(-1.11901f, 6.02316f, 0.62849f);
            f1206.AddVertex(-1.13060f, 5.92589f, 0.60423f);
            faces.Add(f1206);

            Face f1207 = new Face(m02___Default);
            f1207.AddVertex(-1.13991f, 5.81652f, 0.58850f);
            f1207.AddVertex(-1.14501f, 5.69880f, 0.58029f);
            f1207.AddVertex(-0.95130f, 5.42259f, 0.64426f);
            faces.Add(f1207);

            Face f1208 = new Face(m02___Default);
            f1208.AddVertex(-0.81428f, 5.42089f, 0.72818f);
            f1208.AddVertex(-0.95130f, 5.42259f, 0.64426f);
            f1208.AddVertex(-0.86339f, 5.39080f, 0.66871f);
            faces.Add(f1208);

            Face f1209 = new Face(m02___Default);
            f1209.AddVertex(-0.92242f, 5.38162f, 0.68834f);
            f1209.AddVertex(-1.07644f, 5.20532f, 0.62747f);
            f1209.AddVertex(-1.20637f, 5.08662f, 0.59282f);
            f1209.AddVertex(-1.36420f, 5.07701f, 0.51887f);
            faces.Add(f1209);

            Face f1210 = new Face(m02___Default);
            f1210.AddVertex(-1.20637f, 5.08662f, 0.59282f);
            f1210.AddVertex(-1.28321f, 5.07362f, 0.55758f);
            f1210.AddVertex(-1.36420f, 5.07701f, 0.51887f);
            faces.Add(f1210);

            Face f1211 = new Face(m02___Default);
            f1211.AddVertex(-1.69015f, 5.54734f, 0.46948f);
            f1211.AddVertex(-0.92242f, 5.38162f, 0.68834f);
            f1211.AddVertex(-1.36420f, 5.07701f, 0.51887f);
            f1211.AddVertex(-1.57831f, 5.26186f, 0.45266f);
            faces.Add(f1211);

            Face f1212 = new Face(m02___Default);
            f1212.AddVertex(-1.36420f, 5.07701f, 0.51887f);
            f1212.AddVertex(-1.45325f, 5.13774f, 0.47925f);
            f1212.AddVertex(-1.57831f, 5.26186f, 0.45266f);
            faces.Add(f1212);

            Face f1213 = new Face(m02___Default);
            f1213.AddVertex(-1.57831f, 5.26186f, 0.45266f);
            f1213.AddVertex(-1.64753f, 5.40076f, 0.45705f);
            f1213.AddVertex(-1.69015f, 5.54734f, 0.46948f);
            faces.Add(f1213);

            Face f1214 = new Face(m02___Default);
            f1214.AddVertex(-1.50563f, 5.94678f, 0.59237f);
            f1214.AddVertex(-0.92242f, 5.38162f, 0.68834f);
            f1214.AddVertex(-1.69015f, 5.54734f, 0.46948f);
            f1214.AddVertex(-1.57639f, 5.87501f, 0.54482f);
            faces.Add(f1214);

            Face f1215 = new Face(m02___Default);
            f1215.AddVertex(-1.57639f, 5.87501f, 0.54482f);
            f1215.AddVertex(-1.69015f, 5.54734f, 0.46948f);
            f1215.AddVertex(-1.67901f, 5.68320f, 0.48716f);
            f1215.AddVertex(-1.62871f, 5.79521f, 0.51344f);
            faces.Add(f1215);

            Face f1216 = new Face(m02___Default);
            f1216.AddVertex(-0.92242f, 5.38162f, 0.68834f);
            f1216.AddVertex(-1.50563f, 5.94678f, 0.59237f);
            f1216.AddVertex(-1.39726f, 5.99225f, 0.65918f);
            f1216.AddVertex(-1.00711f, 5.56270f, 0.65759f);
            faces.Add(f1216);

            Face f1217 = new Face(m02___Default);
            f1217.AddVertex(-1.02069f, 5.63257f, 0.66791f);
            f1217.AddVertex(-1.00711f, 5.56270f, 0.65759f);
            f1217.AddVertex(-1.39726f, 5.99225f, 0.65918f);
            f1217.AddVertex(-1.31502f, 5.98683f, 0.69430f);
            faces.Add(f1217);

            Face f1218 = new Face(m02___Default);
            f1218.AddVertex(-1.31502f, 5.98683f, 0.69430f);
            f1218.AddVertex(-1.04238f, 5.72971f, 0.69092f);
            f1218.AddVertex(-1.02069f, 5.63257f, 0.66791f);
            faces.Add(f1218);

            Face f1219 = new Face(m02___Default);
            f1219.AddVertex(-1.31502f, 5.98683f, 0.69430f);
            f1219.AddVertex(-1.22997f, 5.96173f, 0.72020f);
            f1219.AddVertex(-1.15192f, 5.91658f, 0.73155f);
            f1219.AddVertex(-1.04238f, 5.72971f, 0.69092f);
            faces.Add(f1219);

            Face f1220 = new Face(m02___Default);
            f1220.AddVertex(-1.04910f, 5.79543f, 0.71774f);
            f1220.AddVertex(-1.04238f, 5.72971f, 0.69092f);
            f1220.AddVertex(-1.15192f, 5.91658f, 0.73155f);
            f1220.AddVertex(-1.08273f, 5.86414f, 0.73697f);
            faces.Add(f1220);

            Face f1221 = new Face(m02___Default);
            f1221.AddVertex(-1.67303f, 5.39481f, 0.48195f);
            f1221.AddVertex(-1.60381f, 5.25590f, 0.47756f);
            f1221.AddVertex(-1.47874f, 5.13179f, 0.50416f);
            f1221.AddVertex(-1.23186f, 5.08067f, 0.61773f);
            faces.Add(f1221);

            Face f1222 = new Face(m02___Default);
            f1222.AddVertex(-1.23186f, 5.08067f, 0.61773f);
            f1222.AddVertex(-1.47874f, 5.13179f, 0.50416f);
            f1222.AddVertex(-1.38970f, 5.07105f, 0.54378f);
            f1222.AddVertex(-1.30871f, 5.06767f, 0.58248f);
            faces.Add(f1222);

            Face f1223 = new Face(m02___Default);
            f1223.AddVertex(-1.42401f, 5.98629f, 0.68352f);
            f1223.AddVertex(-1.67303f, 5.39481f, 0.48195f);
            f1223.AddVertex(-1.23186f, 5.08067f, 0.61773f);
            f1223.AddVertex(-0.94792f, 5.37567f, 0.71324f);
            faces.Add(f1223);

            Face f1224 = new Face(m02___Default);
            f1224.AddVertex(-1.23186f, 5.08067f, 0.61773f);
            f1224.AddVertex(-1.10194f, 5.19937f, 0.65238f);
            f1224.AddVertex(-0.94792f, 5.37567f, 0.71324f);
            faces.Add(f1224);

            Face f1225 = new Face(m02___Default);
            f1225.AddVertex(-1.42401f, 5.98629f, 0.68352f);
            f1225.AddVertex(-0.94792f, 5.37567f, 0.71324f);
            f1225.AddVertex(-1.03261f, 5.55674f, 0.68249f);
            f1225.AddVertex(-1.04619f, 5.62662f, 0.69281f);
            faces.Add(f1225);

            Face f1226 = new Face(m02___Default);
            f1226.AddVertex(-1.25547f, 5.95578f, 0.74511f);
            f1226.AddVertex(-1.42401f, 5.98629f, 0.68352f);
            f1226.AddVertex(-1.04619f, 5.62662f, 0.69281f);
            f1226.AddVertex(-1.06789f, 5.72376f, 0.71583f);
            faces.Add(f1226);

            Face f1227 = new Face(m02___Default);
            f1227.AddVertex(-1.25547f, 5.95578f, 0.74511f);
            f1227.AddVertex(-1.06789f, 5.72376f, 0.71583f);
            f1227.AddVertex(-1.07460f, 5.78948f, 0.74264f);
            f1227.AddVertex(-1.17760f, 5.91076f, 0.75644f);
            faces.Add(f1227);

            Face f1228 = new Face(m02___Default);
            f1228.AddVertex(-1.07460f, 5.78948f, 0.74264f);
            f1228.AddVertex(-1.10823f, 5.85819f, 0.76187f);
            f1228.AddVertex(-1.17760f, 5.91076f, 0.75644f);
            faces.Add(f1228);

            Face f1229 = new Face(m02___Default);
            f1229.AddVertex(-1.25547f, 5.95578f, 0.74511f);
            f1229.AddVertex(-1.34052f, 5.98087f, 0.71920f);
            f1229.AddVertex(-1.42401f, 5.98629f, 0.68352f);
            faces.Add(f1229);

            Face f1230 = new Face(m02___Default);
            f1230.AddVertex(-1.60189f, 5.86905f, 0.56972f);
            f1230.AddVertex(-1.67303f, 5.39481f, 0.48195f);
            f1230.AddVertex(-1.42401f, 5.98629f, 0.68352f);
            f1230.AddVertex(-1.53113f, 5.94082f, 0.61728f);
            faces.Add(f1230);

            Face f1231 = new Face(m02___Default);
            f1231.AddVertex(-1.71565f, 5.54139f, 0.49439f);
            f1231.AddVertex(-1.67303f, 5.39481f, 0.48195f);
            f1231.AddVertex(-1.60189f, 5.86905f, 0.56972f);
            f1231.AddVertex(-1.70451f, 5.67724f, 0.51207f);
            faces.Add(f1231);

            Face f1232 = new Face(m02___Default);
            f1232.AddVertex(-1.60189f, 5.86905f, 0.56972f);
            f1232.AddVertex(-1.65421f, 5.78926f, 0.53834f);
            f1232.AddVertex(-1.70451f, 5.67724f, 0.51207f);
            faces.Add(f1232);

            Face f1233 = new Face(m02___Default);
            f1233.AddVertex(-1.04238f, 5.72971f, 0.69092f);
            f1233.AddVertex(-1.06789f, 5.72376f, 0.71583f);
            f1233.AddVertex(-1.04619f, 5.62662f, 0.69281f);
            f1233.AddVertex(-1.02069f, 5.63257f, 0.66791f);
            faces.Add(f1233);

            Face f1234 = new Face(m02___Default);
            f1234.AddVertex(-1.08273f, 5.86414f, 0.73697f);
            f1234.AddVertex(-1.10823f, 5.85819f, 0.76187f);
            f1234.AddVertex(-1.07460f, 5.78948f, 0.74264f);
            f1234.AddVertex(-1.04910f, 5.79543f, 0.71774f);
            faces.Add(f1234);

            Face f1235 = new Face(m02___Default);
            f1235.AddVertex(-1.22997f, 5.96173f, 0.72020f);
            f1235.AddVertex(-1.25547f, 5.95578f, 0.74511f);
            f1235.AddVertex(-1.17760f, 5.91076f, 0.75644f);
            f1235.AddVertex(-1.15229f, 5.91685f, 0.73153f);
            faces.Add(f1235);

            Face f1236 = new Face(m02___Default);
            f1236.AddVertex(-1.39966f, 5.99191f, 0.65791f);
            f1236.AddVertex(-1.42401f, 5.98629f, 0.68352f);
            f1236.AddVertex(-1.34052f, 5.98087f, 0.71920f);
            f1236.AddVertex(-1.31502f, 5.98683f, 0.69430f);
            faces.Add(f1236);

            Face f1237 = new Face(m02___Default);
            f1237.AddVertex(-1.57639f, 5.87501f, 0.54482f);
            f1237.AddVertex(-1.60189f, 5.86905f, 0.56972f);
            f1237.AddVertex(-1.53113f, 5.94082f, 0.61728f);
            f1237.AddVertex(-1.50563f, 5.94678f, 0.59237f);
            faces.Add(f1237);

            Face f1238 = new Face(m02___Default);
            f1238.AddVertex(-1.67901f, 5.68320f, 0.48716f);
            f1238.AddVertex(-1.70451f, 5.67724f, 0.51207f);
            f1238.AddVertex(-1.65421f, 5.78926f, 0.53834f);
            f1238.AddVertex(-1.62871f, 5.79521f, 0.51344f);
            faces.Add(f1238);

            Face f1239 = new Face(m02___Default);
            f1239.AddVertex(-1.64753f, 5.40076f, 0.45705f);
            f1239.AddVertex(-1.67303f, 5.39481f, 0.48195f);
            f1239.AddVertex(-1.71565f, 5.54139f, 0.49439f);
            f1239.AddVertex(-1.69015f, 5.54734f, 0.46948f);
            faces.Add(f1239);

            Face f1240 = new Face(m02___Default);
            f1240.AddVertex(-1.45325f, 5.13774f, 0.47925f);
            f1240.AddVertex(-1.47874f, 5.13179f, 0.50416f);
            f1240.AddVertex(-1.60381f, 5.25590f, 0.47756f);
            f1240.AddVertex(-1.57831f, 5.26186f, 0.45266f);
            faces.Add(f1240);

            Face f1241 = new Face(m02___Default);
            f1241.AddVertex(-1.28321f, 5.07362f, 0.55758f);
            f1241.AddVertex(-1.30871f, 5.06767f, 0.58248f);
            f1241.AddVertex(-1.38970f, 5.07105f, 0.54378f);
            f1241.AddVertex(-1.36420f, 5.07701f, 0.51887f);
            faces.Add(f1241);

            Face f1242 = new Face(m02___Default);
            f1242.AddVertex(-1.07644f, 5.20532f, 0.62747f);
            f1242.AddVertex(-1.10194f, 5.19937f, 0.65238f);
            f1242.AddVertex(-1.23186f, 5.08067f, 0.61773f);
            f1242.AddVertex(-1.20637f, 5.08662f, 0.59282f);
            faces.Add(f1242);

            Face f1243 = new Face(m02___Default);
            f1243.AddVertex(-1.02069f, 5.63257f, 0.66791f);
            f1243.AddVertex(-1.04619f, 5.62662f, 0.69281f);
            f1243.AddVertex(-1.03261f, 5.55674f, 0.68249f);
            f1243.AddVertex(-1.00711f, 5.56270f, 0.65759f);
            faces.Add(f1243);

            Face f1244 = new Face(m02___Default);
            f1244.AddVertex(-1.04910f, 5.79543f, 0.71774f);
            f1244.AddVertex(-1.07460f, 5.78948f, 0.74264f);
            f1244.AddVertex(-1.06789f, 5.72376f, 0.71583f);
            f1244.AddVertex(-1.04238f, 5.72971f, 0.69092f);
            faces.Add(f1244);

            Face f1245 = new Face(m02___Default);
            f1245.AddVertex(-1.15229f, 5.91685f, 0.73153f);
            f1245.AddVertex(-1.17760f, 5.91076f, 0.75644f);
            f1245.AddVertex(-1.10823f, 5.85819f, 0.76187f);
            f1245.AddVertex(-1.08273f, 5.86414f, 0.73697f);
            faces.Add(f1245);

            Face f1246 = new Face(m02___Default);
            f1246.AddVertex(-1.31502f, 5.98683f, 0.69430f);
            f1246.AddVertex(-1.34052f, 5.98087f, 0.71920f);
            f1246.AddVertex(-1.25547f, 5.95578f, 0.74511f);
            f1246.AddVertex(-1.22997f, 5.96173f, 0.72020f);
            faces.Add(f1246);

            Face f1247 = new Face(m02___Default);
            f1247.AddVertex(-1.50563f, 5.94678f, 0.59237f);
            f1247.AddVertex(-1.53113f, 5.94082f, 0.61728f);
            f1247.AddVertex(-1.42401f, 5.98629f, 0.68352f);
            f1247.AddVertex(-1.39966f, 5.99191f, 0.65791f);
            faces.Add(f1247);

            Face f1248 = new Face(m02___Default);
            f1248.AddVertex(-1.62871f, 5.79521f, 0.51344f);
            f1248.AddVertex(-1.65421f, 5.78926f, 0.53834f);
            f1248.AddVertex(-1.60189f, 5.86905f, 0.56972f);
            f1248.AddVertex(-1.57639f, 5.87501f, 0.54482f);
            faces.Add(f1248);

            Face f1249 = new Face(m02___Default);
            f1249.AddVertex(-1.69015f, 5.54734f, 0.46948f);
            f1249.AddVertex(-1.71565f, 5.54139f, 0.49439f);
            f1249.AddVertex(-1.70451f, 5.67724f, 0.51207f);
            f1249.AddVertex(-1.67901f, 5.68320f, 0.48716f);
            faces.Add(f1249);

            Face f1250 = new Face(m02___Default);
            f1250.AddVertex(-1.57831f, 5.26186f, 0.45266f);
            f1250.AddVertex(-1.60381f, 5.25590f, 0.47756f);
            f1250.AddVertex(-1.67303f, 5.39481f, 0.48195f);
            f1250.AddVertex(-1.64753f, 5.40076f, 0.45705f);
            faces.Add(f1250);

            Face f1251 = new Face(m02___Default);
            f1251.AddVertex(-1.36420f, 5.07701f, 0.51887f);
            f1251.AddVertex(-1.38970f, 5.07105f, 0.54378f);
            f1251.AddVertex(-1.47874f, 5.13179f, 0.50416f);
            f1251.AddVertex(-1.45325f, 5.13774f, 0.47925f);
            faces.Add(f1251);

            Face f1252 = new Face(m02___Default);
            f1252.AddVertex(-1.20637f, 5.08662f, 0.59282f);
            f1252.AddVertex(-1.23186f, 5.08067f, 0.61773f);
            f1252.AddVertex(-1.30871f, 5.06767f, 0.58248f);
            f1252.AddVertex(-1.28321f, 5.07362f, 0.55758f);
            faces.Add(f1252);

            Face f1253 = new Face(m02___Default);
            f1253.AddVertex(-1.05541f, 5.36437f, 0.56878f);
            f1253.AddVertex(-1.31566f, 5.15888f, 0.50202f);
            f1253.AddVertex(-1.31995f, 5.15769f, 0.50610f);
            f1253.AddVertex(-1.05969f, 5.36316f, 0.57286f);
            faces.Add(f1253);

            Face f1254 = new Face(m02___Default);
            f1254.AddVertex(-1.31566f, 5.15888f, 0.50202f);
            f1254.AddVertex(-1.32981f, 5.07223f, 0.49812f);
            f1254.AddVertex(-1.33410f, 5.07103f, 0.50222f);
            f1254.AddVertex(-1.31995f, 5.15769f, 0.50610f);
            faces.Add(f1254);

            Face f1255 = new Face(m02___Default);
            f1255.AddVertex(-1.32981f, 5.07223f, 0.49812f);
            f1255.AddVertex(-1.33927f, 4.98726f, 0.50702f);
            f1255.AddVertex(-1.34356f, 4.98606f, 0.51110f);
            f1255.AddVertex(-1.33410f, 5.07103f, 0.50222f);
            faces.Add(f1255);

            Face f1256 = new Face(m02___Default);
            f1256.AddVertex(-1.33927f, 4.98726f, 0.50702f);
            f1256.AddVertex(-1.33855f, 4.91001f, 0.52319f);
            f1256.AddVertex(-1.34283f, 4.90881f, 0.52728f);
            f1256.AddVertex(-1.34356f, 4.98606f, 0.51110f);
            faces.Add(f1256);

            Face f1257 = new Face(m02___Default);
            f1257.AddVertex(-1.33855f, 4.91001f, 0.52319f);
            f1257.AddVertex(-1.32413f, 4.84604f, 0.54303f);
            f1257.AddVertex(-1.32842f, 4.84483f, 0.54712f);
            f1257.AddVertex(-1.34283f, 4.90881f, 0.52728f);
            faces.Add(f1257);

            Face f1258 = new Face(m02___Default);
            f1258.AddVertex(-1.32413f, 4.84604f, 0.54303f);
            f1258.AddVertex(-1.29502f, 4.79985f, 0.56514f);
            f1258.AddVertex(-1.29931f, 4.79865f, 0.56923f);
            f1258.AddVertex(-1.32842f, 4.84483f, 0.54712f);
            faces.Add(f1258);

            Face f1259 = new Face(m02___Default);
            f1259.AddVertex(-1.29502f, 4.79985f, 0.56514f);
            f1259.AddVertex(-1.25294f, 4.77441f, 0.58989f);
            f1259.AddVertex(-1.25723f, 4.77321f, 0.59398f);
            f1259.AddVertex(-1.29931f, 4.79865f, 0.56923f);
            faces.Add(f1259);

            Face f1260 = new Face(m02___Default);
            f1260.AddVertex(-1.25294f, 4.77441f, 0.58989f);
            f1260.AddVertex(-1.20227f, 4.77122f, 0.61832f);
            f1260.AddVertex(-1.20656f, 4.77002f, 0.62242f);
            f1260.AddVertex(-1.25723f, 4.77321f, 0.59398f);
            faces.Add(f1260);

            Face f1261 = new Face(m02___Default);
            f1261.AddVertex(-1.20227f, 4.77122f, 0.61832f);
            f1261.AddVertex(-1.14929f, 4.79042f, 0.65091f);
            f1261.AddVertex(-1.15358f, 4.78922f, 0.65499f);
            f1261.AddVertex(-1.20656f, 4.77002f, 0.62242f);
            faces.Add(f1261);

            Face f1262 = new Face(m02___Default);
            f1262.AddVertex(-1.14929f, 4.79042f, 0.65091f);
            f1262.AddVertex(-1.10045f, 4.83083f, 0.68640f);
            f1262.AddVertex(-1.10474f, 4.82963f, 0.69050f);
            f1262.AddVertex(-1.15358f, 4.78922f, 0.65499f);
            faces.Add(f1262);

            Face f1263 = new Face(m02___Default);
            f1263.AddVertex(-1.10045f, 4.83083f, 0.68640f);
            f1263.AddVertex(-1.05990f, 4.88981f, 0.72134f);
            f1263.AddVertex(-1.06416f, 4.88859f, 0.72543f);
            f1263.AddVertex(-1.10474f, 4.82963f, 0.69050f);
            faces.Add(f1263);

            Face f1264 = new Face(m02___Default);
            f1264.AddVertex(-1.05990f, 4.88981f, 0.72134f);
            f1264.AddVertex(-1.02716f, 4.96291f, 0.75026f);
            f1264.AddVertex(-1.03134f, 4.96154f, 0.75430f);
            f1264.AddVertex(-1.06416f, 4.88859f, 0.72543f);
            faces.Add(f1264);

            Face f1265 = new Face(m02___Default);
            f1265.AddVertex(-1.02716f, 4.96291f, 0.75026f);
            f1265.AddVertex(-0.99700f, 5.04420f, 0.76743f);
            f1265.AddVertex(-1.00094f, 5.04250f, 0.77136f);
            f1265.AddVertex(-1.03134f, 4.96154f, 0.75430f);
            faces.Add(f1265);

            Face f1266 = new Face(m02___Default);
            f1266.AddVertex(-0.99700f, 5.04420f, 0.76743f);
            f1266.AddVertex(-0.96328f, 5.12924f, 0.77033f);
            f1266.AddVertex(-0.96680f, 5.12692f, 0.77408f);
            f1266.AddVertex(-1.00094f, 5.04250f, 0.77136f);
            faces.Add(f1266);

            Face f1267 = new Face(m02___Default);
            f1267.AddVertex(-0.96328f, 5.12924f, 0.77033f);
            f1267.AddVertex(-0.92501f, 5.21794f, 0.76322f);
            f1267.AddVertex(-0.92801f, 5.21487f, 0.76674f);
            f1267.AddVertex(-0.96680f, 5.12692f, 0.77408f);
            faces.Add(f1267);

            Face f1268 = new Face(m02___Default);
            f1268.AddVertex(-0.92501f, 5.21794f, 0.76322f);
            f1268.AddVertex(-0.85689f, 5.32421f, 0.78738f);
            f1268.AddVertex(-0.85950f, 5.32057f, 0.79072f);
            f1268.AddVertex(-0.92801f, 5.21487f, 0.76674f);
            faces.Add(f1268);

            Face f1269 = new Face(m02___Default);
            f1269.AddVertex(-0.85689f, 5.32421f, 0.78738f);
            f1269.AddVertex(-0.88505f, 5.42816f, 0.67055f);
            f1269.AddVertex(-0.88916f, 5.42670f, 0.67456f);
            f1269.AddVertex(-0.85950f, 5.32057f, 0.79072f);
            faces.Add(f1269);

            Face f1270 = new Face(m02___Default);
            f1270.AddVertex(-0.88505f, 5.42816f, 0.67055f);
            f1270.AddVertex(-0.97571f, 5.38850f, 0.59541f);
            f1270.AddVertex(-0.97998f, 5.38726f, 0.59949f);
            f1270.AddVertex(-0.88916f, 5.42670f, 0.67456f);
            faces.Add(f1270);

            Face f1271 = new Face(m02___Default);
            f1271.AddVertex(-0.97571f, 5.38850f, 0.59541f);
            f1271.AddVertex(-1.05541f, 5.36437f, 0.56878f);
            f1271.AddVertex(-1.05969f, 5.36316f, 0.57286f);
            f1271.AddVertex(-0.97998f, 5.38726f, 0.59949f);
            faces.Add(f1271);

            Face f1272 = new Face(m02___Default);
            f1272.AddVertex(-1.05969f, 5.36316f, 0.57286f);
            f1272.AddVertex(-1.31995f, 5.15769f, 0.50610f);
            f1272.AddVertex(-1.32423f, 5.15649f, 0.51020f);
            f1272.AddVertex(-1.06395f, 5.36192f, 0.57695f);
            faces.Add(f1272);

            Face f1273 = new Face(m02___Default);
            f1273.AddVertex(-1.31995f, 5.15769f, 0.50610f);
            f1273.AddVertex(-1.33410f, 5.07103f, 0.50222f);
            f1273.AddVertex(-1.33839f, 5.06983f, 0.50630f);
            f1273.AddVertex(-1.32423f, 5.15649f, 0.51020f);
            faces.Add(f1273);

            Face f1274 = new Face(m02___Default);
            f1274.AddVertex(-1.33410f, 5.07103f, 0.50222f);
            f1274.AddVertex(-1.34356f, 4.98606f, 0.51110f);
            f1274.AddVertex(-1.34784f, 4.98486f, 0.51520f);
            f1274.AddVertex(-1.33839f, 5.06983f, 0.50630f);
            faces.Add(f1274);

            Face f1275 = new Face(m02___Default);
            f1275.AddVertex(-1.34356f, 4.98606f, 0.51110f);
            f1275.AddVertex(-1.34283f, 4.90881f, 0.52728f);
            f1275.AddVertex(-1.34712f, 4.90760f, 0.53137f);
            f1275.AddVertex(-1.34784f, 4.98486f, 0.51520f);
            faces.Add(f1275);

            Face f1276 = new Face(m02___Default);
            f1276.AddVertex(-1.34283f, 4.90881f, 0.52728f);
            f1276.AddVertex(-1.32842f, 4.84483f, 0.54712f);
            f1276.AddVertex(-1.33270f, 4.84363f, 0.55121f);
            f1276.AddVertex(-1.34712f, 4.90760f, 0.53137f);
            faces.Add(f1276);

            Face f1277 = new Face(m02___Default);
            f1277.AddVertex(-1.32842f, 4.84483f, 0.54712f);
            f1277.AddVertex(-1.29931f, 4.79865f, 0.56923f);
            f1277.AddVertex(-1.30359f, 4.79744f, 0.57332f);
            f1277.AddVertex(-1.33270f, 4.84363f, 0.55121f);
            faces.Add(f1277);

            Face f1278 = new Face(m02___Default);
            f1278.AddVertex(-1.29931f, 4.79865f, 0.56923f);
            f1278.AddVertex(-1.25723f, 4.77321f, 0.59398f);
            f1278.AddVertex(-1.26152f, 4.77201f, 0.59807f);
            f1278.AddVertex(-1.30359f, 4.79744f, 0.57332f);
            faces.Add(f1278);

            Face f1279 = new Face(m02___Default);
            f1279.AddVertex(-1.25723f, 4.77321f, 0.59398f);
            f1279.AddVertex(-1.20656f, 4.77002f, 0.62242f);
            f1279.AddVertex(-1.21085f, 4.76883f, 0.62650f);
            f1279.AddVertex(-1.26152f, 4.77201f, 0.59807f);
            faces.Add(f1279);

            Face f1280 = new Face(m02___Default);
            f1280.AddVertex(-1.20656f, 4.77002f, 0.62242f);
            f1280.AddVertex(-1.15358f, 4.78922f, 0.65499f);
            f1280.AddVertex(-1.15787f, 4.78803f, 0.65909f);
            f1280.AddVertex(-1.21085f, 4.76883f, 0.62650f);
            faces.Add(f1280);

            Face f1281 = new Face(m02___Default);
            f1281.AddVertex(-1.15358f, 4.78922f, 0.65499f);
            f1281.AddVertex(-1.10474f, 4.82963f, 0.69050f);
            f1281.AddVertex(-1.10903f, 4.82843f, 0.69459f);
            f1281.AddVertex(-1.15787f, 4.78803f, 0.65909f);
            faces.Add(f1281);

            Face f1282 = new Face(m02___Default);
            f1282.AddVertex(-1.10474f, 4.82963f, 0.69050f);
            f1282.AddVertex(-1.06416f, 4.88859f, 0.72543f);
            f1282.AddVertex(-1.06842f, 4.88735f, 0.72951f);
            f1282.AddVertex(-1.10903f, 4.82843f, 0.69459f);
            faces.Add(f1282);

            Face f1283 = new Face(m02___Default);
            f1283.AddVertex(-1.06416f, 4.88859f, 0.72543f);
            f1283.AddVertex(-1.03134f, 4.96154f, 0.75430f);
            f1283.AddVertex(-1.03551f, 4.96018f, 0.75834f);
            f1283.AddVertex(-1.06842f, 4.88735f, 0.72951f);
            faces.Add(f1283);

            Face f1284 = new Face(m02___Default);
            f1284.AddVertex(-1.03134f, 4.96154f, 0.75430f);
            f1284.AddVertex(-1.00094f, 5.04250f, 0.77136f);
            f1284.AddVertex(-1.00487f, 5.04078f, 0.77529f);
            f1284.AddVertex(-1.03551f, 4.96018f, 0.75834f);
            faces.Add(f1284);

            Face f1285 = new Face(m02___Default);
            f1285.AddVertex(-1.00094f, 5.04250f, 0.77136f);
            f1285.AddVertex(-0.96680f, 5.12692f, 0.77408f);
            f1285.AddVertex(-0.97030f, 5.12457f, 0.77781f);
            f1285.AddVertex(-1.00487f, 5.04078f, 0.77529f);
            faces.Add(f1285);

            Face f1286 = new Face(m02___Default);
            f1286.AddVertex(-0.96680f, 5.12692f, 0.77408f);
            f1286.AddVertex(-0.92801f, 5.21487f, 0.76674f);
            f1286.AddVertex(-0.93097f, 5.21173f, 0.77023f);
            f1286.AddVertex(-0.97030f, 5.12457f, 0.77781f);
            faces.Add(f1286);

            Face f1287 = new Face(m02___Default);
            f1287.AddVertex(-0.92801f, 5.21487f, 0.76674f);
            f1287.AddVertex(-0.85950f, 5.32057f, 0.79072f);
            f1287.AddVertex(-0.86203f, 5.31682f, 0.79403f);
            f1287.AddVertex(-0.93097f, 5.21173f, 0.77023f);
            faces.Add(f1287);

            Face f1288 = new Face(m02___Default);
            f1288.AddVertex(-0.85950f, 5.32057f, 0.79072f);
            f1288.AddVertex(-0.88916f, 5.42670f, 0.67456f);
            f1288.AddVertex(-0.89321f, 5.42514f, 0.67854f);
            f1288.AddVertex(-0.86203f, 5.31682f, 0.79403f);
            faces.Add(f1288);

            Face f1289 = new Face(m02___Default);
            f1289.AddVertex(-0.88916f, 5.42670f, 0.67456f);
            f1289.AddVertex(-0.97998f, 5.38726f, 0.59949f);
            f1289.AddVertex(-0.98421f, 5.38598f, 0.60356f);
            f1289.AddVertex(-0.89321f, 5.42514f, 0.67854f);
            faces.Add(f1289);

            Face f1290 = new Face(m02___Default);
            f1290.AddVertex(-0.97998f, 5.38726f, 0.59949f);
            f1290.AddVertex(-1.05969f, 5.36316f, 0.57286f);
            f1290.AddVertex(-1.06395f, 5.36192f, 0.57695f);
            f1290.AddVertex(-0.98421f, 5.38598f, 0.60356f);
            faces.Add(f1290);

            Face f1291 = new Face(m02___Default);
            f1291.AddVertex(-1.06395f, 5.36192f, 0.57695f);
            f1291.AddVertex(-1.32423f, 5.15649f, 0.51020f);
            f1291.AddVertex(-1.32852f, 5.15529f, 0.51429f);
            f1291.AddVertex(-1.06820f, 5.36066f, 0.58101f);
            faces.Add(f1291);

            Face f1292 = new Face(m02___Default);
            f1292.AddVertex(-1.32423f, 5.15649f, 0.51020f);
            f1292.AddVertex(-1.33839f, 5.06983f, 0.50630f);
            f1292.AddVertex(-1.34268f, 5.06863f, 0.51040f);
            f1292.AddVertex(-1.32852f, 5.15529f, 0.51429f);
            faces.Add(f1292);

            Face f1293 = new Face(m02___Default);
            f1293.AddVertex(-1.33839f, 5.06983f, 0.50630f);
            f1293.AddVertex(-1.34784f, 4.98486f, 0.51520f);
            f1293.AddVertex(-1.35213f, 4.98366f, 0.51929f);
            f1293.AddVertex(-1.34268f, 5.06863f, 0.51040f);
            faces.Add(f1293);

            Face f1294 = new Face(m02___Default);
            f1294.AddVertex(-1.34784f, 4.98486f, 0.51520f);
            f1294.AddVertex(-1.34712f, 4.90760f, 0.53137f);
            f1294.AddVertex(-1.35140f, 4.90639f, 0.53546f);
            f1294.AddVertex(-1.35213f, 4.98366f, 0.51929f);
            faces.Add(f1294);

            Face f1295 = new Face(m02___Default);
            f1295.AddVertex(-1.34712f, 4.90760f, 0.53137f);
            f1295.AddVertex(-1.33270f, 4.84363f, 0.55121f);
            f1295.AddVertex(-1.33699f, 4.84243f, 0.55530f);
            f1295.AddVertex(-1.35140f, 4.90639f, 0.53546f);
            faces.Add(f1295);

            Face f1296 = new Face(m02___Default);
            f1296.AddVertex(-1.33270f, 4.84363f, 0.55121f);
            f1296.AddVertex(-1.30359f, 4.79744f, 0.57332f);
            f1296.AddVertex(-1.30788f, 4.79624f, 0.57741f);
            f1296.AddVertex(-1.33699f, 4.84243f, 0.55530f);
            faces.Add(f1296);

            Face f1297 = new Face(m02___Default);
            f1297.AddVertex(-1.30359f, 4.79744f, 0.57332f);
            f1297.AddVertex(-1.26152f, 4.77201f, 0.59807f);
            f1297.AddVertex(-1.26581f, 4.77081f, 0.60217f);
            f1297.AddVertex(-1.30788f, 4.79624f, 0.57741f);
            faces.Add(f1297);

            Face f1298 = new Face(m02___Default);
            f1298.AddVertex(-1.26152f, 4.77201f, 0.59807f);
            f1298.AddVertex(-1.21085f, 4.76883f, 0.62650f);
            f1298.AddVertex(-1.21514f, 4.76763f, 0.63060f);
            f1298.AddVertex(-1.26581f, 4.77081f, 0.60217f);
            faces.Add(f1298);

            Face f1299 = new Face(m02___Default);
            f1299.AddVertex(-1.21085f, 4.76883f, 0.62650f);
            f1299.AddVertex(-1.15787f, 4.78803f, 0.65909f);
            f1299.AddVertex(-1.16216f, 4.78683f, 0.66318f);
            f1299.AddVertex(-1.21514f, 4.76763f, 0.63060f);
            faces.Add(f1299);

            Face f1300 = new Face(m02___Default);
            f1300.AddVertex(-1.15787f, 4.78803f, 0.65909f);
            f1300.AddVertex(-1.10903f, 4.82843f, 0.69459f);
            f1300.AddVertex(-1.11331f, 4.82723f, 0.69867f);
            f1300.AddVertex(-1.16216f, 4.78683f, 0.66318f);
            faces.Add(f1300);

            Face f1301 = new Face(m02___Default);
            f1301.AddVertex(-1.10903f, 4.82843f, 0.69459f);
            f1301.AddVertex(-1.06842f, 4.88735f, 0.72951f);
            f1301.AddVertex(-1.07269f, 4.88612f, 0.73359f);
            f1301.AddVertex(-1.11331f, 4.82723f, 0.69867f);
            faces.Add(f1301);

            Face f1302 = new Face(m02___Default);
            f1302.AddVertex(-1.06842f, 4.88735f, 0.72951f);
            f1302.AddVertex(-1.03551f, 4.96018f, 0.75834f);
            f1302.AddVertex(-1.03968f, 4.95881f, 0.76238f);
            f1302.AddVertex(-1.07269f, 4.88612f, 0.73359f);
            faces.Add(f1302);

            Face f1303 = new Face(m02___Default);
            f1303.AddVertex(-1.03551f, 4.96018f, 0.75834f);
            f1303.AddVertex(-1.00487f, 5.04078f, 0.77529f);
            f1303.AddVertex(-1.00879f, 5.03905f, 0.77922f);
            f1303.AddVertex(-1.03968f, 4.95881f, 0.76238f);
            faces.Add(f1303);

            Face f1304 = new Face(m02___Default);
            f1304.AddVertex(-1.00487f, 5.04078f, 0.77529f);
            f1304.AddVertex(-0.97030f, 5.12457f, 0.77781f);
            f1304.AddVertex(-0.97377f, 5.12219f, 0.78154f);
            f1304.AddVertex(-1.00879f, 5.03905f, 0.77922f);
            faces.Add(f1304);

            Face f1305 = new Face(m02___Default);
            f1305.AddVertex(-0.97030f, 5.12457f, 0.77781f);
            f1305.AddVertex(-0.93097f, 5.21173f, 0.77023f);
            f1305.AddVertex(-0.93388f, 5.20854f, 0.77371f);
            f1305.AddVertex(-0.97377f, 5.12219f, 0.78154f);
            faces.Add(f1305);

            Face f1306 = new Face(m02___Default);
            f1306.AddVertex(-0.93097f, 5.21173f, 0.77023f);
            f1306.AddVertex(-0.86203f, 5.31682f, 0.79403f);
            f1306.AddVertex(-0.86450f, 5.31296f, 0.79731f);
            f1306.AddVertex(-0.93388f, 5.20854f, 0.77371f);
            faces.Add(f1306);

            Face f1307 = new Face(m02___Default);
            f1307.AddVertex(-0.86203f, 5.31682f, 0.79403f);
            f1307.AddVertex(-0.89321f, 5.42514f, 0.67854f);
            f1307.AddVertex(-0.89718f, 5.42349f, 0.68249f);
            f1307.AddVertex(-0.86450f, 5.31296f, 0.79731f);
            faces.Add(f1307);

            Face f1308 = new Face(m02___Default);
            f1308.AddVertex(-0.89321f, 5.42514f, 0.67854f);
            f1308.AddVertex(-0.98421f, 5.38598f, 0.60356f);
            f1308.AddVertex(-0.98840f, 5.38464f, 0.60761f);
            f1308.AddVertex(-0.89718f, 5.42349f, 0.68249f);
            faces.Add(f1308);

            Face f1309 = new Face(m02___Default);
            f1309.AddVertex(-0.98421f, 5.38598f, 0.60356f);
            f1309.AddVertex(-1.06395f, 5.36192f, 0.57695f);
            f1309.AddVertex(-1.06820f, 5.36066f, 0.58101f);
            f1309.AddVertex(-0.98840f, 5.38464f, 0.60761f);
            faces.Add(f1309);

            Face f1310 = new Face(m02___Default);
            f1310.AddVertex(-1.06820f, 5.36066f, 0.58101f);
            f1310.AddVertex(-1.32852f, 5.15529f, 0.51429f);
            f1310.AddVertex(-1.33281f, 5.15410f, 0.51838f);
            f1310.AddVertex(-1.07242f, 5.35937f, 0.58508f);
            faces.Add(f1310);

            Face f1311 = new Face(m02___Default);
            f1311.AddVertex(-1.32852f, 5.15529f, 0.51429f);
            f1311.AddVertex(-1.34268f, 5.06863f, 0.51040f);
            f1311.AddVertex(-1.34697f, 5.06743f, 0.51449f);
            f1311.AddVertex(-1.33281f, 5.15410f, 0.51838f);
            faces.Add(f1311);

            Face f1312 = new Face(m02___Default);
            f1312.AddVertex(-1.34268f, 5.06863f, 0.51040f);
            f1312.AddVertex(-1.35213f, 4.98366f, 0.51929f);
            f1312.AddVertex(-1.35641f, 4.98246f, 0.52337f);
            f1312.AddVertex(-1.34697f, 5.06743f, 0.51449f);
            faces.Add(f1312);

            Face f1313 = new Face(m02___Default);
            f1313.AddVertex(-1.35213f, 4.98366f, 0.51929f);
            f1313.AddVertex(-1.35140f, 4.90639f, 0.53546f);
            f1313.AddVertex(-1.35568f, 4.90519f, 0.53955f);
            f1313.AddVertex(-1.35641f, 4.98246f, 0.52337f);
            faces.Add(f1313);

            Face f1314 = new Face(m02___Default);
            f1314.AddVertex(-1.35140f, 4.90639f, 0.53546f);
            f1314.AddVertex(-1.33699f, 4.84243f, 0.55530f);
            f1314.AddVertex(-1.34127f, 4.84122f, 0.55938f);
            f1314.AddVertex(-1.35568f, 4.90519f, 0.53955f);
            faces.Add(f1314);

            Face f1315 = new Face(m02___Default);
            f1315.AddVertex(-1.33699f, 4.84243f, 0.55530f);
            f1315.AddVertex(-1.30788f, 4.79624f, 0.57741f);
            f1315.AddVertex(-1.31217f, 4.79504f, 0.58150f);
            f1315.AddVertex(-1.34127f, 4.84122f, 0.55938f);
            faces.Add(f1315);

            Face f1316 = new Face(m02___Default);
            f1316.AddVertex(-1.30788f, 4.79624f, 0.57741f);
            f1316.AddVertex(-1.26581f, 4.77081f, 0.60217f);
            f1316.AddVertex(-1.27010f, 4.76962f, 0.60625f);
            f1316.AddVertex(-1.31217f, 4.79504f, 0.58150f);
            faces.Add(f1316);

            Face f1317 = new Face(m02___Default);
            f1317.AddVertex(-1.26581f, 4.77081f, 0.60217f);
            f1317.AddVertex(-1.21514f, 4.76763f, 0.63060f);
            f1317.AddVertex(-1.21943f, 4.76643f, 0.63469f);
            f1317.AddVertex(-1.27010f, 4.76962f, 0.60625f);
            faces.Add(f1317);

            Face f1318 = new Face(m02___Default);
            f1318.AddVertex(-1.21514f, 4.76763f, 0.63060f);
            f1318.AddVertex(-1.16216f, 4.78683f, 0.66318f);
            f1318.AddVertex(-1.16646f, 4.78563f, 0.66727f);
            f1318.AddVertex(-1.21943f, 4.76643f, 0.63469f);
            faces.Add(f1318);

            Face f1319 = new Face(m02___Default);
            f1319.AddVertex(-1.16216f, 4.78683f, 0.66318f);
            f1319.AddVertex(-1.11331f, 4.82723f, 0.69867f);
            f1319.AddVertex(-1.11760f, 4.82603f, 0.70277f);
            f1319.AddVertex(-1.16646f, 4.78563f, 0.66727f);
            faces.Add(f1319);

            Face f1320 = new Face(m02___Default);
            f1320.AddVertex(-1.11331f, 4.82723f, 0.69867f);
            f1320.AddVertex(-1.07269f, 4.88612f, 0.73359f);
            f1320.AddVertex(-1.07696f, 4.88489f, 0.73767f);
            f1320.AddVertex(-1.11760f, 4.82603f, 0.70277f);
            faces.Add(f1320);

            Face f1321 = new Face(m02___Default);
            f1321.AddVertex(-1.07269f, 4.88612f, 0.73359f);
            f1321.AddVertex(-1.03968f, 4.95881f, 0.76238f);
            f1321.AddVertex(-1.04385f, 4.95744f, 0.76642f);
            f1321.AddVertex(-1.07696f, 4.88489f, 0.73767f);
            faces.Add(f1321);

            Face f1322 = new Face(m02___Default);
            f1322.AddVertex(-1.03968f, 4.95881f, 0.76238f);
            f1322.AddVertex(-1.00879f, 5.03905f, 0.77922f);
            f1322.AddVertex(-1.01271f, 5.03731f, 0.78315f);
            f1322.AddVertex(-1.04385f, 4.95744f, 0.76642f);
            faces.Add(f1322);

            Face f1323 = new Face(m02___Default);
            f1323.AddVertex(-1.00879f, 5.03905f, 0.77922f);
            f1323.AddVertex(-0.97377f, 5.12219f, 0.78154f);
            f1323.AddVertex(-0.97723f, 5.11978f, 0.78526f);
            f1323.AddVertex(-1.01271f, 5.03731f, 0.78315f);
            faces.Add(f1323);

            Face f1324 = new Face(m02___Default);
            f1324.AddVertex(-0.97377f, 5.12219f, 0.78154f);
            f1324.AddVertex(-0.93388f, 5.20854f, 0.77371f);
            f1324.AddVertex(-0.93675f, 5.20527f, 0.77717f);
            f1324.AddVertex(-0.97723f, 5.11978f, 0.78526f);
            faces.Add(f1324);

            Face f1325 = new Face(m02___Default);
            f1325.AddVertex(-0.93388f, 5.20854f, 0.77371f);
            f1325.AddVertex(-0.86450f, 5.31296f, 0.79731f);
            f1325.AddVertex(-0.86688f, 5.30900f, 0.80054f);
            f1325.AddVertex(-0.93675f, 5.20527f, 0.77717f);
            faces.Add(f1325);

            Face f1326 = new Face(m02___Default);
            f1326.AddVertex(-0.86450f, 5.31296f, 0.79731f);
            f1326.AddVertex(-0.89718f, 5.42349f, 0.68249f);
            f1326.AddVertex(-0.90109f, 5.42174f, 0.68641f);
            f1326.AddVertex(-0.86688f, 5.30900f, 0.80054f);
            faces.Add(f1326);

            Face f1327 = new Face(m02___Default);
            f1327.AddVertex(-0.89718f, 5.42349f, 0.68249f);
            f1327.AddVertex(-0.98840f, 5.38464f, 0.60761f);
            f1327.AddVertex(-0.99255f, 5.38324f, 0.61164f);
            f1327.AddVertex(-0.90109f, 5.42174f, 0.68641f);
            faces.Add(f1327);

            Face f1328 = new Face(m02___Default);
            f1328.AddVertex(-0.98840f, 5.38464f, 0.60761f);
            f1328.AddVertex(-1.06820f, 5.36066f, 0.58101f);
            f1328.AddVertex(-1.07242f, 5.35937f, 0.58508f);
            f1328.AddVertex(-0.99255f, 5.38324f, 0.61164f);
            faces.Add(f1328);

            Face f1329 = new Face(m02___Default);
            f1329.AddVertex(-1.07242f, 5.35937f, 0.58508f);
            f1329.AddVertex(-1.33281f, 5.15410f, 0.51838f);
            f1329.AddVertex(-1.33710f, 5.15290f, 0.52247f);
            f1329.AddVertex(-1.07663f, 5.35805f, 0.58913f);
            faces.Add(f1329);

            Face f1330 = new Face(m02___Default);
            f1330.AddVertex(-1.33281f, 5.15410f, 0.51838f);
            f1330.AddVertex(-1.34697f, 5.06743f, 0.51449f);
            f1330.AddVertex(-1.35126f, 5.06624f, 0.51858f);
            f1330.AddVertex(-1.33710f, 5.15290f, 0.52247f);
            faces.Add(f1330);

            Face f1331 = new Face(m02___Default);
            f1331.AddVertex(-1.34697f, 5.06743f, 0.51449f);
            f1331.AddVertex(-1.35641f, 4.98246f, 0.52337f);
            f1331.AddVertex(-1.36070f, 4.98125f, 0.52747f);
            f1331.AddVertex(-1.35126f, 5.06624f, 0.51858f);
            faces.Add(f1331);

            Face f1332 = new Face(m02___Default);
            f1332.AddVertex(-1.35641f, 4.98246f, 0.52337f);
            f1332.AddVertex(-1.35568f, 4.90519f, 0.53955f);
            f1332.AddVertex(-1.35997f, 4.90398f, 0.54364f);
            f1332.AddVertex(-1.36070f, 4.98125f, 0.52747f);
            faces.Add(f1332);

            Face f1333 = new Face(m02___Default);
            f1333.AddVertex(-1.35568f, 4.90519f, 0.53955f);
            f1333.AddVertex(-1.34127f, 4.84122f, 0.55938f);
            f1333.AddVertex(-1.34556f, 4.84002f, 0.56347f);
            f1333.AddVertex(-1.35997f, 4.90398f, 0.54364f);
            faces.Add(f1333);

            Face f1334 = new Face(m02___Default);
            f1334.AddVertex(-1.34127f, 4.84122f, 0.55938f);
            f1334.AddVertex(-1.31217f, 4.79504f, 0.58150f);
            f1334.AddVertex(-1.31646f, 4.79384f, 0.58559f);
            f1334.AddVertex(-1.34556f, 4.84002f, 0.56347f);
            faces.Add(f1334);

            Face f1335 = new Face(m02___Default);
            f1335.AddVertex(-1.31217f, 4.79504f, 0.58150f);
            f1335.AddVertex(-1.27010f, 4.76962f, 0.60625f);
            f1335.AddVertex(-1.27439f, 4.76842f, 0.61034f);
            f1335.AddVertex(-1.31646f, 4.79384f, 0.58559f);
            faces.Add(f1335);

            Face f1336 = new Face(m02___Default);
            f1336.AddVertex(-1.27010f, 4.76962f, 0.60625f);
            f1336.AddVertex(-1.21943f, 4.76643f, 0.63469f);
            f1336.AddVertex(-1.22372f, 4.76523f, 0.63878f);
            f1336.AddVertex(-1.27439f, 4.76842f, 0.61034f);
            faces.Add(f1336);

            Face f1337 = new Face(m02___Default);
            f1337.AddVertex(-1.21943f, 4.76643f, 0.63469f);
            f1337.AddVertex(-1.16646f, 4.78563f, 0.66727f);
            f1337.AddVertex(-1.17075f, 4.78443f, 0.67136f);
            f1337.AddVertex(-1.22372f, 4.76523f, 0.63878f);
            faces.Add(f1337);

            Face f1338 = new Face(m02___Default);
            f1338.AddVertex(-1.16646f, 4.78563f, 0.66727f);
            f1338.AddVertex(-1.11760f, 4.82603f, 0.70277f);
            f1338.AddVertex(-1.12189f, 4.82483f, 0.70686f);
            f1338.AddVertex(-1.17075f, 4.78443f, 0.67136f);
            faces.Add(f1338);

            Face f1339 = new Face(m02___Default);
            f1339.AddVertex(-1.11760f, 4.82603f, 0.70277f);
            f1339.AddVertex(-1.07696f, 4.88489f, 0.73767f);
            f1339.AddVertex(-1.08122f, 4.88365f, 0.74175f);
            f1339.AddVertex(-1.12189f, 4.82483f, 0.70686f);
            faces.Add(f1339);

            Face f1340 = new Face(m02___Default);
            f1340.AddVertex(-1.07696f, 4.88489f, 0.73767f);
            f1340.AddVertex(-1.04385f, 4.95744f, 0.76642f);
            f1340.AddVertex(-1.04802f, 4.95606f, 0.77046f);
            f1340.AddVertex(-1.08122f, 4.88365f, 0.74175f);
            faces.Add(f1340);

            Face f1341 = new Face(m02___Default);
            f1341.AddVertex(-1.04385f, 4.95744f, 0.76642f);
            f1341.AddVertex(-1.01271f, 5.03731f, 0.78315f);
            f1341.AddVertex(-1.01662f, 5.03555f, 0.78707f);
            f1341.AddVertex(-1.04802f, 4.95606f, 0.77046f);
            faces.Add(f1341);

            Face f1342 = new Face(m02___Default);
            f1342.AddVertex(-1.01271f, 5.03731f, 0.78315f);
            f1342.AddVertex(-0.97723f, 5.11978f, 0.78526f);
            f1342.AddVertex(-0.98066f, 5.11733f, 0.78897f);
            f1342.AddVertex(-1.01662f, 5.03555f, 0.78707f);
            faces.Add(f1342);

            Face f1343 = new Face(m02___Default);
            f1343.AddVertex(-0.97723f, 5.11978f, 0.78526f);
            f1343.AddVertex(-0.93675f, 5.20527f, 0.77717f);
            f1343.AddVertex(-0.93958f, 5.20196f, 0.78061f);
            f1343.AddVertex(-0.98066f, 5.11733f, 0.78897f);
            faces.Add(f1343);

            Face f1344 = new Face(m02___Default);
            f1344.AddVertex(-0.93675f, 5.20527f, 0.77717f);
            f1344.AddVertex(-0.86688f, 5.30900f, 0.80054f);
            f1344.AddVertex(-0.86919f, 5.30494f, 0.80376f);
            f1344.AddVertex(-0.93958f, 5.20196f, 0.78061f);
            faces.Add(f1344);

            Face f1345 = new Face(m02___Default);
            f1345.AddVertex(-0.86688f, 5.30900f, 0.80054f);
            f1345.AddVertex(-0.90109f, 5.42174f, 0.68641f);
            f1345.AddVertex(-0.90493f, 5.41990f, 0.69030f);
            f1345.AddVertex(-0.86919f, 5.30494f, 0.80376f);
            faces.Add(f1345);

            Face f1346 = new Face(m02___Default);
            f1346.AddVertex(-0.90109f, 5.42174f, 0.68641f);
            f1346.AddVertex(-0.99255f, 5.38324f, 0.61164f);
            f1346.AddVertex(-0.99666f, 5.38178f, 0.61564f);
            f1346.AddVertex(-0.90493f, 5.41990f, 0.69030f);
            faces.Add(f1346);

            Face f1347 = new Face(m02___Default);
            f1347.AddVertex(-0.99255f, 5.38324f, 0.61164f);
            f1347.AddVertex(-1.07242f, 5.35937f, 0.58508f);
            f1347.AddVertex(-1.07663f, 5.35805f, 0.58913f);
            f1347.AddVertex(-0.99666f, 5.38178f, 0.61564f);
            faces.Add(f1347);

            Face f1348 = new Face(m02___Default);
            f1348.AddVertex(-0.97571f, 5.38850f, 0.59541f);
            f1348.AddVertex(-0.88505f, 5.42816f, 0.67055f);
            f1348.AddVertex(-0.85689f, 5.32421f, 0.78738f);
            f1348.AddVertex(-0.96328f, 5.12924f, 0.77033f);
            faces.Add(f1348);

            Face f1349 = new Face(m02___Default);
            f1349.AddVertex(-0.85689f, 5.32421f, 0.78738f);
            f1349.AddVertex(-0.92501f, 5.21794f, 0.76322f);
            f1349.AddVertex(-0.96328f, 5.12924f, 0.77033f);
            faces.Add(f1349);

            Face f1350 = new Face(m02___Default);
            f1350.AddVertex(-1.32981f, 5.07223f, 0.49812f);
            f1350.AddVertex(-0.97571f, 5.38850f, 0.59541f);
            f1350.AddVertex(-0.96328f, 5.12924f, 0.77033f);
            f1350.AddVertex(-1.29502f, 4.79985f, 0.56514f);
            faces.Add(f1350);

            Face f1351 = new Face(m02___Default);
            f1351.AddVertex(-1.10045f, 4.83083f, 0.68640f);
            f1351.AddVertex(-1.29502f, 4.79985f, 0.56514f);
            f1351.AddVertex(-0.96328f, 5.12924f, 0.77033f);
            f1351.AddVertex(-1.02716f, 4.96291f, 0.75026f);
            faces.Add(f1351);

            Face f1352 = new Face(m02___Default);
            f1352.AddVertex(-0.96328f, 5.12924f, 0.77033f);
            f1352.AddVertex(-0.99700f, 5.04420f, 0.76743f);
            f1352.AddVertex(-1.02716f, 4.96291f, 0.75026f);
            faces.Add(f1352);

            Face f1353 = new Face(m02___Default);
            f1353.AddVertex(-1.02716f, 4.96291f, 0.75026f);
            f1353.AddVertex(-1.05990f, 4.88981f, 0.72134f);
            f1353.AddVertex(-1.10045f, 4.83083f, 0.68640f);
            faces.Add(f1353);

            Face f1354 = new Face(m02___Default);
            f1354.AddVertex(-1.20227f, 4.77122f, 0.61832f);
            f1354.AddVertex(-1.29502f, 4.79985f, 0.56514f);
            f1354.AddVertex(-1.10045f, 4.83083f, 0.68640f);
            f1354.AddVertex(-1.14929f, 4.79042f, 0.65091f);
            faces.Add(f1354);

            Face f1355 = new Face(m02___Default);
            f1355.AddVertex(-1.20227f, 4.77122f, 0.61832f);
            f1355.AddVertex(-1.25294f, 4.77441f, 0.58989f);
            f1355.AddVertex(-1.29502f, 4.79985f, 0.56514f);
            faces.Add(f1355);

            Face f1356 = new Face(m02___Default);
            f1356.AddVertex(-1.33855f, 4.91001f, 0.52319f);
            f1356.AddVertex(-1.32981f, 5.07223f, 0.49812f);
            f1356.AddVertex(-1.29502f, 4.79985f, 0.56514f);
            f1356.AddVertex(-1.32413f, 4.84604f, 0.54303f);
            faces.Add(f1356);

            Face f1357 = new Face(m02___Default);
            f1357.AddVertex(-1.33855f, 4.91001f, 0.52319f);
            f1357.AddVertex(-1.33927f, 4.98726f, 0.50702f);
            f1357.AddVertex(-1.32981f, 5.07223f, 0.49812f);
            faces.Add(f1357);

            Face f1358 = new Face(m02___Default);
            f1358.AddVertex(-0.97571f, 5.38850f, 0.59541f);
            f1358.AddVertex(-1.32981f, 5.07223f, 0.49812f);
            f1358.AddVertex(-1.31566f, 5.15888f, 0.50202f);
            f1358.AddVertex(-1.05541f, 5.36437f, 0.56878f);
            faces.Add(f1358);

            Face f1359 = new Face(m02___Default);
            f1359.AddVertex(-1.33710f, 5.15290f, 0.52247f);
            f1359.AddVertex(-1.35126f, 5.06624f, 0.51858f);
            f1359.AddVertex(-1.36070f, 4.98125f, 0.52747f);
            f1359.AddVertex(-1.34556f, 4.84002f, 0.56347f);
            faces.Add(f1359);

            Face f1360 = new Face(m02___Default);
            f1360.AddVertex(-1.36070f, 4.98125f, 0.52747f);
            f1360.AddVertex(-1.35997f, 4.90398f, 0.54364f);
            f1360.AddVertex(-1.34556f, 4.84002f, 0.56347f);
            faces.Add(f1360);

            Face f1361 = new Face(m02___Default);
            f1361.AddVertex(-0.90493f, 5.41990f, 0.69030f);
            f1361.AddVertex(-1.33710f, 5.15290f, 0.52247f);
            f1361.AddVertex(-1.34556f, 4.84002f, 0.56347f);
            f1361.AddVertex(-1.01662f, 5.03555f, 0.78707f);
            faces.Add(f1361);

            Face f1362 = new Face(m02___Default);
            f1362.AddVertex(-1.17075f, 4.78443f, 0.67136f);
            f1362.AddVertex(-1.01662f, 5.03555f, 0.78707f);
            f1362.AddVertex(-1.34556f, 4.84002f, 0.56347f);
            f1362.AddVertex(-1.27439f, 4.76842f, 0.61034f);
            faces.Add(f1362);

            Face f1363 = new Face(m02___Default);
            f1363.AddVertex(-1.34556f, 4.84002f, 0.56347f);
            f1363.AddVertex(-1.31646f, 4.79384f, 0.58559f);
            f1363.AddVertex(-1.27439f, 4.76842f, 0.61034f);
            faces.Add(f1363);

            Face f1364 = new Face(m02___Default);
            f1364.AddVertex(-1.27439f, 4.76842f, 0.61034f);
            f1364.AddVertex(-1.22372f, 4.76523f, 0.63878f);
            f1364.AddVertex(-1.17075f, 4.78443f, 0.67136f);
            faces.Add(f1364);

            Face f1365 = new Face(m02___Default);
            f1365.AddVertex(-1.08122f, 4.88365f, 0.74175f);
            f1365.AddVertex(-1.01662f, 5.03555f, 0.78707f);
            f1365.AddVertex(-1.17075f, 4.78443f, 0.67136f);
            f1365.AddVertex(-1.12189f, 4.82483f, 0.70686f);
            faces.Add(f1365);

            Face f1366 = new Face(m02___Default);
            f1366.AddVertex(-1.08122f, 4.88365f, 0.74175f);
            f1366.AddVertex(-1.04802f, 4.95606f, 0.77046f);
            f1366.AddVertex(-1.01662f, 5.03555f, 0.78707f);
            faces.Add(f1366);

            Face f1367 = new Face(m02___Default);
            f1367.AddVertex(-0.93958f, 5.20196f, 0.78061f);
            f1367.AddVertex(-0.90493f, 5.41990f, 0.69030f);
            f1367.AddVertex(-1.01662f, 5.03555f, 0.78707f);
            f1367.AddVertex(-0.98066f, 5.11733f, 0.78897f);
            faces.Add(f1367);

            Face f1368 = new Face(m02___Default);
            f1368.AddVertex(-0.93958f, 5.20196f, 0.78061f);
            f1368.AddVertex(-0.86919f, 5.30494f, 0.80376f);
            f1368.AddVertex(-0.90493f, 5.41990f, 0.69030f);
            faces.Add(f1368);

            Face f1369 = new Face(m02___Default);
            f1369.AddVertex(-1.33710f, 5.15290f, 0.52247f);
            f1369.AddVertex(-0.90493f, 5.41990f, 0.69030f);
            f1369.AddVertex(-0.99666f, 5.38178f, 0.61564f);
            f1369.AddVertex(-1.07663f, 5.35805f, 0.58913f);
            faces.Add(f1369);

            Face f1370 = new Face(m02___Default);
            f1370.AddVertex(-0.38517f, 4.18627f, 0.77828f);
            f1370.AddVertex(-0.18508f, 4.00610f, 0.76613f);
            f1370.AddVertex(-0.03762f, 3.88106f, 0.76913f);
            f1370.AddVertex(0.14913f, 3.85729f, 0.81052f);
            faces.Add(f1370);

            Face f1371 = new Face(m02___Default);
            f1371.AddVertex(-0.03762f, 3.88106f, 0.76913f);
            f1371.AddVertex(0.05451f, 3.86224f, 0.78533f);
            f1371.AddVertex(0.14913f, 3.85729f, 0.81052f);
            faces.Add(f1371);

            Face f1372 = new Face(m02___Default);
            f1372.AddVertex(0.38616f, 4.28534f, 0.98313f);
            f1372.AddVertex(-0.38517f, 4.18627f, 0.77828f);
            f1372.AddVertex(0.14913f, 3.85729f, 0.81052f);
            f1372.AddVertex(0.34415f, 4.01254f, 0.91541f);
            faces.Add(f1372);

            Face f1373 = new Face(m02___Default);
            f1373.AddVertex(0.14913f, 3.85729f, 0.81052f);
            f1373.AddVertex(0.24282f, 3.90646f, 0.85139f);
            f1373.AddVertex(0.34415f, 4.01254f, 0.91541f);
            faces.Add(f1373);

            Face f1374 = new Face(m02___Default);
            f1374.AddVertex(0.34415f, 4.01254f, 0.91541f);
            f1374.AddVertex(0.37812f, 4.14262f, 0.95532f);
            f1374.AddVertex(0.38616f, 4.28534f, 0.98313f);
            faces.Add(f1374);

            Face f1375 = new Face(m02___Default);
            f1375.AddVertex(0.11998f, 4.72450f, 0.92524f);
            f1375.AddVertex(-0.38517f, 4.18627f, 0.77828f);
            f1375.AddVertex(0.38616f, 4.28534f, 0.98313f);
            f1375.AddVertex(0.21748f, 4.64086f, 0.95008f);
            faces.Add(f1375);

            Face f1376 = new Face(m02___Default);
            f1376.AddVertex(0.21748f, 4.64086f, 0.95008f);
            f1376.AddVertex(0.38616f, 4.28534f, 0.98313f);
            f1376.AddVertex(0.35321f, 4.42674f, 0.98575f);
            f1376.AddVertex(0.28728f, 4.55046f, 0.96902f);
            faces.Add(f1376);

            Face f1377 = new Face(m02___Default);
            f1377.AddVertex(-0.38517f, 4.18627f, 0.77828f);
            f1377.AddVertex(0.11998f, 4.72450f, 0.92524f);
            f1377.AddVertex(-0.02338f, 4.78222f, 0.89407f);
            f1377.AddVertex(-0.30323f, 4.36658f, 0.80380f);
            faces.Add(f1377);

            Face f1378 = new Face(m02___Default);
            f1378.AddVertex(-0.30738f, 4.43635f, 0.81245f);
            f1378.AddVertex(-0.30323f, 4.36658f, 0.80380f);
            f1378.AddVertex(-0.02338f, 4.78222f, 0.89407f);
            f1378.AddVertex(-0.11858f, 4.78232f, 0.87634f);
            faces.Add(f1378);

            Face f1379 = new Face(m02___Default);
            f1379.AddVertex(-0.11858f, 4.78232f, 0.87634f);
            f1379.AddVertex(-0.31834f, 4.53323f, 0.82419f);
            f1379.AddVertex(-0.30738f, 4.43635f, 0.81245f);
            faces.Add(f1379);

            Face f1380 = new Face(m02___Default);
            f1380.AddVertex(-0.11858f, 4.78232f, 0.87634f);
            f1380.AddVertex(-0.20827f, 4.76094f, 0.86186f);
            f1380.AddVertex(-0.27900f, 4.71802f, 0.85012f);
            f1380.AddVertex(-0.31834f, 4.53323f, 0.82419f);
            faces.Add(f1380);

            Face f1381 = new Face(m02___Default);
            f1381.AddVertex(-0.34235f, 4.59887f, 0.83141f);
            f1381.AddVertex(-0.31834f, 4.53323f, 0.82419f);
            f1381.AddVertex(-0.27900f, 4.71802f, 0.85012f);
            f1381.AddVertex(-0.33717f, 4.66701f, 0.84026f);
            faces.Add(f1381);

            Face f1382 = new Face(m02___Default);
            f1382.AddVertex(0.38902f, 4.14863f, 0.92646f);
            f1382.AddVertex(0.35505f, 4.01855f, 0.88655f);
            f1382.AddVertex(0.25372f, 3.91248f, 0.82253f);
            f1382.AddVertex(-0.02672f, 3.88707f, 0.74027f);
            faces.Add(f1382);

            Face f1383 = new Face(m02___Default);
            f1383.AddVertex(-0.02672f, 3.88707f, 0.74027f);
            f1383.AddVertex(0.25372f, 3.91248f, 0.82253f);
            f1383.AddVertex(0.16004f, 3.86331f, 0.78165f);
            f1383.AddVertex(0.06542f, 3.86826f, 0.75646f);
            faces.Add(f1383);

            Face f1384 = new Face(m02___Default);
            f1384.AddVertex(-0.01102f, 4.78813f, 0.86551f);
            f1384.AddVertex(0.38902f, 4.14863f, 0.92646f);
            f1384.AddVertex(-0.02672f, 3.88707f, 0.74027f);
            f1384.AddVertex(-0.37427f, 4.19228f, 0.74942f);
            faces.Add(f1384);

            Face f1385 = new Face(m02___Default);
            f1385.AddVertex(-0.02672f, 3.88707f, 0.74027f);
            f1385.AddVertex(-0.17418f, 4.01211f, 0.73727f);
            f1385.AddVertex(-0.37427f, 4.19228f, 0.74942f);
            faces.Add(f1385);

            Face f1386 = new Face(m02___Default);
            f1386.AddVertex(-0.01102f, 4.78813f, 0.86551f);
            f1386.AddVertex(-0.37427f, 4.19228f, 0.74942f);
            f1386.AddVertex(-0.29234f, 4.37260f, 0.77493f);
            f1386.AddVertex(-0.29647f, 4.44236f, 0.78358f);
            faces.Add(f1386);

            Face f1387 = new Face(m02___Default);
            f1387.AddVertex(-0.19736f, 4.76696f, 0.83300f);
            f1387.AddVertex(-0.01102f, 4.78813f, 0.86551f);
            f1387.AddVertex(-0.29647f, 4.44236f, 0.78358f);
            f1387.AddVertex(-0.30743f, 4.53924f, 0.79533f);
            faces.Add(f1387);

            Face f1388 = new Face(m02___Default);
            f1388.AddVertex(-0.19736f, 4.76696f, 0.83300f);
            f1388.AddVertex(-0.30743f, 4.53924f, 0.79533f);
            f1388.AddVertex(-0.33145f, 4.60489f, 0.80255f);
            f1388.AddVertex(-0.26795f, 4.72416f, 0.82128f);
            faces.Add(f1388);

            Face f1389 = new Face(m02___Default);
            f1389.AddVertex(-0.33145f, 4.60489f, 0.80255f);
            f1389.AddVertex(-0.32627f, 4.67302f, 0.81139f);
            f1389.AddVertex(-0.26795f, 4.72416f, 0.82128f);
            faces.Add(f1389);

            Face f1390 = new Face(m02___Default);
            f1390.AddVertex(-0.19736f, 4.76696f, 0.83300f);
            f1390.AddVertex(-0.10768f, 4.78833f, 0.84747f);
            f1390.AddVertex(-0.01102f, 4.78813f, 0.86551f);
            faces.Add(f1390);

            Face f1391 = new Face(m02___Default);
            f1391.AddVertex(0.22837f, 4.64687f, 0.92121f);
            f1391.AddVertex(0.38902f, 4.14863f, 0.92646f);
            f1391.AddVertex(-0.01102f, 4.78813f, 0.86551f);
            f1391.AddVertex(0.13089f, 4.73052f, 0.89638f);
            faces.Add(f1391);

            Face f1392 = new Face(m02___Default);
            f1392.AddVertex(0.39706f, 4.29135f, 0.95427f);
            f1392.AddVertex(0.38902f, 4.14863f, 0.92646f);
            f1392.AddVertex(0.22837f, 4.64687f, 0.92121f);
            f1392.AddVertex(0.36410f, 4.43275f, 0.95688f);
            faces.Add(f1392);

            Face f1393 = new Face(m02___Default);
            f1393.AddVertex(0.22837f, 4.64687f, 0.92121f);
            f1393.AddVertex(0.29817f, 4.55647f, 0.94015f);
            f1393.AddVertex(0.36410f, 4.43275f, 0.95688f);
            faces.Add(f1393);

            Face f1394 = new Face(m02___Default);
            f1394.AddVertex(-0.31834f, 4.53323f, 0.82419f);
            f1394.AddVertex(-0.30743f, 4.53924f, 0.79533f);
            f1394.AddVertex(-0.29647f, 4.44236f, 0.78358f);
            f1394.AddVertex(-0.30738f, 4.43635f, 0.81245f);
            faces.Add(f1394);

            Face f1395 = new Face(m02___Default);
            f1395.AddVertex(-0.33717f, 4.66701f, 0.84026f);
            f1395.AddVertex(-0.32627f, 4.67302f, 0.81139f);
            f1395.AddVertex(-0.33145f, 4.60489f, 0.80255f);
            f1395.AddVertex(-0.34235f, 4.59887f, 0.83141f);
            faces.Add(f1395);

            Face f1396 = new Face(m02___Default);
            f1396.AddVertex(-0.20827f, 4.76094f, 0.86186f);
            f1396.AddVertex(-0.19736f, 4.76696f, 0.83300f);
            f1396.AddVertex(-0.26795f, 4.72416f, 0.82128f);
            f1396.AddVertex(-0.27870f, 4.71828f, 0.85017f);
            faces.Add(f1396);

            Face f1397 = new Face(m02___Default);
            f1397.AddVertex(-0.02038f, 4.78169f, 0.89465f);
            f1397.AddVertex(-0.01102f, 4.78813f, 0.86551f);
            f1397.AddVertex(-0.10768f, 4.78833f, 0.84747f);
            f1397.AddVertex(-0.11858f, 4.78232f, 0.87634f);
            faces.Add(f1397);

            Face f1398 = new Face(m02___Default);
            f1398.AddVertex(0.21748f, 4.64086f, 0.95008f);
            f1398.AddVertex(0.22837f, 4.64687f, 0.92121f);
            f1398.AddVertex(0.13089f, 4.73052f, 0.89638f);
            f1398.AddVertex(0.11998f, 4.72450f, 0.92524f);
            faces.Add(f1398);

            Face f1399 = new Face(m02___Default);
            f1399.AddVertex(0.35321f, 4.42674f, 0.98575f);
            f1399.AddVertex(0.36410f, 4.43275f, 0.95688f);
            f1399.AddVertex(0.29817f, 4.55647f, 0.94015f);
            f1399.AddVertex(0.28728f, 4.55046f, 0.96902f);
            faces.Add(f1399);

            Face f1400 = new Face(m02___Default);
            f1400.AddVertex(0.37812f, 4.14262f, 0.95532f);
            f1400.AddVertex(0.38902f, 4.14863f, 0.92646f);
            f1400.AddVertex(0.39706f, 4.29135f, 0.95427f);
            f1400.AddVertex(0.38616f, 4.28534f, 0.98313f);
            faces.Add(f1400);

            Face f1401 = new Face(m02___Default);
            f1401.AddVertex(0.24282f, 3.90646f, 0.85139f);
            f1401.AddVertex(0.25372f, 3.91248f, 0.82253f);
            f1401.AddVertex(0.35505f, 4.01855f, 0.88655f);
            f1401.AddVertex(0.34415f, 4.01254f, 0.91541f);
            faces.Add(f1401);

            Face f1402 = new Face(m02___Default);
            f1402.AddVertex(0.05451f, 3.86224f, 0.78533f);
            f1402.AddVertex(0.06542f, 3.86826f, 0.75646f);
            f1402.AddVertex(0.16004f, 3.86331f, 0.78165f);
            f1402.AddVertex(0.14913f, 3.85729f, 0.81052f);
            faces.Add(f1402);

            Face f1403 = new Face(m02___Default);
            f1403.AddVertex(-0.18508f, 4.00610f, 0.76613f);
            f1403.AddVertex(-0.17418f, 4.01211f, 0.73727f);
            f1403.AddVertex(-0.02672f, 3.88707f, 0.74027f);
            f1403.AddVertex(-0.03762f, 3.88106f, 0.76913f);
            faces.Add(f1403);

            Face f1404 = new Face(m02___Default);
            f1404.AddVertex(-0.30738f, 4.43635f, 0.81245f);
            f1404.AddVertex(-0.29647f, 4.44236f, 0.78358f);
            f1404.AddVertex(-0.29234f, 4.37260f, 0.77493f);
            f1404.AddVertex(-0.30323f, 4.36658f, 0.80380f);
            faces.Add(f1404);

            Face f1405 = new Face(m02___Default);
            f1405.AddVertex(-0.34235f, 4.59887f, 0.83141f);
            f1405.AddVertex(-0.33145f, 4.60489f, 0.80255f);
            f1405.AddVertex(-0.30743f, 4.53924f, 0.79533f);
            f1405.AddVertex(-0.31834f, 4.53323f, 0.82419f);
            faces.Add(f1405);

            Face f1406 = new Face(m02___Default);
            f1406.AddVertex(-0.27870f, 4.71828f, 0.85017f);
            f1406.AddVertex(-0.26795f, 4.72416f, 0.82128f);
            f1406.AddVertex(-0.32627f, 4.67302f, 0.81139f);
            f1406.AddVertex(-0.33717f, 4.66701f, 0.84026f);
            faces.Add(f1406);

            Face f1407 = new Face(m02___Default);
            f1407.AddVertex(-0.11858f, 4.78232f, 0.87634f);
            f1407.AddVertex(-0.10768f, 4.78833f, 0.84747f);
            f1407.AddVertex(-0.19736f, 4.76696f, 0.83300f);
            f1407.AddVertex(-0.20827f, 4.76094f, 0.86186f);
            faces.Add(f1407);

            Face f1408 = new Face(m02___Default);
            f1408.AddVertex(0.11998f, 4.72450f, 0.92524f);
            f1408.AddVertex(0.13089f, 4.73052f, 0.89638f);
            f1408.AddVertex(-0.01102f, 4.78813f, 0.86551f);
            f1408.AddVertex(-0.02038f, 4.78169f, 0.89465f);
            faces.Add(f1408);

            Face f1409 = new Face(m02___Default);
            f1409.AddVertex(0.28728f, 4.55046f, 0.96902f);
            f1409.AddVertex(0.29817f, 4.55647f, 0.94015f);
            f1409.AddVertex(0.22837f, 4.64687f, 0.92121f);
            f1409.AddVertex(0.21748f, 4.64086f, 0.95008f);
            faces.Add(f1409);

            Face f1410 = new Face(m02___Default);
            f1410.AddVertex(0.38616f, 4.28534f, 0.98313f);
            f1410.AddVertex(0.39706f, 4.29135f, 0.95427f);
            f1410.AddVertex(0.36410f, 4.43275f, 0.95688f);
            f1410.AddVertex(0.35321f, 4.42674f, 0.98575f);
            faces.Add(f1410);

            Face f1411 = new Face(m02___Default);
            f1411.AddVertex(0.34415f, 4.01254f, 0.91541f);
            f1411.AddVertex(0.35505f, 4.01855f, 0.88655f);
            f1411.AddVertex(0.38902f, 4.14863f, 0.92646f);
            f1411.AddVertex(0.37812f, 4.14262f, 0.95532f);
            faces.Add(f1411);

            Face f1412 = new Face(m02___Default);
            f1412.AddVertex(0.14913f, 3.85729f, 0.81052f);
            f1412.AddVertex(0.16004f, 3.86331f, 0.78165f);
            f1412.AddVertex(0.25372f, 3.91248f, 0.82253f);
            f1412.AddVertex(0.24282f, 3.90646f, 0.85139f);
            faces.Add(f1412);

            Face f1413 = new Face(m02___Default);
            f1413.AddVertex(-0.03762f, 3.88106f, 0.76913f);
            f1413.AddVertex(-0.02672f, 3.88707f, 0.74027f);
            f1413.AddVertex(0.06542f, 3.86826f, 0.75646f);
            f1413.AddVertex(0.05451f, 3.86224f, 0.78533f);
            faces.Add(f1413);

            Face f1414 = new Face(m02___Default);
            f1414.AddVertex(-0.39433f, 4.12707f, 0.74893f);
            f1414.AddVertex(-0.46424f, 3.93227f, 0.73324f);
            f1414.AddVertex(-0.46703f, 3.93080f, 0.73857f);
            f1414.AddVertex(-0.39667f, 4.12603f, 0.75374f);
            faces.Add(f1414);

            Face f1415 = new Face(m02___Default);
            f1415.AddVertex(-0.46424f, 3.93227f, 0.73324f);
            f1415.AddVertex(-0.39479f, 3.85025f, 0.73741f);
            f1415.AddVertex(-0.39775f, 3.84859f, 0.74295f);
            f1415.AddVertex(-0.46703f, 3.93080f, 0.73857f);
            faces.Add(f1415);

            Face f1416 = new Face(m02___Default);
            f1416.AddVertex(-0.39479f, 3.85025f, 0.73741f);
            f1416.AddVertex(-0.32141f, 3.76684f, 0.74998f);
            f1416.AddVertex(-0.32441f, 3.76516f, 0.75557f);
            f1416.AddVertex(-0.39775f, 3.84859f, 0.74295f);
            faces.Add(f1416);

            Face f1417 = new Face(m02___Default);
            f1417.AddVertex(-0.32141f, 3.76684f, 0.74998f);
            f1417.AddVertex(-0.24396f, 3.69171f, 0.76284f);
            f1417.AddVertex(-0.24683f, 3.69014f, 0.76828f);
            f1417.AddVertex(-0.32441f, 3.76516f, 0.75557f);
            faces.Add(f1417);

            Face f1418 = new Face(m02___Default);
            f1418.AddVertex(-0.24396f, 3.69171f, 0.76284f);
            f1418.AddVertex(-0.16624f, 3.63156f, 0.77396f);
            f1418.AddVertex(-0.16892f, 3.63019f, 0.77917f);
            f1418.AddVertex(-0.24683f, 3.69014f, 0.76828f);
            faces.Add(f1418);

            Face f1419 = new Face(m02___Default);
            f1419.AddVertex(-0.16624f, 3.63156f, 0.77396f);
            f1419.AddVertex(-0.09328f, 3.58996f, 0.78486f);
            f1419.AddVertex(-0.09578f, 3.58877f, 0.78985f);
            f1419.AddVertex(-0.16892f, 3.63019f, 0.77917f);
            faces.Add(f1419);

            Face f1420 = new Face(m02___Default);
            f1420.AddVertex(-0.09328f, 3.58996f, 0.78486f);
            f1420.AddVertex(-0.02830f, 3.56856f, 0.79663f);
            f1420.AddVertex(-0.03069f, 3.56747f, 0.80149f);
            f1420.AddVertex(-0.09578f, 3.58877f, 0.78985f);
            faces.Add(f1420);

            Face f1421 = new Face(m02___Default);
            f1421.AddVertex(-0.02830f, 3.56856f, 0.79663f);
            f1421.AddVertex(0.02791f, 3.56752f, 0.80837f);
            f1421.AddVertex(0.02557f, 3.56649f, 0.81317f);
            f1421.AddVertex(-0.03069f, 3.56747f, 0.80149f);
            faces.Add(f1421);

            Face f1422 = new Face(m02___Default);
            f1422.AddVertex(0.02791f, 3.56752f, 0.80837f);
            f1422.AddVertex(0.07592f, 3.58566f, 0.81750f);
            f1422.AddVertex(0.07358f, 3.58461f, 0.82230f);
            f1422.AddVertex(0.02557f, 3.56649f, 0.81317f);
            faces.Add(f1422);

            Face f1423 = new Face(m02___Default);
            f1423.AddVertex(0.07592f, 3.58566f, 0.81750f);
            f1423.AddVertex(0.11631f, 3.62079f, 0.82081f);
            f1423.AddVertex(0.11394f, 3.61973f, 0.82563f);
            f1423.AddVertex(0.07358f, 3.58461f, 0.82230f);
            faces.Add(f1423);

            Face f1424 = new Face(m02___Default);
            f1424.AddVertex(0.11631f, 3.62079f, 0.82081f);
            f1424.AddVertex(0.14884f, 3.67029f, 0.81538f);
            f1424.AddVertex(0.14646f, 3.66922f, 0.82021f);
            f1424.AddVertex(0.11394f, 3.61973f, 0.82563f);
            faces.Add(f1424);

            Face f1425 = new Face(m02___Default);
            f1425.AddVertex(0.14884f, 3.67029f, 0.81538f);
            f1425.AddVertex(0.17224f, 3.73121f, 0.79944f);
            f1425.AddVertex(0.16987f, 3.73015f, 0.80427f);
            f1425.AddVertex(0.14646f, 3.66922f, 0.82021f);
            faces.Add(f1425);

            Face f1426 = new Face(m02___Default);
            f1426.AddVertex(0.17224f, 3.73121f, 0.79944f);
            f1426.AddVertex(0.18429f, 3.80019f, 0.77328f);
            f1426.AddVertex(0.18194f, 3.79914f, 0.77810f);
            f1426.AddVertex(0.16987f, 3.73015f, 0.80427f);
            faces.Add(f1426);

            Face f1427 = new Face(m02___Default);
            f1427.AddVertex(0.18429f, 3.80019f, 0.77328f);
            f1427.AddVertex(0.18213f, 3.87342f, 0.74006f);
            f1427.AddVertex(0.17978f, 3.87238f, 0.74487f);
            f1427.AddVertex(0.18194f, 3.79914f, 0.77810f);
            faces.Add(f1427);

            Face f1428 = new Face(m02___Default);
            f1428.AddVertex(0.18213f, 3.87342f, 0.74006f);
            f1428.AddVertex(0.16219f, 3.94681f, 0.70681f);
            f1428.AddVertex(0.15984f, 3.94576f, 0.71161f);
            f1428.AddVertex(0.17978f, 3.87238f, 0.74487f);
            faces.Add(f1428);

            Face f1429 = new Face(m02___Default);
            f1429.AddVertex(0.16219f, 3.94681f, 0.70681f);
            f1429.AddVertex(0.12005f, 4.01624f, 0.68481f);
            f1429.AddVertex(0.11771f, 4.01520f, 0.68961f);
            f1429.AddVertex(0.15984f, 3.94576f, 0.71161f);
            faces.Add(f1429);

            Face f1430 = new Face(m02___Default);
            f1430.AddVertex(0.12005f, 4.01624f, 0.68481f);
            f1430.AddVertex(-0.22143f, 4.14869f, 0.72769f);
            f1430.AddVertex(-0.22378f, 4.14765f, 0.73249f);
            f1430.AddVertex(0.11771f, 4.01520f, 0.68961f);
            faces.Add(f1430);

            Face f1431 = new Face(m02___Default);
            f1431.AddVertex(-0.22143f, 4.14869f, 0.72769f);
            f1431.AddVertex(-0.30556f, 4.14237f, 0.73534f);
            f1431.AddVertex(-0.30791f, 4.14133f, 0.74014f);
            f1431.AddVertex(-0.22378f, 4.14765f, 0.73249f);
            faces.Add(f1431);

            Face f1432 = new Face(m02___Default);
            f1432.AddVertex(-0.30556f, 4.14237f, 0.73534f);
            f1432.AddVertex(-0.39433f, 4.12707f, 0.74893f);
            f1432.AddVertex(-0.39667f, 4.12603f, 0.75374f);
            f1432.AddVertex(-0.30791f, 4.14133f, 0.74014f);
            faces.Add(f1432);

            Face f1433 = new Face(m02___Default);
            f1433.AddVertex(-0.39667f, 4.12603f, 0.75374f);
            f1433.AddVertex(-0.46703f, 3.93080f, 0.73857f);
            f1433.AddVertex(-0.46983f, 3.92930f, 0.74393f);
            f1433.AddVertex(-0.39902f, 4.12498f, 0.75854f);
            faces.Add(f1433);

            Face f1434 = new Face(m02___Default);
            f1434.AddVertex(-0.46703f, 3.93080f, 0.73857f);
            f1434.AddVertex(-0.39775f, 3.84859f, 0.74295f);
            f1434.AddVertex(-0.40074f, 3.84692f, 0.74854f);
            f1434.AddVertex(-0.46983f, 3.92930f, 0.74393f);
            faces.Add(f1434);

            Face f1435 = new Face(m02___Default);
            f1435.AddVertex(-0.39775f, 3.84859f, 0.74295f);
            f1435.AddVertex(-0.32441f, 3.76516f, 0.75557f);
            f1435.AddVertex(-0.32743f, 3.76345f, 0.76118f);
            f1435.AddVertex(-0.40074f, 3.84692f, 0.74854f);
            faces.Add(f1435);

            Face f1436 = new Face(m02___Default);
            f1436.AddVertex(-0.32441f, 3.76516f, 0.75557f);
            f1436.AddVertex(-0.24683f, 3.69014f, 0.76828f);
            f1436.AddVertex(-0.24973f, 3.68857f, 0.77374f);
            f1436.AddVertex(-0.32743f, 3.76345f, 0.76118f);
            faces.Add(f1436);

            Face f1437 = new Face(m02___Default);
            f1437.AddVertex(-0.24683f, 3.69014f, 0.76828f);
            f1437.AddVertex(-0.16892f, 3.63019f, 0.77917f);
            f1437.AddVertex(-0.17160f, 3.62881f, 0.78438f);
            f1437.AddVertex(-0.24973f, 3.68857f, 0.77374f);
            faces.Add(f1437);

            Face f1438 = new Face(m02___Default);
            f1438.AddVertex(-0.16892f, 3.63019f, 0.77917f);
            f1438.AddVertex(-0.09578f, 3.58877f, 0.78985f);
            f1438.AddVertex(-0.09828f, 3.58757f, 0.79484f);
            f1438.AddVertex(-0.17160f, 3.62881f, 0.78438f);
            faces.Add(f1438);

            Face f1439 = new Face(m02___Default);
            f1439.AddVertex(-0.09578f, 3.58877f, 0.78985f);
            f1439.AddVertex(-0.03069f, 3.56747f, 0.80149f);
            f1439.AddVertex(-0.03308f, 3.56639f, 0.80635f);
            f1439.AddVertex(-0.09828f, 3.58757f, 0.79484f);
            faces.Add(f1439);

            Face f1440 = new Face(m02___Default);
            f1440.AddVertex(-0.03069f, 3.56747f, 0.80149f);
            f1440.AddVertex(0.02557f, 3.56649f, 0.81317f);
            f1440.AddVertex(0.02322f, 3.56544f, 0.81797f);
            f1440.AddVertex(-0.03308f, 3.56639f, 0.80635f);
            faces.Add(f1440);

            Face f1441 = new Face(m02___Default);
            f1441.AddVertex(0.02557f, 3.56649f, 0.81317f);
            f1441.AddVertex(0.07358f, 3.58461f, 0.82230f);
            f1441.AddVertex(0.07123f, 3.58357f, 0.82711f);
            f1441.AddVertex(0.02322f, 3.56544f, 0.81797f);
            faces.Add(f1441);

            Face f1442 = new Face(m02___Default);
            f1442.AddVertex(0.07358f, 3.58461f, 0.82230f);
            f1442.AddVertex(0.11394f, 3.61973f, 0.82563f);
            f1442.AddVertex(0.11158f, 3.61868f, 0.83046f);
            f1442.AddVertex(0.07123f, 3.58357f, 0.82711f);
            faces.Add(f1442);

            Face f1443 = new Face(m02___Default);
            f1443.AddVertex(0.11394f, 3.61973f, 0.82563f);
            f1443.AddVertex(0.14646f, 3.66922f, 0.82021f);
            f1443.AddVertex(0.14409f, 3.66816f, 0.82505f);
            f1443.AddVertex(0.11158f, 3.61868f, 0.83046f);
            faces.Add(f1443);

            Face f1444 = new Face(m02___Default);
            f1444.AddVertex(0.14646f, 3.66922f, 0.82021f);
            f1444.AddVertex(0.16987f, 3.73015f, 0.80427f);
            f1444.AddVertex(0.16749f, 3.72909f, 0.80910f);
            f1444.AddVertex(0.14409f, 3.66816f, 0.82505f);
            faces.Add(f1444);

            Face f1445 = new Face(m02___Default);
            f1445.AddVertex(0.16987f, 3.73015f, 0.80427f);
            f1445.AddVertex(0.18194f, 3.79914f, 0.77810f);
            f1445.AddVertex(0.17958f, 3.79808f, 0.78291f);
            f1445.AddVertex(0.16749f, 3.72909f, 0.80910f);
            faces.Add(f1445);

            Face f1446 = new Face(m02___Default);
            f1446.AddVertex(0.18194f, 3.79914f, 0.77810f);
            f1446.AddVertex(0.17978f, 3.87238f, 0.74487f);
            f1446.AddVertex(0.17743f, 3.87133f, 0.74968f);
            f1446.AddVertex(0.17958f, 3.79808f, 0.78291f);
            faces.Add(f1446);

            Face f1447 = new Face(m02___Default);
            f1447.AddVertex(0.17978f, 3.87238f, 0.74487f);
            f1447.AddVertex(0.15984f, 3.94576f, 0.71161f);
            f1447.AddVertex(0.15749f, 3.94473f, 0.71642f);
            f1447.AddVertex(0.17743f, 3.87133f, 0.74968f);
            faces.Add(f1447);

            Face f1448 = new Face(m02___Default);
            f1448.AddVertex(0.15984f, 3.94576f, 0.71161f);
            f1448.AddVertex(0.11771f, 4.01520f, 0.68961f);
            f1448.AddVertex(0.11536f, 4.01416f, 0.69442f);
            f1448.AddVertex(0.15749f, 3.94473f, 0.71642f);
            faces.Add(f1448);

            Face f1449 = new Face(m02___Default);
            f1449.AddVertex(0.11771f, 4.01520f, 0.68961f);
            f1449.AddVertex(-0.22378f, 4.14765f, 0.73249f);
            f1449.AddVertex(-0.22613f, 4.14660f, 0.73730f);
            f1449.AddVertex(0.11536f, 4.01416f, 0.69442f);
            faces.Add(f1449);

            Face f1450 = new Face(m02___Default);
            f1450.AddVertex(-0.22378f, 4.14765f, 0.73249f);
            f1450.AddVertex(-0.30791f, 4.14133f, 0.74014f);
            f1450.AddVertex(-0.31026f, 4.14028f, 0.74495f);
            f1450.AddVertex(-0.22613f, 4.14660f, 0.73730f);
            faces.Add(f1450);

            Face f1451 = new Face(m02___Default);
            f1451.AddVertex(-0.30791f, 4.14133f, 0.74014f);
            f1451.AddVertex(-0.39667f, 4.12603f, 0.75374f);
            f1451.AddVertex(-0.39902f, 4.12498f, 0.75854f);
            f1451.AddVertex(-0.31026f, 4.14028f, 0.74495f);
            faces.Add(f1451);

            Face f1452 = new Face(m02___Default);
            f1452.AddVertex(-0.39902f, 4.12498f, 0.75854f);
            f1452.AddVertex(-0.46983f, 3.92930f, 0.74393f);
            f1452.AddVertex(-0.47266f, 3.92778f, 0.74932f);
            f1452.AddVertex(-0.40137f, 4.12394f, 0.76335f);
            faces.Add(f1452);

            Face f1453 = new Face(m02___Default);
            f1453.AddVertex(-0.46983f, 3.92930f, 0.74393f);
            f1453.AddVertex(-0.40074f, 3.84692f, 0.74854f);
            f1453.AddVertex(-0.40375f, 3.84522f, 0.75415f);
            f1453.AddVertex(-0.47266f, 3.92778f, 0.74932f);
            faces.Add(f1453);

            Face f1454 = new Face(m02___Default);
            f1454.AddVertex(-0.40074f, 3.84692f, 0.74854f);
            f1454.AddVertex(-0.32743f, 3.76345f, 0.76118f);
            f1454.AddVertex(-0.33047f, 3.76172f, 0.76683f);
            f1454.AddVertex(-0.40375f, 3.84522f, 0.75415f);
            faces.Add(f1454);

            Face f1455 = new Face(m02___Default);
            f1455.AddVertex(-0.32743f, 3.76345f, 0.76118f);
            f1455.AddVertex(-0.24973f, 3.68857f, 0.77374f);
            f1455.AddVertex(-0.25264f, 3.68697f, 0.77922f);
            f1455.AddVertex(-0.33047f, 3.76172f, 0.76683f);
            faces.Add(f1455);

            Face f1456 = new Face(m02___Default);
            f1456.AddVertex(-0.24973f, 3.68857f, 0.77374f);
            f1456.AddVertex(-0.17160f, 3.62881f, 0.78438f);
            f1456.AddVertex(-0.17430f, 3.62743f, 0.78960f);
            f1456.AddVertex(-0.25264f, 3.68697f, 0.77922f);
            faces.Add(f1456);

            Face f1457 = new Face(m02___Default);
            f1457.AddVertex(-0.17160f, 3.62881f, 0.78438f);
            f1457.AddVertex(-0.09828f, 3.58757f, 0.79484f);
            f1457.AddVertex(-0.10079f, 3.58637f, 0.79984f);
            f1457.AddVertex(-0.17430f, 3.62743f, 0.78960f);
            faces.Add(f1457);

            Face f1458 = new Face(m02___Default);
            f1458.AddVertex(-0.09828f, 3.58757f, 0.79484f);
            f1458.AddVertex(-0.03308f, 3.56639f, 0.80635f);
            f1458.AddVertex(-0.03547f, 3.56531f, 0.81121f);
            f1458.AddVertex(-0.10079f, 3.58637f, 0.79984f);
            faces.Add(f1458);

            Face f1459 = new Face(m02___Default);
            f1459.AddVertex(-0.03308f, 3.56639f, 0.80635f);
            f1459.AddVertex(0.02322f, 3.56544f, 0.81797f);
            f1459.AddVertex(0.02087f, 3.56441f, 0.82278f);
            f1459.AddVertex(-0.03547f, 3.56531f, 0.81121f);
            faces.Add(f1459);

            Face f1460 = new Face(m02___Default);
            f1460.AddVertex(0.02322f, 3.56544f, 0.81797f);
            f1460.AddVertex(0.07123f, 3.58357f, 0.82711f);
            f1460.AddVertex(0.06888f, 3.58253f, 0.83191f);
            f1460.AddVertex(0.02087f, 3.56441f, 0.82278f);
            faces.Add(f1460);

            Face f1461 = new Face(m02___Default);
            f1461.AddVertex(0.07123f, 3.58357f, 0.82711f);
            f1461.AddVertex(0.11158f, 3.61868f, 0.83046f);
            f1461.AddVertex(0.10922f, 3.61762f, 0.83528f);
            f1461.AddVertex(0.06888f, 3.58253f, 0.83191f);
            faces.Add(f1461);

            Face f1462 = new Face(m02___Default);
            f1462.AddVertex(0.11158f, 3.61868f, 0.83046f);
            f1462.AddVertex(0.14409f, 3.66816f, 0.82505f);
            f1462.AddVertex(0.14172f, 3.66709f, 0.82988f);
            f1462.AddVertex(0.10922f, 3.61762f, 0.83528f);
            faces.Add(f1462);

            Face f1463 = new Face(m02___Default);
            f1463.AddVertex(0.14409f, 3.66816f, 0.82505f);
            f1463.AddVertex(0.16749f, 3.72909f, 0.80910f);
            f1463.AddVertex(0.16513f, 3.72802f, 0.81394f);
            f1463.AddVertex(0.14172f, 3.66709f, 0.82988f);
            faces.Add(f1463);

            Face f1464 = new Face(m02___Default);
            f1464.AddVertex(0.16749f, 3.72909f, 0.80910f);
            f1464.AddVertex(0.17958f, 3.79808f, 0.78291f);
            f1464.AddVertex(0.17721f, 3.79703f, 0.78773f);
            f1464.AddVertex(0.16513f, 3.72802f, 0.81394f);
            faces.Add(f1464);

            Face f1465 = new Face(m02___Default);
            f1465.AddVertex(0.17958f, 3.79808f, 0.78291f);
            f1465.AddVertex(0.17743f, 3.87133f, 0.74968f);
            f1465.AddVertex(0.17507f, 3.87029f, 0.75449f);
            f1465.AddVertex(0.17721f, 3.79703f, 0.78773f);
            faces.Add(f1465);

            Face f1466 = new Face(m02___Default);
            f1466.AddVertex(0.17743f, 3.87133f, 0.74968f);
            f1466.AddVertex(0.15749f, 3.94473f, 0.71642f);
            f1466.AddVertex(0.15514f, 3.94368f, 0.72122f);
            f1466.AddVertex(0.17507f, 3.87029f, 0.75449f);
            faces.Add(f1466);

            Face f1467 = new Face(m02___Default);
            f1467.AddVertex(0.15749f, 3.94473f, 0.71642f);
            f1467.AddVertex(0.11536f, 4.01416f, 0.69442f);
            f1467.AddVertex(0.11301f, 4.01312f, 0.69922f);
            f1467.AddVertex(0.15514f, 3.94368f, 0.72122f);
            faces.Add(f1467);

            Face f1468 = new Face(m02___Default);
            f1468.AddVertex(0.11536f, 4.01416f, 0.69442f);
            f1468.AddVertex(-0.22613f, 4.14660f, 0.73730f);
            f1468.AddVertex(-0.22848f, 4.14557f, 0.74210f);
            f1468.AddVertex(0.11301f, 4.01312f, 0.69922f);
            faces.Add(f1468);

            Face f1469 = new Face(m02___Default);
            f1469.AddVertex(-0.22613f, 4.14660f, 0.73730f);
            f1469.AddVertex(-0.31026f, 4.14028f, 0.74495f);
            f1469.AddVertex(-0.31261f, 4.13924f, 0.74975f);
            f1469.AddVertex(-0.22848f, 4.14557f, 0.74210f);
            faces.Add(f1469);

            Face f1470 = new Face(m02___Default);
            f1470.AddVertex(-0.31026f, 4.14028f, 0.74495f);
            f1470.AddVertex(-0.39902f, 4.12498f, 0.75854f);
            f1470.AddVertex(-0.40137f, 4.12394f, 0.76335f);
            f1470.AddVertex(-0.31261f, 4.13924f, 0.74975f);
            faces.Add(f1470);

            Face f1471 = new Face(m02___Default);
            f1471.AddVertex(-0.40137f, 4.12394f, 0.76335f);
            f1471.AddVertex(-0.47266f, 3.92778f, 0.74932f);
            f1471.AddVertex(-0.47552f, 3.92624f, 0.75473f);
            f1471.AddVertex(-0.40372f, 4.12290f, 0.76816f);
            faces.Add(f1471);

            Face f1472 = new Face(m02___Default);
            f1472.AddVertex(-0.47266f, 3.92778f, 0.74932f);
            f1472.AddVertex(-0.40375f, 3.84522f, 0.75415f);
            f1472.AddVertex(-0.40680f, 3.84349f, 0.75979f);
            f1472.AddVertex(-0.47552f, 3.92624f, 0.75473f);
            faces.Add(f1472);

            Face f1473 = new Face(m02___Default);
            f1473.AddVertex(-0.40375f, 3.84522f, 0.75415f);
            f1473.AddVertex(-0.33047f, 3.76172f, 0.76683f);
            f1473.AddVertex(-0.33354f, 3.75997f, 0.77250f);
            f1473.AddVertex(-0.40680f, 3.84349f, 0.75979f);
            faces.Add(f1473);

            Face f1474 = new Face(m02___Default);
            f1474.AddVertex(-0.33047f, 3.76172f, 0.76683f);
            f1474.AddVertex(-0.25264f, 3.68697f, 0.77922f);
            f1474.AddVertex(-0.25556f, 3.68536f, 0.78472f);
            f1474.AddVertex(-0.33354f, 3.75997f, 0.77250f);
            faces.Add(f1474);

            Face f1475 = new Face(m02___Default);
            f1475.AddVertex(-0.25264f, 3.68697f, 0.77922f);
            f1475.AddVertex(-0.17430f, 3.62743f, 0.78960f);
            f1475.AddVertex(-0.17701f, 3.62603f, 0.79484f);
            f1475.AddVertex(-0.25556f, 3.68536f, 0.78472f);
            faces.Add(f1475);

            Face f1476 = new Face(m02___Default);
            f1476.AddVertex(-0.17430f, 3.62743f, 0.78960f);
            f1476.AddVertex(-0.10079f, 3.58637f, 0.79984f);
            f1476.AddVertex(-0.10330f, 3.58517f, 0.80485f);
            f1476.AddVertex(-0.17701f, 3.62603f, 0.79484f);
            faces.Add(f1476);

            Face f1477 = new Face(m02___Default);
            f1477.AddVertex(-0.10079f, 3.58637f, 0.79984f);
            f1477.AddVertex(-0.03547f, 3.56531f, 0.81121f);
            f1477.AddVertex(-0.03787f, 3.56422f, 0.81606f);
            f1477.AddVertex(-0.10330f, 3.58517f, 0.80485f);
            faces.Add(f1477);

            Face f1478 = new Face(m02___Default);
            f1478.AddVertex(-0.03547f, 3.56531f, 0.81121f);
            f1478.AddVertex(0.02087f, 3.56441f, 0.82278f);
            f1478.AddVertex(0.01852f, 3.56336f, 0.82758f);
            f1478.AddVertex(-0.03787f, 3.56422f, 0.81606f);
            faces.Add(f1478);

            Face f1479 = new Face(m02___Default);
            f1479.AddVertex(0.02087f, 3.56441f, 0.82278f);
            f1479.AddVertex(0.06888f, 3.58253f, 0.83191f);
            f1479.AddVertex(0.06653f, 3.58149f, 0.83672f);
            f1479.AddVertex(0.01852f, 3.56336f, 0.82758f);
            faces.Add(f1479);

            Face f1480 = new Face(m02___Default);
            f1480.AddVertex(0.06888f, 3.58253f, 0.83191f);
            f1480.AddVertex(0.10922f, 3.61762f, 0.83528f);
            f1480.AddVertex(0.10685f, 3.61656f, 0.84010f);
            f1480.AddVertex(0.06653f, 3.58149f, 0.83672f);
            faces.Add(f1480);

            Face f1481 = new Face(m02___Default);
            f1481.AddVertex(0.10922f, 3.61762f, 0.83528f);
            f1481.AddVertex(0.14172f, 3.66709f, 0.82988f);
            f1481.AddVertex(0.13935f, 3.66602f, 0.83471f);
            f1481.AddVertex(0.10685f, 3.61656f, 0.84010f);
            faces.Add(f1481);

            Face f1482 = new Face(m02___Default);
            f1482.AddVertex(0.14172f, 3.66709f, 0.82988f);
            f1482.AddVertex(0.16513f, 3.72802f, 0.81394f);
            f1482.AddVertex(0.16275f, 3.72696f, 0.81877f);
            f1482.AddVertex(0.13935f, 3.66602f, 0.83471f);
            faces.Add(f1482);

            Face f1483 = new Face(m02___Default);
            f1483.AddVertex(0.16513f, 3.72802f, 0.81394f);
            f1483.AddVertex(0.17721f, 3.79703f, 0.78773f);
            f1483.AddVertex(0.17485f, 3.79598f, 0.79256f);
            f1483.AddVertex(0.16275f, 3.72696f, 0.81877f);
            faces.Add(f1483);

            Face f1484 = new Face(m02___Default);
            f1484.AddVertex(0.17721f, 3.79703f, 0.78773f);
            f1484.AddVertex(0.17507f, 3.87029f, 0.75449f);
            f1484.AddVertex(0.17272f, 3.86924f, 0.75929f);
            f1484.AddVertex(0.17485f, 3.79598f, 0.79256f);
            faces.Add(f1484);

            Face f1485 = new Face(m02___Default);
            f1485.AddVertex(0.17507f, 3.87029f, 0.75449f);
            f1485.AddVertex(0.15514f, 3.94368f, 0.72122f);
            f1485.AddVertex(0.15279f, 3.94264f, 0.72603f);
            f1485.AddVertex(0.17272f, 3.86924f, 0.75929f);
            faces.Add(f1485);

            Face f1486 = new Face(m02___Default);
            f1486.AddVertex(0.15514f, 3.94368f, 0.72122f);
            f1486.AddVertex(0.11301f, 4.01312f, 0.69922f);
            f1486.AddVertex(0.11066f, 4.01208f, 0.70403f);
            f1486.AddVertex(0.15279f, 3.94264f, 0.72603f);
            faces.Add(f1486);

            Face f1487 = new Face(m02___Default);
            f1487.AddVertex(0.11301f, 4.01312f, 0.69922f);
            f1487.AddVertex(-0.22848f, 4.14557f, 0.74210f);
            f1487.AddVertex(-0.23083f, 4.14452f, 0.74691f);
            f1487.AddVertex(0.11066f, 4.01208f, 0.70403f);
            faces.Add(f1487);

            Face f1488 = new Face(m02___Default);
            f1488.AddVertex(-0.22848f, 4.14557f, 0.74210f);
            f1488.AddVertex(-0.31261f, 4.13924f, 0.74975f);
            f1488.AddVertex(-0.31496f, 4.13820f, 0.75456f);
            f1488.AddVertex(-0.23083f, 4.14452f, 0.74691f);
            faces.Add(f1488);

            Face f1489 = new Face(m02___Default);
            f1489.AddVertex(-0.31261f, 4.13924f, 0.74975f);
            f1489.AddVertex(-0.40137f, 4.12394f, 0.76335f);
            f1489.AddVertex(-0.40372f, 4.12290f, 0.76816f);
            f1489.AddVertex(-0.31496f, 4.13820f, 0.75456f);
            faces.Add(f1489);

            Face f1490 = new Face(m02___Default);
            f1490.AddVertex(-0.40372f, 4.12290f, 0.76816f);
            f1490.AddVertex(-0.47552f, 3.92624f, 0.75473f);
            f1490.AddVertex(-0.47840f, 3.92468f, 0.76018f);
            f1490.AddVertex(-0.40607f, 4.12186f, 0.77296f);
            faces.Add(f1490);

            Face f1491 = new Face(m02___Default);
            f1491.AddVertex(-0.47552f, 3.92624f, 0.75473f);
            f1491.AddVertex(-0.40680f, 3.84349f, 0.75979f);
            f1491.AddVertex(-0.40986f, 3.84174f, 0.76545f);
            f1491.AddVertex(-0.47840f, 3.92468f, 0.76018f);
            faces.Add(f1491);

            Face f1492 = new Face(m02___Default);
            f1492.AddVertex(-0.40680f, 3.84349f, 0.75979f);
            f1492.AddVertex(-0.33354f, 3.75997f, 0.77250f);
            f1492.AddVertex(-0.33662f, 3.75820f, 0.77820f);
            f1492.AddVertex(-0.40986f, 3.84174f, 0.76545f);
            faces.Add(f1492);

            Face f1493 = new Face(m02___Default);
            f1493.AddVertex(-0.33354f, 3.75997f, 0.77250f);
            f1493.AddVertex(-0.25556f, 3.68536f, 0.78472f);
            f1493.AddVertex(-0.25850f, 3.68373f, 0.79024f);
            f1493.AddVertex(-0.33662f, 3.75820f, 0.77820f);
            faces.Add(f1493);

            Face f1494 = new Face(m02___Default);
            f1494.AddVertex(-0.25556f, 3.68536f, 0.78472f);
            f1494.AddVertex(-0.17701f, 3.62603f, 0.79484f);
            f1494.AddVertex(-0.17972f, 3.62462f, 0.80009f);
            f1494.AddVertex(-0.25850f, 3.68373f, 0.79024f);
            faces.Add(f1494);

            Face f1495 = new Face(m02___Default);
            f1495.AddVertex(-0.17701f, 3.62603f, 0.79484f);
            f1495.AddVertex(-0.10330f, 3.58517f, 0.80485f);
            f1495.AddVertex(-0.10582f, 3.58396f, 0.80985f);
            f1495.AddVertex(-0.17972f, 3.62462f, 0.80009f);
            faces.Add(f1495);

            Face f1496 = new Face(m02___Default);
            f1496.AddVertex(-0.10330f, 3.58517f, 0.80485f);
            f1496.AddVertex(-0.03787f, 3.56422f, 0.81606f);
            f1496.AddVertex(-0.04027f, 3.56313f, 0.82093f);
            f1496.AddVertex(-0.10582f, 3.58396f, 0.80985f);
            faces.Add(f1496);

            Face f1497 = new Face(m02___Default);
            f1497.AddVertex(-0.03787f, 3.56422f, 0.81606f);
            f1497.AddVertex(0.01852f, 3.56336f, 0.82758f);
            f1497.AddVertex(0.01617f, 3.56232f, 0.83239f);
            f1497.AddVertex(-0.04027f, 3.56313f, 0.82093f);
            faces.Add(f1497);

            Face f1498 = new Face(m02___Default);
            f1498.AddVertex(0.01852f, 3.56336f, 0.82758f);
            f1498.AddVertex(0.06653f, 3.58149f, 0.83672f);
            f1498.AddVertex(0.06418f, 3.58045f, 0.84152f);
            f1498.AddVertex(0.01617f, 3.56232f, 0.83239f);
            faces.Add(f1498);

            Face f1499 = new Face(m02___Default);
            f1499.AddVertex(0.06653f, 3.58149f, 0.83672f);
            f1499.AddVertex(0.10685f, 3.61656f, 0.84010f);
            f1499.AddVertex(0.10449f, 3.61551f, 0.84493f);
            f1499.AddVertex(0.06418f, 3.58045f, 0.84152f);
            faces.Add(f1499);

            Face f1500 = new Face(m02___Default);
            f1500.AddVertex(0.10685f, 3.61656f, 0.84010f);
            f1500.AddVertex(0.13935f, 3.66602f, 0.83471f);
            f1500.AddVertex(0.13697f, 3.66496f, 0.83955f);
            f1500.AddVertex(0.10449f, 3.61551f, 0.84493f);
            faces.Add(f1500);

            Face f1501 = new Face(m02___Default);
            f1501.AddVertex(0.13935f, 3.66602f, 0.83471f);
            f1501.AddVertex(0.16275f, 3.72696f, 0.81877f);
            f1501.AddVertex(0.16038f, 3.72589f, 0.82360f);
            f1501.AddVertex(0.13697f, 3.66496f, 0.83955f);
            faces.Add(f1501);

            Face f1502 = new Face(m02___Default);
            f1502.AddVertex(0.16275f, 3.72696f, 0.81877f);
            f1502.AddVertex(0.17485f, 3.79598f, 0.79256f);
            f1502.AddVertex(0.17249f, 3.79493f, 0.79738f);
            f1502.AddVertex(0.16038f, 3.72589f, 0.82360f);
            faces.Add(f1502);

            Face f1503 = new Face(m02___Default);
            f1503.AddVertex(0.17485f, 3.79598f, 0.79256f);
            f1503.AddVertex(0.17272f, 3.86924f, 0.75929f);
            f1503.AddVertex(0.17037f, 3.86819f, 0.76411f);
            f1503.AddVertex(0.17249f, 3.79493f, 0.79738f);
            faces.Add(f1503);

            Face f1504 = new Face(m02___Default);
            f1504.AddVertex(0.17272f, 3.86924f, 0.75929f);
            f1504.AddVertex(0.15279f, 3.94264f, 0.72603f);
            f1504.AddVertex(0.15044f, 3.94160f, 0.73084f);
            f1504.AddVertex(0.17037f, 3.86819f, 0.76411f);
            faces.Add(f1504);

            Face f1505 = new Face(m02___Default);
            f1505.AddVertex(0.15279f, 3.94264f, 0.72603f);
            f1505.AddVertex(0.11066f, 4.01208f, 0.70403f);
            f1505.AddVertex(0.10831f, 4.01104f, 0.70883f);
            f1505.AddVertex(0.15044f, 3.94160f, 0.73084f);
            faces.Add(f1505);

            Face f1506 = new Face(m02___Default);
            f1506.AddVertex(0.11066f, 4.01208f, 0.70403f);
            f1506.AddVertex(-0.23083f, 4.14452f, 0.74691f);
            f1506.AddVertex(-0.23317f, 4.14348f, 0.75172f);
            f1506.AddVertex(0.10831f, 4.01104f, 0.70883f);
            faces.Add(f1506);

            Face f1507 = new Face(m02___Default);
            f1507.AddVertex(-0.23083f, 4.14452f, 0.74691f);
            f1507.AddVertex(-0.31496f, 4.13820f, 0.75456f);
            f1507.AddVertex(-0.31730f, 4.13716f, 0.75936f);
            f1507.AddVertex(-0.23317f, 4.14348f, 0.75172f);
            faces.Add(f1507);

            Face f1508 = new Face(m02___Default);
            f1508.AddVertex(-0.31496f, 4.13820f, 0.75456f);
            f1508.AddVertex(-0.40372f, 4.12290f, 0.76816f);
            f1508.AddVertex(-0.40607f, 4.12186f, 0.77296f);
            f1508.AddVertex(-0.31730f, 4.13716f, 0.75936f);
            faces.Add(f1508);

            Face f1509 = new Face(m02___Default);
            f1509.AddVertex(-0.30556f, 4.14237f, 0.73534f);
            f1509.AddVertex(-0.22143f, 4.14869f, 0.72769f);
            f1509.AddVertex(0.12005f, 4.01624f, 0.68481f);
            f1509.AddVertex(0.18213f, 3.87342f, 0.74006f);
            faces.Add(f1509);

            Face f1510 = new Face(m02___Default);
            f1510.AddVertex(0.12005f, 4.01624f, 0.68481f);
            f1510.AddVertex(0.16219f, 3.94681f, 0.70681f);
            f1510.AddVertex(0.18213f, 3.87342f, 0.74006f);
            faces.Add(f1510);

            Face f1511 = new Face(m02___Default);
            f1511.AddVertex(-0.39479f, 3.85025f, 0.73741f);
            f1511.AddVertex(-0.30556f, 4.14237f, 0.73534f);
            f1511.AddVertex(0.18213f, 3.87342f, 0.74006f);
            f1511.AddVertex(-0.09328f, 3.58996f, 0.78486f);
            faces.Add(f1511);

            Face f1512 = new Face(m02___Default);
            f1512.AddVertex(0.11631f, 3.62079f, 0.82081f);
            f1512.AddVertex(-0.09328f, 3.58996f, 0.78486f);
            f1512.AddVertex(0.18213f, 3.87342f, 0.74006f);
            f1512.AddVertex(0.17224f, 3.73121f, 0.79944f);
            faces.Add(f1512);

            Face f1513 = new Face(m02___Default);
            f1513.AddVertex(0.18213f, 3.87342f, 0.74006f);
            f1513.AddVertex(0.18429f, 3.80019f, 0.77328f);
            f1513.AddVertex(0.17224f, 3.73121f, 0.79944f);
            faces.Add(f1513);

            Face f1514 = new Face(m02___Default);
            f1514.AddVertex(0.17224f, 3.73121f, 0.79944f);
            f1514.AddVertex(0.14884f, 3.67029f, 0.81538f);
            f1514.AddVertex(0.11631f, 3.62079f, 0.82081f);
            faces.Add(f1514);

            Face f1515 = new Face(m02___Default);
            f1515.AddVertex(0.02791f, 3.56752f, 0.80837f);
            f1515.AddVertex(-0.09328f, 3.58996f, 0.78486f);
            f1515.AddVertex(0.11631f, 3.62079f, 0.82081f);
            f1515.AddVertex(0.07592f, 3.58566f, 0.81750f);
            faces.Add(f1515);

            Face f1516 = new Face(m02___Default);
            f1516.AddVertex(0.02791f, 3.56752f, 0.80837f);
            f1516.AddVertex(-0.02830f, 3.56856f, 0.79663f);
            f1516.AddVertex(-0.09328f, 3.58996f, 0.78486f);
            faces.Add(f1516);

            Face f1517 = new Face(m02___Default);
            f1517.AddVertex(-0.24396f, 3.69171f, 0.76284f);
            f1517.AddVertex(-0.39479f, 3.85025f, 0.73741f);
            f1517.AddVertex(-0.09328f, 3.58996f, 0.78486f);
            f1517.AddVertex(-0.16624f, 3.63156f, 0.77396f);
            faces.Add(f1517);

            Face f1518 = new Face(m02___Default);
            f1518.AddVertex(-0.24396f, 3.69171f, 0.76284f);
            f1518.AddVertex(-0.32141f, 3.76684f, 0.74998f);
            f1518.AddVertex(-0.39479f, 3.85025f, 0.73741f);
            faces.Add(f1518);

            Face f1519 = new Face(m02___Default);
            f1519.AddVertex(-0.30556f, 4.14237f, 0.73534f);
            f1519.AddVertex(-0.39479f, 3.85025f, 0.73741f);
            f1519.AddVertex(-0.46424f, 3.93227f, 0.73324f);
            f1519.AddVertex(-0.39433f, 4.12707f, 0.74893f);
            faces.Add(f1519);

            Face f1520 = new Face(m02___Default);
            f1520.AddVertex(-0.47840f, 3.92468f, 0.76018f);
            f1520.AddVertex(-0.40986f, 3.84174f, 0.76545f);
            f1520.AddVertex(-0.33662f, 3.75820f, 0.77820f);
            f1520.AddVertex(-0.17972f, 3.62462f, 0.80009f);
            faces.Add(f1520);

            Face f1521 = new Face(m02___Default);
            f1521.AddVertex(-0.33662f, 3.75820f, 0.77820f);
            f1521.AddVertex(-0.25850f, 3.68373f, 0.79024f);
            f1521.AddVertex(-0.17972f, 3.62462f, 0.80009f);
            faces.Add(f1521);

            Face f1522 = new Face(m02___Default);
            f1522.AddVertex(-0.23317f, 4.14348f, 0.75172f);
            f1522.AddVertex(-0.47840f, 3.92468f, 0.76018f);
            f1522.AddVertex(-0.17972f, 3.62462f, 0.80009f);
            f1522.AddVertex(0.17249f, 3.79493f, 0.79738f);
            faces.Add(f1522);

            Face f1523 = new Face(m02___Default);
            f1523.AddVertex(0.06418f, 3.58045f, 0.84152f);
            f1523.AddVertex(0.17249f, 3.79493f, 0.79738f);
            f1523.AddVertex(-0.17972f, 3.62462f, 0.80009f);
            f1523.AddVertex(-0.04027f, 3.56313f, 0.82093f);
            faces.Add(f1523);

            Face f1524 = new Face(m02___Default);
            f1524.AddVertex(-0.17972f, 3.62462f, 0.80009f);
            f1524.AddVertex(-0.10582f, 3.58396f, 0.80985f);
            f1524.AddVertex(-0.04027f, 3.56313f, 0.82093f);
            faces.Add(f1524);

            Face f1525 = new Face(m02___Default);
            f1525.AddVertex(-0.04027f, 3.56313f, 0.82093f);
            f1525.AddVertex(0.01617f, 3.56232f, 0.83239f);
            f1525.AddVertex(0.06418f, 3.58045f, 0.84152f);
            faces.Add(f1525);

            Face f1526 = new Face(m02___Default);
            f1526.AddVertex(0.13697f, 3.66496f, 0.83955f);
            f1526.AddVertex(0.17249f, 3.79493f, 0.79738f);
            f1526.AddVertex(0.06418f, 3.58045f, 0.84152f);
            f1526.AddVertex(0.10449f, 3.61551f, 0.84493f);
            faces.Add(f1526);

            Face f1527 = new Face(m02___Default);
            f1527.AddVertex(0.13697f, 3.66496f, 0.83955f);
            f1527.AddVertex(0.16038f, 3.72589f, 0.82360f);
            f1527.AddVertex(0.17249f, 3.79493f, 0.79738f);
            faces.Add(f1527);

            Face f1528 = new Face(m02___Default);
            f1528.AddVertex(0.15044f, 3.94160f, 0.73084f);
            f1528.AddVertex(-0.23317f, 4.14348f, 0.75172f);
            f1528.AddVertex(0.17249f, 3.79493f, 0.79738f);
            f1528.AddVertex(0.17037f, 3.86819f, 0.76411f);
            faces.Add(f1528);

            Face f1529 = new Face(m02___Default);
            f1529.AddVertex(0.15044f, 3.94160f, 0.73084f);
            f1529.AddVertex(0.10831f, 4.01104f, 0.70883f);
            f1529.AddVertex(-0.23317f, 4.14348f, 0.75172f);
            faces.Add(f1529);

            Face f1530 = new Face(m02___Default);
            f1530.AddVertex(-0.47840f, 3.92468f, 0.76018f);
            f1530.AddVertex(-0.23317f, 4.14348f, 0.75172f);
            f1530.AddVertex(-0.31730f, 4.13716f, 0.75936f);
            f1530.AddVertex(-0.40607f, 4.12186f, 0.77296f);
            faces.Add(f1530);

            Face f1531 = new Face(m02___Default);
            f1531.AddVertex(-0.33841f, 4.16375f, 0.70807f);
            f1531.AddVertex(-0.13302f, 4.43913f, 0.72168f);
            f1531.AddVertex(-0.13492f, 4.43901f, 0.72669f);
            f1531.AddVertex(-0.34031f, 4.16363f, 0.71307f);
            faces.Add(f1531);

            Face f1532 = new Face(m02___Default);
            f1532.AddVertex(-0.13302f, 4.43913f, 0.72168f);
            f1532.AddVertex(-0.14785f, 4.55717f, 0.71497f);
            f1532.AddVertex(-0.14975f, 4.55704f, 0.71997f);
            f1532.AddVertex(-0.13492f, 4.43901f, 0.72669f);
            faces.Add(f1532);

            Face f1533 = new Face(m02___Default);
            f1533.AddVertex(-0.14785f, 4.55717f, 0.71497f);
            f1533.AddVertex(-0.17617f, 4.66677f, 0.71763f);
            f1533.AddVertex(-0.17806f, 4.66664f, 0.72263f);
            f1533.AddVertex(-0.14975f, 4.55704f, 0.71997f);
            faces.Add(f1533);

            Face f1534 = new Face(m02___Default);
            f1534.AddVertex(-0.17617f, 4.66677f, 0.71763f);
            f1534.AddVertex(-0.21787f, 4.76413f, 0.73183f);
            f1534.AddVertex(-0.21976f, 4.76400f, 0.73684f);
            f1534.AddVertex(-0.17806f, 4.66664f, 0.72263f);
            faces.Add(f1534);

            Face f1535 = new Face(m02___Default);
            f1535.AddVertex(-0.21787f, 4.76413f, 0.73183f);
            f1535.AddVertex(-0.27166f, 4.84594f, 0.75746f);
            f1535.AddVertex(-0.27356f, 4.84582f, 0.76247f);
            f1535.AddVertex(-0.21976f, 4.76400f, 0.73684f);
            faces.Add(f1535);

            Face f1536 = new Face(m02___Default);
            f1536.AddVertex(-0.27166f, 4.84594f, 0.75746f);
            f1536.AddVertex(-0.33429f, 4.90951f, 0.78987f);
            f1536.AddVertex(-0.33619f, 4.90938f, 0.79488f);
            f1536.AddVertex(-0.27356f, 4.84582f, 0.76247f);
            faces.Add(f1536);

            Face f1537 = new Face(m02___Default);
            f1537.AddVertex(-0.33429f, 4.90951f, 0.78987f);
            f1537.AddVertex(-0.40078f, 4.95286f, 0.82051f);
            f1537.AddVertex(-0.40268f, 4.95273f, 0.82551f);
            f1537.AddVertex(-0.33619f, 4.90938f, 0.79488f);
            faces.Add(f1537);

            Face f1538 = new Face(m02___Default);
            f1538.AddVertex(-0.40078f, 4.95286f, 0.82051f);
            f1538.AddVertex(-0.46578f, 4.97472f, 0.84016f);
            f1538.AddVertex(-0.46769f, 4.97459f, 0.84516f);
            f1538.AddVertex(-0.40268f, 4.95273f, 0.82551f);
            faces.Add(f1538);

            Face f1539 = new Face(m02___Default);
            f1539.AddVertex(-0.46578f, 4.97472f, 0.84016f);
            f1539.AddVertex(-0.52519f, 4.97448f, 0.84321f);
            f1539.AddVertex(-0.52710f, 4.97436f, 0.84821f);
            f1539.AddVertex(-0.46769f, 4.97459f, 0.84516f);
            faces.Add(f1539);

            Face f1540 = new Face(m02___Default);
            f1540.AddVertex(-0.52519f, 4.97448f, 0.84321f);
            f1540.AddVertex(-0.57728f, 4.95213f, 0.83031f);
            f1540.AddVertex(-0.57918f, 4.95201f, 0.83532f);
            f1540.AddVertex(-0.52710f, 4.97436f, 0.84821f);
            faces.Add(f1540);

            Face f1541 = new Face(m02___Default);
            f1541.AddVertex(-0.57728f, 4.95213f, 0.83031f);
            f1541.AddVertex(-0.62255f, 4.90828f, 0.80791f);
            f1541.AddVertex(-0.62445f, 4.90815f, 0.81291f);
            f1541.AddVertex(-0.57918f, 4.95201f, 0.83532f);
            faces.Add(f1541);

            Face f1542 = new Face(m02___Default);
            f1542.AddVertex(-0.62255f, 4.90828f, 0.80791f);
            f1542.AddVertex(-0.66244f, 4.84421f, 0.78461f);
            f1542.AddVertex(-0.66433f, 4.84408f, 0.78961f);
            f1542.AddVertex(-0.62445f, 4.90815f, 0.81291f);
            faces.Add(f1542);

            Face f1543 = new Face(m02___Default);
            f1543.AddVertex(-0.66244f, 4.84421f, 0.78461f);
            f1543.AddVertex(-0.69770f, 4.76197f, 0.76676f);
            f1543.AddVertex(-0.69960f, 4.76184f, 0.77177f);
            f1543.AddVertex(-0.66433f, 4.84408f, 0.78961f);
            faces.Add(f1543);

            Face f1544 = new Face(m02___Default);
            f1544.AddVertex(-0.69770f, 4.76197f, 0.76676f);
            f1544.AddVertex(-0.72752f, 4.66432f, 0.75600f);
            f1544.AddVertex(-0.72942f, 4.66419f, 0.76100f);
            f1544.AddVertex(-0.69960f, 4.76184f, 0.77177f);
            faces.Add(f1544);

            Face f1545 = new Face(m02___Default);
            f1545.AddVertex(-0.72752f, 4.66432f, 0.75600f);
            f1545.AddVertex(-0.75000f, 4.55466f, 0.75034f);
            f1545.AddVertex(-0.75190f, 4.55453f, 0.75535f);
            f1545.AddVertex(-0.72942f, 4.66419f, 0.76100f);
            faces.Add(f1545);

            Face f1546 = new Face(m02___Default);
            f1546.AddVertex(-0.75000f, 4.55466f, 0.75034f);
            f1546.AddVertex(-0.76368f, 4.43676f, 0.74818f);
            f1546.AddVertex(-0.76558f, 4.43664f, 0.75318f);
            f1546.AddVertex(-0.75190f, 4.55453f, 0.75535f);
            faces.Add(f1546);

            Face f1547 = new Face(m02___Default);
            f1547.AddVertex(-0.76368f, 4.43676f, 0.74818f);
            f1547.AddVertex(-0.53193f, 4.16317f, 0.71009f);
            f1547.AddVertex(-0.53383f, 4.16305f, 0.71510f);
            f1547.AddVertex(-0.76558f, 4.43664f, 0.75318f);
            faces.Add(f1547);

            Face f1548 = new Face(m02___Default);
            f1548.AddVertex(-0.53193f, 4.16317f, 0.71009f);
            f1548.AddVertex(-0.42698f, 4.13258f, 0.68853f);
            f1548.AddVertex(-0.42887f, 4.13245f, 0.69354f);
            f1548.AddVertex(-0.53383f, 4.16305f, 0.71510f);
            faces.Add(f1548);

            Face f1549 = new Face(m02___Default);
            f1549.AddVertex(-0.42698f, 4.13258f, 0.68853f);
            f1549.AddVertex(-0.33841f, 4.16375f, 0.70807f);
            f1549.AddVertex(-0.34031f, 4.16363f, 0.71307f);
            f1549.AddVertex(-0.42887f, 4.13245f, 0.69354f);
            faces.Add(f1549);

            Face f1550 = new Face(m02___Default);
            f1550.AddVertex(-0.34031f, 4.16363f, 0.71307f);
            f1550.AddVertex(-0.13492f, 4.43901f, 0.72669f);
            f1550.AddVertex(-0.13682f, 4.43888f, 0.73169f);
            f1550.AddVertex(-0.34221f, 4.16349f, 0.71807f);
            faces.Add(f1550);

            Face f1551 = new Face(m02___Default);
            f1551.AddVertex(-0.13492f, 4.43901f, 0.72669f);
            f1551.AddVertex(-0.14975f, 4.55704f, 0.71997f);
            f1551.AddVertex(-0.15165f, 4.55691f, 0.72497f);
            f1551.AddVertex(-0.13682f, 4.43888f, 0.73169f);
            faces.Add(f1551);

            Face f1552 = new Face(m02___Default);
            f1552.AddVertex(-0.14975f, 4.55704f, 0.71997f);
            f1552.AddVertex(-0.17806f, 4.66664f, 0.72263f);
            f1552.AddVertex(-0.17997f, 4.66651f, 0.72763f);
            f1552.AddVertex(-0.15165f, 4.55691f, 0.72497f);
            faces.Add(f1552);

            Face f1553 = new Face(m02___Default);
            f1553.AddVertex(-0.17806f, 4.66664f, 0.72263f);
            f1553.AddVertex(-0.21976f, 4.76400f, 0.73684f);
            f1553.AddVertex(-0.22166f, 4.76388f, 0.74184f);
            f1553.AddVertex(-0.17997f, 4.66651f, 0.72763f);
            faces.Add(f1553);

            Face f1554 = new Face(m02___Default);
            f1554.AddVertex(-0.21976f, 4.76400f, 0.73684f);
            f1554.AddVertex(-0.27356f, 4.84582f, 0.76247f);
            f1554.AddVertex(-0.27546f, 4.84568f, 0.76747f);
            f1554.AddVertex(-0.22166f, 4.76388f, 0.74184f);
            faces.Add(f1554);

            Face f1555 = new Face(m02___Default);
            f1555.AddVertex(-0.27356f, 4.84582f, 0.76247f);
            f1555.AddVertex(-0.33619f, 4.90938f, 0.79488f);
            f1555.AddVertex(-0.33809f, 4.90925f, 0.79988f);
            f1555.AddVertex(-0.27546f, 4.84568f, 0.76747f);
            faces.Add(f1555);

            Face f1556 = new Face(m02___Default);
            f1556.AddVertex(-0.33619f, 4.90938f, 0.79488f);
            f1556.AddVertex(-0.40268f, 4.95273f, 0.82551f);
            f1556.AddVertex(-0.40459f, 4.95260f, 0.83052f);
            f1556.AddVertex(-0.33809f, 4.90925f, 0.79988f);
            faces.Add(f1556);

            Face f1557 = new Face(m02___Default);
            f1557.AddVertex(-0.40268f, 4.95273f, 0.82551f);
            f1557.AddVertex(-0.46769f, 4.97459f, 0.84516f);
            f1557.AddVertex(-0.46959f, 4.97446f, 0.85017f);
            f1557.AddVertex(-0.40459f, 4.95260f, 0.83052f);
            faces.Add(f1557);

            Face f1558 = new Face(m02___Default);
            f1558.AddVertex(-0.46769f, 4.97459f, 0.84516f);
            f1558.AddVertex(-0.52710f, 4.97436f, 0.84821f);
            f1558.AddVertex(-0.52900f, 4.97422f, 0.85321f);
            f1558.AddVertex(-0.46959f, 4.97446f, 0.85017f);
            faces.Add(f1558);

            Face f1559 = new Face(m02___Default);
            f1559.AddVertex(-0.52710f, 4.97436f, 0.84821f);
            f1559.AddVertex(-0.57918f, 4.95201f, 0.83532f);
            f1559.AddVertex(-0.58108f, 4.95188f, 0.84032f);
            f1559.AddVertex(-0.52900f, 4.97422f, 0.85321f);
            faces.Add(f1559);

            Face f1560 = new Face(m02___Default);
            f1560.AddVertex(-0.57918f, 4.95201f, 0.83532f);
            f1560.AddVertex(-0.62445f, 4.90815f, 0.81291f);
            f1560.AddVertex(-0.62635f, 4.90802f, 0.81792f);
            f1560.AddVertex(-0.58108f, 4.95188f, 0.84032f);
            faces.Add(f1560);

            Face f1561 = new Face(m02___Default);
            f1561.AddVertex(-0.62445f, 4.90815f, 0.81291f);
            f1561.AddVertex(-0.66433f, 4.84408f, 0.78961f);
            f1561.AddVertex(-0.66624f, 4.84395f, 0.79462f);
            f1561.AddVertex(-0.62635f, 4.90802f, 0.81792f);
            faces.Add(f1561);

            Face f1562 = new Face(m02___Default);
            f1562.AddVertex(-0.66433f, 4.84408f, 0.78961f);
            f1562.AddVertex(-0.69960f, 4.76184f, 0.77177f);
            f1562.AddVertex(-0.70150f, 4.76171f, 0.77677f);
            f1562.AddVertex(-0.66624f, 4.84395f, 0.79462f);
            faces.Add(f1562);

            Face f1563 = new Face(m02___Default);
            f1563.AddVertex(-0.69960f, 4.76184f, 0.77177f);
            f1563.AddVertex(-0.72942f, 4.66419f, 0.76100f);
            f1563.AddVertex(-0.73132f, 4.66406f, 0.76601f);
            f1563.AddVertex(-0.70150f, 4.76171f, 0.77677f);
            faces.Add(f1563);

            Face f1564 = new Face(m02___Default);
            f1564.AddVertex(-0.72942f, 4.66419f, 0.76100f);
            f1564.AddVertex(-0.75190f, 4.55453f, 0.75535f);
            f1564.AddVertex(-0.75380f, 4.55440f, 0.76035f);
            f1564.AddVertex(-0.73132f, 4.66406f, 0.76601f);
            faces.Add(f1564);

            Face f1565 = new Face(m02___Default);
            f1565.AddVertex(-0.75190f, 4.55453f, 0.75535f);
            f1565.AddVertex(-0.76558f, 4.43664f, 0.75318f);
            f1565.AddVertex(-0.76748f, 4.43651f, 0.75819f);
            f1565.AddVertex(-0.75380f, 4.55440f, 0.76035f);
            faces.Add(f1565);

            Face f1566 = new Face(m02___Default);
            f1566.AddVertex(-0.76558f, 4.43664f, 0.75318f);
            f1566.AddVertex(-0.53383f, 4.16305f, 0.71510f);
            f1566.AddVertex(-0.53573f, 4.16292f, 0.72010f);
            f1566.AddVertex(-0.76748f, 4.43651f, 0.75819f);
            faces.Add(f1566);

            Face f1567 = new Face(m02___Default);
            f1567.AddVertex(-0.53383f, 4.16305f, 0.71510f);
            f1567.AddVertex(-0.42887f, 4.13245f, 0.69354f);
            f1567.AddVertex(-0.43078f, 4.13232f, 0.69854f);
            f1567.AddVertex(-0.53573f, 4.16292f, 0.72010f);
            faces.Add(f1567);

            Face f1568 = new Face(m02___Default);
            f1568.AddVertex(-0.42887f, 4.13245f, 0.69354f);
            f1568.AddVertex(-0.34031f, 4.16363f, 0.71307f);
            f1568.AddVertex(-0.34221f, 4.16349f, 0.71807f);
            f1568.AddVertex(-0.43078f, 4.13232f, 0.69854f);
            faces.Add(f1568);

            Face f1569 = new Face(m02___Default);
            f1569.AddVertex(-0.34221f, 4.16349f, 0.71807f);
            f1569.AddVertex(-0.13682f, 4.43888f, 0.73169f);
            f1569.AddVertex(-0.13872f, 4.43875f, 0.73669f);
            f1569.AddVertex(-0.34411f, 4.16337f, 0.72308f);
            faces.Add(f1569);

            Face f1570 = new Face(m02___Default);
            f1570.AddVertex(-0.13682f, 4.43888f, 0.73169f);
            f1570.AddVertex(-0.15165f, 4.55691f, 0.72497f);
            f1570.AddVertex(-0.15356f, 4.55679f, 0.72998f);
            f1570.AddVertex(-0.13872f, 4.43875f, 0.73669f);
            faces.Add(f1570);

            Face f1571 = new Face(m02___Default);
            f1571.AddVertex(-0.15165f, 4.55691f, 0.72497f);
            f1571.AddVertex(-0.17997f, 4.66651f, 0.72763f);
            f1571.AddVertex(-0.18187f, 4.66638f, 0.73264f);
            f1571.AddVertex(-0.15356f, 4.55679f, 0.72998f);
            faces.Add(f1571);

            Face f1572 = new Face(m02___Default);
            f1572.AddVertex(-0.17997f, 4.66651f, 0.72763f);
            f1572.AddVertex(-0.22166f, 4.76388f, 0.74184f);
            f1572.AddVertex(-0.22357f, 4.76374f, 0.74684f);
            f1572.AddVertex(-0.18187f, 4.66638f, 0.73264f);
            faces.Add(f1572);

            Face f1573 = new Face(m02___Default);
            f1573.AddVertex(-0.22166f, 4.76388f, 0.74184f);
            f1573.AddVertex(-0.27546f, 4.84568f, 0.76747f);
            f1573.AddVertex(-0.27736f, 4.84556f, 0.77248f);
            f1573.AddVertex(-0.22357f, 4.76374f, 0.74684f);
            faces.Add(f1573);

            Face f1574 = new Face(m02___Default);
            f1574.AddVertex(-0.27546f, 4.84568f, 0.76747f);
            f1574.AddVertex(-0.33809f, 4.90925f, 0.79988f);
            f1574.AddVertex(-0.33999f, 4.90912f, 0.80489f);
            f1574.AddVertex(-0.27736f, 4.84556f, 0.77248f);
            faces.Add(f1574);

            Face f1575 = new Face(m02___Default);
            f1575.AddVertex(-0.33809f, 4.90925f, 0.79988f);
            f1575.AddVertex(-0.40459f, 4.95260f, 0.83052f);
            f1575.AddVertex(-0.40649f, 4.95247f, 0.83552f);
            f1575.AddVertex(-0.33999f, 4.90912f, 0.80489f);
            faces.Add(f1575);

            Face f1576 = new Face(m02___Default);
            f1576.AddVertex(-0.40459f, 4.95260f, 0.83052f);
            f1576.AddVertex(-0.46959f, 4.97446f, 0.85017f);
            f1576.AddVertex(-0.47149f, 4.97433f, 0.85517f);
            f1576.AddVertex(-0.40649f, 4.95247f, 0.83552f);
            faces.Add(f1576);

            Face f1577 = new Face(m02___Default);
            f1577.AddVertex(-0.46959f, 4.97446f, 0.85017f);
            f1577.AddVertex(-0.52900f, 4.97422f, 0.85321f);
            f1577.AddVertex(-0.53090f, 4.97410f, 0.85822f);
            f1577.AddVertex(-0.47149f, 4.97433f, 0.85517f);
            faces.Add(f1577);

            Face f1578 = new Face(m02___Default);
            f1578.AddVertex(-0.52900f, 4.97422f, 0.85321f);
            f1578.AddVertex(-0.58108f, 4.95188f, 0.84032f);
            f1578.AddVertex(-0.58299f, 4.95175f, 0.84532f);
            f1578.AddVertex(-0.53090f, 4.97410f, 0.85822f);
            faces.Add(f1578);

            Face f1579 = new Face(m02___Default);
            f1579.AddVertex(-0.58108f, 4.95188f, 0.84032f);
            f1579.AddVertex(-0.62635f, 4.90802f, 0.81792f);
            f1579.AddVertex(-0.62825f, 4.90789f, 0.82292f);
            f1579.AddVertex(-0.58299f, 4.95175f, 0.84532f);
            faces.Add(f1579);

            Face f1580 = new Face(m02___Default);
            f1580.AddVertex(-0.62635f, 4.90802f, 0.81792f);
            f1580.AddVertex(-0.66624f, 4.84395f, 0.79462f);
            f1580.AddVertex(-0.66814f, 4.84383f, 0.79962f);
            f1580.AddVertex(-0.62825f, 4.90789f, 0.82292f);
            faces.Add(f1580);

            Face f1581 = new Face(m02___Default);
            f1581.AddVertex(-0.66624f, 4.84395f, 0.79462f);
            f1581.AddVertex(-0.70150f, 4.76171f, 0.77677f);
            f1581.AddVertex(-0.70340f, 4.76158f, 0.78177f);
            f1581.AddVertex(-0.66814f, 4.84383f, 0.79962f);
            faces.Add(f1581);

            Face f1582 = new Face(m02___Default);
            f1582.AddVertex(-0.70150f, 4.76171f, 0.77677f);
            f1582.AddVertex(-0.73132f, 4.66406f, 0.76601f);
            f1582.AddVertex(-0.73322f, 4.66393f, 0.77101f);
            f1582.AddVertex(-0.70340f, 4.76158f, 0.78177f);
            faces.Add(f1582);

            Face f1583 = new Face(m02___Default);
            f1583.AddVertex(-0.73132f, 4.66406f, 0.76601f);
            f1583.AddVertex(-0.75380f, 4.55440f, 0.76035f);
            f1583.AddVertex(-0.75570f, 4.55427f, 0.76535f);
            f1583.AddVertex(-0.73322f, 4.66393f, 0.77101f);
            faces.Add(f1583);

            Face f1584 = new Face(m02___Default);
            f1584.AddVertex(-0.75380f, 4.55440f, 0.76035f);
            f1584.AddVertex(-0.76748f, 4.43651f, 0.75819f);
            f1584.AddVertex(-0.76938f, 4.43638f, 0.76319f);
            f1584.AddVertex(-0.75570f, 4.55427f, 0.76535f);
            faces.Add(f1584);

            Face f1585 = new Face(m02___Default);
            f1585.AddVertex(-0.76748f, 4.43651f, 0.75819f);
            f1585.AddVertex(-0.53573f, 4.16292f, 0.72010f);
            f1585.AddVertex(-0.53763f, 4.16279f, 0.72510f);
            f1585.AddVertex(-0.76938f, 4.43638f, 0.76319f);
            faces.Add(f1585);

            Face f1586 = new Face(m02___Default);
            f1586.AddVertex(-0.53573f, 4.16292f, 0.72010f);
            f1586.AddVertex(-0.43078f, 4.13232f, 0.69854f);
            f1586.AddVertex(-0.43268f, 4.13219f, 0.70354f);
            f1586.AddVertex(-0.53763f, 4.16279f, 0.72510f);
            faces.Add(f1586);

            Face f1587 = new Face(m02___Default);
            f1587.AddVertex(-0.43078f, 4.13232f, 0.69854f);
            f1587.AddVertex(-0.34221f, 4.16349f, 0.71807f);
            f1587.AddVertex(-0.34411f, 4.16337f, 0.72308f);
            f1587.AddVertex(-0.43268f, 4.13219f, 0.70354f);
            faces.Add(f1587);

            Face f1588 = new Face(m02___Default);
            f1588.AddVertex(-0.34411f, 4.16337f, 0.72308f);
            f1588.AddVertex(-0.13872f, 4.43875f, 0.73669f);
            f1588.AddVertex(-0.14062f, 4.43862f, 0.74170f);
            f1588.AddVertex(-0.34601f, 4.16323f, 0.72808f);
            faces.Add(f1588);

            Face f1589 = new Face(m02___Default);
            f1589.AddVertex(-0.13872f, 4.43875f, 0.73669f);
            f1589.AddVertex(-0.15356f, 4.55679f, 0.72998f);
            f1589.AddVertex(-0.15545f, 4.55665f, 0.73498f);
            f1589.AddVertex(-0.14062f, 4.43862f, 0.74170f);
            faces.Add(f1589);

            Face f1590 = new Face(m02___Default);
            f1590.AddVertex(-0.15356f, 4.55679f, 0.72998f);
            f1590.AddVertex(-0.18187f, 4.66638f, 0.73264f);
            f1590.AddVertex(-0.18377f, 4.66625f, 0.73764f);
            f1590.AddVertex(-0.15545f, 4.55665f, 0.73498f);
            faces.Add(f1590);

            Face f1591 = new Face(m02___Default);
            f1591.AddVertex(-0.18187f, 4.66638f, 0.73264f);
            f1591.AddVertex(-0.22357f, 4.76374f, 0.74684f);
            f1591.AddVertex(-0.22547f, 4.76362f, 0.75185f);
            f1591.AddVertex(-0.18377f, 4.66625f, 0.73764f);
            faces.Add(f1591);

            Face f1592 = new Face(m02___Default);
            f1592.AddVertex(-0.22357f, 4.76374f, 0.74684f);
            f1592.AddVertex(-0.27736f, 4.84556f, 0.77248f);
            f1592.AddVertex(-0.27926f, 4.84543f, 0.77748f);
            f1592.AddVertex(-0.22547f, 4.76362f, 0.75185f);
            faces.Add(f1592);

            Face f1593 = new Face(m02___Default);
            f1593.AddVertex(-0.27736f, 4.84556f, 0.77248f);
            f1593.AddVertex(-0.33999f, 4.90912f, 0.80489f);
            f1593.AddVertex(-0.34189f, 4.90899f, 0.80989f);
            f1593.AddVertex(-0.27926f, 4.84543f, 0.77748f);
            faces.Add(f1593);

            Face f1594 = new Face(m02___Default);
            f1594.AddVertex(-0.33999f, 4.90912f, 0.80489f);
            f1594.AddVertex(-0.40649f, 4.95247f, 0.83552f);
            f1594.AddVertex(-0.40838f, 4.95234f, 0.84052f);
            f1594.AddVertex(-0.34189f, 4.90899f, 0.80989f);
            faces.Add(f1594);

            Face f1595 = new Face(m02___Default);
            f1595.AddVertex(-0.40649f, 4.95247f, 0.83552f);
            f1595.AddVertex(-0.47149f, 4.97433f, 0.85517f);
            f1595.AddVertex(-0.47339f, 4.97420f, 0.86018f);
            f1595.AddVertex(-0.40838f, 4.95234f, 0.84052f);
            faces.Add(f1595);

            Face f1596 = new Face(m02___Default);
            f1596.AddVertex(-0.47149f, 4.97433f, 0.85517f);
            f1596.AddVertex(-0.53090f, 4.97410f, 0.85822f);
            f1596.AddVertex(-0.53280f, 4.97396f, 0.86322f);
            f1596.AddVertex(-0.47339f, 4.97420f, 0.86018f);
            faces.Add(f1596);

            Face f1597 = new Face(m02___Default);
            f1597.AddVertex(-0.53090f, 4.97410f, 0.85822f);
            f1597.AddVertex(-0.58299f, 4.95175f, 0.84532f);
            f1597.AddVertex(-0.58489f, 4.95162f, 0.85033f);
            f1597.AddVertex(-0.53280f, 4.97396f, 0.86322f);
            faces.Add(f1597);

            Face f1598 = new Face(m02___Default);
            f1598.AddVertex(-0.58299f, 4.95175f, 0.84532f);
            f1598.AddVertex(-0.62825f, 4.90789f, 0.82292f);
            f1598.AddVertex(-0.63015f, 4.90777f, 0.82792f);
            f1598.AddVertex(-0.58489f, 4.95162f, 0.85033f);
            faces.Add(f1598);

            Face f1599 = new Face(m02___Default);
            f1599.AddVertex(-0.62825f, 4.90789f, 0.82292f);
            f1599.AddVertex(-0.66814f, 4.84383f, 0.79962f);
            f1599.AddVertex(-0.67004f, 4.84369f, 0.80462f);
            f1599.AddVertex(-0.63015f, 4.90777f, 0.82792f);
            faces.Add(f1599);

            Face f1600 = new Face(m02___Default);
            f1600.AddVertex(-0.66814f, 4.84383f, 0.79962f);
            f1600.AddVertex(-0.70340f, 4.76158f, 0.78177f);
            f1600.AddVertex(-0.70530f, 4.76145f, 0.78678f);
            f1600.AddVertex(-0.67004f, 4.84369f, 0.80462f);
            faces.Add(f1600);

            Face f1601 = new Face(m02___Default);
            f1601.AddVertex(-0.70340f, 4.76158f, 0.78177f);
            f1601.AddVertex(-0.73322f, 4.66393f, 0.77101f);
            f1601.AddVertex(-0.73512f, 4.66380f, 0.77601f);
            f1601.AddVertex(-0.70530f, 4.76145f, 0.78678f);
            faces.Add(f1601);

            Face f1602 = new Face(m02___Default);
            f1602.AddVertex(-0.73322f, 4.66393f, 0.77101f);
            f1602.AddVertex(-0.75570f, 4.55427f, 0.76535f);
            f1602.AddVertex(-0.75760f, 4.55415f, 0.77036f);
            f1602.AddVertex(-0.73512f, 4.66380f, 0.77601f);
            faces.Add(f1602);

            Face f1603 = new Face(m02___Default);
            f1603.AddVertex(-0.75570f, 4.55427f, 0.76535f);
            f1603.AddVertex(-0.76938f, 4.43638f, 0.76319f);
            f1603.AddVertex(-0.77128f, 4.43625f, 0.76820f);
            f1603.AddVertex(-0.75760f, 4.55415f, 0.77036f);
            faces.Add(f1603);

            Face f1604 = new Face(m02___Default);
            f1604.AddVertex(-0.76938f, 4.43638f, 0.76319f);
            f1604.AddVertex(-0.53763f, 4.16279f, 0.72510f);
            f1604.AddVertex(-0.53953f, 4.16266f, 0.73011f);
            f1604.AddVertex(-0.77128f, 4.43625f, 0.76820f);
            faces.Add(f1604);

            Face f1605 = new Face(m02___Default);
            f1605.AddVertex(-0.53763f, 4.16279f, 0.72510f);
            f1605.AddVertex(-0.43268f, 4.13219f, 0.70354f);
            f1605.AddVertex(-0.43458f, 4.13206f, 0.70854f);
            f1605.AddVertex(-0.53953f, 4.16266f, 0.73011f);
            faces.Add(f1605);

            Face f1606 = new Face(m02___Default);
            f1606.AddVertex(-0.43268f, 4.13219f, 0.70354f);
            f1606.AddVertex(-0.34411f, 4.16337f, 0.72308f);
            f1606.AddVertex(-0.34601f, 4.16323f, 0.72808f);
            f1606.AddVertex(-0.43458f, 4.13206f, 0.70854f);
            faces.Add(f1606);

            Face f1607 = new Face(m02___Default);
            f1607.AddVertex(-0.34601f, 4.16323f, 0.72808f);
            f1607.AddVertex(-0.14062f, 4.43862f, 0.74170f);
            f1607.AddVertex(-0.14253f, 4.43849f, 0.74670f);
            f1607.AddVertex(-0.34791f, 4.16311f, 0.73309f);
            faces.Add(f1607);

            Face f1608 = new Face(m02___Default);
            f1608.AddVertex(-0.14062f, 4.43862f, 0.74170f);
            f1608.AddVertex(-0.15545f, 4.55665f, 0.73498f);
            f1608.AddVertex(-0.15735f, 4.55653f, 0.73999f);
            f1608.AddVertex(-0.14253f, 4.43849f, 0.74670f);
            faces.Add(f1608);

            Face f1609 = new Face(m02___Default);
            f1609.AddVertex(-0.15545f, 4.55665f, 0.73498f);
            f1609.AddVertex(-0.18377f, 4.66625f, 0.73764f);
            f1609.AddVertex(-0.18567f, 4.66613f, 0.74265f);
            f1609.AddVertex(-0.15735f, 4.55653f, 0.73999f);
            faces.Add(f1609);

            Face f1610 = new Face(m02___Default);
            f1610.AddVertex(-0.18377f, 4.66625f, 0.73764f);
            f1610.AddVertex(-0.22547f, 4.76362f, 0.75185f);
            f1610.AddVertex(-0.22736f, 4.76349f, 0.75685f);
            f1610.AddVertex(-0.18567f, 4.66613f, 0.74265f);
            faces.Add(f1610);

            Face f1611 = new Face(m02___Default);
            f1611.AddVertex(-0.22547f, 4.76362f, 0.75185f);
            f1611.AddVertex(-0.27926f, 4.84543f, 0.77748f);
            f1611.AddVertex(-0.28116f, 4.84530f, 0.78248f);
            f1611.AddVertex(-0.22736f, 4.76349f, 0.75685f);
            faces.Add(f1611);

            Face f1612 = new Face(m02___Default);
            f1612.AddVertex(-0.27926f, 4.84543f, 0.77748f);
            f1612.AddVertex(-0.34189f, 4.90899f, 0.80989f);
            f1612.AddVertex(-0.34379f, 4.90887f, 0.81489f);
            f1612.AddVertex(-0.28116f, 4.84530f, 0.78248f);
            faces.Add(f1612);

            Face f1613 = new Face(m02___Default);
            f1613.AddVertex(-0.34189f, 4.90899f, 0.80989f);
            f1613.AddVertex(-0.40838f, 4.95234f, 0.84052f);
            f1613.AddVertex(-0.41029f, 4.95221f, 0.84553f);
            f1613.AddVertex(-0.34379f, 4.90887f, 0.81489f);
            faces.Add(f1613);

            Face f1614 = new Face(m02___Default);
            f1614.AddVertex(-0.40838f, 4.95234f, 0.84052f);
            f1614.AddVertex(-0.47339f, 4.97420f, 0.86018f);
            f1614.AddVertex(-0.47529f, 4.97408f, 0.86518f);
            f1614.AddVertex(-0.41029f, 4.95221f, 0.84553f);
            faces.Add(f1614);

            Face f1615 = new Face(m02___Default);
            f1615.AddVertex(-0.47339f, 4.97420f, 0.86018f);
            f1615.AddVertex(-0.53280f, 4.97396f, 0.86322f);
            f1615.AddVertex(-0.53470f, 4.97384f, 0.86823f);
            f1615.AddVertex(-0.47529f, 4.97408f, 0.86518f);
            faces.Add(f1615);

            Face f1616 = new Face(m02___Default);
            f1616.AddVertex(-0.53280f, 4.97396f, 0.86322f);
            f1616.AddVertex(-0.58489f, 4.95162f, 0.85033f);
            f1616.AddVertex(-0.58678f, 4.95149f, 0.85533f);
            f1616.AddVertex(-0.53470f, 4.97384f, 0.86823f);
            faces.Add(f1616);

            Face f1617 = new Face(m02___Default);
            f1617.AddVertex(-0.58489f, 4.95162f, 0.85033f);
            f1617.AddVertex(-0.63015f, 4.90777f, 0.82792f);
            f1617.AddVertex(-0.63205f, 4.90763f, 0.83293f);
            f1617.AddVertex(-0.58678f, 4.95149f, 0.85533f);
            faces.Add(f1617);

            Face f1618 = new Face(m02___Default);
            f1618.AddVertex(-0.63015f, 4.90777f, 0.82792f);
            f1618.AddVertex(-0.67004f, 4.84369f, 0.80462f);
            f1618.AddVertex(-0.67194f, 4.84357f, 0.80963f);
            f1618.AddVertex(-0.63205f, 4.90763f, 0.83293f);
            faces.Add(f1618);

            Face f1619 = new Face(m02___Default);
            f1619.AddVertex(-0.67004f, 4.84369f, 0.80462f);
            f1619.AddVertex(-0.70530f, 4.76145f, 0.78678f);
            f1619.AddVertex(-0.70720f, 4.76132f, 0.79178f);
            f1619.AddVertex(-0.67194f, 4.84357f, 0.80963f);
            faces.Add(f1619);

            Face f1620 = new Face(m02___Default);
            f1620.AddVertex(-0.70530f, 4.76145f, 0.78678f);
            f1620.AddVertex(-0.73512f, 4.66380f, 0.77601f);
            f1620.AddVertex(-0.73702f, 4.66368f, 0.78102f);
            f1620.AddVertex(-0.70720f, 4.76132f, 0.79178f);
            faces.Add(f1620);

            Face f1621 = new Face(m02___Default);
            f1621.AddVertex(-0.73512f, 4.66380f, 0.77601f);
            f1621.AddVertex(-0.75760f, 4.55415f, 0.77036f);
            f1621.AddVertex(-0.75950f, 4.55401f, 0.77536f);
            f1621.AddVertex(-0.73702f, 4.66368f, 0.78102f);
            faces.Add(f1621);

            Face f1622 = new Face(m02___Default);
            f1622.AddVertex(-0.75760f, 4.55415f, 0.77036f);
            f1622.AddVertex(-0.77128f, 4.43625f, 0.76820f);
            f1622.AddVertex(-0.77318f, 4.43612f, 0.77320f);
            f1622.AddVertex(-0.75950f, 4.55401f, 0.77536f);
            faces.Add(f1622);

            Face f1623 = new Face(m02___Default);
            f1623.AddVertex(-0.77128f, 4.43625f, 0.76820f);
            f1623.AddVertex(-0.53953f, 4.16266f, 0.73011f);
            f1623.AddVertex(-0.54143f, 4.16253f, 0.73511f);
            f1623.AddVertex(-0.77318f, 4.43612f, 0.77320f);
            faces.Add(f1623);

            Face f1624 = new Face(m02___Default);
            f1624.AddVertex(-0.53953f, 4.16266f, 0.73011f);
            f1624.AddVertex(-0.43458f, 4.13206f, 0.70854f);
            f1624.AddVertex(-0.43648f, 4.13194f, 0.71355f);
            f1624.AddVertex(-0.54143f, 4.16253f, 0.73511f);
            faces.Add(f1624);

            Face f1625 = new Face(m02___Default);
            f1625.AddVertex(-0.43458f, 4.13206f, 0.70854f);
            f1625.AddVertex(-0.34601f, 4.16323f, 0.72808f);
            f1625.AddVertex(-0.34791f, 4.16311f, 0.73309f);
            f1625.AddVertex(-0.43648f, 4.13194f, 0.71355f);
            faces.Add(f1625);

            Face f1626 = new Face(m02___Default);
            f1626.AddVertex(-0.53193f, 4.16317f, 0.71009f);
            f1626.AddVertex(-0.76368f, 4.43676f, 0.74818f);
            f1626.AddVertex(-0.75000f, 4.55466f, 0.75034f);
            f1626.AddVertex(-0.33841f, 4.16375f, 0.70807f);
            faces.Add(f1626);

            Face f1627 = new Face(m02___Default);
            f1627.AddVertex(-0.14785f, 4.55717f, 0.71497f);
            f1627.AddVertex(-0.33841f, 4.16375f, 0.70807f);
            f1627.AddVertex(-0.75000f, 4.55466f, 0.75034f);
            f1627.AddVertex(-0.57728f, 4.95213f, 0.83031f);
            faces.Add(f1627);

            Face f1628 = new Face(m02___Default);
            f1628.AddVertex(-0.69770f, 4.76197f, 0.76676f);
            f1628.AddVertex(-0.57728f, 4.95213f, 0.83031f);
            f1628.AddVertex(-0.75000f, 4.55466f, 0.75034f);
            f1628.AddVertex(-0.72752f, 4.66432f, 0.75600f);
            faces.Add(f1628);

            Face f1629 = new Face(m02___Default);
            f1629.AddVertex(-0.57728f, 4.95213f, 0.83031f);
            f1629.AddVertex(-0.69770f, 4.76197f, 0.76676f);
            f1629.AddVertex(-0.66244f, 4.84421f, 0.78461f);
            f1629.AddVertex(-0.62255f, 4.90828f, 0.80791f);
            faces.Add(f1629);

            Face f1630 = new Face(m02___Default);
            f1630.AddVertex(-0.33429f, 4.90951f, 0.78987f);
            f1630.AddVertex(-0.14785f, 4.55717f, 0.71497f);
            f1630.AddVertex(-0.57728f, 4.95213f, 0.83031f);
            f1630.AddVertex(-0.46578f, 4.97472f, 0.84016f);
            faces.Add(f1630);

            Face f1631 = new Face(m02___Default);
            f1631.AddVertex(-0.57728f, 4.95213f, 0.83031f);
            f1631.AddVertex(-0.52519f, 4.97448f, 0.84321f);
            f1631.AddVertex(-0.46578f, 4.97472f, 0.84016f);
            faces.Add(f1631);

            Face f1632 = new Face(m02___Default);
            f1632.AddVertex(-0.46578f, 4.97472f, 0.84016f);
            f1632.AddVertex(-0.40078f, 4.95286f, 0.82051f);
            f1632.AddVertex(-0.33429f, 4.90951f, 0.78987f);
            faces.Add(f1632);

            Face f1633 = new Face(m02___Default);
            f1633.AddVertex(-0.21787f, 4.76413f, 0.73183f);
            f1633.AddVertex(-0.14785f, 4.55717f, 0.71497f);
            f1633.AddVertex(-0.33429f, 4.90951f, 0.78987f);
            f1633.AddVertex(-0.27166f, 4.84594f, 0.75746f);
            faces.Add(f1633);

            Face f1634 = new Face(m02___Default);
            f1634.AddVertex(-0.21787f, 4.76413f, 0.73183f);
            f1634.AddVertex(-0.17617f, 4.66677f, 0.71763f);
            f1634.AddVertex(-0.14785f, 4.55717f, 0.71497f);
            faces.Add(f1634);

            Face f1635 = new Face(m02___Default);
            f1635.AddVertex(-0.14785f, 4.55717f, 0.71497f);
            f1635.AddVertex(-0.13302f, 4.43913f, 0.72168f);
            f1635.AddVertex(-0.33841f, 4.16375f, 0.70807f);
            faces.Add(f1635);

            Face f1636 = new Face(m02___Default);
            f1636.AddVertex(-0.42698f, 4.13258f, 0.68853f);
            f1636.AddVertex(-0.53193f, 4.16317f, 0.71009f);
            f1636.AddVertex(-0.33841f, 4.16375f, 0.70807f);
            faces.Add(f1636);

            Face f1637 = new Face(m02___Default);
            f1637.AddVertex(-0.34791f, 4.16311f, 0.73309f);
            f1637.AddVertex(-0.14253f, 4.43849f, 0.74670f);
            f1637.AddVertex(-0.15735f, 4.55653f, 0.73999f);
            f1637.AddVertex(-0.54143f, 4.16253f, 0.73511f);
            faces.Add(f1637);

            Face f1638 = new Face(m02___Default);
            f1638.AddVertex(-0.34379f, 4.90887f, 0.81489f);
            f1638.AddVertex(-0.54143f, 4.16253f, 0.73511f);
            f1638.AddVertex(-0.15735f, 4.55653f, 0.73999f);
            f1638.AddVertex(-0.22736f, 4.76349f, 0.75685f);
            faces.Add(f1638);

            Face f1639 = new Face(m02___Default);
            f1639.AddVertex(-0.15735f, 4.55653f, 0.73999f);
            f1639.AddVertex(-0.18567f, 4.66613f, 0.74265f);
            f1639.AddVertex(-0.22736f, 4.76349f, 0.75685f);
            faces.Add(f1639);

            Face f1640 = new Face(m02___Default);
            f1640.AddVertex(-0.22736f, 4.76349f, 0.75685f);
            f1640.AddVertex(-0.28116f, 4.84530f, 0.78248f);
            f1640.AddVertex(-0.34379f, 4.90887f, 0.81489f);
            faces.Add(f1640);

            Face f1641 = new Face(m02___Default);
            f1641.AddVertex(-0.70720f, 4.76132f, 0.79178f);
            f1641.AddVertex(-0.54143f, 4.16253f, 0.73511f);
            f1641.AddVertex(-0.34379f, 4.90887f, 0.81489f);
            f1641.AddVertex(-0.58678f, 4.95149f, 0.85533f);
            faces.Add(f1641);

            Face f1642 = new Face(m02___Default);
            f1642.AddVertex(-0.47529f, 4.97408f, 0.86518f);
            f1642.AddVertex(-0.58678f, 4.95149f, 0.85533f);
            f1642.AddVertex(-0.34379f, 4.90887f, 0.81489f);
            f1642.AddVertex(-0.41029f, 4.95221f, 0.84553f);
            faces.Add(f1642);

            Face f1643 = new Face(m02___Default);
            f1643.AddVertex(-0.47529f, 4.97408f, 0.86518f);
            f1643.AddVertex(-0.53470f, 4.97384f, 0.86823f);
            f1643.AddVertex(-0.58678f, 4.95149f, 0.85533f);
            faces.Add(f1643);

            Face f1644 = new Face(m02___Default);
            f1644.AddVertex(-0.67194f, 4.84357f, 0.80963f);
            f1644.AddVertex(-0.70720f, 4.76132f, 0.79178f);
            f1644.AddVertex(-0.58678f, 4.95149f, 0.85533f);
            f1644.AddVertex(-0.63205f, 4.90763f, 0.83293f);
            faces.Add(f1644);

            Face f1645 = new Face(m02___Default);
            f1645.AddVertex(-0.75950f, 4.55401f, 0.77536f);
            f1645.AddVertex(-0.54143f, 4.16253f, 0.73511f);
            f1645.AddVertex(-0.70720f, 4.76132f, 0.79178f);
            f1645.AddVertex(-0.73702f, 4.66368f, 0.78102f);
            faces.Add(f1645);

            Face f1646 = new Face(m02___Default);
            f1646.AddVertex(-0.75950f, 4.55401f, 0.77536f);
            f1646.AddVertex(-0.77318f, 4.43612f, 0.77320f);
            f1646.AddVertex(-0.54143f, 4.16253f, 0.73511f);
            faces.Add(f1646);

            Face f1647 = new Face(m02___Default);
            f1647.AddVertex(-0.34791f, 4.16311f, 0.73309f);
            f1647.AddVertex(-0.54143f, 4.16253f, 0.73511f);
            f1647.AddVertex(-0.43648f, 4.13194f, 0.71355f);
            faces.Add(f1647);

            Face f1648 = new Face(m02___Default);
            f1648.AddVertex(-0.48530f, 4.12227f, 0.75365f);
            f1648.AddVertex(-0.68694f, 3.94365f, 0.78140f);
            f1648.AddVertex(-0.84577f, 3.82316f, 0.81617f);
            f1648.AddVertex(-1.05482f, 3.81112f, 0.83456f);
            faces.Add(f1648);

            Face f1649 = new Face(m02___Default);
            f1649.AddVertex(-0.84577f, 3.82316f, 0.81617f);
            f1649.AddVertex(-0.94731f, 3.80899f, 0.82575f);
            f1649.AddVertex(-1.05482f, 3.81112f, 0.83456f);
            faces.Add(f1649);

            Face f1650 = new Face(m02___Default);
            f1650.AddVertex(-1.40827f, 4.27758f, 0.93946f);
            f1650.AddVertex(-0.48530f, 4.12227f, 0.75365f);
            f1650.AddVertex(-1.05482f, 3.81112f, 0.83456f);
            f1650.AddVertex(-1.31156f, 3.99308f, 0.88118f);
            faces.Add(f1650);

            Face f1651 = new Face(m02___Default);
            f1651.AddVertex(-1.05482f, 3.81112f, 0.83456f);
            f1651.AddVertex(-1.16959f, 3.87054f, 0.84566f);
            f1651.AddVertex(-1.31156f, 3.99308f, 0.88118f);
            faces.Add(f1651);

            Face f1652 = new Face(m02___Default);
            f1652.AddVertex(-1.31156f, 3.99308f, 0.88118f);
            f1652.AddVertex(-1.37625f, 4.13131f, 0.91345f);
            f1652.AddVertex(-1.40827f, 4.27758f, 0.93946f);
            faces.Add(f1652);

            Face f1653 = new Face(m02___Default);
            f1653.AddVertex(-1.13025f, 4.68031f, 0.93913f);
            f1653.AddVertex(-0.48530f, 4.12227f, 0.75365f);
            f1653.AddVertex(-1.40827f, 4.27758f, 0.93946f);
            f1653.AddVertex(-1.23485f, 4.60730f, 0.93803f);
            faces.Add(f1653);

            Face f1654 = new Face(m02___Default);
            f1654.AddVertex(-1.23485f, 4.60730f, 0.93803f);
            f1654.AddVertex(-1.40827f, 4.27758f, 0.93946f);
            f1654.AddVertex(-1.38196f, 4.41377f, 0.94537f);
            f1654.AddVertex(-1.31059f, 4.52662f, 0.94018f);
            faces.Add(f1654);

            Face f1655 = new Face(m02___Default);
            f1655.AddVertex(-0.48530f, 4.12227f, 0.75365f);
            f1655.AddVertex(-1.13025f, 4.68031f, 0.93913f);
            f1655.AddVertex(-0.97562f, 4.72760f, 0.93732f);
            f1655.AddVertex(-0.58667f, 4.30220f, 0.76767f);
            faces.Add(f1655);

            Face f1656 = new Face(m02___Default);
            f1656.AddVertex(-0.59227f, 4.37204f, 0.78015f);
            f1656.AddVertex(-0.58667f, 4.30220f, 0.76767f);
            f1656.AddVertex(-0.97562f, 4.72760f, 0.93732f);
            f1656.AddVertex(-0.86912f, 4.72341f, 0.92545f);
            faces.Add(f1656);

            Face f1657 = new Face(m02___Default);
            f1657.AddVertex(-0.86912f, 4.72341f, 0.92545f);
            f1657.AddVertex(-0.59754f, 4.46918f, 0.80484f);
            f1657.AddVertex(-0.59227f, 4.37204f, 0.78015f);
            faces.Add(f1657);

            Face f1658 = new Face(m02___Default);
            f1658.AddVertex(-0.86912f, 4.72341f, 0.92545f);
            f1658.AddVertex(-0.76602f, 4.69948f, 0.90611f);
            f1658.AddVertex(-0.67979f, 4.65527f, 0.87990f);
            f1658.AddVertex(-0.59754f, 4.46918f, 0.80484f);
            faces.Add(f1658);

            Face f1659 = new Face(m02___Default);
            f1659.AddVertex(-0.58587f, 4.53509f, 0.82588f);
            f1659.AddVertex(-0.59754f, 4.46918f, 0.80484f);
            f1659.AddVertex(-0.67979f, 4.65527f, 0.87990f);
            f1659.AddVertex(-0.60659f, 4.60363f, 0.85354f);
            faces.Add(f1659);

            Face f1660 = new Face(m02___Default);
            f1660.AddVertex(-1.38715f, 4.12529f, 0.94232f);
            f1660.AddVertex(-1.32246f, 3.98707f, 0.91004f);
            f1660.AddVertex(-1.18049f, 3.86453f, 0.87452f);
            f1660.AddVertex(-0.85667f, 3.81714f, 0.84504f);
            faces.Add(f1660);

            Face f1661 = new Face(m02___Default);
            f1661.AddVertex(-0.85667f, 3.81714f, 0.84504f);
            f1661.AddVertex(-1.18049f, 3.86453f, 0.87452f);
            f1661.AddVertex(-1.06572f, 3.80511f, 0.86342f);
            f1661.AddVertex(-0.95821f, 3.80298f, 0.85462f);
            faces.Add(f1661);

            Face f1662 = new Face(m02___Default);
            f1662.AddVertex(-0.98816f, 4.72156f, 0.96633f);
            f1662.AddVertex(-1.38715f, 4.12529f, 0.94232f);
            f1662.AddVertex(-0.85667f, 3.81714f, 0.84504f);
            f1662.AddVertex(-0.49621f, 4.11626f, 0.78251f);
            faces.Add(f1662);

            Face f1663 = new Face(m02___Default);
            f1663.AddVertex(-0.85667f, 3.81714f, 0.84504f);
            f1663.AddVertex(-0.69784f, 3.93764f, 0.81026f);
            f1663.AddVertex(-0.49621f, 4.11626f, 0.78251f);
            faces.Add(f1663);

            Face f1664 = new Face(m02___Default);
            f1664.AddVertex(-0.98816f, 4.72156f, 0.96633f);
            f1664.AddVertex(-0.49621f, 4.11626f, 0.78251f);
            f1664.AddVertex(-0.59757f, 4.29618f, 0.79653f);
            f1664.AddVertex(-0.60317f, 4.36603f, 0.80902f);
            faces.Add(f1664);

            Face f1665 = new Face(m02___Default);
            f1665.AddVertex(-0.77692f, 4.69347f, 0.93498f);
            f1665.AddVertex(-0.98816f, 4.72156f, 0.96633f);
            f1665.AddVertex(-0.60317f, 4.36603f, 0.80902f);
            f1665.AddVertex(-0.60843f, 4.46317f, 0.83370f);
            faces.Add(f1665);

            Face f1666 = new Face(m02___Default);
            f1666.AddVertex(-0.77692f, 4.69347f, 0.93498f);
            f1666.AddVertex(-0.60843f, 4.46317f, 0.83370f);
            f1666.AddVertex(-0.59677f, 4.52908f, 0.85474f);
            f1666.AddVertex(-0.69088f, 4.64940f, 0.90883f);
            faces.Add(f1666);

            Face f1667 = new Face(m02___Default);
            f1667.AddVertex(-0.59677f, 4.52908f, 0.85474f);
            f1667.AddVertex(-0.61750f, 4.59762f, 0.88241f);
            f1667.AddVertex(-0.69088f, 4.64940f, 0.90883f);
            faces.Add(f1667);

            Face f1668 = new Face(m02___Default);
            f1668.AddVertex(-0.77692f, 4.69347f, 0.93498f);
            f1668.AddVertex(-0.88002f, 4.71739f, 0.95432f);
            f1668.AddVertex(-0.98816f, 4.72156f, 0.96633f);
            faces.Add(f1668);

            Face f1669 = new Face(m02___Default);
            f1669.AddVertex(-1.24575f, 4.60129f, 0.96690f);
            f1669.AddVertex(-1.38715f, 4.12529f, 0.94232f);
            f1669.AddVertex(-0.98816f, 4.72156f, 0.96633f);
            f1669.AddVertex(-1.14115f, 4.67430f, 0.96799f);
            faces.Add(f1669);

            Face f1670 = new Face(m02___Default);
            f1670.AddVertex(-1.41918f, 4.27156f, 0.96832f);
            f1670.AddVertex(-1.38715f, 4.12529f, 0.94232f);
            f1670.AddVertex(-1.24575f, 4.60129f, 0.96690f);
            f1670.AddVertex(-1.39286f, 4.40776f, 0.97424f);
            faces.Add(f1670);

            Face f1671 = new Face(m02___Default);
            f1671.AddVertex(-1.24575f, 4.60129f, 0.96690f);
            f1671.AddVertex(-1.32148f, 4.52061f, 0.96904f);
            f1671.AddVertex(-1.39286f, 4.40776f, 0.97424f);
            faces.Add(f1671);

            Face f1672 = new Face(m02___Default);
            f1672.AddVertex(-0.59754f, 4.46918f, 0.80484f);
            f1672.AddVertex(-0.60843f, 4.46317f, 0.83370f);
            f1672.AddVertex(-0.60317f, 4.36603f, 0.80902f);
            f1672.AddVertex(-0.59227f, 4.37204f, 0.78015f);
            faces.Add(f1672);

            Face f1673 = new Face(m02___Default);
            f1673.AddVertex(-0.60659f, 4.60363f, 0.85354f);
            f1673.AddVertex(-0.61750f, 4.59762f, 0.88241f);
            f1673.AddVertex(-0.59677f, 4.52908f, 0.85474f);
            f1673.AddVertex(-0.58587f, 4.53509f, 0.82588f);
            faces.Add(f1673);

            Face f1674 = new Face(m02___Default);
            f1674.AddVertex(-0.76602f, 4.69948f, 0.90611f);
            f1674.AddVertex(-0.77692f, 4.69347f, 0.93498f);
            f1674.AddVertex(-0.69088f, 4.64940f, 0.90883f);
            f1674.AddVertex(-0.68018f, 4.65555f, 0.88004f);
            faces.Add(f1674);

            Face f1675 = new Face(m02___Default);
            f1675.AddVertex(-0.97890f, 4.72723f, 0.93749f);
            f1675.AddVertex(-0.98816f, 4.72156f, 0.96633f);
            f1675.AddVertex(-0.88002f, 4.71739f, 0.95432f);
            f1675.AddVertex(-0.86912f, 4.72341f, 0.92545f);
            faces.Add(f1675);

            Face f1676 = new Face(m02___Default);
            f1676.AddVertex(-1.23485f, 4.60730f, 0.93803f);
            f1676.AddVertex(-1.24575f, 4.60129f, 0.96690f);
            f1676.AddVertex(-1.14115f, 4.67430f, 0.96799f);
            f1676.AddVertex(-1.13025f, 4.68031f, 0.93913f);
            faces.Add(f1676);

            Face f1677 = new Face(m02___Default);
            f1677.AddVertex(-1.38196f, 4.41377f, 0.94537f);
            f1677.AddVertex(-1.39286f, 4.40776f, 0.97424f);
            f1677.AddVertex(-1.32148f, 4.52061f, 0.96904f);
            f1677.AddVertex(-1.31059f, 4.52662f, 0.94018f);
            faces.Add(f1677);

            Face f1678 = new Face(m02___Default);
            f1678.AddVertex(-1.37625f, 4.13131f, 0.91345f);
            f1678.AddVertex(-1.38715f, 4.12529f, 0.94232f);
            f1678.AddVertex(-1.41918f, 4.27156f, 0.96832f);
            f1678.AddVertex(-1.40827f, 4.27758f, 0.93946f);
            faces.Add(f1678);

            Face f1679 = new Face(m02___Default);
            f1679.AddVertex(-1.16959f, 3.87054f, 0.84566f);
            f1679.AddVertex(-1.18049f, 3.86453f, 0.87452f);
            f1679.AddVertex(-1.32246f, 3.98707f, 0.91004f);
            f1679.AddVertex(-1.31156f, 3.99308f, 0.88118f);
            faces.Add(f1679);

            Face f1680 = new Face(m02___Default);
            f1680.AddVertex(-0.94731f, 3.80899f, 0.82575f);
            f1680.AddVertex(-0.95821f, 3.80298f, 0.85462f);
            f1680.AddVertex(-1.06572f, 3.80511f, 0.86342f);
            f1680.AddVertex(-1.05482f, 3.81112f, 0.83456f);
            faces.Add(f1680);

            Face f1681 = new Face(m02___Default);
            f1681.AddVertex(-0.68694f, 3.94365f, 0.78140f);
            f1681.AddVertex(-0.69784f, 3.93764f, 0.81026f);
            f1681.AddVertex(-0.85667f, 3.81714f, 0.84504f);
            f1681.AddVertex(-0.84577f, 3.82316f, 0.81617f);
            faces.Add(f1681);

            Face f1682 = new Face(m02___Default);
            f1682.AddVertex(-0.59227f, 4.37204f, 0.78015f);
            f1682.AddVertex(-0.60317f, 4.36603f, 0.80902f);
            f1682.AddVertex(-0.59757f, 4.29618f, 0.79653f);
            f1682.AddVertex(-0.58667f, 4.30220f, 0.76767f);
            faces.Add(f1682);

            Face f1683 = new Face(m02___Default);
            f1683.AddVertex(-0.58587f, 4.53509f, 0.82588f);
            f1683.AddVertex(-0.59677f, 4.52908f, 0.85474f);
            f1683.AddVertex(-0.60843f, 4.46317f, 0.83370f);
            f1683.AddVertex(-0.59754f, 4.46918f, 0.80484f);
            faces.Add(f1683);

            Face f1684 = new Face(m02___Default);
            f1684.AddVertex(-0.68018f, 4.65555f, 0.88004f);
            f1684.AddVertex(-0.69088f, 4.64940f, 0.90883f);
            f1684.AddVertex(-0.61750f, 4.59762f, 0.88241f);
            f1684.AddVertex(-0.60659f, 4.60363f, 0.85354f);
            faces.Add(f1684);

            Face f1685 = new Face(m02___Default);
            f1685.AddVertex(-0.86912f, 4.72341f, 0.92545f);
            f1685.AddVertex(-0.88002f, 4.71739f, 0.95432f);
            f1685.AddVertex(-0.77692f, 4.69347f, 0.93498f);
            f1685.AddVertex(-0.76602f, 4.69948f, 0.90611f);
            faces.Add(f1685);

            Face f1686 = new Face(m02___Default);
            f1686.AddVertex(-1.13025f, 4.68031f, 0.93913f);
            f1686.AddVertex(-1.14115f, 4.67430f, 0.96799f);
            f1686.AddVertex(-0.98816f, 4.72156f, 0.96633f);
            f1686.AddVertex(-0.97890f, 4.72723f, 0.93749f);
            faces.Add(f1686);

            Face f1687 = new Face(m02___Default);
            f1687.AddVertex(-1.31059f, 4.52662f, 0.94018f);
            f1687.AddVertex(-1.32148f, 4.52061f, 0.96904f);
            f1687.AddVertex(-1.24575f, 4.60129f, 0.96690f);
            f1687.AddVertex(-1.23485f, 4.60730f, 0.93803f);
            faces.Add(f1687);

            Face f1688 = new Face(m02___Default);
            f1688.AddVertex(-1.40827f, 4.27758f, 0.93946f);
            f1688.AddVertex(-1.41918f, 4.27156f, 0.96832f);
            f1688.AddVertex(-1.39286f, 4.40776f, 0.97424f);
            f1688.AddVertex(-1.38196f, 4.41377f, 0.94537f);
            faces.Add(f1688);

            Face f1689 = new Face(m02___Default);
            f1689.AddVertex(-1.31156f, 3.99308f, 0.88118f);
            f1689.AddVertex(-1.32246f, 3.98707f, 0.91004f);
            f1689.AddVertex(-1.38715f, 4.12529f, 0.94232f);
            f1689.AddVertex(-1.37625f, 4.13131f, 0.91345f);
            faces.Add(f1689);

            Face f1690 = new Face(m02___Default);
            f1690.AddVertex(-1.05482f, 3.81112f, 0.83456f);
            f1690.AddVertex(-1.06572f, 3.80511f, 0.86342f);
            f1690.AddVertex(-1.18049f, 3.86453f, 0.87452f);
            f1690.AddVertex(-1.16959f, 3.87054f, 0.84566f);
            faces.Add(f1690);

            Face f1691 = new Face(m02___Default);
            f1691.AddVertex(-0.84577f, 3.82316f, 0.81617f);
            f1691.AddVertex(-0.85667f, 3.81714f, 0.84504f);
            f1691.AddVertex(-0.95821f, 3.80298f, 0.85462f);
            f1691.AddVertex(-0.94731f, 3.80899f, 0.82575f);
            faces.Add(f1691);

            Face f1692 = new Face(m02___Default);
            f1692.AddVertex(-0.69744f, 4.10246f, 0.72909f);
            f1692.AddVertex(-1.01302f, 3.89342f, 0.80024f);
            f1692.AddVertex(-1.01492f, 3.89221f, 0.80502f);
            f1692.AddVertex(-0.69933f, 4.10124f, 0.73387f);
            faces.Add(f1692);

            Face f1693 = new Face(m02___Default);
            f1693.AddVertex(-1.01302f, 3.89342f, 0.80024f);
            f1693.AddVertex(-1.03246f, 3.80654f, 0.80478f);
            f1693.AddVertex(-1.03437f, 3.80533f, 0.80956f);
            f1693.AddVertex(-1.01492f, 3.89221f, 0.80502f);
            faces.Add(f1693);

            Face f1694 = new Face(m02___Default);
            f1694.AddVertex(-1.03246f, 3.80654f, 0.80478f);
            f1694.AddVertex(-1.03905f, 3.72152f, 0.81618f);
            f1694.AddVertex(-1.04095f, 3.72031f, 0.82096f);
            f1694.AddVertex(-1.03437f, 3.80533f, 0.80956f);
            faces.Add(f1694);

            Face f1695 = new Face(m02___Default);
            f1695.AddVertex(-1.03905f, 3.72152f, 0.81618f);
            f1695.AddVertex(-1.03038f, 3.64439f, 0.82808f);
            f1695.AddVertex(-1.03228f, 3.64318f, 0.83286f);
            f1695.AddVertex(-1.04095f, 3.72031f, 0.82096f);
            faces.Add(f1695);

            Face f1696 = new Face(m02___Default);
            f1696.AddVertex(-1.03038f, 3.64439f, 0.82808f);
            f1696.AddVertex(-1.00494f, 3.58075f, 0.83630f);
            f1696.AddVertex(-1.00684f, 3.57953f, 0.84109f);
            f1696.AddVertex(-1.03228f, 3.64318f, 0.83286f);
            faces.Add(f1696);

            Face f1697 = new Face(m02___Default);
            f1697.AddVertex(-1.00494f, 3.58075f, 0.83630f);
            f1697.AddVertex(-0.96245f, 3.53505f, 0.83939f);
            f1697.AddVertex(-0.96435f, 3.53384f, 0.84418f);
            f1697.AddVertex(-1.00684f, 3.57953f, 0.84109f);
            faces.Add(f1697);

            Face f1698 = new Face(m02___Default);
            f1698.AddVertex(-0.96245f, 3.53505f, 0.83939f);
            f1698.AddVertex(-0.90435f, 3.51029f, 0.83834f);
            f1698.AddVertex(-0.90626f, 3.50908f, 0.84313f);
            f1698.AddVertex(-0.96435f, 3.53384f, 0.84418f);
            faces.Add(f1698);

            Face f1699 = new Face(m02___Default);
            f1699.AddVertex(-0.90435f, 3.51029f, 0.83834f);
            f1699.AddVertex(-0.83449f, 3.50793f, 0.83580f);
            f1699.AddVertex(-0.83640f, 3.50672f, 0.84059f);
            f1699.AddVertex(-0.90626f, 3.50908f, 0.84313f);
            faces.Add(f1699);

            Face f1700 = new Face(m02___Default);
            f1700.AddVertex(-0.83449f, 3.50793f, 0.83580f);
            f1700.AddVertex(-0.75904f, 3.52801f, 0.83489f);
            f1700.AddVertex(-0.76094f, 3.52680f, 0.83968f);
            f1700.AddVertex(-0.83640f, 3.50672f, 0.84059f);
            faces.Add(f1700);

            Face f1701 = new Face(m02___Default);
            f1701.AddVertex(-0.75904f, 3.52801f, 0.83489f);
            f1701.AddVertex(-0.68542f, 3.56930f, 0.83763f);
            f1701.AddVertex(-0.68732f, 3.56808f, 0.84242f);
            f1701.AddVertex(-0.76094f, 3.52680f, 0.83968f);
            faces.Add(f1701);

            Face f1702 = new Face(m02___Default);
            f1702.AddVertex(-0.68542f, 3.56930f, 0.83763f);
            f1702.AddVertex(-0.62017f, 3.62907f, 0.84344f);
            f1702.AddVertex(-0.62206f, 3.62783f, 0.84821f);
            f1702.AddVertex(-0.68732f, 3.56808f, 0.84242f);
            faces.Add(f1702);

            Face f1703 = new Face(m02___Default);
            f1703.AddVertex(-0.62017f, 3.62907f, 0.84344f);
            f1703.AddVertex(-0.56635f, 3.70281f, 0.84835f);
            f1703.AddVertex(-0.56817f, 3.70144f, 0.85306f);
            f1703.AddVertex(-0.62206f, 3.62783f, 0.84821f);
            faces.Add(f1703);

            Face f1704 = new Face(m02___Default);
            f1704.AddVertex(-0.56635f, 3.70281f, 0.84835f);
            f1704.AddVertex(-0.52227f, 3.78462f, 0.84607f);
            f1704.AddVertex(-0.52393f, 3.78291f, 0.85059f);
            f1704.AddVertex(-0.56817f, 3.70144f, 0.85306f);
            faces.Add(f1704);

            Face f1705 = new Face(m02___Default);
            f1705.AddVertex(-0.52227f, 3.78462f, 0.84607f);
            f1705.AddVertex(-0.48334f, 3.87009f, 0.83216f);
            f1705.AddVertex(-0.48469f, 3.86777f, 0.83638f);
            f1705.AddVertex(-0.52393f, 3.78291f, 0.85059f);
            faces.Add(f1705);

            Face f1706 = new Face(m02___Default);
            f1706.AddVertex(-0.48334f, 3.87009f, 0.83216f);
            f1706.AddVertex(-0.44585f, 3.95919f, 0.80917f);
            f1706.AddVertex(-0.44683f, 3.95611f, 0.81300f);
            f1706.AddVertex(-0.48469f, 3.86777f, 0.83638f);
            faces.Add(f1706);

            Face f1707 = new Face(m02___Default);
            f1707.AddVertex(-0.44585f, 3.95919f, 0.80917f);
            f1707.AddVertex(-0.35760f, 4.06646f, 0.79464f);
            f1707.AddVertex(-0.35830f, 4.06282f, 0.79818f);
            f1707.AddVertex(-0.44683f, 3.95611f, 0.81300f);
            faces.Add(f1707);

            Face f1708 = new Face(m02___Default);
            f1708.AddVertex(-0.35760f, 4.06646f, 0.79464f);
            f1708.AddVertex(-0.45660f, 4.16908f, 0.72404f);
            f1708.AddVertex(-0.45838f, 4.16761f, 0.72869f);
            f1708.AddVertex(-0.35830f, 4.06282f, 0.79818f);
            faces.Add(f1708);

            Face f1709 = new Face(m02___Default);
            f1709.AddVertex(-0.45660f, 4.16908f, 0.72404f);
            f1709.AddVertex(-0.59802f, 4.12772f, 0.71208f);
            f1709.AddVertex(-0.59990f, 4.12647f, 0.71685f);
            f1709.AddVertex(-0.45838f, 4.16761f, 0.72869f);
            faces.Add(f1709);

            Face f1710 = new Face(m02___Default);
            f1710.AddVertex(-0.59802f, 4.12772f, 0.71208f);
            f1710.AddVertex(-0.69744f, 4.10246f, 0.72909f);
            f1710.AddVertex(-0.69933f, 4.10124f, 0.73387f);
            f1710.AddVertex(-0.59990f, 4.12647f, 0.71685f);
            faces.Add(f1710);

            Face f1711 = new Face(m02___Default);
            f1711.AddVertex(-0.69933f, 4.10124f, 0.73387f);
            f1711.AddVertex(-1.01492f, 3.89221f, 0.80502f);
            f1711.AddVertex(-1.01682f, 3.89100f, 0.80982f);
            f1711.AddVertex(-0.70121f, 4.09999f, 0.73864f);
            faces.Add(f1711);

            Face f1712 = new Face(m02___Default);
            f1712.AddVertex(-1.01492f, 3.89221f, 0.80502f);
            f1712.AddVertex(-1.03437f, 3.80533f, 0.80956f);
            f1712.AddVertex(-1.03626f, 3.80412f, 0.81436f);
            f1712.AddVertex(-1.01682f, 3.89100f, 0.80982f);
            faces.Add(f1712);

            Face f1713 = new Face(m02___Default);
            f1713.AddVertex(-1.03437f, 3.80533f, 0.80956f);
            f1713.AddVertex(-1.04095f, 3.72031f, 0.82096f);
            f1713.AddVertex(-1.04284f, 3.71910f, 0.82575f);
            f1713.AddVertex(-1.03626f, 3.80412f, 0.81436f);
            faces.Add(f1713);

            Face f1714 = new Face(m02___Default);
            f1714.AddVertex(-1.04095f, 3.72031f, 0.82096f);
            f1714.AddVertex(-1.03228f, 3.64318f, 0.83286f);
            f1714.AddVertex(-1.03417f, 3.64196f, 0.83764f);
            f1714.AddVertex(-1.04284f, 3.71910f, 0.82575f);
            faces.Add(f1714);

            Face f1715 = new Face(m02___Default);
            f1715.AddVertex(-1.03228f, 3.64318f, 0.83286f);
            f1715.AddVertex(-1.00684f, 3.57953f, 0.84109f);
            f1715.AddVertex(-1.00874f, 3.57831f, 0.84588f);
            f1715.AddVertex(-1.03417f, 3.64196f, 0.83764f);
            faces.Add(f1715);

            Face f1716 = new Face(m02___Default);
            f1716.AddVertex(-1.00684f, 3.57953f, 0.84109f);
            f1716.AddVertex(-0.96435f, 3.53384f, 0.84418f);
            f1716.AddVertex(-0.96625f, 3.53263f, 0.84897f);
            f1716.AddVertex(-1.00874f, 3.57831f, 0.84588f);
            faces.Add(f1716);

            Face f1717 = new Face(m02___Default);
            f1717.AddVertex(-0.96435f, 3.53384f, 0.84418f);
            f1717.AddVertex(-0.90626f, 3.50908f, 0.84313f);
            f1717.AddVertex(-0.90816f, 3.50787f, 0.84792f);
            f1717.AddVertex(-0.96625f, 3.53263f, 0.84897f);
            faces.Add(f1717);

            Face f1718 = new Face(m02___Default);
            f1718.AddVertex(-0.90626f, 3.50908f, 0.84313f);
            f1718.AddVertex(-0.83640f, 3.50672f, 0.84059f);
            f1718.AddVertex(-0.83830f, 3.50551f, 0.84538f);
            f1718.AddVertex(-0.90816f, 3.50787f, 0.84792f);
            faces.Add(f1718);

            Face f1719 = new Face(m02___Default);
            f1719.AddVertex(-0.83640f, 3.50672f, 0.84059f);
            f1719.AddVertex(-0.76094f, 3.52680f, 0.83968f);
            f1719.AddVertex(-0.76284f, 3.52559f, 0.84447f);
            f1719.AddVertex(-0.83830f, 3.50551f, 0.84538f);
            faces.Add(f1719);

            Face f1720 = new Face(m02___Default);
            f1720.AddVertex(-0.76094f, 3.52680f, 0.83968f);
            f1720.AddVertex(-0.68732f, 3.56808f, 0.84242f);
            f1720.AddVertex(-0.68922f, 3.56688f, 0.84721f);
            f1720.AddVertex(-0.76284f, 3.52559f, 0.84447f);
            faces.Add(f1720);

            Face f1721 = new Face(m02___Default);
            f1721.AddVertex(-0.68732f, 3.56808f, 0.84242f);
            f1721.AddVertex(-0.62206f, 3.62783f, 0.84821f);
            f1721.AddVertex(-0.62394f, 3.62659f, 0.85299f);
            f1721.AddVertex(-0.68922f, 3.56688f, 0.84721f);
            faces.Add(f1721);

            Face f1722 = new Face(m02___Default);
            f1722.AddVertex(-0.62206f, 3.62783f, 0.84821f);
            f1722.AddVertex(-0.56817f, 3.70144f, 0.85306f);
            f1722.AddVertex(-0.56999f, 3.70006f, 0.85776f);
            f1722.AddVertex(-0.62394f, 3.62659f, 0.85299f);
            faces.Add(f1722);

            Face f1723 = new Face(m02___Default);
            f1723.AddVertex(-0.56817f, 3.70144f, 0.85306f);
            f1723.AddVertex(-0.52393f, 3.78291f, 0.85059f);
            f1723.AddVertex(-0.52557f, 3.78118f, 0.85512f);
            f1723.AddVertex(-0.56999f, 3.70006f, 0.85776f);
            faces.Add(f1723);

            Face f1724 = new Face(m02___Default);
            f1724.AddVertex(-0.52393f, 3.78291f, 0.85059f);
            f1724.AddVertex(-0.48469f, 3.86777f, 0.83638f);
            f1724.AddVertex(-0.48602f, 3.86541f, 0.84058f);
            f1724.AddVertex(-0.52557f, 3.78118f, 0.85512f);
            faces.Add(f1724);

            Face f1725 = new Face(m02___Default);
            f1725.AddVertex(-0.48469f, 3.86777f, 0.83638f);
            f1725.AddVertex(-0.44683f, 3.95611f, 0.81300f);
            f1725.AddVertex(-0.44778f, 3.95297f, 0.81680f);
            f1725.AddVertex(-0.48602f, 3.86541f, 0.84058f);
            faces.Add(f1725);

            Face f1726 = new Face(m02___Default);
            f1726.AddVertex(-0.44683f, 3.95611f, 0.81300f);
            f1726.AddVertex(-0.35830f, 4.06282f, 0.79818f);
            f1726.AddVertex(-0.35895f, 4.05907f, 0.80167f);
            f1726.AddVertex(-0.44778f, 3.95297f, 0.81680f);
            faces.Add(f1726);

            Face f1727 = new Face(m02___Default);
            f1727.AddVertex(-0.35830f, 4.06282f, 0.79818f);
            f1727.AddVertex(-0.45838f, 4.16761f, 0.72869f);
            f1727.AddVertex(-0.46010f, 4.16604f, 0.73330f);
            f1727.AddVertex(-0.35895f, 4.05907f, 0.80167f);
            faces.Add(f1727);

            Face f1728 = new Face(m02___Default);
            f1728.AddVertex(-0.45838f, 4.16761f, 0.72869f);
            f1728.AddVertex(-0.59990f, 4.12647f, 0.71685f);
            f1728.AddVertex(-0.60176f, 4.12518f, 0.72160f);
            f1728.AddVertex(-0.46010f, 4.16604f, 0.73330f);
            faces.Add(f1728);

            Face f1729 = new Face(m02___Default);
            f1729.AddVertex(-0.59990f, 4.12647f, 0.71685f);
            f1729.AddVertex(-0.69933f, 4.10124f, 0.73387f);
            f1729.AddVertex(-0.70121f, 4.09999f, 0.73864f);
            f1729.AddVertex(-0.60176f, 4.12518f, 0.72160f);
            faces.Add(f1729);

            Face f1730 = new Face(m02___Default);
            f1730.AddVertex(-0.70121f, 4.09999f, 0.73864f);
            f1730.AddVertex(-1.01682f, 3.89100f, 0.80982f);
            f1730.AddVertex(-1.01872f, 3.88979f, 0.81460f);
            f1730.AddVertex(-0.70308f, 4.09872f, 0.74340f);
            faces.Add(f1730);

            Face f1731 = new Face(m02___Default);
            f1731.AddVertex(-1.01682f, 3.89100f, 0.80982f);
            f1731.AddVertex(-1.03626f, 3.80412f, 0.81436f);
            f1731.AddVertex(-1.03816f, 3.80291f, 0.81914f);
            f1731.AddVertex(-1.01872f, 3.88979f, 0.81460f);
            faces.Add(f1731);

            Face f1732 = new Face(m02___Default);
            f1732.AddVertex(-1.03626f, 3.80412f, 0.81436f);
            f1732.AddVertex(-1.04284f, 3.71910f, 0.82575f);
            f1732.AddVertex(-1.04475f, 3.71788f, 0.83054f);
            f1732.AddVertex(-1.03816f, 3.80291f, 0.81914f);
            faces.Add(f1732);

            Face f1733 = new Face(m02___Default);
            f1733.AddVertex(-1.04284f, 3.71910f, 0.82575f);
            f1733.AddVertex(-1.03417f, 3.64196f, 0.83764f);
            f1733.AddVertex(-1.03607f, 3.64074f, 0.84243f);
            f1733.AddVertex(-1.04475f, 3.71788f, 0.83054f);
            faces.Add(f1733);

            Face f1734 = new Face(m02___Default);
            f1734.AddVertex(-1.03417f, 3.64196f, 0.83764f);
            f1734.AddVertex(-1.00874f, 3.57831f, 0.84588f);
            f1734.AddVertex(-1.01064f, 3.57709f, 0.85066f);
            f1734.AddVertex(-1.03607f, 3.64074f, 0.84243f);
            faces.Add(f1734);

            Face f1735 = new Face(m02___Default);
            f1735.AddVertex(-1.00874f, 3.57831f, 0.84588f);
            f1735.AddVertex(-0.96625f, 3.53263f, 0.84897f);
            f1735.AddVertex(-0.96814f, 3.53141f, 0.85376f);
            f1735.AddVertex(-1.01064f, 3.57709f, 0.85066f);
            faces.Add(f1735);

            Face f1736 = new Face(m02___Default);
            f1736.AddVertex(-0.96625f, 3.53263f, 0.84897f);
            f1736.AddVertex(-0.90816f, 3.50787f, 0.84792f);
            f1736.AddVertex(-0.91005f, 3.50667f, 0.85270f);
            f1736.AddVertex(-0.96814f, 3.53141f, 0.85376f);
            faces.Add(f1736);

            Face f1737 = new Face(m02___Default);
            f1737.AddVertex(-0.90816f, 3.50787f, 0.84792f);
            f1737.AddVertex(-0.83830f, 3.50551f, 0.84538f);
            f1737.AddVertex(-0.84019f, 3.50430f, 0.85017f);
            f1737.AddVertex(-0.91005f, 3.50667f, 0.85270f);
            faces.Add(f1737);

            Face f1738 = new Face(m02___Default);
            f1738.AddVertex(-0.83830f, 3.50551f, 0.84538f);
            f1738.AddVertex(-0.76284f, 3.52559f, 0.84447f);
            f1738.AddVertex(-0.76474f, 3.52438f, 0.84926f);
            f1738.AddVertex(-0.84019f, 3.50430f, 0.85017f);
            faces.Add(f1738);

            Face f1739 = new Face(m02___Default);
            f1739.AddVertex(-0.76284f, 3.52559f, 0.84447f);
            f1739.AddVertex(-0.68922f, 3.56688f, 0.84721f);
            f1739.AddVertex(-0.69112f, 3.56567f, 0.85199f);
            f1739.AddVertex(-0.76474f, 3.52438f, 0.84926f);
            faces.Add(f1739);

            Face f1740 = new Face(m02___Default);
            f1740.AddVertex(-0.68922f, 3.56688f, 0.84721f);
            f1740.AddVertex(-0.62394f, 3.62659f, 0.85299f);
            f1740.AddVertex(-0.62582f, 3.62534f, 0.85776f);
            f1740.AddVertex(-0.69112f, 3.56567f, 0.85199f);
            faces.Add(f1740);

            Face f1741 = new Face(m02___Default);
            f1741.AddVertex(-0.62394f, 3.62659f, 0.85299f);
            f1741.AddVertex(-0.56999f, 3.70006f, 0.85776f);
            f1741.AddVertex(-0.57181f, 3.69868f, 0.86246f);
            f1741.AddVertex(-0.62582f, 3.62534f, 0.85776f);
            faces.Add(f1741);

            Face f1742 = new Face(m02___Default);
            f1742.AddVertex(-0.56999f, 3.70006f, 0.85776f);
            f1742.AddVertex(-0.52557f, 3.78118f, 0.85512f);
            f1742.AddVertex(-0.52722f, 3.77945f, 0.85964f);
            f1742.AddVertex(-0.57181f, 3.69868f, 0.86246f);
            faces.Add(f1742);

            Face f1743 = new Face(m02___Default);
            f1743.AddVertex(-0.52557f, 3.78118f, 0.85512f);
            f1743.AddVertex(-0.48602f, 3.86541f, 0.84058f);
            f1743.AddVertex(-0.48735f, 3.86302f, 0.84476f);
            f1743.AddVertex(-0.52722f, 3.77945f, 0.85964f);
            faces.Add(f1743);

            Face f1744 = new Face(m02___Default);
            f1744.AddVertex(-0.48602f, 3.86541f, 0.84058f);
            f1744.AddVertex(-0.44778f, 3.95297f, 0.81680f);
            f1744.AddVertex(-0.44870f, 3.94977f, 0.82057f);
            f1744.AddVertex(-0.48735f, 3.86302f, 0.84476f);
            faces.Add(f1744);

            Face f1745 = new Face(m02___Default);
            f1745.AddVertex(-0.44778f, 3.95297f, 0.81680f);
            f1745.AddVertex(-0.35895f, 4.05907f, 0.80167f);
            f1745.AddVertex(-0.35955f, 4.05522f, 0.80510f);
            f1745.AddVertex(-0.44870f, 3.94977f, 0.82057f);
            faces.Add(f1745);

            Face f1746 = new Face(m02___Default);
            f1746.AddVertex(-0.35895f, 4.05907f, 0.80167f);
            f1746.AddVertex(-0.46010f, 4.16604f, 0.73330f);
            f1746.AddVertex(-0.46178f, 4.16438f, 0.73785f);
            f1746.AddVertex(-0.35955f, 4.05522f, 0.80510f);
            faces.Add(f1746);

            Face f1747 = new Face(m02___Default);
            f1747.AddVertex(-0.46010f, 4.16604f, 0.73330f);
            f1747.AddVertex(-0.60176f, 4.12518f, 0.72160f);
            f1747.AddVertex(-0.60359f, 4.12382f, 0.72631f);
            f1747.AddVertex(-0.46178f, 4.16438f, 0.73785f);
            faces.Add(f1747);

            Face f1748 = new Face(m02___Default);
            f1748.AddVertex(-0.60176f, 4.12518f, 0.72160f);
            f1748.AddVertex(-0.70121f, 4.09999f, 0.73864f);
            f1748.AddVertex(-0.70308f, 4.09872f, 0.74340f);
            f1748.AddVertex(-0.60359f, 4.12382f, 0.72631f);
            faces.Add(f1748);

            Face f1749 = new Face(m02___Default);
            f1749.AddVertex(-0.70308f, 4.09872f, 0.74340f);
            f1749.AddVertex(-1.01872f, 3.88979f, 0.81460f);
            f1749.AddVertex(-1.02062f, 3.88858f, 0.81939f);
            f1749.AddVertex(-0.70494f, 4.09741f, 0.74814f);
            faces.Add(f1749);

            Face f1750 = new Face(m02___Default);
            f1750.AddVertex(-1.01872f, 3.88979f, 0.81460f);
            f1750.AddVertex(-1.03816f, 3.80291f, 0.81914f);
            f1750.AddVertex(-1.04007f, 3.80170f, 0.82393f);
            f1750.AddVertex(-1.02062f, 3.88858f, 0.81939f);
            faces.Add(f1750);

            Face f1751 = new Face(m02___Default);
            f1751.AddVertex(-1.03816f, 3.80291f, 0.81914f);
            f1751.AddVertex(-1.04475f, 3.71788f, 0.83054f);
            f1751.AddVertex(-1.04664f, 3.71667f, 0.83533f);
            f1751.AddVertex(-1.04007f, 3.80170f, 0.82393f);
            faces.Add(f1751);

            Face f1752 = new Face(m02___Default);
            f1752.AddVertex(-1.04475f, 3.71788f, 0.83054f);
            f1752.AddVertex(-1.03607f, 3.64074f, 0.84243f);
            f1752.AddVertex(-1.03797f, 3.63953f, 0.84721f);
            f1752.AddVertex(-1.04664f, 3.71667f, 0.83533f);
            faces.Add(f1752);

            Face f1753 = new Face(m02___Default);
            f1753.AddVertex(-1.03607f, 3.64074f, 0.84243f);
            f1753.AddVertex(-1.01064f, 3.57709f, 0.85066f);
            f1753.AddVertex(-1.01253f, 3.57588f, 0.85544f);
            f1753.AddVertex(-1.03797f, 3.63953f, 0.84721f);
            faces.Add(f1753);

            Face f1754 = new Face(m02___Default);
            f1754.AddVertex(-1.01064f, 3.57709f, 0.85066f);
            f1754.AddVertex(-0.96814f, 3.53141f, 0.85376f);
            f1754.AddVertex(-0.97004f, 3.53020f, 0.85854f);
            f1754.AddVertex(-1.01253f, 3.57588f, 0.85544f);
            faces.Add(f1754);

            Face f1755 = new Face(m02___Default);
            f1755.AddVertex(-0.96814f, 3.53141f, 0.85376f);
            f1755.AddVertex(-0.91005f, 3.50667f, 0.85270f);
            f1755.AddVertex(-0.91196f, 3.50546f, 0.85749f);
            f1755.AddVertex(-0.97004f, 3.53020f, 0.85854f);
            faces.Add(f1755);

            Face f1756 = new Face(m02___Default);
            f1756.AddVertex(-0.91005f, 3.50667f, 0.85270f);
            f1756.AddVertex(-0.84019f, 3.50430f, 0.85017f);
            f1756.AddVertex(-0.84210f, 3.50309f, 0.85496f);
            f1756.AddVertex(-0.91196f, 3.50546f, 0.85749f);
            faces.Add(f1756);

            Face f1757 = new Face(m02___Default);
            f1757.AddVertex(-0.84019f, 3.50430f, 0.85017f);
            f1757.AddVertex(-0.76474f, 3.52438f, 0.84926f);
            f1757.AddVertex(-0.76664f, 3.52318f, 0.85405f);
            f1757.AddVertex(-0.84210f, 3.50309f, 0.85496f);
            faces.Add(f1757);

            Face f1758 = new Face(m02___Default);
            f1758.AddVertex(-0.76474f, 3.52438f, 0.84926f);
            f1758.AddVertex(-0.69112f, 3.56567f, 0.85199f);
            f1758.AddVertex(-0.69302f, 3.56446f, 0.85678f);
            f1758.AddVertex(-0.76664f, 3.52318f, 0.85405f);
            faces.Add(f1758);

            Face f1759 = new Face(m02___Default);
            f1759.AddVertex(-0.69112f, 3.56567f, 0.85199f);
            f1759.AddVertex(-0.62582f, 3.62534f, 0.85776f);
            f1759.AddVertex(-0.62771f, 3.62410f, 0.86252f);
            f1759.AddVertex(-0.69302f, 3.56446f, 0.85678f);
            faces.Add(f1759);

            Face f1760 = new Face(m02___Default);
            f1760.AddVertex(-0.62582f, 3.62534f, 0.85776f);
            f1760.AddVertex(-0.57181f, 3.69868f, 0.86246f);
            f1760.AddVertex(-0.57362f, 3.69730f, 0.86716f);
            f1760.AddVertex(-0.62771f, 3.62410f, 0.86252f);
            faces.Add(f1760);

            Face f1761 = new Face(m02___Default);
            f1761.AddVertex(-0.57181f, 3.69868f, 0.86246f);
            f1761.AddVertex(-0.52722f, 3.77945f, 0.85964f);
            f1761.AddVertex(-0.52885f, 3.77770f, 0.86415f);
            f1761.AddVertex(-0.57362f, 3.69730f, 0.86716f);
            faces.Add(f1761);

            Face f1762 = new Face(m02___Default);
            f1762.AddVertex(-0.52722f, 3.77945f, 0.85964f);
            f1762.AddVertex(-0.48735f, 3.86302f, 0.84476f);
            f1762.AddVertex(-0.48865f, 3.86060f, 0.84893f);
            f1762.AddVertex(-0.52885f, 3.77770f, 0.86415f);
            faces.Add(f1762);

            Face f1763 = new Face(m02___Default);
            f1763.AddVertex(-0.48735f, 3.86302f, 0.84476f);
            f1763.AddVertex(-0.44870f, 3.94977f, 0.82057f);
            f1763.AddVertex(-0.44960f, 3.94651f, 0.82430f);
            f1763.AddVertex(-0.48865f, 3.86060f, 0.84893f);
            faces.Add(f1763);

            Face f1764 = new Face(m02___Default);
            f1764.AddVertex(-0.44870f, 3.94977f, 0.82057f);
            f1764.AddVertex(-0.35955f, 4.05522f, 0.80510f);
            f1764.AddVertex(-0.36010f, 4.05126f, 0.80848f);
            f1764.AddVertex(-0.44960f, 3.94651f, 0.82430f);
            faces.Add(f1764);

            Face f1765 = new Face(m02___Default);
            f1765.AddVertex(-0.35955f, 4.05522f, 0.80510f);
            f1765.AddVertex(-0.46178f, 4.16438f, 0.73785f);
            f1765.AddVertex(-0.46341f, 4.16262f, 0.74236f);
            f1765.AddVertex(-0.36010f, 4.05126f, 0.80848f);
            faces.Add(f1765);

            Face f1766 = new Face(m02___Default);
            f1766.AddVertex(-0.46178f, 4.16438f, 0.73785f);
            f1766.AddVertex(-0.60359f, 4.12382f, 0.72631f);
            f1766.AddVertex(-0.60540f, 4.12242f, 0.73100f);
            f1766.AddVertex(-0.46341f, 4.16262f, 0.74236f);
            faces.Add(f1766);

            Face f1767 = new Face(m02___Default);
            f1767.AddVertex(-0.60359f, 4.12382f, 0.72631f);
            f1767.AddVertex(-0.70308f, 4.09872f, 0.74340f);
            f1767.AddVertex(-0.70494f, 4.09741f, 0.74814f);
            f1767.AddVertex(-0.60540f, 4.12242f, 0.73100f);
            faces.Add(f1767);

            Face f1768 = new Face(m02___Default);
            f1768.AddVertex(-0.70494f, 4.09741f, 0.74814f);
            f1768.AddVertex(-1.02062f, 3.88858f, 0.81939f);
            f1768.AddVertex(-1.02252f, 3.88737f, 0.82418f);
            f1768.AddVertex(-0.70678f, 4.09608f, 0.75286f);
            faces.Add(f1768);

            Face f1769 = new Face(m02___Default);
            f1769.AddVertex(-1.02062f, 3.88858f, 0.81939f);
            f1769.AddVertex(-1.04007f, 3.80170f, 0.82393f);
            f1769.AddVertex(-1.04196f, 3.80049f, 0.82872f);
            f1769.AddVertex(-1.02252f, 3.88737f, 0.82418f);
            faces.Add(f1769);

            Face f1770 = new Face(m02___Default);
            f1770.AddVertex(-1.04007f, 3.80170f, 0.82393f);
            f1770.AddVertex(-1.04664f, 3.71667f, 0.83533f);
            f1770.AddVertex(-1.04854f, 3.71546f, 0.84011f);
            f1770.AddVertex(-1.04196f, 3.80049f, 0.82872f);
            faces.Add(f1770);

            Face f1771 = new Face(m02___Default);
            f1771.AddVertex(-1.04664f, 3.71667f, 0.83533f);
            f1771.AddVertex(-1.03797f, 3.63953f, 0.84721f);
            f1771.AddVertex(-1.03987f, 3.63831f, 0.85200f);
            f1771.AddVertex(-1.04854f, 3.71546f, 0.84011f);
            faces.Add(f1771);

            Face f1772 = new Face(m02___Default);
            f1772.AddVertex(-1.03797f, 3.63953f, 0.84721f);
            f1772.AddVertex(-1.01253f, 3.57588f, 0.85544f);
            f1772.AddVertex(-1.01443f, 3.57466f, 0.86023f);
            f1772.AddVertex(-1.03987f, 3.63831f, 0.85200f);
            faces.Add(f1772);

            Face f1773 = new Face(m02___Default);
            f1773.AddVertex(-1.01253f, 3.57588f, 0.85544f);
            f1773.AddVertex(-0.97004f, 3.53020f, 0.85854f);
            f1773.AddVertex(-0.97194f, 3.52899f, 0.86333f);
            f1773.AddVertex(-1.01443f, 3.57466f, 0.86023f);
            faces.Add(f1773);

            Face f1774 = new Face(m02___Default);
            f1774.AddVertex(-0.97004f, 3.53020f, 0.85854f);
            f1774.AddVertex(-0.91196f, 3.50546f, 0.85749f);
            f1774.AddVertex(-0.91386f, 3.50425f, 0.86228f);
            f1774.AddVertex(-0.97194f, 3.52899f, 0.86333f);
            faces.Add(f1774);

            Face f1775 = new Face(m02___Default);
            f1775.AddVertex(-0.91196f, 3.50546f, 0.85749f);
            f1775.AddVertex(-0.84210f, 3.50309f, 0.85496f);
            f1775.AddVertex(-0.84400f, 3.50188f, 0.85975f);
            f1775.AddVertex(-0.91386f, 3.50425f, 0.86228f);
            faces.Add(f1775);

            Face f1776 = new Face(m02___Default);
            f1776.AddVertex(-0.84210f, 3.50309f, 0.85496f);
            f1776.AddVertex(-0.76664f, 3.52318f, 0.85405f);
            f1776.AddVertex(-0.76855f, 3.52197f, 0.85884f);
            f1776.AddVertex(-0.84400f, 3.50188f, 0.85975f);
            faces.Add(f1776);

            Face f1777 = new Face(m02___Default);
            f1777.AddVertex(-0.76664f, 3.52318f, 0.85405f);
            f1777.AddVertex(-0.69302f, 3.56446f, 0.85678f);
            f1777.AddVertex(-0.69492f, 3.56324f, 0.86157f);
            f1777.AddVertex(-0.76855f, 3.52197f, 0.85884f);
            faces.Add(f1777);

            Face f1778 = new Face(m02___Default);
            f1778.AddVertex(-0.69302f, 3.56446f, 0.85678f);
            f1778.AddVertex(-0.62771f, 3.62410f, 0.86252f);
            f1778.AddVertex(-0.62959f, 3.62285f, 0.86730f);
            f1778.AddVertex(-0.69492f, 3.56324f, 0.86157f);
            faces.Add(f1778);

            Face f1779 = new Face(m02___Default);
            f1779.AddVertex(-0.62771f, 3.62410f, 0.86252f);
            f1779.AddVertex(-0.57362f, 3.69730f, 0.86716f);
            f1779.AddVertex(-0.57543f, 3.69592f, 0.87186f);
            f1779.AddVertex(-0.62959f, 3.62285f, 0.86730f);
            faces.Add(f1779);

            Face f1780 = new Face(m02___Default);
            f1780.AddVertex(-0.57362f, 3.69730f, 0.86716f);
            f1780.AddVertex(-0.52885f, 3.77770f, 0.86415f);
            f1780.AddVertex(-0.53048f, 3.77594f, 0.86865f);
            f1780.AddVertex(-0.57543f, 3.69592f, 0.87186f);
            faces.Add(f1780);

            Face f1781 = new Face(m02___Default);
            f1781.AddVertex(-0.52885f, 3.77770f, 0.86415f);
            f1781.AddVertex(-0.48865f, 3.86060f, 0.84893f);
            f1781.AddVertex(-0.48994f, 3.85816f, 0.85309f);
            f1781.AddVertex(-0.53048f, 3.77594f, 0.86865f);
            faces.Add(f1781);

            Face f1782 = new Face(m02___Default);
            f1782.AddVertex(-0.48865f, 3.86060f, 0.84893f);
            f1782.AddVertex(-0.44960f, 3.94651f, 0.82430f);
            f1782.AddVertex(-0.45045f, 3.94319f, 0.82801f);
            f1782.AddVertex(-0.48994f, 3.85816f, 0.85309f);
            faces.Add(f1782);

            Face f1783 = new Face(m02___Default);
            f1783.AddVertex(-0.44960f, 3.94651f, 0.82430f);
            f1783.AddVertex(-0.36010f, 4.05126f, 0.80848f);
            f1783.AddVertex(-0.36060f, 4.04720f, 0.81181f);
            f1783.AddVertex(-0.45045f, 3.94319f, 0.82801f);
            faces.Add(f1783);

            Face f1784 = new Face(m02___Default);
            f1784.AddVertex(-0.36010f, 4.05126f, 0.80848f);
            f1784.AddVertex(-0.46341f, 4.16262f, 0.74236f);
            f1784.AddVertex(-0.46499f, 4.16077f, 0.74682f);
            f1784.AddVertex(-0.36060f, 4.04720f, 0.81181f);
            faces.Add(f1784);

            Face f1785 = new Face(m02___Default);
            f1785.AddVertex(-0.46341f, 4.16262f, 0.74236f);
            f1785.AddVertex(-0.60540f, 4.12242f, 0.73100f);
            f1785.AddVertex(-0.60717f, 4.12095f, 0.73565f);
            f1785.AddVertex(-0.46499f, 4.16077f, 0.74682f);
            faces.Add(f1785);

            Face f1786 = new Face(m02___Default);
            f1786.AddVertex(-0.60540f, 4.12242f, 0.73100f);
            f1786.AddVertex(-0.70494f, 4.09741f, 0.74814f);
            f1786.AddVertex(-0.70678f, 4.09608f, 0.75286f);
            f1786.AddVertex(-0.60717f, 4.12095f, 0.73565f);
            faces.Add(f1786);

            Face f1787 = new Face(m02___Default);
            f1787.AddVertex(-0.59802f, 4.12772f, 0.71208f);
            f1787.AddVertex(-0.45660f, 4.16908f, 0.72404f);
            f1787.AddVertex(-0.35760f, 4.06646f, 0.79464f);
            f1787.AddVertex(-0.48334f, 3.87009f, 0.83216f);
            faces.Add(f1787);

            Face f1788 = new Face(m02___Default);
            f1788.AddVertex(-0.35760f, 4.06646f, 0.79464f);
            f1788.AddVertex(-0.44585f, 3.95919f, 0.80917f);
            f1788.AddVertex(-0.48334f, 3.87009f, 0.83216f);
            faces.Add(f1788);

            Face f1789 = new Face(m02___Default);
            f1789.AddVertex(-1.03246f, 3.80654f, 0.80478f);
            f1789.AddVertex(-0.59802f, 4.12772f, 0.71208f);
            f1789.AddVertex(-0.48334f, 3.87009f, 0.83216f);
            f1789.AddVertex(-0.96245f, 3.53505f, 0.83939f);
            faces.Add(f1789);

            Face f1790 = new Face(m02___Default);
            f1790.AddVertex(-0.68542f, 3.56930f, 0.83763f);
            f1790.AddVertex(-0.96245f, 3.53505f, 0.83939f);
            f1790.AddVertex(-0.48334f, 3.87009f, 0.83216f);
            f1790.AddVertex(-0.56635f, 3.70281f, 0.84835f);
            faces.Add(f1790);

            Face f1791 = new Face(m02___Default);
            f1791.AddVertex(-0.48334f, 3.87009f, 0.83216f);
            f1791.AddVertex(-0.52227f, 3.78462f, 0.84607f);
            f1791.AddVertex(-0.56635f, 3.70281f, 0.84835f);
            faces.Add(f1791);

            Face f1792 = new Face(m02___Default);
            f1792.AddVertex(-0.56635f, 3.70281f, 0.84835f);
            f1792.AddVertex(-0.62017f, 3.62907f, 0.84344f);
            f1792.AddVertex(-0.68542f, 3.56930f, 0.83763f);
            faces.Add(f1792);

            Face f1793 = new Face(m02___Default);
            f1793.AddVertex(-0.83449f, 3.50793f, 0.83580f);
            f1793.AddVertex(-0.96245f, 3.53505f, 0.83939f);
            f1793.AddVertex(-0.68542f, 3.56930f, 0.83763f);
            f1793.AddVertex(-0.75904f, 3.52801f, 0.83489f);
            faces.Add(f1793);

            Face f1794 = new Face(m02___Default);
            f1794.AddVertex(-0.83449f, 3.50793f, 0.83580f);
            f1794.AddVertex(-0.90435f, 3.51029f, 0.83834f);
            f1794.AddVertex(-0.96245f, 3.53505f, 0.83939f);
            faces.Add(f1794);

            Face f1795 = new Face(m02___Default);
            f1795.AddVertex(-1.03038f, 3.64439f, 0.82808f);
            f1795.AddVertex(-1.03246f, 3.80654f, 0.80478f);
            f1795.AddVertex(-0.96245f, 3.53505f, 0.83939f);
            f1795.AddVertex(-1.00494f, 3.58075f, 0.83630f);
            faces.Add(f1795);

            Face f1796 = new Face(m02___Default);
            f1796.AddVertex(-1.03038f, 3.64439f, 0.82808f);
            f1796.AddVertex(-1.03905f, 3.72152f, 0.81618f);
            f1796.AddVertex(-1.03246f, 3.80654f, 0.80478f);
            faces.Add(f1796);

            Face f1797 = new Face(m02___Default);
            f1797.AddVertex(-0.59802f, 4.12772f, 0.71208f);
            f1797.AddVertex(-1.03246f, 3.80654f, 0.80478f);
            f1797.AddVertex(-1.01302f, 3.89342f, 0.80024f);
            f1797.AddVertex(-0.69744f, 4.10246f, 0.72909f);
            faces.Add(f1797);

            Face f1798 = new Face(m02___Default);
            f1798.AddVertex(-1.02252f, 3.88737f, 0.82418f);
            f1798.AddVertex(-1.04196f, 3.80049f, 0.82872f);
            f1798.AddVertex(-1.04854f, 3.71546f, 0.84011f);
            f1798.AddVertex(-1.01443f, 3.57466f, 0.86023f);
            faces.Add(f1798);

            Face f1799 = new Face(m02___Default);
            f1799.AddVertex(-1.04854f, 3.71546f, 0.84011f);
            f1799.AddVertex(-1.03987f, 3.63831f, 0.85200f);
            f1799.AddVertex(-1.01443f, 3.57466f, 0.86023f);
            faces.Add(f1799);

            Face f1800 = new Face(m02___Default);
            f1800.AddVertex(-0.46499f, 4.16077f, 0.74682f);
            f1800.AddVertex(-1.02252f, 3.88737f, 0.82418f);
            f1800.AddVertex(-1.01443f, 3.57466f, 0.86023f);
            f1800.AddVertex(-0.53048f, 3.77594f, 0.86865f);
            faces.Add(f1800);

            Face f1801 = new Face(m02___Default);
            f1801.AddVertex(-0.76855f, 3.52197f, 0.85884f);
            f1801.AddVertex(-0.53048f, 3.77594f, 0.86865f);
            f1801.AddVertex(-1.01443f, 3.57466f, 0.86023f);
            f1801.AddVertex(-0.91386f, 3.50425f, 0.86228f);
            faces.Add(f1801);

            Face f1802 = new Face(m02___Default);
            f1802.AddVertex(-1.01443f, 3.57466f, 0.86023f);
            f1802.AddVertex(-0.97194f, 3.52899f, 0.86333f);
            f1802.AddVertex(-0.91386f, 3.50425f, 0.86228f);
            faces.Add(f1802);

            Face f1803 = new Face(m02___Default);
            f1803.AddVertex(-0.91386f, 3.50425f, 0.86228f);
            f1803.AddVertex(-0.84400f, 3.50188f, 0.85975f);
            f1803.AddVertex(-0.76855f, 3.52197f, 0.85884f);
            faces.Add(f1803);

            Face f1804 = new Face(m02___Default);
            f1804.AddVertex(-0.62959f, 3.62285f, 0.86730f);
            f1804.AddVertex(-0.53048f, 3.77594f, 0.86865f);
            f1804.AddVertex(-0.76855f, 3.52197f, 0.85884f);
            f1804.AddVertex(-0.69492f, 3.56324f, 0.86157f);
            faces.Add(f1804);

            Face f1805 = new Face(m02___Default);
            f1805.AddVertex(-0.62959f, 3.62285f, 0.86730f);
            f1805.AddVertex(-0.57543f, 3.69592f, 0.87186f);
            f1805.AddVertex(-0.53048f, 3.77594f, 0.86865f);
            faces.Add(f1805);

            Face f1806 = new Face(m02___Default);
            f1806.AddVertex(-0.45045f, 3.94319f, 0.82801f);
            f1806.AddVertex(-0.46499f, 4.16077f, 0.74682f);
            f1806.AddVertex(-0.53048f, 3.77594f, 0.86865f);
            f1806.AddVertex(-0.48994f, 3.85816f, 0.85309f);
            faces.Add(f1806);

            Face f1807 = new Face(m02___Default);
            f1807.AddVertex(-0.45045f, 3.94319f, 0.82801f);
            f1807.AddVertex(-0.36060f, 4.04720f, 0.81181f);
            f1807.AddVertex(-0.46499f, 4.16077f, 0.74682f);
            faces.Add(f1807);

            Face f1808 = new Face(m02___Default);
            f1808.AddVertex(-1.02252f, 3.88737f, 0.82418f);
            f1808.AddVertex(-0.46499f, 4.16077f, 0.74682f);
            f1808.AddVertex(-0.60717f, 4.12095f, 0.73565f);
            f1808.AddVertex(-0.70678f, 4.09608f, 0.75286f);
            faces.Add(f1808);

            Face f1809 = new Face(m03___Default);
            f1809.AddVertex(-1.03240f, 5.53863f, 0.93686f);
            f1809.AddVertex(-1.10761f, 5.56508f, 0.97428f);
            f1809.AddVertex(-1.17647f, 5.58138f, 0.99740f);
            f1809.AddVertex(-0.99419f, 5.52123f, 0.91605f);
            faces.Add(f1809);

            Face f1810 = new Face(m03___Default);
            f1810.AddVertex(-0.98517f, 5.51064f, 0.89075f);
            f1810.AddVertex(-0.99419f, 5.52123f, 0.91605f);
            f1810.AddVertex(-1.17647f, 5.58138f, 0.99740f);
            f1810.AddVertex(-1.20785f, 5.53593f, 0.83090f);
            faces.Add(f1810);

            Face f1811 = new Face(m03___Default);
            f1811.AddVertex(-1.24079f, 5.57355f, 0.93088f);
            f1811.AddVertex(-1.20785f, 5.53593f, 0.83090f);
            f1811.AddVertex(-1.17647f, 5.58138f, 0.99740f);
            f1811.AddVertex(-1.23275f, 5.58499f, 0.98085f);
            faces.Add(f1811);

            Face f1812 = new Face(m03___Default);
            f1812.AddVertex(-1.24079f, 5.57355f, 0.93088f);
            f1812.AddVertex(-1.23605f, 5.55810f, 0.88276f);
            f1812.AddVertex(-1.20785f, 5.53593f, 0.83090f);
            faces.Add(f1812);

            Face f1813 = new Face(m03___Default);
            f1813.AddVertex(-1.00264f, 5.50847f, 0.86624f);
            f1813.AddVertex(-0.98517f, 5.51064f, 0.89075f);
            f1813.AddVertex(-1.20785f, 5.53593f, 0.83090f);
            f1813.AddVertex(-1.01443f, 5.50252f, 0.84170f);
            faces.Add(f1813);

            Face f1814 = new Face(m03___Default);
            f1814.AddVertex(-1.00496f, 5.47763f, 0.80066f);
            f1814.AddVertex(-1.01443f, 5.50252f, 0.84170f);
            f1814.AddVertex(-1.20785f, 5.53593f, 0.83090f);
            f1814.AddVertex(-1.12571f, 5.51456f, 0.80682f);
            faces.Add(f1814);

            Face f1815 = new Face(m03___Default);
            f1815.AddVertex(-1.00496f, 5.47763f, 0.80066f);
            f1815.AddVertex(-1.12571f, 5.51456f, 0.80682f);
            f1815.AddVertex(-1.05823f, 5.48285f, 0.77925f);
            f1815.AddVertex(-0.95677f, 5.41739f, 0.76299f);
            faces.Add(f1815);

            Face f1816 = new Face(m03___Default);
            f1816.AddVertex(-0.83984f, 5.35465f, 0.84755f);
            f1816.AddVertex(-0.80748f, 5.36897f, 0.88989f);
            f1816.AddVertex(-0.81734f, 5.41149f, 0.90825f);
            f1816.AddVertex(-0.96562f, 5.51801f, 0.94929f);
            faces.Add(f1816);

            Face f1817 = new Face(m03___Default);
            f1817.AddVertex(-0.81734f, 5.41149f, 0.90825f);
            f1817.AddVertex(-0.88918f, 5.47762f, 0.92968f);
            f1817.AddVertex(-0.96562f, 5.51801f, 0.94929f);
            faces.Add(f1817);

            Face f1818 = new Face(m03___Default);
            f1818.AddVertex(-0.88701f, 5.42932f, 0.83308f);
            f1818.AddVertex(-0.83984f, 5.35465f, 0.84755f);
            f1818.AddVertex(-0.96562f, 5.51801f, 0.94929f);
            f1818.AddVertex(-0.92882f, 5.47639f, 0.86560f);
            faces.Add(f1818);

            Face f1819 = new Face(m03___Default);
            f1819.AddVertex(-0.96562f, 5.51801f, 0.94929f);
            f1819.AddVertex(-0.95587f, 5.50703f, 0.91827f);
            f1819.AddVertex(-0.92882f, 5.47639f, 0.86560f);
            faces.Add(f1819);

            Face f1820 = new Face(m03___Default);
            f1820.AddVertex(-0.91481f, 5.22580f, 0.92309f);
            f1820.AddVertex(-1.02883f, 5.19850f, 0.95362f);
            f1820.AddVertex(-1.08863f, 5.18821f, 0.96838f);
            f1820.AddVertex(-0.88686f, 5.28771f, 0.81118f);
            faces.Add(f1820);

            Face f1821 = new Face(m03___Default);
            f1821.AddVertex(-0.88636f, 5.23948f, 0.90495f);
            f1821.AddVertex(-0.91481f, 5.22580f, 0.92309f);
            f1821.AddVertex(-0.88686f, 5.28771f, 0.81118f);
            f1821.AddVertex(-0.87624f, 5.26412f, 0.85807f);
            faces.Add(f1821);

            Face f1822 = new Face(m03___Default);
            f1822.AddVertex(-0.97035f, 5.20453f, 0.96202f);
            f1822.AddVertex(-1.02883f, 5.19850f, 0.95362f);
            f1822.AddVertex(-0.91481f, 5.22580f, 0.92309f);
            faces.Add(f1822);

            Face f1823 = new Face(m03___Default);
            f1823.AddVertex(-1.16116f, 5.20283f, 0.94559f);
            f1823.AddVertex(-1.17023f, 5.18975f, 1.01322f);
            f1823.AddVertex(-1.10792f, 5.20083f, 0.98653f);
            faces.Add(f1823);

            Face f1824 = new Face(m03___Default);
            f1824.AddVertex(-1.14187f, 5.19021f, 0.92743f);
            f1824.AddVertex(-0.91300f, 5.30951f, 0.76712f);
            f1824.AddVertex(-0.88686f, 5.28771f, 0.81118f);
            f1824.AddVertex(-1.08863f, 5.18821f, 0.96838f);
            faces.Add(f1824);

            Face f1825 = new Face(m03___Default);
            f1825.AddVertex(-1.15094f, 5.17713f, 0.99507f);
            f1825.AddVertex(-1.14187f, 5.19021f, 0.92743f);
            f1825.AddVertex(-1.08863f, 5.18821f, 0.96838f);
            faces.Add(f1825);

            Face f1826 = new Face(m03___Default);
            f1826.AddVertex(-1.15210f, 5.24840f, 0.72262f);
            f1826.AddVertex(-1.11920f, 5.26460f, 0.70999f);
            f1826.AddVertex(-1.07560f, 5.28005f, 0.70844f);
            f1826.AddVertex(-1.19119f, 5.22215f, 0.76652f);
            faces.Add(f1826);

            Face f1827 = new Face(m03___Default);
            f1827.AddVertex(-1.09490f, 5.29267f, 0.72659f);
            f1827.AddVertex(-1.13850f, 5.27722f, 0.72814f);
            f1827.AddVertex(-1.17139f, 5.26101f, 0.74076f);
            f1827.AddVertex(-1.21048f, 5.23477f, 0.78468f);
            faces.Add(f1827);

            Face f1828 = new Face(m03___Default);
            f1828.AddVertex(-1.12936f, 5.47187f, 0.73264f);
            f1828.AddVertex(-1.16229f, 5.48806f, 0.75007f);
            f1828.AddVertex(-1.12652f, 5.47923f, 0.74393f);
            f1828.AddVertex(-1.10196f, 5.42610f, 0.68930f);
            faces.Add(f1828);

            Face f1829 = new Face(m03___Default);
            f1829.AddVertex(-1.06393f, 5.32272f, 0.67805f);
            f1829.AddVertex(-1.10196f, 5.42610f, 0.68930f);
            f1829.AddVertex(-1.12652f, 5.47923f, 0.74393f);
            f1829.AddVertex(-1.03578f, 5.39473f, 0.68979f);
            faces.Add(f1829);

            Face f1830 = new Face(m03___Default);
            f1830.AddVertex(-1.12652f, 5.47923f, 0.74393f);
            f1830.AddVertex(-1.06936f, 5.43567f, 0.70715f);
            f1830.AddVertex(-1.03578f, 5.39473f, 0.68979f);
            faces.Add(f1830);

            Face f1831 = new Face(m03___Default);
            f1831.AddVertex(-1.03578f, 5.39473f, 0.68979f);
            f1831.AddVertex(-1.02562f, 5.31765f, 0.69663f);
            f1831.AddVertex(-1.06393f, 5.32272f, 0.67805f);
            faces.Add(f1831);

            Face f1832 = new Face(m03___Default);
            f1832.AddVertex(-1.13059f, 5.35143f, 0.65205f);
            f1832.AddVertex(-1.10196f, 5.42610f, 0.68930f);
            f1832.AddVertex(-1.06393f, 5.32272f, 0.67805f);
            f1832.AddVertex(-1.10349f, 5.33239f, 0.66134f);
            faces.Add(f1832);

            Face f1833 = new Face(m03___Default);
            f1833.AddVertex(-1.10196f, 5.42610f, 0.68930f);
            f1833.AddVertex(-1.13059f, 5.35143f, 0.65205f);
            f1833.AddVertex(-1.12212f, 5.37765f, 0.65804f);
            f1833.AddVertex(-1.11550f, 5.39802f, 0.66762f);
            faces.Add(f1833);

            Face f1834 = new Face(m03___Default);
            f1834.AddVertex(-1.12125f, 5.43872f, 0.70746f);
            f1834.AddVertex(-1.13479f, 5.41063f, 0.68576f);
            f1834.AddVertex(-1.14138f, 5.39034f, 0.67621f);
            f1834.AddVertex(-1.12278f, 5.34501f, 0.67948f);
            faces.Add(f1834);

            Face f1835 = new Face(m03___Default);
            f1835.AddVertex(-1.14138f, 5.39034f, 0.67621f);
            f1835.AddVertex(-1.14989f, 5.36405f, 0.67019f);
            f1835.AddVertex(-1.12278f, 5.34501f, 0.67948f);
            faces.Add(f1835);

            Face f1836 = new Face(m03___Default);
            f1836.AddVertex(-1.08865f, 5.44829f, 0.72530f);
            f1836.AddVertex(-1.12125f, 5.43872f, 0.70746f);
            f1836.AddVertex(-1.12278f, 5.34501f, 0.67948f);
            f1836.AddVertex(-1.04491f, 5.33027f, 0.71478f);
            faces.Add(f1836);

            Face f1837 = new Face(m03___Default);
            f1837.AddVertex(-1.12278f, 5.34501f, 0.67948f);
            f1837.AddVertex(-1.08323f, 5.33534f, 0.69620f);
            f1837.AddVertex(-1.04491f, 5.33027f, 0.71478f);
            faces.Add(f1837);

            Face f1838 = new Face(m03___Default);
            f1838.AddVertex(-1.04491f, 5.33027f, 0.71478f);
            f1838.AddVertex(-1.05508f, 5.40735f, 0.70793f);
            f1838.AddVertex(-1.08865f, 5.44829f, 0.72530f);
            faces.Add(f1838);

            Face f1839 = new Face(m03___Default);
            f1839.AddVertex(-1.14857f, 5.48445f, 0.75075f);
            f1839.AddVertex(-1.12125f, 5.43872f, 0.70746f);
            f1839.AddVertex(-1.08865f, 5.44829f, 0.72530f);
            f1839.AddVertex(-1.18159f, 5.50068f, 0.76822f);
            faces.Add(f1839);

            Face f1840 = new Face(m03___Default);
            f1840.AddVertex(-1.18159f, 5.50068f, 0.76822f);
            f1840.AddVertex(-1.08865f, 5.44829f, 0.72530f);
            f1840.AddVertex(-1.14575f, 5.49183f, 0.76207f);
            faces.Add(f1840);

            Face f1841 = new Face(m03___Default);
            f1841.AddVertex(-1.04491f, 5.33027f, 0.71478f);
            f1841.AddVertex(-0.95677f, 5.41739f, 0.76299f);
            f1841.AddVertex(-1.00205f, 5.40957f, 0.73214f);
            faces.Add(f1841);

            Face f1842 = new Face(m03___Default);
            f1842.AddVertex(-0.88411f, 5.38864f, 0.77530f);
            f1842.AddVertex(-0.82054f, 5.34204f, 0.82940f);
            f1842.AddVertex(-0.88873f, 5.33401f, 0.76865f);
            f1842.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            faces.Add(f1842);

            Face f1843 = new Face(m03___Default);
            f1843.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            f1843.AddVertex(-0.88873f, 5.33401f, 0.76865f);
            f1843.AddVertex(-0.91300f, 5.30951f, 0.76712f);
            f1843.AddVertex(-1.18558f, 5.20791f, 0.82028f);
            faces.Add(f1843);

            Face f1844 = new Face(m03___Default);
            f1844.AddVertex(-1.18558f, 5.20791f, 0.82028f);
            f1844.AddVertex(-0.91300f, 5.30951f, 0.76712f);
            f1844.AddVertex(-1.14187f, 5.19021f, 0.92743f);
            f1844.AddVertex(-1.17878f, 5.19050f, 0.90415f);
            faces.Add(f1844);

            Face f1845 = new Face(m03___Default);
            f1845.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            f1845.AddVertex(-1.18558f, 5.20791f, 0.82028f);
            f1845.AddVertex(-1.19119f, 5.22215f, 0.76652f);
            f1845.AddVertex(-1.07560f, 5.28005f, 0.70844f);
            faces.Add(f1845);

            Face f1846 = new Face(m03___Default);
            f1846.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            f1846.AddVertex(-1.07560f, 5.28005f, 0.70844f);
            f1846.AddVertex(-1.02562f, 5.31765f, 0.69663f);
            faces.Add(f1846);

            Face f1847 = new Face(m03___Default);
            f1847.AddVertex(-1.01323f, 5.44709f, 0.75560f);
            f1847.AddVertex(-1.00205f, 5.40957f, 0.73214f);
            f1847.AddVertex(-0.95677f, 5.41739f, 0.76299f);
            f1847.AddVertex(-1.05823f, 5.48285f, 0.77925f);
            faces.Add(f1847);

            Face f1848 = new Face(m03___Default);
            f1848.AddVertex(-1.03893f, 5.47024f, 0.76110f);
            f1848.AddVertex(-1.05823f, 5.48285f, 0.77925f);
            f1848.AddVertex(-1.12571f, 5.51456f, 0.80682f);
            f1848.AddVertex(-1.10642f, 5.50195f, 0.78867f);
            faces.Add(f1848);

            Face f1849 = new Face(m03___Default);
            f1849.AddVertex(-1.10642f, 5.50195f, 0.78867f);
            f1849.AddVertex(-1.12571f, 5.51456f, 0.80682f);
            f1849.AddVertex(-1.20785f, 5.53593f, 0.83090f);
            f1849.AddVertex(-1.18856f, 5.52332f, 0.81275f);
            faces.Add(f1849);

            Face f1850 = new Face(m03___Default);
            f1850.AddVertex(-1.22150f, 5.56094f, 0.91273f);
            f1850.AddVertex(-1.21675f, 5.54548f, 0.86460f);
            f1850.AddVertex(-1.23605f, 5.55810f, 0.88276f);
            f1850.AddVertex(-1.24079f, 5.57355f, 0.93088f);
            faces.Add(f1850);

            Face f1851 = new Face(m03___Default);
            f1851.AddVertex(-1.21345f, 5.57238f, 0.96269f);
            f1851.AddVertex(-1.22150f, 5.56094f, 0.91273f);
            f1851.AddVertex(-1.24079f, 5.57355f, 0.93088f);
            f1851.AddVertex(-1.23275f, 5.58499f, 0.98085f);
            faces.Add(f1851);

            Face f1852 = new Face(m03___Default);
            f1852.AddVertex(-1.15717f, 5.56877f, 0.97925f);
            f1852.AddVertex(-1.21345f, 5.57238f, 0.96269f);
            f1852.AddVertex(-1.23275f, 5.58499f, 0.98085f);
            f1852.AddVertex(-1.17647f, 5.58138f, 0.99740f);
            faces.Add(f1852);

            Face f1853 = new Face(m03___Default);
            f1853.AddVertex(-1.08832f, 5.55247f, 0.95613f);
            f1853.AddVertex(-1.15717f, 5.56877f, 0.97925f);
            f1853.AddVertex(-1.17647f, 5.58138f, 0.99740f);
            f1853.AddVertex(-1.10761f, 5.56508f, 0.97428f);
            faces.Add(f1853);

            Face f1854 = new Face(m03___Default);
            f1854.AddVertex(-1.01311f, 5.52603f, 0.91871f);
            f1854.AddVertex(-1.08832f, 5.55247f, 0.95613f);
            f1854.AddVertex(-1.10761f, 5.56508f, 0.97428f);
            f1854.AddVertex(-1.03240f, 5.53863f, 0.93686f);
            faces.Add(f1854);

            Face f1855 = new Face(m03___Default);
            f1855.AddVertex(-0.97490f, 5.50862f, 0.89790f);
            f1855.AddVertex(-1.01311f, 5.52603f, 0.91871f);
            f1855.AddVertex(-1.03240f, 5.53863f, 0.93686f);
            f1855.AddVertex(-0.99419f, 5.52123f, 0.91605f);
            faces.Add(f1855);

            Face f1856 = new Face(m03___Default);
            f1856.AddVertex(-0.96588f, 5.49802f, 0.87260f);
            f1856.AddVertex(-0.97490f, 5.50862f, 0.89790f);
            f1856.AddVertex(-0.99419f, 5.52123f, 0.91605f);
            f1856.AddVertex(-0.98517f, 5.51064f, 0.89075f);
            faces.Add(f1856);

            Face f1857 = new Face(m03___Default);
            f1857.AddVertex(-0.98335f, 5.49585f, 0.84809f);
            f1857.AddVertex(-0.96588f, 5.49802f, 0.87260f);
            f1857.AddVertex(-0.98517f, 5.51064f, 0.89075f);
            f1857.AddVertex(-1.00264f, 5.50847f, 0.86624f);
            faces.Add(f1857);

            Face f1858 = new Face(m03___Default);
            f1858.AddVertex(-0.99514f, 5.48990f, 0.82355f);
            f1858.AddVertex(-0.98335f, 5.49585f, 0.84809f);
            f1858.AddVertex(-1.00264f, 5.50847f, 0.86624f);
            f1858.AddVertex(-1.01443f, 5.50252f, 0.84170f);
            faces.Add(f1858);

            Face f1859 = new Face(m03___Default);
            f1859.AddVertex(-0.98566f, 5.46502f, 0.78251f);
            f1859.AddVertex(-0.99514f, 5.48990f, 0.82355f);
            f1859.AddVertex(-1.01443f, 5.50252f, 0.84170f);
            f1859.AddVertex(-1.00496f, 5.47763f, 0.80066f);
            faces.Add(f1859);

            Face f1860 = new Face(m03___Default);
            f1860.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            f1860.AddVertex(-0.98566f, 5.46502f, 0.78251f);
            f1860.AddVertex(-1.00496f, 5.47763f, 0.80066f);
            f1860.AddVertex(-0.95677f, 5.41739f, 0.76299f);
            faces.Add(f1860);

            Face f1861 = new Face(m03___Default);
            f1861.AddVertex(-0.88411f, 5.38864f, 0.77530f);
            f1861.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            f1861.AddVertex(-0.95677f, 5.41739f, 0.76299f);
            f1861.AddVertex(-0.90340f, 5.40126f, 0.79345f);
            faces.Add(f1861);

            Face f1862 = new Face(m03___Default);
            f1862.AddVertex(-0.86771f, 5.41670f, 0.81493f);
            f1862.AddVertex(-0.88411f, 5.38864f, 0.77530f);
            f1862.AddVertex(-0.90340f, 5.40126f, 0.79345f);
            f1862.AddVertex(-0.88701f, 5.42932f, 0.83308f);
            faces.Add(f1862);

            Face f1863 = new Face(m03___Default);
            f1863.AddVertex(-0.90953f, 5.46377f, 0.84745f);
            f1863.AddVertex(-0.86771f, 5.41670f, 0.81493f);
            f1863.AddVertex(-0.88701f, 5.42932f, 0.83308f);
            f1863.AddVertex(-0.92882f, 5.47639f, 0.86560f);
            faces.Add(f1863);

            Face f1864 = new Face(m03___Default);
            f1864.AddVertex(-0.93658f, 5.49441f, 0.90012f);
            f1864.AddVertex(-0.90953f, 5.46377f, 0.84745f);
            f1864.AddVertex(-0.92882f, 5.47639f, 0.86560f);
            f1864.AddVertex(-0.95587f, 5.50703f, 0.91827f);
            faces.Add(f1864);

            Face f1865 = new Face(m03___Default);
            f1865.AddVertex(-0.94632f, 5.50540f, 0.93114f);
            f1865.AddVertex(-0.93658f, 5.49441f, 0.90012f);
            f1865.AddVertex(-0.95587f, 5.50703f, 0.91827f);
            f1865.AddVertex(-0.96562f, 5.51801f, 0.94929f);
            faces.Add(f1865);

            Face f1866 = new Face(m03___Default);
            f1866.AddVertex(-0.86989f, 5.46500f, 0.91153f);
            f1866.AddVertex(-0.94632f, 5.50540f, 0.93114f);
            f1866.AddVertex(-0.96562f, 5.51801f, 0.94929f);
            f1866.AddVertex(-0.88918f, 5.47762f, 0.92968f);
            faces.Add(f1866);

            Face f1867 = new Face(m03___Default);
            f1867.AddVertex(-0.79805f, 5.39887f, 0.89009f);
            f1867.AddVertex(-0.86989f, 5.46500f, 0.91153f);
            f1867.AddVertex(-0.88918f, 5.47762f, 0.92968f);
            f1867.AddVertex(-0.81734f, 5.41149f, 0.90825f);
            faces.Add(f1867);

            Face f1868 = new Face(m03___Default);
            f1868.AddVertex(-0.78819f, 5.35635f, 0.87174f);
            f1868.AddVertex(-0.79805f, 5.39887f, 0.89009f);
            f1868.AddVertex(-0.81734f, 5.41149f, 0.90825f);
            f1868.AddVertex(-0.80748f, 5.36897f, 0.88989f);
            faces.Add(f1868);

            Face f1869 = new Face(m03___Default);
            f1869.AddVertex(-0.82054f, 5.34204f, 0.82940f);
            f1869.AddVertex(-0.78819f, 5.35635f, 0.87174f);
            f1869.AddVertex(-0.80748f, 5.36897f, 0.88989f);
            f1869.AddVertex(-0.83984f, 5.35465f, 0.84755f);
            faces.Add(f1869);

            Face f1870 = new Face(m03___Default);
            f1870.AddVertex(-0.88873f, 5.33401f, 0.76865f);
            f1870.AddVertex(-0.82054f, 5.34204f, 0.82940f);
            f1870.AddVertex(-0.83984f, 5.35465f, 0.84755f);
            f1870.AddVertex(-0.90803f, 5.34662f, 0.78680f);
            faces.Add(f1870);

            Face f1871 = new Face(m03___Default);
            f1871.AddVertex(-0.91300f, 5.30951f, 0.76712f);
            f1871.AddVertex(-0.88873f, 5.33401f, 0.76865f);
            f1871.AddVertex(-0.90803f, 5.34662f, 0.78680f);
            f1871.AddVertex(-0.93230f, 5.32213f, 0.78527f);
            faces.Add(f1871);

            Face f1872 = new Face(m03___Default);
            f1872.AddVertex(-0.88686f, 5.28771f, 0.81118f);
            f1872.AddVertex(-0.91300f, 5.30951f, 0.76712f);
            f1872.AddVertex(-0.93230f, 5.32213f, 0.78527f);
            f1872.AddVertex(-0.90616f, 5.30032f, 0.82933f);
            faces.Add(f1872);

            Face f1873 = new Face(m03___Default);
            f1873.AddVertex(-0.87624f, 5.26412f, 0.85807f);
            f1873.AddVertex(-0.88686f, 5.28771f, 0.81118f);
            f1873.AddVertex(-0.90616f, 5.30032f, 0.82933f);
            f1873.AddVertex(-0.89553f, 5.27674f, 0.87622f);
            faces.Add(f1873);

            Face f1874 = new Face(m03___Default);
            f1874.AddVertex(-0.88636f, 5.23948f, 0.90495f);
            f1874.AddVertex(-0.87624f, 5.26412f, 0.85807f);
            f1874.AddVertex(-0.89553f, 5.27674f, 0.87622f);
            f1874.AddVertex(-0.90568f, 5.25209f, 0.92311f);
            faces.Add(f1874);

            Face f1875 = new Face(m03___Default);
            f1875.AddVertex(-0.91481f, 5.22580f, 0.92309f);
            f1875.AddVertex(-0.88636f, 5.23948f, 0.90495f);
            f1875.AddVertex(-0.90568f, 5.25209f, 0.92311f);
            f1875.AddVertex(-0.93410f, 5.23841f, 0.94123f);
            faces.Add(f1875);

            Face f1876 = new Face(m03___Default);
            f1876.AddVertex(-0.97035f, 5.20453f, 0.96202f);
            f1876.AddVertex(-0.91481f, 5.22580f, 0.92309f);
            f1876.AddVertex(-0.93410f, 5.23841f, 0.94123f);
            f1876.AddVertex(-0.98965f, 5.21715f, 0.98017f);
            faces.Add(f1876);

            Face f1877 = new Face(m03___Default);
            f1877.AddVertex(-1.02883f, 5.19850f, 0.95362f);
            f1877.AddVertex(-0.97035f, 5.20453f, 0.96202f);
            f1877.AddVertex(-0.98965f, 5.21715f, 0.98017f);
            f1877.AddVertex(-1.04812f, 5.21111f, 0.97177f);
            faces.Add(f1877);

            Face f1878 = new Face(m03___Default);
            f1878.AddVertex(-1.08863f, 5.18821f, 0.96838f);
            f1878.AddVertex(-1.02883f, 5.19850f, 0.95362f);
            f1878.AddVertex(-1.04812f, 5.21111f, 0.97177f);
            f1878.AddVertex(-1.10792f, 5.20083f, 0.98653f);
            faces.Add(f1878);

            Face f1879 = new Face(m03___Default);
            f1879.AddVertex(-1.15094f, 5.17713f, 0.99507f);
            f1879.AddVertex(-1.08863f, 5.18821f, 0.96838f);
            f1879.AddVertex(-1.10792f, 5.20083f, 0.98653f);
            f1879.AddVertex(-1.17023f, 5.18975f, 1.01322f);
            faces.Add(f1879);

            Face f1880 = new Face(m03___Default);
            f1880.AddVertex(-1.14187f, 5.19021f, 0.92743f);
            f1880.AddVertex(-1.15094f, 5.17713f, 0.99507f);
            f1880.AddVertex(-1.17023f, 5.18975f, 1.01322f);
            f1880.AddVertex(-1.16116f, 5.20283f, 0.94559f);
            faces.Add(f1880);

            Face f1881 = new Face(m03___Default);
            f1881.AddVertex(-1.17878f, 5.19050f, 0.90415f);
            f1881.AddVertex(-1.14187f, 5.19021f, 0.92743f);
            f1881.AddVertex(-1.16116f, 5.20283f, 0.94559f);
            f1881.AddVertex(-1.19807f, 5.20311f, 0.92230f);
            faces.Add(f1881);

            Face f1882 = new Face(m03___Default);
            f1882.AddVertex(-1.18558f, 5.20791f, 0.82028f);
            f1882.AddVertex(-1.17878f, 5.19050f, 0.90415f);
            f1882.AddVertex(-1.19807f, 5.20311f, 0.92230f);
            f1882.AddVertex(-1.20487f, 5.22053f, 0.83843f);
            faces.Add(f1882);

            Face f1883 = new Face(m03___Default);
            f1883.AddVertex(-1.19119f, 5.22215f, 0.76652f);
            f1883.AddVertex(-1.18558f, 5.20791f, 0.82028f);
            f1883.AddVertex(-1.20487f, 5.22053f, 0.83843f);
            f1883.AddVertex(-1.21048f, 5.23477f, 0.78468f);
            faces.Add(f1883);

            Face f1884 = new Face(m03___Default);
            f1884.AddVertex(-1.15210f, 5.24840f, 0.72262f);
            f1884.AddVertex(-1.19119f, 5.22215f, 0.76652f);
            f1884.AddVertex(-1.21048f, 5.23477f, 0.78468f);
            f1884.AddVertex(-1.17139f, 5.26101f, 0.74076f);
            faces.Add(f1884);

            Face f1885 = new Face(m03___Default);
            f1885.AddVertex(-1.11920f, 5.26460f, 0.70999f);
            f1885.AddVertex(-1.15210f, 5.24840f, 0.72262f);
            f1885.AddVertex(-1.17139f, 5.26101f, 0.74076f);
            f1885.AddVertex(-1.13850f, 5.27722f, 0.72814f);
            faces.Add(f1885);

            Face f1886 = new Face(m03___Default);
            f1886.AddVertex(-1.07560f, 5.28005f, 0.70844f);
            f1886.AddVertex(-1.11920f, 5.26460f, 0.70999f);
            f1886.AddVertex(-1.13850f, 5.27722f, 0.72814f);
            f1886.AddVertex(-1.09490f, 5.29267f, 0.72659f);
            faces.Add(f1886);

            Face f1887 = new Face(m03___Default);
            f1887.AddVertex(-1.02562f, 5.31765f, 0.69663f);
            f1887.AddVertex(-1.07560f, 5.28005f, 0.70844f);
            f1887.AddVertex(-1.09490f, 5.29267f, 0.72659f);
            f1887.AddVertex(-1.04491f, 5.33027f, 0.71478f);
            faces.Add(f1887);

            Face f1888 = new Face(m03___Default);
            f1888.AddVertex(-1.06393f, 5.32272f, 0.67805f);
            f1888.AddVertex(-1.02562f, 5.31765f, 0.69663f);
            f1888.AddVertex(-1.04491f, 5.33027f, 0.71478f);
            f1888.AddVertex(-1.08323f, 5.33534f, 0.69620f);
            faces.Add(f1888);

            Face f1889 = new Face(m03___Default);
            f1889.AddVertex(-1.10349f, 5.33239f, 0.66134f);
            f1889.AddVertex(-1.06393f, 5.32272f, 0.67805f);
            f1889.AddVertex(-1.08323f, 5.33534f, 0.69620f);
            f1889.AddVertex(-1.12278f, 5.34501f, 0.67948f);
            faces.Add(f1889);

            Face f1890 = new Face(m03___Default);
            f1890.AddVertex(-1.13059f, 5.35143f, 0.65205f);
            f1890.AddVertex(-1.10349f, 5.33239f, 0.66134f);
            f1890.AddVertex(-1.12278f, 5.34501f, 0.67948f);
            f1890.AddVertex(-1.14989f, 5.36405f, 0.67019f);
            faces.Add(f1890);

            Face f1891 = new Face(m03___Default);
            f1891.AddVertex(-1.12212f, 5.37765f, 0.65804f);
            f1891.AddVertex(-1.13059f, 5.35143f, 0.65205f);
            f1891.AddVertex(-1.14989f, 5.36405f, 0.67019f);
            f1891.AddVertex(-1.14138f, 5.39034f, 0.67621f);
            faces.Add(f1891);

            Face f1892 = new Face(m03___Default);
            f1892.AddVertex(-1.11550f, 5.39802f, 0.66762f);
            f1892.AddVertex(-1.12212f, 5.37765f, 0.65804f);
            f1892.AddVertex(-1.14138f, 5.39034f, 0.67621f);
            f1892.AddVertex(-1.13479f, 5.41063f, 0.68576f);
            faces.Add(f1892);

            Face f1893 = new Face(m03___Default);
            f1893.AddVertex(-1.10196f, 5.42610f, 0.68930f);
            f1893.AddVertex(-1.11550f, 5.39802f, 0.66762f);
            f1893.AddVertex(-1.13479f, 5.41063f, 0.68576f);
            f1893.AddVertex(-1.12125f, 5.43872f, 0.70746f);
            faces.Add(f1893);

            Face f1894 = new Face(m03___Default);
            f1894.AddVertex(-1.12936f, 5.47187f, 0.73264f);
            f1894.AddVertex(-1.10196f, 5.42610f, 0.68930f);
            f1894.AddVertex(-1.12125f, 5.43872f, 0.70746f);
            f1894.AddVertex(-1.14857f, 5.48445f, 0.75075f);
            faces.Add(f1894);

            Face f1895 = new Face(m03___Default);
            f1895.AddVertex(-1.16229f, 5.48806f, 0.75007f);
            f1895.AddVertex(-1.12936f, 5.47187f, 0.73264f);
            f1895.AddVertex(-1.14857f, 5.48445f, 0.75075f);
            f1895.AddVertex(-1.18159f, 5.50068f, 0.76822f);
            faces.Add(f1895);

            Face f1896 = new Face(m03___Default);
            f1896.AddVertex(-1.12652f, 5.47923f, 0.74393f);
            f1896.AddVertex(-1.16229f, 5.48806f, 0.75007f);
            f1896.AddVertex(-1.18159f, 5.50068f, 0.76822f);
            f1896.AddVertex(-1.14575f, 5.49183f, 0.76207f);
            faces.Add(f1896);

            Face f1897 = new Face(m03___Default);
            f1897.AddVertex(-1.06936f, 5.43567f, 0.70715f);
            f1897.AddVertex(-1.12652f, 5.47923f, 0.74393f);
            f1897.AddVertex(-1.14575f, 5.49183f, 0.76207f);
            f1897.AddVertex(-1.08865f, 5.44829f, 0.72530f);
            faces.Add(f1897);

            Face f1898 = new Face(m03___Default);
            f1898.AddVertex(-1.03578f, 5.39473f, 0.68979f);
            f1898.AddVertex(-1.06936f, 5.43567f, 0.70715f);
            f1898.AddVertex(-1.08865f, 5.44829f, 0.72530f);
            f1898.AddVertex(-1.05508f, 5.40735f, 0.70793f);
            faces.Add(f1898);

            Face f1899 = new Face(m03___Default);
            f1899.AddVertex(-0.98276f, 5.39695f, 0.71399f);
            f1899.AddVertex(-1.03578f, 5.39473f, 0.68979f);
            f1899.AddVertex(-1.05508f, 5.40735f, 0.70793f);
            f1899.AddVertex(-1.00205f, 5.40957f, 0.73214f);
            faces.Add(f1899);

            Face f1900 = new Face(m03___Default);
            f1900.AddVertex(-0.99386f, 5.43444f, 0.73746f);
            f1900.AddVertex(-0.98276f, 5.39695f, 0.71399f);
            f1900.AddVertex(-1.00205f, 5.40957f, 0.73214f);
            f1900.AddVertex(-1.01323f, 5.44709f, 0.75560f);
            faces.Add(f1900);

            Face f1901 = new Face(m03___Default);
            f1901.AddVertex(-1.03893f, 5.47024f, 0.76110f);
            f1901.AddVertex(-0.99386f, 5.43444f, 0.73746f);
            f1901.AddVertex(-1.01323f, 5.44709f, 0.75560f);
            f1901.AddVertex(-1.05823f, 5.48285f, 0.77925f);
            faces.Add(f1901);

            Face f1902 = new Face(m03___Default);
            f1902.AddVertex(-0.98276f, 5.39695f, 0.71399f);
            f1902.AddVertex(-0.99386f, 5.43444f, 0.73746f);
            f1902.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            faces.Add(f1902);

            Face f1903 = new Face(m03___Default);
            f1903.AddVertex(-1.18856f, 5.52332f, 0.81275f);
            f1903.AddVertex(-1.21675f, 5.54548f, 0.86460f);
            f1903.AddVertex(-1.22150f, 5.56094f, 0.91273f);
            f1903.AddVertex(-1.21345f, 5.57238f, 0.96269f);
            faces.Add(f1903);

            Face f1904 = new Face(m03___Default);
            f1904.AddVertex(-0.97490f, 5.50862f, 0.89790f);
            f1904.AddVertex(-1.18856f, 5.52332f, 0.81275f);
            f1904.AddVertex(-1.21345f, 5.57238f, 0.96269f);
            f1904.AddVertex(-1.15717f, 5.56877f, 0.97925f);
            faces.Add(f1904);

            Face f1905 = new Face(m03___Default);
            f1905.AddVertex(-1.01311f, 5.52603f, 0.91871f);
            f1905.AddVertex(-0.97490f, 5.50862f, 0.89790f);
            f1905.AddVertex(-1.15717f, 5.56877f, 0.97925f);
            f1905.AddVertex(-1.08832f, 5.55247f, 0.95613f);
            faces.Add(f1905);

            Face f1906 = new Face(m03___Default);
            f1906.AddVertex(-1.18856f, 5.52332f, 0.81275f);
            f1906.AddVertex(-0.97490f, 5.50862f, 0.89790f);
            f1906.AddVertex(-0.96588f, 5.49802f, 0.87260f);
            f1906.AddVertex(-0.98335f, 5.49585f, 0.84809f);
            faces.Add(f1906);

            Face f1907 = new Face(m03___Default);
            f1907.AddVertex(-1.18856f, 5.52332f, 0.81275f);
            f1907.AddVertex(-0.98335f, 5.49585f, 0.84809f);
            f1907.AddVertex(-0.99514f, 5.48990f, 0.82355f);
            f1907.AddVertex(-0.98566f, 5.46502f, 0.78251f);
            faces.Add(f1907);

            Face f1908 = new Face(m03___Default);
            f1908.AddVertex(-1.10642f, 5.50195f, 0.78867f);
            f1908.AddVertex(-1.18856f, 5.52332f, 0.81275f);
            f1908.AddVertex(-0.98566f, 5.46502f, 0.78251f);
            f1908.AddVertex(-1.03893f, 5.47024f, 0.76110f);
            faces.Add(f1908);

            Face f1909 = new Face(m03___Default);
            f1909.AddVertex(-1.03893f, 5.47024f, 0.76110f);
            f1909.AddVertex(-0.98566f, 5.46502f, 0.78251f);
            f1909.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            faces.Add(f1909);

            Face f1910 = new Face(m03___Default);
            f1910.AddVertex(-1.20487f, 5.22053f, 0.83843f);
            f1910.AddVertex(-1.19807f, 5.20311f, 0.92230f);
            f1910.AddVertex(-1.16116f, 5.20283f, 0.94559f);
            f1910.AddVertex(-0.93230f, 5.32213f, 0.78527f);
            faces.Add(f1910);

            Face f1911 = new Face(m03___Default);
            f1911.AddVertex(-1.21048f, 5.23477f, 0.78468f);
            f1911.AddVertex(-1.20487f, 5.22053f, 0.83843f);
            f1911.AddVertex(-0.93230f, 5.32213f, 0.78527f);
            f1911.AddVertex(-0.95677f, 5.41739f, 0.76299f);
            faces.Add(f1911);

            Face f1912 = new Face(m03___Default);
            f1912.AddVertex(-0.95677f, 5.41739f, 0.76299f);
            f1912.AddVertex(-0.93230f, 5.32213f, 0.78527f);
            f1912.AddVertex(-0.90803f, 5.34662f, 0.78680f);
            f1912.AddVertex(-0.90340f, 5.40126f, 0.79345f);
            faces.Add(f1912);

            Face f1913 = new Face(m03___Default);
            f1913.AddVertex(-1.09490f, 5.29267f, 0.72659f);
            f1913.AddVertex(-1.21048f, 5.23477f, 0.78468f);
            f1913.AddVertex(-0.95677f, 5.41739f, 0.76299f);
            f1913.AddVertex(-1.04491f, 5.33027f, 0.71478f);
            faces.Add(f1913);

            Face f1914 = new Face(m03___Default);
            f1914.AddVertex(-0.90953f, 5.46377f, 0.84745f);
            f1914.AddVertex(-0.93658f, 5.49441f, 0.90012f);
            f1914.AddVertex(-0.94632f, 5.50540f, 0.93114f);
            f1914.AddVertex(-0.79805f, 5.39887f, 0.89009f);
            faces.Add(f1914);

            Face f1915 = new Face(m03___Default);
            f1915.AddVertex(-0.94632f, 5.50540f, 0.93114f);
            f1915.AddVertex(-0.86989f, 5.46500f, 0.91153f);
            f1915.AddVertex(-0.79805f, 5.39887f, 0.89009f);
            faces.Add(f1915);

            Face f1916 = new Face(m03___Default);
            f1916.AddVertex(-0.82054f, 5.34204f, 0.82940f);
            f1916.AddVertex(-0.90953f, 5.46377f, 0.84745f);
            f1916.AddVertex(-0.79805f, 5.39887f, 0.89009f);
            f1916.AddVertex(-0.78819f, 5.35635f, 0.87174f);
            faces.Add(f1916);

            Face f1917 = new Face(m03___Default);
            f1917.AddVertex(-0.86771f, 5.41670f, 0.81493f);
            f1917.AddVertex(-0.90953f, 5.46377f, 0.84745f);
            f1917.AddVertex(-0.82054f, 5.34204f, 0.82940f);
            faces.Add(f1917);

            Face f1918 = new Face(m03___Default);
            f1918.AddVertex(-0.88411f, 5.38864f, 0.77530f);
            f1918.AddVertex(-0.86771f, 5.41670f, 0.81493f);
            f1918.AddVertex(-0.82054f, 5.34204f, 0.82940f);
            faces.Add(f1918);

            Face f1919 = new Face(m03___Default);
            f1919.AddVertex(-0.90340f, 5.40126f, 0.79345f);
            f1919.AddVertex(-0.90803f, 5.34662f, 0.78680f);
            f1919.AddVertex(-0.83984f, 5.35465f, 0.84755f);
            f1919.AddVertex(-0.88701f, 5.42932f, 0.83308f);
            faces.Add(f1919);

            Face f1920 = new Face(m03___Default);
            f1920.AddVertex(-1.04812f, 5.21111f, 0.97177f);
            f1920.AddVertex(-0.98965f, 5.21715f, 0.98017f);
            f1920.AddVertex(-0.93410f, 5.23841f, 0.94123f);
            faces.Add(f1920);

            Face f1921 = new Face(m03___Default);
            f1921.AddVertex(-1.10792f, 5.20083f, 0.98653f);
            f1921.AddVertex(-1.04812f, 5.21111f, 0.97177f);
            f1921.AddVertex(-0.93410f, 5.23841f, 0.94123f);
            f1921.AddVertex(-0.90616f, 5.30032f, 0.82933f);
            faces.Add(f1921);

            Face f1922 = new Face(m03___Default);
            f1922.AddVertex(-0.90616f, 5.30032f, 0.82933f);
            f1922.AddVertex(-0.93410f, 5.23841f, 0.94123f);
            f1922.AddVertex(-0.90568f, 5.25209f, 0.92311f);
            f1922.AddVertex(-0.89553f, 5.27674f, 0.87622f);
            faces.Add(f1922);

            Face f1923 = new Face(m03___Default);
            f1923.AddVertex(-1.16116f, 5.20283f, 0.94559f);
            f1923.AddVertex(-1.10792f, 5.20083f, 0.98653f);
            f1923.AddVertex(-0.90616f, 5.30032f, 0.82933f);
            f1923.AddVertex(-0.93230f, 5.32213f, 0.78527f);
            faces.Add(f1923);

            Face f1924 = new Face(m03___Default);
            f1924.AddVertex(-1.03578f, 5.39473f, 0.68979f);
            f1924.AddVertex(-0.98276f, 5.39695f, 0.71399f);
            f1924.AddVertex(-1.02562f, 5.31765f, 0.69663f);
            faces.Add(f1924);

            Face f1925 = new Face(m03___Default);
            f1925.AddVertex(-0.98276f, 5.39695f, 0.71399f);
            f1925.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            f1925.AddVertex(-1.02562f, 5.31765f, 0.69663f);
            faces.Add(f1925);

            Face f1926 = new Face(m03___Default);
            f1926.AddVertex(-1.00205f, 5.40957f, 0.73214f);
            f1926.AddVertex(-1.05508f, 5.40735f, 0.70793f);
            f1926.AddVertex(-1.04491f, 5.33027f, 0.71478f);
            faces.Add(f1926);

            Face f1927 = new Face(m03___Default);
            f1927.AddVertex(-0.99386f, 5.43444f, 0.73746f);
            f1927.AddVertex(-1.03893f, 5.47024f, 0.76110f);
            f1927.AddVertex(-0.93748f, 5.40477f, 0.74483f);
            faces.Add(f1927);

            Face f1928 = new Face(m03___Default);
            f1928.AddVertex(-0.43913f, 4.28039f, 0.97504f);
            f1928.AddVertex(-0.49254f, 4.30634f, 1.03441f);
            f1928.AddVertex(-0.54859f, 4.32210f, 1.08103f);
            f1928.AddVertex(-0.41324f, 4.26320f, 0.94366f);
            faces.Add(f1928);

            Face f1929 = new Face(m03___Default);
            f1929.AddVertex(-0.42003f, 4.25248f, 0.92203f);
            f1929.AddVertex(-0.41324f, 4.26320f, 0.94366f);
            f1929.AddVertex(-0.54859f, 4.32210f, 1.08103f);
            f1929.AddVertex(-0.68611f, 4.27478f, 0.97873f);
            faces.Add(f1929);

            Face f1930 = new Face(m03___Default);
            f1930.AddVertex(-0.65661f, 4.31295f, 1.06306f);
            f1930.AddVertex(-0.68611f, 4.27478f, 0.97873f);
            f1930.AddVertex(-0.54859f, 4.32210f, 1.08103f);
            f1930.AddVertex(-0.61681f, 4.32494f, 1.09439f);
            faces.Add(f1930);

            Face f1931 = new Face(m03___Default);
            f1931.AddVertex(-0.65661f, 4.31295f, 1.06306f);
            f1931.AddVertex(-0.68218f, 4.29710f, 1.02737f);
            f1931.AddVertex(-0.68611f, 4.27478f, 0.97873f);
            faces.Add(f1931);

            Face f1932 = new Face(m03___Default);
            f1932.AddVertex(-0.45339f, 4.24989f, 0.91262f);
            f1932.AddVertex(-0.42003f, 4.25248f, 0.92203f);
            f1932.AddVertex(-0.68611f, 4.27478f, 0.97873f);
            f1932.AddVertex(-0.48102f, 4.24358f, 0.90073f);
            faces.Add(f1932);

            Face f1933 = new Face(m03___Default);
            f1933.AddVertex(-0.49756f, 4.21842f, 0.86802f);
            f1933.AddVertex(-0.48102f, 4.24358f, 0.90073f);
            f1933.AddVertex(-0.68611f, 4.27478f, 0.97873f);
            f1933.AddVertex(-0.61711f, 4.25409f, 0.92558f);
            faces.Add(f1933);

            Face f1934 = new Face(m03___Default);
            f1934.AddVertex(-0.49756f, 4.21842f, 0.86802f);
            f1934.AddVertex(-0.61711f, 4.25409f, 0.92558f);
            f1934.AddVertex(-0.56567f, 4.22286f, 0.87661f);
            f1934.AddVertex(-0.47312f, 4.15835f, 0.82086f);
            faces.Add(f1934);

            Face f1935 = new Face(m03___Default);
            f1935.AddVertex(-0.30161f, 4.09765f, 0.82891f);
            f1935.AddVertex(-0.24146f, 4.11271f, 0.84406f);
            f1935.AddVertex(-0.23897f, 4.15531f, 0.86084f);
            f1935.AddVertex(-0.36314f, 4.26060f, 0.95431f);
            faces.Add(f1935);

            Face f1936 = new Face(m03___Default);
            f1936.AddVertex(-0.23897f, 4.15531f, 0.86084f);
            f1936.AddVertex(-0.29776f, 4.22086f, 0.90705f);
            f1936.AddVertex(-0.36314f, 4.26060f, 0.95431f);
            faces.Add(f1936);

            Face f1937 = new Face(m03___Default);
            f1937.AddVertex(-0.35716f, 4.17169f, 0.83888f);
            f1937.AddVertex(-0.30161f, 4.09765f, 0.82891f);
            f1937.AddVertex(-0.36314f, 4.26060f, 0.95431f);
            f1937.AddVertex(-0.37862f, 4.21860f, 0.87974f);
            faces.Add(f1937);

            Face f1938 = new Face(m03___Default);
            f1938.AddVertex(-0.36314f, 4.26060f, 0.95431f);
            f1938.AddVertex(-0.37277f, 4.24944f, 0.92835f);
            f1938.AddVertex(-0.37862f, 4.21860f, 0.87974f);
            faces.Add(f1938);

            Face f1939 = new Face(m03___Default);
            f1939.AddVertex(-0.33535f, 3.96861f, 0.91666f);
            f1939.AddVertex(-0.43454f, 3.94032f, 0.98905f);
            f1939.AddVertex(-0.48724f, 3.92949f, 1.02609f);
            f1939.AddVertex(-0.37465f, 4.02983f, 0.82505f);
            faces.Add(f1939);

            Face f1940 = new Face(m03___Default);
            f1940.AddVertex(-0.31697f, 3.98245f, 0.89114f);
            f1940.AddVertex(-0.33535f, 3.96861f, 0.91666f);
            f1940.AddVertex(-0.37465f, 4.02983f, 0.82505f);
            f1940.AddVertex(-0.33510f, 4.00679f, 0.85349f);
            faces.Add(f1940);

            Face f1941 = new Face(m03___Default);
            f1941.AddVertex(-0.36888f, 3.94707f, 0.96888f);
            f1941.AddVertex(-0.43454f, 3.94032f, 0.98905f);
            f1941.AddVertex(-0.33535f, 3.96861f, 0.91666f);
            faces.Add(f1941);

            Face f1942 = new Face(m03___Default);
            f1942.AddVertex(-0.57579f, 3.94311f, 1.04217f);
            f1942.AddVertex(-0.54329f, 3.93054f, 1.09378f);
            f1942.AddVertex(-0.49544f, 3.94207f, 1.04725f);
            faces.Add(f1942);

            Face f1943 = new Face(m03___Default);
            f1943.AddVertex(-0.56759f, 3.93054f, 1.02101f);
            f1943.AddVertex(-0.42846f, 4.05095f, 0.80553f);
            f1943.AddVertex(-0.37465f, 4.02983f, 0.82505f);
            f1943.AddVertex(-0.48724f, 3.92949f, 1.02609f);
            faces.Add(f1943);

            Face f1944 = new Face(m03___Default);
            f1944.AddVertex(-0.53509f, 3.91797f, 1.07262f);
            f1944.AddVertex(-0.56759f, 3.93054f, 1.02101f);
            f1944.AddVertex(-0.48724f, 3.92949f, 1.02609f);
            faces.Add(f1944);

            Face f1945 = new Face(m03___Default);
            f1945.AddVertex(-0.70431f, 3.98677f, 0.88126f);
            f1945.AddVertex(-0.67785f, 4.00323f, 0.85760f);
            f1945.AddVertex(-0.63346f, 4.01916f, 0.83696f);
            f1945.AddVertex(-0.71792f, 3.96048f, 0.92972f);
            faces.Add(f1945);

            Face f1946 = new Face(m03___Default);
            f1946.AddVertex(-0.64165f, 4.03173f, 0.85812f);
            f1946.AddVertex(-0.68605f, 4.01580f, 0.87876f);
            f1946.AddVertex(-0.71251f, 3.99934f, 0.90241f);
            f1946.AddVertex(-0.72612f, 3.97306f, 0.95088f);
            faces.Add(f1946);

            Face f1947 = new Face(m03___Default);
            f1947.AddVertex(-0.66835f, 4.21067f, 0.87566f);
            f1947.AddVertex(-0.69096f, 4.22666f, 0.90233f);
            f1947.AddVertex(-0.65819f, 4.21817f, 0.88223f);
            f1947.AddVertex(-0.66845f, 4.16479f, 0.83361f);
            faces.Add(f1947);

            Face f1948 = new Face(m03___Default);
            f1948.AddVertex(-0.63920f, 4.06169f, 0.80998f);
            f1948.AddVertex(-0.66845f, 4.16479f, 0.83361f);
            f1948.AddVertex(-0.65819f, 4.21817f, 0.88223f);
            f1948.AddVertex(-0.60085f, 4.13415f, 0.80489f);
            faces.Add(f1948);

            Face f1949 = new Face(m03___Default);
            f1949.AddVertex(-0.65819f, 4.21817f, 0.88223f);
            f1949.AddVertex(-0.62345f, 4.17489f, 0.83152f);
            f1949.AddVertex(-0.60085f, 4.13415f, 0.80489f);
            faces.Add(f1949);

            Face f1950 = new Face(m03___Default);
            f1950.AddVertex(-0.60085f, 4.13415f, 0.80489f);
            f1950.AddVertex(-0.58827f, 4.05721f, 0.80604f);
            f1950.AddVertex(-0.63920f, 4.06169f, 0.80998f);
            faces.Add(f1950);

            Face f1951 = new Face(m03___Default);
            f1951.AddVertex(-0.72330f, 4.08944f, 0.82104f);
            f1951.AddVertex(-0.66845f, 4.16479f, 0.83361f);
            f1951.AddVertex(-0.63920f, 4.06169f, 0.80998f);
            f1951.AddVertex(-0.69011f, 4.07078f, 0.81572f);
            faces.Add(f1951);

            Face f1952 = new Face(m03___Default);
            f1952.AddVertex(-0.66845f, 4.16479f, 0.83361f);
            f1952.AddVertex(-0.72330f, 4.08944f, 0.82104f);
            f1952.AddVertex(-0.71010f, 4.11581f, 0.82119f);
            f1952.AddVertex(-0.69673f, 4.13635f, 0.82473f);
            faces.Add(f1952);

            Face f1953 = new Face(m03___Default);
            f1953.AddVertex(-0.67665f, 4.17736f, 0.85476f);
            f1953.AddVertex(-0.70493f, 4.14892f, 0.84589f);
            f1953.AddVertex(-0.71824f, 4.12846f, 0.84235f);
            f1953.AddVertex(-0.69831f, 4.08335f, 0.83689f);
            faces.Add(f1953);

            Face f1954 = new Face(m03___Default);
            f1954.AddVertex(-0.71824f, 4.12846f, 0.84235f);
            f1954.AddVertex(-0.73150f, 4.10201f, 0.84220f);
            f1954.AddVertex(-0.69831f, 4.08335f, 0.83689f);
            faces.Add(f1954);

            Face f1955 = new Face(m03___Default);
            f1955.AddVertex(-0.63165f, 4.18746f, 0.85269f);
            f1955.AddVertex(-0.67665f, 4.17736f, 0.85476f);
            f1955.AddVertex(-0.69831f, 4.08335f, 0.83689f);
            f1955.AddVertex(-0.59646f, 4.06978f, 0.82720f);
            faces.Add(f1955);

            Face f1956 = new Face(m03___Default);
            f1956.AddVertex(-0.69831f, 4.08335f, 0.83689f);
            f1956.AddVertex(-0.64740f, 4.07426f, 0.83114f);
            f1956.AddVertex(-0.59646f, 4.06978f, 0.82720f);
            faces.Add(f1956);

            Face f1957 = new Face(m03___Default);
            f1957.AddVertex(-0.59646f, 4.06978f, 0.82720f);
            f1957.AddVertex(-0.60904f, 4.14672f, 0.82605f);
            f1957.AddVertex(-0.63165f, 4.18746f, 0.85269f);
            faces.Add(f1957);

            Face f1958 = new Face(m03___Default);
            f1958.AddVertex(-0.67649f, 4.22320f, 0.89676f);
            f1958.AddVertex(-0.67665f, 4.17736f, 0.85476f);
            f1958.AddVertex(-0.63165f, 4.18746f, 0.85269f);
            f1958.AddVertex(-0.69915f, 4.23923f, 0.92349f);
            faces.Add(f1958);

            Face f1959 = new Face(m03___Default);
            f1959.AddVertex(-0.69915f, 4.23923f, 0.92349f);
            f1959.AddVertex(-0.63165f, 4.18746f, 0.85269f);
            f1959.AddVertex(-0.66632f, 4.23071f, 0.90335f);
            faces.Add(f1959);

            Face f1960 = new Face(m03___Default);
            f1960.AddVertex(-0.59646f, 4.06978f, 0.82720f);
            f1960.AddVertex(-0.47312f, 4.15835f, 0.82086f);
            f1960.AddVertex(-0.53924f, 4.14974f, 0.81944f);
            faces.Add(f1960);

            Face f1961 = new Face(m03___Default);
            f1961.AddVertex(-0.39137f, 4.13051f, 0.79753f);
            f1961.AddVertex(-0.29342f, 4.08508f, 0.80775f);
            f1961.AddVertex(-0.40182f, 4.07574f, 0.79554f);
            f1961.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            faces.Add(f1961);

            Face f1962 = new Face(m03___Default);
            f1962.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            f1962.AddVertex(-0.40182f, 4.07574f, 0.79554f);
            f1962.AddVertex(-0.42846f, 4.05095f, 0.80553f);
            f1962.AddVertex(-0.67900f, 3.94679f, 0.96509f);
            faces.Add(f1962);

            Face f1963 = new Face(m03___Default);
            f1963.AddVertex(-0.67900f, 3.94679f, 0.96509f);
            f1963.AddVertex(-0.42846f, 4.05095f, 0.80553f);
            f1963.AddVertex(-0.56759f, 3.93054f, 1.02101f);
            f1963.AddVertex(-0.62014f, 3.93021f, 1.02108f);
            faces.Add(f1963);

            Face f1964 = new Face(m03___Default);
            f1964.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            f1964.AddVertex(-0.67900f, 3.94679f, 0.96509f);
            f1964.AddVertex(-0.71792f, 3.96048f, 0.92972f);
            f1964.AddVertex(-0.63346f, 4.01916f, 0.83696f);
            faces.Add(f1964);

            Face f1965 = new Face(m03___Default);
            f1965.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            f1965.AddVertex(-0.63346f, 4.01916f, 0.83696f);
            f1965.AddVertex(-0.58827f, 4.05721f, 0.80604f);
            faces.Add(f1965);

            Face f1966 = new Face(m03___Default);
            f1966.AddVertex(-0.53506f, 4.18737f, 0.84044f);
            f1966.AddVertex(-0.53924f, 4.14974f, 0.81944f);
            f1966.AddVertex(-0.47312f, 4.15835f, 0.82086f);
            f1966.AddVertex(-0.56567f, 4.22286f, 0.87661f);
            faces.Add(f1966);

            Face f1967 = new Face(m03___Default);
            f1967.AddVertex(-0.55747f, 4.21029f, 0.85545f);
            f1967.AddVertex(-0.56567f, 4.22286f, 0.87661f);
            f1967.AddVertex(-0.61711f, 4.25409f, 0.92558f);
            f1967.AddVertex(-0.60890f, 4.24151f, 0.90442f);
            faces.Add(f1967);

            Face f1968 = new Face(m03___Default);
            f1968.AddVertex(-0.60890f, 4.24151f, 0.90442f);
            f1968.AddVertex(-0.61711f, 4.25409f, 0.92558f);
            f1968.AddVertex(-0.68611f, 4.27478f, 0.97873f);
            f1968.AddVertex(-0.67791f, 4.26221f, 0.95757f);
            faces.Add(f1968);

            Face f1969 = new Face(m03___Default);
            f1969.AddVertex(-0.64841f, 4.30038f, 1.04190f);
            f1969.AddVertex(-0.67398f, 4.28454f, 1.00621f);
            f1969.AddVertex(-0.68218f, 4.29710f, 1.02737f);
            f1969.AddVertex(-0.65661f, 4.31295f, 1.06306f);
            faces.Add(f1969);

            Face f1970 = new Face(m03___Default);
            f1970.AddVertex(-0.60861f, 4.31237f, 1.07324f);
            f1970.AddVertex(-0.64841f, 4.30038f, 1.04190f);
            f1970.AddVertex(-0.65661f, 4.31295f, 1.06306f);
            f1970.AddVertex(-0.61681f, 4.32494f, 1.09439f);
            faces.Add(f1970);

            Face f1971 = new Face(m03___Default);
            f1971.AddVertex(-0.54039f, 4.30953f, 1.05987f);
            f1971.AddVertex(-0.60861f, 4.31237f, 1.07324f);
            f1971.AddVertex(-0.61681f, 4.32494f, 1.09439f);
            f1971.AddVertex(-0.54859f, 4.32210f, 1.08103f);
            faces.Add(f1971);

            Face f1972 = new Face(m03___Default);
            f1972.AddVertex(-0.48433f, 4.29378f, 1.01325f);
            f1972.AddVertex(-0.54039f, 4.30953f, 1.05987f);
            f1972.AddVertex(-0.54859f, 4.32210f, 1.08103f);
            f1972.AddVertex(-0.49254f, 4.30634f, 1.03441f);
            faces.Add(f1972);

            Face f1973 = new Face(m03___Default);
            f1973.AddVertex(-0.43093f, 4.26781f, 0.95387f);
            f1973.AddVertex(-0.48433f, 4.29378f, 1.01325f);
            f1973.AddVertex(-0.49254f, 4.30634f, 1.03441f);
            f1973.AddVertex(-0.43913f, 4.28039f, 0.97504f);
            faces.Add(f1973);

            Face f1974 = new Face(m03___Default);
            f1974.AddVertex(-0.40504f, 4.25063f, 0.92250f);
            f1974.AddVertex(-0.43093f, 4.26781f, 0.95387f);
            f1974.AddVertex(-0.43913f, 4.28039f, 0.97504f);
            f1974.AddVertex(-0.41324f, 4.26320f, 0.94366f);
            faces.Add(f1974);

            Face f1975 = new Face(m03___Default);
            f1975.AddVertex(-0.41183f, 4.23990f, 0.90087f);
            f1975.AddVertex(-0.40504f, 4.25063f, 0.92250f);
            f1975.AddVertex(-0.41324f, 4.26320f, 0.94366f);
            f1975.AddVertex(-0.42003f, 4.25248f, 0.92203f);
            faces.Add(f1975);

            Face f1976 = new Face(m03___Default);
            f1976.AddVertex(-0.44519f, 4.23732f, 0.89147f);
            f1976.AddVertex(-0.41183f, 4.23990f, 0.90087f);
            f1976.AddVertex(-0.42003f, 4.25248f, 0.92203f);
            f1976.AddVertex(-0.45339f, 4.24989f, 0.91262f);
            faces.Add(f1976);

            Face f1977 = new Face(m03___Default);
            f1977.AddVertex(-0.47282f, 4.23101f, 0.87956f);
            f1977.AddVertex(-0.44519f, 4.23732f, 0.89147f);
            f1977.AddVertex(-0.45339f, 4.24989f, 0.91262f);
            f1977.AddVertex(-0.48102f, 4.24358f, 0.90073f);
            faces.Add(f1977);

            Face f1978 = new Face(m03___Default);
            f1978.AddVertex(-0.48937f, 4.20585f, 0.84685f);
            f1978.AddVertex(-0.47282f, 4.23101f, 0.87956f);
            f1978.AddVertex(-0.48102f, 4.24358f, 0.90073f);
            f1978.AddVertex(-0.49756f, 4.21842f, 0.86802f);
            faces.Add(f1978);

            Face f1979 = new Face(m03___Default);
            f1979.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            f1979.AddVertex(-0.48937f, 4.20585f, 0.84685f);
            f1979.AddVertex(-0.49756f, 4.21842f, 0.86802f);
            f1979.AddVertex(-0.47312f, 4.15835f, 0.82086f);
            faces.Add(f1979);

            Face f1980 = new Face(m03___Default);
            f1980.AddVertex(-0.39137f, 4.13051f, 0.79753f);
            f1980.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            f1980.AddVertex(-0.47312f, 4.15835f, 0.82086f);
            f1980.AddVertex(-0.39957f, 4.14308f, 0.81869f);
            faces.Add(f1980);

            Face f1981 = new Face(m03___Default);
            f1981.AddVertex(-0.34896f, 4.15912f, 0.81772f);
            f1981.AddVertex(-0.39137f, 4.13051f, 0.79753f);
            f1981.AddVertex(-0.39957f, 4.14308f, 0.81869f);
            f1981.AddVertex(-0.35716f, 4.17169f, 0.83888f);
            faces.Add(f1981);

            Face f1982 = new Face(m03___Default);
            f1982.AddVertex(-0.37042f, 4.20604f, 0.85857f);
            f1982.AddVertex(-0.34896f, 4.15912f, 0.81772f);
            f1982.AddVertex(-0.35716f, 4.17169f, 0.83888f);
            f1982.AddVertex(-0.37862f, 4.21860f, 0.87974f);
            faces.Add(f1982);

            Face f1983 = new Face(m03___Default);
            f1983.AddVertex(-0.36457f, 4.23687f, 0.90719f);
            f1983.AddVertex(-0.37042f, 4.20604f, 0.85857f);
            f1983.AddVertex(-0.37862f, 4.21860f, 0.87974f);
            f1983.AddVertex(-0.37277f, 4.24944f, 0.92835f);
            faces.Add(f1983);

            Face f1984 = new Face(m03___Default);
            f1984.AddVertex(-0.35494f, 4.24803f, 0.93315f);
            f1984.AddVertex(-0.36457f, 4.23687f, 0.90719f);
            f1984.AddVertex(-0.37277f, 4.24944f, 0.92835f);
            f1984.AddVertex(-0.36314f, 4.26060f, 0.95431f);
            faces.Add(f1984);

            Face f1985 = new Face(m03___Default);
            f1985.AddVertex(-0.28956f, 4.20829f, 0.88589f);
            f1985.AddVertex(-0.35494f, 4.24803f, 0.93315f);
            f1985.AddVertex(-0.36314f, 4.26060f, 0.95431f);
            f1985.AddVertex(-0.29776f, 4.22086f, 0.90705f);
            faces.Add(f1985);

            Face f1986 = new Face(m03___Default);
            f1986.AddVertex(-0.23077f, 4.14273f, 0.83968f);
            f1986.AddVertex(-0.28956f, 4.20829f, 0.88589f);
            f1986.AddVertex(-0.29776f, 4.22086f, 0.90705f);
            f1986.AddVertex(-0.23897f, 4.15531f, 0.86084f);
            faces.Add(f1986);

            Face f1987 = new Face(m03___Default);
            f1987.AddVertex(-0.23326f, 4.10014f, 0.82290f);
            f1987.AddVertex(-0.23077f, 4.14273f, 0.83968f);
            f1987.AddVertex(-0.23897f, 4.15531f, 0.86084f);
            f1987.AddVertex(-0.24146f, 4.11271f, 0.84406f);
            faces.Add(f1987);

            Face f1988 = new Face(m03___Default);
            f1988.AddVertex(-0.29342f, 4.08508f, 0.80775f);
            f1988.AddVertex(-0.23326f, 4.10014f, 0.82290f);
            f1988.AddVertex(-0.24146f, 4.11271f, 0.84406f);
            f1988.AddVertex(-0.30161f, 4.09765f, 0.82891f);
            faces.Add(f1988);

            Face f1989 = new Face(m03___Default);
            f1989.AddVertex(-0.40182f, 4.07574f, 0.79554f);
            f1989.AddVertex(-0.29342f, 4.08508f, 0.80775f);
            f1989.AddVertex(-0.30161f, 4.09765f, 0.82891f);
            f1989.AddVertex(-0.41002f, 4.08831f, 0.81670f);
            faces.Add(f1989);

            Face f1990 = new Face(m03___Default);
            f1990.AddVertex(-0.42846f, 4.05095f, 0.80553f);
            f1990.AddVertex(-0.40182f, 4.07574f, 0.79554f);
            f1990.AddVertex(-0.41002f, 4.08831f, 0.81670f);
            f1990.AddVertex(-0.43667f, 4.06352f, 0.82668f);
            faces.Add(f1990);

            Face f1991 = new Face(m03___Default);
            f1991.AddVertex(-0.37465f, 4.02983f, 0.82505f);
            f1991.AddVertex(-0.42846f, 4.05095f, 0.80553f);
            f1991.AddVertex(-0.43667f, 4.06352f, 0.82668f);
            f1991.AddVertex(-0.38286f, 4.04240f, 0.84622f);
            faces.Add(f1991);

            Face f1992 = new Face(m03___Default);
            f1992.AddVertex(-0.33510f, 4.00679f, 0.85349f);
            f1992.AddVertex(-0.37465f, 4.02983f, 0.82505f);
            f1992.AddVertex(-0.38286f, 4.04240f, 0.84622f);
            f1992.AddVertex(-0.34330f, 4.01936f, 0.87465f);
            faces.Add(f1992);

            Face f1993 = new Face(m03___Default);
            f1993.AddVertex(-0.31697f, 3.98245f, 0.89114f);
            f1993.AddVertex(-0.33510f, 4.00679f, 0.85349f);
            f1993.AddVertex(-0.34330f, 4.01936f, 0.87465f);
            f1993.AddVertex(-0.32518f, 3.99501f, 0.91232f);
            faces.Add(f1993);

            Face f1994 = new Face(m03___Default);
            f1994.AddVertex(-0.33535f, 3.96861f, 0.91666f);
            f1994.AddVertex(-0.31697f, 3.98245f, 0.89114f);
            f1994.AddVertex(-0.32518f, 3.99501f, 0.91232f);
            f1994.AddVertex(-0.34355f, 3.98118f, 0.93782f);
            faces.Add(f1994);

            Face f1995 = new Face(m03___Default);
            f1995.AddVertex(-0.36888f, 3.94707f, 0.96888f);
            f1995.AddVertex(-0.33535f, 3.96861f, 0.91666f);
            f1995.AddVertex(-0.34355f, 3.98118f, 0.93782f);
            f1995.AddVertex(-0.37708f, 3.95965f, 0.99005f);
            faces.Add(f1995);

            Face f1996 = new Face(m03___Default);
            f1996.AddVertex(-0.43454f, 3.94032f, 0.98905f);
            f1996.AddVertex(-0.36888f, 3.94707f, 0.96888f);
            f1996.AddVertex(-0.37708f, 3.95965f, 0.99005f);
            f1996.AddVertex(-0.44274f, 3.95289f, 1.01021f);
            faces.Add(f1996);

            Face f1997 = new Face(m03___Default);
            f1997.AddVertex(-0.48724f, 3.92949f, 1.02609f);
            f1997.AddVertex(-0.43454f, 3.94032f, 0.98905f);
            f1997.AddVertex(-0.44274f, 3.95289f, 1.01021f);
            f1997.AddVertex(-0.49544f, 3.94207f, 1.04725f);
            faces.Add(f1997);

            Face f1998 = new Face(m03___Default);
            f1998.AddVertex(-0.53509f, 3.91797f, 1.07262f);
            f1998.AddVertex(-0.48724f, 3.92949f, 1.02609f);
            f1998.AddVertex(-0.49544f, 3.94207f, 1.04725f);
            f1998.AddVertex(-0.54329f, 3.93054f, 1.09378f);
            faces.Add(f1998);

            Face f1999 = new Face(m03___Default);
            f1999.AddVertex(-0.56759f, 3.93054f, 1.02101f);
            f1999.AddVertex(-0.53509f, 3.91797f, 1.07262f);
            f1999.AddVertex(-0.54329f, 3.93054f, 1.09378f);
            f1999.AddVertex(-0.57579f, 3.94311f, 1.04217f);
            faces.Add(f1999);

            Face f2000 = new Face(m03___Default);
            f2000.AddVertex(-0.62014f, 3.93021f, 1.02108f);
            f2000.AddVertex(-0.56759f, 3.93054f, 1.02101f);
            f2000.AddVertex(-0.57579f, 3.94311f, 1.04217f);
            f2000.AddVertex(-0.62834f, 3.94277f, 1.04224f);
            faces.Add(f2000);

            Face f2001 = new Face(m03___Default);
            f2001.AddVertex(-0.67900f, 3.94679f, 0.96509f);
            f2001.AddVertex(-0.62014f, 3.93021f, 1.02108f);
            f2001.AddVertex(-0.62834f, 3.94277f, 1.04224f);
            f2001.AddVertex(-0.68720f, 3.95936f, 0.98624f);
            faces.Add(f2001);

            Face f2002 = new Face(m03___Default);
            f2002.AddVertex(-0.71792f, 3.96048f, 0.92972f);
            f2002.AddVertex(-0.67900f, 3.94679f, 0.96509f);
            f2002.AddVertex(-0.68720f, 3.95936f, 0.98624f);
            f2002.AddVertex(-0.72612f, 3.97306f, 0.95088f);
            faces.Add(f2002);

            Face f2003 = new Face(m03___Default);
            f2003.AddVertex(-0.70431f, 3.98677f, 0.88126f);
            f2003.AddVertex(-0.71792f, 3.96048f, 0.92972f);
            f2003.AddVertex(-0.72612f, 3.97306f, 0.95088f);
            f2003.AddVertex(-0.71251f, 3.99934f, 0.90241f);
            faces.Add(f2003);

            Face f2004 = new Face(m03___Default);
            f2004.AddVertex(-0.67785f, 4.00323f, 0.85760f);
            f2004.AddVertex(-0.70431f, 3.98677f, 0.88126f);
            f2004.AddVertex(-0.71251f, 3.99934f, 0.90241f);
            f2004.AddVertex(-0.68605f, 4.01580f, 0.87876f);
            faces.Add(f2004);

            Face f2005 = new Face(m03___Default);
            f2005.AddVertex(-0.63346f, 4.01916f, 0.83696f);
            f2005.AddVertex(-0.67785f, 4.00323f, 0.85760f);
            f2005.AddVertex(-0.68605f, 4.01580f, 0.87876f);
            f2005.AddVertex(-0.64165f, 4.03173f, 0.85812f);
            faces.Add(f2005);

            Face f2006 = new Face(m03___Default);
            f2006.AddVertex(-0.58827f, 4.05721f, 0.80604f);
            f2006.AddVertex(-0.63346f, 4.01916f, 0.83696f);
            f2006.AddVertex(-0.64165f, 4.03173f, 0.85812f);
            f2006.AddVertex(-0.59646f, 4.06978f, 0.82720f);
            faces.Add(f2006);

            Face f2007 = new Face(m03___Default);
            f2007.AddVertex(-0.63920f, 4.06169f, 0.80998f);
            f2007.AddVertex(-0.58827f, 4.05721f, 0.80604f);
            f2007.AddVertex(-0.59646f, 4.06978f, 0.82720f);
            f2007.AddVertex(-0.64740f, 4.07426f, 0.83114f);
            faces.Add(f2007);

            Face f2008 = new Face(m03___Default);
            f2008.AddVertex(-0.69011f, 4.07078f, 0.81572f);
            f2008.AddVertex(-0.63920f, 4.06169f, 0.80998f);
            f2008.AddVertex(-0.64740f, 4.07426f, 0.83114f);
            f2008.AddVertex(-0.69831f, 4.08335f, 0.83689f);
            faces.Add(f2008);

            Face f2009 = new Face(m03___Default);
            f2009.AddVertex(-0.72330f, 4.08944f, 0.82104f);
            f2009.AddVertex(-0.69011f, 4.07078f, 0.81572f);
            f2009.AddVertex(-0.69831f, 4.08335f, 0.83689f);
            f2009.AddVertex(-0.73150f, 4.10201f, 0.84220f);
            faces.Add(f2009);

            Face f2010 = new Face(m03___Default);
            f2010.AddVertex(-0.71010f, 4.11581f, 0.82119f);
            f2010.AddVertex(-0.72330f, 4.08944f, 0.82104f);
            f2010.AddVertex(-0.73150f, 4.10201f, 0.84220f);
            f2010.AddVertex(-0.71824f, 4.12846f, 0.84235f);
            faces.Add(f2010);

            Face f2011 = new Face(m03___Default);
            f2011.AddVertex(-0.69673f, 4.13635f, 0.82473f);
            f2011.AddVertex(-0.71010f, 4.11581f, 0.82119f);
            f2011.AddVertex(-0.71824f, 4.12846f, 0.84235f);
            f2011.AddVertex(-0.70493f, 4.14892f, 0.84589f);
            faces.Add(f2011);

            Face f2012 = new Face(m03___Default);
            f2012.AddVertex(-0.66845f, 4.16479f, 0.83361f);
            f2012.AddVertex(-0.69673f, 4.13635f, 0.82473f);
            f2012.AddVertex(-0.70493f, 4.14892f, 0.84589f);
            f2012.AddVertex(-0.67665f, 4.17736f, 0.85476f);
            faces.Add(f2012);

            Face f2013 = new Face(m03___Default);
            f2013.AddVertex(-0.66835f, 4.21067f, 0.87566f);
            f2013.AddVertex(-0.66845f, 4.16479f, 0.83361f);
            f2013.AddVertex(-0.67665f, 4.17736f, 0.85476f);
            f2013.AddVertex(-0.67649f, 4.22320f, 0.89676f);
            faces.Add(f2013);

            Face f2014 = new Face(m03___Default);
            f2014.AddVertex(-0.69096f, 4.22666f, 0.90233f);
            f2014.AddVertex(-0.66835f, 4.21067f, 0.87566f);
            f2014.AddVertex(-0.67649f, 4.22320f, 0.89676f);
            f2014.AddVertex(-0.69915f, 4.23923f, 0.92349f);
            faces.Add(f2014);

            Face f2015 = new Face(m03___Default);
            f2015.AddVertex(-0.65819f, 4.21817f, 0.88223f);
            f2015.AddVertex(-0.69096f, 4.22666f, 0.90233f);
            f2015.AddVertex(-0.69915f, 4.23923f, 0.92349f);
            f2015.AddVertex(-0.66632f, 4.23071f, 0.90335f);
            faces.Add(f2015);

            Face f2016 = new Face(m03___Default);
            f2016.AddVertex(-0.62345f, 4.17489f, 0.83152f);
            f2016.AddVertex(-0.65819f, 4.21817f, 0.88223f);
            f2016.AddVertex(-0.66632f, 4.23071f, 0.90335f);
            f2016.AddVertex(-0.63165f, 4.18746f, 0.85269f);
            faces.Add(f2016);

            Face f2017 = new Face(m03___Default);
            f2017.AddVertex(-0.60085f, 4.13415f, 0.80489f);
            f2017.AddVertex(-0.62345f, 4.17489f, 0.83152f);
            f2017.AddVertex(-0.63165f, 4.18746f, 0.85269f);
            f2017.AddVertex(-0.60904f, 4.14672f, 0.82605f);
            faces.Add(f2017);

            Face f2018 = new Face(m03___Default);
            f2018.AddVertex(-0.53104f, 4.13717f, 0.79828f);
            f2018.AddVertex(-0.60085f, 4.13415f, 0.80489f);
            f2018.AddVertex(-0.60904f, 4.14672f, 0.82605f);
            f2018.AddVertex(-0.53924f, 4.14974f, 0.81944f);
            faces.Add(f2018);

            Face f2019 = new Face(m03___Default);
            f2019.AddVertex(-0.52678f, 4.17476f, 0.81925f);
            f2019.AddVertex(-0.53104f, 4.13717f, 0.79828f);
            f2019.AddVertex(-0.53924f, 4.14974f, 0.81944f);
            f2019.AddVertex(-0.53506f, 4.18737f, 0.84044f);
            faces.Add(f2019);

            Face f2020 = new Face(m03___Default);
            f2020.AddVertex(-0.55747f, 4.21029f, 0.85545f);
            f2020.AddVertex(-0.52678f, 4.17476f, 0.81925f);
            f2020.AddVertex(-0.53506f, 4.18737f, 0.84044f);
            f2020.AddVertex(-0.56567f, 4.22286f, 0.87661f);
            faces.Add(f2020);

            Face f2021 = new Face(m03___Default);
            f2021.AddVertex(-0.53104f, 4.13717f, 0.79828f);
            f2021.AddVertex(-0.52678f, 4.17476f, 0.81925f);
            f2021.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            faces.Add(f2021);

            Face f2022 = new Face(m03___Default);
            f2022.AddVertex(-0.67791f, 4.26221f, 0.95757f);
            f2022.AddVertex(-0.67398f, 4.28454f, 1.00621f);
            f2022.AddVertex(-0.64841f, 4.30038f, 1.04190f);
            f2022.AddVertex(-0.60861f, 4.31237f, 1.07324f);
            faces.Add(f2022);

            Face f2023 = new Face(m03___Default);
            f2023.AddVertex(-0.40504f, 4.25063f, 0.92250f);
            f2023.AddVertex(-0.67791f, 4.26221f, 0.95757f);
            f2023.AddVertex(-0.60861f, 4.31237f, 1.07324f);
            f2023.AddVertex(-0.54039f, 4.30953f, 1.05987f);
            faces.Add(f2023);

            Face f2024 = new Face(m03___Default);
            f2024.AddVertex(-0.43093f, 4.26781f, 0.95387f);
            f2024.AddVertex(-0.40504f, 4.25063f, 0.92250f);
            f2024.AddVertex(-0.54039f, 4.30953f, 1.05987f);
            f2024.AddVertex(-0.48433f, 4.29378f, 1.01325f);
            faces.Add(f2024);

            Face f2025 = new Face(m03___Default);
            f2025.AddVertex(-0.67791f, 4.26221f, 0.95757f);
            f2025.AddVertex(-0.40504f, 4.25063f, 0.92250f);
            f2025.AddVertex(-0.41183f, 4.23990f, 0.90087f);
            f2025.AddVertex(-0.44519f, 4.23732f, 0.89147f);
            faces.Add(f2025);

            Face f2026 = new Face(m03___Default);
            f2026.AddVertex(-0.67791f, 4.26221f, 0.95757f);
            f2026.AddVertex(-0.44519f, 4.23732f, 0.89147f);
            f2026.AddVertex(-0.47282f, 4.23101f, 0.87956f);
            f2026.AddVertex(-0.48937f, 4.20585f, 0.84685f);
            faces.Add(f2026);

            Face f2027 = new Face(m03___Default);
            f2027.AddVertex(-0.60890f, 4.24151f, 0.90442f);
            f2027.AddVertex(-0.67791f, 4.26221f, 0.95757f);
            f2027.AddVertex(-0.48937f, 4.20585f, 0.84685f);
            f2027.AddVertex(-0.55747f, 4.21029f, 0.85545f);
            faces.Add(f2027);

            Face f2028 = new Face(m03___Default);
            f2028.AddVertex(-0.55747f, 4.21029f, 0.85545f);
            f2028.AddVertex(-0.48937f, 4.20585f, 0.84685f);
            f2028.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            faces.Add(f2028);

            Face f2029 = new Face(m03___Default);
            f2029.AddVertex(-0.68720f, 3.95936f, 0.98624f);
            f2029.AddVertex(-0.62834f, 3.94277f, 1.04224f);
            f2029.AddVertex(-0.57579f, 3.94311f, 1.04217f);
            f2029.AddVertex(-0.43667f, 4.06352f, 0.82668f);
            faces.Add(f2029);

            Face f2030 = new Face(m03___Default);
            f2030.AddVertex(-0.72612f, 3.97306f, 0.95088f);
            f2030.AddVertex(-0.68720f, 3.95936f, 0.98624f);
            f2030.AddVertex(-0.43667f, 4.06352f, 0.82668f);
            f2030.AddVertex(-0.47312f, 4.15835f, 0.82086f);
            faces.Add(f2030);

            Face f2031 = new Face(m03___Default);
            f2031.AddVertex(-0.47312f, 4.15835f, 0.82086f);
            f2031.AddVertex(-0.43667f, 4.06352f, 0.82668f);
            f2031.AddVertex(-0.41002f, 4.08831f, 0.81670f);
            f2031.AddVertex(-0.39957f, 4.14308f, 0.81869f);
            faces.Add(f2031);

            Face f2032 = new Face(m03___Default);
            f2032.AddVertex(-0.64165f, 4.03173f, 0.85812f);
            f2032.AddVertex(-0.72612f, 3.97306f, 0.95088f);
            f2032.AddVertex(-0.47312f, 4.15835f, 0.82086f);
            f2032.AddVertex(-0.59646f, 4.06978f, 0.82720f);
            faces.Add(f2032);

            Face f2033 = new Face(m03___Default);
            f2033.AddVertex(-0.37042f, 4.20604f, 0.85857f);
            f2033.AddVertex(-0.36457f, 4.23687f, 0.90719f);
            f2033.AddVertex(-0.35494f, 4.24803f, 0.93315f);
            f2033.AddVertex(-0.23077f, 4.14273f, 0.83968f);
            faces.Add(f2033);

            Face f2034 = new Face(m03___Default);
            f2034.AddVertex(-0.35494f, 4.24803f, 0.93315f);
            f2034.AddVertex(-0.28956f, 4.20829f, 0.88589f);
            f2034.AddVertex(-0.23077f, 4.14273f, 0.83968f);
            faces.Add(f2034);

            Face f2035 = new Face(m03___Default);
            f2035.AddVertex(-0.29342f, 4.08508f, 0.80775f);
            f2035.AddVertex(-0.37042f, 4.20604f, 0.85857f);
            f2035.AddVertex(-0.23077f, 4.14273f, 0.83968f);
            f2035.AddVertex(-0.23326f, 4.10014f, 0.82290f);
            faces.Add(f2035);

            Face f2036 = new Face(m03___Default);
            f2036.AddVertex(-0.34896f, 4.15912f, 0.81772f);
            f2036.AddVertex(-0.37042f, 4.20604f, 0.85857f);
            f2036.AddVertex(-0.29342f, 4.08508f, 0.80775f);
            faces.Add(f2036);

            Face f2037 = new Face(m03___Default);
            f2037.AddVertex(-0.39137f, 4.13051f, 0.79753f);
            f2037.AddVertex(-0.34896f, 4.15912f, 0.81772f);
            f2037.AddVertex(-0.29342f, 4.08508f, 0.80775f);
            faces.Add(f2037);

            Face f2038 = new Face(m03___Default);
            f2038.AddVertex(-0.39957f, 4.14308f, 0.81869f);
            f2038.AddVertex(-0.41002f, 4.08831f, 0.81670f);
            f2038.AddVertex(-0.30161f, 4.09765f, 0.82891f);
            f2038.AddVertex(-0.35716f, 4.17169f, 0.83888f);
            faces.Add(f2038);

            Face f2039 = new Face(m03___Default);
            f2039.AddVertex(-0.44274f, 3.95289f, 1.01021f);
            f2039.AddVertex(-0.37708f, 3.95965f, 0.99005f);
            f2039.AddVertex(-0.34355f, 3.98118f, 0.93782f);
            faces.Add(f2039);

            Face f2040 = new Face(m03___Default);
            f2040.AddVertex(-0.49544f, 3.94207f, 1.04725f);
            f2040.AddVertex(-0.44274f, 3.95289f, 1.01021f);
            f2040.AddVertex(-0.34355f, 3.98118f, 0.93782f);
            f2040.AddVertex(-0.38286f, 4.04240f, 0.84622f);
            faces.Add(f2040);

            Face f2041 = new Face(m03___Default);
            f2041.AddVertex(-0.38286f, 4.04240f, 0.84622f);
            f2041.AddVertex(-0.34355f, 3.98118f, 0.93782f);
            f2041.AddVertex(-0.32518f, 3.99501f, 0.91232f);
            f2041.AddVertex(-0.34330f, 4.01936f, 0.87465f);
            faces.Add(f2041);

            Face f2042 = new Face(m03___Default);
            f2042.AddVertex(-0.57579f, 3.94311f, 1.04217f);
            f2042.AddVertex(-0.49544f, 3.94207f, 1.04725f);
            f2042.AddVertex(-0.38286f, 4.04240f, 0.84622f);
            f2042.AddVertex(-0.43667f, 4.06352f, 0.82668f);
            faces.Add(f2042);

            Face f2043 = new Face(m03___Default);
            f2043.AddVertex(-0.60085f, 4.13415f, 0.80489f);
            f2043.AddVertex(-0.53104f, 4.13717f, 0.79828f);
            f2043.AddVertex(-0.58827f, 4.05721f, 0.80604f);
            faces.Add(f2043);

            Face f2044 = new Face(m03___Default);
            f2044.AddVertex(-0.53104f, 4.13717f, 0.79828f);
            f2044.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            f2044.AddVertex(-0.58827f, 4.05721f, 0.80604f);
            faces.Add(f2044);

            Face f2045 = new Face(m03___Default);
            f2045.AddVertex(-0.53924f, 4.14974f, 0.81944f);
            f2045.AddVertex(-0.60904f, 4.14672f, 0.82605f);
            f2045.AddVertex(-0.59646f, 4.06978f, 0.82720f);
            faces.Add(f2045);

            Face f2046 = new Face(m03___Default);
            f2046.AddVertex(-0.52678f, 4.17476f, 0.81925f);
            f2046.AddVertex(-0.55747f, 4.21029f, 0.85545f);
            f2046.AddVertex(-0.46492f, 4.14578f, 0.79970f);
            faces.Add(f2046);

            Face f2047 = new Face(m03___Default);
            f2047.AddVertex(-1.43621f, 7.14486f, 0.07991f);
            f2047.AddVertex(-1.40912f, 7.15393f, 0.07972f);
            f2047.AddVertex(-1.41698f, 7.14541f, 0.05605f);
            faces.Add(f2047);

            Face f2048 = new Face(m03___Default);
            f2048.AddVertex(-1.40912f, 7.15393f, 0.07972f);
            f2048.AddVertex(-1.37899f, 7.15400f, 0.07996f);
            f2048.AddVertex(-1.38744f, 7.15147f, 0.05574f);
            faces.Add(f2048);

            Face f2049 = new Face(m03___Default);
            f2049.AddVertex(-1.40912f, 7.15393f, 0.07972f);
            f2049.AddVertex(-1.38744f, 7.15147f, 0.05574f);
            f2049.AddVertex(-1.41698f, 7.14541f, 0.05605f);
            faces.Add(f2049);

            Face f2050 = new Face(m03___Default);
            f2050.AddVertex(-1.41698f, 7.14541f, 0.05605f);
            f2050.AddVertex(-1.38744f, 7.15147f, 0.05574f);
            f2050.AddVertex(-1.39409f, 7.13761f, 0.03442f);
            faces.Add(f2050);

            Face f2051 = new Face(m03___Default);
            f2051.AddVertex(-1.37899f, 7.15400f, 0.07996f);
            f2051.AddVertex(-1.34810f, 7.14508f, 0.08060f);
            f2051.AddVertex(-1.35405f, 7.14706f, 0.05603f);
            faces.Add(f2051);

            Face f2052 = new Face(m03___Default);
            f2052.AddVertex(-1.37899f, 7.15400f, 0.07996f);
            f2052.AddVertex(-1.35405f, 7.14706f, 0.05603f);
            f2052.AddVertex(-1.38744f, 7.15147f, 0.05574f);
            faces.Add(f2052);

            Face f2053 = new Face(m03___Default);
            f2053.AddVertex(-1.38744f, 7.15147f, 0.05574f);
            f2053.AddVertex(-1.35405f, 7.14706f, 0.05603f);
            f2053.AddVertex(-1.36133f, 7.13916f, 0.03407f);
            faces.Add(f2053);

            Face f2054 = new Face(m03___Default);
            f2054.AddVertex(-1.38744f, 7.15147f, 0.05574f);
            f2054.AddVertex(-1.36133f, 7.13916f, 0.03407f);
            f2054.AddVertex(-1.39409f, 7.13761f, 0.03442f);
            faces.Add(f2054);

            Face f2055 = new Face(m03___Default);
            f2055.AddVertex(-1.39409f, 7.13761f, 0.03442f);
            f2055.AddVertex(-1.36133f, 7.13916f, 0.03407f);
            f2055.AddVertex(-1.36931f, 7.12206f, 0.01667f);
            faces.Add(f2055);

            Face f2056 = new Face(m03___Default);
            f2056.AddVertex(-1.34810f, 7.14508f, 0.08060f);
            f2056.AddVertex(-1.31881f, 7.12783f, 0.08162f);
            f2056.AddVertex(-1.32008f, 7.13136f, 0.05746f);
            faces.Add(f2056);

            Face f2057 = new Face(m03___Default);
            f2057.AddVertex(-1.34810f, 7.14508f, 0.08060f);
            f2057.AddVertex(-1.32008f, 7.13136f, 0.05746f);
            f2057.AddVertex(-1.35405f, 7.14706f, 0.05603f);
            faces.Add(f2057);

            Face f2058 = new Face(m03___Default);
            f2058.AddVertex(-1.35405f, 7.14706f, 0.05603f);
            f2058.AddVertex(-1.32008f, 7.13136f, 0.05746f);
            f2058.AddVertex(-1.32508f, 7.12761f, 0.03542f);
            faces.Add(f2058);

            Face f2059 = new Face(m03___Default);
            f2059.AddVertex(-1.35405f, 7.14706f, 0.05603f);
            f2059.AddVertex(-1.32508f, 7.12761f, 0.03542f);
            f2059.AddVertex(-1.36133f, 7.13916f, 0.03407f);
            faces.Add(f2059);

            Face f2060 = new Face(m03___Default);
            f2060.AddVertex(-1.36133f, 7.13916f, 0.03407f);
            f2060.AddVertex(-1.32508f, 7.12761f, 0.03542f);
            f2060.AddVertex(-1.33344f, 7.11686f, 0.01719f);
            faces.Add(f2060);

            Face f2061 = new Face(m03___Default);
            f2061.AddVertex(-1.36133f, 7.13916f, 0.03407f);
            f2061.AddVertex(-1.33344f, 7.11686f, 0.01719f);
            f2061.AddVertex(-1.36931f, 7.12206f, 0.01667f);
            faces.Add(f2061);

            Face f2062 = new Face(m03___Default);
            f2062.AddVertex(-1.36931f, 7.12206f, 0.01667f);
            f2062.AddVertex(-1.33344f, 7.11686f, 0.01719f);
            f2062.AddVertex(-1.34450f, 7.09994f, 0.00414f);
            faces.Add(f2062);

            Face f2063 = new Face(m03___Default);
            f2063.AddVertex(-1.43621f, 7.14486f, 0.07991f);
            f2063.AddVertex(-1.41698f, 7.14541f, 0.05605f);
            f2063.AddVertex(-1.44788f, 7.13038f, 0.06564f);
            faces.Add(f2063);

            Face f2064 = new Face(m03___Default);
            f2064.AddVertex(-1.41698f, 7.14541f, 0.05605f);
            f2064.AddVertex(-1.39409f, 7.13761f, 0.03442f);
            f2064.AddVertex(-1.42664f, 7.12766f, 0.04150f);
            faces.Add(f2064);

            Face f2065 = new Face(m03___Default);
            f2065.AddVertex(-1.41698f, 7.14541f, 0.05605f);
            f2065.AddVertex(-1.42664f, 7.12766f, 0.04150f);
            f2065.AddVertex(-1.44788f, 7.13038f, 0.06564f);
            faces.Add(f2065);

            Face f2066 = new Face(m03___Default);
            f2066.AddVertex(-1.44788f, 7.13038f, 0.06564f);
            f2066.AddVertex(-1.42664f, 7.12766f, 0.04150f);
            f2066.AddVertex(-1.45354f, 7.10871f, 0.05288f);
            faces.Add(f2066);

            Face f2067 = new Face(m03___Default);
            f2067.AddVertex(-1.39409f, 7.13761f, 0.03442f);
            f2067.AddVertex(-1.36931f, 7.12206f, 0.01667f);
            f2067.AddVertex(-1.40080f, 7.11518f, 0.01974f);
            faces.Add(f2067);

            Face f2068 = new Face(m03___Default);
            f2068.AddVertex(-1.39409f, 7.13761f, 0.03442f);
            f2068.AddVertex(-1.40080f, 7.11518f, 0.01974f);
            f2068.AddVertex(-1.42664f, 7.12766f, 0.04150f);
            faces.Add(f2068);

            Face f2069 = new Face(m03___Default);
            f2069.AddVertex(-1.42664f, 7.12766f, 0.04150f);
            f2069.AddVertex(-1.40080f, 7.11518f, 0.01974f);
            f2069.AddVertex(-1.42947f, 7.10124f, 0.02865f);
            faces.Add(f2069);

            Face f2070 = new Face(m03___Default);
            f2070.AddVertex(-1.42664f, 7.12766f, 0.04150f);
            f2070.AddVertex(-1.42947f, 7.10124f, 0.02865f);
            f2070.AddVertex(-1.45354f, 7.10871f, 0.05288f);
            faces.Add(f2070);

            Face f2071 = new Face(m03___Default);
            f2071.AddVertex(-1.45354f, 7.10871f, 0.05288f);
            f2071.AddVertex(-1.42947f, 7.10124f, 0.02865f);
            f2071.AddVertex(-1.45278f, 7.08148f, 0.04259f);
            faces.Add(f2071);

            Face f2072 = new Face(m03___Default);
            f2072.AddVertex(-1.36931f, 7.12206f, 0.01667f);
            f2072.AddVertex(-1.34450f, 7.09994f, 0.00414f);
            f2072.AddVertex(-1.37219f, 7.09332f, 0.00312f);
            faces.Add(f2072);

            Face f2073 = new Face(m03___Default);
            f2073.AddVertex(-1.36931f, 7.12206f, 0.01667f);
            f2073.AddVertex(-1.37219f, 7.09332f, 0.00312f);
            f2073.AddVertex(-1.40080f, 7.11518f, 0.01974f);
            faces.Add(f2073);

            Face f2074 = new Face(m03___Default);
            f2074.AddVertex(-1.40080f, 7.11518f, 0.01974f);
            f2074.AddVertex(-1.37219f, 7.09332f, 0.00312f);
            f2074.AddVertex(-1.39964f, 7.08231f, 0.00835f);
            faces.Add(f2074);

            Face f2075 = new Face(m03___Default);
            f2075.AddVertex(-1.40080f, 7.11518f, 0.01974f);
            f2075.AddVertex(-1.39964f, 7.08231f, 0.00835f);
            f2075.AddVertex(-1.42947f, 7.10124f, 0.02865f);
            faces.Add(f2075);

            Face f2076 = new Face(m03___Default);
            f2076.AddVertex(-1.42947f, 7.10124f, 0.02865f);
            f2076.AddVertex(-1.39964f, 7.08231f, 0.00835f);
            f2076.AddVertex(-1.42476f, 7.06776f, 0.01944f);
            faces.Add(f2076);

            Face f2077 = new Face(m03___Default);
            f2077.AddVertex(-1.42947f, 7.10124f, 0.02865f);
            f2077.AddVertex(-1.42476f, 7.06776f, 0.01944f);
            f2077.AddVertex(-1.45278f, 7.08148f, 0.04259f);
            faces.Add(f2077);

            Face f2078 = new Face(m03___Default);
            f2078.AddVertex(-1.45278f, 7.08148f, 0.04259f);
            f2078.AddVertex(-1.42476f, 7.06776f, 0.01944f);
            f2078.AddVertex(-1.44564f, 7.05077f, 0.03556f);
            faces.Add(f2078);

            Face f2079 = new Face(m03___Default);
            f2079.AddVertex(-1.43621f, 7.14486f, 0.07991f);
            f2079.AddVertex(-1.44788f, 7.13038f, 0.06564f);
            f2079.AddVertex(-1.45912f, 7.12962f, 0.09525f);
            faces.Add(f2079);

            Face f2080 = new Face(m03___Default);
            f2080.AddVertex(-1.44788f, 7.13038f, 0.06564f);
            f2080.AddVertex(-1.45354f, 7.10871f, 0.05288f);
            f2080.AddVertex(-1.46927f, 7.11170f, 0.08115f);
            faces.Add(f2080);

            Face f2081 = new Face(m03___Default);
            f2081.AddVertex(-1.44788f, 7.13038f, 0.06564f);
            f2081.AddVertex(-1.46927f, 7.11170f, 0.08115f);
            f2081.AddVertex(-1.45912f, 7.12962f, 0.09525f);
            faces.Add(f2081);

            Face f2082 = new Face(m03___Default);
            f2082.AddVertex(-1.45912f, 7.12962f, 0.09525f);
            f2082.AddVertex(-1.46927f, 7.11170f, 0.08115f);
            f2082.AddVertex(-1.47518f, 7.10725f, 0.10984f);
            faces.Add(f2082);

            Face f2083 = new Face(m03___Default);
            f2083.AddVertex(-1.45354f, 7.10871f, 0.05288f);
            f2083.AddVertex(-1.45278f, 7.08148f, 0.04259f);
            f2083.AddVertex(-1.47240f, 7.08517f, 0.06857f);
            faces.Add(f2083);

            Face f2084 = new Face(m03___Default);
            f2084.AddVertex(-1.45354f, 7.10871f, 0.05288f);
            f2084.AddVertex(-1.47240f, 7.08517f, 0.06857f);
            f2084.AddVertex(-1.46927f, 7.11170f, 0.08115f);
            faces.Add(f2084);

            Face f2085 = new Face(m03___Default);
            f2085.AddVertex(-1.46927f, 7.11170f, 0.08115f);
            f2085.AddVertex(-1.47240f, 7.08517f, 0.06857f);
            f2085.AddVertex(-1.48283f, 7.08446f, 0.09604f);
            faces.Add(f2085);

            Face f2086 = new Face(m03___Default);
            f2086.AddVertex(-1.46927f, 7.11170f, 0.08115f);
            f2086.AddVertex(-1.48283f, 7.08446f, 0.09604f);
            f2086.AddVertex(-1.47518f, 7.10725f, 0.10984f);
            faces.Add(f2086);

            Face f2087 = new Face(m03___Default);
            f2087.AddVertex(-1.47518f, 7.10725f, 0.10984f);
            f2087.AddVertex(-1.48283f, 7.08446f, 0.09604f);
            f2087.AddVertex(-1.48316f, 7.07943f, 0.12256f);
            faces.Add(f2087);

            Face f2088 = new Face(m03___Default);
            f2088.AddVertex(-1.45278f, 7.08148f, 0.04259f);
            f2088.AddVertex(-1.44564f, 7.05077f, 0.03556f);
            f2088.AddVertex(-1.46691f, 7.05198f, 0.05865f);
            faces.Add(f2088);

            Face f2089 = new Face(m03___Default);
            f2089.AddVertex(-1.45278f, 7.08148f, 0.04259f);
            f2089.AddVertex(-1.46691f, 7.05198f, 0.05865f);
            f2089.AddVertex(-1.47240f, 7.08517f, 0.06857f);
            faces.Add(f2089);

            Face f2090 = new Face(m03___Default);
            f2090.AddVertex(-1.47240f, 7.08517f, 0.06857f);
            f2090.AddVertex(-1.46691f, 7.05198f, 0.05865f);
            f2090.AddVertex(-1.48072f, 7.05195f, 0.08377f);
            faces.Add(f2090);

            Face f2091 = new Face(m03___Default);
            f2091.AddVertex(-1.47240f, 7.08517f, 0.06857f);
            f2091.AddVertex(-1.48072f, 7.05195f, 0.08377f);
            f2091.AddVertex(-1.48283f, 7.08446f, 0.09604f);
            faces.Add(f2091);

            Face f2092 = new Face(m03___Default);
            f2092.AddVertex(-1.48283f, 7.08446f, 0.09604f);
            f2092.AddVertex(-1.48072f, 7.05195f, 0.08377f);
            f2092.AddVertex(-1.48604f, 7.05068f, 0.10901f);
            faces.Add(f2092);

            Face f2093 = new Face(m03___Default);
            f2093.AddVertex(-1.48283f, 7.08446f, 0.09604f);
            f2093.AddVertex(-1.48604f, 7.05068f, 0.10901f);
            f2093.AddVertex(-1.48316f, 7.07943f, 0.12256f);
            faces.Add(f2093);

            Face f2094 = new Face(m03___Default);
            f2094.AddVertex(-1.48316f, 7.07943f, 0.12256f);
            f2094.AddVertex(-1.48604f, 7.05068f, 0.10901f);
            f2094.AddVertex(-1.48245f, 7.04828f, 0.13246f);
            faces.Add(f2094);

            Face f2095 = new Face(m03___Default);
            f2095.AddVertex(-1.43621f, 7.14486f, 0.07991f);
            f2095.AddVertex(-1.45912f, 7.12962f, 0.09525f);
            f2095.AddVertex(-1.43517f, 7.14417f, 0.10395f);
            faces.Add(f2095);

            Face f2096 = new Face(m03___Default);
            f2096.AddVertex(-1.45912f, 7.12962f, 0.09525f);
            f2096.AddVertex(-1.47518f, 7.10725f, 0.10984f);
            f2096.AddVertex(-1.45641f, 7.12564f, 0.11989f);
            faces.Add(f2096);

            Face f2097 = new Face(m03___Default);
            f2097.AddVertex(-1.45912f, 7.12962f, 0.09525f);
            f2097.AddVertex(-1.45641f, 7.12564f, 0.11989f);
            f2097.AddVertex(-1.43517f, 7.14417f, 0.10395f);
            faces.Add(f2097);

            Face f2098 = new Face(m03___Default);
            f2098.AddVertex(-1.43517f, 7.14417f, 0.10395f);
            f2098.AddVertex(-1.45641f, 7.12564f, 0.11989f);
            f2098.AddVertex(-1.42910f, 7.13524f, 0.12657f);
            faces.Add(f2098);

            Face f2099 = new Face(m03___Default);
            f2099.AddVertex(-1.47518f, 7.10725f, 0.10984f);
            f2099.AddVertex(-1.48316f, 7.07943f, 0.12256f);
            f2099.AddVertex(-1.46989f, 7.09851f, 0.13504f);
            faces.Add(f2099);

            Face f2100 = new Face(m03___Default);
            f2100.AddVertex(-1.47518f, 7.10725f, 0.10984f);
            f2100.AddVertex(-1.46989f, 7.09851f, 0.13504f);
            f2100.AddVertex(-1.45641f, 7.12564f, 0.11989f);
            faces.Add(f2100);

            Face f2101 = new Face(m03___Default);
            f2101.AddVertex(-1.45641f, 7.12564f, 0.11989f);
            f2101.AddVertex(-1.46989f, 7.09851f, 0.13504f);
            f2101.AddVertex(-1.44767f, 7.11200f, 0.14311f);
            faces.Add(f2101);

            Face f2102 = new Face(m03___Default);
            f2102.AddVertex(-1.45641f, 7.12564f, 0.11989f);
            f2102.AddVertex(-1.44767f, 7.11200f, 0.14311f);
            f2102.AddVertex(-1.42910f, 7.13524f, 0.12657f);
            faces.Add(f2102);

            Face f2103 = new Face(m03___Default);
            f2103.AddVertex(-1.42910f, 7.13524f, 0.12657f);
            f2103.AddVertex(-1.44767f, 7.11200f, 0.14311f);
            f2103.AddVertex(-1.41846f, 7.11873f, 0.14605f);
            faces.Add(f2103);

            Face f2104 = new Face(m03___Default);
            f2104.AddVertex(-1.48316f, 7.07943f, 0.12256f);
            f2104.AddVertex(-1.48245f, 7.04828f, 0.13246f);
            f2104.AddVertex(-1.47333f, 7.06447f, 0.14731f);
            faces.Add(f2104);

            Face f2105 = new Face(m03___Default);
            f2105.AddVertex(-1.48316f, 7.07943f, 0.12256f);
            f2105.AddVertex(-1.47333f, 7.06447f, 0.14731f);
            f2105.AddVertex(-1.46989f, 7.09851f, 0.13504f);
            faces.Add(f2105);

            Face f2106 = new Face(m03___Default);
            f2106.AddVertex(-1.46989f, 7.09851f, 0.13504f);
            f2106.AddVertex(-1.47333f, 7.06447f, 0.14731f);
            f2106.AddVertex(-1.45628f, 7.07848f, 0.15745f);
            faces.Add(f2106);

            Face f2107 = new Face(m03___Default);
            f2107.AddVertex(-1.46989f, 7.09851f, 0.13504f);
            f2107.AddVertex(-1.45628f, 7.07848f, 0.15745f);
            f2107.AddVertex(-1.44767f, 7.11200f, 0.14311f);
            faces.Add(f2107);

            Face f2108 = new Face(m03___Default);
            f2108.AddVertex(-1.44767f, 7.11200f, 0.14311f);
            f2108.AddVertex(-1.45628f, 7.07848f, 0.15745f);
            f2108.AddVertex(-1.43259f, 7.08923f, 0.16210f);
            faces.Add(f2108);

            Face f2109 = new Face(m03___Default);
            f2109.AddVertex(-1.44767f, 7.11200f, 0.14311f);
            f2109.AddVertex(-1.43259f, 7.08923f, 0.16210f);
            f2109.AddVertex(-1.41846f, 7.11873f, 0.14605f);
            faces.Add(f2109);

            Face f2110 = new Face(m03___Default);
            f2110.AddVertex(-1.41846f, 7.11873f, 0.14605f);
            f2110.AddVertex(-1.43259f, 7.08923f, 0.16210f);
            f2110.AddVertex(-1.40406f, 7.09591f, 0.16092f);
            faces.Add(f2110);

            Face f2111 = new Face(m03___Default);
            f2111.AddVertex(-1.43621f, 7.14486f, 0.07991f);
            f2111.AddVertex(-1.43517f, 7.14417f, 0.10395f);
            f2111.AddVertex(-1.40912f, 7.15393f, 0.07972f);
            faces.Add(f2111);

            Face f2112 = new Face(m03___Default);
            f2112.AddVertex(-1.43517f, 7.14417f, 0.10395f);
            f2112.AddVertex(-1.42910f, 7.13524f, 0.12657f);
            f2112.AddVertex(-1.40585f, 7.15023f, 0.10418f);
            faces.Add(f2112);

            Face f2113 = new Face(m03___Default);
            f2113.AddVertex(-1.43517f, 7.14417f, 0.10395f);
            f2113.AddVertex(-1.40585f, 7.15023f, 0.10418f);
            f2113.AddVertex(-1.40912f, 7.15393f, 0.07972f);
            faces.Add(f2113);

            Face f2114 = new Face(m03___Default);
            f2114.AddVertex(-1.40912f, 7.15393f, 0.07972f);
            f2114.AddVertex(-1.40585f, 7.15023f, 0.10418f);
            f2114.AddVertex(-1.37899f, 7.15400f, 0.07996f);
            faces.Add(f2114);

            Face f2115 = new Face(m03___Default);
            f2115.AddVertex(-1.42910f, 7.13524f, 0.12657f);
            f2115.AddVertex(-1.41846f, 7.11873f, 0.14605f);
            f2115.AddVertex(-1.39675f, 7.13676f, 0.12730f);
            faces.Add(f2115);

            Face f2116 = new Face(m03___Default);
            f2116.AddVertex(-1.42910f, 7.13524f, 0.12657f);
            f2116.AddVertex(-1.39675f, 7.13676f, 0.12730f);
            f2116.AddVertex(-1.40585f, 7.15023f, 0.10418f);
            faces.Add(f2116);

            Face f2117 = new Face(m03___Default);
            f2117.AddVertex(-1.40585f, 7.15023f, 0.10418f);
            f2117.AddVertex(-1.39675f, 7.13676f, 0.12730f);
            f2117.AddVertex(-1.37258f, 7.14581f, 0.10481f);
            faces.Add(f2117);

            Face f2118 = new Face(m03___Default);
            f2118.AddVertex(-1.40585f, 7.15023f, 0.10418f);
            f2118.AddVertex(-1.37258f, 7.14581f, 0.10481f);
            f2118.AddVertex(-1.37899f, 7.15400f, 0.07996f);
            faces.Add(f2118);

            Face f2119 = new Face(m03___Default);
            f2119.AddVertex(-1.37899f, 7.15400f, 0.07996f);
            f2119.AddVertex(-1.37258f, 7.14581f, 0.10481f);
            f2119.AddVertex(-1.34810f, 7.14508f, 0.08060f);
            faces.Add(f2119);

            Face f2120 = new Face(m03___Default);
            f2120.AddVertex(-1.41846f, 7.11873f, 0.14605f);
            f2120.AddVertex(-1.40406f, 7.09591f, 0.16092f);
            f2120.AddVertex(-1.38259f, 7.11353f, 0.14658f);
            faces.Add(f2120);

            Face f2121 = new Face(m03___Default);
            f2121.AddVertex(-1.41846f, 7.11873f, 0.14605f);
            f2121.AddVertex(-1.38259f, 7.11353f, 0.14658f);
            f2121.AddVertex(-1.39675f, 7.13676f, 0.12730f);
            faces.Add(f2121);

            Face f2122 = new Face(m03___Default);
            f2122.AddVertex(-1.39675f, 7.13676f, 0.12730f);
            f2122.AddVertex(-1.38259f, 7.11353f, 0.14658f);
            f2122.AddVertex(-1.36009f, 7.12523f, 0.12757f);
            faces.Add(f2122);

            Face f2123 = new Face(m03___Default);
            f2123.AddVertex(-1.39675f, 7.13676f, 0.12730f);
            f2123.AddVertex(-1.36009f, 7.12523f, 0.12757f);
            f2123.AddVertex(-1.37258f, 7.14581f, 0.10481f);
            faces.Add(f2123);

            Face f2124 = new Face(m03___Default);
            f2124.AddVertex(-1.37258f, 7.14581f, 0.10481f);
            f2124.AddVertex(-1.36009f, 7.12523f, 0.12757f);
            f2124.AddVertex(-1.33827f, 7.13013f, 0.10535f);
            faces.Add(f2124);

            Face f2125 = new Face(m03___Default);
            f2125.AddVertex(-1.37258f, 7.14581f, 0.10481f);
            f2125.AddVertex(-1.33827f, 7.13013f, 0.10535f);
            f2125.AddVertex(-1.34810f, 7.14508f, 0.08060f);
            faces.Add(f2125);

            Face f2126 = new Face(m03___Default);
            f2126.AddVertex(-1.34810f, 7.14508f, 0.08060f);
            f2126.AddVertex(-1.33827f, 7.13013f, 0.10535f);
            f2126.AddVertex(-1.31881f, 7.12783f, 0.08162f);
            faces.Add(f2126);

            Face f2127 = new Face(m03___Default);
            f2127.AddVertex(-1.31881f, 7.12783f, 0.08162f);
            f2127.AddVertex(-1.30419f, 7.10716f, 0.09750f);
            f2127.AddVertex(-1.29294f, 7.10792f, 0.06790f);
            faces.Add(f2127);

            Face f2128 = new Face(m03___Default);
            f2128.AddVertex(-1.30419f, 7.10716f, 0.09750f);
            f2128.AddVertex(-1.29450f, 7.08105f, 0.11246f);
            f2128.AddVertex(-1.27929f, 7.08415f, 0.08391f);
            faces.Add(f2128);

            Face f2129 = new Face(m03___Default);
            f2129.AddVertex(-1.30419f, 7.10716f, 0.09750f);
            f2129.AddVertex(-1.27929f, 7.08415f, 0.08391f);
            f2129.AddVertex(-1.29294f, 7.10792f, 0.06790f);
            faces.Add(f2129);

            Face f2130 = new Face(m03___Default);
            f2130.AddVertex(-1.29294f, 7.10792f, 0.06790f);
            f2130.AddVertex(-1.27929f, 7.08415f, 0.08391f);
            f2130.AddVertex(-1.27287f, 7.08251f, 0.05551f);
            faces.Add(f2130);

            Face f2131 = new Face(m03___Default);
            f2131.AddVertex(-1.29450f, 7.08105f, 0.11246f);
            f2131.AddVertex(-1.29050f, 7.05149f, 0.12536f);
            f2131.AddVertex(-1.27139f, 7.05380f, 0.09911f);
            faces.Add(f2131);

            Face f2132 = new Face(m03___Default);
            f2132.AddVertex(-1.29450f, 7.08105f, 0.11246f);
            f2132.AddVertex(-1.27139f, 7.05380f, 0.09911f);
            f2132.AddVertex(-1.27929f, 7.08415f, 0.08391f);
            faces.Add(f2132);

            Face f2133 = new Face(m03___Default);
            f2133.AddVertex(-1.27929f, 7.08415f, 0.08391f);
            f2133.AddVertex(-1.27139f, 7.05380f, 0.09911f);
            f2133.AddVertex(-1.26095f, 7.05451f, 0.07164f);
            faces.Add(f2133);

            Face f2134 = new Face(m03___Default);
            f2134.AddVertex(-1.27929f, 7.08415f, 0.08391f);
            f2134.AddVertex(-1.26095f, 7.05451f, 0.07164f);
            f2134.AddVertex(-1.27287f, 7.08251f, 0.05551f);
            faces.Add(f2134);

            Face f2135 = new Face(m03___Default);
            f2135.AddVertex(-1.27287f, 7.08251f, 0.05551f);
            f2135.AddVertex(-1.26095f, 7.05451f, 0.07164f);
            f2135.AddVertex(-1.26013f, 7.05355f, 0.04539f);
            faces.Add(f2135);

            Face f2136 = new Face(m03___Default);
            f2136.AddVertex(-1.29050f, 7.05149f, 0.12536f);
            f2136.AddVertex(-1.29248f, 7.02074f, 0.13521f);
            f2136.AddVertex(-1.27121f, 7.01954f, 0.11213f);
            faces.Add(f2136);

            Face f2137 = new Face(m03___Default);
            f2137.AddVertex(-1.29050f, 7.05149f, 0.12536f);
            f2137.AddVertex(-1.27121f, 7.01954f, 0.11213f);
            f2137.AddVertex(-1.27139f, 7.05380f, 0.09911f);
            faces.Add(f2137);

            Face f2138 = new Face(m03___Default);
            f2138.AddVertex(-1.27139f, 7.05380f, 0.09911f);
            f2138.AddVertex(-1.27121f, 7.01954f, 0.11213f);
            f2138.AddVertex(-1.25740f, 7.01956f, 0.08701f);
            faces.Add(f2138);

            Face f2139 = new Face(m03___Default);
            f2139.AddVertex(-1.27139f, 7.05380f, 0.09911f);
            f2139.AddVertex(-1.25740f, 7.01956f, 0.08701f);
            f2139.AddVertex(-1.26095f, 7.05451f, 0.07164f);
            faces.Add(f2139);

            Face f2140 = new Face(m03___Default);
            f2140.AddVertex(-1.26095f, 7.05451f, 0.07164f);
            f2140.AddVertex(-1.25740f, 7.01956f, 0.08701f);
            f2140.AddVertex(-1.25208f, 7.02083f, 0.06177f);
            faces.Add(f2140);

            Face f2141 = new Face(m03___Default);
            f2141.AddVertex(-1.26095f, 7.05451f, 0.07164f);
            f2141.AddVertex(-1.25208f, 7.02083f, 0.06177f);
            f2141.AddVertex(-1.26013f, 7.05355f, 0.04539f);
            faces.Add(f2141);

            Face f2142 = new Face(m03___Default);
            f2142.AddVertex(-1.26013f, 7.05355f, 0.04539f);
            f2142.AddVertex(-1.25208f, 7.02083f, 0.06177f);
            f2142.AddVertex(-1.25567f, 7.02323f, 0.03832f);
            faces.Add(f2142);

            Face f2143 = new Face(m03___Default);
            f2143.AddVertex(-1.34450f, 7.09994f, 0.00414f);
            f2143.AddVertex(-1.31415f, 7.08490f, 0.00395f);
            f2143.AddVertex(-1.33810f, 7.07035f, -0.00473f);
            faces.Add(f2143);

            Face f2144 = new Face(m03___Default);
            f2144.AddVertex(-1.31415f, 7.08490f, 0.00395f);
            f2144.AddVertex(-1.28798f, 7.06612f, 0.00997f);
            f2144.AddVertex(-1.30803f, 7.05297f, -0.00270f);
            faces.Add(f2144);

            Face f2145 = new Face(m03___Default);
            f2145.AddVertex(-1.31415f, 7.08490f, 0.00395f);
            f2145.AddVertex(-1.30803f, 7.05297f, -0.00270f);
            f2145.AddVertex(-1.33810f, 7.07035f, -0.00473f);
            faces.Add(f2145);

            Face f2146 = new Face(m03___Default);
            f2146.AddVertex(-1.33810f, 7.07035f, -0.00473f);
            f2146.AddVertex(-1.30803f, 7.05297f, -0.00270f);
            f2146.AddVertex(-1.33405f, 7.03813f, -0.00675f);
            faces.Add(f2146);

            Face f2147 = new Face(m03___Default);
            f2147.AddVertex(-1.28798f, 7.06612f, 0.00997f);
            f2147.AddVertex(-1.26797f, 7.04503f, 0.02172f);
            f2147.AddVertex(-1.28251f, 7.03112f, 0.00666f);
            faces.Add(f2147);

            Face f2148 = new Face(m03___Default);
            f2148.AddVertex(-1.28798f, 7.06612f, 0.00997f);
            f2148.AddVertex(-1.28251f, 7.03112f, 0.00666f);
            f2148.AddVertex(-1.30803f, 7.05297f, -0.00270f);
            faces.Add(f2148);

            Face f2149 = new Face(m03___Default);
            f2149.AddVertex(-1.30803f, 7.05297f, -0.00270f);
            f2149.AddVertex(-1.28251f, 7.03112f, 0.00666f);
            f2149.AddVertex(-1.30473f, 7.01761f, -0.00140f);
            faces.Add(f2149);

            Face f2150 = new Face(m03___Default);
            f2150.AddVertex(-1.30803f, 7.05297f, -0.00270f);
            f2150.AddVertex(-1.30473f, 7.01761f, -0.00140f);
            f2150.AddVertex(-1.33405f, 7.03813f, -0.00675f);
            faces.Add(f2150);

            Face f2151 = new Face(m03___Default);
            f2151.AddVertex(-1.33405f, 7.03813f, -0.00675f);
            f2151.AddVertex(-1.30473f, 7.01761f, -0.00140f);
            f2151.AddVertex(-1.33268f, 7.00573f, -0.00176f);
            faces.Add(f2151);

            Face f2152 = new Face(m03___Default);
            f2152.AddVertex(-1.26797f, 7.04503f, 0.02172f);
            f2152.AddVertex(-1.25567f, 7.02323f, 0.03832f);
            f2152.AddVertex(-1.26479f, 7.00704f, 0.02347f);
            faces.Add(f2152);

            Face f2153 = new Face(m03___Default);
            f2153.AddVertex(-1.26797f, 7.04503f, 0.02172f);
            f2153.AddVertex(-1.26479f, 7.00704f, 0.02347f);
            f2153.AddVertex(-1.28251f, 7.03112f, 0.00666f);
            faces.Add(f2153);

            Face f2154 = new Face(m03___Default);
            f2154.AddVertex(-1.28251f, 7.03112f, 0.00666f);
            f2154.AddVertex(-1.26479f, 7.00704f, 0.02347f);
            f2154.AddVertex(-1.28184f, 6.99304f, 0.01333f);
            faces.Add(f2154);

            Face f2155 = new Face(m03___Default);
            f2155.AddVertex(-1.28251f, 7.03112f, 0.00666f);
            f2155.AddVertex(-1.28184f, 6.99304f, 0.01333f);
            f2155.AddVertex(-1.30473f, 7.01761f, -0.00140f);
            faces.Add(f2155);

            Face f2156 = new Face(m03___Default);
            f2156.AddVertex(-1.30473f, 7.01761f, -0.00140f);
            f2156.AddVertex(-1.28184f, 6.99304f, 0.01333f);
            f2156.AddVertex(-1.30553f, 6.98229f, 0.00867f);
            faces.Add(f2156);

            Face f2157 = new Face(m03___Default);
            f2157.AddVertex(-1.30473f, 7.01761f, -0.00140f);
            f2157.AddVertex(-1.30553f, 6.98229f, 0.00867f);
            f2157.AddVertex(-1.33268f, 7.00573f, -0.00176f);
            faces.Add(f2157);

            Face f2158 = new Face(m03___Default);
            f2158.AddVertex(-1.33268f, 7.00573f, -0.00176f);
            f2158.AddVertex(-1.30553f, 6.98229f, 0.00867f);
            f2158.AddVertex(-1.33406f, 6.97561f, 0.00986f);
            faces.Add(f2158);

            Face f2159 = new Face(m03___Default);
            f2159.AddVertex(-1.44564f, 7.05077f, 0.03556f);
            f2159.AddVertex(-1.42157f, 7.02978f, 0.02119f);
            f2159.AddVertex(-1.44762f, 7.02002f, 0.04542f);
            faces.Add(f2159);

            Face f2160 = new Face(m03___Default);
            f2160.AddVertex(-1.42157f, 7.02978f, 0.02119f);
            f2160.AddVertex(-1.39350f, 7.00923f, 0.01170f);
            f2160.AddVertex(-1.42110f, 6.99800f, 0.03242f);
            faces.Add(f2160);

            Face f2161 = new Face(m03___Default);
            f2161.AddVertex(-1.42157f, 7.02978f, 0.02119f);
            f2161.AddVertex(-1.42110f, 6.99800f, 0.03242f);
            f2161.AddVertex(-1.44762f, 7.02002f, 0.04542f);
            faces.Add(f2161);

            Face f2162 = new Face(m03___Default);
            f2162.AddVertex(-1.44762f, 7.02002f, 0.04542f);
            f2162.AddVertex(-1.42110f, 6.99800f, 0.03242f);
            f2162.AddVertex(-1.44361f, 6.99047f, 0.05832f);
            faces.Add(f2162);

            Face f2163 = new Face(m03___Default);
            f2163.AddVertex(-1.39350f, 7.00923f, 0.01170f);
            f2163.AddVertex(-1.36357f, 6.99070f, 0.00783f);
            f2163.AddVertex(-1.38957f, 6.97637f, 0.02494f);
            faces.Add(f2163);

            Face f2164 = new Face(m03___Default);
            f2164.AddVertex(-1.39350f, 7.00923f, 0.01170f);
            f2164.AddVertex(-1.38957f, 6.97637f, 0.02494f);
            f2164.AddVertex(-1.42110f, 6.99800f, 0.03242f);
            faces.Add(f2164);

            Face f2165 = new Face(m03___Default);
            f2165.AddVertex(-1.42110f, 6.99800f, 0.03242f);
            f2165.AddVertex(-1.38957f, 6.97637f, 0.02494f);
            f2165.AddVertex(-1.41373f, 6.96732f, 0.04742f);
            faces.Add(f2165);

            Face f2166 = new Face(m03___Default);
            f2166.AddVertex(-1.42110f, 6.99800f, 0.03242f);
            f2166.AddVertex(-1.41373f, 6.96732f, 0.04742f);
            f2166.AddVertex(-1.44361f, 6.99047f, 0.05832f);
            faces.Add(f2166);

            Face f2167 = new Face(m03___Default);
            f2167.AddVertex(-1.44361f, 6.99047f, 0.05832f);
            f2167.AddVertex(-1.41373f, 6.96732f, 0.04742f);
            f2167.AddVertex(-1.43393f, 6.96436f, 0.07328f);
            faces.Add(f2167);

            Face f2168 = new Face(m03___Default);
            f2168.AddVertex(-1.36357f, 6.99070f, 0.00783f);
            f2168.AddVertex(-1.33406f, 6.97561f, 0.00986f);
            f2168.AddVertex(-1.35553f, 6.95798f, 0.02421f);
            faces.Add(f2168);

            Face f2169 = new Face(m03___Default);
            f2169.AddVertex(-1.36357f, 6.99070f, 0.00783f);
            f2169.AddVertex(-1.35553f, 6.95798f, 0.02421f);
            f2169.AddVertex(-1.38957f, 6.97637f, 0.02494f);
            faces.Add(f2169);

            Face f2170 = new Face(m03___Default);
            f2170.AddVertex(-1.38957f, 6.97637f, 0.02494f);
            f2170.AddVertex(-1.35553f, 6.95798f, 0.02421f);
            f2170.AddVertex(-1.37803f, 6.94628f, 0.04321f);
            faces.Add(f2170);

            Face f2171 = new Face(m03___Default);
            f2171.AddVertex(-1.38957f, 6.97637f, 0.02494f);
            f2171.AddVertex(-1.37803f, 6.94628f, 0.04321f);
            f2171.AddVertex(-1.41373f, 6.96732f, 0.04742f);
            faces.Add(f2171);

            Face f2172 = new Face(m03___Default);
            f2172.AddVertex(-1.41373f, 6.96732f, 0.04742f);
            f2172.AddVertex(-1.37803f, 6.94628f, 0.04321f);
            f2172.AddVertex(-1.39984f, 6.94139f, 0.06542f);
            faces.Add(f2172);

            Face f2173 = new Face(m03___Default);
            f2173.AddVertex(-1.41373f, 6.96732f, 0.04742f);
            f2173.AddVertex(-1.39984f, 6.94139f, 0.06542f);
            f2173.AddVertex(-1.43393f, 6.96436f, 0.07328f);
            faces.Add(f2173);

            Face f2174 = new Face(m03___Default);
            f2174.AddVertex(-1.43393f, 6.96436f, 0.07328f);
            f2174.AddVertex(-1.39984f, 6.94139f, 0.06542f);
            f2174.AddVertex(-1.41932f, 6.94368f, 0.08916f);
            faces.Add(f2174);

            Face f2175 = new Face(m03___Default);
            f2175.AddVertex(-1.48245f, 7.04828f, 0.13246f);
            f2175.AddVertex(-1.47800f, 7.01796f, 0.12538f);
            f2175.AddVertex(-1.47015f, 7.02649f, 0.14905f);
            faces.Add(f2175);

            Face f2176 = new Face(m03___Default);
            f2176.AddVertex(-1.47800f, 7.01796f, 0.12538f);
            f2176.AddVertex(-1.46525f, 6.98900f, 0.11527f);
            f2176.AddVertex(-1.46226f, 6.99521f, 0.14075f);
            faces.Add(f2176);

            Face f2177 = new Face(m03___Default);
            f2177.AddVertex(-1.47800f, 7.01796f, 0.12538f);
            f2177.AddVertex(-1.46226f, 6.99521f, 0.14075f);
            f2177.AddVertex(-1.47015f, 7.02649f, 0.14905f);
            faces.Add(f2177);

            Face f2178 = new Face(m03___Default);
            f2178.AddVertex(-1.47015f, 7.02649f, 0.14905f);
            f2178.AddVertex(-1.46226f, 6.99521f, 0.14075f);
            f2178.AddVertex(-1.45015f, 7.00539f, 0.16081f);
            faces.Add(f2178);

            Face f2179 = new Face(m03___Default);
            f2179.AddVertex(-1.46525f, 6.98900f, 0.11527f);
            f2179.AddVertex(-1.44518f, 6.96359f, 0.10288f);
            f2179.AddVertex(-1.44461f, 6.96523f, 0.12869f);
            faces.Add(f2179);

            Face f2180 = new Face(m03___Default);
            f2180.AddVertex(-1.46525f, 6.98900f, 0.11527f);
            f2180.AddVertex(-1.44461f, 6.96523f, 0.12869f);
            f2180.AddVertex(-1.46226f, 6.99521f, 0.14075f);
            faces.Add(f2180);

            Face f2181 = new Face(m03___Default);
            f2181.AddVertex(-1.46226f, 6.99521f, 0.14075f);
            f2181.AddVertex(-1.44461f, 6.96523f, 0.12869f);
            f2181.AddVertex(-1.43732f, 6.97314f, 0.15066f);
            faces.Add(f2181);

            Face f2182 = new Face(m03___Default);
            f2182.AddVertex(-1.46226f, 6.99521f, 0.14075f);
            f2182.AddVertex(-1.43732f, 6.97314f, 0.15066f);
            f2182.AddVertex(-1.45015f, 7.00539f, 0.16081f);
            faces.Add(f2182);

            Face f2183 = new Face(m03___Default);
            f2183.AddVertex(-1.45015f, 7.00539f, 0.16081f);
            f2183.AddVertex(-1.43732f, 6.97314f, 0.15066f);
            f2183.AddVertex(-1.42397f, 6.98662f, 0.16682f);
            faces.Add(f2183);

            Face f2184 = new Face(m03___Default);
            f2184.AddVertex(-1.44518f, 6.96359f, 0.10288f);
            f2184.AddVertex(-1.41932f, 6.94368f, 0.08916f);
            f2184.AddVertex(-1.41804f, 6.94016f, 0.11332f);
            faces.Add(f2184);

            Face f2185 = new Face(m03___Default);
            f2185.AddVertex(-1.44518f, 6.96359f, 0.10288f);
            f2185.AddVertex(-1.41804f, 6.94016f, 0.11332f);
            f2185.AddVertex(-1.44461f, 6.96523f, 0.12869f);
            faces.Add(f2185);

            Face f2186 = new Face(m03___Default);
            f2186.AddVertex(-1.44461f, 6.96523f, 0.12869f);
            f2186.AddVertex(-1.41804f, 6.94016f, 0.11332f);
            f2186.AddVertex(-1.41303f, 6.94391f, 0.13536f);
            faces.Add(f2186);

            Face f2187 = new Face(m03___Default);
            f2187.AddVertex(-1.44461f, 6.96523f, 0.12869f);
            f2187.AddVertex(-1.41303f, 6.94391f, 0.13536f);
            f2187.AddVertex(-1.43732f, 6.97314f, 0.15066f);
            faces.Add(f2187);

            Face f2188 = new Face(m03___Default);
            f2188.AddVertex(-1.43732f, 6.97314f, 0.15066f);
            f2188.AddVertex(-1.41303f, 6.94391f, 0.13536f);
            f2188.AddVertex(-1.40468f, 6.95465f, 0.15359f);
            faces.Add(f2188);

            Face f2189 = new Face(m03___Default);
            f2189.AddVertex(-1.43732f, 6.97314f, 0.15066f);
            f2189.AddVertex(-1.40468f, 6.95465f, 0.15359f);
            f2189.AddVertex(-1.42397f, 6.98662f, 0.16682f);
            faces.Add(f2189);

            Face f2190 = new Face(m03___Default);
            f2190.AddVertex(-1.42397f, 6.98662f, 0.16682f);
            f2190.AddVertex(-1.40468f, 6.95465f, 0.15359f);
            f2190.AddVertex(-1.39362f, 6.97157f, 0.16663f);
            faces.Add(f2190);

            Face f2191 = new Face(m03___Default);
            f2191.AddVertex(-1.40406f, 7.09591f, 0.16092f);
            f2191.AddVertex(-1.40545f, 7.06579f, 0.17255f);
            f2191.AddVertex(-1.37455f, 7.08081f, 0.16295f);
            faces.Add(f2191);

            Face f2192 = new Face(m03___Default);
            f2192.AddVertex(-1.40545f, 7.06579f, 0.17255f);
            f2192.AddVertex(-1.40406f, 7.03338f, 0.17754f);
            f2192.AddVertex(-1.37461f, 7.04846f, 0.17257f);
            faces.Add(f2192);

            Face f2193 = new Face(m03___Default);
            f2193.AddVertex(-1.40545f, 7.06579f, 0.17255f);
            f2193.AddVertex(-1.37461f, 7.04846f, 0.17257f);
            f2193.AddVertex(-1.37455f, 7.08081f, 0.16295f);
            faces.Add(f2193);

            Face f2194 = new Face(m03___Default);
            f2194.AddVertex(-1.37455f, 7.08081f, 0.16295f);
            f2194.AddVertex(-1.37461f, 7.04846f, 0.17257f);
            f2194.AddVertex(-1.34462f, 7.06228f, 0.15907f);
            faces.Add(f2194);

            Face f2195 = new Face(m03___Default);
            f2195.AddVertex(-1.40406f, 7.03338f, 0.17754f);
            f2195.AddVertex(-1.40002f, 7.00117f, 0.17552f);
            f2195.AddVertex(-1.37157f, 7.01309f, 0.17453f);
            faces.Add(f2195);

            Face f2196 = new Face(m03___Default);
            f2196.AddVertex(-1.40406f, 7.03338f, 0.17754f);
            f2196.AddVertex(-1.37157f, 7.01309f, 0.17453f);
            f2196.AddVertex(-1.37461f, 7.04846f, 0.17257f);
            faces.Add(f2196);

            Face f2197 = new Face(m03___Default);
            f2197.AddVertex(-1.37461f, 7.04846f, 0.17257f);
            f2197.AddVertex(-1.37157f, 7.01309f, 0.17453f);
            f2197.AddVertex(-1.34290f, 7.02703f, 0.16562f);
            faces.Add(f2197);

            Face f2198 = new Face(m03___Default);
            f2198.AddVertex(-1.37461f, 7.04846f, 0.17257f);
            f2198.AddVertex(-1.34290f, 7.02703f, 0.16562f);
            f2198.AddVertex(-1.34462f, 7.06228f, 0.15907f);
            faces.Add(f2198);

            Face f2199 = new Face(m03___Default);
            f2199.AddVertex(-1.34462f, 7.06228f, 0.15907f);
            f2199.AddVertex(-1.34290f, 7.02703f, 0.16562f);
            f2199.AddVertex(-1.31655f, 7.04174f, 0.14959f);
            faces.Add(f2199);

            Face f2200 = new Face(m03___Default);
            f2200.AddVertex(-1.40002f, 7.00117f, 0.17552f);
            f2200.AddVertex(-1.39362f, 6.97157f, 0.16663f);
            f2200.AddVertex(-1.36593f, 6.97820f, 0.16767f);
            faces.Add(f2200);

            Face f2201 = new Face(m03___Default);
            f2201.AddVertex(-1.40002f, 7.00117f, 0.17552f);
            f2201.AddVertex(-1.36593f, 6.97820f, 0.16767f);
            f2201.AddVertex(-1.37157f, 7.01309f, 0.17453f);
            faces.Add(f2201);

            Face f2202 = new Face(m03___Default);
            f2202.AddVertex(-1.37157f, 7.01309f, 0.17453f);
            f2202.AddVertex(-1.36593f, 6.97820f, 0.16767f);
            f2202.AddVertex(-1.33848f, 6.98920f, 0.16243f);
            faces.Add(f2202);

            Face f2203 = new Face(m03___Default);
            f2203.AddVertex(-1.37157f, 7.01309f, 0.17453f);
            f2203.AddVertex(-1.33848f, 6.98920f, 0.16243f);
            f2203.AddVertex(-1.34290f, 7.02703f, 0.16562f);
            faces.Add(f2203);

            Face f2204 = new Face(m03___Default);
            f2204.AddVertex(-1.34290f, 7.02703f, 0.16562f);
            f2204.AddVertex(-1.33848f, 6.98920f, 0.16243f);
            f2204.AddVertex(-1.31336f, 7.00375f, 0.15133f);
            faces.Add(f2204);

            Face f2205 = new Face(m03___Default);
            f2205.AddVertex(-1.34290f, 7.02703f, 0.16562f);
            f2205.AddVertex(-1.31336f, 7.00375f, 0.15133f);
            f2205.AddVertex(-1.31655f, 7.04174f, 0.14959f);
            faces.Add(f2205);

            Face f2206 = new Face(m03___Default);
            f2206.AddVertex(-1.31655f, 7.04174f, 0.14959f);
            f2206.AddVertex(-1.31336f, 7.00375f, 0.15133f);
            f2206.AddVertex(-1.29248f, 7.02074f, 0.13521f);
            faces.Add(f2206);

            Face f2207 = new Face(m03___Default);
            f2207.AddVertex(-1.25567f, 7.02323f, 0.03832f);
            f2207.AddVertex(-1.26797f, 7.04503f, 0.02172f);
            f2207.AddVertex(-1.26013f, 7.05355f, 0.04539f);
            faces.Add(f2207);

            Face f2208 = new Face(m03___Default);
            f2208.AddVertex(-1.26797f, 7.04503f, 0.02172f);
            f2208.AddVertex(-1.28798f, 7.06612f, 0.00997f);
            f2208.AddVertex(-1.27586f, 7.07630f, 0.03003f);
            faces.Add(f2208);

            Face f2209 = new Face(m03___Default);
            f2209.AddVertex(-1.26797f, 7.04503f, 0.02172f);
            f2209.AddVertex(-1.27586f, 7.07630f, 0.03003f);
            f2209.AddVertex(-1.26013f, 7.05355f, 0.04539f);
            faces.Add(f2209);

            Face f2210 = new Face(m03___Default);
            f2210.AddVertex(-1.26013f, 7.05355f, 0.04539f);
            f2210.AddVertex(-1.27586f, 7.07630f, 0.03003f);
            f2210.AddVertex(-1.27287f, 7.08251f, 0.05551f);
            faces.Add(f2210);

            Face f2211 = new Face(m03___Default);
            f2211.AddVertex(-1.28798f, 7.06612f, 0.00997f);
            f2211.AddVertex(-1.31415f, 7.08490f, 0.00395f);
            f2211.AddVertex(-1.30080f, 7.09838f, 0.02012f);
            faces.Add(f2211);

            Face f2212 = new Face(m03___Default);
            f2212.AddVertex(-1.28798f, 7.06612f, 0.00997f);
            f2212.AddVertex(-1.30080f, 7.09838f, 0.02012f);
            f2212.AddVertex(-1.27586f, 7.07630f, 0.03003f);
            faces.Add(f2212);

            Face f2213 = new Face(m03___Default);
            f2213.AddVertex(-1.27586f, 7.07630f, 0.03003f);
            f2213.AddVertex(-1.30080f, 7.09838f, 0.02012f);
            f2213.AddVertex(-1.29351f, 7.10628f, 0.04209f);
            faces.Add(f2213);

            Face f2214 = new Face(m03___Default);
            f2214.AddVertex(-1.27586f, 7.07630f, 0.03003f);
            f2214.AddVertex(-1.29351f, 7.10628f, 0.04209f);
            f2214.AddVertex(-1.27287f, 7.08251f, 0.05551f);
            faces.Add(f2214);

            Face f2215 = new Face(m03___Default);
            f2215.AddVertex(-1.27287f, 7.08251f, 0.05551f);
            f2215.AddVertex(-1.29351f, 7.10628f, 0.04209f);
            f2215.AddVertex(-1.29294f, 7.10792f, 0.06790f);
            faces.Add(f2215);

            Face f2216 = new Face(m03___Default);
            f2216.AddVertex(-1.31415f, 7.08490f, 0.00395f);
            f2216.AddVertex(-1.34450f, 7.09994f, 0.00414f);
            f2216.AddVertex(-1.33344f, 7.11686f, 0.01719f);
            faces.Add(f2216);

            Face f2217 = new Face(m03___Default);
            f2217.AddVertex(-1.31415f, 7.08490f, 0.00395f);
            f2217.AddVertex(-1.33344f, 7.11686f, 0.01719f);
            f2217.AddVertex(-1.30080f, 7.09838f, 0.02012f);
            faces.Add(f2217);

            Face f2218 = new Face(m03___Default);
            f2218.AddVertex(-1.30080f, 7.09838f, 0.02012f);
            f2218.AddVertex(-1.33344f, 7.11686f, 0.01719f);
            f2218.AddVertex(-1.32508f, 7.12761f, 0.03542f);
            faces.Add(f2218);

            Face f2219 = new Face(m03___Default);
            f2219.AddVertex(-1.30080f, 7.09838f, 0.02012f);
            f2219.AddVertex(-1.32508f, 7.12761f, 0.03542f);
            f2219.AddVertex(-1.29351f, 7.10628f, 0.04209f);
            faces.Add(f2219);

            Face f2220 = new Face(m03___Default);
            f2220.AddVertex(-1.29351f, 7.10628f, 0.04209f);
            f2220.AddVertex(-1.32508f, 7.12761f, 0.03542f);
            f2220.AddVertex(-1.32008f, 7.13136f, 0.05746f);
            faces.Add(f2220);

            Face f2221 = new Face(m03___Default);
            f2221.AddVertex(-1.29351f, 7.10628f, 0.04209f);
            f2221.AddVertex(-1.32008f, 7.13136f, 0.05746f);
            f2221.AddVertex(-1.29294f, 7.10792f, 0.06790f);
            faces.Add(f2221);

            Face f2222 = new Face(m03___Default);
            f2222.AddVertex(-1.29294f, 7.10792f, 0.06790f);
            f2222.AddVertex(-1.32008f, 7.13136f, 0.05746f);
            f2222.AddVertex(-1.31881f, 7.12783f, 0.08162f);
            faces.Add(f2222);

            Face f2223 = new Face(m03___Default);
            f2223.AddVertex(-1.33406f, 6.97561f, 0.00986f);
            f2223.AddVertex(-1.36357f, 6.99070f, 0.00783f);
            f2223.AddVertex(-1.33268f, 7.00573f, -0.00176f);
            faces.Add(f2223);

            Face f2224 = new Face(m03___Default);
            f2224.AddVertex(-1.36357f, 6.99070f, 0.00783f);
            f2224.AddVertex(-1.39350f, 7.00923f, 0.01170f);
            f2224.AddVertex(-1.36351f, 7.02305f, -0.00179f);
            faces.Add(f2224);

            Face f2225 = new Face(m03___Default);
            f2225.AddVertex(-1.36357f, 6.99070f, 0.00783f);
            f2225.AddVertex(-1.36351f, 7.02305f, -0.00179f);
            f2225.AddVertex(-1.33268f, 7.00573f, -0.00176f);
            faces.Add(f2225);

            Face f2226 = new Face(m03___Default);
            f2226.AddVertex(-1.33268f, 7.00573f, -0.00176f);
            f2226.AddVertex(-1.36351f, 7.02305f, -0.00179f);
            f2226.AddVertex(-1.33405f, 7.03813f, -0.00675f);
            faces.Add(f2226);

            Face f2227 = new Face(m03___Default);
            f2227.AddVertex(-1.39350f, 7.00923f, 0.01170f);
            f2227.AddVertex(-1.42157f, 7.02978f, 0.02119f);
            f2227.AddVertex(-1.39522f, 7.04449f, 0.00515f);
            faces.Add(f2227);

            Face f2228 = new Face(m03___Default);
            f2228.AddVertex(-1.39350f, 7.00923f, 0.01170f);
            f2228.AddVertex(-1.39522f, 7.04449f, 0.00515f);
            f2228.AddVertex(-1.36351f, 7.02305f, -0.00179f);
            faces.Add(f2228);

            Face f2229 = new Face(m03___Default);
            f2229.AddVertex(-1.36351f, 7.02305f, -0.00179f);
            f2229.AddVertex(-1.39522f, 7.04449f, 0.00515f);
            f2229.AddVertex(-1.36655f, 7.05843f, -0.00375f);
            faces.Add(f2229);

            Face f2230 = new Face(m03___Default);
            f2230.AddVertex(-1.36351f, 7.02305f, -0.00179f);
            f2230.AddVertex(-1.36655f, 7.05843f, -0.00375f);
            f2230.AddVertex(-1.33405f, 7.03813f, -0.00675f);
            faces.Add(f2230);

            Face f2231 = new Face(m03___Default);
            f2231.AddVertex(-1.33405f, 7.03813f, -0.00675f);
            f2231.AddVertex(-1.36655f, 7.05843f, -0.00375f);
            f2231.AddVertex(-1.33810f, 7.07035f, -0.00473f);
            faces.Add(f2231);

            Face f2232 = new Face(m03___Default);
            f2232.AddVertex(-1.42157f, 7.02978f, 0.02119f);
            f2232.AddVertex(-1.44564f, 7.05077f, 0.03556f);
            f2232.AddVertex(-1.42476f, 7.06776f, 0.01944f);
            faces.Add(f2232);

            Face f2233 = new Face(m03___Default);
            f2233.AddVertex(-1.42157f, 7.02978f, 0.02119f);
            f2233.AddVertex(-1.42476f, 7.06776f, 0.01944f);
            f2233.AddVertex(-1.39522f, 7.04449f, 0.00515f);
            faces.Add(f2233);

            Face f2234 = new Face(m03___Default);
            f2234.AddVertex(-1.39522f, 7.04449f, 0.00515f);
            f2234.AddVertex(-1.42476f, 7.06776f, 0.01944f);
            f2234.AddVertex(-1.39964f, 7.08231f, 0.00835f);
            faces.Add(f2234);

            Face f2235 = new Face(m03___Default);
            f2235.AddVertex(-1.39522f, 7.04449f, 0.00515f);
            f2235.AddVertex(-1.39964f, 7.08231f, 0.00835f);
            f2235.AddVertex(-1.36655f, 7.05843f, -0.00375f);
            faces.Add(f2235);

            Face f2236 = new Face(m03___Default);
            f2236.AddVertex(-1.36655f, 7.05843f, -0.00375f);
            f2236.AddVertex(-1.39964f, 7.08231f, 0.00835f);
            f2236.AddVertex(-1.37219f, 7.09332f, 0.00312f);
            faces.Add(f2236);

            Face f2237 = new Face(m03___Default);
            f2237.AddVertex(-1.36655f, 7.05843f, -0.00375f);
            f2237.AddVertex(-1.37219f, 7.09332f, 0.00312f);
            f2237.AddVertex(-1.33810f, 7.07035f, -0.00473f);
            faces.Add(f2237);

            Face f2238 = new Face(m03___Default);
            f2238.AddVertex(-1.33810f, 7.07035f, -0.00473f);
            f2238.AddVertex(-1.37219f, 7.09332f, 0.00312f);
            f2238.AddVertex(-1.34450f, 7.09994f, 0.00414f);
            faces.Add(f2238);

            Face f2239 = new Face(m03___Default);
            f2239.AddVertex(-1.41932f, 6.94368f, 0.08916f);
            f2239.AddVertex(-1.44518f, 6.96359f, 0.10288f);
            f2239.AddVertex(-1.43393f, 6.96436f, 0.07328f);
            faces.Add(f2239);

            Face f2240 = new Face(m03___Default);
            f2240.AddVertex(-1.44518f, 6.96359f, 0.10288f);
            f2240.AddVertex(-1.46525f, 6.98900f, 0.11527f);
            f2240.AddVertex(-1.45883f, 6.98736f, 0.08687f);
            faces.Add(f2240);

            Face f2241 = new Face(m03___Default);
            f2241.AddVertex(-1.44518f, 6.96359f, 0.10288f);
            f2241.AddVertex(-1.45883f, 6.98736f, 0.08687f);
            f2241.AddVertex(-1.43393f, 6.96436f, 0.07328f);
            faces.Add(f2241);

            Face f2242 = new Face(m03___Default);
            f2242.AddVertex(-1.43393f, 6.96436f, 0.07328f);
            f2242.AddVertex(-1.45883f, 6.98736f, 0.08687f);
            f2242.AddVertex(-1.44361f, 6.99047f, 0.05832f);
            faces.Add(f2242);

            Face f2243 = new Face(m03___Default);
            f2243.AddVertex(-1.46525f, 6.98900f, 0.11527f);
            f2243.AddVertex(-1.47800f, 7.01796f, 0.12538f);
            f2243.AddVertex(-1.47717f, 7.01700f, 0.09914f);
            faces.Add(f2243);

            Face f2244 = new Face(m03___Default);
            f2244.AddVertex(-1.46525f, 6.98900f, 0.11527f);
            f2244.AddVertex(-1.47717f, 7.01700f, 0.09914f);
            f2244.AddVertex(-1.45883f, 6.98736f, 0.08687f);
            faces.Add(f2244);

            Face f2245 = new Face(m03___Default);
            f2245.AddVertex(-1.45883f, 6.98736f, 0.08687f);
            f2245.AddVertex(-1.47717f, 7.01700f, 0.09914f);
            f2245.AddVertex(-1.46673f, 7.01771f, 0.07167f);
            faces.Add(f2245);

            Face f2246 = new Face(m03___Default);
            f2246.AddVertex(-1.45883f, 6.98736f, 0.08687f);
            f2246.AddVertex(-1.46673f, 7.01771f, 0.07167f);
            f2246.AddVertex(-1.44361f, 6.99047f, 0.05832f);
            faces.Add(f2246);

            Face f2247 = new Face(m03___Default);
            f2247.AddVertex(-1.44361f, 6.99047f, 0.05832f);
            f2247.AddVertex(-1.46673f, 7.01771f, 0.07167f);
            f2247.AddVertex(-1.44762f, 7.02002f, 0.04542f);
            faces.Add(f2247);

            Face f2248 = new Face(m03___Default);
            f2248.AddVertex(-1.47800f, 7.01796f, 0.12538f);
            f2248.AddVertex(-1.48245f, 7.04828f, 0.13246f);
            f2248.AddVertex(-1.48604f, 7.05068f, 0.10901f);
            faces.Add(f2248);

            Face f2249 = new Face(m03___Default);
            f2249.AddVertex(-1.47800f, 7.01796f, 0.12538f);
            f2249.AddVertex(-1.48604f, 7.05068f, 0.10901f);
            f2249.AddVertex(-1.47717f, 7.01700f, 0.09914f);
            faces.Add(f2249);

            Face f2250 = new Face(m03___Default);
            f2250.AddVertex(-1.47717f, 7.01700f, 0.09914f);
            f2250.AddVertex(-1.48604f, 7.05068f, 0.10901f);
            f2250.AddVertex(-1.48072f, 7.05195f, 0.08377f);
            faces.Add(f2250);

            Face f2251 = new Face(m03___Default);
            f2251.AddVertex(-1.47717f, 7.01700f, 0.09914f);
            f2251.AddVertex(-1.48072f, 7.05195f, 0.08377f);
            f2251.AddVertex(-1.46673f, 7.01771f, 0.07167f);
            faces.Add(f2251);

            Face f2252 = new Face(m03___Default);
            f2252.AddVertex(-1.46673f, 7.01771f, 0.07167f);
            f2252.AddVertex(-1.48072f, 7.05195f, 0.08377f);
            f2252.AddVertex(-1.46691f, 7.05198f, 0.05865f);
            faces.Add(f2252);

            Face f2253 = new Face(m03___Default);
            f2253.AddVertex(-1.46673f, 7.01771f, 0.07167f);
            f2253.AddVertex(-1.46691f, 7.05198f, 0.05865f);
            f2253.AddVertex(-1.44762f, 7.02002f, 0.04542f);
            faces.Add(f2253);

            Face f2254 = new Face(m03___Default);
            f2254.AddVertex(-1.44762f, 7.02002f, 0.04542f);
            f2254.AddVertex(-1.46691f, 7.05198f, 0.05865f);
            f2254.AddVertex(-1.44564f, 7.05077f, 0.03556f);
            faces.Add(f2254);

            Face f2255 = new Face(m03___Default);
            f2255.AddVertex(-1.39362f, 6.97157f, 0.16663f);
            f2255.AddVertex(-1.40002f, 7.00117f, 0.17552f);
            f2255.AddVertex(-1.42397f, 6.98662f, 0.16682f);
            faces.Add(f2255);

            Face f2256 = new Face(m03___Default);
            f2256.AddVertex(-1.40002f, 7.00117f, 0.17552f);
            f2256.AddVertex(-1.40406f, 7.03338f, 0.17754f);
            f2256.AddVertex(-1.43009f, 7.01855f, 0.17349f);
            faces.Add(f2256);

            Face f2257 = new Face(m03___Default);
            f2257.AddVertex(-1.40002f, 7.00117f, 0.17552f);
            f2257.AddVertex(-1.43009f, 7.01855f, 0.17349f);
            f2257.AddVertex(-1.42397f, 6.98662f, 0.16682f);
            faces.Add(f2257);

            Face f2258 = new Face(m03___Default);
            f2258.AddVertex(-1.42397f, 6.98662f, 0.16682f);
            f2258.AddVertex(-1.43009f, 7.01855f, 0.17349f);
            f2258.AddVertex(-1.45015f, 7.00539f, 0.16081f);
            faces.Add(f2258);

            Face f2259 = new Face(m03___Default);
            f2259.AddVertex(-1.40406f, 7.03338f, 0.17754f);
            f2259.AddVertex(-1.40545f, 7.06579f, 0.17255f);
            f2259.AddVertex(-1.43339f, 7.05390f, 0.17219f);
            faces.Add(f2259);

            Face f2260 = new Face(m03___Default);
            f2260.AddVertex(-1.40406f, 7.03338f, 0.17754f);
            f2260.AddVertex(-1.43339f, 7.05390f, 0.17219f);
            f2260.AddVertex(-1.43009f, 7.01855f, 0.17349f);
            faces.Add(f2260);

            Face f2261 = new Face(m03___Default);
            f2261.AddVertex(-1.43009f, 7.01855f, 0.17349f);
            f2261.AddVertex(-1.43339f, 7.05390f, 0.17219f);
            f2261.AddVertex(-1.45561f, 7.04040f, 0.16412f);
            faces.Add(f2261);

            Face f2262 = new Face(m03___Default);
            f2262.AddVertex(-1.43009f, 7.01855f, 0.17349f);
            f2262.AddVertex(-1.45561f, 7.04040f, 0.16412f);
            f2262.AddVertex(-1.45015f, 7.00539f, 0.16081f);
            faces.Add(f2262);

            Face f2263 = new Face(m03___Default);
            f2263.AddVertex(-1.45015f, 7.00539f, 0.16081f);
            f2263.AddVertex(-1.45561f, 7.04040f, 0.16412f);
            f2263.AddVertex(-1.47015f, 7.02649f, 0.14905f);
            faces.Add(f2263);

            Face f2264 = new Face(m03___Default);
            f2264.AddVertex(-1.40545f, 7.06579f, 0.17255f);
            f2264.AddVertex(-1.40406f, 7.09591f, 0.16092f);
            f2264.AddVertex(-1.43259f, 7.08923f, 0.16210f);
            faces.Add(f2264);

            Face f2265 = new Face(m03___Default);
            f2265.AddVertex(-1.40545f, 7.06579f, 0.17255f);
            f2265.AddVertex(-1.43259f, 7.08923f, 0.16210f);
            f2265.AddVertex(-1.43339f, 7.05390f, 0.17219f);
            faces.Add(f2265);

            Face f2266 = new Face(m03___Default);
            f2266.AddVertex(-1.43339f, 7.05390f, 0.17219f);
            f2266.AddVertex(-1.43259f, 7.08923f, 0.16210f);
            f2266.AddVertex(-1.45628f, 7.07848f, 0.15745f);
            faces.Add(f2266);

            Face f2267 = new Face(m03___Default);
            f2267.AddVertex(-1.43339f, 7.05390f, 0.17219f);
            f2267.AddVertex(-1.45628f, 7.07848f, 0.15745f);
            f2267.AddVertex(-1.45561f, 7.04040f, 0.16412f);
            faces.Add(f2267);

            Face f2268 = new Face(m03___Default);
            f2268.AddVertex(-1.45561f, 7.04040f, 0.16412f);
            f2268.AddVertex(-1.45628f, 7.07848f, 0.15745f);
            f2268.AddVertex(-1.47333f, 7.06447f, 0.14731f);
            faces.Add(f2268);

            Face f2269 = new Face(m03___Default);
            f2269.AddVertex(-1.45561f, 7.04040f, 0.16412f);
            f2269.AddVertex(-1.47333f, 7.06447f, 0.14731f);
            f2269.AddVertex(-1.47015f, 7.02649f, 0.14905f);
            faces.Add(f2269);

            Face f2270 = new Face(m03___Default);
            f2270.AddVertex(-1.47015f, 7.02649f, 0.14905f);
            f2270.AddVertex(-1.47333f, 7.06447f, 0.14731f);
            f2270.AddVertex(-1.48245f, 7.04828f, 0.13246f);
            faces.Add(f2270);

            Face f2271 = new Face(m03___Default);
            f2271.AddVertex(-1.29248f, 7.02074f, 0.13521f);
            f2271.AddVertex(-1.29050f, 7.05149f, 0.12536f);
            f2271.AddVertex(-1.31655f, 7.04174f, 0.14959f);
            faces.Add(f2271);

            Face f2272 = new Face(m03___Default);
            f2272.AddVertex(-1.29050f, 7.05149f, 0.12536f);
            f2272.AddVertex(-1.29450f, 7.08105f, 0.11246f);
            f2272.AddVertex(-1.31702f, 7.07352f, 0.13836f);
            faces.Add(f2272);

            Face f2273 = new Face(m03___Default);
            f2273.AddVertex(-1.29050f, 7.05149f, 0.12536f);
            f2273.AddVertex(-1.31702f, 7.07352f, 0.13836f);
            f2273.AddVertex(-1.31655f, 7.04174f, 0.14959f);
            faces.Add(f2273);

            Face f2274 = new Face(m03___Default);
            f2274.AddVertex(-1.31655f, 7.04174f, 0.14959f);
            f2274.AddVertex(-1.31702f, 7.07352f, 0.13836f);
            f2274.AddVertex(-1.34462f, 7.06228f, 0.15907f);
            faces.Add(f2274);

            Face f2275 = new Face(m03___Default);
            f2275.AddVertex(-1.29450f, 7.08105f, 0.11246f);
            f2275.AddVertex(-1.30419f, 7.10716f, 0.09750f);
            f2275.AddVertex(-1.32439f, 7.10419f, 0.12336f);
            faces.Add(f2275);

            Face f2276 = new Face(m03___Default);
            f2276.AddVertex(-1.29450f, 7.08105f, 0.11246f);
            f2276.AddVertex(-1.32439f, 7.10419f, 0.12336f);
            f2276.AddVertex(-1.31702f, 7.07352f, 0.13836f);
            faces.Add(f2276);

            Face f2277 = new Face(m03___Default);
            f2277.AddVertex(-1.31702f, 7.07352f, 0.13836f);
            f2277.AddVertex(-1.32439f, 7.10419f, 0.12336f);
            f2277.AddVertex(-1.34855f, 7.09514f, 0.14584f);
            faces.Add(f2277);

            Face f2278 = new Face(m03___Default);
            f2278.AddVertex(-1.31702f, 7.07352f, 0.13836f);
            f2278.AddVertex(-1.34855f, 7.09514f, 0.14584f);
            f2278.AddVertex(-1.34462f, 7.06228f, 0.15907f);
            faces.Add(f2278);

            Face f2279 = new Face(m03___Default);
            f2279.AddVertex(-1.34462f, 7.06228f, 0.15907f);
            f2279.AddVertex(-1.34855f, 7.09514f, 0.14584f);
            f2279.AddVertex(-1.37455f, 7.08081f, 0.16295f);
            faces.Add(f2279);

            Face f2280 = new Face(m03___Default);
            f2280.AddVertex(-1.30419f, 7.10716f, 0.09750f);
            f2280.AddVertex(-1.31881f, 7.12783f, 0.08162f);
            f2280.AddVertex(-1.33827f, 7.13013f, 0.10535f);
            faces.Add(f2280);

            Face f2281 = new Face(m03___Default);
            f2281.AddVertex(-1.30419f, 7.10716f, 0.09750f);
            f2281.AddVertex(-1.33827f, 7.13013f, 0.10535f);
            f2281.AddVertex(-1.32439f, 7.10419f, 0.12336f);
            faces.Add(f2281);

            Face f2282 = new Face(m03___Default);
            f2282.AddVertex(-1.32439f, 7.10419f, 0.12336f);
            f2282.AddVertex(-1.33827f, 7.13013f, 0.10535f);
            f2282.AddVertex(-1.36009f, 7.12523f, 0.12757f);
            faces.Add(f2282);

            Face f2283 = new Face(m03___Default);
            f2283.AddVertex(-1.32439f, 7.10419f, 0.12336f);
            f2283.AddVertex(-1.36009f, 7.12523f, 0.12757f);
            f2283.AddVertex(-1.34855f, 7.09514f, 0.14584f);
            faces.Add(f2283);

            Face f2284 = new Face(m03___Default);
            f2284.AddVertex(-1.34855f, 7.09514f, 0.14584f);
            f2284.AddVertex(-1.36009f, 7.12523f, 0.12757f);
            f2284.AddVertex(-1.38259f, 7.11353f, 0.14658f);
            faces.Add(f2284);

            Face f2285 = new Face(m03___Default);
            f2285.AddVertex(-1.34855f, 7.09514f, 0.14584f);
            f2285.AddVertex(-1.38259f, 7.11353f, 0.14658f);
            f2285.AddVertex(-1.37455f, 7.08081f, 0.16295f);
            faces.Add(f2285);

            Face f2286 = new Face(m03___Default);
            f2286.AddVertex(-1.37455f, 7.08081f, 0.16295f);
            f2286.AddVertex(-1.38259f, 7.11353f, 0.14658f);
            f2286.AddVertex(-1.40406f, 7.09591f, 0.16092f);
            faces.Add(f2286);

            Face f2287 = new Face(m03___Default);
            f2287.AddVertex(-1.30191f, 6.92666f, 0.09087f);
            f2287.AddVertex(-1.30294f, 6.92734f, 0.06683f);
            f2287.AddVertex(-1.27900f, 6.94189f, 0.07553f);
            faces.Add(f2287);

            Face f2288 = new Face(m03___Default);
            f2288.AddVertex(-1.30294f, 6.92734f, 0.06683f);
            f2288.AddVertex(-1.30902f, 6.93628f, 0.04421f);
            f2288.AddVertex(-1.28171f, 6.94587f, 0.05089f);
            faces.Add(f2288);

            Face f2289 = new Face(m03___Default);
            f2289.AddVertex(-1.30294f, 6.92734f, 0.06683f);
            f2289.AddVertex(-1.28171f, 6.94587f, 0.05089f);
            f2289.AddVertex(-1.27900f, 6.94189f, 0.07553f);
            faces.Add(f2289);

            Face f2290 = new Face(m03___Default);
            f2290.AddVertex(-1.27900f, 6.94189f, 0.07553f);
            f2290.AddVertex(-1.28171f, 6.94587f, 0.05089f);
            f2290.AddVertex(-1.26294f, 6.96427f, 0.06094f);
            faces.Add(f2290);

            Face f2291 = new Face(m03___Default);
            f2291.AddVertex(-1.30902f, 6.93628f, 0.04421f);
            f2291.AddVertex(-1.31966f, 6.95279f, 0.02473f);
            f2291.AddVertex(-1.29045f, 6.95951f, 0.02766f);
            faces.Add(f2291);

            Face f2292 = new Face(m03___Default);
            f2292.AddVertex(-1.30902f, 6.93628f, 0.04421f);
            f2292.AddVertex(-1.29045f, 6.95951f, 0.02766f);
            f2292.AddVertex(-1.28171f, 6.94587f, 0.05089f);
            faces.Add(f2292);

            Face f2293 = new Face(m03___Default);
            f2293.AddVertex(-1.28171f, 6.94587f, 0.05089f);
            f2293.AddVertex(-1.29045f, 6.95951f, 0.02766f);
            f2293.AddVertex(-1.26823f, 6.97301f, 0.03574f);
            faces.Add(f2293);

            Face f2294 = new Face(m03___Default);
            f2294.AddVertex(-1.28171f, 6.94587f, 0.05089f);
            f2294.AddVertex(-1.26823f, 6.97301f, 0.03574f);
            f2294.AddVertex(-1.26294f, 6.96427f, 0.06094f);
            faces.Add(f2294);

            Face f2295 = new Face(m03___Default);
            f2295.AddVertex(-1.26294f, 6.96427f, 0.06094f);
            f2295.AddVertex(-1.26823f, 6.97301f, 0.03574f);
            f2295.AddVertex(-1.25496f, 6.99209f, 0.04822f);
            faces.Add(f2295);

            Face f2296 = new Face(m03___Default);
            f2296.AddVertex(-1.31966f, 6.95279f, 0.02473f);
            f2296.AddVertex(-1.33406f, 6.97561f, 0.00986f);
            f2296.AddVertex(-1.30553f, 6.98229f, 0.00867f);
            faces.Add(f2296);

            Face f2297 = new Face(m03___Default);
            f2297.AddVertex(-1.31966f, 6.95279f, 0.02473f);
            f2297.AddVertex(-1.30553f, 6.98229f, 0.00867f);
            f2297.AddVertex(-1.29045f, 6.95951f, 0.02766f);
            faces.Add(f2297);

            Face f2298 = new Face(m03___Default);
            f2298.AddVertex(-1.29045f, 6.95951f, 0.02766f);
            f2298.AddVertex(-1.30553f, 6.98229f, 0.00867f);
            f2298.AddVertex(-1.28184f, 6.99304f, 0.01333f);
            faces.Add(f2298);

            Face f2299 = new Face(m03___Default);
            f2299.AddVertex(-1.29045f, 6.95951f, 0.02766f);
            f2299.AddVertex(-1.28184f, 6.99304f, 0.01333f);
            f2299.AddVertex(-1.26823f, 6.97301f, 0.03574f);
            faces.Add(f2299);

            Face f2300 = new Face(m03___Default);
            f2300.AddVertex(-1.26823f, 6.97301f, 0.03574f);
            f2300.AddVertex(-1.28184f, 6.99304f, 0.01333f);
            f2300.AddVertex(-1.26479f, 7.00704f, 0.02347f);
            faces.Add(f2300);

            Face f2301 = new Face(m03___Default);
            f2301.AddVertex(-1.26823f, 6.97301f, 0.03574f);
            f2301.AddVertex(-1.26479f, 7.00704f, 0.02347f);
            f2301.AddVertex(-1.25496f, 6.99209f, 0.04822f);
            faces.Add(f2301);

            Face f2302 = new Face(m03___Default);
            f2302.AddVertex(-1.25496f, 6.99209f, 0.04822f);
            f2302.AddVertex(-1.26479f, 7.00704f, 0.02347f);
            f2302.AddVertex(-1.25567f, 7.02323f, 0.03832f);
            faces.Add(f2302);

            Face f2303 = new Face(m03___Default);
            f2303.AddVertex(-1.30191f, 6.92666f, 0.09087f);
            f2303.AddVertex(-1.32900f, 6.91759f, 0.09106f);
            f2303.AddVertex(-1.30294f, 6.92734f, 0.06683f);
            faces.Add(f2303);

            Face f2304 = new Face(m03___Default);
            f2304.AddVertex(-1.32900f, 6.91759f, 0.09106f);
            f2304.AddVertex(-1.35913f, 6.91751f, 0.09082f);
            f2304.AddVertex(-1.33227f, 6.92129f, 0.06660f);
            faces.Add(f2304);

            Face f2305 = new Face(m03___Default);
            f2305.AddVertex(-1.32900f, 6.91759f, 0.09106f);
            f2305.AddVertex(-1.33227f, 6.92129f, 0.06660f);
            f2305.AddVertex(-1.30294f, 6.92734f, 0.06683f);
            faces.Add(f2305);

            Face f2306 = new Face(m03___Default);
            f2306.AddVertex(-1.30294f, 6.92734f, 0.06683f);
            f2306.AddVertex(-1.33227f, 6.92129f, 0.06660f);
            f2306.AddVertex(-1.30902f, 6.93628f, 0.04421f);
            faces.Add(f2306);

            Face f2307 = new Face(m03___Default);
            f2307.AddVertex(-1.35913f, 6.91751f, 0.09082f);
            f2307.AddVertex(-1.39002f, 6.92643f, 0.09017f);
            f2307.AddVertex(-1.36554f, 6.92571f, 0.06597f);
            faces.Add(f2307);

            Face f2308 = new Face(m03___Default);
            f2308.AddVertex(-1.35913f, 6.91751f, 0.09082f);
            f2308.AddVertex(-1.36554f, 6.92571f, 0.06597f);
            f2308.AddVertex(-1.33227f, 6.92129f, 0.06660f);
            faces.Add(f2308);

            Face f2309 = new Face(m03___Default);
            f2309.AddVertex(-1.33227f, 6.92129f, 0.06660f);
            f2309.AddVertex(-1.36554f, 6.92571f, 0.06597f);
            f2309.AddVertex(-1.34137f, 6.93476f, 0.04349f);
            faces.Add(f2309);

            Face f2310 = new Face(m03___Default);
            f2310.AddVertex(-1.33227f, 6.92129f, 0.06660f);
            f2310.AddVertex(-1.34137f, 6.93476f, 0.04349f);
            f2310.AddVertex(-1.30902f, 6.93628f, 0.04421f);
            faces.Add(f2310);

            Face f2311 = new Face(m03___Default);
            f2311.AddVertex(-1.30902f, 6.93628f, 0.04421f);
            f2311.AddVertex(-1.34137f, 6.93476f, 0.04349f);
            f2311.AddVertex(-1.31966f, 6.95279f, 0.02473f);
            faces.Add(f2311);

            Face f2312 = new Face(m03___Default);
            f2312.AddVertex(-1.39002f, 6.92643f, 0.09017f);
            f2312.AddVertex(-1.41932f, 6.94368f, 0.08916f);
            f2312.AddVertex(-1.39984f, 6.94139f, 0.06542f);
            faces.Add(f2312);

            Face f2313 = new Face(m03___Default);
            f2313.AddVertex(-1.39002f, 6.92643f, 0.09017f);
            f2313.AddVertex(-1.39984f, 6.94139f, 0.06542f);
            f2313.AddVertex(-1.36554f, 6.92571f, 0.06597f);
            faces.Add(f2313);

            Face f2314 = new Face(m03___Default);
            f2314.AddVertex(-1.36554f, 6.92571f, 0.06597f);
            f2314.AddVertex(-1.39984f, 6.94139f, 0.06542f);
            f2314.AddVertex(-1.37803f, 6.94628f, 0.04321f);
            faces.Add(f2314);

            Face f2315 = new Face(m03___Default);
            f2315.AddVertex(-1.36554f, 6.92571f, 0.06597f);
            f2315.AddVertex(-1.37803f, 6.94628f, 0.04321f);
            f2315.AddVertex(-1.34137f, 6.93476f, 0.04349f);
            faces.Add(f2315);

            Face f2316 = new Face(m03___Default);
            f2316.AddVertex(-1.34137f, 6.93476f, 0.04349f);
            f2316.AddVertex(-1.37803f, 6.94628f, 0.04321f);
            f2316.AddVertex(-1.35553f, 6.95798f, 0.02421f);
            faces.Add(f2316);

            Face f2317 = new Face(m03___Default);
            f2317.AddVertex(-1.34137f, 6.93476f, 0.04349f);
            f2317.AddVertex(-1.35553f, 6.95798f, 0.02421f);
            f2317.AddVertex(-1.31966f, 6.95279f, 0.02473f);
            faces.Add(f2317);

            Face f2318 = new Face(m03___Default);
            f2318.AddVertex(-1.31966f, 6.95279f, 0.02473f);
            f2318.AddVertex(-1.35553f, 6.95798f, 0.02421f);
            f2318.AddVertex(-1.33406f, 6.97561f, 0.00986f);
            faces.Add(f2318);

            Face f2319 = new Face(m03___Default);
            f2319.AddVertex(-1.30191f, 6.92666f, 0.09087f);
            f2319.AddVertex(-1.32114f, 6.92611f, 0.11473f);
            f2319.AddVertex(-1.32900f, 6.91759f, 0.09106f);
            faces.Add(f2319);

            Face f2320 = new Face(m03___Default);
            f2320.AddVertex(-1.32114f, 6.92611f, 0.11473f);
            f2320.AddVertex(-1.34402f, 6.93390f, 0.13636f);
            f2320.AddVertex(-1.35068f, 6.92004f, 0.11505f);
            faces.Add(f2320);

            Face f2321 = new Face(m03___Default);
            f2321.AddVertex(-1.32114f, 6.92611f, 0.11473f);
            f2321.AddVertex(-1.35068f, 6.92004f, 0.11505f);
            f2321.AddVertex(-1.32900f, 6.91759f, 0.09106f);
            faces.Add(f2321);

            Face f2322 = new Face(m03___Default);
            f2322.AddVertex(-1.32900f, 6.91759f, 0.09106f);
            f2322.AddVertex(-1.35068f, 6.92004f, 0.11505f);
            f2322.AddVertex(-1.35913f, 6.91751f, 0.09082f);
            faces.Add(f2322);

            Face f2323 = new Face(m03___Default);
            f2323.AddVertex(-1.34402f, 6.93390f, 0.13636f);
            f2323.AddVertex(-1.36881f, 6.94945f, 0.15412f);
            f2323.AddVertex(-1.37679f, 6.93236f, 0.13671f);
            faces.Add(f2323);

            Face f2324 = new Face(m03___Default);
            f2324.AddVertex(-1.34402f, 6.93390f, 0.13636f);
            f2324.AddVertex(-1.37679f, 6.93236f, 0.13671f);
            f2324.AddVertex(-1.35068f, 6.92004f, 0.11505f);
            faces.Add(f2324);

            Face f2325 = new Face(m03___Default);
            f2325.AddVertex(-1.35068f, 6.92004f, 0.11505f);
            f2325.AddVertex(-1.37679f, 6.93236f, 0.13671f);
            f2325.AddVertex(-1.38407f, 6.92445f, 0.11474f);
            faces.Add(f2325);

            Face f2326 = new Face(m03___Default);
            f2326.AddVertex(-1.35068f, 6.92004f, 0.11505f);
            f2326.AddVertex(-1.38407f, 6.92445f, 0.11474f);
            f2326.AddVertex(-1.35913f, 6.91751f, 0.09082f);
            faces.Add(f2326);

            Face f2327 = new Face(m03___Default);
            f2327.AddVertex(-1.35913f, 6.91751f, 0.09082f);
            f2327.AddVertex(-1.38407f, 6.92445f, 0.11474f);
            f2327.AddVertex(-1.39002f, 6.92643f, 0.09017f);
            faces.Add(f2327);

            Face f2328 = new Face(m03___Default);
            f2328.AddVertex(-1.36881f, 6.94945f, 0.15412f);
            f2328.AddVertex(-1.39362f, 6.97157f, 0.16663f);
            f2328.AddVertex(-1.40468f, 6.95465f, 0.15359f);
            faces.Add(f2328);

            Face f2329 = new Face(m03___Default);
            f2329.AddVertex(-1.36881f, 6.94945f, 0.15412f);
            f2329.AddVertex(-1.40468f, 6.95465f, 0.15359f);
            f2329.AddVertex(-1.37679f, 6.93236f, 0.13671f);
            faces.Add(f2329);

            Face f2330 = new Face(m03___Default);
            f2330.AddVertex(-1.37679f, 6.93236f, 0.13671f);
            f2330.AddVertex(-1.40468f, 6.95465f, 0.15359f);
            f2330.AddVertex(-1.41303f, 6.94391f, 0.13536f);
            faces.Add(f2330);

            Face f2331 = new Face(m03___Default);
            f2331.AddVertex(-1.37679f, 6.93236f, 0.13671f);
            f2331.AddVertex(-1.41303f, 6.94391f, 0.13536f);
            f2331.AddVertex(-1.38407f, 6.92445f, 0.11474f);
            faces.Add(f2331);

            Face f2332 = new Face(m03___Default);
            f2332.AddVertex(-1.38407f, 6.92445f, 0.11474f);
            f2332.AddVertex(-1.41303f, 6.94391f, 0.13536f);
            f2332.AddVertex(-1.41804f, 6.94016f, 0.11332f);
            faces.Add(f2332);

            Face f2333 = new Face(m03___Default);
            f2333.AddVertex(-1.38407f, 6.92445f, 0.11474f);
            f2333.AddVertex(-1.41804f, 6.94016f, 0.11332f);
            f2333.AddVertex(-1.39002f, 6.92643f, 0.09017f);
            faces.Add(f2333);

            Face f2334 = new Face(m03___Default);
            f2334.AddVertex(-1.39002f, 6.92643f, 0.09017f);
            f2334.AddVertex(-1.41804f, 6.94016f, 0.11332f);
            f2334.AddVertex(-1.41932f, 6.94368f, 0.08916f);
            faces.Add(f2334);

            Face f2335 = new Face(m03___Default);
            f2335.AddVertex(-1.30191f, 6.92666f, 0.09087f);
            f2335.AddVertex(-1.29024f, 6.94113f, 0.10513f);
            f2335.AddVertex(-1.32114f, 6.92611f, 0.11473f);
            faces.Add(f2335);

            Face f2336 = new Face(m03___Default);
            f2336.AddVertex(-1.29024f, 6.94113f, 0.10513f);
            f2336.AddVertex(-1.28458f, 6.96280f, 0.11789f);
            f2336.AddVertex(-1.31148f, 6.94385f, 0.12927f);
            faces.Add(f2336);

            Face f2337 = new Face(m03___Default);
            f2337.AddVertex(-1.29024f, 6.94113f, 0.10513f);
            f2337.AddVertex(-1.31148f, 6.94385f, 0.12927f);
            f2337.AddVertex(-1.32114f, 6.92611f, 0.11473f);
            faces.Add(f2337);

            Face f2338 = new Face(m03___Default);
            f2338.AddVertex(-1.32114f, 6.92611f, 0.11473f);
            f2338.AddVertex(-1.31148f, 6.94385f, 0.12927f);
            f2338.AddVertex(-1.34402f, 6.93390f, 0.13636f);
            faces.Add(f2338);

            Face f2339 = new Face(m03___Default);
            f2339.AddVertex(-1.28458f, 6.96280f, 0.11789f);
            f2339.AddVertex(-1.28534f, 6.99003f, 0.12819f);
            f2339.AddVertex(-1.30865f, 6.97027f, 0.14213f);
            faces.Add(f2339);

            Face f2340 = new Face(m03___Default);
            f2340.AddVertex(-1.28458f, 6.96280f, 0.11789f);
            f2340.AddVertex(-1.30865f, 6.97027f, 0.14213f);
            f2340.AddVertex(-1.31148f, 6.94385f, 0.12927f);
            faces.Add(f2340);

            Face f2341 = new Face(m03___Default);
            f2341.AddVertex(-1.31148f, 6.94385f, 0.12927f);
            f2341.AddVertex(-1.30865f, 6.97027f, 0.14213f);
            f2341.AddVertex(-1.33732f, 6.95634f, 0.15104f);
            faces.Add(f2341);

            Face f2342 = new Face(m03___Default);
            f2342.AddVertex(-1.31148f, 6.94385f, 0.12927f);
            f2342.AddVertex(-1.33732f, 6.95634f, 0.15104f);
            f2342.AddVertex(-1.34402f, 6.93390f, 0.13636f);
            faces.Add(f2342);

            Face f2343 = new Face(m03___Default);
            f2343.AddVertex(-1.34402f, 6.93390f, 0.13636f);
            f2343.AddVertex(-1.33732f, 6.95634f, 0.15104f);
            f2343.AddVertex(-1.36881f, 6.94945f, 0.15412f);
            faces.Add(f2343);

            Face f2344 = new Face(m03___Default);
            f2344.AddVertex(-1.28534f, 6.99003f, 0.12819f);
            f2344.AddVertex(-1.29248f, 7.02074f, 0.13521f);
            f2344.AddVertex(-1.31336f, 7.00375f, 0.15133f);
            faces.Add(f2344);

            Face f2345 = new Face(m03___Default);
            f2345.AddVertex(-1.28534f, 6.99003f, 0.12819f);
            f2345.AddVertex(-1.31336f, 7.00375f, 0.15133f);
            f2345.AddVertex(-1.30865f, 6.97027f, 0.14213f);
            faces.Add(f2345);

            Face f2346 = new Face(m03___Default);
            f2346.AddVertex(-1.30865f, 6.97027f, 0.14213f);
            f2346.AddVertex(-1.31336f, 7.00375f, 0.15133f);
            f2346.AddVertex(-1.33848f, 6.98920f, 0.16243f);
            faces.Add(f2346);

            Face f2347 = new Face(m03___Default);
            f2347.AddVertex(-1.30865f, 6.97027f, 0.14213f);
            f2347.AddVertex(-1.33848f, 6.98920f, 0.16243f);
            f2347.AddVertex(-1.33732f, 6.95634f, 0.15104f);
            faces.Add(f2347);

            Face f2348 = new Face(m03___Default);
            f2348.AddVertex(-1.33732f, 6.95634f, 0.15104f);
            f2348.AddVertex(-1.33848f, 6.98920f, 0.16243f);
            f2348.AddVertex(-1.36593f, 6.97820f, 0.16767f);
            faces.Add(f2348);

            Face f2349 = new Face(m03___Default);
            f2349.AddVertex(-1.33732f, 6.95634f, 0.15104f);
            f2349.AddVertex(-1.36593f, 6.97820f, 0.16767f);
            f2349.AddVertex(-1.36881f, 6.94945f, 0.15412f);
            faces.Add(f2349);

            Face f2350 = new Face(m03___Default);
            f2350.AddVertex(-1.36881f, 6.94945f, 0.15412f);
            f2350.AddVertex(-1.36593f, 6.97820f, 0.16767f);
            f2350.AddVertex(-1.39362f, 6.97157f, 0.16663f);
            faces.Add(f2350);

            Face f2351 = new Face(m03___Default);
            f2351.AddVertex(-1.30191f, 6.92666f, 0.09087f);
            f2351.AddVertex(-1.27900f, 6.94189f, 0.07553f);
            f2351.AddVertex(-1.29024f, 6.94113f, 0.10513f);
            faces.Add(f2351);

            Face f2352 = new Face(m03___Default);
            f2352.AddVertex(-1.27900f, 6.94189f, 0.07553f);
            f2352.AddVertex(-1.26294f, 6.96427f, 0.06094f);
            f2352.AddVertex(-1.26886f, 6.95982f, 0.08962f);
            faces.Add(f2352);

            Face f2353 = new Face(m03___Default);
            f2353.AddVertex(-1.27900f, 6.94189f, 0.07553f);
            f2353.AddVertex(-1.26886f, 6.95982f, 0.08962f);
            f2353.AddVertex(-1.29024f, 6.94113f, 0.10513f);
            faces.Add(f2353);

            Face f2354 = new Face(m03___Default);
            f2354.AddVertex(-1.29024f, 6.94113f, 0.10513f);
            f2354.AddVertex(-1.26886f, 6.95982f, 0.08962f);
            f2354.AddVertex(-1.28458f, 6.96280f, 0.11789f);
            faces.Add(f2354);

            Face f2355 = new Face(m03___Default);
            f2355.AddVertex(-1.26294f, 6.96427f, 0.06094f);
            f2355.AddVertex(-1.25496f, 6.99209f, 0.04822f);
            f2355.AddVertex(-1.25529f, 6.98706f, 0.07474f);
            faces.Add(f2355);

            Face f2356 = new Face(m03___Default);
            f2356.AddVertex(-1.26294f, 6.96427f, 0.06094f);
            f2356.AddVertex(-1.25529f, 6.98706f, 0.07474f);
            f2356.AddVertex(-1.26886f, 6.95982f, 0.08962f);
            faces.Add(f2356);

            Face f2357 = new Face(m03___Default);
            f2357.AddVertex(-1.26886f, 6.95982f, 0.08962f);
            f2357.AddVertex(-1.25529f, 6.98706f, 0.07474f);
            f2357.AddVertex(-1.26573f, 6.98634f, 0.10221f);
            faces.Add(f2357);

            Face f2358 = new Face(m03___Default);
            f2358.AddVertex(-1.26886f, 6.95982f, 0.08962f);
            f2358.AddVertex(-1.26573f, 6.98634f, 0.10221f);
            f2358.AddVertex(-1.28458f, 6.96280f, 0.11789f);
            faces.Add(f2358);

            Face f2359 = new Face(m03___Default);
            f2359.AddVertex(-1.28458f, 6.96280f, 0.11789f);
            f2359.AddVertex(-1.26573f, 6.98634f, 0.10221f);
            f2359.AddVertex(-1.28534f, 6.99003f, 0.12819f);
            faces.Add(f2359);

            Face f2360 = new Face(m03___Default);
            f2360.AddVertex(-1.25496f, 6.99209f, 0.04822f);
            f2360.AddVertex(-1.25567f, 7.02323f, 0.03832f);
            f2360.AddVertex(-1.25208f, 7.02083f, 0.06177f);
            faces.Add(f2360);

            Face f2361 = new Face(m03___Default);
            f2361.AddVertex(-1.25496f, 6.99209f, 0.04822f);
            f2361.AddVertex(-1.25208f, 7.02083f, 0.06177f);
            f2361.AddVertex(-1.25529f, 6.98706f, 0.07474f);
            faces.Add(f2361);

            Face f2362 = new Face(m03___Default);
            f2362.AddVertex(-1.25529f, 6.98706f, 0.07474f);
            f2362.AddVertex(-1.25208f, 7.02083f, 0.06177f);
            f2362.AddVertex(-1.25740f, 7.01956f, 0.08701f);
            faces.Add(f2362);

            Face f2363 = new Face(m03___Default);
            f2363.AddVertex(-1.25529f, 6.98706f, 0.07474f);
            f2363.AddVertex(-1.25740f, 7.01956f, 0.08701f);
            f2363.AddVertex(-1.26573f, 6.98634f, 0.10221f);
            faces.Add(f2363);

            Face f2364 = new Face(m03___Default);
            f2364.AddVertex(-1.26573f, 6.98634f, 0.10221f);
            f2364.AddVertex(-1.25740f, 7.01956f, 0.08701f);
            f2364.AddVertex(-1.27121f, 7.01954f, 0.11213f);
            faces.Add(f2364);

            Face f2365 = new Face(m03___Default);
            f2365.AddVertex(-1.26573f, 6.98634f, 0.10221f);
            f2365.AddVertex(-1.27121f, 7.01954f, 0.11213f);
            f2365.AddVertex(-1.28534f, 6.99003f, 0.12819f);
            faces.Add(f2365);

            Face f2366 = new Face(m03___Default);
            f2366.AddVertex(-1.28534f, 6.99003f, 0.12819f);
            f2366.AddVertex(-1.27121f, 7.01954f, 0.11213f);
            f2366.AddVertex(-1.29248f, 7.02074f, 0.13521f);
            faces.Add(f2366);

            Face f2367 = new Face(m03___Default);
            f2367.AddVertex(-1.01865f, 7.19450f, 0.08100f);
            f2367.AddVertex(-0.99043f, 7.18977f, 0.08143f);
            f2367.AddVertex(-1.00085f, 7.19034f, 0.05733f);
            faces.Add(f2367);

            Face f2368 = new Face(m03___Default);
            f2368.AddVertex(-0.99043f, 7.18977f, 0.08143f);
            f2368.AddVertex(-0.96440f, 7.17579f, 0.08227f);
            f2368.AddVertex(-0.97212f, 7.18190f, 0.05766f);
            faces.Add(f2368);

            Face f2369 = new Face(m03___Default);
            f2369.AddVertex(-0.99043f, 7.18977f, 0.08143f);
            f2369.AddVertex(-0.97212f, 7.18190f, 0.05766f);
            f2369.AddVertex(-1.00085f, 7.19034f, 0.05733f);
            faces.Add(f2369);

            Face f2370 = new Face(m03___Default);
            f2370.AddVertex(-1.00085f, 7.19034f, 0.05733f);
            f2370.AddVertex(-0.97212f, 7.18190f, 0.05766f);
            f2370.AddVertex(-0.98445f, 7.17688f, 0.03590f);
            faces.Add(f2370);

            Face f2371 = new Face(m03___Default);
            f2371.AddVertex(-0.96440f, 7.17579f, 0.08227f);
            f2371.AddVertex(-0.94255f, 7.15363f, 0.08345f);
            f2371.AddVertex(-0.94568f, 7.16253f, 0.05858f);
            faces.Add(f2371);

            Face f2372 = new Face(m03___Default);
            f2372.AddVertex(-0.96440f, 7.17579f, 0.08227f);
            f2372.AddVertex(-0.94568f, 7.16253f, 0.05858f);
            f2372.AddVertex(-0.97212f, 7.18190f, 0.05766f);
            faces.Add(f2372);

            Face f2373 = new Face(m03___Default);
            f2373.AddVertex(-0.97212f, 7.18190f, 0.05766f);
            f2373.AddVertex(-0.94568f, 7.16253f, 0.05858f);
            f2373.AddVertex(-0.95535f, 7.16306f, 0.03622f);
            faces.Add(f2373);

            Face f2374 = new Face(m03___Default);
            f2374.AddVertex(-0.97212f, 7.18190f, 0.05766f);
            f2374.AddVertex(-0.95535f, 7.16306f, 0.03622f);
            f2374.AddVertex(-0.98445f, 7.17688f, 0.03590f);
            faces.Add(f2374);

            Face f2375 = new Face(m03___Default);
            f2375.AddVertex(-0.98445f, 7.17688f, 0.03590f);
            f2375.AddVertex(-0.95535f, 7.16306f, 0.03622f);
            f2375.AddVertex(-0.97070f, 7.15516f, 0.01834f);
            faces.Add(f2375);

            Face f2376 = new Face(m03___Default);
            f2376.AddVertex(-0.94255f, 7.15363f, 0.08345f);
            f2376.AddVertex(-0.92654f, 7.12499f, 0.08488f);
            f2376.AddVertex(-0.92483f, 7.13296f, 0.06054f);
            faces.Add(f2376);

            Face f2377 = new Face(m03___Default);
            f2377.AddVertex(-0.94255f, 7.15363f, 0.08345f);
            f2377.AddVertex(-0.92483f, 7.13296f, 0.06054f);
            f2377.AddVertex(-0.94568f, 7.16253f, 0.05858f);
            faces.Add(f2377);

            Face f2378 = new Face(m03___Default);
            f2378.AddVertex(-0.94568f, 7.16253f, 0.05858f);
            f2378.AddVertex(-0.92483f, 7.13296f, 0.06054f);
            f2378.AddVertex(-0.93030f, 7.13602f, 0.03818f);
            faces.Add(f2378);

            Face f2379 = new Face(m03___Default);
            f2379.AddVertex(-0.94568f, 7.16253f, 0.05858f);
            f2379.AddVertex(-0.93030f, 7.13602f, 0.03818f);
            f2379.AddVertex(-0.95535f, 7.16306f, 0.03622f);
            faces.Add(f2379);

            Face f2380 = new Face(m03___Default);
            f2380.AddVertex(-0.95535f, 7.16306f, 0.03622f);
            f2380.AddVertex(-0.93030f, 7.13602f, 0.03818f);
            f2380.AddVertex(-0.94256f, 7.13392f, 0.01953f);
            faces.Add(f2380);

            Face f2381 = new Face(m03___Default);
            f2381.AddVertex(-0.95535f, 7.16306f, 0.03622f);
            f2381.AddVertex(-0.94256f, 7.13392f, 0.01953f);
            f2381.AddVertex(-0.97070f, 7.15516f, 0.01834f);
            faces.Add(f2381);

            Face f2382 = new Face(m03___Default);
            f2382.AddVertex(-0.97070f, 7.15516f, 0.01834f);
            f2382.AddVertex(-0.94256f, 7.13392f, 0.01953f);
            f2382.AddVertex(-0.96065f, 7.12684f, 0.00598f);
            faces.Add(f2382);

            Face f2383 = new Face(m03___Default);
            f2383.AddVertex(-1.01865f, 7.19450f, 0.08100f);
            f2383.AddVertex(-1.00085f, 7.19034f, 0.05733f);
            f2383.AddVertex(-1.03591f, 7.19002f, 0.06623f);
            faces.Add(f2383);

            Face f2384 = new Face(m03___Default);
            f2384.AddVertex(-1.00085f, 7.19034f, 0.05733f);
            f2384.AddVertex(-0.98445f, 7.17688f, 0.03590f);
            f2384.AddVertex(-1.01812f, 7.18215f, 0.04229f);
            faces.Add(f2384);

            Face f2385 = new Face(m03___Default);
            f2385.AddVertex(-1.00085f, 7.19034f, 0.05733f);
            f2385.AddVertex(-1.01812f, 7.18215f, 0.04229f);
            f2385.AddVertex(-1.03591f, 7.19002f, 0.06623f);
            faces.Add(f2385);

            Face f2386 = new Face(m03___Default);
            f2386.AddVertex(-1.03591f, 7.19002f, 0.06623f);
            f2386.AddVertex(-1.01812f, 7.18215f, 0.04229f);
            f2386.AddVertex(-1.05190f, 7.17628f, 0.05302f);
            faces.Add(f2386);

            Face f2387 = new Face(m03___Default);
            f2387.AddVertex(-0.98445f, 7.17688f, 0.03590f);
            f2387.AddVertex(-0.97070f, 7.15516f, 0.01834f);
            f2387.AddVertex(-1.00167f, 7.16332f, 0.02074f);
            faces.Add(f2387);

            Face f2388 = new Face(m03___Default);
            f2388.AddVertex(-0.98445f, 7.17688f, 0.03590f);
            f2388.AddVertex(-1.00167f, 7.16332f, 0.02074f);
            f2388.AddVertex(-1.01812f, 7.18215f, 0.04229f);
            faces.Add(f2388);

            Face f2389 = new Face(m03___Default);
            f2389.AddVertex(-1.01812f, 7.18215f, 0.04229f);
            f2389.AddVertex(-1.00167f, 7.16332f, 0.02074f);
            f2389.AddVertex(-1.03420f, 7.16302f, 0.02900f);
            faces.Add(f2389);

            Face f2390 = new Face(m03___Default);
            f2390.AddVertex(-1.01812f, 7.18215f, 0.04229f);
            f2390.AddVertex(-1.03420f, 7.16302f, 0.02900f);
            f2390.AddVertex(-1.05190f, 7.17628f, 0.05302f);
            faces.Add(f2390);

            Face f2391 = new Face(m03___Default);
            f2391.AddVertex(-1.05190f, 7.17628f, 0.05302f);
            f2391.AddVertex(-1.03420f, 7.16302f, 0.02900f);
            f2391.AddVertex(-1.06541f, 7.15431f, 0.04238f);
            faces.Add(f2391);

            Face f2392 = new Face(m03___Default);
            f2392.AddVertex(-0.97070f, 7.15516f, 0.01834f);
            f2392.AddVertex(-0.96065f, 7.12684f, 0.00598f);
            f2392.AddVertex(-0.98804f, 7.13418f, 0.00433f);
            faces.Add(f2392);

            Face f2393 = new Face(m03___Default);
            f2393.AddVertex(-0.97070f, 7.15516f, 0.01834f);
            f2393.AddVertex(-0.98804f, 7.13418f, 0.00433f);
            f2393.AddVertex(-1.00167f, 7.16332f, 0.02074f);
            faces.Add(f2393);

            Face f2394 = new Face(m03___Default);
            f2394.AddVertex(-1.00167f, 7.16332f, 0.02074f);
            f2394.AddVertex(-0.98804f, 7.13418f, 0.00433f);
            f2394.AddVertex(-1.01781f, 7.13651f, 0.00894f);
            faces.Add(f2394);

            Face f2395 = new Face(m03___Default);
            f2395.AddVertex(-1.00167f, 7.16332f, 0.02074f);
            f2395.AddVertex(-1.01781f, 7.13651f, 0.00894f);
            f2395.AddVertex(-1.03420f, 7.16302f, 0.02900f);
            faces.Add(f2395);

            Face f2396 = new Face(m03___Default);
            f2396.AddVertex(-1.03420f, 7.16302f, 0.02900f);
            f2396.AddVertex(-1.01781f, 7.13651f, 0.00894f);
            f2396.AddVertex(-1.04768f, 7.13364f, 0.01947f);
            faces.Add(f2396);

            Face f2397 = new Face(m03___Default);
            f2397.AddVertex(-1.03420f, 7.16302f, 0.02900f);
            f2397.AddVertex(-1.04768f, 7.13364f, 0.01947f);
            f2397.AddVertex(-1.06541f, 7.15431f, 0.04238f);
            faces.Add(f2397);

            Face f2398 = new Face(m03___Default);
            f2398.AddVertex(-1.06541f, 7.15431f, 0.04238f);
            f2398.AddVertex(-1.04768f, 7.13364f, 0.01947f);
            f2398.AddVertex(-1.07540f, 7.12581f, 0.03511f);
            faces.Add(f2398);

            Face f2399 = new Face(m03___Default);
            f2399.AddVertex(-1.01865f, 7.19450f, 0.08100f);
            f2399.AddVertex(-1.03591f, 7.19002f, 0.06623f);
            f2399.AddVertex(-1.04715f, 7.18926f, 0.09583f);
            faces.Add(f2399);

            Face f2400 = new Face(m03___Default);
            f2400.AddVertex(-1.03591f, 7.19002f, 0.06623f);
            f2400.AddVertex(-1.05190f, 7.17628f, 0.05302f);
            f2400.AddVertex(-1.06495f, 7.18106f, 0.08123f);
            faces.Add(f2400);

            Face f2401 = new Face(m03___Default);
            f2401.AddVertex(-1.03591f, 7.19002f, 0.06623f);
            f2401.AddVertex(-1.06495f, 7.18106f, 0.08123f);
            f2401.AddVertex(-1.04715f, 7.18926f, 0.09583f);
            faces.Add(f2401);

            Face f2402 = new Face(m03___Default);
            f2402.AddVertex(-1.04715f, 7.18926f, 0.09583f);
            f2402.AddVertex(-1.06495f, 7.18106f, 0.08123f);
            f2402.AddVertex(-1.07353f, 7.17481f, 0.10998f);
            faces.Add(f2402);

            Face f2403 = new Face(m03___Default);
            f2403.AddVertex(-1.05190f, 7.17628f, 0.05302f);
            f2403.AddVertex(-1.06541f, 7.15431f, 0.04238f);
            f2403.AddVertex(-1.08135f, 7.16192f, 0.06821f);
            faces.Add(f2403);

            Face f2404 = new Face(m03___Default);
            f2404.AddVertex(-1.05190f, 7.17628f, 0.05302f);
            f2404.AddVertex(-1.08135f, 7.16192f, 0.06821f);
            f2404.AddVertex(-1.06495f, 7.18106f, 0.08123f);
            faces.Add(f2404);

            Face f2405 = new Face(m03___Default);
            f2405.AddVertex(-1.06495f, 7.18106f, 0.08123f);
            f2405.AddVertex(-1.08135f, 7.16192f, 0.06821f);
            f2405.AddVertex(-1.09179f, 7.16122f, 0.09568f);
            faces.Add(f2405);

            Face f2406 = new Face(m03___Default);
            f2406.AddVertex(-1.06495f, 7.18106f, 0.08123f);
            f2406.AddVertex(-1.09179f, 7.16122f, 0.09568f);
            f2406.AddVertex(-1.07353f, 7.17481f, 0.10998f);
            faces.Add(f2406);

            Face f2407 = new Face(m03___Default);
            f2407.AddVertex(-1.07353f, 7.17481f, 0.10998f);
            f2407.AddVertex(-1.09179f, 7.16122f, 0.09568f);
            f2407.AddVertex(-1.09579f, 7.15226f, 0.12235f);
            faces.Add(f2407);

            Face f2408 = new Face(m03___Default);
            f2408.AddVertex(-1.06541f, 7.15431f, 0.04238f);
            f2408.AddVertex(-1.07540f, 7.12581f, 0.03511f);
            f2408.AddVertex(-1.09399f, 7.13256f, 0.05797f);
            faces.Add(f2408);

            Face f2409 = new Face(m03___Default);
            f2409.AddVertex(-1.06541f, 7.15431f, 0.04238f);
            f2409.AddVertex(-1.09399f, 7.13256f, 0.05797f);
            f2409.AddVertex(-1.08135f, 7.16192f, 0.06821f);
            faces.Add(f2409);

            Face f2410 = new Face(m03___Default);
            f2410.AddVertex(-1.08135f, 7.16192f, 0.06821f);
            f2410.AddVertex(-1.09399f, 7.13256f, 0.05797f);
            f2410.AddVertex(-1.10689f, 7.13443f, 0.08301f);
            faces.Add(f2410);

            Face f2411 = new Face(m03___Default);
            f2411.AddVertex(-1.08135f, 7.16192f, 0.06821f);
            f2411.AddVertex(-1.10689f, 7.13443f, 0.08301f);
            f2411.AddVertex(-1.09179f, 7.16122f, 0.09568f);
            faces.Add(f2411);

            Face f2412 = new Face(m03___Default);
            f2412.AddVertex(-1.09179f, 7.16122f, 0.09568f);
            f2412.AddVertex(-1.10689f, 7.13443f, 0.08301f);
            f2412.AddVertex(-1.11312f, 7.13127f, 0.10833f);
            faces.Add(f2412);

            Face f2413 = new Face(m03___Default);
            f2413.AddVertex(-1.09179f, 7.16122f, 0.09568f);
            f2413.AddVertex(-1.11312f, 7.13127f, 0.10833f);
            f2413.AddVertex(-1.09579f, 7.15226f, 0.12235f);
            faces.Add(f2413);

            Face f2414 = new Face(m03___Default);
            f2414.AddVertex(-1.09579f, 7.15226f, 0.12235f);
            f2414.AddVertex(-1.11312f, 7.13127f, 0.10833f);
            f2414.AddVertex(-1.11221f, 7.12332f, 0.13201f);
            faces.Add(f2414);

            Face f2415 = new Face(m03___Default);
            f2415.AddVertex(-1.01865f, 7.19450f, 0.08100f);
            f2415.AddVertex(-1.04715f, 7.18926f, 0.09583f);
            f2415.AddVertex(-1.01905f, 7.18910f, 0.10523f);
            faces.Add(f2415);

            Face f2416 = new Face(m03___Default);
            f2416.AddVertex(-1.04715f, 7.18926f, 0.09583f);
            f2416.AddVertex(-1.07353f, 7.17481f, 0.10998f);
            f2416.AddVertex(-1.04790f, 7.18013f, 0.12068f);
            faces.Add(f2416);

            Face f2417 = new Face(m03___Default);
            f2417.AddVertex(-1.04715f, 7.18926f, 0.09583f);
            f2417.AddVertex(-1.04790f, 7.18013f, 0.12068f);
            f2417.AddVertex(-1.01905f, 7.18910f, 0.10523f);
            faces.Add(f2417);

            Face f2418 = new Face(m03___Default);
            f2418.AddVertex(-1.01905f, 7.18910f, 0.10523f);
            f2418.AddVertex(-1.04790f, 7.18013f, 0.12068f);
            f2418.AddVertex(-1.01946f, 7.17451f, 0.12805f);
            faces.Add(f2418);

            Face f2419 = new Face(m03___Default);
            f2419.AddVertex(-1.07353f, 7.17481f, 0.10998f);
            f2419.AddVertex(-1.09579f, 7.15226f, 0.12235f);
            f2419.AddVertex(-1.07462f, 7.16028f, 0.13540f);
            faces.Add(f2419);

            Face f2420 = new Face(m03___Default);
            f2420.AddVertex(-1.07353f, 7.17481f, 0.10998f);
            f2420.AddVertex(-1.07462f, 7.16028f, 0.13540f);
            f2420.AddVertex(-1.04790f, 7.18013f, 0.12068f);
            faces.Add(f2420);

            Face f2421 = new Face(m03___Default);
            f2421.AddVertex(-1.04790f, 7.18013f, 0.12068f);
            f2421.AddVertex(-1.07462f, 7.16028f, 0.13540f);
            f2421.AddVertex(-1.04853f, 7.16014f, 0.14411f);
            faces.Add(f2421);

            Face f2422 = new Face(m03___Default);
            f2422.AddVertex(-1.04790f, 7.18013f, 0.12068f);
            f2422.AddVertex(-1.04853f, 7.16014f, 0.14411f);
            f2422.AddVertex(-1.01946f, 7.17451f, 0.12805f);
            faces.Add(f2422);

            Face f2423 = new Face(m03___Default);
            f2423.AddVertex(-1.01946f, 7.17451f, 0.12805f);
            f2423.AddVertex(-1.04853f, 7.16014f, 0.14411f);
            f2423.AddVertex(-1.01985f, 7.15184f, 0.14773f);
            faces.Add(f2423);

            Face f2424 = new Face(m03___Default);
            f2424.AddVertex(-1.09579f, 7.15226f, 0.12235f);
            f2424.AddVertex(-1.11221f, 7.12332f, 0.13201f);
            f2424.AddVertex(-1.09626f, 7.13035f, 0.14733f);
            faces.Add(f2424);

            Face f2425 = new Face(m03___Default);
            f2425.AddVertex(-1.09579f, 7.15226f, 0.12235f);
            f2425.AddVertex(-1.09626f, 7.13035f, 0.14733f);
            f2425.AddVertex(-1.07462f, 7.16028f, 0.13540f);
            faces.Add(f2425);

            Face f2426 = new Face(m03___Default);
            f2426.AddVertex(-1.07462f, 7.16028f, 0.13540f);
            f2426.AddVertex(-1.09626f, 7.13035f, 0.14733f);
            f2426.AddVertex(-1.07445f, 7.13267f, 0.15804f);
            faces.Add(f2426);

            Face f2427 = new Face(m03___Default);
            f2427.AddVertex(-1.07462f, 7.16028f, 0.13540f);
            f2427.AddVertex(-1.07445f, 7.13267f, 0.15804f);
            f2427.AddVertex(-1.04853f, 7.16014f, 0.14411f);
            faces.Add(f2427);

            Face f2428 = new Face(m03___Default);
            f2428.AddVertex(-1.04853f, 7.16014f, 0.14411f);
            f2428.AddVertex(-1.07445f, 7.13267f, 0.15804f);
            f2428.AddVertex(-1.04844f, 7.13009f, 0.16331f);
            faces.Add(f2428);

            Face f2429 = new Face(m03___Default);
            f2429.AddVertex(-1.04853f, 7.16014f, 0.14411f);
            f2429.AddVertex(-1.04844f, 7.13009f, 0.16331f);
            f2429.AddVertex(-1.01985f, 7.15184f, 0.14773f);
            faces.Add(f2429);

            Face f2430 = new Face(m03___Default);
            f2430.AddVertex(-1.01985f, 7.15184f, 0.14773f);
            f2430.AddVertex(-1.04844f, 7.13009f, 0.16331f);
            f2430.AddVertex(-1.02021f, 7.12281f, 0.16276f);
            faces.Add(f2430);

            Face f2431 = new Face(m03___Default);
            f2431.AddVertex(-1.01865f, 7.19450f, 0.08100f);
            f2431.AddVertex(-1.01905f, 7.18910f, 0.10523f);
            f2431.AddVertex(-0.99043f, 7.18977f, 0.08143f);
            faces.Add(f2431);

            Face f2432 = new Face(m03___Default);
            f2432.AddVertex(-1.01905f, 7.18910f, 0.10523f);
            f2432.AddVertex(-1.01946f, 7.17451f, 0.12805f);
            f2432.AddVertex(-0.99052f, 7.18065f, 0.10611f);
            faces.Add(f2432);

            Face f2433 = new Face(m03___Default);
            f2433.AddVertex(-1.01905f, 7.18910f, 0.10523f);
            f2433.AddVertex(-0.99052f, 7.18065f, 0.10611f);
            f2433.AddVertex(-0.99043f, 7.18977f, 0.08143f);
            faces.Add(f2433);

            Face f2434 = new Face(m03___Default);
            f2434.AddVertex(-0.99043f, 7.18977f, 0.08143f);
            f2434.AddVertex(-0.99052f, 7.18065f, 0.10611f);
            f2434.AddVertex(-0.96440f, 7.17579f, 0.08227f);
            faces.Add(f2434);

            Face f2435 = new Face(m03___Default);
            f2435.AddVertex(-1.01946f, 7.17451f, 0.12805f);
            f2435.AddVertex(-1.01985f, 7.15184f, 0.14773f);
            f2435.AddVertex(-0.99077f, 7.16066f, 0.12944f);
            faces.Add(f2435);

            Face f2436 = new Face(m03___Default);
            f2436.AddVertex(-1.01946f, 7.17451f, 0.12805f);
            f2436.AddVertex(-0.99077f, 7.16066f, 0.12944f);
            f2436.AddVertex(-0.99052f, 7.18065f, 0.10611f);
            faces.Add(f2436);

            Face f2437 = new Face(m03___Default);
            f2437.AddVertex(-0.99052f, 7.18065f, 0.10611f);
            f2437.AddVertex(-0.99077f, 7.16066f, 0.12944f);
            f2437.AddVertex(-0.96421f, 7.16127f, 0.10737f);
            faces.Add(f2437);

            Face f2438 = new Face(m03___Default);
            f2438.AddVertex(-0.99052f, 7.18065f, 0.10611f);
            f2438.AddVertex(-0.96421f, 7.16127f, 0.10737f);
            f2438.AddVertex(-0.96440f, 7.17579f, 0.08227f);
            faces.Add(f2438);

            Face f2439 = new Face(m03___Default);
            f2439.AddVertex(-0.96440f, 7.17579f, 0.08227f);
            f2439.AddVertex(-0.96421f, 7.16127f, 0.10737f);
            f2439.AddVertex(-0.94255f, 7.15363f, 0.08345f);
            faces.Add(f2439);

            Face f2440 = new Face(m03___Default);
            f2440.AddVertex(-1.01985f, 7.15184f, 0.14773f);
            f2440.AddVertex(-1.02021f, 7.12281f, 0.16276f);
            f2440.AddVertex(-0.99171f, 7.13060f, 0.14891f);
            faces.Add(f2440);

            Face f2441 = new Face(m03___Default);
            f2441.AddVertex(-1.01985f, 7.15184f, 0.14773f);
            f2441.AddVertex(-0.99171f, 7.13060f, 0.14891f);
            f2441.AddVertex(-0.99077f, 7.16066f, 0.12944f);
            faces.Add(f2441);

            Face f2442 = new Face(m03___Default);
            f2442.AddVertex(-0.99077f, 7.16066f, 0.12944f);
            f2442.AddVertex(-0.99171f, 7.13060f, 0.14891f);
            f2442.AddVertex(-0.96531f, 7.13365f, 0.13033f);
            faces.Add(f2442);

            Face f2443 = new Face(m03___Default);
            f2443.AddVertex(-0.99077f, 7.16066f, 0.12944f);
            f2443.AddVertex(-0.96531f, 7.13365f, 0.13033f);
            f2443.AddVertex(-0.96421f, 7.16127f, 0.10737f);
            faces.Add(f2443);

            Face f2444 = new Face(m03___Default);
            f2444.AddVertex(-0.96421f, 7.16127f, 0.10737f);
            f2444.AddVertex(-0.96531f, 7.13365f, 0.13033f);
            f2444.AddVertex(-0.94302f, 7.13173f, 0.10843f);
            faces.Add(f2444);

            Face f2445 = new Face(m03___Default);
            f2445.AddVertex(-0.96421f, 7.16127f, 0.10737f);
            f2445.AddVertex(-0.94302f, 7.13173f, 0.10843f);
            f2445.AddVertex(-0.94255f, 7.15363f, 0.08345f);
            faces.Add(f2445);

            Face f2446 = new Face(m03___Default);
            f2446.AddVertex(-0.94255f, 7.15363f, 0.08345f);
            f2446.AddVertex(-0.94302f, 7.13173f, 0.10843f);
            f2446.AddVertex(-0.92654f, 7.12499f, 0.08488f);
            faces.Add(f2446);

            Face f2447 = new Face(m03___Default);
            f2447.AddVertex(-0.92654f, 7.12499f, 0.08488f);
            f2447.AddVertex(-0.92560f, 7.09752f, 0.10096f);
            f2447.AddVertex(-0.91435f, 7.09829f, 0.07135f);
            faces.Add(f2447);

            Face f2448 = new Face(m03___Default);
            f2448.AddVertex(-0.92560f, 7.09752f, 0.10096f);
            f2448.AddVertex(-0.93179f, 7.06784f, 0.11595f);
            f2448.AddVertex(-0.91591f, 7.06858f, 0.08751f);
            faces.Add(f2448);

            Face f2449 = new Face(m03___Default);
            f2449.AddVertex(-0.92560f, 7.09752f, 0.10096f);
            f2449.AddVertex(-0.91591f, 7.06858f, 0.08751f);
            f2449.AddVertex(-0.91435f, 7.09829f, 0.07135f);
            faces.Add(f2449);

            Face f2450 = new Face(m03___Default);
            f2450.AddVertex(-0.91435f, 7.09829f, 0.07135f);
            f2450.AddVertex(-0.91591f, 7.06858f, 0.08751f);
            f2450.AddVertex(-0.91015f, 7.06931f, 0.05900f);
            faces.Add(f2450);

            Face f2451 = new Face(m03___Default);
            f2451.AddVertex(-0.93179f, 7.06784f, 0.11595f);
            f2451.AddVertex(-0.94463f, 7.03819f, 0.12872f);
            f2451.AddVertex(-0.92590f, 7.03603f, 0.10267f);
            faces.Add(f2451);

            Face f2452 = new Face(m03___Default);
            f2452.AddVertex(-0.93179f, 7.06784f, 0.11595f);
            f2452.AddVertex(-0.92590f, 7.03603f, 0.10267f);
            f2452.AddVertex(-0.91591f, 7.06858f, 0.08751f);
            faces.Add(f2452);

            Face f2453 = new Face(m03___Default);
            f2453.AddVertex(-0.91591f, 7.06858f, 0.08751f);
            f2453.AddVertex(-0.92590f, 7.03603f, 0.10267f);
            f2453.AddVertex(-0.91546f, 7.03673f, 0.07520f);
            faces.Add(f2453);

            Face f2454 = new Face(m03___Default);
            f2454.AddVertex(-0.91591f, 7.06858f, 0.08751f);
            f2454.AddVertex(-0.91546f, 7.03673f, 0.07520f);
            f2454.AddVertex(-0.91015f, 7.06931f, 0.05900f);
            faces.Add(f2454);

            Face f2455 = new Face(m03___Default);
            f2455.AddVertex(-0.91015f, 7.06931f, 0.05900f);
            f2455.AddVertex(-0.91546f, 7.03673f, 0.07520f);
            f2455.AddVertex(-0.91426f, 7.04025f, 0.04875f);
            faces.Add(f2455);

            Face f2456 = new Face(m03___Default);
            f2456.AddVertex(-0.94463f, 7.03819f, 0.12872f);
            f2456.AddVertex(-0.96317f, 7.01084f, 0.13829f);
            f2456.AddVertex(-0.94458f, 7.00408f, 0.11544f);
            faces.Add(f2456);

            Face f2457 = new Face(m03___Default);
            f2457.AddVertex(-0.94463f, 7.03819f, 0.12872f);
            f2457.AddVertex(-0.94458f, 7.00408f, 0.11544f);
            f2457.AddVertex(-0.92590f, 7.03603f, 0.10267f);
            faces.Add(f2457);

            Face f2458 = new Face(m03___Default);
            f2458.AddVertex(-0.92590f, 7.03603f, 0.10267f);
            f2458.AddVertex(-0.94458f, 7.00408f, 0.11544f);
            f2458.AddVertex(-0.93168f, 7.00221f, 0.09039f);
            faces.Add(f2458);

            Face f2459 = new Face(m03___Default);
            f2459.AddVertex(-0.92590f, 7.03603f, 0.10267f);
            f2459.AddVertex(-0.93168f, 7.00221f, 0.09039f);
            f2459.AddVertex(-0.91546f, 7.03673f, 0.07520f);
            faces.Add(f2459);

            Face f2460 = new Face(m03___Default);
            f2460.AddVertex(-0.91546f, 7.03673f, 0.07520f);
            f2460.AddVertex(-0.93168f, 7.00221f, 0.09039f);
            f2460.AddVertex(-0.92545f, 7.00537f, 0.06507f);
            faces.Add(f2460);

            Face f2461 = new Face(m03___Default);
            f2461.AddVertex(-0.91546f, 7.03673f, 0.07520f);
            f2461.AddVertex(-0.92545f, 7.00537f, 0.06507f);
            f2461.AddVertex(-0.91426f, 7.04025f, 0.04875f);
            faces.Add(f2461);

            Face f2462 = new Face(m03___Default);
            f2462.AddVertex(-0.91426f, 7.04025f, 0.04875f);
            f2462.AddVertex(-0.92545f, 7.00537f, 0.06507f);
            f2462.AddVertex(-0.92636f, 7.01333f, 0.04139f);
            faces.Add(f2462);

            Face f2463 = new Face(m03___Default);
            f2463.AddVertex(-0.96065f, 7.12684f, 0.00598f);
            f2463.AddVertex(-0.94251f, 7.09982f, 0.00624f);
            f2463.AddVertex(-0.97061f, 7.09997f, -0.00314f);
            faces.Add(f2463);

            Face f2464 = new Face(m03___Default);
            f2464.AddVertex(-0.94251f, 7.09982f, 0.00624f);
            f2464.AddVertex(-0.93020f, 7.07039f, 0.01263f);
            f2464.AddVertex(-0.95404f, 7.07066f, -0.00068f);
            faces.Add(f2464);

            Face f2465 = new Face(m03___Default);
            f2465.AddVertex(-0.94251f, 7.09982f, 0.00624f);
            f2465.AddVertex(-0.95404f, 7.07066f, -0.00068f);
            f2465.AddVertex(-0.97061f, 7.09997f, -0.00314f);
            faces.Add(f2465);

            Face f2466 = new Face(m03___Default);
            f2466.AddVertex(-0.97061f, 7.09997f, -0.00314f);
            f2466.AddVertex(-0.95404f, 7.07066f, -0.00068f);
            f2466.AddVertex(-0.98428f, 7.07069f, -0.00544f);
            faces.Add(f2466);

            Face f2467 = new Face(m03___Default);
            f2467.AddVertex(-0.93020f, 7.07039f, 0.01263f);
            f2467.AddVertex(-0.92468f, 7.04082f, 0.02465f);
            f2467.AddVertex(-0.94408f, 7.03829f, 0.00903f);
            faces.Add(f2467);

            Face f2468 = new Face(m03___Default);
            f2468.AddVertex(-0.93020f, 7.07039f, 0.01263f);
            f2468.AddVertex(-0.94408f, 7.03829f, 0.00903f);
            f2468.AddVertex(-0.95404f, 7.07066f, -0.00068f);
            faces.Add(f2468);

            Face f2469 = new Face(m03___Default);
            f2469.AddVertex(-0.95404f, 7.07066f, -0.00068f);
            f2469.AddVertex(-0.94408f, 7.03829f, 0.00903f);
            f2469.AddVertex(-0.97016f, 7.03844f, 0.00031f);
            faces.Add(f2469);

            Face f2470 = new Face(m03___Default);
            f2470.AddVertex(-0.95404f, 7.07066f, -0.00068f);
            f2470.AddVertex(-0.97016f, 7.03844f, 0.00031f);
            f2470.AddVertex(-0.98428f, 7.07069f, -0.00544f);
            faces.Add(f2470);

            Face f2471 = new Face(m03___Default);
            f2471.AddVertex(-0.98428f, 7.07069f, -0.00544f);
            f2471.AddVertex(-0.97016f, 7.03844f, 0.00031f);
            f2471.AddVertex(-1.00060f, 7.04124f, -0.00072f);
            faces.Add(f2471);

            Face f2472 = new Face(m03___Default);
            f2472.AddVertex(-0.92468f, 7.04082f, 0.02465f);
            f2472.AddVertex(-0.92636f, 7.01333f, 0.04139f);
            f2472.AddVertex(-0.94231f, 7.00629f, 0.02607f);
            faces.Add(f2472);

            Face f2473 = new Face(m03___Default);
            f2473.AddVertex(-0.92468f, 7.04082f, 0.02465f);
            f2473.AddVertex(-0.94231f, 7.00629f, 0.02607f);
            f2473.AddVertex(-0.94408f, 7.03829f, 0.00903f);
            faces.Add(f2473);

            Face f2474 = new Face(m03___Default);
            f2474.AddVertex(-0.94408f, 7.03829f, 0.00903f);
            f2474.AddVertex(-0.94231f, 7.00629f, 0.02607f);
            f2474.AddVertex(-0.96412f, 7.00397f, 0.01536f);
            faces.Add(f2474);

            Face f2475 = new Face(m03___Default);
            f2475.AddVertex(-0.94408f, 7.03829f, 0.00903f);
            f2475.AddVertex(-0.96412f, 7.00397f, 0.01536f);
            f2475.AddVertex(-0.97016f, 7.03844f, 0.00031f);
            faces.Add(f2475);

            Face f2476 = new Face(m03___Default);
            f2476.AddVertex(-0.97016f, 7.03844f, 0.00031f);
            f2476.AddVertex(-0.96412f, 7.00397f, 0.01536f);
            f2476.AddVertex(-0.99013f, 7.00656f, 0.01009f);
            faces.Add(f2476);

            Face f2477 = new Face(m03___Default);
            f2477.AddVertex(-0.97016f, 7.03844f, 0.00031f);
            f2477.AddVertex(-0.99013f, 7.00656f, 0.01009f);
            f2477.AddVertex(-1.00060f, 7.04124f, -0.00072f);
            faces.Add(f2477);

            Face f2478 = new Face(m03___Default);
            f2478.AddVertex(-1.00060f, 7.04124f, -0.00072f);
            f2478.AddVertex(-0.99013f, 7.00656f, 0.01009f);
            f2478.AddVertex(-1.01836f, 7.01384f, 0.01064f);
            faces.Add(f2478);

            Face f2479 = new Face(m03___Default);
            f2479.AddVertex(-1.07540f, 7.12581f, 0.03511f);
            f2479.AddVertex(-1.06531f, 7.09912f, 0.02089f);
            f2479.AddVertex(-1.09393f, 7.09846f, 0.04468f);
            faces.Add(f2479);

            Face f2480 = new Face(m03___Default);
            f2480.AddVertex(-1.06531f, 7.09912f, 0.02089f);
            f2480.AddVertex(-1.05173f, 7.07009f, 0.01167f);
            f2480.AddVertex(-1.08234f, 7.06951f, 0.03188f);
            faces.Add(f2480);

            Face f2481 = new Face(m03___Default);
            f2481.AddVertex(-1.06531f, 7.09912f, 0.02089f);
            f2481.AddVertex(-1.08234f, 7.06951f, 0.03188f);
            f2481.AddVertex(-1.09393f, 7.09846f, 0.04468f);
            faces.Add(f2481);

            Face f2482 = new Face(m03___Default);
            f2482.AddVertex(-1.09393f, 7.09846f, 0.04468f);
            f2482.AddVertex(-1.08234f, 7.06951f, 0.03188f);
            f2482.AddVertex(-1.10678f, 7.06881f, 0.05746f);
            faces.Add(f2482);

            Face f2483 = new Face(m03___Default);
            f2483.AddVertex(-1.05173f, 7.07009f, 0.01167f);
            f2483.AddVertex(-1.03566f, 7.04092f, 0.00817f);
            f2483.AddVertex(-1.06641f, 7.03757f, 0.02474f);
            faces.Add(f2483);

            Face f2484 = new Face(m03___Default);
            f2484.AddVertex(-1.05173f, 7.07009f, 0.01167f);
            f2484.AddVertex(-1.06641f, 7.03757f, 0.02474f);
            f2484.AddVertex(-1.08234f, 7.06951f, 0.03188f);
            faces.Add(f2484);

            Face f2485 = new Face(m03___Default);
            f2485.AddVertex(-1.08234f, 7.06951f, 0.03188f);
            f2485.AddVertex(-1.06641f, 7.03757f, 0.02474f);
            f2485.AddVertex(-1.09296f, 7.03695f, 0.04682f);
            faces.Add(f2485);

            Face f2486 = new Face(m03___Default);
            f2486.AddVertex(-1.08234f, 7.06951f, 0.03188f);
            f2486.AddVertex(-1.09296f, 7.03695f, 0.04682f);
            f2486.AddVertex(-1.10678f, 7.06881f, 0.05746f);
            faces.Add(f2486);

            Face f2487 = new Face(m03___Default);
            f2487.AddVertex(-1.10678f, 7.06881f, 0.05746f);
            f2487.AddVertex(-1.09296f, 7.03695f, 0.04682f);
            f2487.AddVertex(-1.11297f, 7.03912f, 0.07245f);
            faces.Add(f2487);

            Face f2488 = new Face(m03___Default);
            f2488.AddVertex(-1.03566f, 7.04092f, 0.00817f);
            f2488.AddVertex(-1.01836f, 7.01384f, 0.01064f);
            f2488.AddVertex(-1.04686f, 7.00605f, 0.02449f);
            faces.Add(f2488);

            Face f2489 = new Face(m03___Default);
            f2489.AddVertex(-1.03566f, 7.04092f, 0.00817f);
            f2489.AddVertex(-1.04686f, 7.00605f, 0.02449f);
            f2489.AddVertex(-1.06641f, 7.03757f, 0.02474f);
            faces.Add(f2489);

            Face f2490 = new Face(m03___Default);
            f2490.AddVertex(-1.06641f, 7.03757f, 0.02474f);
            f2490.AddVertex(-1.04686f, 7.00605f, 0.02449f);
            f2490.AddVertex(-1.07325f, 7.00299f, 0.04307f);
            faces.Add(f2490);

            Face f2491 = new Face(m03___Default);
            f2491.AddVertex(-1.06641f, 7.03757f, 0.02474f);
            f2491.AddVertex(-1.07325f, 7.00299f, 0.04307f);
            f2491.AddVertex(-1.09296f, 7.03695f, 0.04682f);
            faces.Add(f2491);

            Face f2492 = new Face(m03___Default);
            f2492.AddVertex(-1.09296f, 7.03695f, 0.04682f);
            f2492.AddVertex(-1.07325f, 7.00299f, 0.04307f);
            f2492.AddVertex(-1.09554f, 7.00491f, 0.06497f);
            faces.Add(f2492);

            Face f2493 = new Face(m03___Default);
            f2493.AddVertex(-1.09296f, 7.03695f, 0.04682f);
            f2493.AddVertex(-1.09554f, 7.00491f, 0.06497f);
            f2493.AddVertex(-1.11297f, 7.03912f, 0.07245f);
            faces.Add(f2493);

            Face f2494 = new Face(m03___Default);
            f2494.AddVertex(-1.11297f, 7.03912f, 0.07245f);
            f2494.AddVertex(-1.09554f, 7.00491f, 0.06497f);
            f2494.AddVertex(-1.11202f, 7.01166f, 0.08853f);
            faces.Add(f2494);

            Face f2495 = new Face(m03___Default);
            f2495.AddVertex(-1.11221f, 7.12332f, 0.13201f);
            f2495.AddVertex(-1.12431f, 7.09640f, 0.12465f);
            f2495.AddVertex(-1.11389f, 7.09583f, 0.14876f);
            faces.Add(f2495);

            Face f2496 = new Face(m03___Default);
            f2496.AddVertex(-1.12431f, 7.09640f, 0.12465f);
            f2496.AddVertex(-1.12842f, 7.06734f, 0.11440f);
            f2496.AddVertex(-1.12349f, 7.06672f, 0.14021f);
            faces.Add(f2496);

            Face f2497 = new Face(m03___Default);
            f2497.AddVertex(-1.12431f, 7.09640f, 0.12465f);
            f2497.AddVertex(-1.12349f, 7.06672f, 0.14021f);
            f2497.AddVertex(-1.11389f, 7.09583f, 0.14876f);
            faces.Add(f2497);

            Face f2498 = new Face(m03___Default);
            f2498.AddVertex(-1.11389f, 7.09583f, 0.14876f);
            f2498.AddVertex(-1.12349f, 7.06672f, 0.14021f);
            f2498.AddVertex(-1.10836f, 7.06625f, 0.16077f);
            faces.Add(f2498);

            Face f2499 = new Face(m03___Default);
            f2499.AddVertex(-1.12842f, 7.06734f, 0.11440f);
            f2499.AddVertex(-1.12422f, 7.03836f, 0.10205f);
            f2499.AddVertex(-1.12383f, 7.03486f, 0.12810f);
            faces.Add(f2499);

            Face f2500 = new Face(m03___Default);
            f2500.AddVertex(-1.12842f, 7.06734f, 0.11440f);
            f2500.AddVertex(-1.12383f, 7.03486f, 0.12810f);
            f2500.AddVertex(-1.12349f, 7.06672f, 0.14021f);
            faces.Add(f2500);

            Face f2501 = new Face(m03___Default);
            f2501.AddVertex(-1.12349f, 7.06672f, 0.14021f);
            f2501.AddVertex(-1.12383f, 7.03486f, 0.12810f);
            f2501.AddVertex(-1.11417f, 7.03433f, 0.15046f);
            faces.Add(f2501);

            Face f2502 = new Face(m03___Default);
            f2502.AddVertex(-1.12349f, 7.06672f, 0.14021f);
            f2502.AddVertex(-1.11417f, 7.03433f, 0.15046f);
            f2502.AddVertex(-1.10836f, 7.06625f, 0.16077f);
            faces.Add(f2502);

            Face f2503 = new Face(m03___Default);
            f2503.AddVertex(-1.10836f, 7.06625f, 0.16077f);
            f2503.AddVertex(-1.11417f, 7.03433f, 0.15046f);
            f2503.AddVertex(-1.09606f, 7.03683f, 0.16716f);
            faces.Add(f2503);

            Face f2504 = new Face(m03___Default);
            f2504.AddVertex(-1.12422f, 7.03836f, 0.10205f);
            f2504.AddVertex(-1.11202f, 7.01166f, 0.08853f);
            f2504.AddVertex(-1.11374f, 7.00369f, 0.11287f);
            faces.Add(f2504);

            Face f2505 = new Face(m03___Default);
            f2505.AddVertex(-1.12422f, 7.03836f, 0.10205f);
            f2505.AddVertex(-1.11374f, 7.00369f, 0.11287f);
            f2505.AddVertex(-1.12383f, 7.03486f, 0.12810f);
            faces.Add(f2505);

            Face f2506 = new Face(m03___Default);
            f2506.AddVertex(-1.12383f, 7.03486f, 0.12810f);
            f2506.AddVertex(-1.11374f, 7.00369f, 0.11287f);
            f2506.AddVertex(-1.10826f, 7.00062f, 0.13522f);
            faces.Add(f2506);

            Face f2507 = new Face(m03___Default);
            f2507.AddVertex(-1.12383f, 7.03486f, 0.12810f);
            f2507.AddVertex(-1.10826f, 7.00062f, 0.13522f);
            f2507.AddVertex(-1.11417f, 7.03433f, 0.15046f);
            faces.Add(f2507);

            Face f2508 = new Face(m03___Default);
            f2508.AddVertex(-1.11417f, 7.03433f, 0.15046f);
            f2508.AddVertex(-1.10826f, 7.00062f, 0.13522f);
            f2508.AddVertex(-1.09601f, 7.00271f, 0.15388f);
            faces.Add(f2508);

            Face f2509 = new Face(m03___Default);
            f2509.AddVertex(-1.11417f, 7.03433f, 0.15046f);
            f2509.AddVertex(-1.09601f, 7.00271f, 0.15388f);
            f2509.AddVertex(-1.09606f, 7.03683f, 0.16716f);
            faces.Add(f2509);

            Face f2510 = new Face(m03___Default);
            f2510.AddVertex(-1.09606f, 7.03683f, 0.16716f);
            f2510.AddVertex(-1.09601f, 7.00271f, 0.15388f);
            f2510.AddVertex(-1.07792f, 7.00981f, 0.16742f);
            faces.Add(f2510);

            Face f2511 = new Face(m03___Default);
            f2511.AddVertex(-1.02021f, 7.12281f, 0.16276f);
            f2511.AddVertex(-1.03796f, 7.09541f, 0.17413f);
            f2511.AddVertex(-1.00290f, 7.09572f, 0.16523f);
            faces.Add(f2511);

            Face f2512 = new Face(m03___Default);
            f2512.AddVertex(-1.03796f, 7.09541f, 0.17413f);
            f2512.AddVertex(-1.05429f, 7.06595f, 0.17885f);
            f2512.AddVertex(-1.02063f, 7.06615f, 0.17459f);
            faces.Add(f2512);

            Face f2513 = new Face(m03___Default);
            f2513.AddVertex(-1.03796f, 7.09541f, 0.17413f);
            f2513.AddVertex(-1.02063f, 7.06615f, 0.17459f);
            f2513.AddVertex(-1.00290f, 7.09572f, 0.16523f);
            faces.Add(f2513);

            Face f2514 = new Face(m03___Default);
            f2514.AddVertex(-1.00290f, 7.09572f, 0.16523f);
            f2514.AddVertex(-1.02063f, 7.06615f, 0.17459f);
            f2514.AddVertex(-0.98684f, 7.06656f, 0.16173f);
            faces.Add(f2514);

            Face f2515 = new Face(m03___Default);
            f2515.AddVertex(-1.05429f, 7.06595f, 0.17885f);
            f2515.AddVertex(-1.06796f, 7.03667f, 0.17655f);
            f2515.AddVertex(-1.03700f, 7.03391f, 0.17626f);
            faces.Add(f2515);

            Face f2516 = new Face(m03___Default);
            f2516.AddVertex(-1.05429f, 7.06595f, 0.17885f);
            f2516.AddVertex(-1.03700f, 7.03391f, 0.17626f);
            f2516.AddVertex(-1.02063f, 7.06615f, 0.17459f);
            faces.Add(f2516);

            Face f2517 = new Face(m03___Default);
            f2517.AddVertex(-1.02063f, 7.06615f, 0.17459f);
            f2517.AddVertex(-1.03700f, 7.03391f, 0.17626f);
            f2517.AddVertex(-1.00447f, 7.03420f, 0.16800f);
            faces.Add(f2517);

            Face f2518 = new Face(m03___Default);
            f2518.AddVertex(-1.02063f, 7.06615f, 0.17459f);
            f2518.AddVertex(-1.00447f, 7.03420f, 0.16800f);
            f2518.AddVertex(-0.98684f, 7.06656f, 0.16173f);
            faces.Add(f2518);

            Face f2519 = new Face(m03___Default);
            f2519.AddVertex(-0.98684f, 7.06656f, 0.16173f);
            f2519.AddVertex(-1.00447f, 7.03420f, 0.16800f);
            f2519.AddVertex(-0.97325f, 7.03753f, 0.15252f);
            faces.Add(f2519);

            Face f2520 = new Face(m03___Default);
            f2520.AddVertex(-1.06796f, 7.03667f, 0.17655f);
            f2520.AddVertex(-1.07792f, 7.00981f, 0.16742f);
            f2520.AddVertex(-1.05053f, 7.00247f, 0.16908f);
            faces.Add(f2520);

            Face f2521 = new Face(m03___Default);
            f2521.AddVertex(-1.06796f, 7.03667f, 0.17655f);
            f2521.AddVertex(-1.05053f, 7.00247f, 0.16908f);
            f2521.AddVertex(-1.03700f, 7.03391f, 0.17626f);
            faces.Add(f2521);

            Face f2522 = new Face(m03___Default);
            f2522.AddVertex(-1.03700f, 7.03391f, 0.17626f);
            f2522.AddVertex(-1.05053f, 7.00247f, 0.16908f);
            f2522.AddVertex(-1.02076f, 7.00014f, 0.16447f);
            faces.Add(f2522);

            Face f2523 = new Face(m03___Default);
            f2523.AddVertex(-1.03700f, 7.03391f, 0.17626f);
            f2523.AddVertex(-1.02076f, 7.00014f, 0.16447f);
            f2523.AddVertex(-1.00447f, 7.03420f, 0.16800f);
            faces.Add(f2523);

            Face f2524 = new Face(m03___Default);
            f2524.AddVertex(-1.00447f, 7.03420f, 0.16800f);
            f2524.AddVertex(-1.02076f, 7.00014f, 0.16447f);
            f2524.AddVertex(-0.99088f, 7.00301f, 0.15393f);
            faces.Add(f2524);

            Face f2525 = new Face(m03___Default);
            f2525.AddVertex(-1.00447f, 7.03420f, 0.16800f);
            f2525.AddVertex(-0.99088f, 7.00301f, 0.15393f);
            f2525.AddVertex(-0.97325f, 7.03753f, 0.15252f);
            faces.Add(f2525);

            Face f2526 = new Face(m03___Default);
            f2526.AddVertex(-0.97325f, 7.03753f, 0.15252f);
            f2526.AddVertex(-0.99088f, 7.00301f, 0.15393f);
            f2526.AddVertex(-0.96317f, 7.01084f, 0.13829f);
            faces.Add(f2526);

            Face f2527 = new Face(m03___Default);
            f2527.AddVertex(-0.92636f, 7.01333f, 0.04139f);
            f2527.AddVertex(-0.92468f, 7.04082f, 0.02465f);
            f2527.AddVertex(-0.91426f, 7.04025f, 0.04875f);
            faces.Add(f2527);

            Face f2528 = new Face(m03___Default);
            f2528.AddVertex(-0.92468f, 7.04082f, 0.02465f);
            f2528.AddVertex(-0.93020f, 7.07039f, 0.01263f);
            f2528.AddVertex(-0.91507f, 7.06993f, 0.03319f);
            faces.Add(f2528);

            Face f2529 = new Face(m03___Default);
            f2529.AddVertex(-0.92468f, 7.04082f, 0.02465f);
            f2529.AddVertex(-0.91507f, 7.06993f, 0.03319f);
            f2529.AddVertex(-0.91426f, 7.04025f, 0.04875f);
            faces.Add(f2529);

            Face f2530 = new Face(m03___Default);
            f2530.AddVertex(-0.91426f, 7.04025f, 0.04875f);
            f2530.AddVertex(-0.91507f, 7.06993f, 0.03319f);
            f2530.AddVertex(-0.91015f, 7.06931f, 0.05900f);
            faces.Add(f2530);

            Face f2531 = new Face(m03___Default);
            f2531.AddVertex(-0.93020f, 7.07039f, 0.01263f);
            f2531.AddVertex(-0.94251f, 7.09982f, 0.00624f);
            f2531.AddVertex(-0.92440f, 7.10231f, 0.02295f);
            faces.Add(f2531);

            Face f2532 = new Face(m03___Default);
            f2532.AddVertex(-0.93020f, 7.07039f, 0.01263f);
            f2532.AddVertex(-0.92440f, 7.10231f, 0.02295f);
            f2532.AddVertex(-0.91507f, 7.06993f, 0.03319f);
            faces.Add(f2532);

            Face f2533 = new Face(m03___Default);
            f2533.AddVertex(-0.91507f, 7.06993f, 0.03319f);
            f2533.AddVertex(-0.92440f, 7.10231f, 0.02295f);
            f2533.AddVertex(-0.91473f, 7.10178f, 0.04531f);
            faces.Add(f2533);

            Face f2534 = new Face(m03___Default);
            f2534.AddVertex(-0.91507f, 7.06993f, 0.03319f);
            f2534.AddVertex(-0.91473f, 7.10178f, 0.04531f);
            f2534.AddVertex(-0.91015f, 7.06931f, 0.05900f);
            faces.Add(f2534);

            Face f2535 = new Face(m03___Default);
            f2535.AddVertex(-0.91015f, 7.06931f, 0.05900f);
            f2535.AddVertex(-0.91473f, 7.10178f, 0.04531f);
            f2535.AddVertex(-0.91435f, 7.09829f, 0.07135f);
            faces.Add(f2535);

            Face f2536 = new Face(m03___Default);
            f2536.AddVertex(-0.94251f, 7.09982f, 0.00624f);
            f2536.AddVertex(-0.96065f, 7.12684f, 0.00598f);
            f2536.AddVertex(-0.94256f, 7.13392f, 0.01953f);
            faces.Add(f2536);

            Face f2537 = new Face(m03___Default);
            f2537.AddVertex(-0.94251f, 7.09982f, 0.00624f);
            f2537.AddVertex(-0.94256f, 7.13392f, 0.01953f);
            f2537.AddVertex(-0.92440f, 7.10231f, 0.02295f);
            faces.Add(f2537);

            Face f2538 = new Face(m03___Default);
            f2538.AddVertex(-0.92440f, 7.10231f, 0.02295f);
            f2538.AddVertex(-0.94256f, 7.13392f, 0.01953f);
            f2538.AddVertex(-0.93030f, 7.13602f, 0.03818f);
            faces.Add(f2538);

            Face f2539 = new Face(m03___Default);
            f2539.AddVertex(-0.92440f, 7.10231f, 0.02295f);
            f2539.AddVertex(-0.93030f, 7.13602f, 0.03818f);
            f2539.AddVertex(-0.91473f, 7.10178f, 0.04531f);
            faces.Add(f2539);

            Face f2540 = new Face(m03___Default);
            f2540.AddVertex(-0.91473f, 7.10178f, 0.04531f);
            f2540.AddVertex(-0.93030f, 7.13602f, 0.03818f);
            f2540.AddVertex(-0.92483f, 7.13296f, 0.06054f);
            faces.Add(f2540);

            Face f2541 = new Face(m03___Default);
            f2541.AddVertex(-0.91473f, 7.10178f, 0.04531f);
            f2541.AddVertex(-0.92483f, 7.13296f, 0.06054f);
            f2541.AddVertex(-0.91435f, 7.09829f, 0.07135f);
            faces.Add(f2541);

            Face f2542 = new Face(m03___Default);
            f2542.AddVertex(-0.91435f, 7.09829f, 0.07135f);
            f2542.AddVertex(-0.92483f, 7.13296f, 0.06054f);
            f2542.AddVertex(-0.92654f, 7.12499f, 0.08488f);
            faces.Add(f2542);

            Face f2543 = new Face(m03___Default);
            f2543.AddVertex(-1.01836f, 7.01384f, 0.01064f);
            f2543.AddVertex(-1.03566f, 7.04092f, 0.00817f);
            f2543.AddVertex(-1.00060f, 7.04124f, -0.00072f);
            faces.Add(f2543);

            Face f2544 = new Face(m03___Default);
            f2544.AddVertex(-1.03566f, 7.04092f, 0.00817f);
            f2544.AddVertex(-1.05173f, 7.07009f, 0.01167f);
            f2544.AddVertex(-1.01793f, 7.07050f, -0.00118f);
            faces.Add(f2544);

            Face f2545 = new Face(m03___Default);
            f2545.AddVertex(-1.03566f, 7.04092f, 0.00817f);
            f2545.AddVertex(-1.01793f, 7.07050f, -0.00118f);
            f2545.AddVertex(-1.00060f, 7.04124f, -0.00072f);
            faces.Add(f2545);

            Face f2546 = new Face(m03___Default);
            f2546.AddVertex(-1.00060f, 7.04124f, -0.00072f);
            f2546.AddVertex(-1.01793f, 7.07050f, -0.00118f);
            f2546.AddVertex(-0.98428f, 7.07069f, -0.00544f);
            faces.Add(f2546);

            Face f2547 = new Face(m03___Default);
            f2547.AddVertex(-1.05173f, 7.07009f, 0.01167f);
            f2547.AddVertex(-1.06531f, 7.09912f, 0.02089f);
            f2547.AddVertex(-1.03410f, 7.10244f, 0.00541f);
            faces.Add(f2547);

            Face f2548 = new Face(m03___Default);
            f2548.AddVertex(-1.05173f, 7.07009f, 0.01167f);
            f2548.AddVertex(-1.03410f, 7.10244f, 0.00541f);
            f2548.AddVertex(-1.01793f, 7.07050f, -0.00118f);
            faces.Add(f2548);

            Face f2549 = new Face(m03___Default);
            f2549.AddVertex(-1.01793f, 7.07050f, -0.00118f);
            f2549.AddVertex(-1.03410f, 7.10244f, 0.00541f);
            f2549.AddVertex(-1.00157f, 7.10274f, -0.00284f);
            faces.Add(f2549);

            Face f2550 = new Face(m03___Default);
            f2550.AddVertex(-1.01793f, 7.07050f, -0.00118f);
            f2550.AddVertex(-1.00157f, 7.10274f, -0.00284f);
            f2550.AddVertex(-0.98428f, 7.07069f, -0.00544f);
            faces.Add(f2550);

            Face f2551 = new Face(m03___Default);
            f2551.AddVertex(-0.98428f, 7.07069f, -0.00544f);
            f2551.AddVertex(-1.00157f, 7.10274f, -0.00284f);
            f2551.AddVertex(-0.97061f, 7.09997f, -0.00314f);
            faces.Add(f2551);

            Face f2552 = new Face(m03___Default);
            f2552.AddVertex(-1.06531f, 7.09912f, 0.02089f);
            f2552.AddVertex(-1.07540f, 7.12581f, 0.03511f);
            f2552.AddVertex(-1.04768f, 7.13364f, 0.01947f);
            faces.Add(f2552);

            Face f2553 = new Face(m03___Default);
            f2553.AddVertex(-1.06531f, 7.09912f, 0.02089f);
            f2553.AddVertex(-1.04768f, 7.13364f, 0.01947f);
            f2553.AddVertex(-1.03410f, 7.10244f, 0.00541f);
            faces.Add(f2553);

            Face f2554 = new Face(m03___Default);
            f2554.AddVertex(-1.03410f, 7.10244f, 0.00541f);
            f2554.AddVertex(-1.04768f, 7.13364f, 0.01947f);
            f2554.AddVertex(-1.01781f, 7.13651f, 0.00894f);
            faces.Add(f2554);

            Face f2555 = new Face(m03___Default);
            f2555.AddVertex(-1.03410f, 7.10244f, 0.00541f);
            f2555.AddVertex(-1.01781f, 7.13651f, 0.00894f);
            f2555.AddVertex(-1.00157f, 7.10274f, -0.00284f);
            faces.Add(f2555);

            Face f2556 = new Face(m03___Default);
            f2556.AddVertex(-1.00157f, 7.10274f, -0.00284f);
            f2556.AddVertex(-1.01781f, 7.13651f, 0.00894f);
            f2556.AddVertex(-0.98804f, 7.13418f, 0.00433f);
            faces.Add(f2556);

            Face f2557 = new Face(m03___Default);
            f2557.AddVertex(-1.00157f, 7.10274f, -0.00284f);
            f2557.AddVertex(-0.98804f, 7.13418f, 0.00433f);
            f2557.AddVertex(-0.97061f, 7.09997f, -0.00314f);
            faces.Add(f2557);

            Face f2558 = new Face(m03___Default);
            f2558.AddVertex(-0.97061f, 7.09997f, -0.00314f);
            f2558.AddVertex(-0.98804f, 7.13418f, 0.00433f);
            f2558.AddVertex(-0.96065f, 7.12684f, 0.00598f);
            faces.Add(f2558);

            Face f2559 = new Face(m03___Default);
            f2559.AddVertex(-1.11202f, 7.01166f, 0.08853f);
            f2559.AddVertex(-1.12422f, 7.03836f, 0.10205f);
            f2559.AddVertex(-1.11297f, 7.03912f, 0.07245f);
            faces.Add(f2559);

            Face f2560 = new Face(m03___Default);
            f2560.AddVertex(-1.12422f, 7.03836f, 0.10205f);
            f2560.AddVertex(-1.12842f, 7.06734f, 0.11440f);
            f2560.AddVertex(-1.12266f, 7.06806f, 0.08589f);
            faces.Add(f2560);

            Face f2561 = new Face(m03___Default);
            f2561.AddVertex(-1.12422f, 7.03836f, 0.10205f);
            f2561.AddVertex(-1.12266f, 7.06806f, 0.08589f);
            f2561.AddVertex(-1.11297f, 7.03912f, 0.07245f);
            faces.Add(f2561);

            Face f2562 = new Face(m03___Default);
            f2562.AddVertex(-1.11297f, 7.03912f, 0.07245f);
            f2562.AddVertex(-1.12266f, 7.06806f, 0.08589f);
            f2562.AddVertex(-1.10678f, 7.06881f, 0.05746f);
            faces.Add(f2562);

            Face f2563 = new Face(m03___Default);
            f2563.AddVertex(-1.12842f, 7.06734f, 0.11440f);
            f2563.AddVertex(-1.12431f, 7.09640f, 0.12465f);
            f2563.AddVertex(-1.12310f, 7.09991f, 0.09820f);
            faces.Add(f2563);

            Face f2564 = new Face(m03___Default);
            f2564.AddVertex(-1.12842f, 7.06734f, 0.11440f);
            f2564.AddVertex(-1.12310f, 7.09991f, 0.09820f);
            f2564.AddVertex(-1.12266f, 7.06806f, 0.08589f);
            faces.Add(f2564);

            Face f2565 = new Face(m03___Default);
            f2565.AddVertex(-1.12266f, 7.06806f, 0.08589f);
            f2565.AddVertex(-1.12310f, 7.09991f, 0.09820f);
            f2565.AddVertex(-1.11267f, 7.10062f, 0.07073f);
            faces.Add(f2565);

            Face f2566 = new Face(m03___Default);
            f2566.AddVertex(-1.12266f, 7.06806f, 0.08589f);
            f2566.AddVertex(-1.11267f, 7.10062f, 0.07073f);
            f2566.AddVertex(-1.10678f, 7.06881f, 0.05746f);
            faces.Add(f2566);

            Face f2567 = new Face(m03___Default);
            f2567.AddVertex(-1.10678f, 7.06881f, 0.05746f);
            f2567.AddVertex(-1.11267f, 7.10062f, 0.07073f);
            f2567.AddVertex(-1.09393f, 7.09846f, 0.04468f);
            faces.Add(f2567);

            Face f2568 = new Face(m03___Default);
            f2568.AddVertex(-1.12431f, 7.09640f, 0.12465f);
            f2568.AddVertex(-1.11221f, 7.12332f, 0.13201f);
            f2568.AddVertex(-1.11312f, 7.13127f, 0.10833f);
            faces.Add(f2568);

            Face f2569 = new Face(m03___Default);
            f2569.AddVertex(-1.12431f, 7.09640f, 0.12465f);
            f2569.AddVertex(-1.11312f, 7.13127f, 0.10833f);
            f2569.AddVertex(-1.12310f, 7.09991f, 0.09820f);
            faces.Add(f2569);

            Face f2570 = new Face(m03___Default);
            f2570.AddVertex(-1.12310f, 7.09991f, 0.09820f);
            f2570.AddVertex(-1.11312f, 7.13127f, 0.10833f);
            f2570.AddVertex(-1.10689f, 7.13443f, 0.08301f);
            faces.Add(f2570);

            Face f2571 = new Face(m03___Default);
            f2571.AddVertex(-1.12310f, 7.09991f, 0.09820f);
            f2571.AddVertex(-1.10689f, 7.13443f, 0.08301f);
            f2571.AddVertex(-1.11267f, 7.10062f, 0.07073f);
            faces.Add(f2571);

            Face f2572 = new Face(m03___Default);
            f2572.AddVertex(-1.11267f, 7.10062f, 0.07073f);
            f2572.AddVertex(-1.10689f, 7.13443f, 0.08301f);
            f2572.AddVertex(-1.09399f, 7.13256f, 0.05797f);
            faces.Add(f2572);

            Face f2573 = new Face(m03___Default);
            f2573.AddVertex(-1.11267f, 7.10062f, 0.07073f);
            f2573.AddVertex(-1.09399f, 7.13256f, 0.05797f);
            f2573.AddVertex(-1.09393f, 7.09846f, 0.04468f);
            faces.Add(f2573);

            Face f2574 = new Face(m03___Default);
            f2574.AddVertex(-1.09393f, 7.09846f, 0.04468f);
            f2574.AddVertex(-1.09399f, 7.13256f, 0.05797f);
            f2574.AddVertex(-1.07540f, 7.12581f, 0.03511f);
            faces.Add(f2574);

            Face f2575 = new Face(m03___Default);
            f2575.AddVertex(-1.07792f, 7.00981f, 0.16742f);
            f2575.AddVertex(-1.06796f, 7.03667f, 0.17655f);
            f2575.AddVertex(-1.09606f, 7.03683f, 0.16716f);
            faces.Add(f2575);

            Face f2576 = new Face(m03___Default);
            f2576.AddVertex(-1.06796f, 7.03667f, 0.17655f);
            f2576.AddVertex(-1.05429f, 7.06595f, 0.17885f);
            f2576.AddVertex(-1.08452f, 7.06599f, 0.17409f);
            faces.Add(f2576);

            Face f2577 = new Face(m03___Default);
            f2577.AddVertex(-1.06796f, 7.03667f, 0.17655f);
            f2577.AddVertex(-1.08452f, 7.06599f, 0.17409f);
            f2577.AddVertex(-1.09606f, 7.03683f, 0.16716f);
            faces.Add(f2577);

            Face f2578 = new Face(m03___Default);
            f2578.AddVertex(-1.09606f, 7.03683f, 0.16716f);
            f2578.AddVertex(-1.08452f, 7.06599f, 0.17409f);
            f2578.AddVertex(-1.10836f, 7.06625f, 0.16077f);
            faces.Add(f2578);

            Face f2579 = new Face(m03___Default);
            f2579.AddVertex(-1.05429f, 7.06595f, 0.17885f);
            f2579.AddVertex(-1.03796f, 7.09541f, 0.17413f);
            f2579.AddVertex(-1.06840f, 7.09821f, 0.17310f);
            faces.Add(f2579);

            Face f2580 = new Face(m03___Default);
            f2580.AddVertex(-1.05429f, 7.06595f, 0.17885f);
            f2580.AddVertex(-1.06840f, 7.09821f, 0.17310f);
            f2580.AddVertex(-1.08452f, 7.06599f, 0.17409f);
            faces.Add(f2580);

            Face f2581 = new Face(m03___Default);
            f2581.AddVertex(-1.08452f, 7.06599f, 0.17409f);
            f2581.AddVertex(-1.06840f, 7.09821f, 0.17310f);
            f2581.AddVertex(-1.09449f, 7.09836f, 0.16437f);
            faces.Add(f2581);

            Face f2582 = new Face(m03___Default);
            f2582.AddVertex(-1.08452f, 7.06599f, 0.17409f);
            f2582.AddVertex(-1.09449f, 7.09836f, 0.16437f);
            f2582.AddVertex(-1.10836f, 7.06625f, 0.16077f);
            faces.Add(f2582);

            Face f2583 = new Face(m03___Default);
            f2583.AddVertex(-1.10836f, 7.06625f, 0.16077f);
            f2583.AddVertex(-1.09449f, 7.09836f, 0.16437f);
            f2583.AddVertex(-1.11389f, 7.09583f, 0.14876f);
            faces.Add(f2583);

            Face f2584 = new Face(m03___Default);
            f2584.AddVertex(-1.03796f, 7.09541f, 0.17413f);
            f2584.AddVertex(-1.02021f, 7.12281f, 0.16276f);
            f2584.AddVertex(-1.04844f, 7.13009f, 0.16331f);
            faces.Add(f2584);

            Face f2585 = new Face(m03___Default);
            f2585.AddVertex(-1.03796f, 7.09541f, 0.17413f);
            f2585.AddVertex(-1.04844f, 7.13009f, 0.16331f);
            f2585.AddVertex(-1.06840f, 7.09821f, 0.17310f);
            faces.Add(f2585);

            Face f2586 = new Face(m03___Default);
            f2586.AddVertex(-1.06840f, 7.09821f, 0.17310f);
            f2586.AddVertex(-1.04844f, 7.13009f, 0.16331f);
            f2586.AddVertex(-1.07445f, 7.13267f, 0.15804f);
            faces.Add(f2586);

            Face f2587 = new Face(m03___Default);
            f2587.AddVertex(-1.06840f, 7.09821f, 0.17310f);
            f2587.AddVertex(-1.07445f, 7.13267f, 0.15804f);
            f2587.AddVertex(-1.09449f, 7.09836f, 0.16437f);
            faces.Add(f2587);

            Face f2588 = new Face(m03___Default);
            f2588.AddVertex(-1.09449f, 7.09836f, 0.16437f);
            f2588.AddVertex(-1.07445f, 7.13267f, 0.15804f);
            f2588.AddVertex(-1.09626f, 7.13035f, 0.14733f);
            faces.Add(f2588);

            Face f2589 = new Face(m03___Default);
            f2589.AddVertex(-1.09449f, 7.09836f, 0.16437f);
            f2589.AddVertex(-1.09626f, 7.13035f, 0.14733f);
            f2589.AddVertex(-1.11389f, 7.09583f, 0.14876f);
            faces.Add(f2589);

            Face f2590 = new Face(m03___Default);
            f2590.AddVertex(-1.11389f, 7.09583f, 0.14876f);
            f2590.AddVertex(-1.09626f, 7.13035f, 0.14733f);
            f2590.AddVertex(-1.11221f, 7.12332f, 0.13201f);
            faces.Add(f2590);

            Face f2591 = new Face(m03___Default);
            f2591.AddVertex(-0.96317f, 7.01084f, 0.13829f);
            f2591.AddVertex(-0.94463f, 7.03819f, 0.12872f);
            f2591.AddVertex(-0.97325f, 7.03753f, 0.15252f);
            faces.Add(f2591);

            Face f2592 = new Face(m03___Default);
            f2592.AddVertex(-0.94463f, 7.03819f, 0.12872f);
            f2592.AddVertex(-0.93179f, 7.06784f, 0.11595f);
            f2592.AddVertex(-0.95622f, 7.06714f, 0.14153f);
            faces.Add(f2592);

            Face f2593 = new Face(m03___Default);
            f2593.AddVertex(-0.94463f, 7.03819f, 0.12872f);
            f2593.AddVertex(-0.95622f, 7.06714f, 0.14153f);
            f2593.AddVertex(-0.97325f, 7.03753f, 0.15252f);
            faces.Add(f2593);

            Face f2594 = new Face(m03___Default);
            f2594.AddVertex(-0.97325f, 7.03753f, 0.15252f);
            f2594.AddVertex(-0.95622f, 7.06714f, 0.14153f);
            f2594.AddVertex(-0.98684f, 7.06656f, 0.16173f);
            faces.Add(f2594);

            Face f2595 = new Face(m03___Default);
            f2595.AddVertex(-0.93179f, 7.06784f, 0.11595f);
            f2595.AddVertex(-0.92560f, 7.09752f, 0.10096f);
            f2595.AddVertex(-0.94560f, 7.09969f, 0.12658f);
            faces.Add(f2595);

            Face f2596 = new Face(m03___Default);
            f2596.AddVertex(-0.93179f, 7.06784f, 0.11595f);
            f2596.AddVertex(-0.94560f, 7.09969f, 0.12658f);
            f2596.AddVertex(-0.95622f, 7.06714f, 0.14153f);
            faces.Add(f2596);

            Face f2597 = new Face(m03___Default);
            f2597.AddVertex(-0.95622f, 7.06714f, 0.14153f);
            f2597.AddVertex(-0.94560f, 7.09969f, 0.12658f);
            f2597.AddVertex(-0.97216f, 7.09907f, 0.14866f);
            faces.Add(f2597);

            Face f2598 = new Face(m03___Default);
            f2598.AddVertex(-0.95622f, 7.06714f, 0.14153f);
            f2598.AddVertex(-0.97216f, 7.09907f, 0.14866f);
            f2598.AddVertex(-0.98684f, 7.06656f, 0.16173f);
            faces.Add(f2598);

            Face f2599 = new Face(m03___Default);
            f2599.AddVertex(-0.98684f, 7.06656f, 0.16173f);
            f2599.AddVertex(-0.97216f, 7.09907f, 0.14866f);
            f2599.AddVertex(-1.00290f, 7.09572f, 0.16523f);
            faces.Add(f2599);

            Face f2600 = new Face(m03___Default);
            f2600.AddVertex(-0.92560f, 7.09752f, 0.10096f);
            f2600.AddVertex(-0.92654f, 7.12499f, 0.08488f);
            f2600.AddVertex(-0.94302f, 7.13173f, 0.10843f);
            faces.Add(f2600);

            Face f2601 = new Face(m03___Default);
            f2601.AddVertex(-0.92560f, 7.09752f, 0.10096f);
            f2601.AddVertex(-0.94302f, 7.13173f, 0.10843f);
            f2601.AddVertex(-0.94560f, 7.09969f, 0.12658f);
            faces.Add(f2601);

            Face f2602 = new Face(m03___Default);
            f2602.AddVertex(-0.94560f, 7.09969f, 0.12658f);
            f2602.AddVertex(-0.94302f, 7.13173f, 0.10843f);
            f2602.AddVertex(-0.96531f, 7.13365f, 0.13033f);
            faces.Add(f2602);

            Face f2603 = new Face(m03___Default);
            f2603.AddVertex(-0.94560f, 7.09969f, 0.12658f);
            f2603.AddVertex(-0.96531f, 7.13365f, 0.13033f);
            f2603.AddVertex(-0.97216f, 7.09907f, 0.14866f);
            faces.Add(f2603);

            Face f2604 = new Face(m03___Default);
            f2604.AddVertex(-0.97216f, 7.09907f, 0.14866f);
            f2604.AddVertex(-0.96531f, 7.13365f, 0.13033f);
            f2604.AddVertex(-0.99171f, 7.13060f, 0.14891f);
            faces.Add(f2604);

            Face f2605 = new Face(m03___Default);
            f2605.AddVertex(-0.97216f, 7.09907f, 0.14866f);
            f2605.AddVertex(-0.99171f, 7.13060f, 0.14891f);
            f2605.AddVertex(-1.00290f, 7.09572f, 0.16523f);
            faces.Add(f2605);

            Face f2606 = new Face(m03___Default);
            f2606.AddVertex(-1.00290f, 7.09572f, 0.16523f);
            f2606.AddVertex(-0.99171f, 7.13060f, 0.14891f);
            f2606.AddVertex(-1.02021f, 7.12281f, 0.16276f);
            faces.Add(f2606);

            Face f2607 = new Face(m03___Default);
            f2607.AddVertex(-1.01991f, 6.94215f, 0.09241f);
            f2607.AddVertex(-1.01952f, 6.94754f, 0.06818f);
            f2607.AddVertex(-0.99141f, 6.94739f, 0.07757f);
            faces.Add(f2607);

            Face f2608 = new Face(m03___Default);
            f2608.AddVertex(-1.01952f, 6.94754f, 0.06818f);
            f2608.AddVertex(-1.01911f, 6.96213f, 0.04535f);
            f2608.AddVertex(-0.99067f, 6.95651f, 0.05273f);
            faces.Add(f2608);

            Face f2609 = new Face(m03___Default);
            f2609.AddVertex(-1.01952f, 6.94754f, 0.06818f);
            f2609.AddVertex(-0.99067f, 6.95651f, 0.05273f);
            f2609.AddVertex(-0.99141f, 6.94739f, 0.07757f);
            faces.Add(f2609);

            Face f2610 = new Face(m03___Default);
            f2610.AddVertex(-0.99141f, 6.94739f, 0.07757f);
            f2610.AddVertex(-0.99067f, 6.95651f, 0.05273f);
            f2610.AddVertex(-0.96503f, 6.96184f, 0.06343f);
            faces.Add(f2610);

            Face f2611 = new Face(m03___Default);
            f2611.AddVertex(-1.01911f, 6.96213f, 0.04535f);
            f2611.AddVertex(-1.01871f, 6.98481f, 0.02567f);
            f2611.AddVertex(-0.99003f, 6.97651f, 0.02929f);
            faces.Add(f2611);

            Face f2612 = new Face(m03___Default);
            f2612.AddVertex(-1.01911f, 6.96213f, 0.04535f);
            f2612.AddVertex(-0.99003f, 6.97651f, 0.02929f);
            f2612.AddVertex(-0.99067f, 6.95651f, 0.05273f);
            faces.Add(f2612);

            Face f2613 = new Face(m03___Default);
            f2613.AddVertex(-0.99067f, 6.95651f, 0.05273f);
            f2613.AddVertex(-0.99003f, 6.97651f, 0.02929f);
            f2613.AddVertex(-0.96395f, 6.97636f, 0.03801f);
            faces.Add(f2613);

            Face f2614 = new Face(m03___Default);
            f2614.AddVertex(-0.99067f, 6.95651f, 0.05273f);
            f2614.AddVertex(-0.96395f, 6.97636f, 0.03801f);
            f2614.AddVertex(-0.96503f, 6.96184f, 0.06343f);
            faces.Add(f2614);

            Face f2615 = new Face(m03___Default);
            f2615.AddVertex(-0.96503f, 6.96184f, 0.06343f);
            f2615.AddVertex(-0.96395f, 6.97636f, 0.03801f);
            f2615.AddVertex(-0.94278f, 6.98439f, 0.05106f);
            faces.Add(f2615);

            Face f2616 = new Face(m03___Default);
            f2616.AddVertex(-1.01871f, 6.98481f, 0.02567f);
            f2616.AddVertex(-1.01836f, 7.01384f, 0.01064f);
            f2616.AddVertex(-0.99013f, 7.00656f, 0.01009f);
            faces.Add(f2616);

            Face f2617 = new Face(m03___Default);
            f2617.AddVertex(-1.01871f, 6.98481f, 0.02567f);
            f2617.AddVertex(-0.99013f, 7.00656f, 0.01009f);
            f2617.AddVertex(-0.99003f, 6.97651f, 0.02929f);
            faces.Add(f2617);

            Face f2618 = new Face(m03___Default);
            f2618.AddVertex(-0.99003f, 6.97651f, 0.02929f);
            f2618.AddVertex(-0.99013f, 7.00656f, 0.01009f);
            f2618.AddVertex(-0.96412f, 7.00397f, 0.01536f);
            faces.Add(f2618);

            Face f2619 = new Face(m03___Default);
            f2619.AddVertex(-0.99003f, 6.97651f, 0.02929f);
            f2619.AddVertex(-0.96412f, 7.00397f, 0.01536f);
            f2619.AddVertex(-0.96395f, 6.97636f, 0.03801f);
            faces.Add(f2619);

            Face f2620 = new Face(m03___Default);
            f2620.AddVertex(-0.96395f, 6.97636f, 0.03801f);
            f2620.AddVertex(-0.96412f, 7.00397f, 0.01536f);
            f2620.AddVertex(-0.94231f, 7.00629f, 0.02607f);
            faces.Add(f2620);

            Face f2621 = new Face(m03___Default);
            f2621.AddVertex(-0.96395f, 6.97636f, 0.03801f);
            f2621.AddVertex(-0.94231f, 7.00629f, 0.02607f);
            f2621.AddVertex(-0.94278f, 6.98439f, 0.05106f);
            faces.Add(f2621);

            Face f2622 = new Face(m03___Default);
            f2622.AddVertex(-0.94278f, 6.98439f, 0.05106f);
            f2622.AddVertex(-0.94231f, 7.00629f, 0.02607f);
            f2622.AddVertex(-0.92636f, 7.01333f, 0.04139f);
            faces.Add(f2622);

            Face f2623 = new Face(m03___Default);
            f2623.AddVertex(-1.01991f, 6.94215f, 0.09241f);
            f2623.AddVertex(-1.04814f, 6.94688f, 0.09197f);
            f2623.AddVertex(-1.01952f, 6.94754f, 0.06818f);
            faces.Add(f2623);

            Face f2624 = new Face(m03___Default);
            f2624.AddVertex(-1.04814f, 6.94688f, 0.09197f);
            f2624.AddVertex(-1.07417f, 6.96085f, 0.09113f);
            f2624.AddVertex(-1.04805f, 6.95600f, 0.06729f);
            faces.Add(f2624);

            Face f2625 = new Face(m03___Default);
            f2625.AddVertex(-1.04814f, 6.94688f, 0.09197f);
            f2625.AddVertex(-1.04805f, 6.95600f, 0.06729f);
            f2625.AddVertex(-1.01952f, 6.94754f, 0.06818f);
            faces.Add(f2625);

            Face f2626 = new Face(m03___Default);
            f2626.AddVertex(-1.01952f, 6.94754f, 0.06818f);
            f2626.AddVertex(-1.04805f, 6.95600f, 0.06729f);
            f2626.AddVertex(-1.01911f, 6.96213f, 0.04535f);
            faces.Add(f2626);

            Face f2627 = new Face(m03___Default);
            f2627.AddVertex(-1.07417f, 6.96085f, 0.09113f);
            f2627.AddVertex(-1.09602f, 6.98301f, 0.08995f);
            f2627.AddVertex(-1.07436f, 6.97537f, 0.06604f);
            faces.Add(f2627);

            Face f2628 = new Face(m03___Default);
            f2628.AddVertex(-1.07417f, 6.96085f, 0.09113f);
            f2628.AddVertex(-1.07436f, 6.97537f, 0.06604f);
            f2628.AddVertex(-1.04805f, 6.95600f, 0.06729f);
            faces.Add(f2628);

            Face f2629 = new Face(m03___Default);
            f2629.AddVertex(-1.04805f, 6.95600f, 0.06729f);
            f2629.AddVertex(-1.07436f, 6.97537f, 0.06604f);
            f2629.AddVertex(-1.04780f, 6.97598f, 0.04396f);
            faces.Add(f2629);

            Face f2630 = new Face(m03___Default);
            f2630.AddVertex(-1.04805f, 6.95600f, 0.06729f);
            f2630.AddVertex(-1.04780f, 6.97598f, 0.04396f);
            f2630.AddVertex(-1.01911f, 6.96213f, 0.04535f);
            faces.Add(f2630);

            Face f2631 = new Face(m03___Default);
            f2631.AddVertex(-1.01911f, 6.96213f, 0.04535f);
            f2631.AddVertex(-1.04780f, 6.97598f, 0.04396f);
            f2631.AddVertex(-1.01871f, 6.98481f, 0.02567f);
            faces.Add(f2631);

            Face f2632 = new Face(m03___Default);
            f2632.AddVertex(-1.09602f, 6.98301f, 0.08995f);
            f2632.AddVertex(-1.11202f, 7.01166f, 0.08853f);
            f2632.AddVertex(-1.09554f, 7.00491f, 0.06497f);
            faces.Add(f2632);

            Face f2633 = new Face(m03___Default);
            f2633.AddVertex(-1.09602f, 6.98301f, 0.08995f);
            f2633.AddVertex(-1.09554f, 7.00491f, 0.06497f);
            f2633.AddVertex(-1.07436f, 6.97537f, 0.06604f);
            faces.Add(f2633);

            Face f2634 = new Face(m03___Default);
            f2634.AddVertex(-1.07436f, 6.97537f, 0.06604f);
            f2634.AddVertex(-1.09554f, 7.00491f, 0.06497f);
            f2634.AddVertex(-1.07325f, 7.00299f, 0.04307f);
            faces.Add(f2634);

            Face f2635 = new Face(m03___Default);
            f2635.AddVertex(-1.07436f, 6.97537f, 0.06604f);
            f2635.AddVertex(-1.07325f, 7.00299f, 0.04307f);
            f2635.AddVertex(-1.04780f, 6.97598f, 0.04396f);
            faces.Add(f2635);

            Face f2636 = new Face(m03___Default);
            f2636.AddVertex(-1.04780f, 6.97598f, 0.04396f);
            f2636.AddVertex(-1.07325f, 7.00299f, 0.04307f);
            f2636.AddVertex(-1.04686f, 7.00605f, 0.02449f);
            faces.Add(f2636);

            Face f2637 = new Face(m03___Default);
            f2637.AddVertex(-1.04780f, 6.97598f, 0.04396f);
            f2637.AddVertex(-1.04686f, 7.00605f, 0.02449f);
            f2637.AddVertex(-1.01871f, 6.98481f, 0.02567f);
            faces.Add(f2637);

            Face f2638 = new Face(m03___Default);
            f2638.AddVertex(-1.01871f, 6.98481f, 0.02567f);
            f2638.AddVertex(-1.04686f, 7.00605f, 0.02449f);
            f2638.AddVertex(-1.01836f, 7.01384f, 0.01064f);
            faces.Add(f2638);

            Face f2639 = new Face(m03___Default);
            f2639.AddVertex(-1.01991f, 6.94215f, 0.09241f);
            f2639.AddVertex(-1.03772f, 6.94631f, 0.11607f);
            f2639.AddVertex(-1.04814f, 6.94688f, 0.09197f);
            faces.Add(f2639);

            Face f2640 = new Face(m03___Default);
            f2640.AddVertex(-1.03772f, 6.94631f, 0.11607f);
            f2640.AddVertex(-1.05411f, 6.95976f, 0.13750f);
            f2640.AddVertex(-1.06645f, 6.95475f, 0.11574f);
            faces.Add(f2640);

            Face f2641 = new Face(m03___Default);
            f2641.AddVertex(-1.03772f, 6.94631f, 0.11607f);
            f2641.AddVertex(-1.06645f, 6.95475f, 0.11574f);
            f2641.AddVertex(-1.04814f, 6.94688f, 0.09197f);
            faces.Add(f2641);

            Face f2642 = new Face(m03___Default);
            f2642.AddVertex(-1.04814f, 6.94688f, 0.09197f);
            f2642.AddVertex(-1.06645f, 6.95475f, 0.11574f);
            f2642.AddVertex(-1.07417f, 6.96085f, 0.09113f);
            faces.Add(f2642);

            Face f2643 = new Face(m03___Default);
            f2643.AddVertex(-1.05411f, 6.95976f, 0.13750f);
            f2643.AddVertex(-1.06786f, 6.98148f, 0.15506f);
            f2643.AddVertex(-1.08321f, 6.97359f, 0.13718f);
            faces.Add(f2643);

            Face f2644 = new Face(m03___Default);
            f2644.AddVertex(-1.05411f, 6.95976f, 0.13750f);
            f2644.AddVertex(-1.08321f, 6.97359f, 0.13718f);
            f2644.AddVertex(-1.06645f, 6.95475f, 0.11574f);
            faces.Add(f2644);

            Face f2645 = new Face(m03___Default);
            f2645.AddVertex(-1.06645f, 6.95475f, 0.11574f);
            f2645.AddVertex(-1.08321f, 6.97359f, 0.13718f);
            f2645.AddVertex(-1.09289f, 6.97411f, 0.11482f);
            faces.Add(f2645);

            Face f2646 = new Face(m03___Default);
            f2646.AddVertex(-1.06645f, 6.95475f, 0.11574f);
            f2646.AddVertex(-1.09289f, 6.97411f, 0.11482f);
            f2646.AddVertex(-1.07417f, 6.96085f, 0.09113f);
            faces.Add(f2646);

            Face f2647 = new Face(m03___Default);
            f2647.AddVertex(-1.07417f, 6.96085f, 0.09113f);
            f2647.AddVertex(-1.09289f, 6.97411f, 0.11482f);
            f2647.AddVertex(-1.09602f, 6.98301f, 0.08995f);
            faces.Add(f2647);

            Face f2648 = new Face(m03___Default);
            f2648.AddVertex(-1.06786f, 6.98148f, 0.15506f);
            f2648.AddVertex(-1.07792f, 7.00981f, 0.16742f);
            f2648.AddVertex(-1.09601f, 7.00271f, 0.15388f);
            faces.Add(f2648);

            Face f2649 = new Face(m03___Default);
            f2649.AddVertex(-1.06786f, 6.98148f, 0.15506f);
            f2649.AddVertex(-1.09601f, 7.00271f, 0.15388f);
            f2649.AddVertex(-1.08321f, 6.97359f, 0.13718f);
            faces.Add(f2649);

            Face f2650 = new Face(m03___Default);
            f2650.AddVertex(-1.08321f, 6.97359f, 0.13718f);
            f2650.AddVertex(-1.09601f, 7.00271f, 0.15388f);
            f2650.AddVertex(-1.10826f, 7.00062f, 0.13522f);
            faces.Add(f2650);

            Face f2651 = new Face(m03___Default);
            f2651.AddVertex(-1.08321f, 6.97359f, 0.13718f);
            f2651.AddVertex(-1.10826f, 7.00062f, 0.13522f);
            f2651.AddVertex(-1.09289f, 6.97411f, 0.11482f);
            faces.Add(f2651);

            Face f2652 = new Face(m03___Default);
            f2652.AddVertex(-1.09289f, 6.97411f, 0.11482f);
            f2652.AddVertex(-1.10826f, 7.00062f, 0.13522f);
            f2652.AddVertex(-1.11374f, 7.00369f, 0.11287f);
            faces.Add(f2652);

            Face f2653 = new Face(m03___Default);
            f2653.AddVertex(-1.09289f, 6.97411f, 0.11482f);
            f2653.AddVertex(-1.11374f, 7.00369f, 0.11287f);
            f2653.AddVertex(-1.09602f, 6.98301f, 0.08995f);
            faces.Add(f2653);

            Face f2654 = new Face(m03___Default);
            f2654.AddVertex(-1.09602f, 6.98301f, 0.08995f);
            f2654.AddVertex(-1.11374f, 7.00369f, 0.11287f);
            f2654.AddVertex(-1.11202f, 7.01166f, 0.08853f);
            faces.Add(f2654);

            Face f2655 = new Face(m03___Default);
            f2655.AddVertex(-1.01991f, 6.94215f, 0.09241f);
            f2655.AddVertex(-1.00266f, 6.94662f, 0.10717f);
            f2655.AddVertex(-1.03772f, 6.94631f, 0.11607f);
            faces.Add(f2655);

            Face f2656 = new Face(m03___Default);
            f2656.AddVertex(-1.00266f, 6.94662f, 0.10717f);
            f2656.AddVertex(-0.98667f, 6.96037f, 0.12038f);
            f2656.AddVertex(-1.02045f, 6.95450f, 0.13111f);
            faces.Add(f2656);

            Face f2657 = new Face(m03___Default);
            f2657.AddVertex(-1.00266f, 6.94662f, 0.10717f);
            f2657.AddVertex(-1.02045f, 6.95450f, 0.13111f);
            f2657.AddVertex(-1.03772f, 6.94631f, 0.11607f);
            faces.Add(f2657);

            Face f2658 = new Face(m03___Default);
            f2658.AddVertex(-1.03772f, 6.94631f, 0.11607f);
            f2658.AddVertex(-1.02045f, 6.95450f, 0.13111f);
            f2658.AddVertex(-1.05411f, 6.95976f, 0.13750f);
            faces.Add(f2658);

            Face f2659 = new Face(m03___Default);
            f2659.AddVertex(-0.98667f, 6.96037f, 0.12038f);
            f2659.AddVertex(-0.97316f, 6.98233f, 0.13102f);
            f2659.AddVertex(-1.00437f, 6.97362f, 0.14440f);
            faces.Add(f2659);

            Face f2660 = new Face(m03___Default);
            f2660.AddVertex(-0.98667f, 6.96037f, 0.12038f);
            f2660.AddVertex(-1.00437f, 6.97362f, 0.14440f);
            f2660.AddVertex(-1.02045f, 6.95450f, 0.13111f);
            faces.Add(f2660);

            Face f2661 = new Face(m03___Default);
            f2661.AddVertex(-1.02045f, 6.95450f, 0.13111f);
            f2661.AddVertex(-1.00437f, 6.97362f, 0.14440f);
            f2661.AddVertex(-1.03690f, 6.97333f, 0.15266f);
            faces.Add(f2661);

            Face f2662 = new Face(m03___Default);
            f2662.AddVertex(-1.02045f, 6.95450f, 0.13111f);
            f2662.AddVertex(-1.03690f, 6.97333f, 0.15266f);
            f2662.AddVertex(-1.05411f, 6.95976f, 0.13750f);
            faces.Add(f2662);

            Face f2663 = new Face(m03___Default);
            f2663.AddVertex(-1.05411f, 6.95976f, 0.13750f);
            f2663.AddVertex(-1.03690f, 6.97333f, 0.15266f);
            f2663.AddVertex(-1.06786f, 6.98148f, 0.15506f);
            faces.Add(f2663);

            Face f2664 = new Face(m03___Default);
            f2664.AddVertex(-0.97316f, 6.98233f, 0.13102f);
            f2664.AddVertex(-0.96317f, 7.01084f, 0.13829f);
            f2664.AddVertex(-0.99088f, 7.00301f, 0.15393f);
            faces.Add(f2664);

            Face f2665 = new Face(m03___Default);
            f2665.AddVertex(-0.97316f, 6.98233f, 0.13102f);
            f2665.AddVertex(-0.99088f, 7.00301f, 0.15393f);
            f2665.AddVertex(-1.00437f, 6.97362f, 0.14440f);
            faces.Add(f2665);

            Face f2666 = new Face(m03___Default);
            f2666.AddVertex(-1.00437f, 6.97362f, 0.14440f);
            f2666.AddVertex(-0.99088f, 7.00301f, 0.15393f);
            f2666.AddVertex(-1.02076f, 7.00014f, 0.16447f);
            faces.Add(f2666);

            Face f2667 = new Face(m03___Default);
            f2667.AddVertex(-1.00437f, 6.97362f, 0.14440f);
            f2667.AddVertex(-1.02076f, 7.00014f, 0.16447f);
            f2667.AddVertex(-1.03690f, 6.97333f, 0.15266f);
            faces.Add(f2667);

            Face f2668 = new Face(m03___Default);
            f2668.AddVertex(-1.03690f, 6.97333f, 0.15266f);
            f2668.AddVertex(-1.02076f, 7.00014f, 0.16447f);
            f2668.AddVertex(-1.05053f, 7.00247f, 0.16908f);
            faces.Add(f2668);

            Face f2669 = new Face(m03___Default);
            f2669.AddVertex(-1.03690f, 6.97333f, 0.15266f);
            f2669.AddVertex(-1.05053f, 7.00247f, 0.16908f);
            f2669.AddVertex(-1.06786f, 6.98148f, 0.15506f);
            faces.Add(f2669);

            Face f2670 = new Face(m03___Default);
            f2670.AddVertex(-1.06786f, 6.98148f, 0.15506f);
            f2670.AddVertex(-1.05053f, 7.00247f, 0.16908f);
            f2670.AddVertex(-1.07792f, 7.00981f, 0.16742f);
            faces.Add(f2670);

            Face f2671 = new Face(m03___Default);
            f2671.AddVertex(-1.01991f, 6.94215f, 0.09241f);
            f2671.AddVertex(-0.99141f, 6.94739f, 0.07757f);
            f2671.AddVertex(-1.00266f, 6.94662f, 0.10717f);
            faces.Add(f2671);

            Face f2672 = new Face(m03___Default);
            f2672.AddVertex(-0.99141f, 6.94739f, 0.07757f);
            f2672.AddVertex(-0.96503f, 6.96184f, 0.06343f);
            f2672.AddVertex(-0.97361f, 6.95558f, 0.09217f);
            faces.Add(f2672);

            Face f2673 = new Face(m03___Default);
            f2673.AddVertex(-0.99141f, 6.94739f, 0.07757f);
            f2673.AddVertex(-0.97361f, 6.95558f, 0.09217f);
            f2673.AddVertex(-1.00266f, 6.94662f, 0.10717f);
            faces.Add(f2673);

            Face f2674 = new Face(m03___Default);
            f2674.AddVertex(-1.00266f, 6.94662f, 0.10717f);
            f2674.AddVertex(-0.97361f, 6.95558f, 0.09217f);
            f2674.AddVertex(-0.98667f, 6.96037f, 0.12038f);
            faces.Add(f2674);

            Face f2675 = new Face(m03___Default);
            f2675.AddVertex(-0.96503f, 6.96184f, 0.06343f);
            f2675.AddVertex(-0.94278f, 6.98439f, 0.05106f);
            f2675.AddVertex(-0.94678f, 6.97543f, 0.07773f);
            faces.Add(f2675);

            Face f2676 = new Face(m03___Default);
            f2676.AddVertex(-0.96503f, 6.96184f, 0.06343f);
            f2676.AddVertex(-0.94678f, 6.97543f, 0.07773f);
            f2676.AddVertex(-0.97361f, 6.95558f, 0.09217f);
            faces.Add(f2676);

            Face f2677 = new Face(m03___Default);
            f2677.AddVertex(-0.97361f, 6.95558f, 0.09217f);
            f2677.AddVertex(-0.94678f, 6.97543f, 0.07773f);
            f2677.AddVertex(-0.95721f, 6.97472f, 0.10519f);
            faces.Add(f2677);

            Face f2678 = new Face(m03___Default);
            f2678.AddVertex(-0.97361f, 6.95558f, 0.09217f);
            f2678.AddVertex(-0.95721f, 6.97472f, 0.10519f);
            f2678.AddVertex(-0.98667f, 6.96037f, 0.12038f);
            faces.Add(f2678);

            Face f2679 = new Face(m03___Default);
            f2679.AddVertex(-0.98667f, 6.96037f, 0.12038f);
            f2679.AddVertex(-0.95721f, 6.97472f, 0.10519f);
            f2679.AddVertex(-0.97316f, 6.98233f, 0.13102f);
            faces.Add(f2679);

            Face f2680 = new Face(m03___Default);
            f2680.AddVertex(-0.94278f, 6.98439f, 0.05106f);
            f2680.AddVertex(-0.92636f, 7.01333f, 0.04139f);
            f2680.AddVertex(-0.92545f, 7.00537f, 0.06507f);
            faces.Add(f2680);

            Face f2681 = new Face(m03___Default);
            f2681.AddVertex(-0.94278f, 6.98439f, 0.05106f);
            f2681.AddVertex(-0.92545f, 7.00537f, 0.06507f);
            f2681.AddVertex(-0.94678f, 6.97543f, 0.07773f);
            faces.Add(f2681);

            Face f2682 = new Face(m03___Default);
            f2682.AddVertex(-0.94678f, 6.97543f, 0.07773f);
            f2682.AddVertex(-0.92545f, 7.00537f, 0.06507f);
            f2682.AddVertex(-0.93168f, 7.00221f, 0.09039f);
            faces.Add(f2682);

            Face f2683 = new Face(m03___Default);
            f2683.AddVertex(-0.94678f, 6.97543f, 0.07773f);
            f2683.AddVertex(-0.93168f, 7.00221f, 0.09039f);
            f2683.AddVertex(-0.95721f, 6.97472f, 0.10519f);
            faces.Add(f2683);

            Face f2684 = new Face(m03___Default);
            f2684.AddVertex(-0.95721f, 6.97472f, 0.10519f);
            f2684.AddVertex(-0.93168f, 7.00221f, 0.09039f);
            f2684.AddVertex(-0.94458f, 7.00408f, 0.11544f);
            faces.Add(f2684);

            Face f2685 = new Face(m03___Default);
            f2685.AddVertex(-0.95721f, 6.97472f, 0.10519f);
            f2685.AddVertex(-0.94458f, 7.00408f, 0.11544f);
            f2685.AddVertex(-0.97316f, 6.98233f, 0.13102f);
            faces.Add(f2685);

            Face f2686 = new Face(m03___Default);
            f2686.AddVertex(-0.97316f, 6.98233f, 0.13102f);
            f2686.AddVertex(-0.94458f, 7.00408f, 0.11544f);
            f2686.AddVertex(-0.96317f, 7.01084f, 0.13829f);
            faces.Add(f2686);

            Face f2687 = new Face(m03___Default);
            f2687.AddVertex(0.14084f, 6.52931f, 0.10319f);
            f2687.AddVertex(0.15707f, 6.50734f, 0.10431f);
            f2687.AddVertex(0.15243f, 6.52079f, 0.07967f);
            faces.Add(f2687);

            Face f2688 = new Face(m03___Default);
            f2688.AddVertex(0.15707f, 6.50734f, 0.10431f);
            f2688.AddVertex(0.16473f, 6.48024f, 0.10560f);
            f2688.AddVertex(0.16622f, 6.49591f, 0.08064f);
            faces.Add(f2688);

            Face f2689 = new Face(m03___Default);
            f2689.AddVertex(0.15707f, 6.50734f, 0.10431f);
            f2689.AddVertex(0.16622f, 6.49591f, 0.08064f);
            f2689.AddVertex(0.15243f, 6.52079f, 0.07967f);
            faces.Add(f2689);

            Face f2690 = new Face(m03___Default);
            f2690.AddVertex(0.15243f, 6.52079f, 0.07967f);
            f2690.AddVertex(0.16622f, 6.49591f, 0.08064f);
            f2690.AddVertex(0.15580f, 6.50610f, 0.05820f);
            faces.Add(f2690);

            Face f2691 = new Face(m03___Default);
            f2691.AddVertex(0.16473f, 6.48024f, 0.10560f);
            f2691.AddVertex(0.16326f, 6.45006f, 0.10696f);
            f2691.AddVertex(0.17010f, 6.46474f, 0.08191f);
            faces.Add(f2691);

            Face f2692 = new Face(m03___Default);
            f2692.AddVertex(0.16473f, 6.48024f, 0.10560f);
            f2692.AddVertex(0.17010f, 6.46474f, 0.08191f);
            f2692.AddVertex(0.16622f, 6.49591f, 0.08064f);
            faces.Add(f2692);

            Face f2693 = new Face(m03___Default);
            f2693.AddVertex(0.16622f, 6.49591f, 0.08064f);
            f2693.AddVertex(0.17010f, 6.46474f, 0.08191f);
            f2693.AddVertex(0.16579f, 6.47722f, 0.05905f);
            faces.Add(f2693);

            Face f2694 = new Face(m03___Default);
            f2694.AddVertex(0.16622f, 6.49591f, 0.08064f);
            f2694.AddVertex(0.16579f, 6.47722f, 0.05905f);
            f2694.AddVertex(0.15580f, 6.50610f, 0.05820f);
            faces.Add(f2694);

            Face f2695 = new Face(m03___Default);
            f2695.AddVertex(0.15580f, 6.50610f, 0.05820f);
            f2695.AddVertex(0.16579f, 6.47722f, 0.05905f);
            f2695.AddVertex(0.15072f, 6.48637f, 0.04040f);
            faces.Add(f2695);

            Face f2696 = new Face(m03___Default);
            f2696.AddVertex(0.16326f, 6.45006f, 0.10696f);
            f2696.AddVertex(0.15276f, 6.41910f, 0.10827f);
            f2696.AddVertex(0.16225f, 6.42983f, 0.08387f);
            faces.Add(f2696);

            Face f2697 = new Face(m03___Default);
            f2697.AddVertex(0.16326f, 6.45006f, 0.10696f);
            f2697.AddVertex(0.16225f, 6.42983f, 0.08387f);
            f2697.AddVertex(0.17010f, 6.46474f, 0.08191f);
            faces.Add(f2697);

            Face f2698 = new Face(m03___Default);
            f2698.AddVertex(0.17010f, 6.46474f, 0.08191f);
            f2698.AddVertex(0.16225f, 6.42983f, 0.08387f);
            f2698.AddVertex(0.16280f, 6.44131f, 0.06119f);
            faces.Add(f2698);

            Face f2699 = new Face(m03___Default);
            f2699.AddVertex(0.17010f, 6.46474f, 0.08191f);
            f2699.AddVertex(0.16280f, 6.44131f, 0.06119f);
            f2699.AddVertex(0.16579f, 6.47722f, 0.05905f);
            faces.Add(f2699);

            Face f2700 = new Face(m03___Default);
            f2700.AddVertex(0.16579f, 6.47722f, 0.05905f);
            f2700.AddVertex(0.16280f, 6.44131f, 0.06119f);
            f2700.AddVertex(0.15436f, 6.45270f, 0.04195f);
            faces.Add(f2700);

            Face f2701 = new Face(m03___Default);
            f2701.AddVertex(0.16579f, 6.47722f, 0.05905f);
            f2701.AddVertex(0.15436f, 6.45270f, 0.04195f);
            f2701.AddVertex(0.15072f, 6.48637f, 0.04040f);
            faces.Add(f2701);

            Face f2702 = new Face(m03___Default);
            f2702.AddVertex(0.15072f, 6.48637f, 0.04040f);
            f2702.AddVertex(0.15436f, 6.45270f, 0.04195f);
            f2702.AddVertex(0.13756f, 6.46310f, 0.02763f);
            faces.Add(f2702);

            Face f2703 = new Face(m03___Default);
            f2703.AddVertex(0.14084f, 6.52931f, 0.10319f);
            f2703.AddVertex(0.15243f, 6.52079f, 0.07967f);
            f2703.AddVertex(0.12672f, 6.54131f, 0.08770f);
            faces.Add(f2703);

            Face f2704 = new Face(m03___Default);
            f2704.AddVertex(0.15243f, 6.52079f, 0.07967f);
            f2704.AddVertex(0.15580f, 6.50610f, 0.05820f);
            f2704.AddVertex(0.13553f, 6.53027f, 0.06384f);
            faces.Add(f2704);

            Face f2705 = new Face(m03___Default);
            f2705.AddVertex(0.15243f, 6.52079f, 0.07967f);
            f2705.AddVertex(0.13553f, 6.53027f, 0.06384f);
            f2705.AddVertex(0.12672f, 6.54131f, 0.08770f);
            faces.Add(f2705);

            Face f2706 = new Face(m03___Default);
            f2706.AddVertex(0.12672f, 6.54131f, 0.08770f);
            f2706.AddVertex(0.13553f, 6.53027f, 0.06384f);
            f2706.AddVertex(0.10635f, 6.54558f, 0.07365f);
            faces.Add(f2706);

            Face f2707 = new Face(m03___Default);
            f2707.AddVertex(0.15580f, 6.50610f, 0.05820f);
            f2707.AddVertex(0.15072f, 6.48637f, 0.04040f);
            f2707.AddVertex(0.13489f, 6.51180f, 0.04213f);
            faces.Add(f2707);

            Face f2708 = new Face(m03___Default);
            f2708.AddVertex(0.15580f, 6.50610f, 0.05820f);
            f2708.AddVertex(0.13489f, 6.51180f, 0.04213f);
            f2708.AddVertex(0.13553f, 6.53027f, 0.06384f);
            faces.Add(f2708);

            Face f2709 = new Face(m03___Default);
            f2709.AddVertex(0.13553f, 6.53027f, 0.06384f);
            f2709.AddVertex(0.13489f, 6.51180f, 0.04213f);
            f2709.AddVertex(0.11104f, 6.53084f, 0.04958f);
            faces.Add(f2709);

            Face f2710 = new Face(m03___Default);
            f2710.AddVertex(0.13553f, 6.53027f, 0.06384f);
            f2710.AddVertex(0.11104f, 6.53084f, 0.04958f);
            f2710.AddVertex(0.10635f, 6.54558f, 0.07365f);
            faces.Add(f2710);

            Face f2711 = new Face(m03___Default);
            f2711.AddVertex(0.10635f, 6.54558f, 0.07365f);
            f2711.AddVertex(0.11104f, 6.53084f, 0.04958f);
            f2711.AddVertex(0.08129f, 6.54181f, 0.06209f);
            faces.Add(f2711);

            Face f2712 = new Face(m03___Default);
            f2712.AddVertex(0.15072f, 6.48637f, 0.04040f);
            f2712.AddVertex(0.13756f, 6.46310f, 0.02763f);
            f2712.AddVertex(0.12401f, 6.48666f, 0.02535f);
            faces.Add(f2712);

            Face f2713 = new Face(m03___Default);
            f2713.AddVertex(0.15072f, 6.48637f, 0.04040f);
            f2713.AddVertex(0.12401f, 6.48666f, 0.02535f);
            f2713.AddVertex(0.13489f, 6.51180f, 0.04213f);
            faces.Add(f2713);

            Face f2714 = new Face(m03___Default);
            f2714.AddVertex(0.13489f, 6.51180f, 0.04213f);
            f2714.AddVertex(0.12401f, 6.48666f, 0.02535f);
            f2714.AddVertex(0.10443f, 6.50666f, 0.02923f);
            faces.Add(f2714);

            Face f2715 = new Face(m03___Default);
            f2715.AddVertex(0.13489f, 6.51180f, 0.04213f);
            f2715.AddVertex(0.10443f, 6.50666f, 0.02923f);
            f2715.AddVertex(0.11104f, 6.53084f, 0.04958f);
            faces.Add(f2715);

            Face f2716 = new Face(m03___Default);
            f2716.AddVertex(0.11104f, 6.53084f, 0.04958f);
            f2716.AddVertex(0.10443f, 6.50666f, 0.02923f);
            f2716.AddVertex(0.08029f, 6.52157f, 0.03901f);
            faces.Add(f2716);

            Face f2717 = new Face(m03___Default);
            f2717.AddVertex(0.11104f, 6.53084f, 0.04958f);
            f2717.AddVertex(0.08029f, 6.52157f, 0.03901f);
            f2717.AddVertex(0.08129f, 6.54181f, 0.06209f);
            faces.Add(f2717);

            Face f2718 = new Face(m03___Default);
            f2718.AddVertex(0.08129f, 6.54181f, 0.06209f);
            f2718.AddVertex(0.08029f, 6.52157f, 0.03901f);
            f2718.AddVertex(0.05344f, 6.53027f, 0.05391f);
            faces.Add(f2718);

            Face f2719 = new Face(m03___Default);
            f2719.AddVertex(0.14084f, 6.52931f, 0.10319f);
            f2719.AddVertex(0.12672f, 6.54131f, 0.08770f);
            f2719.AddVertex(0.11548f, 6.54054f, 0.11731f);
            faces.Add(f2719);

            Face f2720 = new Face(m03___Default);
            f2720.AddVertex(0.12672f, 6.54131f, 0.08770f);
            f2720.AddVertex(0.10635f, 6.54558f, 0.07365f);
            f2720.AddVertex(0.09815f, 6.55025f, 0.10190f);
            faces.Add(f2720);

            Face f2721 = new Face(m03___Default);
            f2721.AddVertex(0.12672f, 6.54131f, 0.08770f);
            f2721.AddVertex(0.09815f, 6.55025f, 0.10190f);
            f2721.AddVertex(0.11548f, 6.54054f, 0.11731f);
            faces.Add(f2721);

            Face f2722 = new Face(m03___Default);
            f2722.AddVertex(0.11548f, 6.54054f, 0.11731f);
            f2722.AddVertex(0.09815f, 6.55025f, 0.10190f);
            f2722.AddVertex(0.08472f, 6.54412f, 0.13060f);
            faces.Add(f2722);

            Face f2723 = new Face(m03___Default);
            f2723.AddVertex(0.10635f, 6.54558f, 0.07365f);
            f2723.AddVertex(0.08129f, 6.54181f, 0.06209f);
            f2723.AddVertex(0.07340f, 6.55097f, 0.08791f);
            faces.Add(f2723);

            Face f2724 = new Face(m03___Default);
            f2724.AddVertex(0.10635f, 6.54558f, 0.07365f);
            f2724.AddVertex(0.07340f, 6.55097f, 0.08791f);
            f2724.AddVertex(0.09815f, 6.55025f, 0.10190f);
            faces.Add(f2724);

            Face f2725 = new Face(m03___Default);
            f2725.AddVertex(0.09815f, 6.55025f, 0.10190f);
            f2725.AddVertex(0.07340f, 6.55097f, 0.08791f);
            f2725.AddVertex(0.06297f, 6.55026f, 0.11538f);
            faces.Add(f2725);

            Face f2726 = new Face(m03___Default);
            f2726.AddVertex(0.09815f, 6.55025f, 0.10190f);
            f2726.AddVertex(0.06297f, 6.55026f, 0.11538f);
            f2726.AddVertex(0.08472f, 6.54412f, 0.13060f);
            faces.Add(f2726);

            Face f2727 = new Face(m03___Default);
            f2727.AddVertex(0.08472f, 6.54412f, 0.13060f);
            f2727.AddVertex(0.06297f, 6.55026f, 0.11538f);
            f2727.AddVertex(0.05091f, 6.53974f, 0.14205f);
            faces.Add(f2727);

            Face f2728 = new Face(m03___Default);
            f2728.AddVertex(0.08129f, 6.54181f, 0.06209f);
            f2728.AddVertex(0.05344f, 6.53027f, 0.05391f);
            f2728.AddVertex(0.04333f, 6.54133f, 0.07664f);
            faces.Add(f2728);

            Face f2729 = new Face(m03___Default);
            f2729.AddVertex(0.08129f, 6.54181f, 0.06209f);
            f2729.AddVertex(0.04333f, 6.54133f, 0.07664f);
            f2729.AddVertex(0.07340f, 6.55097f, 0.08791f);
            faces.Add(f2729);

            Face f2730 = new Face(m03___Default);
            f2730.AddVertex(0.07340f, 6.55097f, 0.08791f);
            f2730.AddVertex(0.04333f, 6.54133f, 0.07664f);
            f2730.AddVertex(0.03334f, 6.54468f, 0.10164f);
            faces.Add(f2730);

            Face f2731 = new Face(m03___Default);
            f2731.AddVertex(0.07340f, 6.55097f, 0.08791f);
            f2731.AddVertex(0.03334f, 6.54468f, 0.10164f);
            f2731.AddVertex(0.06297f, 6.55026f, 0.11538f);
            faces.Add(f2731);

            Face f2732 = new Face(m03___Default);
            f2732.AddVertex(0.06297f, 6.55026f, 0.11538f);
            f2732.AddVertex(0.03334f, 6.54468f, 0.10164f);
            f2732.AddVertex(0.02420f, 6.54003f, 0.12700f);
            faces.Add(f2732);

            Face f2733 = new Face(m03___Default);
            f2733.AddVertex(0.06297f, 6.55026f, 0.11538f);
            f2733.AddVertex(0.02420f, 6.54003f, 0.12700f);
            f2733.AddVertex(0.05091f, 6.53974f, 0.14205f);
            faces.Add(f2733);

            Face f2734 = new Face(m03___Default);
            f2734.AddVertex(0.05091f, 6.53974f, 0.14205f);
            f2734.AddVertex(0.02420f, 6.54003f, 0.12700f);
            f2734.AddVertex(0.01663f, 6.52777f, 0.15080f);
            faces.Add(f2734);

            Face f2735 = new Face(m03___Default);
            f2735.AddVertex(0.14084f, 6.52931f, 0.10319f);
            f2735.AddVertex(0.11548f, 6.54054f, 0.11731f);
            f2735.AddVertex(0.13423f, 6.51956f, 0.12757f);
            faces.Add(f2735);

            Face f2736 = new Face(m03___Default);
            f2736.AddVertex(0.11548f, 6.54054f, 0.11731f);
            f2736.AddVertex(0.08472f, 6.54412f, 0.13060f);
            f2736.AddVertex(0.10575f, 6.52825f, 0.14223f);
            faces.Add(f2736);

            Face f2737 = new Face(m03___Default);
            f2737.AddVertex(0.11548f, 6.54054f, 0.11731f);
            f2737.AddVertex(0.10575f, 6.52825f, 0.14223f);
            f2737.AddVertex(0.13423f, 6.51956f, 0.12757f);
            faces.Add(f2737);

            Face f2738 = new Face(m03___Default);
            f2738.AddVertex(0.13423f, 6.51956f, 0.12757f);
            f2738.AddVertex(0.10575f, 6.52825f, 0.14223f);
            f2738.AddVertex(0.12080f, 6.50373f, 0.15035f);
            faces.Add(f2738);

            Face f2739 = new Face(m03___Default);
            f2739.AddVertex(0.08472f, 6.54412f, 0.13060f);
            f2739.AddVertex(0.05091f, 6.53974f, 0.14205f);
            f2739.AddVertex(0.07062f, 6.52811f, 0.15598f);
            faces.Add(f2739);

            Face f2740 = new Face(m03___Default);
            f2740.AddVertex(0.08472f, 6.54412f, 0.13060f);
            f2740.AddVertex(0.07062f, 6.52811f, 0.15598f);
            f2740.AddVertex(0.10575f, 6.52825f, 0.14223f);
            faces.Add(f2740);

            Face f2741 = new Face(m03___Default);
            f2741.AddVertex(0.10575f, 6.52825f, 0.14223f);
            f2741.AddVertex(0.07062f, 6.52811f, 0.15598f);
            f2741.AddVertex(0.08802f, 6.50863f, 0.16551f);
            faces.Add(f2741);

            Face f2742 = new Face(m03___Default);
            f2742.AddVertex(0.10575f, 6.52825f, 0.14223f);
            f2742.AddVertex(0.08802f, 6.50863f, 0.16551f);
            f2742.AddVertex(0.12080f, 6.50373f, 0.15035f);
            faces.Add(f2742);

            Face f2743 = new Face(m03___Default);
            f2743.AddVertex(0.12080f, 6.50373f, 0.15035f);
            f2743.AddVertex(0.08802f, 6.50863f, 0.16551f);
            f2743.AddVertex(0.10157f, 6.48304f, 0.16979f);
            faces.Add(f2743);

            Face f2744 = new Face(m03___Default);
            f2744.AddVertex(0.05091f, 6.53974f, 0.14205f);
            f2744.AddVertex(0.01663f, 6.52777f, 0.15080f);
            f2744.AddVertex(0.03171f, 6.51829f, 0.16687f);
            faces.Add(f2744);

            Face f2745 = new Face(m03___Default);
            f2745.AddVertex(0.05091f, 6.53974f, 0.14205f);
            f2745.AddVertex(0.03171f, 6.51829f, 0.16687f);
            f2745.AddVertex(0.07062f, 6.52811f, 0.15598f);
            faces.Add(f2745);

            Face f2746 = new Face(m03___Default);
            f2746.AddVertex(0.07062f, 6.52811f, 0.15598f);
            f2746.AddVertex(0.03171f, 6.51829f, 0.16687f);
            f2746.AddVertex(0.04778f, 6.50283f, 0.17834f);
            faces.Add(f2746);

            Face f2747 = new Face(m03___Default);
            f2747.AddVertex(0.07062f, 6.52811f, 0.15598f);
            f2747.AddVertex(0.04778f, 6.50283f, 0.17834f);
            f2747.AddVertex(0.08802f, 6.50863f, 0.16551f);
            faces.Add(f2747);

            Face f2748 = new Face(m03___Default);
            f2748.AddVertex(0.08802f, 6.50863f, 0.16551f);
            f2748.AddVertex(0.04778f, 6.50283f, 0.17834f);
            f2748.AddVertex(0.06362f, 6.48257f, 0.18433f);
            faces.Add(f2748);

            Face f2749 = new Face(m03___Default);
            f2749.AddVertex(0.08802f, 6.50863f, 0.16551f);
            f2749.AddVertex(0.06362f, 6.48257f, 0.18433f);
            f2749.AddVertex(0.10157f, 6.48304f, 0.16979f);
            faces.Add(f2749);

            Face f2750 = new Face(m03___Default);
            f2750.AddVertex(0.10157f, 6.48304f, 0.16979f);
            f2750.AddVertex(0.06362f, 6.48257f, 0.18433f);
            f2750.AddVertex(0.07801f, 6.45906f, 0.18440f);
            faces.Add(f2750);

            Face f2751 = new Face(m03___Default);
            f2751.AddVertex(0.14084f, 6.52931f, 0.10319f);
            f2751.AddVertex(0.13423f, 6.51956f, 0.12757f);
            f2751.AddVertex(0.15707f, 6.50734f, 0.10431f);
            faces.Add(f2751);

            Face f2752 = new Face(m03___Default);
            f2752.AddVertex(0.13423f, 6.51956f, 0.12757f);
            f2752.AddVertex(0.12080f, 6.50373f, 0.15035f);
            f2752.AddVertex(0.14781f, 6.49466f, 0.12908f);
            faces.Add(f2752);

            Face f2753 = new Face(m03___Default);
            f2753.AddVertex(0.13423f, 6.51956f, 0.12757f);
            f2753.AddVertex(0.14781f, 6.49466f, 0.12908f);
            f2753.AddVertex(0.15707f, 6.50734f, 0.10431f);
            faces.Add(f2753);

            Face f2754 = new Face(m03___Default);
            f2754.AddVertex(0.15707f, 6.50734f, 0.10431f);
            f2754.AddVertex(0.14781f, 6.49466f, 0.12908f);
            f2754.AddVertex(0.16473f, 6.48024f, 0.10560f);
            faces.Add(f2754);

            Face f2755 = new Face(m03___Default);
            f2755.AddVertex(0.12080f, 6.50373f, 0.15035f);
            f2755.AddVertex(0.10157f, 6.48304f, 0.16979f);
            f2755.AddVertex(0.13038f, 6.47482f, 0.15227f);
            faces.Add(f2755);

            Face f2756 = new Face(m03___Default);
            f2756.AddVertex(0.12080f, 6.50373f, 0.15035f);
            f2756.AddVertex(0.13038f, 6.47482f, 0.15227f);
            f2756.AddVertex(0.14781f, 6.49466f, 0.12908f);
            faces.Add(f2756);

            Face f2757 = new Face(m03___Default);
            f2757.AddVertex(0.14781f, 6.49466f, 0.12908f);
            f2757.AddVertex(0.13038f, 6.47482f, 0.15227f);
            f2757.AddVertex(0.15157f, 6.46349f, 0.13069f);
            faces.Add(f2757);

            Face f2758 = new Face(m03___Default);
            f2758.AddVertex(0.14781f, 6.49466f, 0.12908f);
            f2758.AddVertex(0.15157f, 6.46349f, 0.13069f);
            f2758.AddVertex(0.16473f, 6.48024f, 0.10560f);
            faces.Add(f2758);

            Face f2759 = new Face(m03___Default);
            f2759.AddVertex(0.16473f, 6.48024f, 0.10560f);
            f2759.AddVertex(0.15157f, 6.46349f, 0.13069f);
            f2759.AddVertex(0.16326f, 6.45006f, 0.10696f);
            faces.Add(f2759);

            Face f2760 = new Face(m03___Default);
            f2760.AddVertex(0.10157f, 6.48304f, 0.16979f);
            f2760.AddVertex(0.07801f, 6.45906f, 0.18440f);
            f2760.AddVertex(0.10521f, 6.44937f, 0.17134f);
            faces.Add(f2760);

            Face f2761 = new Face(m03___Default);
            f2761.AddVertex(0.10157f, 6.48304f, 0.16979f);
            f2761.AddVertex(0.10521f, 6.44937f, 0.17134f);
            f2761.AddVertex(0.13038f, 6.47482f, 0.15227f);
            faces.Add(f2761);

            Face f2762 = new Face(m03___Default);
            f2762.AddVertex(0.13038f, 6.47482f, 0.15227f);
            f2762.AddVertex(0.10521f, 6.44937f, 0.17134f);
            f2762.AddVertex(0.12780f, 6.43895f, 0.15334f);
            faces.Add(f2762);

            Face f2763 = new Face(m03___Default);
            f2763.AddVertex(0.13038f, 6.47482f, 0.15227f);
            f2763.AddVertex(0.12780f, 6.43895f, 0.15334f);
            f2763.AddVertex(0.15157f, 6.46349f, 0.13069f);
            faces.Add(f2763);

            Face f2764 = new Face(m03___Default);
            f2764.AddVertex(0.15157f, 6.46349f, 0.13069f);
            f2764.AddVertex(0.12780f, 6.43895f, 0.15334f);
            f2764.AddVertex(0.14406f, 6.42859f, 0.13177f);
            faces.Add(f2764);

            Face f2765 = new Face(m03___Default);
            f2765.AddVertex(0.15157f, 6.46349f, 0.13069f);
            f2765.AddVertex(0.14406f, 6.42859f, 0.13177f);
            f2765.AddVertex(0.16326f, 6.45006f, 0.10696f);
            faces.Add(f2765);

            Face f2766 = new Face(m03___Default);
            f2766.AddVertex(0.16326f, 6.45006f, 0.10696f);
            f2766.AddVertex(0.14406f, 6.42859f, 0.13177f);
            f2766.AddVertex(0.15276f, 6.41910f, 0.10827f);
            faces.Add(f2766);

            Face f2767 = new Face(m03___Default);
            f2767.AddVertex(0.15276f, 6.41910f, 0.10827f);
            f2767.AddVertex(0.13119f, 6.39510f, 0.12402f);
            f2767.AddVertex(0.14244f, 6.39586f, 0.09442f);
            faces.Add(f2767);

            Face f2768 = new Face(m03___Default);
            f2768.AddVertex(0.13119f, 6.39510f, 0.12402f);
            f2768.AddVertex(0.10305f, 6.37451f, 0.13843f);
            f2768.AddVertex(0.11742f, 6.37191f, 0.11013f);
            faces.Add(f2768);

            Face f2769 = new Face(m03___Default);
            f2769.AddVertex(0.13119f, 6.39510f, 0.12402f);
            f2769.AddVertex(0.11742f, 6.37191f, 0.11013f);
            f2769.AddVertex(0.14244f, 6.39586f, 0.09442f);
            faces.Add(f2769);

            Face f2770 = new Face(m03___Default);
            f2770.AddVertex(0.14244f, 6.39586f, 0.09442f);
            f2770.AddVertex(0.11742f, 6.37191f, 0.11013f);
            f2770.AddVertex(0.12468f, 6.37597f, 0.08147f);
            faces.Add(f2770);

            Face f2771 = new Face(m03___Default);
            f2771.AddVertex(0.10305f, 6.37451f, 0.13843f);
            f2771.AddVertex(0.07045f, 6.35889f, 0.15040f);
            f2771.AddVertex(0.08442f, 6.35177f, 0.12454f);
            faces.Add(f2771);

            Face f2772 = new Face(m03___Default);
            f2772.AddVertex(0.10305f, 6.37451f, 0.13843f);
            f2772.AddVertex(0.08442f, 6.35177f, 0.12454f);
            f2772.AddVertex(0.11742f, 6.37191f, 0.11013f);
            faces.Add(f2772);

            Face f2773 = new Face(m03___Default);
            f2773.AddVertex(0.11742f, 6.37191f, 0.11013f);
            f2773.AddVertex(0.08442f, 6.35177f, 0.12454f);
            f2773.AddVertex(0.09485f, 6.35248f, 0.09707f);
            faces.Add(f2773);

            Face f2774 = new Face(m03___Default);
            f2774.AddVertex(0.11742f, 6.37191f, 0.11013f);
            f2774.AddVertex(0.09485f, 6.35248f, 0.09707f);
            f2774.AddVertex(0.12468f, 6.37597f, 0.08147f);
            faces.Add(f2774);

            Face f2775 = new Face(m03___Default);
            f2775.AddVertex(0.12468f, 6.37597f, 0.08147f);
            f2775.AddVertex(0.09485f, 6.35248f, 0.09707f);
            f2775.AddVertex(0.10083f, 6.36095f, 0.07044f);
            faces.Add(f2775);

            Face f2776 = new Face(m03___Default);
            f2776.AddVertex(0.07045f, 6.35889f, 0.15040f);
            f2776.AddVertex(0.03590f, 6.34944f, 0.15904f);
            f2776.AddVertex(0.04599f, 6.33837f, 0.13631f);
            faces.Add(f2776);

            Face f2777 = new Face(m03___Default);
            f2777.AddVertex(0.07045f, 6.35889f, 0.15040f);
            f2777.AddVertex(0.04599f, 6.33837f, 0.13631f);
            f2777.AddVertex(0.08442f, 6.35177f, 0.12454f);
            faces.Add(f2777);

            Face f2778 = new Face(m03___Default);
            f2778.AddVertex(0.08442f, 6.35177f, 0.12454f);
            f2778.AddVertex(0.04599f, 6.33837f, 0.13631f);
            f2778.AddVertex(0.05599f, 6.33503f, 0.11131f);
            faces.Add(f2778);

            Face f2779 = new Face(m03___Default);
            f2779.AddVertex(0.08442f, 6.35177f, 0.12454f);
            f2779.AddVertex(0.05599f, 6.33503f, 0.11131f);
            f2779.AddVertex(0.09485f, 6.35248f, 0.09707f);
            faces.Add(f2779);

            Face f2780 = new Face(m03___Default);
            f2780.AddVertex(0.09485f, 6.35248f, 0.09707f);
            f2780.AddVertex(0.05599f, 6.33503f, 0.11131f);
            f2780.AddVertex(0.06513f, 6.33967f, 0.08595f);
            faces.Add(f2780);

            Face f2781 = new Face(m03___Default);
            f2781.AddVertex(0.09485f, 6.35248f, 0.09707f);
            f2781.AddVertex(0.06513f, 6.33967f, 0.08595f);
            f2781.AddVertex(0.10083f, 6.36095f, 0.07044f);
            faces.Add(f2781);

            Face f2782 = new Face(m03___Default);
            f2782.AddVertex(0.10083f, 6.36095f, 0.07044f);
            f2782.AddVertex(0.06513f, 6.33967f, 0.08595f);
            f2782.AddVertex(0.07270f, 6.35193f, 0.06214f);
            faces.Add(f2782);

            Face f2783 = new Face(m03___Default);
            f2783.AddVertex(0.13756f, 6.46310f, 0.02763f);
            f2783.AddVertex(0.12990f, 6.43218f, 0.02786f);
            f2783.AddVertex(0.11115f, 6.45317f, 0.01759f);
            faces.Add(f2783);

            Face f2784 = new Face(m03___Default);
            f2784.AddVertex(0.12990f, 6.43218f, 0.02786f);
            f2784.AddVertex(0.11575f, 6.40184f, 0.03407f);
            f2784.AddVertex(0.10044f, 6.42111f, 0.01996f);
            faces.Add(f2784);

            Face f2785 = new Face(m03___Default);
            f2785.AddVertex(0.12990f, 6.43218f, 0.02786f);
            f2785.AddVertex(0.10044f, 6.42111f, 0.01996f);
            f2785.AddVertex(0.11115f, 6.45317f, 0.01759f);
            faces.Add(f2785);

            Face f2786 = new Face(m03___Default);
            f2786.AddVertex(0.11115f, 6.45317f, 0.01759f);
            f2786.AddVertex(0.10044f, 6.42111f, 0.01996f);
            f2786.AddVertex(0.07967f, 6.44222f, 0.01432f);
            faces.Add(f2786);

            Face f2787 = new Face(m03___Default);
            f2787.AddVertex(0.11575f, 6.40184f, 0.03407f);
            f2787.AddVertex(0.09619f, 6.37439f, 0.04580f);
            f2787.AddVertex(0.08212f, 6.38939f, 0.02943f);
            faces.Add(f2787);

            Face f2788 = new Face(m03___Default);
            f2788.AddVertex(0.11575f, 6.40184f, 0.03407f);
            f2788.AddVertex(0.08212f, 6.38939f, 0.02943f);
            f2788.AddVertex(0.10044f, 6.42111f, 0.01996f);
            faces.Add(f2788);

            Face f2789 = new Face(m03___Default);
            f2789.AddVertex(0.10044f, 6.42111f, 0.01996f);
            f2789.AddVertex(0.08212f, 6.38939f, 0.02943f);
            f2789.AddVertex(0.06471f, 6.40886f, 0.01990f);
            faces.Add(f2789);

            Face f2790 = new Face(m03___Default);
            f2790.AddVertex(0.10044f, 6.42111f, 0.01996f);
            f2790.AddVertex(0.06471f, 6.40886f, 0.01990f);
            f2790.AddVertex(0.07967f, 6.44222f, 0.01432f);
            faces.Add(f2790);

            Face f2791 = new Face(m03___Default);
            f2791.AddVertex(0.07967f, 6.44222f, 0.01432f);
            f2791.AddVertex(0.06471f, 6.40886f, 0.01990f);
            f2791.AddVertex(0.04553f, 6.43110f, 0.01807f);
            faces.Add(f2791);

            Face f2792 = new Face(m03___Default);
            f2792.AddVertex(0.09619f, 6.37439f, 0.04580f);
            f2792.AddVertex(0.07270f, 6.35193f, 0.06214f);
            f2792.AddVertex(0.05762f, 6.36142f, 0.04607f);
            faces.Add(f2792);

            Face f2793 = new Face(m03___Default);
            f2793.AddVertex(0.09619f, 6.37439f, 0.04580f);
            f2793.AddVertex(0.05762f, 6.36142f, 0.04607f);
            f2793.AddVertex(0.08212f, 6.38939f, 0.02943f);
            faces.Add(f2793);

            Face f2794 = new Face(m03___Default);
            f2794.AddVertex(0.08212f, 6.38939f, 0.02943f);
            f2794.AddVertex(0.05762f, 6.36142f, 0.04607f);
            f2794.AddVertex(0.04154f, 6.37688f, 0.03461f);
            faces.Add(f2794);

            Face f2795 = new Face(m03___Default);
            f2795.AddVertex(0.08212f, 6.38939f, 0.02943f);
            f2795.AddVertex(0.04154f, 6.37688f, 0.03461f);
            f2795.AddVertex(0.06471f, 6.40886f, 0.01990f);
            faces.Add(f2795);

            Face f2796 = new Face(m03___Default);
            f2796.AddVertex(0.06471f, 6.40886f, 0.01990f);
            f2796.AddVertex(0.04154f, 6.37688f, 0.03461f);
            f2796.AddVertex(0.02571f, 6.39714f, 0.02861f);
            faces.Add(f2796);

            Face f2797 = new Face(m03___Default);
            f2797.AddVertex(0.06471f, 6.40886f, 0.01990f);
            f2797.AddVertex(0.02571f, 6.39714f, 0.02861f);
            f2797.AddVertex(0.04553f, 6.43110f, 0.01807f);
            faces.Add(f2797);

            Face f2798 = new Face(m03___Default);
            f2798.AddVertex(0.04553f, 6.43110f, 0.01807f);
            f2798.AddVertex(0.02571f, 6.39714f, 0.02861f);
            f2798.AddVertex(0.01132f, 6.42064f, 0.02855f);
            faces.Add(f2798);

            Face f2799 = new Face(m03___Default);
            f2799.AddVertex(0.05344f, 6.53027f, 0.05391f);
            f2799.AddVertex(0.04171f, 6.50860f, 0.03928f);
            f2799.AddVertex(0.01888f, 6.52081f, 0.06255f);
            faces.Add(f2799);

            Face f2800 = new Face(m03___Default);
            f2800.AddVertex(0.04171f, 6.50860f, 0.03928f);
            f2800.AddVertex(0.03022f, 6.48170f, 0.02977f);
            f2800.AddVertex(0.00638f, 6.49621f, 0.04935f);
            faces.Add(f2800);

            Face f2801 = new Face(m03___Default);
            f2801.AddVertex(0.04171f, 6.50860f, 0.03928f);
            f2801.AddVertex(0.00638f, 6.49621f, 0.04935f);
            f2801.AddVertex(0.01888f, 6.52081f, 0.06255f);
            faces.Add(f2801);

            Face f2802 = new Face(m03___Default);
            f2802.AddVertex(0.01888f, 6.52081f, 0.06255f);
            f2802.AddVertex(0.00638f, 6.49621f, 0.04935f);
            f2802.AddVertex(-0.01371f, 6.50520f, 0.07452f);
            faces.Add(f2802);

            Face f2803 = new Face(m03___Default);
            f2803.AddVertex(0.03022f, 6.48170f, 0.02977f);
            f2803.AddVertex(0.01983f, 6.45162f, 0.02610f);
            f2803.AddVertex(-0.00584f, 6.46520f, 0.04195f);
            faces.Add(f2803);

            Face f2804 = new Face(m03___Default);
            f2804.AddVertex(0.03022f, 6.48170f, 0.02977f);
            f2804.AddVertex(-0.00584f, 6.46520f, 0.04195f);
            f2804.AddVertex(0.00638f, 6.49621f, 0.04935f);
            faces.Add(f2804);

            Face f2805 = new Face(m03___Default);
            f2805.AddVertex(0.00638f, 6.49621f, 0.04935f);
            f2805.AddVertex(-0.00584f, 6.46520f, 0.04195f);
            f2805.AddVertex(-0.02704f, 6.47653f, 0.06353f);
            faces.Add(f2805);

            Face f2806 = new Face(m03___Default);
            f2806.AddVertex(0.00638f, 6.49621f, 0.04935f);
            f2806.AddVertex(-0.02704f, 6.47653f, 0.06353f);
            f2806.AddVertex(-0.01371f, 6.50520f, 0.07452f);
            faces.Add(f2806);

            Face f2807 = new Face(m03___Default);
            f2807.AddVertex(-0.01371f, 6.50520f, 0.07452f);
            f2807.AddVertex(-0.02704f, 6.47653f, 0.06353f);
            f2807.AddVertex(-0.04185f, 6.48461f, 0.08893f);
            faces.Add(f2807);

            Face f2808 = new Face(m03___Default);
            f2808.AddVertex(0.01983f, 6.45162f, 0.02610f);
            f2808.AddVertex(0.01132f, 6.42064f, 0.02855f);
            f2808.AddVertex(-0.01587f, 6.43034f, 0.04161f);
            faces.Add(f2808);

            Face f2809 = new Face(m03___Default);
            f2809.AddVertex(0.01983f, 6.45162f, 0.02610f);
            f2809.AddVertex(-0.01587f, 6.43034f, 0.04161f);
            f2809.AddVertex(-0.00584f, 6.46520f, 0.04195f);
            faces.Add(f2809);

            Face f2810 = new Face(m03___Default);
            f2810.AddVertex(-0.00584f, 6.46520f, 0.04195f);
            f2810.AddVertex(-0.01587f, 6.43034f, 0.04161f);
            f2810.AddVertex(-0.03846f, 6.44076f, 0.05961f);
            faces.Add(f2810);

            Face f2811 = new Face(m03___Default);
            f2811.AddVertex(-0.00584f, 6.46520f, 0.04195f);
            f2811.AddVertex(-0.03846f, 6.44076f, 0.05961f);
            f2811.AddVertex(-0.02704f, 6.47653f, 0.06353f);
            faces.Add(f2811);

            Face f2812 = new Face(m03___Default);
            f2812.AddVertex(-0.02704f, 6.47653f, 0.06353f);
            f2812.AddVertex(-0.03846f, 6.44076f, 0.05961f);
            f2812.AddVertex(-0.05472f, 6.45111f, 0.08118f);
            faces.Add(f2812);

            Face f2813 = new Face(m03___Default);
            f2813.AddVertex(-0.02704f, 6.47653f, 0.06353f);
            f2813.AddVertex(-0.05472f, 6.45111f, 0.08118f);
            f2813.AddVertex(-0.04185f, 6.48461f, 0.08893f);
            faces.Add(f2813);

            Face f2814 = new Face(m03___Default);
            f2814.AddVertex(-0.04185f, 6.48461f, 0.08893f);
            f2814.AddVertex(-0.05472f, 6.45111f, 0.08118f);
            f2814.AddVertex(-0.06341f, 6.46061f, 0.10467f);
            faces.Add(f2814);

            Face f2815 = new Face(m03___Default);
            f2815.AddVertex(0.01663f, 6.52777f, 0.15080f);
            f2815.AddVertex(-0.01149f, 6.51876f, 0.14251f);
            f2815.AddVertex(-0.00685f, 6.50531f, 0.16715f);
            faces.Add(f2815);

            Face f2816 = new Face(m03___Default);
            f2816.AddVertex(-0.01149f, 6.51876f, 0.14251f);
            f2816.AddVertex(-0.03534f, 6.50373f, 0.13147f);
            f2816.AddVertex(-0.03477f, 6.49342f, 0.15768f);
            faces.Add(f2816);

            Face f2817 = new Face(m03___Default);
            f2817.AddVertex(-0.01149f, 6.51876f, 0.14251f);
            f2817.AddVertex(-0.03477f, 6.49342f, 0.15768f);
            f2817.AddVertex(-0.00685f, 6.50531f, 0.16715f);
            faces.Add(f2817);

            Face f2818 = new Face(m03___Default);
            f2818.AddVertex(-0.00685f, 6.50531f, 0.16715f);
            f2818.AddVertex(-0.03477f, 6.49342f, 0.15768f);
            f2818.AddVertex(-0.02642f, 6.47787f, 0.17888f);
            faces.Add(f2818);

            Face f2819 = new Face(m03___Default);
            f2819.AddVertex(-0.03534f, 6.50373f, 0.13147f);
            f2819.AddVertex(-0.05310f, 6.48384f, 0.11853f);
            f2819.AddVertex(-0.05791f, 6.47445f, 0.14480f);
            faces.Add(f2819);

            Face f2820 = new Face(m03___Default);
            f2820.AddVertex(-0.03534f, 6.50373f, 0.13147f);
            f2820.AddVertex(-0.05791f, 6.47445f, 0.14480f);
            f2820.AddVertex(-0.03477f, 6.49342f, 0.15768f);
            faces.Add(f2820);

            Face f2821 = new Face(m03___Default);
            f2821.AddVertex(-0.03477f, 6.49342f, 0.15768f);
            f2821.AddVertex(-0.05791f, 6.47445f, 0.14480f);
            f2821.AddVertex(-0.05360f, 6.46197f, 0.16767f);
            faces.Add(f2821);

            Face f2822 = new Face(m03___Default);
            f2822.AddVertex(-0.03477f, 6.49342f, 0.15768f);
            f2822.AddVertex(-0.05360f, 6.46197f, 0.16767f);
            f2822.AddVertex(-0.02642f, 6.47787f, 0.17888f);
            faces.Add(f2822);

            Face f2823 = new Face(m03___Default);
            f2823.AddVertex(-0.02642f, 6.47787f, 0.17888f);
            f2823.AddVertex(-0.05360f, 6.46197f, 0.16767f);
            f2823.AddVertex(-0.04056f, 6.44752f, 0.18509f);
            faces.Add(f2823);

            Face f2824 = new Face(m03___Default);
            f2824.AddVertex(-0.05310f, 6.48384f, 0.11853f);
            f2824.AddVertex(-0.06341f, 6.46061f, 0.10467f);
            f2824.AddVertex(-0.07292f, 6.44988f, 0.12908f);
            faces.Add(f2824);

            Face f2825 = new Face(m03___Default);
            f2825.AddVertex(-0.05310f, 6.48384f, 0.11853f);
            f2825.AddVertex(-0.07292f, 6.44988f, 0.12908f);
            f2825.AddVertex(-0.05791f, 6.47445f, 0.14480f);
            faces.Add(f2825);

            Face f2826 = new Face(m03___Default);
            f2826.AddVertex(-0.05791f, 6.47445f, 0.14480f);
            f2826.AddVertex(-0.07292f, 6.44988f, 0.12908f);
            f2826.AddVertex(-0.07347f, 6.43839f, 0.15176f);
            faces.Add(f2826);

            Face f2827 = new Face(m03___Default);
            f2827.AddVertex(-0.05791f, 6.47445f, 0.14480f);
            f2827.AddVertex(-0.07347f, 6.43839f, 0.15176f);
            f2827.AddVertex(-0.05360f, 6.46197f, 0.16767f);
            faces.Add(f2827);

            Face f2828 = new Face(m03___Default);
            f2828.AddVertex(-0.05360f, 6.46197f, 0.16767f);
            f2828.AddVertex(-0.07347f, 6.43839f, 0.15176f);
            f2828.AddVertex(-0.06502f, 6.42701f, 0.17100f);
            faces.Add(f2828);

            Face f2829 = new Face(m03___Default);
            f2829.AddVertex(-0.05360f, 6.46197f, 0.16767f);
            f2829.AddVertex(-0.06502f, 6.42701f, 0.17100f);
            f2829.AddVertex(-0.04056f, 6.44752f, 0.18509f);
            faces.Add(f2829);

            Face f2830 = new Face(m03___Default);
            f2830.AddVertex(-0.04056f, 6.44752f, 0.18509f);
            f2830.AddVertex(-0.06502f, 6.42701f, 0.17100f);
            f2830.AddVertex(-0.04823f, 6.41660f, 0.18532f);
            faces.Add(f2830);

            Face f2831 = new Face(m03___Default);
            f2831.AddVertex(0.07801f, 6.45906f, 0.18440f);
            f2831.AddVertex(0.04380f, 6.44861f, 0.19488f);
            f2831.AddVertex(0.06951f, 6.42809f, 0.18685f);
            faces.Add(f2831);

            Face f2832 = new Face(m03___Default);
            f2832.AddVertex(0.04380f, 6.44861f, 0.19488f);
            f2832.AddVertex(0.00966f, 6.43748f, 0.19862f);
            f2832.AddVertex(0.03385f, 6.41660f, 0.19524f);
            faces.Add(f2832);

            Face f2833 = new Face(m03___Default);
            f2833.AddVertex(0.04380f, 6.44861f, 0.19488f);
            f2833.AddVertex(0.03385f, 6.41660f, 0.19524f);
            f2833.AddVertex(0.06951f, 6.42809f, 0.18685f);
            faces.Add(f2833);

            Face f2834 = new Face(m03___Default);
            f2834.AddVertex(0.06951f, 6.42809f, 0.18685f);
            f2834.AddVertex(0.03385f, 6.41660f, 0.19524f);
            f2834.AddVertex(0.05911f, 6.39800f, 0.18317f);
            faces.Add(f2834);

            Face f2835 = new Face(m03___Default);
            f2835.AddVertex(0.00966f, 6.43748f, 0.19862f);
            f2835.AddVertex(-0.02181f, 6.42654f, 0.19535f);
            f2835.AddVertex(-0.00212f, 6.40434f, 0.19585f);
            faces.Add(f2835);

            Face f2836 = new Face(m03___Default);
            f2836.AddVertex(0.00966f, 6.43748f, 0.19862f);
            f2836.AddVertex(-0.00212f, 6.40434f, 0.19585f);
            f2836.AddVertex(0.03385f, 6.41660f, 0.19524f);
            faces.Add(f2836);

            Face f2837 = new Face(m03___Default);
            f2837.AddVertex(0.03385f, 6.41660f, 0.19524f);
            f2837.AddVertex(-0.00212f, 6.40434f, 0.19585f);
            f2837.AddVertex(0.02172f, 6.38530f, 0.18839f);
            faces.Add(f2837);

            Face f2838 = new Face(m03___Default);
            f2838.AddVertex(0.03385f, 6.41660f, 0.19524f);
            f2838.AddVertex(0.02172f, 6.38530f, 0.18839f);
            f2838.AddVertex(0.05911f, 6.39800f, 0.18317f);
            faces.Add(f2838);

            Face f2839 = new Face(m03___Default);
            f2839.AddVertex(0.05911f, 6.39800f, 0.18317f);
            f2839.AddVertex(0.02172f, 6.38530f, 0.18839f);
            f2839.AddVertex(0.04762f, 6.37110f, 0.17366f);
            faces.Add(f2839);

            Face f2840 = new Face(m03___Default);
            f2840.AddVertex(-0.02181f, 6.42654f, 0.19535f);
            f2840.AddVertex(-0.04823f, 6.41660f, 0.18532f);
            f2840.AddVertex(-0.03468f, 6.39304f, 0.18761f);
            faces.Add(f2840);

            Face f2841 = new Face(m03___Default);
            f2841.AddVertex(-0.02181f, 6.42654f, 0.19535f);
            f2841.AddVertex(-0.03468f, 6.39304f, 0.18761f);
            f2841.AddVertex(-0.00212f, 6.40434f, 0.19585f);
            faces.Add(f2841);

            Face f2842 = new Face(m03___Default);
            f2842.AddVertex(-0.00212f, 6.40434f, 0.19585f);
            f2842.AddVertex(-0.03468f, 6.39304f, 0.18761f);
            f2842.AddVertex(-0.01508f, 6.37304f, 0.18371f);
            faces.Add(f2842);

            Face f2843 = new Face(m03___Default);
            f2843.AddVertex(-0.00212f, 6.40434f, 0.19585f);
            f2843.AddVertex(-0.01508f, 6.37304f, 0.18371f);
            f2843.AddVertex(0.02172f, 6.38530f, 0.18839f);
            faces.Add(f2843);

            Face f2844 = new Face(m03___Default);
            f2844.AddVertex(0.02172f, 6.38530f, 0.18839f);
            f2844.AddVertex(-0.01508f, 6.37304f, 0.18371f);
            f2844.AddVertex(0.00904f, 6.35813f, 0.17394f);
            faces.Add(f2844);

            Face f2845 = new Face(m03___Default);
            f2845.AddVertex(0.02172f, 6.38530f, 0.18839f);
            f2845.AddVertex(0.00904f, 6.35813f, 0.17394f);
            f2845.AddVertex(0.04762f, 6.37110f, 0.17366f);
            faces.Add(f2845);

            Face f2846 = new Face(m03___Default);
            f2846.AddVertex(0.04762f, 6.37110f, 0.17366f);
            f2846.AddVertex(0.00904f, 6.35813f, 0.17394f);
            f2846.AddVertex(0.03590f, 6.34944f, 0.15904f);
            faces.Add(f2846);

            Face f2847 = new Face(m03___Default);
            f2847.AddVertex(0.07270f, 6.35193f, 0.06214f);
            f2847.AddVertex(0.09619f, 6.37439f, 0.04580f);
            f2847.AddVertex(0.10083f, 6.36095f, 0.07044f);
            faces.Add(f2847);

            Face f2848 = new Face(m03___Default);
            f2848.AddVertex(0.09619f, 6.37439f, 0.04580f);
            f2848.AddVertex(0.11575f, 6.40184f, 0.03407f);
            f2848.AddVertex(0.12410f, 6.38628f, 0.05526f);
            faces.Add(f2848);

            Face f2849 = new Face(m03___Default);
            f2849.AddVertex(0.09619f, 6.37439f, 0.04580f);
            f2849.AddVertex(0.12410f, 6.38628f, 0.05526f);
            f2849.AddVertex(0.10083f, 6.36095f, 0.07044f);
            faces.Add(f2849);

            Face f2850 = new Face(m03___Default);
            f2850.AddVertex(0.10083f, 6.36095f, 0.07044f);
            f2850.AddVertex(0.12410f, 6.38628f, 0.05526f);
            f2850.AddVertex(0.12468f, 6.37597f, 0.08147f);
            faces.Add(f2850);

            Face f2851 = new Face(m03___Default);
            f2851.AddVertex(0.11575f, 6.40184f, 0.03407f);
            f2851.AddVertex(0.12990f, 6.43218f, 0.02786f);
            f2851.AddVertex(0.14294f, 6.41774f, 0.04528f);
            faces.Add(f2851);

            Face f2852 = new Face(m03___Default);
            f2852.AddVertex(0.11575f, 6.40184f, 0.03407f);
            f2852.AddVertex(0.14294f, 6.41774f, 0.04528f);
            f2852.AddVertex(0.12410f, 6.38628f, 0.05526f);
            faces.Add(f2852);

            Face f2853 = new Face(m03___Default);
            f2853.AddVertex(0.12410f, 6.38628f, 0.05526f);
            f2853.AddVertex(0.14294f, 6.41774f, 0.04528f);
            f2853.AddVertex(0.14724f, 6.40526f, 0.06815f);
            faces.Add(f2853);

            Face f2854 = new Face(m03___Default);
            f2854.AddVertex(0.12410f, 6.38628f, 0.05526f);
            f2854.AddVertex(0.14724f, 6.40526f, 0.06815f);
            f2854.AddVertex(0.12468f, 6.37597f, 0.08147f);
            faces.Add(f2854);

            Face f2855 = new Face(m03___Default);
            f2855.AddVertex(0.12468f, 6.37597f, 0.08147f);
            f2855.AddVertex(0.14724f, 6.40526f, 0.06815f);
            f2855.AddVertex(0.14244f, 6.39586f, 0.09442f);
            faces.Add(f2855);

            Face f2856 = new Face(m03___Default);
            f2856.AddVertex(0.12990f, 6.43218f, 0.02786f);
            f2856.AddVertex(0.13756f, 6.46310f, 0.02763f);
            f2856.AddVertex(0.15436f, 6.45270f, 0.04195f);
            faces.Add(f2856);

            Face f2857 = new Face(m03___Default);
            f2857.AddVertex(0.12990f, 6.43218f, 0.02786f);
            f2857.AddVertex(0.15436f, 6.45270f, 0.04195f);
            f2857.AddVertex(0.14294f, 6.41774f, 0.04528f);
            faces.Add(f2857);

            Face f2858 = new Face(m03___Default);
            f2858.AddVertex(0.14294f, 6.41774f, 0.04528f);
            f2858.AddVertex(0.15436f, 6.45270f, 0.04195f);
            f2858.AddVertex(0.16280f, 6.44131f, 0.06119f);
            faces.Add(f2858);

            Face f2859 = new Face(m03___Default);
            f2859.AddVertex(0.14294f, 6.41774f, 0.04528f);
            f2859.AddVertex(0.16280f, 6.44131f, 0.06119f);
            f2859.AddVertex(0.14724f, 6.40526f, 0.06815f);
            faces.Add(f2859);

            Face f2860 = new Face(m03___Default);
            f2860.AddVertex(0.14724f, 6.40526f, 0.06815f);
            f2860.AddVertex(0.16280f, 6.44131f, 0.06119f);
            f2860.AddVertex(0.16225f, 6.42983f, 0.08387f);
            faces.Add(f2860);

            Face f2861 = new Face(m03___Default);
            f2861.AddVertex(0.14724f, 6.40526f, 0.06815f);
            f2861.AddVertex(0.16225f, 6.42983f, 0.08387f);
            f2861.AddVertex(0.14244f, 6.39586f, 0.09442f);
            faces.Add(f2861);

            Face f2862 = new Face(m03___Default);
            f2862.AddVertex(0.14244f, 6.39586f, 0.09442f);
            f2862.AddVertex(0.16225f, 6.42983f, 0.08387f);
            f2862.AddVertex(0.15276f, 6.41910f, 0.10827f);
            faces.Add(f2862);

            Face f2863 = new Face(m03___Default);
            f2863.AddVertex(0.01132f, 6.42064f, 0.02855f);
            f2863.AddVertex(0.01983f, 6.45162f, 0.02610f);
            f2863.AddVertex(0.04553f, 6.43110f, 0.01807f);
            faces.Add(f2863);

            Face f2864 = new Face(m03___Default);
            f2864.AddVertex(0.01983f, 6.45162f, 0.02610f);
            f2864.AddVertex(0.03022f, 6.48170f, 0.02977f);
            f2864.AddVertex(0.05547f, 6.46310f, 0.01771f);
            faces.Add(f2864);

            Face f2865 = new Face(m03___Default);
            f2865.AddVertex(0.01983f, 6.45162f, 0.02610f);
            f2865.AddVertex(0.05547f, 6.46310f, 0.01771f);
            f2865.AddVertex(0.04553f, 6.43110f, 0.01807f);
            faces.Add(f2865);

            Face f2866 = new Face(m03___Default);
            f2866.AddVertex(0.04553f, 6.43110f, 0.01807f);
            f2866.AddVertex(0.05547f, 6.46310f, 0.01771f);
            f2866.AddVertex(0.07967f, 6.44222f, 0.01432f);
            faces.Add(f2866);

            Face f2867 = new Face(m03___Default);
            f2867.AddVertex(0.03022f, 6.48170f, 0.02977f);
            f2867.AddVertex(0.04171f, 6.50860f, 0.03928f);
            f2867.AddVertex(0.06760f, 6.49441f, 0.02455f);
            faces.Add(f2867);

            Face f2868 = new Face(m03___Default);
            f2868.AddVertex(0.03022f, 6.48170f, 0.02977f);
            f2868.AddVertex(0.06760f, 6.49441f, 0.02455f);
            f2868.AddVertex(0.05547f, 6.46310f, 0.01771f);
            faces.Add(f2868);

            Face f2869 = new Face(m03___Default);
            f2869.AddVertex(0.05547f, 6.46310f, 0.01771f);
            f2869.AddVertex(0.06760f, 6.49441f, 0.02455f);
            f2869.AddVertex(0.09146f, 6.47536f, 0.01710f);
            faces.Add(f2869);

            Face f2870 = new Face(m03___Default);
            f2870.AddVertex(0.05547f, 6.46310f, 0.01771f);
            f2870.AddVertex(0.09146f, 6.47536f, 0.01710f);
            f2870.AddVertex(0.07967f, 6.44222f, 0.01432f);
            faces.Add(f2870);

            Face f2871 = new Face(m03___Default);
            f2871.AddVertex(0.07967f, 6.44222f, 0.01432f);
            f2871.AddVertex(0.09146f, 6.47536f, 0.01710f);
            f2871.AddVertex(0.11115f, 6.45317f, 0.01759f);
            faces.Add(f2871);

            Face f2872 = new Face(m03___Default);
            f2872.AddVertex(0.04171f, 6.50860f, 0.03928f);
            f2872.AddVertex(0.05344f, 6.53027f, 0.05391f);
            f2872.AddVertex(0.08029f, 6.52157f, 0.03901f);
            faces.Add(f2872);

            Face f2873 = new Face(m03___Default);
            f2873.AddVertex(0.04171f, 6.50860f, 0.03928f);
            f2873.AddVertex(0.08029f, 6.52157f, 0.03901f);
            f2873.AddVertex(0.06760f, 6.49441f, 0.02455f);
            faces.Add(f2873);

            Face f2874 = new Face(m03___Default);
            f2874.AddVertex(0.06760f, 6.49441f, 0.02455f);
            f2874.AddVertex(0.08029f, 6.52157f, 0.03901f);
            f2874.AddVertex(0.10443f, 6.50666f, 0.02923f);
            faces.Add(f2874);

            Face f2875 = new Face(m03___Default);
            f2875.AddVertex(0.06760f, 6.49441f, 0.02455f);
            f2875.AddVertex(0.10443f, 6.50666f, 0.02923f);
            f2875.AddVertex(0.09146f, 6.47536f, 0.01710f);
            faces.Add(f2875);

            Face f2876 = new Face(m03___Default);
            f2876.AddVertex(0.09146f, 6.47536f, 0.01710f);
            f2876.AddVertex(0.10443f, 6.50666f, 0.02923f);
            f2876.AddVertex(0.12401f, 6.48666f, 0.02535f);
            faces.Add(f2876);

            Face f2877 = new Face(m03___Default);
            f2877.AddVertex(0.09146f, 6.47536f, 0.01710f);
            f2877.AddVertex(0.12401f, 6.48666f, 0.02535f);
            f2877.AddVertex(0.11115f, 6.45317f, 0.01759f);
            faces.Add(f2877);

            Face f2878 = new Face(m03___Default);
            f2878.AddVertex(0.11115f, 6.45317f, 0.01759f);
            f2878.AddVertex(0.12401f, 6.48666f, 0.02535f);
            f2878.AddVertex(0.13756f, 6.46310f, 0.02763f);
            faces.Add(f2878);

            Face f2879 = new Face(m03___Default);
            f2879.AddVertex(-0.06341f, 6.46061f, 0.10467f);
            f2879.AddVertex(-0.05310f, 6.48384f, 0.11853f);
            f2879.AddVertex(-0.04185f, 6.48461f, 0.08893f);
            faces.Add(f2879);

            Face f2880 = new Face(m03___Default);
            f2880.AddVertex(-0.05310f, 6.48384f, 0.11853f);
            f2880.AddVertex(-0.03534f, 6.50373f, 0.13147f);
            f2880.AddVertex(-0.02809f, 6.50779f, 0.10282f);
            faces.Add(f2880);

            Face f2881 = new Face(m03___Default);
            f2881.AddVertex(-0.05310f, 6.48384f, 0.11853f);
            f2881.AddVertex(-0.02809f, 6.50779f, 0.10282f);
            f2881.AddVertex(-0.04185f, 6.48461f, 0.08893f);
            faces.Add(f2881);

            Face f2882 = new Face(m03___Default);
            f2882.AddVertex(-0.04185f, 6.48461f, 0.08893f);
            f2882.AddVertex(-0.02809f, 6.50779f, 0.10282f);
            f2882.AddVertex(-0.01371f, 6.50520f, 0.07452f);
            faces.Add(f2882);

            Face f2883 = new Face(m03___Default);
            f2883.AddVertex(-0.03534f, 6.50373f, 0.13147f);
            f2883.AddVertex(-0.01149f, 6.51876f, 0.14251f);
            f2883.AddVertex(-0.00552f, 6.52722f, 0.11588f);
            faces.Add(f2883);

            Face f2884 = new Face(m03___Default);
            f2884.AddVertex(-0.03534f, 6.50373f, 0.13147f);
            f2884.AddVertex(-0.00552f, 6.52722f, 0.11588f);
            f2884.AddVertex(-0.02809f, 6.50779f, 0.10282f);
            faces.Add(f2884);

            Face f2885 = new Face(m03___Default);
            f2885.AddVertex(-0.02809f, 6.50779f, 0.10282f);
            f2885.AddVertex(-0.00552f, 6.52722f, 0.11588f);
            f2885.AddVertex(0.00491f, 6.52794f, 0.08841f);
            faces.Add(f2885);

            Face f2886 = new Face(m03___Default);
            f2886.AddVertex(-0.02809f, 6.50779f, 0.10282f);
            f2886.AddVertex(0.00491f, 6.52794f, 0.08841f);
            f2886.AddVertex(-0.01371f, 6.50520f, 0.07452f);
            faces.Add(f2886);

            Face f2887 = new Face(m03___Default);
            f2887.AddVertex(-0.01371f, 6.50520f, 0.07452f);
            f2887.AddVertex(0.00491f, 6.52794f, 0.08841f);
            f2887.AddVertex(0.01888f, 6.52081f, 0.06255f);
            faces.Add(f2887);

            Face f2888 = new Face(m03___Default);
            f2888.AddVertex(-0.01149f, 6.51876f, 0.14251f);
            f2888.AddVertex(0.01663f, 6.52777f, 0.15080f);
            f2888.AddVertex(0.02420f, 6.54003f, 0.12700f);
            faces.Add(f2888);

            Face f2889 = new Face(m03___Default);
            f2889.AddVertex(-0.01149f, 6.51876f, 0.14251f);
            f2889.AddVertex(0.02420f, 6.54003f, 0.12700f);
            f2889.AddVertex(-0.00552f, 6.52722f, 0.11588f);
            faces.Add(f2889);

            Face f2890 = new Face(m03___Default);
            f2890.AddVertex(-0.00552f, 6.52722f, 0.11588f);
            f2890.AddVertex(0.02420f, 6.54003f, 0.12700f);
            f2890.AddVertex(0.03334f, 6.54468f, 0.10164f);
            faces.Add(f2890);

            Face f2891 = new Face(m03___Default);
            f2891.AddVertex(-0.00552f, 6.52722f, 0.11588f);
            f2891.AddVertex(0.03334f, 6.54468f, 0.10164f);
            f2891.AddVertex(0.00491f, 6.52794f, 0.08841f);
            faces.Add(f2891);

            Face f2892 = new Face(m03___Default);
            f2892.AddVertex(0.00491f, 6.52794f, 0.08841f);
            f2892.AddVertex(0.03334f, 6.54468f, 0.10164f);
            f2892.AddVertex(0.04333f, 6.54133f, 0.07664f);
            faces.Add(f2892);

            Face f2893 = new Face(m03___Default);
            f2893.AddVertex(0.00491f, 6.52794f, 0.08841f);
            f2893.AddVertex(0.04333f, 6.54133f, 0.07664f);
            f2893.AddVertex(0.01888f, 6.52081f, 0.06255f);
            faces.Add(f2893);

            Face f2894 = new Face(m03___Default);
            f2894.AddVertex(0.01888f, 6.52081f, 0.06255f);
            f2894.AddVertex(0.04333f, 6.54133f, 0.07664f);
            f2894.AddVertex(0.05344f, 6.53027f, 0.05391f);
            faces.Add(f2894);

            Face f2895 = new Face(m03___Default);
            f2895.AddVertex(-0.04823f, 6.41660f, 0.18532f);
            f2895.AddVertex(-0.02181f, 6.42654f, 0.19535f);
            f2895.AddVertex(-0.04056f, 6.44752f, 0.18509f);
            faces.Add(f2895);

            Face f2896 = new Face(m03___Default);
            f2896.AddVertex(-0.02181f, 6.42654f, 0.19535f);
            f2896.AddVertex(0.00966f, 6.43748f, 0.19862f);
            f2896.AddVertex(-0.01110f, 6.45859f, 0.19299f);
            faces.Add(f2896);

            Face f2897 = new Face(m03___Default);
            f2897.AddVertex(-0.02181f, 6.42654f, 0.19535f);
            f2897.AddVertex(-0.01110f, 6.45859f, 0.19299f);
            f2897.AddVertex(-0.04056f, 6.44752f, 0.18509f);
            faces.Add(f2897);

            Face f2898 = new Face(m03___Default);
            f2898.AddVertex(-0.04056f, 6.44752f, 0.18509f);
            f2898.AddVertex(-0.01110f, 6.45859f, 0.19299f);
            f2898.AddVertex(-0.02642f, 6.47787f, 0.17888f);
            faces.Add(f2898);

            Face f2899 = new Face(m03___Default);
            f2899.AddVertex(0.00966f, 6.43748f, 0.19862f);
            f2899.AddVertex(0.04380f, 6.44861f, 0.19488f);
            f2899.AddVertex(0.02462f, 6.47084f, 0.19305f);
            faces.Add(f2899);

            Face f2900 = new Face(m03___Default);
            f2900.AddVertex(0.00966f, 6.43748f, 0.19862f);
            f2900.AddVertex(0.02462f, 6.47084f, 0.19305f);
            f2900.AddVertex(-0.01110f, 6.45859f, 0.19299f);
            faces.Add(f2900);

            Face f2901 = new Face(m03___Default);
            f2901.AddVertex(-0.01110f, 6.45859f, 0.19299f);
            f2901.AddVertex(0.02462f, 6.47084f, 0.19305f);
            f2901.AddVertex(0.00722f, 6.49032f, 0.18352f);
            faces.Add(f2901);

            Face f2902 = new Face(m03___Default);
            f2902.AddVertex(-0.01110f, 6.45859f, 0.19299f);
            f2902.AddVertex(0.00722f, 6.49032f, 0.18352f);
            f2902.AddVertex(-0.02642f, 6.47787f, 0.17888f);
            faces.Add(f2902);

            Face f2903 = new Face(m03___Default);
            f2903.AddVertex(-0.02642f, 6.47787f, 0.17888f);
            f2903.AddVertex(0.00722f, 6.49032f, 0.18352f);
            f2903.AddVertex(-0.00685f, 6.50531f, 0.16715f);
            faces.Add(f2903);

            Face f2904 = new Face(m03___Default);
            f2904.AddVertex(0.04380f, 6.44861f, 0.19488f);
            f2904.AddVertex(0.07801f, 6.45906f, 0.18440f);
            f2904.AddVertex(0.06362f, 6.48257f, 0.18433f);
            faces.Add(f2904);

            Face f2905 = new Face(m03___Default);
            f2905.AddVertex(0.04380f, 6.44861f, 0.19488f);
            f2905.AddVertex(0.06362f, 6.48257f, 0.18433f);
            f2905.AddVertex(0.02462f, 6.47084f, 0.19305f);
            faces.Add(f2905);

            Face f2906 = new Face(m03___Default);
            f2906.AddVertex(0.02462f, 6.47084f, 0.19305f);
            f2906.AddVertex(0.06362f, 6.48257f, 0.18433f);
            f2906.AddVertex(0.04778f, 6.50283f, 0.17834f);
            faces.Add(f2906);

            Face f2907 = new Face(m03___Default);
            f2907.AddVertex(0.02462f, 6.47084f, 0.19305f);
            f2907.AddVertex(0.04778f, 6.50283f, 0.17834f);
            f2907.AddVertex(0.00722f, 6.49032f, 0.18352f);
            faces.Add(f2907);

            Face f2908 = new Face(m03___Default);
            f2908.AddVertex(0.00722f, 6.49032f, 0.18352f);
            f2908.AddVertex(0.04778f, 6.50283f, 0.17834f);
            f2908.AddVertex(0.03171f, 6.51829f, 0.16687f);
            faces.Add(f2908);

            Face f2909 = new Face(m03___Default);
            f2909.AddVertex(0.00722f, 6.49032f, 0.18352f);
            f2909.AddVertex(0.03171f, 6.51829f, 0.16687f);
            f2909.AddVertex(-0.00685f, 6.50531f, 0.16715f);
            faces.Add(f2909);

            Face f2910 = new Face(m03___Default);
            f2910.AddVertex(-0.00685f, 6.50531f, 0.16715f);
            f2910.AddVertex(0.03171f, 6.51829f, 0.16687f);
            f2910.AddVertex(0.01663f, 6.52777f, 0.15080f);
            faces.Add(f2910);

            Face f2911 = new Face(m03___Default);
            f2911.AddVertex(0.03590f, 6.34944f, 0.15904f);
            f2911.AddVertex(0.07045f, 6.35889f, 0.15040f);
            f2911.AddVertex(0.04762f, 6.37110f, 0.17366f);
            faces.Add(f2911);

            Face f2912 = new Face(m03___Default);
            f2912.AddVertex(0.07045f, 6.35889f, 0.15040f);
            f2912.AddVertex(0.10305f, 6.37451f, 0.13843f);
            f2912.AddVertex(0.08295f, 6.38350f, 0.16360f);
            faces.Add(f2912);

            Face f2913 = new Face(m03___Default);
            f2913.AddVertex(0.07045f, 6.35889f, 0.15040f);
            f2913.AddVertex(0.08295f, 6.38350f, 0.16360f);
            f2913.AddVertex(0.04762f, 6.37110f, 0.17366f);
            faces.Add(f2913);

            Face f2914 = new Face(m03___Default);
            f2914.AddVertex(0.04762f, 6.37110f, 0.17366f);
            f2914.AddVertex(0.08295f, 6.38350f, 0.16360f);
            f2914.AddVertex(0.05911f, 6.39800f, 0.18317f);
            faces.Add(f2914);

            Face f2915 = new Face(m03___Default);
            f2915.AddVertex(0.10305f, 6.37451f, 0.13843f);
            f2915.AddVertex(0.13119f, 6.39510f, 0.12402f);
            f2915.AddVertex(0.11637f, 6.40317f, 0.14942f);
            faces.Add(f2915);

            Face f2916 = new Face(m03___Default);
            f2916.AddVertex(0.10305f, 6.37451f, 0.13843f);
            f2916.AddVertex(0.11637f, 6.40317f, 0.14942f);
            f2916.AddVertex(0.08295f, 6.38350f, 0.16360f);
            faces.Add(f2916);

            Face f2917 = new Face(m03___Default);
            f2917.AddVertex(0.08295f, 6.38350f, 0.16360f);
            f2917.AddVertex(0.11637f, 6.40317f, 0.14942f);
            f2917.AddVertex(0.09519f, 6.41450f, 0.17100f);
            faces.Add(f2917);

            Face f2918 = new Face(m03___Default);
            f2918.AddVertex(0.08295f, 6.38350f, 0.16360f);
            f2918.AddVertex(0.09519f, 6.41450f, 0.17100f);
            f2918.AddVertex(0.05911f, 6.39800f, 0.18317f);
            faces.Add(f2918);

            Face f2919 = new Face(m03___Default);
            f2919.AddVertex(0.05911f, 6.39800f, 0.18317f);
            f2919.AddVertex(0.09519f, 6.41450f, 0.17100f);
            f2919.AddVertex(0.06951f, 6.42809f, 0.18685f);
            faces.Add(f2919);

            Face f2920 = new Face(m03___Default);
            f2920.AddVertex(0.13119f, 6.39510f, 0.12402f);
            f2920.AddVertex(0.15276f, 6.41910f, 0.10827f);
            f2920.AddVertex(0.14406f, 6.42859f, 0.13177f);
            faces.Add(f2920);

            Face f2921 = new Face(m03___Default);
            f2921.AddVertex(0.13119f, 6.39510f, 0.12402f);
            f2921.AddVertex(0.14406f, 6.42859f, 0.13177f);
            f2921.AddVertex(0.11637f, 6.40317f, 0.14942f);
            faces.Add(f2921);

            Face f2922 = new Face(m03___Default);
            f2922.AddVertex(0.11637f, 6.40317f, 0.14942f);
            f2922.AddVertex(0.14406f, 6.42859f, 0.13177f);
            f2922.AddVertex(0.12780f, 6.43895f, 0.15334f);
            faces.Add(f2922);

            Face f2923 = new Face(m03___Default);
            f2923.AddVertex(0.11637f, 6.40317f, 0.14942f);
            f2923.AddVertex(0.12780f, 6.43895f, 0.15334f);
            f2923.AddVertex(0.09519f, 6.41450f, 0.17100f);
            faces.Add(f2923);

            Face f2924 = new Face(m03___Default);
            f2924.AddVertex(0.09519f, 6.41450f, 0.17100f);
            f2924.AddVertex(0.12780f, 6.43895f, 0.15334f);
            f2924.AddVertex(0.10521f, 6.44937f, 0.17134f);
            faces.Add(f2924);

            Face f2925 = new Face(m03___Default);
            f2925.AddVertex(0.09519f, 6.41450f, 0.17100f);
            f2925.AddVertex(0.10521f, 6.44937f, 0.17134f);
            f2925.AddVertex(0.06951f, 6.42809f, 0.18685f);
            faces.Add(f2925);

            Face f2926 = new Face(m03___Default);
            f2926.AddVertex(0.06951f, 6.42809f, 0.18685f);
            f2926.AddVertex(0.10521f, 6.44937f, 0.17134f);
            f2926.AddVertex(0.07801f, 6.45906f, 0.18440f);
            faces.Add(f2926);

            Face f2927 = new Face(m03___Default);
            f2927.AddVertex(-0.05151f, 6.35039f, 0.10976f);
            f2927.AddVertex(-0.04490f, 6.36015f, 0.08537f);
            f2927.AddVertex(-0.02614f, 6.33916f, 0.09564f);
            faces.Add(f2927);

            Face f2928 = new Face(m03___Default);
            f2928.AddVertex(-0.04490f, 6.36015f, 0.08537f);
            f2928.AddVertex(-0.03146f, 6.37597f, 0.06260f);
            f2928.AddVertex(-0.01641f, 6.35146f, 0.07072f);
            faces.Add(f2928);

            Face f2929 = new Face(m03___Default);
            f2929.AddVertex(-0.04490f, 6.36015f, 0.08537f);
            f2929.AddVertex(-0.01641f, 6.35146f, 0.07072f);
            f2929.AddVertex(-0.02614f, 6.33916f, 0.09564f);
            faces.Add(f2929);

            Face f2930 = new Face(m03___Default);
            f2930.AddVertex(-0.02614f, 6.33916f, 0.09564f);
            f2930.AddVertex(-0.01641f, 6.35146f, 0.07072f);
            f2930.AddVertex(0.00461f, 6.33559f, 0.08235f);
            faces.Add(f2930);

            Face f2931 = new Face(m03___Default);
            f2931.AddVertex(-0.03146f, 6.37597f, 0.06260f);
            f2931.AddVertex(-0.01223f, 6.39666f, 0.04316f);
            f2931.AddVertex(0.00131f, 6.37107f, 0.04744f);
            faces.Add(f2931);

            Face f2932 = new Face(m03___Default);
            f2932.AddVertex(-0.03146f, 6.37597f, 0.06260f);
            f2932.AddVertex(0.00131f, 6.37107f, 0.04744f);
            f2932.AddVertex(-0.01641f, 6.35146f, 0.07072f);
            faces.Add(f2932);

            Face f2933 = new Face(m03___Default);
            f2933.AddVertex(-0.01641f, 6.35146f, 0.07072f);
            f2933.AddVertex(0.00131f, 6.37107f, 0.04744f);
            f2933.AddVertex(0.01871f, 6.35159f, 0.05697f);
            faces.Add(f2933);

            Face f2934 = new Face(m03___Default);
            f2934.AddVertex(-0.01641f, 6.35146f, 0.07072f);
            f2934.AddVertex(0.01871f, 6.35159f, 0.05697f);
            f2934.AddVertex(0.00461f, 6.33559f, 0.08235f);
            faces.Add(f2934);

            Face f2935 = new Face(m03___Default);
            f2935.AddVertex(0.00461f, 6.33559f, 0.08235f);
            f2935.AddVertex(0.01871f, 6.35159f, 0.05697f);
            f2935.AddVertex(0.03842f, 6.33996f, 0.07089f);
            faces.Add(f2935);

            Face f2936 = new Face(m03___Default);
            f2936.AddVertex(-0.01223f, 6.39666f, 0.04316f);
            f2936.AddVertex(0.01132f, 6.42064f, 0.02855f);
            f2936.AddVertex(0.02571f, 6.39714f, 0.02861f);
            faces.Add(f2936);

            Face f2937 = new Face(m03___Default);
            f2937.AddVertex(-0.01223f, 6.39666f, 0.04316f);
            f2937.AddVertex(0.02571f, 6.39714f, 0.02861f);
            f2937.AddVertex(0.00131f, 6.37107f, 0.04744f);
            faces.Add(f2937);

            Face f2938 = new Face(m03___Default);
            f2938.AddVertex(0.00131f, 6.37107f, 0.04744f);
            f2938.AddVertex(0.02571f, 6.39714f, 0.02861f);
            f2938.AddVertex(0.04154f, 6.37688f, 0.03461f);
            faces.Add(f2938);

            Face f2939 = new Face(m03___Default);
            f2939.AddVertex(0.00131f, 6.37107f, 0.04744f);
            f2939.AddVertex(0.04154f, 6.37688f, 0.03461f);
            f2939.AddVertex(0.01871f, 6.35159f, 0.05697f);
            faces.Add(f2939);

            Face f2940 = new Face(m03___Default);
            f2940.AddVertex(0.01871f, 6.35159f, 0.05697f);
            f2940.AddVertex(0.04154f, 6.37688f, 0.03461f);
            f2940.AddVertex(0.05762f, 6.36142f, 0.04607f);
            faces.Add(f2940);

            Face f2941 = new Face(m03___Default);
            f2941.AddVertex(0.01871f, 6.35159f, 0.05697f);
            f2941.AddVertex(0.05762f, 6.36142f, 0.04607f);
            f2941.AddVertex(0.03842f, 6.33996f, 0.07089f);
            faces.Add(f2941);

            Face f2942 = new Face(m03___Default);
            f2942.AddVertex(0.03842f, 6.33996f, 0.07089f);
            f2942.AddVertex(0.05762f, 6.36142f, 0.04607f);
            f2942.AddVertex(0.07270f, 6.35193f, 0.06214f);
            faces.Add(f2942);

            Face f2943 = new Face(m03___Default);
            f2943.AddVertex(-0.05151f, 6.35039f, 0.10976f);
            f2943.AddVertex(-0.06773f, 6.37236f, 0.10863f);
            f2943.AddVertex(-0.04490f, 6.36015f, 0.08537f);
            faces.Add(f2943);

            Face f2944 = new Face(m03___Default);
            f2944.AddVertex(-0.06773f, 6.37236f, 0.10863f);
            f2944.AddVertex(-0.07539f, 6.39946f, 0.10734f);
            f2944.AddVertex(-0.05848f, 6.38504f, 0.08387f);
            faces.Add(f2944);

            Face f2945 = new Face(m03___Default);
            f2945.AddVertex(-0.06773f, 6.37236f, 0.10863f);
            f2945.AddVertex(-0.05848f, 6.38504f, 0.08387f);
            f2945.AddVertex(-0.04490f, 6.36015f, 0.08537f);
            faces.Add(f2945);

            Face f2946 = new Face(m03___Default);
            f2946.AddVertex(-0.04490f, 6.36015f, 0.08537f);
            f2946.AddVertex(-0.05848f, 6.38504f, 0.08387f);
            f2946.AddVertex(-0.03146f, 6.37597f, 0.06260f);
            faces.Add(f2946);

            Face f2947 = new Face(m03___Default);
            f2947.AddVertex(-0.07539f, 6.39946f, 0.10734f);
            f2947.AddVertex(-0.07392f, 6.42965f, 0.10599f);
            f2947.AddVertex(-0.06223f, 6.41622f, 0.08225f);
            faces.Add(f2947);

            Face f2948 = new Face(m03___Default);
            f2948.AddVertex(-0.07539f, 6.39946f, 0.10734f);
            f2948.AddVertex(-0.06223f, 6.41622f, 0.08225f);
            f2948.AddVertex(-0.05848f, 6.38504f, 0.08387f);
            faces.Add(f2948);

            Face f2949 = new Face(m03___Default);
            f2949.AddVertex(-0.05848f, 6.38504f, 0.08387f);
            f2949.AddVertex(-0.06223f, 6.41622f, 0.08225f);
            f2949.AddVertex(-0.04104f, 6.40489f, 0.06068f);
            faces.Add(f2949);

            Face f2950 = new Face(m03___Default);
            f2950.AddVertex(-0.05848f, 6.38504f, 0.08387f);
            f2950.AddVertex(-0.04104f, 6.40489f, 0.06068f);
            f2950.AddVertex(-0.03146f, 6.37597f, 0.06260f);
            faces.Add(f2950);

            Face f2951 = new Face(m03___Default);
            f2951.AddVertex(-0.03146f, 6.37597f, 0.06260f);
            f2951.AddVertex(-0.04104f, 6.40489f, 0.06068f);
            f2951.AddVertex(-0.01223f, 6.39666f, 0.04316f);
            faces.Add(f2951);

            Face f2952 = new Face(m03___Default);
            f2952.AddVertex(-0.07392f, 6.42965f, 0.10599f);
            f2952.AddVertex(-0.06341f, 6.46061f, 0.10467f);
            f2952.AddVertex(-0.05472f, 6.45111f, 0.08118f);
            faces.Add(f2952);

            Face f2953 = new Face(m03___Default);
            f2953.AddVertex(-0.07392f, 6.42965f, 0.10599f);
            f2953.AddVertex(-0.05472f, 6.45111f, 0.08118f);
            f2953.AddVertex(-0.06223f, 6.41622f, 0.08225f);
            faces.Add(f2953);

            Face f2954 = new Face(m03___Default);
            f2954.AddVertex(-0.06223f, 6.41622f, 0.08225f);
            f2954.AddVertex(-0.05472f, 6.45111f, 0.08118f);
            f2954.AddVertex(-0.03846f, 6.44076f, 0.05961f);
            faces.Add(f2954);

            Face f2955 = new Face(m03___Default);
            f2955.AddVertex(-0.06223f, 6.41622f, 0.08225f);
            f2955.AddVertex(-0.03846f, 6.44076f, 0.05961f);
            f2955.AddVertex(-0.04104f, 6.40489f, 0.06068f);
            faces.Add(f2955);

            Face f2956 = new Face(m03___Default);
            f2956.AddVertex(-0.04104f, 6.40489f, 0.06068f);
            f2956.AddVertex(-0.03846f, 6.44076f, 0.05961f);
            f2956.AddVertex(-0.01587f, 6.43034f, 0.04161f);
            faces.Add(f2956);

            Face f2957 = new Face(m03___Default);
            f2957.AddVertex(-0.04104f, 6.40489f, 0.06068f);
            f2957.AddVertex(-0.01587f, 6.43034f, 0.04161f);
            f2957.AddVertex(-0.01223f, 6.39666f, 0.04316f);
            faces.Add(f2957);

            Face f2958 = new Face(m03___Default);
            f2958.AddVertex(-0.01223f, 6.39666f, 0.04316f);
            f2958.AddVertex(-0.01587f, 6.43034f, 0.04161f);
            f2958.AddVertex(0.01132f, 6.42064f, 0.02855f);
            faces.Add(f2958);

            Face f2959 = new Face(m03___Default);
            f2959.AddVertex(-0.05151f, 6.35039f, 0.10976f);
            f2959.AddVertex(-0.06309f, 6.35891f, 0.13327f);
            f2959.AddVertex(-0.06773f, 6.37236f, 0.10863f);
            faces.Add(f2959);

            Face f2960 = new Face(m03___Default);
            f2960.AddVertex(-0.06309f, 6.35891f, 0.13327f);
            f2960.AddVertex(-0.06647f, 6.37360f, 0.15475f);
            f2960.AddVertex(-0.07688f, 6.38379f, 0.13231f);
            faces.Add(f2960);

            Face f2961 = new Face(m03___Default);
            f2961.AddVertex(-0.06309f, 6.35891f, 0.13327f);
            f2961.AddVertex(-0.07688f, 6.38379f, 0.13231f);
            f2961.AddVertex(-0.06773f, 6.37236f, 0.10863f);
            faces.Add(f2961);

            Face f2962 = new Face(m03___Default);
            f2962.AddVertex(-0.06773f, 6.37236f, 0.10863f);
            f2962.AddVertex(-0.07688f, 6.38379f, 0.13231f);
            f2962.AddVertex(-0.07539f, 6.39946f, 0.10734f);
            faces.Add(f2962);

            Face f2963 = new Face(m03___Default);
            f2963.AddVertex(-0.06647f, 6.37360f, 0.15475f);
            f2963.AddVertex(-0.06139f, 6.39333f, 0.17255f);
            f2963.AddVertex(-0.07645f, 6.40249f, 0.15390f);
            faces.Add(f2963);

            Face f2964 = new Face(m03___Default);
            f2964.AddVertex(-0.06647f, 6.37360f, 0.15475f);
            f2964.AddVertex(-0.07645f, 6.40249f, 0.15390f);
            f2964.AddVertex(-0.07688f, 6.38379f, 0.13231f);
            faces.Add(f2964);

            Face f2965 = new Face(m03___Default);
            f2965.AddVertex(-0.07688f, 6.38379f, 0.13231f);
            f2965.AddVertex(-0.07645f, 6.40249f, 0.15390f);
            f2965.AddVertex(-0.08076f, 6.41496f, 0.13104f);
            faces.Add(f2965);

            Face f2966 = new Face(m03___Default);
            f2966.AddVertex(-0.07688f, 6.38379f, 0.13231f);
            f2966.AddVertex(-0.08076f, 6.41496f, 0.13104f);
            f2966.AddVertex(-0.07539f, 6.39946f, 0.10734f);
            faces.Add(f2966);

            Face f2967 = new Face(m03___Default);
            f2967.AddVertex(-0.07539f, 6.39946f, 0.10734f);
            f2967.AddVertex(-0.08076f, 6.41496f, 0.13104f);
            f2967.AddVertex(-0.07392f, 6.42965f, 0.10599f);
            faces.Add(f2967);

            Face f2968 = new Face(m03___Default);
            f2968.AddVertex(-0.06139f, 6.39333f, 0.17255f);
            f2968.AddVertex(-0.04823f, 6.41660f, 0.18532f);
            f2968.AddVertex(-0.06502f, 6.42701f, 0.17100f);
            faces.Add(f2968);

            Face f2969 = new Face(m03___Default);
            f2969.AddVertex(-0.06139f, 6.39333f, 0.17255f);
            f2969.AddVertex(-0.06502f, 6.42701f, 0.17100f);
            f2969.AddVertex(-0.07645f, 6.40249f, 0.15390f);
            faces.Add(f2969);

            Face f2970 = new Face(m03___Default);
            f2970.AddVertex(-0.07645f, 6.40249f, 0.15390f);
            f2970.AddVertex(-0.06502f, 6.42701f, 0.17100f);
            f2970.AddVertex(-0.07347f, 6.43839f, 0.15176f);
            faces.Add(f2970);

            Face f2971 = new Face(m03___Default);
            f2971.AddVertex(-0.07645f, 6.40249f, 0.15390f);
            f2971.AddVertex(-0.07347f, 6.43839f, 0.15176f);
            f2971.AddVertex(-0.08076f, 6.41496f, 0.13104f);
            faces.Add(f2971);

            Face f2972 = new Face(m03___Default);
            f2972.AddVertex(-0.08076f, 6.41496f, 0.13104f);
            f2972.AddVertex(-0.07347f, 6.43839f, 0.15176f);
            f2972.AddVertex(-0.07292f, 6.44988f, 0.12908f);
            faces.Add(f2972);

            Face f2973 = new Face(m03___Default);
            f2973.AddVertex(-0.08076f, 6.41496f, 0.13104f);
            f2973.AddVertex(-0.07292f, 6.44988f, 0.12908f);
            f2973.AddVertex(-0.07392f, 6.42965f, 0.10599f);
            faces.Add(f2973);

            Face f2974 = new Face(m03___Default);
            f2974.AddVertex(-0.07392f, 6.42965f, 0.10599f);
            f2974.AddVertex(-0.07292f, 6.44988f, 0.12908f);
            f2974.AddVertex(-0.06341f, 6.46061f, 0.10467f);
            faces.Add(f2974);

            Face f2975 = new Face(m03___Default);
            f2975.AddVertex(-0.05151f, 6.35039f, 0.10976f);
            f2975.AddVertex(-0.03738f, 6.33839f, 0.12524f);
            f2975.AddVertex(-0.06309f, 6.35891f, 0.13327f);
            faces.Add(f2975);

            Face f2976 = new Face(m03___Default);
            f2976.AddVertex(-0.03738f, 6.33839f, 0.12524f);
            f2976.AddVertex(-0.01702f, 6.33412f, 0.13930f);
            f2976.AddVertex(-0.04619f, 6.34944f, 0.14911f);
            faces.Add(f2976);

            Face f2977 = new Face(m03___Default);
            f2977.AddVertex(-0.03738f, 6.33839f, 0.12524f);
            f2977.AddVertex(-0.04619f, 6.34944f, 0.14911f);
            f2977.AddVertex(-0.06309f, 6.35891f, 0.13327f);
            faces.Add(f2977);

            Face f2978 = new Face(m03___Default);
            f2978.AddVertex(-0.06309f, 6.35891f, 0.13327f);
            f2978.AddVertex(-0.04619f, 6.34944f, 0.14911f);
            f2978.AddVertex(-0.06647f, 6.37360f, 0.15475f);
            faces.Add(f2978);

            Face f2979 = new Face(m03___Default);
            f2979.AddVertex(-0.01702f, 6.33412f, 0.13930f);
            f2979.AddVertex(0.00804f, 6.33790f, 0.15085f);
            f2979.AddVertex(-0.02170f, 6.34885f, 0.16336f);
            faces.Add(f2979);

            Face f2980 = new Face(m03___Default);
            f2980.AddVertex(-0.01702f, 6.33412f, 0.13930f);
            f2980.AddVertex(-0.02170f, 6.34885f, 0.16336f);
            f2980.AddVertex(-0.04619f, 6.34944f, 0.14911f);
            faces.Add(f2980);

            Face f2981 = new Face(m03___Default);
            f2981.AddVertex(-0.04619f, 6.34944f, 0.14911f);
            f2981.AddVertex(-0.02170f, 6.34885f, 0.16336f);
            f2981.AddVertex(-0.04555f, 6.36790f, 0.17081f);
            faces.Add(f2981);

            Face f2982 = new Face(m03___Default);
            f2982.AddVertex(-0.04619f, 6.34944f, 0.14911f);
            f2982.AddVertex(-0.04555f, 6.36790f, 0.17081f);
            f2982.AddVertex(-0.06647f, 6.37360f, 0.15475f);
            faces.Add(f2982);

            Face f2983 = new Face(m03___Default);
            f2983.AddVertex(-0.06647f, 6.37360f, 0.15475f);
            f2983.AddVertex(-0.04555f, 6.36790f, 0.17081f);
            f2983.AddVertex(-0.06139f, 6.39333f, 0.17255f);
            faces.Add(f2983);

            Face f2984 = new Face(m03___Default);
            f2984.AddVertex(0.00804f, 6.33790f, 0.15085f);
            f2984.AddVertex(0.03590f, 6.34944f, 0.15904f);
            f2984.AddVertex(0.00904f, 6.35813f, 0.17394f);
            faces.Add(f2984);

            Face f2985 = new Face(m03___Default);
            f2985.AddVertex(0.00804f, 6.33790f, 0.15085f);
            f2985.AddVertex(0.00904f, 6.35813f, 0.17394f);
            f2985.AddVertex(-0.02170f, 6.34885f, 0.16336f);
            faces.Add(f2985);

            Face f2986 = new Face(m03___Default);
            f2986.AddVertex(-0.02170f, 6.34885f, 0.16336f);
            f2986.AddVertex(0.00904f, 6.35813f, 0.17394f);
            f2986.AddVertex(-0.01508f, 6.37304f, 0.18371f);
            faces.Add(f2986);

            Face f2987 = new Face(m03___Default);
            f2987.AddVertex(-0.02170f, 6.34885f, 0.16336f);
            f2987.AddVertex(-0.01508f, 6.37304f, 0.18371f);
            f2987.AddVertex(-0.04555f, 6.36790f, 0.17081f);
            faces.Add(f2987);

            Face f2988 = new Face(m03___Default);
            f2988.AddVertex(-0.04555f, 6.36790f, 0.17081f);
            f2988.AddVertex(-0.01508f, 6.37304f, 0.18371f);
            f2988.AddVertex(-0.03468f, 6.39304f, 0.18761f);
            faces.Add(f2988);

            Face f2989 = new Face(m03___Default);
            f2989.AddVertex(-0.04555f, 6.36790f, 0.17081f);
            f2989.AddVertex(-0.03468f, 6.39304f, 0.18761f);
            f2989.AddVertex(-0.06139f, 6.39333f, 0.17255f);
            faces.Add(f2989);

            Face f2990 = new Face(m03___Default);
            f2990.AddVertex(-0.06139f, 6.39333f, 0.17255f);
            f2990.AddVertex(-0.03468f, 6.39304f, 0.18761f);
            f2990.AddVertex(-0.04823f, 6.41660f, 0.18532f);
            faces.Add(f2990);

            Face f2991 = new Face(m03___Default);
            f2991.AddVertex(-0.05151f, 6.35039f, 0.10976f);
            f2991.AddVertex(-0.02614f, 6.33916f, 0.09564f);
            f2991.AddVertex(-0.03738f, 6.33839f, 0.12524f);
            faces.Add(f2991);

            Face f2992 = new Face(m03___Default);
            f2992.AddVertex(-0.02614f, 6.33916f, 0.09564f);
            f2992.AddVertex(0.00461f, 6.33559f, 0.08235f);
            f2992.AddVertex(-0.00882f, 6.32945f, 0.11105f);
            faces.Add(f2992);

            Face f2993 = new Face(m03___Default);
            f2993.AddVertex(-0.02614f, 6.33916f, 0.09564f);
            f2993.AddVertex(-0.00882f, 6.32945f, 0.11105f);
            f2993.AddVertex(-0.03738f, 6.33839f, 0.12524f);
            faces.Add(f2993);

            Face f2994 = new Face(m03___Default);
            f2994.AddVertex(-0.03738f, 6.33839f, 0.12524f);
            f2994.AddVertex(-0.00882f, 6.32945f, 0.11105f);
            f2994.AddVertex(-0.01702f, 6.33412f, 0.13930f);
            faces.Add(f2994);

            Face f2995 = new Face(m03___Default);
            f2995.AddVertex(0.00461f, 6.33559f, 0.08235f);
            f2995.AddVertex(0.03842f, 6.33996f, 0.07089f);
            f2995.AddVertex(0.02636f, 6.32944f, 0.09757f);
            faces.Add(f2995);

            Face f2996 = new Face(m03___Default);
            f2996.AddVertex(0.00461f, 6.33559f, 0.08235f);
            f2996.AddVertex(0.02636f, 6.32944f, 0.09757f);
            f2996.AddVertex(-0.00882f, 6.32945f, 0.11105f);
            faces.Add(f2996);

            Face f2997 = new Face(m03___Default);
            f2997.AddVertex(-0.00882f, 6.32945f, 0.11105f);
            f2997.AddVertex(0.02636f, 6.32944f, 0.09757f);
            f2997.AddVertex(0.01592f, 6.32873f, 0.12504f);
            faces.Add(f2997);

            Face f2998 = new Face(m03___Default);
            f2998.AddVertex(-0.00882f, 6.32945f, 0.11105f);
            f2998.AddVertex(0.01592f, 6.32873f, 0.12504f);
            f2998.AddVertex(-0.01702f, 6.33412f, 0.13930f);
            faces.Add(f2998);

            Face f2999 = new Face(m03___Default);
            f2999.AddVertex(-0.01702f, 6.33412f, 0.13930f);
            f2999.AddVertex(0.01592f, 6.32873f, 0.12504f);
            f2999.AddVertex(0.00804f, 6.33790f, 0.15085f);
            faces.Add(f2999);

            Face f3000 = new Face(m03___Default);
            f3000.AddVertex(0.03842f, 6.33996f, 0.07089f);
            f3000.AddVertex(0.07270f, 6.35193f, 0.06214f);
            f3000.AddVertex(0.06513f, 6.33967f, 0.08595f);
            faces.Add(f3000);

            Face f3001 = new Face(m03___Default);
            f3001.AddVertex(0.03842f, 6.33996f, 0.07089f);
            f3001.AddVertex(0.06513f, 6.33967f, 0.08595f);
            f3001.AddVertex(0.02636f, 6.32944f, 0.09757f);
            faces.Add(f3001);

            Face f3002 = new Face(m03___Default);
            f3002.AddVertex(0.02636f, 6.32944f, 0.09757f);
            f3002.AddVertex(0.06513f, 6.33967f, 0.08595f);
            f3002.AddVertex(0.05599f, 6.33503f, 0.11131f);
            faces.Add(f3002);

            Face f3003 = new Face(m03___Default);
            f3003.AddVertex(0.02636f, 6.32944f, 0.09757f);
            f3003.AddVertex(0.05599f, 6.33503f, 0.11131f);
            f3003.AddVertex(0.01592f, 6.32873f, 0.12504f);
            faces.Add(f3003);

            Face f3004 = new Face(m03___Default);
            f3004.AddVertex(0.01592f, 6.32873f, 0.12504f);
            f3004.AddVertex(0.05599f, 6.33503f, 0.11131f);
            f3004.AddVertex(0.04599f, 6.33837f, 0.13631f);
            faces.Add(f3004);

            Face f3005 = new Face(m03___Default);
            f3005.AddVertex(0.01592f, 6.32873f, 0.12504f);
            f3005.AddVertex(0.04599f, 6.33837f, 0.13631f);
            f3005.AddVertex(0.00804f, 6.33790f, 0.15085f);
            faces.Add(f3005);

            Face f3006 = new Face(m03___Default);
            f3006.AddVertex(0.00804f, 6.33790f, 0.15085f);
            f3006.AddVertex(0.04599f, 6.33837f, 0.13631f);
            f3006.AddVertex(0.03590f, 6.34944f, 0.15904f);
            faces.Add(f3006);

            Face f3007 = new Face(m07___Default);
            f3007.AddVertex(0.02129f, 1.28418f, -0.00328f);
            f3007.AddVertex(0.76532f, 1.25750f, -0.00328f);
            f3007.AddVertex(0.02129f, 1.25750f, -0.74732f);
            faces.Add(f3007);

            Face f3008 = new Face(m07___Default);
            f3008.AddVertex(0.02129f, 1.28418f, -0.00328f);
            f3008.AddVertex(0.02129f, 1.25750f, -0.74732f);
            f3008.AddVertex(-0.72274f, 1.25750f, -0.00328f);
            faces.Add(f3008);

            Face f3009 = new Face(m07___Default);
            f3009.AddVertex(0.02129f, 1.28418f, -0.00328f);
            f3009.AddVertex(-0.72274f, 1.25750f, -0.00328f);
            f3009.AddVertex(0.02129f, 1.25750f, 0.74074f);
            faces.Add(f3009);

            Face f3010 = new Face(m07___Default);
            f3010.AddVertex(0.02129f, 1.28418f, -0.00328f);
            f3010.AddVertex(0.02129f, 1.25750f, 0.74074f);
            f3010.AddVertex(0.76532f, 1.25750f, -0.00328f);
            faces.Add(f3010);

            Face f3011 = new Face(Material__289);
            f3011.AddVertex(0.94249f, 1.59095f, -0.00328f);
            f3011.AddVertex(1.32406f, 0.66975f, -0.00328f);
            f3011.AddVertex(0.94249f, 0.66975f, -0.92448f);
            faces.Add(f3011);

            Face f3012 = new Face(Material__289);
            f3012.AddVertex(0.94249f, 1.59095f, -0.00328f);
            f3012.AddVertex(0.94249f, 0.66975f, -0.92448f);
            f3012.AddVertex(0.02129f, 1.59095f, -0.92448f);
            faces.Add(f3012);

            Face f3013 = new Face(Material__289);
            f3013.AddVertex(0.02129f, 1.59095f, -0.92448f);
            f3013.AddVertex(0.94249f, 0.66975f, -0.92448f);
            f3013.AddVertex(0.02129f, 0.66975f, -1.30606f);
            faces.Add(f3013);

            Face f3014 = new Face(Material__289);
            f3014.AddVertex(0.02129f, 1.59095f, -0.92448f);
            f3014.AddVertex(0.02129f, 0.66975f, -1.30606f);
            f3014.AddVertex(-0.89991f, 0.66975f, -0.92448f);
            faces.Add(f3014);

            Face f3015 = new Face(Material__289);
            f3015.AddVertex(0.02129f, 1.59095f, -0.92448f);
            f3015.AddVertex(-0.89991f, 0.66975f, -0.92448f);
            f3015.AddVertex(-0.89991f, 1.59095f, -0.00328f);
            faces.Add(f3015);

            Face f3016 = new Face(Material__289);
            f3016.AddVertex(-0.89991f, 1.59095f, -0.00328f);
            f3016.AddVertex(-0.89991f, 0.66975f, -0.92448f);
            f3016.AddVertex(-1.28148f, 0.66975f, -0.00328f);
            faces.Add(f3016);

            Face f3017 = new Face(Material__289);
            f3017.AddVertex(-0.89991f, 1.59095f, -0.00328f);
            f3017.AddVertex(-1.28148f, 0.66975f, -0.00328f);
            f3017.AddVertex(-0.89991f, 0.66975f, 0.91791f);
            faces.Add(f3017);

            Face f3018 = new Face(Material__289);
            f3018.AddVertex(-0.89991f, 1.59095f, -0.00328f);
            f3018.AddVertex(-0.89991f, 0.66975f, 0.91791f);
            f3018.AddVertex(0.02129f, 1.59095f, 0.91791f);
            faces.Add(f3018);

            Face f3019 = new Face(Material__289);
            f3019.AddVertex(0.02129f, 1.59095f, 0.91791f);
            f3019.AddVertex(-0.89991f, 0.66975f, 0.91791f);
            f3019.AddVertex(0.02129f, 0.66975f, 1.29949f);
            faces.Add(f3019);

            Face f3020 = new Face(Material__289);
            f3020.AddVertex(0.02129f, 1.59095f, 0.91791f);
            f3020.AddVertex(0.02129f, 0.66975f, 1.29949f);
            f3020.AddVertex(0.94249f, 0.66975f, 0.91791f);
            faces.Add(f3020);

            Face f3021 = new Face(Material__289);
            f3021.AddVertex(0.02129f, 1.59095f, 0.91791f);
            f3021.AddVertex(0.94249f, 0.66975f, 0.91791f);
            f3021.AddVertex(0.94249f, 1.59095f, -0.00328f);
            faces.Add(f3021);

            Face f3022 = new Face(Material__289);
            f3022.AddVertex(0.94249f, 1.59095f, -0.00328f);
            f3022.AddVertex(0.94249f, 0.66975f, 0.91791f);
            f3022.AddVertex(1.32406f, 0.66975f, -0.00328f);
            faces.Add(f3022);

            Face f3023 = new Face(Material__289);
            f3023.AddVertex(0.02129f, -0.27033f, -0.00328f);
            f3023.AddVertex(0.02129f, -0.25145f, -0.92448f);
            f3023.AddVertex(0.94249f, -0.25145f, -0.00328f);
            faces.Add(f3023);

            Face f3024 = new Face(Material__289);
            f3024.AddVertex(0.02129f, -0.25145f, -0.92448f);
            f3024.AddVertex(0.02129f, 0.66975f, -1.30606f);
            f3024.AddVertex(0.94249f, 0.66975f, -0.92448f);
            faces.Add(f3024);

            Face f3025 = new Face(Material__289);
            f3025.AddVertex(0.02129f, -0.25145f, -0.92448f);
            f3025.AddVertex(0.94249f, 0.66975f, -0.92448f);
            f3025.AddVertex(0.94249f, -0.25145f, -0.00328f);
            faces.Add(f3025);

            Face f3026 = new Face(Material__289);
            f3026.AddVertex(0.94249f, -0.25145f, -0.00328f);
            f3026.AddVertex(0.94249f, 0.66975f, -0.92448f);
            f3026.AddVertex(1.32406f, 0.66975f, -0.00328f);
            faces.Add(f3026);

            Face f3027 = new Face(Material__289);
            f3027.AddVertex(0.02129f, -0.27033f, -0.00328f);
            f3027.AddVertex(-0.89991f, -0.25145f, -0.00328f);
            f3027.AddVertex(0.02129f, -0.25145f, -0.92448f);
            faces.Add(f3027);

            Face f3028 = new Face(Material__289);
            f3028.AddVertex(-0.89991f, -0.25145f, -0.00328f);
            f3028.AddVertex(-1.28148f, 0.66975f, -0.00328f);
            f3028.AddVertex(-0.89991f, 0.66975f, -0.92448f);
            faces.Add(f3028);

            Face f3029 = new Face(Material__289);
            f3029.AddVertex(-0.89991f, -0.25145f, -0.00328f);
            f3029.AddVertex(-0.89991f, 0.66975f, -0.92448f);
            f3029.AddVertex(0.02129f, -0.25145f, -0.92448f);
            faces.Add(f3029);

            Face f3030 = new Face(Material__289);
            f3030.AddVertex(0.02129f, -0.25145f, -0.92448f);
            f3030.AddVertex(-0.89991f, 0.66975f, -0.92448f);
            f3030.AddVertex(0.02129f, 0.66975f, -1.30606f);
            faces.Add(f3030);

            Face f3031 = new Face(Material__289);
            f3031.AddVertex(0.02129f, -0.27033f, -0.00328f);
            f3031.AddVertex(0.02129f, -0.25145f, 0.91791f);
            f3031.AddVertex(-0.89991f, -0.25145f, -0.00328f);
            faces.Add(f3031);

            Face f3032 = new Face(Material__289);
            f3032.AddVertex(0.02129f, -0.25145f, 0.91791f);
            f3032.AddVertex(0.02129f, 0.66975f, 1.29949f);
            f3032.AddVertex(-0.89991f, 0.66975f, 0.91791f);
            faces.Add(f3032);

            Face f3033 = new Face(Material__289);
            f3033.AddVertex(0.02129f, -0.25145f, 0.91791f);
            f3033.AddVertex(-0.89991f, 0.66975f, 0.91791f);
            f3033.AddVertex(-0.89991f, -0.25145f, -0.00328f);
            faces.Add(f3033);

            Face f3034 = new Face(Material__289);
            f3034.AddVertex(-0.89991f, -0.25145f, -0.00328f);
            f3034.AddVertex(-0.89991f, 0.66975f, 0.91791f);
            f3034.AddVertex(-1.28148f, 0.66975f, -0.00328f);
            faces.Add(f3034);

            Face f3035 = new Face(Material__289);
            f3035.AddVertex(0.02129f, -0.27033f, -0.00328f);
            f3035.AddVertex(0.94249f, -0.25145f, -0.00328f);
            f3035.AddVertex(0.02129f, -0.25145f, 0.91791f);
            faces.Add(f3035);

            Face f3036 = new Face(Material__289);
            f3036.AddVertex(0.94249f, -0.25145f, -0.00328f);
            f3036.AddVertex(1.32406f, 0.66975f, -0.00328f);
            f3036.AddVertex(0.94249f, 0.66975f, 0.91791f);
            faces.Add(f3036);

            Face f3037 = new Face(Material__289);
            f3037.AddVertex(0.94249f, -0.25145f, -0.00328f);
            f3037.AddVertex(0.94249f, 0.66975f, 0.91791f);
            f3037.AddVertex(0.02129f, -0.25145f, 0.91791f);
            faces.Add(f3037);

            Face f3038 = new Face(Material__289);
            f3038.AddVertex(0.02129f, -0.25145f, 0.91791f);
            f3038.AddVertex(0.94249f, 0.66975f, 0.91791f);
            f3038.AddVertex(0.02129f, 0.66975f, 1.29949f);
            faces.Add(f3038);

            Face f3039 = new Face(Material__289);
            f3039.AddVertex(0.94249f, 1.59095f, -0.00328f);
            f3039.AddVertex(0.02129f, 1.59095f, -0.92448f);
            f3039.AddVertex(0.02129f, 1.59902f, -0.83596f);
            f3039.AddVertex(0.85396f, 1.59902f, -0.00328f);
            faces.Add(f3039);

            Face f3040 = new Face(Material__289);
            f3040.AddVertex(0.02129f, 1.59095f, -0.92448f);
            f3040.AddVertex(-0.89991f, 1.59095f, -0.00328f);
            f3040.AddVertex(-0.81138f, 1.59902f, -0.00328f);
            f3040.AddVertex(0.02129f, 1.59902f, -0.83596f);
            faces.Add(f3040);

            Face f3041 = new Face(Material__289);
            f3041.AddVertex(-0.89991f, 1.59095f, -0.00328f);
            f3041.AddVertex(0.02129f, 1.59095f, 0.91791f);
            f3041.AddVertex(0.02129f, 1.59902f, 0.82938f);
            f3041.AddVertex(-0.81138f, 1.59902f, -0.00328f);
            faces.Add(f3041);

            Face f3042 = new Face(Material__289);
            f3042.AddVertex(0.02129f, 1.59095f, 0.91791f);
            f3042.AddVertex(0.94249f, 1.59095f, -0.00328f);
            f3042.AddVertex(0.85396f, 1.59902f, -0.00328f);
            f3042.AddVertex(0.02129f, 1.59902f, 0.82938f);
            faces.Add(f3042);

            Face f3043 = new Face(Material__289);
            f3043.AddVertex(0.85396f, 1.59902f, -0.00328f);
            f3043.AddVertex(0.02129f, 1.59902f, -0.83596f);
            f3043.AddVertex(0.02129f, 1.60623f, -0.74732f);
            f3043.AddVertex(0.76532f, 1.60623f, -0.00328f);
            faces.Add(f3043);

            Face f3044 = new Face(Material__289);
            f3044.AddVertex(0.02129f, 1.59902f, -0.83596f);
            f3044.AddVertex(-0.81138f, 1.59902f, -0.00328f);
            f3044.AddVertex(-0.72274f, 1.60623f, -0.00328f);
            f3044.AddVertex(0.02129f, 1.60623f, -0.74732f);
            faces.Add(f3044);

            Face f3045 = new Face(Material__289);
            f3045.AddVertex(-0.81138f, 1.59902f, -0.00328f);
            f3045.AddVertex(0.02129f, 1.59902f, 0.82938f);
            f3045.AddVertex(0.02129f, 1.60623f, 0.74074f);
            f3045.AddVertex(-0.72274f, 1.60623f, -0.00328f);
            faces.Add(f3045);

            Face f3046 = new Face(Material__289);
            f3046.AddVertex(0.02129f, 1.59902f, 0.82938f);
            f3046.AddVertex(0.85396f, 1.59902f, -0.00328f);
            f3046.AddVertex(0.76532f, 1.60623f, -0.00328f);
            f3046.AddVertex(0.02129f, 1.60623f, 0.74074f);
            faces.Add(f3046);

            Face f3047 = new Face(Material__289);
            f3047.AddVertex(0.76532f, 1.60623f, -0.00328f);
            f3047.AddVertex(0.02129f, 1.60623f, -0.74732f);
            f3047.AddVertex(0.02129f, 1.25750f, -0.74732f);
            f3047.AddVertex(0.76532f, 1.25750f, -0.00328f);
            faces.Add(f3047);

            Face f3048 = new Face(Material__289);
            f3048.AddVertex(0.02129f, 1.60623f, -0.74732f);
            f3048.AddVertex(-0.72274f, 1.60623f, -0.00328f);
            f3048.AddVertex(-0.72274f, 1.25750f, -0.00328f);
            f3048.AddVertex(0.02129f, 1.25750f, -0.74732f);
            faces.Add(f3048);

            Face f3049 = new Face(Material__289);
            f3049.AddVertex(-0.72274f, 1.60623f, -0.00328f);
            f3049.AddVertex(0.02129f, 1.60623f, 0.74074f);
            f3049.AddVertex(0.02129f, 1.25750f, 0.74074f);
            f3049.AddVertex(-0.72274f, 1.25750f, -0.00328f);
            faces.Add(f3049);

            Face f3050 = new Face(Material__289);
            f3050.AddVertex(0.02129f, 1.60623f, 0.74074f);
            f3050.AddVertex(0.76532f, 1.60623f, -0.00328f);
            f3050.AddVertex(0.76532f, 1.25750f, -0.00328f);
            f3050.AddVertex(0.02129f, 1.25750f, 0.74074f);
            faces.Add(f3050);

            foreach (Face f in faces)
            {
                for (int i = 0; i < f.vertices.Count; i++)
                {
                    f.vertices[i].x *= 3;
                    f.vertices[i].y *= 3;
                    f.vertices[i].z *= 3;
                }
            }

            return faces;
        }
    }
}
