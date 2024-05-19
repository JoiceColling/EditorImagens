using System;
using System.Drawing;
using System.Linq;

namespace EditorImagens.Processes
{
    public class ModeProcess
    {
        public static Bitmap Process(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            int neighborhoodSize = 3;

            Bitmap outputImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color[] neighborhood = GetNeighborhood(image, x, y, neighborhoodSize);
                    Color modeColor = GetModeColor(neighborhood);
                    outputImage.SetPixel(x, y, modeColor);
                }
            }

            return outputImage;
        }

        private static Color[] GetNeighborhood(Bitmap image, int x, int y, int size)
        {
            int startX = Math.Max(0, x - size / 2);
            int startY = Math.Max(0, y - size / 2);
            int endX = Math.Min(image.Width - 1, x + size / 2);
            int endY = Math.Min(image.Height - 1, y + size / 2);

            Color[] neighborhood = new Color[(endX - startX + 1) * (endY - startY + 1)];
            int index = 0;

            for (int i = startX; i <= endX; i++)
            {
                for (int j = startY; j <= endY; j++)
                {
                    neighborhood[index] = image.GetPixel(i, j);
                    index++;
                }
            }

            return neighborhood;
        }

        private static Color GetModeColor(Color[] colors)
        {
            var groupedColors = colors
                .GroupBy(c => c)
                .OrderByDescending(g => g.Count());

            return groupedColors.First().Key;
        }
    }
}
