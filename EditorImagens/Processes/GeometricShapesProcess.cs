using AForge.Imaging;
using AForge.Math.Geometry;
using AForge;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EditorImagens.Processes
{
    public class GeometricShapesProcess
    {
        public static GeometricShapesReturn Process(Bitmap bitmap)
        {
            try
            {
                Bitmap binaryImage = GrayscaleProcess.Process(bitmap);
                binaryImage = ThresholdProcess.Process(binaryImage, 128);

                SimpleShapeChecker shapeChecker = new SimpleShapeChecker();

                int squaresTotal = 0, circlesTotal = 0, rectanglesTotal = 0, trianglesTotal = 0;

                BlobCounter blobCounter = new BlobCounter
                {
                    FilterBlobs = true
                };
                blobCounter.ProcessImage(binaryImage);
                Blob[] blobs = blobCounter.GetObjectsInformation();

                int fullWidth = binaryImage.Width;
                int fullHeight = binaryImage.Height;

                foreach (var blob in blobs)
                {
                    List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blob);

                    if (shapeChecker.IsQuadrilateral(edgePoints, out var corners))
                    {
                        double width = blob.Rectangle.Width;
                        double height = blob.Rectangle.Height;
                        double aspectRatio = Math.Max(width, height) / Math.Min(width, height);

                        if (width != fullWidth && height != fullHeight)
                        {
                            if (aspectRatio <= 1.2)
                                squaresTotal++;
                            else
                                rectanglesTotal++;
                        }
                    }
                    else if (shapeChecker.IsTriangle(edgePoints, out corners))
                    {
                        trianglesTotal++;
                    }
                    else if (!shapeChecker.IsConvexPolygon(edgePoints, out corners))
                    {
                        circlesTotal++;
                    }
                }

                var geometricShapesReturn = new GeometricShapesReturn
                {
                    Image = binaryImage,
                    Result = $"Resultado:\nTriângulos: {trianglesTotal}\nCírculos: {circlesTotal}\nQuadrados: {squaresTotal}\nRetângulos: {rectanglesTotal}"
                };

                return geometricShapesReturn;
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível encontrar formas geométricas!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        public class GeometricShapesReturn
        {
            public Bitmap Image { get; set; }
            public string Result { get; set; }
        }
    }
}
