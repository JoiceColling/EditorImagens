using System.Drawing;

namespace EditorImagens.Processes
{
    public class OpeningProcess
    {
        public static Bitmap Process(Bitmap image)
        {
            Bitmap erodedImage = ErosionProcess.Process(image);
            Bitmap openedImage = DilationProcess.Process(erodedImage);

            return openedImage;
        }
    }
}
