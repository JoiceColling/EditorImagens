using System;
using System.Drawing;

namespace EditorImagens.Processes
{
    public class ContrastProcess
    {
        public static Bitmap Process(Bitmap image, double contrast)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);
            contrast = Math.Max(0, contrast);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);

                    int newR = Clamp((int)(((pixel.R / 255.0 - 0.5) * contrast + 0.5) * 255.0));
                    int newG = Clamp((int)(((pixel.G / 255.0 - 0.5) * contrast + 0.5) * 255.0));
                    int newB = Clamp((int)(((pixel.B / 255.0 - 0.5) * contrast + 0.5) * 255.0));

                    Color newColor = Color.FromArgb(newR, newG, newB);
                    outputImage.SetPixel(x, y, newColor);
                }
            }

            return outputImage;
        }

        private static int Clamp(int value, int min = 0, int max = 255)
        {
            return Math.Min(max, Math.Max(min, value));
        }
    }
}
