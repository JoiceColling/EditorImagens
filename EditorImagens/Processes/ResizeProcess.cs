using System;
using System.Drawing;

namespace EditorImagens.Processes
{
    public class ResizeProcess
    {
        public static Bitmap Process(Bitmap image, double x, double y)
        {
            double[,] kernel = new double[3, 3]
            {
                { 1.0 / x, 0, 0 },
                { 0, 1.0 / y, 0 },
                { 0, 0, 1 }
            };

            return Transform(image, kernel);
        }

        private static Bitmap Transform(Bitmap image, double[,] kernel)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            for (var x = 0; x < image.Width; x++)
            {
                for (var y = 0; y < image.Height; y++)
                {
                    var halfX = image.Width / 2;
                    var halfY = image.Height / 2;
                    var tmpX = x - halfX;
                    var tmpY = y - halfY;
                    var newX = (int)Math.Round(tmpX * kernel[0, 0] + tmpY * kernel[0, 1] + 1 * kernel[0, 2]);
                    var newY = (int)Math.Round(tmpX * kernel[1, 0] + tmpY * kernel[1, 1] + 1 * kernel[1, 2]);
                    newX += halfX;
                    newY += halfY;

                    if (newX < image.Width && newY < image.Height && newX >= 0 && newY >= 0)
                    {
                        outputImage.SetPixel(x, y, image.GetPixel(newX, newY)); 
                    }
                }
            }

            return outputImage;
        }
    }
}
