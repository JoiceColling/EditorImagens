using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace EditorImagens.Processes
{
    public class GaussProcess
    {
        public static Bitmap Process(Bitmap image, double sigma, int kernelSize)
        {
            int width = image.Width;
            int height = image.Height;
            Bitmap outputImage = new Bitmap(width, height);

            double[,] kernel = CreateGaussianKernel(kernelSize, sigma);

            BitmapData inputData = image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData outputData = outputImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            int bytesPerPixel = 4;
            int stride = inputData.Stride;

            unsafe
            {
                byte* inputPtr = (byte*)inputData.Scan0.ToPointer();
                byte* outputPtr = (byte*)outputData.Scan0.ToPointer();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        double red = 0;
                        double green = 0;
                        double blue = 0;

                        for (int i = 0; i < kernelSize; i++)
                        {
                            for (int j = 0; j < kernelSize; j++)
                            {
                                int offsetX = x + i - kernelSize / 2;
                                int offsetY = y + j - kernelSize / 2;

                                if (offsetX >= 0 && offsetX < width && offsetY >= 0 && offsetY < height)
                                {
                                    byte* currentPixel = inputPtr + offsetY * stride + offsetX * bytesPerPixel;

                                    red += currentPixel[2] * kernel[i, j];
                                    green += currentPixel[1] * kernel[i, j];
                                    blue += currentPixel[0] * kernel[i, j];
                                }
                            }
                        }

                        byte* outputPixel = outputPtr + y * stride + x * bytesPerPixel;
                        outputPixel[2] = (byte)Math.Max(0, Math.Min(255, red));
                        outputPixel[1] = (byte)Math.Max(0, Math.Min(255, green));
                        outputPixel[0] = (byte)Math.Max(0, Math.Min(255, blue));
                        outputPixel[3] = 255;
                    }
                }
            }

            image.UnlockBits(inputData);
            outputImage.UnlockBits(outputData);

            return outputImage;
        }
        
        static double[,] CreateGaussianKernel(int size, double sigma)
        {
            double[,] kernel = new double[size, size];
            double sum = 0;
            int radius = size / 2;
        
            for (int x = -radius; x <= radius; x++)
            {
                for (int y = -radius; y <= radius; y++)
                {
                    double value = Math.Exp(-(x * x + y * y) / (2 * sigma * sigma));
                    kernel[x + radius, y + radius] = value;
                    sum += value;
                }
            }
        
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    kernel[x, y] /= sum;
                }
            }
            return kernel;
        }
    }
}
