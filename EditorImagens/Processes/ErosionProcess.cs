using System.Drawing;

namespace EditorImagens.Processes
{
    public class ErosionProcess
    {
        public static Bitmap Process(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap outputImage = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color minColor = Color.White;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            int newX = x + i;
                            int newY = y + j;

                            if (newX >= 0 && newX < width && newY >= 0 && newY < height)
                            {
                                Color currentColor = image.GetPixel(newX, newY);
                                if (currentColor.R < minColor.R || currentColor.G < minColor.G || currentColor.B < minColor.B)
                                {
                                    minColor = currentColor;
                                }
                            }
                        }
                    }

                    outputImage.SetPixel(x, y, minColor);
                }
            }

            return outputImage;
        }
    }
}
