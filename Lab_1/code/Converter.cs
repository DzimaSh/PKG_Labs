using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ColorConverter
{
    class Converter
    {
        public static String getHEX(Color clr)
        {
            return "#" + clr.R.ToString("X2") + clr.G.ToString("X2") + clr.B.ToString("X2");
        }

        public static Color fromRGB(int[] rgb)
        {
            return Color.FromArgb(rgb[0], rgb[1], rgb[2]);
        }

        public static Color fromHSV(int[] hsv)
        {
            double C = (double)hsv[1]/100 * (double)hsv[2]/100;
            double X = C * (1 - Math.Abs((double)hsv[0] / 60d % 2 - 1));
            double m = (double)hsv[2]/100 - C;
            return fromHS(hsv[0], C, X, m);
        }

        public static Color fromHSL(int[] hsl)
        {
            
            double C = (1 - (double)Math.Abs(2 * (double)hsl[2]/100 - 1)) * (double)hsl[1]/100;
            double X = C * (1 - Math.Abs((double)hsl[0] / 60 % 2 - 1));
            double m = (double)hsl[2]/100 - C/2;
            return fromHS(hsl[0], C, X, m);
        }
 
        
        private static Color fromHS (int h, double C, double X, double m)
        {
            double[] rgb = new double[3];

            if (h >= 0 && h < 60)
            {
                rgb[0] = C;
                rgb[1] = X;
                rgb[2] = 0;
            }
            else if (h >= 60 && h < 120)
            {
                rgb[0] = X;
                rgb[1] = C;
                rgb[2] = 0;
            }
            else if (h >= 120 && h < 180)
            {
                rgb[0] = 0;
                rgb[1] = C;
                rgb[2] = X;
            }
            else if (h >= 180 && h < 240)
            {
                rgb[0] = 0;
                rgb[1] = X;
                rgb[2] = C;
            }
            else if (h >= 240 && h < 300)
            {
                rgb[0] = X;
                rgb[1] = 0;
                rgb[2] = C;
            }
            else if (h >= 300 && h < 360)
            {
                rgb[0] = C;
                rgb[1] = 0;
                rgb[2] = X;
            }
            for (int i = 0 ; i < 3; i++)
            {
                rgb[i] += m;
                rgb[i] *= 255;
            }

            int[] clr = rgb.Select(d => (int)Math.Round(d)).ToArray();
            for (int i = 0; i < 3; i++)
            {
                if (clr[i] > 255)
                {
                    clr[i] = 255;
                }
                else if (clr[i] < 0)
                {
                    clr[i] = 0;
                }
            }

            return Color.FromArgb(clr[0], clr[1], clr[2]);
        }

        public static Color fromCMYK(int[] cmyk)
        {
            double[] rgb = new double[3];
            for (int i = 0; i < 3; i++)
            {
                rgb[i] = 255 * (1 - (double)cmyk[i]/100) * (1 - (double)cmyk[3]/100);
            }

            int[] clr = rgb.Select(d => (int)Math.Round(d)).ToArray();
            for (int i = 0; i < 3; i++)
            {
                if (clr[i] > 255)
                {
                    clr[i] = 255;
                }
                else if (clr[i] < 0)
                {
                    clr[i] = 0;
                }
            }
            return Color.FromArgb(clr[0], clr[1], clr[2]);
        }

        private static double[] fromXYZdouble(double[] xyz)
        {
            double[] modXyz = new double[3];
            double[] rgb = new double[3];
            for (int i = 0; i < 3; i++)
            {
                modXyz[i] = xyz[i]/100;
            }    

            rgb[0] = 3.2404542 * modXyz[0] - 0.4985314 * modXyz[1] - 0.4985314 * modXyz[2];
            rgb[1] = -0.9692660 * modXyz[0] + 1.8760108 * modXyz[1] + 0.0415560 * modXyz[2];
            rgb[2] = 0.0556434 * modXyz[0] - 0.2040259 * modXyz[1] + 1.0572252 * modXyz[2];

            for (int i = 0; i < 3; i++)
            {
                if (rgb[i] >= 0.0031308) rgb[i] = Math.Pow(modXyz[i], 1 / 2.4) * 1.055 - 0.055;
                else rgb[i] *= 12.92;
            }
            
            return rgb;
        }

        public static Color fromXYZ(int[] xyz)
        {
            double[] mXyz = {(double)xyz[0], (double)xyz[1], (double)xyz[2]};
            int[] clr = fromXYZdouble(mXyz).Select(d => (int)Math.Round(d*255d)).ToArray();
            for (int i = 0; i < 3; i++)
            {
                if (clr[i] < 0)
                {
                    clr[i] = 0;
                }
                else if (clr[i] > 255)
                {
                    clr[i] = 255;
                }
            }
            return Color.FromArgb(clr[0], clr[1], clr[2]);
        }

        public static Color fromLab(int[] lab)
        {
            double[] xyzW = {95.047, 100, 108.883};
            double[] xyz = new double[3];

            double F(double x) {
                if (x >= 0.008856)
                {
                    x = Math.Pow(x, 3d);
                }
                else
                {
                    x = (x - 16d/116d)/7.787;
                }
                return x;
            }
            
            xyz[0] = F(lab[1]/500d + ((lab[0] + 16)/116d))*xyzW[1];
            xyz[1] = F((lab[0] + 16)/116d)*xyzW[0];
            xyz[2] = F((lab[0] + 16)/116d - lab[2]/200d)*xyzW[2];
            int[] rgb = fromXYZdouble(xyz).Select(d => (int)Math.Round(d*255)).ToArray();
            for (int i = 0; i < 3; i++)
            {
                if (rgb[i] > 255)
                {
                    rgb[i] = 255;
                }
                else if (rgb[i] < 0)
                {
                    rgb[i] = 0;
                }
            }
            return Color.FromArgb(rgb[0], rgb[1], rgb[2]);
        }

        public static int[] toLab(Color clr)
        {
            double[] xyzW = {95.047, 100, 108.883};
            double[] xyz = toXYZdouble(clr);
            double[] lab = new double[3];

            double F(double x) {
                if (x >= 0.008856)
                {
                    x = Math.Pow(x, 1d/3d);
                }
                else
                {
                    x = 7.787*x + 16d/116d;
                }
                return x;
            }
            
            lab[0] = 116*F(xyz[1]/xyzW[1]) - 16;
            lab[1] = 500*(F(xyz[0]/xyzW[0]) - F(xyz[1]/xyzW[1]));
            lab[2] = 200*(F(xyz[1]/xyzW[1]) - F(xyz[2]/xyzW[2]));
            return lab.Select(d => (int)Math.Round(d)).ToArray();
        }

        public static int[] toRGB(Color clr)
        {
            int[] rgb = new int[3];
            rgb[0] = clr.R;
            rgb[1] = clr.G;
            rgb[2] = clr.B;
            return rgb;
        }

        private static double [] modifyRgb(Color clr)
        {
            double[] modRgb = new double[3] { (double)clr.R, (double)clr.B, (double)clr.G };
            for (int i = 0; i < modRgb.Length; i++)
            {
                modRgb[i] /= 255.0;
            }
            return modRgb;
        }

        private static double[] toXYZdouble(Color clr)
        {
            double[] xyz = new double[3];
            double[] modRgb = modifyRgb(clr);

            for (int i = 0; i < 3; i++)
            {
                modRgb[i] = (modRgb[i] > 0.04045) 
                    ? Math.Pow((modRgb[i] + 0.055) / 1.055, 2.4) 
                    : (modRgb[i] / 12.92);
                modRgb[i] *= 100d;
            }
            
            xyz[0] = modRgb[0] * 0.4124564 + modRgb[1] * 0.3575761 + modRgb[2] * 0.1804375;
            xyz[1] = modRgb[0] * 0.2126729 + modRgb[1] * 0.7151522 + modRgb[2] * 0.0721750;
            xyz[2] = modRgb[0] * 0.0193339 + modRgb[1] * 0.1191920 + modRgb[2] * 0.9503041;
            
            return xyz;
        }

        public static int[] toXYZ(Color color)
        {
            return toXYZdouble(color).Select(d => (int)Math.Round(d)).ToArray();
        }

        public static int[] toHSV(Color clr)
        {
            double[] hsv = new double[3] { -1, -1, 0 };
            double[] modRgb = modifyRgb(clr);

            double cmax = modRgb.Max();
            double cmin = modRgb.Min();
            double diff = cmax - cmin;

            if (cmax == cmin)
            {
                hsv[0] = 0;
            }
            else if (cmax == modRgb[0])
            {
                hsv[0] = (60 * ((modRgb[1] - modRgb[2]) / diff) + 360) % 360;
            }
            else if (cmax == modRgb[1])
            {
                hsv[0] = (60 * ((modRgb[2] - modRgb[0]) / diff) + 120) % 360;
            }
            else if (cmax == modRgb[2]) {
                hsv[0] = (60 * ((modRgb[0] - modRgb[1]) / diff) + 240) % 360;
            }

            hsv[1] = (cmax == 0) ? 0 : (diff / cmax) * 100;
            hsv[2] = cmax * 100;
            return hsv.Select(d => (int)Math.Round(d)).ToArray();
        }

        public static int[] toCMYK(Color clr)
        {
            double[] cmyk = new double[4];
            double[] modRgb = modifyRgb(clr);

            cmyk[3] = 1 - modRgb.Max();

            for (int i = 0; i < 3; i++)
            {
                cmyk[i] = (1 - modRgb[i] - cmyk[3]) / (1 - cmyk[3]);
            }

            for (int i = 0; i < 4; i++)
            {
                cmyk[i] = Math.Round(cmyk[i] * 100);
            }
            return cmyk.Select(d => (int)d).ToArray();
        }

        public static int[] toHSL(Color clr)
        {
            double[] hsl = new double[] { clr.GetHue()/100, clr.GetSaturation(), clr.GetBrightness() };
            return hsl.Select(d => (int)Math.Round(d*100)).ToArray();
        }
    }
}
