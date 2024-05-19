using System.Drawing;

namespace EditorImagens.Processes
{
    public class AverageProcess
    {
        public static Bitmap Process(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            int maskSize = 3;

            Bitmap outputBitmap = new Bitmap(width, height);

            int halfMask = maskSize / 2;

            for (int x = halfMask; x < width - halfMask; x++)
            {
                for (int y = halfMask; y < height - halfMask; y++)
                {
                    Color pixel = CalculateAverage(image, x, y, halfMask);
                    outputBitmap.SetPixel(x, y, pixel);
                }
            }

            return outputBitmap;
        }

        private static Color CalculateAverage(Bitmap image, int x, int y, int halfMask)
        {
            int redTotal = 0;
            int greenTotal = 0;
            int blueTotal = 0;
            int count = 0;

            for (int i = -halfMask; i <= halfMask; i++)
            {
                for (int j = -halfMask; j <= halfMask; j++)
                {
                    Color pixel = image.GetPixel(x + i, y + j);
                    redTotal += pixel.R;
                    greenTotal += pixel.G;
                    blueTotal += pixel.B;
                    count++;
                }
            }

            int red = redTotal / count;
            int green = greenTotal / count;
            int blue = blueTotal / count;

            return Color.FromArgb(red, green, blue);
        }
    }
}
