namespace BlobTracking
{
    partial class BlobTracking
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
            this.captureImage = new Emgu.CV.UI.ImageBox();
            this.captureButton = new System.Windows.Forms.Button();
            this.maskImage = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.captureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskImage)).BeginInit();
            this.SuspendLayout();
            // 
            // captureImage
            // 
            this.captureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captureImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.captureImage.Location = new System.Drawing.Point(12, 12);
            this.captureImage.Name = "captureImage";
            this.captureImage.Size = new System.Drawing.Size(640, 480);
            this.captureImage.TabIndex = 2;
            this.captureImage.TabStop = false;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(12, 498);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(100, 30);
            this.captureButton.TabIndex = 3;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // maskImage
            // 
            this.maskImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.maskImage.Location = new System.Drawing.Point(658, 12);
            this.maskImage.Name = "maskImage";
            this.maskImage.Size = new System.Drawing.Size(640, 480);
            this.maskImage.TabIndex = 4;
            this.maskImage.TabStop = false;
            // 
            // BlobTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 730);
            this.Controls.Add(this.maskImage);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.captureImage);
            this.Name = "BlobTracking";
            this.Text = "Blob Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.captureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox captureImage;
        private System.Windows.Forms.Button captureButton;
        private Emgu.CV.UI.ImageBox maskImage;
    }
}

