using System.Drawing;

namespace EditorImagens.Processes
{
    public class GrayscaleProcess
    {
        public static Bitmap Process(Bitmap image)
        {
            Bitmap outputImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color pixel = image.GetPixel(x, y);
                    int grayValue = (int)(pixel.R * 0.299 + pixel.G * 0.587 + pixel.B * 0.114);
                    Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                    outputImage.SetPixel(x, y, grayColor);
                }
            }

            return outputImage;
        }
    }
}
