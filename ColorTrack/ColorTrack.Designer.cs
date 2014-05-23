namespace ColorTrack
{
    partial class ColorTrack
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.camptureImage = new Emgu.CV.UI.ImageBox();
            this.treatedImage = new Emgu.CV.UI.ImageBox();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.camptureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // camptureImage
            // 
            this.camptureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camptureImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.camptureImage.Location = new System.Drawing.Point(12, 12);
            this.camptureImage.Name = "camptureImage";
            this.camptureImage.Size = new System.Drawing.Size(640, 480);
            this.camptureImage.TabIndex = 2;
            this.camptureImage.TabStop = false;
            // 
            // treatedImage
            // 
            this.treatedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treatedImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.treatedImage.Location = new System.Drawing.Point(658, 12);
            this.treatedImage.Name = "treatedImage";
            this.treatedImage.Size = new System.Drawing.Size(640, 480);
            this.treatedImage.TabIndex = 2;
            this.treatedImage.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 496);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(97, 36);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start/Stop";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // ColorTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 544);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.treatedImage);
            this.Controls.Add(this.camptureImage);
            this.Name = "ColorTrack";
            this.Text = "Color Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.camptureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox camptureImage;
        private Emgu.CV.UI.ImageBox treatedImage;
        private System.Windows.Forms.Button startButton;
    }
}

