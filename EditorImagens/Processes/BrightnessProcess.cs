using System;
using System.Drawing;

namespace EditorImagens.Processes
{
    public class BrightnessProcess
    {
        public static Bitmap Process(Bitmap image, int brightness)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            brightness = Math.Max(-255, Math.Min(255, brightness));

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);

                    int newR = Math.Min(255, Math.Max(0, pixel.R + brightness));
                    int newG = Math.Min(255, Math.Max(0, pixel.G + brightness));
                    int newB = Math.Min(255, Math.Max(0, pixel.B + brightness));

                    Color newColor = Color.FromArgb(newR, newG, newB);
                    outputImage.SetPixel(x, y, newColor);
                }
            }

            return outputImage;
        }
    }
}
