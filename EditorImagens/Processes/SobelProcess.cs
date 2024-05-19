using System;
using System.Drawing;

namespace EditorImagens.Processes
{
    public class SobelProcess
    {
        private static readonly int[,] kernelX = new int[3, 3]
        {
            { 1, 0, -1 },
            { 2, 0, -2 },
            { 1, 0, -1 }
        };

        private static readonly int[,] kernelY = new int[3, 3]
        {
            { 1, 2, 1 },
            { 0, 0, 0 },
            { -1, -2, -1 }
        };

        public static Bitmap Process(Bitmap image)
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap outputImage = new Bitmap(width, height);

            for (int x = 1; x < width - 1; x++)
            {
                for (int y = 1; y < height - 1; y++)
                {
                    int totalKernelXR = 0;
                    int totalKernelYR = 0;
                    int totalKernelXG = 0;
                    int totalKernelYG = 0;
                    int totalKernelXB = 0;
                    int totalKernelYB = 0;

                    for (int i = -1; i <= 1; i++)
                    {
                        for (int j = -1; j <= 1; j++)
                        {
                            Color pixel = image.GetPixel(x + i, y + j);

                            totalKernelXR += pixel.R * kernelX[i + 1, j + 1];
                            totalKernelYR += pixel.R * kernelY[i + 1, j + 1];

                            totalKernelXG += pixel.G * kernelX[i + 1, j + 1];
                            totalKernelYG += pixel.G * kernelY[i + 1, j + 1];

                            totalKernelXB += pixel.B * kernelX[i + 1, j + 1];
                            totalKernelYB += pixel.B * kernelY[i + 1, j + 1];
                        }
                    }

                    int gradientR = (int)Math.Sqrt(totalKernelXR * totalKernelXR + totalKernelYR * totalKernelYR);
                    int gradientG = (int)Math.Sqrt(totalKernelXG * totalKernelXG + totalKernelYG * totalKernelYG);
                    int gradientB = (int)Math.Sqrt(totalKernelXB * totalKernelXB + totalKernelYB * totalKernelYB);

                    gradientR = Math.Min(255, Math.Max(0, gradientR));
                    gradientG = Math.Min(255, Math.Max(0, gradientG));
                    gradientB = Math.Min(255, Math.Max(0, gradientB));

                    Color edgeColor = Color.FromArgb(gradientR, gradientG, gradientB);
                    outputImage.SetPixel(x, y, edgeColor);
                }
            }

            return outputImage;
        }
    }
}
