using System;
using System.Drawing;

namespace EditorImagens.Processes
{
    public class TranslationProcess
    {
        public static Bitmap Process(Bitmap bitmap, int x, int y)
        {
            double[,] kernel = new double[3, 3]
            {
                { 1, 0, -x },
                { 0, 1, -y },
                { 0, 0, 1 }
            };

            return Transform(bitmap, kernel);
        }

        private static Bitmap Transform(Bitmap bitmap, double[,] kernel)
        {
            Bitmap outputImage = new Bitmap(bitmap.Width, bitmap.Height);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    var halfX = bitmap.Width / 2;
                    var halfY = bitmap.Height / 2;
                    var tmpX = x - halfX;
                    var tmpY = y - halfY;
                    var newX = (int)Math.Round(tmpX * kernel[0, 0] + tmpY * kernel[0, 1] + 1 * kernel[0, 2]);
                    var newY = (int)Math.Round(tmpX * kernel[1, 0] + tmpY * kernel[1, 1] + 1 * kernel[1, 2]);
                    newX += halfX;
                    newY += halfY;

                    if (newX < bitmap.Width && newY < bitmap.Height && newX >= 0 && newY >= 0)
                    {
                        outputImage.SetPixel(x, y, bitmap.GetPixel(newX, newY));
                    }
                }
            }

            return outputImage;
        }
    }
}
