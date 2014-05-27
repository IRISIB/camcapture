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
            this.thresholdValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.captureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValue)).BeginInit();
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
            // thresholdValue
            // 
            this.thresholdValue.Location = new System.Drawing.Point(208, 505);
            this.thresholdValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.thresholdValue.Name = "thresholdValue";
            this.thresholdValue.Size = new System.Drawing.Size(53, 20);
            this.thresholdValue.TabIndex = 5;
            this.thresholdValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.thresholdValue.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.thresholdValue.ValueChanged += new System.EventHandler(this.thresholdValue_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Threshold Value";
            // 
            // BlobTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 730);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.thresholdValue);
            this.Controls.Add(this.maskImage);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.captureImage);
            this.Name = "BlobTracking";
            this.Text = "Blob Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.captureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox captureImage;
        private System.Windows.Forms.Button captureButton;
        private Emgu.CV.UI.ImageBox maskImage;
        private System.Windows.Forms.NumericUpDown thresholdValue;
        private System.Windows.Forms.Label label1;
    }
}

