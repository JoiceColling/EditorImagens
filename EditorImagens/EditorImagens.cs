using EditorImagens.Processes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EditorImagens
{
    public partial class EditorImagens : Form
    {
        public EditorImagens()
        {
            InitializeComponent();
        }

        private void EditorImagens_Load(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (lblOption.Text == "Processo")
            {
                MessageBox.Show("Selecione um processo!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if ((tbOption1.Visible && string.IsNullOrEmpty(tbOption1.Text)) || (tbOption2.Visible && string.IsNullOrEmpty(tbOption2.Text)))
            {
                MessageBox.Show("Todos os parâmetros são obrigatórios", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (pbSourceImage.Image == null)
            {
                MessageBox.Show("Selecione uma imagem!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            switch (lblOption.Text)
            {
                case "Translação":
                    Translation();
                    break;
                case "Redimencionamento":
                    Resize();
                    break;
                case "Espelhamento Horizontal":
                    HorizontalMirroring();
                    break;
                case "Espelhamento Vertical":
                    VerticalMirroring();
                    break;
                case "Rotação":
                    Rotation();
                    break;
                case "Grayscale":
                    Grayscale();
                    break;
                case "Brilho":
                    Brightness();
                    break;
                case "Contraste":
                    Contrast();
                    break;
                case "Threshold":
                    Threshold();
                    break;
                case "Média":
                    Average();
                    break;
                case "Moda":
                    Mode();
                    break;
                case "Mediana":
                    Median();
                    break;
                case "Gauss":
                    Gauss();
                    break;
                case "Sobel":
                    Sobel();
                    break;
                case "Dilatação":
                    Dilation();
                    break;
                case "Erosão":
                    Erosion();
                    break;
                case "Abertura":
                    Opening();
                    break;
                case "Fechamento":
                    ClosingMethod();
                    break;
                case "Formas Geométricas":
                    GeometricShapes();
                    break;
            }
        }

        #region File

        private void tsmiOpenImage_Click(object sender, EventArgs e)
        {
            pbTargetImage.Image = null;
            lblGeometricShapesResult.Text = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                pbSourceImage.ImageLocation = openFileDialog.FileName;
            }
        }

        private void tsmiSaveImage_Click(object sender, EventArgs e)
        {
            if (pbTargetImage.Image != null)
            {
                Bitmap myImage = new Bitmap(pbTargetImage.Image);

                var saveFileDialog = new SaveFileDialog
                {
                    Filter = "JPG (*.jpg)|*.jpg|PNG (*.png)|*.png",
                    DefaultExt = "jpg",
                    AddExtension = false
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    myImage.Save(saveFileDialog.FileName);
                }
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void tsmiGoOut_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion File

        #region Transformations

        private void tsmiTranslation_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiTranslation.Text;

            ResetControls();
            lblOption1.Visible = true;
            lblOption1.Text = "X";
            tbOption1.Visible = true;

            lblOption2.Visible = true;
            lblOption2.Text = "Y";
            tbOption2.Visible = true;
        }

        private void Translation()
        {
            try
            {
                var option1 = Convert.ToInt32(tbOption1.Text);
                var option2 = Convert.ToInt32(tbOption2.Text);
                pbTargetImage.Image = TranslationProcess.Process((Bitmap)pbSourceImage.Image, option1, option2);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os parâmetros e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiResize_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiResize.Text;

            ResetControls();
            lblOption1.Visible = true;
            lblOption1.Text = "Tamanho X";
            tbOption1.Visible = true;
            tbOption1.Text = "1";

            lblOption2.Visible = true;
            lblOption2.Text = "Tamanho Y";
            tbOption2.Visible = true;
            tbOption2.Text = "1";
        }

        private void Resize()
        {
            try
            {
                var option1 = Convert.ToDouble(tbOption1.Text);
                var option2 = Convert.ToDouble(tbOption2.Text);
                pbTargetImage.Image = ResizeProcess.Process((Bitmap)pbSourceImage.Image, option1, option2);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os parâmetros e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiHorizontalMirroring_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiHorizontalMirroring.Text;

            ResetControls();
        }

        private void HorizontalMirroring()
        {
            pbTargetImage.Image = HorizontalMirroringProcess.Process((Bitmap)pbSourceImage.Image);
        }

        private void tsmiVerticalMirroring_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiVerticalMirroring.Text;

            ResetControls();
        }

        private void VerticalMirroring()
        {
            pbTargetImage.Image = VerticalMirroringProcess.Process((Bitmap)pbSourceImage.Image);
        }

        private void tsmiRotation_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiRotation.Text;

            ResetControls();
            lblOption1.Visible = true;
            lblOption1.Text = "Ângulo";
            tbOption1.Visible = true;
        }

        private void Rotation()
        {
            try
            {
                var option1 = Convert.ToDouble(tbOption1.Text);
                pbTargetImage.Image = RotationProcess.Process((Bitmap)pbSourceImage.Image, option1);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os parâmetros e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        #endregion Transformations

        #region Preprocessing

        private void tsmiGrayscale_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiGrayscale.Text;

            ResetControls();
        }

        private void Grayscale()
        {
            pbTargetImage.Image = GrayscaleProcess.Process((Bitmap)pbSourceImage.Image);
        }

        private void tsmiBrightness_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiBrightness.Text;

            ResetControls();
            lblOption1.Visible = true;
            lblOption1.Text = "Brilho";
            tbOption1.Visible = true;
        }

        private void Brightness()
        {
            try
            {
                var option1 = Convert.ToInt32(tbOption1.Text);
                pbTargetImage.Image = BrightnessProcess.Process((Bitmap)pbSourceImage.Image, option1);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os parâmetros e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiContrast_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiContrast.Text;

            ResetControls();
            lblOption1.Visible = true;
            lblOption1.Text = "Contraste";
            tbOption1.Visible = true;
        }

        private void Contrast()
        {
            try
            {
                var option1 = Convert.ToDouble(tbOption1.Text);
                pbTargetImage.Image = ContrastProcess.Process((Bitmap)pbSourceImage.Image, option1);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os parâmetros e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsmiThreshold_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiThreshold.Text;

            ResetControls();
            lblOption1.Visible = true;
            lblOption1.Text = "Threshold";
            tbOption1.Visible = true;
            tbOption1.Text = "128";
        }

        private void Threshold()
        {
            try
            {
                var option1 = Convert.ToInt32(tbOption1.Text);
                if (option1 < 0)
                {
                    option1 = 0;
                    tbOption1.Text = "0";
                }
                else if (option1 > 255)
                {
                    option1 = 255;
                    tbOption1.Text = "255";
                }
                    
                pbTargetImage.Image = ThresholdProcess.Process((Bitmap)pbSourceImage.Image, option1);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os parâmetros e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region LowPassFilters

        private void tsmiAverage_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiAverage.Text;

            ResetControls();
        }

        private void Average()
        {
            pbTargetImage.Image = AverageProcess.Process((Bitmap)pbSourceImage.Image);
        }

        private void tsmiMode_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiMode.Text;

            ResetControls();
        }

        private void Mode()
        {
            pbTargetImage.Image = ModeProcess.Process((Bitmap)pbSourceImage.Image);
        }

        private void tsmiMedian_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiMedian.Text;

            ResetControls();
        }

        private void Median()
        {
            pbTargetImage.Image = MedianProcess.Process((Bitmap)pbSourceImage.Image);
        }

        private void tsmiGauss_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiGauss.Text;

            ResetControls();
            lblOption1.Visible = true;
            lblOption1.Text = "Sigma";
            tbOption1.Visible = true;
            tbOption1.Text = "1,76";

            lblOption2.Visible = true;
            lblOption2.Text = "Tamanho da Máscara";
            tbOption2.Visible = true;
            tbOption2.Text = "5";
        }

        private void Gauss()
        {
            try
            {
                var option1 = Convert.ToDouble(tbOption1.Text);
                var option2 = Convert.ToInt32(tbOption2.Text);
                pbTargetImage.Image = GaussProcess.Process((Bitmap)pbSourceImage.Image, option1, option2);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique os parâmetros e tente novamente!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region HighPassFilters

        private void tsmiSobel_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiSobel.Text;

            ResetControls();
        }

        private void Sobel()
        {
            pbTargetImage.Image = SobelProcess.Process((Bitmap)pbSourceImage.Image);
        }

        #endregion

        #region MathMorphology

        private void tsmiDilation_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiDilation.Text;

            ResetControls();
        }

        private void Dilation()
        {
            pbTargetImage.Image = DilationProcess.Process((Bitmap)pbSourceImage.Image);
        }

        private void tsmiErosion_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiErosion.Text;

            ResetControls();
        }

        private void Erosion()
        {
            pbTargetImage.Image = ErosionProcess.Process((Bitmap)pbSourceImage.Image);
        }

        private void tsmiOpening_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiOpening.Text;

            ResetControls();
        }

        private void Opening()
        {
            pbTargetImage.Image = OpeningProcess.Process((Bitmap)pbSourceImage.Image);
        }

        private void tsmiClosing_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiClosing.Text;

            ResetControls();
        }

        private void ClosingMethod()
        {
            pbTargetImage.Image = ClosingProcess.Process((Bitmap)pbSourceImage.Image);
        }

        #endregion

        #region Challenge

        private void tsmiGeometricShapes_Click(object sender, EventArgs e)
        {
            lblOption.Text = tsmiGeometricShapes.Text;

            ResetControls();
        }

        private void GeometricShapes()
        {
            var geometricShapesReturn = GeometricShapesProcess.Process((Bitmap)pbSourceImage.Image);
            if (geometricShapesReturn != null)
            {
                pbTargetImage.Image = geometricShapesReturn.Image;
                lblGeometricShapesResult.Text = geometricShapesReturn.Result;
            } 
        }

        #endregion

        #region Methods

        private void ResetControls()
        {
            foreach (TextBoxBase c in gbOptions.Controls.OfType<TextBoxBase>())
            {
                c.Visible = false;
                c.Text = string.Empty;
            }

            foreach (Label c in gbOptions.Controls.OfType<Label>())
            {
                c.Visible = false;
            }

            pbTargetImage.Image = null;
            lblGeometricShapesResult.Text = string.Empty;
        }

        #endregion Methods 
    }
}
