using System.Drawing;

namespace EditorImagens.Processes
{
    public class ClosingProcess
    {
        public static Bitmap Process(Bitmap image)
        {
            Bitmap dilatedImage = DilationProcess.Process(image);
            Bitmap closedImage = ErosionProcess.Process(dilatedImage);

            return closedImage;
        }
    }
}
