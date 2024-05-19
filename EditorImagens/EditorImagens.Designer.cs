namespace EditorImagens
{
    partial class EditorImagens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGoOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTransformations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTranslation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiResize = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHorizontalMirroring = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVerticalMirroring = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRotation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPreprocessing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGrayscale = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBrightness = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiContrast = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThreshold = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLowPassFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAverage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMedian = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGauss = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHighPassFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSobel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMathMorphology = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDilation = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiErosion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpening = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClosing = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChallenge = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGeometricShapes = new System.Windows.Forms.ToolStripMenuItem();
            this.gbOptions = new System.Windows.Forms.GroupBox();
            this.lblOption2 = new System.Windows.Forms.Label();
            this.tbOption2 = new System.Windows.Forms.TextBox();
            this.lblOption1 = new System.Windows.Forms.Label();
            this.tbOption1 = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblOption = new System.Windows.Forms.Label();
            this.gbSourceImage = new System.Windows.Forms.GroupBox();
            this.pbSourceImage = new System.Windows.Forms.PictureBox();
            this.gbTargetImage = new System.Windows.Forms.GroupBox();
            this.pbTargetImage = new System.Windows.Forms.PictureBox();
            this.lblGeometricShapesResult = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbOptions.SuspendLayout();
            this.gbSourceImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSourceImage)).BeginInit();
            this.gbTargetImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTargetImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiTransformations,
            this.tsmiPreprocessing,
            this.tsmiLowPassFilters,
            this.tsmiHighPassFilters,
            this.tsmiMathMorphology,
            this.tsmiChallenge});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpenImage,
            this.tsmiSaveImage,
            this.tsmiAbout,
            this.tsmiGoOut});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(61, 20);
            this.tsmiFile.Text = "Arquivo";
            // 
            // tsmiOpenImage
            // 
            this.tsmiOpenImage.Name = "tsmiOpenImage";
            this.tsmiOpenImage.Size = new System.Drawing.Size(152, 22);
            this.tsmiOpenImage.Text = "Abrir Imagem";
            this.tsmiOpenImage.Click += new System.EventHandler(this.tsmiOpenImage_Click);
            // 
            // tsmiSaveImage
            // 
            this.tsmiSaveImage.Name = "tsmiSaveImage";
            this.tsmiSaveImage.Size = new System.Drawing.Size(152, 22);
            this.tsmiSaveImage.Text = "Salvar Imagem";
            this.tsmiSaveImage.Click += new System.EventHandler(this.tsmiSaveImage_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(152, 22);
            this.tsmiAbout.Text = "Sobre";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiGoOut
            // 
            this.tsmiGoOut.Name = "tsmiGoOut";
            this.tsmiGoOut.Size = new System.Drawing.Size(152, 22);
            this.tsmiGoOut.Text = "Sair";
            this.tsmiGoOut.Click += new System.EventHandler(this.tsmiGoOut_Click);
            // 
            // tsmiTransformations
            // 
            this.tsmiTransformations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTranslation,
            this.tsmiResize,
            this.tsmiHorizontalMirroring,
            this.tsmiVerticalMirroring,
            this.tsmiRotation});
            this.tsmiTransformations.Name = "tsmiTransformations";
            this.tsmiTransformations.Size = new System.Drawing.Size(102, 20);
            this.tsmiTransformations.Text = "Transformações";
            // 
            // tsmiTranslation
            // 
            this.tsmiTranslation.Name = "tsmiTranslation";
            this.tsmiTranslation.Size = new System.Drawing.Size(207, 22);
            this.tsmiTranslation.Text = "Translação";
            this.tsmiTranslation.Click += new System.EventHandler(this.tsmiTranslation_Click);
            // 
            // tsmiResize
            // 
            this.tsmiResize.Name = "tsmiResize";
            this.tsmiResize.Size = new System.Drawing.Size(207, 22);
            this.tsmiResize.Text = "Redimencionamento";
            this.tsmiResize.Click += new System.EventHandler(this.tsmiResize_Click);
            // 
            // tsmiHorizontalMirroring
            // 
            this.tsmiHorizontalMirroring.Name = "tsmiHorizontalMirroring";
            this.tsmiHorizontalMirroring.Size = new System.Drawing.Size(207, 22);
            this.tsmiHorizontalMirroring.Text = "Espelhamento Horizontal";
            this.tsmiHorizontalMirroring.Click += new System.EventHandler(this.tsmiHorizontalMirroring_Click);
            // 
            // tsmiVerticalMirroring
            // 
            this.tsmiVerticalMirroring.Name = "tsmiVerticalMirroring";
            this.tsmiVerticalMirroring.Size = new System.Drawing.Size(207, 22);
            this.tsmiVerticalMirroring.Text = "Espelhamento Vertical";
            this.tsmiVerticalMirroring.Click += new System.EventHandler(this.tsmiVerticalMirroring_Click);
            // 
            // tsmiRotation
            // 
            this.tsmiRotation.Name = "tsmiRotation";
            this.tsmiRotation.Size = new System.Drawing.Size(207, 22);
            this.tsmiRotation.Text = "Rotação";
            this.tsmiRotation.Click += new System.EventHandler(this.tsmiRotation_Click);
            // 
            // tsmiPreprocessing
            // 
            this.tsmiPreprocessing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGrayscale,
            this.tsmiBrightness,
            this.tsmiContrast,
            this.tsmiThreshold});
            this.tsmiPreprocessing.Name = "tsmiPreprocessing";
            this.tsmiPreprocessing.Size = new System.Drawing.Size(122, 20);
            this.tsmiPreprocessing.Text = "Pré-Processamento";
            // 
            // tsmiGrayscale
            // 
            this.tsmiGrayscale.Name = "tsmiGrayscale";
            this.tsmiGrayscale.Size = new System.Drawing.Size(126, 22);
            this.tsmiGrayscale.Text = "Grayscale";
            this.tsmiGrayscale.Click += new System.EventHandler(this.tsmiGrayscale_Click);
            // 
            // tsmiBrightness
            // 
            this.tsmiBrightness.Name = "tsmiBrightness";
            this.tsmiBrightness.Size = new System.Drawing.Size(126, 22);
            this.tsmiBrightness.Text = "Brilho";
            this.tsmiBrightness.Click += new System.EventHandler(this.tsmiBrightness_Click);
            // 
            // tsmiContrast
            // 
            this.tsmiContrast.Name = "tsmiContrast";
            this.tsmiContrast.Size = new System.Drawing.Size(126, 22);
            this.tsmiContrast.Text = "Contraste";
            this.tsmiContrast.Click += new System.EventHandler(this.tsmiContrast_Click);
            // 
            // tsmiThreshold
            // 
            this.tsmiThreshold.Name = "tsmiThreshold";
            this.tsmiThreshold.Size = new System.Drawing.Size(126, 22);
            this.tsmiThreshold.Text = "Threshold";
            this.tsmiThreshold.Click += new System.EventHandler(this.tsmiThreshold_Click);
            // 
            // tsmiLowPassFilters
            // 
            this.tsmiLowPassFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAverage,
            this.tsmiMode,
            this.tsmiMedian,
            this.tsmiGauss});
            this.tsmiLowPassFilters.Name = "tsmiLowPassFilters";
            this.tsmiLowPassFilters.Size = new System.Drawing.Size(114, 20);
            this.tsmiLowPassFilters.Text = "Filtros Passa Baixa";
            // 
            // tsmiAverage
            // 
            this.tsmiAverage.Name = "tsmiAverage";
            this.tsmiAverage.Size = new System.Drawing.Size(120, 22);
            this.tsmiAverage.Text = "Média";
            this.tsmiAverage.Click += new System.EventHandler(this.tsmiAverage_Click);
            // 
            // tsmiMode
            // 
            this.tsmiMode.Name = "tsmiMode";
            this.tsmiMode.Size = new System.Drawing.Size(120, 22);
            this.tsmiMode.Text = "Moda";
            this.tsmiMode.Click += new System.EventHandler(this.tsmiMode_Click);
            // 
            // tsmiMedian
            // 
            this.tsmiMedian.Name = "tsmiMedian";
            this.tsmiMedian.Size = new System.Drawing.Size(120, 22);
            this.tsmiMedian.Text = "Mediana";
            this.tsmiMedian.Click += new System.EventHandler(this.tsmiMedian_Click);
            // 
            // tsmiGauss
            // 
            this.tsmiGauss.Name = "tsmiGauss";
            this.tsmiGauss.Size = new System.Drawing.Size(120, 22);
            this.tsmiGauss.Text = "Gauss";
            this.tsmiGauss.Click += new System.EventHandler(this.tsmiGauss_Click);
            // 
            // tsmiHighPassFilters
            // 
            this.tsmiHighPassFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSobel});
            this.tsmiHighPassFilters.Name = "tsmiHighPassFilters";
            this.tsmiHighPassFilters.Size = new System.Drawing.Size(107, 20);
            this.tsmiHighPassFilters.Text = "Filtros Passa Alta";
            // 
            // tsmiSobel
            // 
            this.tsmiSobel.Name = "tsmiSobel";
            this.tsmiSobel.Size = new System.Drawing.Size(103, 22);
            this.tsmiSobel.Text = "Sobel";
            this.tsmiSobel.Click += new System.EventHandler(this.tsmiSobel_Click);
            // 
            // tsmiMathMorphology
            // 
            this.tsmiMathMorphology.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDilation,
            this.tsmiErosion,
            this.tsmiOpening,
            this.tsmiClosing});
            this.tsmiMathMorphology.Name = "tsmiMathMorphology";
            this.tsmiMathMorphology.Size = new System.Drawing.Size(144, 20);
            this.tsmiMathMorphology.Text = "Morfologia Matemática";
            // 
            // tsmiDilation
            // 
            this.tsmiDilation.Name = "tsmiDilation";
            this.tsmiDilation.Size = new System.Drawing.Size(140, 22);
            this.tsmiDilation.Text = "Dilatação";
            this.tsmiDilation.Click += new System.EventHandler(this.tsmiDilation_Click);
            // 
            // tsmiErosion
            // 
            this.tsmiErosion.Name = "tsmiErosion";
            this.tsmiErosion.Size = new System.Drawing.Size(140, 22);
            this.tsmiErosion.Text = "Erosão";
            this.tsmiErosion.Click += new System.EventHandler(this.tsmiErosion_Click);
            // 
            // tsmiOpening
            // 
            this.tsmiOpening.Name = "tsmiOpening";
            this.tsmiOpening.Size = new System.Drawing.Size(140, 22);
            this.tsmiOpening.Text = "Abertura";
            this.tsmiOpening.Click += new System.EventHandler(this.tsmiOpening_Click);
            // 
            // tsmiClosing
            // 
            this.tsmiClosing.Name = "tsmiClosing";
            this.tsmiClosing.Size = new System.Drawing.Size(140, 22);
            this.tsmiClosing.Text = "Fechamento";
            this.tsmiClosing.Click += new System.EventHandler(this.tsmiClosing_Click);
            // 
            // tsmiChallenge
            // 
            this.tsmiChallenge.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGeometricShapes});
            this.tsmiChallenge.Name = "tsmiChallenge";
            this.tsmiChallenge.Size = new System.Drawing.Size(58, 20);
            this.tsmiChallenge.Text = "Desafio";
            // 
            // tsmiGeometricShapes
            // 
            this.tsmiGeometricShapes.Name = "tsmiGeometricShapes";
            this.tsmiGeometricShapes.Size = new System.Drawing.Size(182, 22);
            this.tsmiGeometricShapes.Text = "Formas Geométricas";
            this.tsmiGeometricShapes.Click += new System.EventHandler(this.tsmiGeometricShapes_Click);
            // 
            // gbOptions
            // 
            this.gbOptions.Controls.Add(this.lblOption2);
            this.gbOptions.Controls.Add(this.tbOption2);
            this.gbOptions.Controls.Add(this.lblOption1);
            this.gbOptions.Controls.Add(this.tbOption1);
            this.gbOptions.Location = new System.Drawing.Point(12, 84);
            this.gbOptions.Name = "gbOptions";
            this.gbOptions.Size = new System.Drawing.Size(149, 107);
            this.gbOptions.TabIndex = 1;
            this.gbOptions.TabStop = false;
            this.gbOptions.Text = "Opções";
            // 
            // lblOption2
            // 
            this.lblOption2.AutoSize = true;
            this.lblOption2.Location = new System.Drawing.Point(7, 63);
            this.lblOption2.Name = "lblOption2";
            this.lblOption2.Size = new System.Drawing.Size(48, 13);
            this.lblOption2.TabIndex = 3;
            this.lblOption2.Text = "Opção 2";
            // 
            // tbOption2
            // 
            this.tbOption2.Location = new System.Drawing.Point(6, 79);
            this.tbOption2.Name = "tbOption2";
            this.tbOption2.Size = new System.Drawing.Size(121, 20);
            this.tbOption2.TabIndex = 2;
            // 
            // lblOption1
            // 
            this.lblOption1.AutoSize = true;
            this.lblOption1.Location = new System.Drawing.Point(7, 20);
            this.lblOption1.Name = "lblOption1";
            this.lblOption1.Size = new System.Drawing.Size(48, 13);
            this.lblOption1.TabIndex = 1;
            this.lblOption1.Text = "Opção 1";
            // 
            // tbOption1
            // 
            this.tbOption1.Location = new System.Drawing.Point(6, 36);
            this.tbOption1.Name = "tbOption1";
            this.tbOption1.Size = new System.Drawing.Size(121, 20);
            this.tbOption1.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(12, 197);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(149, 23);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Processar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.Location = new System.Drawing.Point(7, 38);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(115, 29);
            this.lblOption.TabIndex = 2;
            this.lblOption.Text = "Processo";
            // 
            // gbSourceImage
            // 
            this.gbSourceImage.Controls.Add(this.pbSourceImage);
            this.gbSourceImage.Location = new System.Drawing.Point(167, 84);
            this.gbSourceImage.Name = "gbSourceImage";
            this.gbSourceImage.Size = new System.Drawing.Size(267, 283);
            this.gbSourceImage.TabIndex = 3;
            this.gbSourceImage.TabStop = false;
            this.gbSourceImage.Text = "Imagem Origem";
            // 
            // pbSourceImage
            // 
            this.pbSourceImage.Location = new System.Drawing.Point(6, 20);
            this.pbSourceImage.Name = "pbSourceImage";
            this.pbSourceImage.Size = new System.Drawing.Size(255, 255);
            this.pbSourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSourceImage.TabIndex = 0;
            this.pbSourceImage.TabStop = false;
            // 
            // gbTargetImage
            // 
            this.gbTargetImage.Controls.Add(this.pbTargetImage);
            this.gbTargetImage.Location = new System.Drawing.Point(440, 84);
            this.gbTargetImage.Name = "gbTargetImage";
            this.gbTargetImage.Size = new System.Drawing.Size(268, 283);
            this.gbTargetImage.TabIndex = 4;
            this.gbTargetImage.TabStop = false;
            this.gbTargetImage.Text = "Imagem Destino";
            // 
            // pbTargetImage
            // 
            this.pbTargetImage.Location = new System.Drawing.Point(6, 20);
            this.pbTargetImage.Name = "pbTargetImage";
            this.pbTargetImage.Size = new System.Drawing.Size(255, 255);
            this.pbTargetImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTargetImage.TabIndex = 0;
            this.pbTargetImage.TabStop = false;
            // 
            // lblGeometricShapesResult
            // 
            this.lblGeometricShapesResult.AutoSize = true;
            this.lblGeometricShapesResult.Location = new System.Drawing.Point(443, 370);
            this.lblGeometricShapesResult.Name = "lblGeometricShapesResult";
            this.lblGeometricShapesResult.Size = new System.Drawing.Size(92, 13);
            this.lblGeometricShapesResult.TabIndex = 6;
            this.lblGeometricShapesResult.Text = "Resultado desafio";
            // 
            // EditorImagens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 455);
            this.Controls.Add(this.lblGeometricShapesResult);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.gbTargetImage);
            this.Controls.Add(this.gbSourceImage);
            this.Controls.Add(this.lblOption);
            this.Controls.Add(this.gbOptions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditorImagens";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Imagens";
            this.Load += new System.EventHandler(this.EditorImagens_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbOptions.ResumeLayout(false);
            this.gbOptions.PerformLayout();
            this.gbSourceImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSourceImage)).EndInit();
            this.gbTargetImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTargetImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox gbOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpenImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiGoOut;
        private System.Windows.Forms.ToolStripMenuItem tsmiTransformations;
        private System.Windows.Forms.ToolStripMenuItem tsmiTranslation;
        private System.Windows.Forms.ToolStripMenuItem tsmiResize;
        private System.Windows.Forms.ToolStripMenuItem tsmiHorizontalMirroring;
        private System.Windows.Forms.ToolStripMenuItem tsmiVerticalMirroring;
        private System.Windows.Forms.ToolStripMenuItem tsmiRotation;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreprocessing;
        private System.Windows.Forms.ToolStripMenuItem tsmiGrayscale;
        private System.Windows.Forms.ToolStripMenuItem tsmiBrightness;
        private System.Windows.Forms.ToolStripMenuItem tsmiContrast;
        private System.Windows.Forms.ToolStripMenuItem tsmiLowPassFilters;
        private System.Windows.Forms.ToolStripMenuItem tsmiAverage;
        private System.Windows.Forms.ToolStripMenuItem tsmiMode;
        private System.Windows.Forms.ToolStripMenuItem tsmiMedian;
        private System.Windows.Forms.ToolStripMenuItem tsmiGauss;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Label lblOption2;
        private System.Windows.Forms.TextBox tbOption2;
        private System.Windows.Forms.Label lblOption1;
        private System.Windows.Forms.TextBox tbOption1;
        private System.Windows.Forms.GroupBox gbSourceImage;
        private System.Windows.Forms.PictureBox pbSourceImage;
        private System.Windows.Forms.GroupBox gbTargetImage;
        private System.Windows.Forms.PictureBox pbTargetImage;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.ToolStripMenuItem tsmiHighPassFilters;
        private System.Windows.Forms.ToolStripMenuItem tsmiSobel;
        private System.Windows.Forms.ToolStripMenuItem tsmiMathMorphology;
        private System.Windows.Forms.ToolStripMenuItem tsmiDilation;
        private System.Windows.Forms.ToolStripMenuItem tsmiErosion;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpening;
        private System.Windows.Forms.ToolStripMenuItem tsmiClosing;
        private System.Windows.Forms.ToolStripMenuItem tsmiThreshold;
        private System.Windows.Forms.ToolStripMenuItem tsmiChallenge;
        private System.Windows.Forms.ToolStripMenuItem tsmiGeometricShapes;
        private System.Windows.Forms.Label lblGeometricShapesResult;
    }
}