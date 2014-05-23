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
            this.captureImage = new Emgu.CV.UI.ImageBox();
            this.treatedImage = new Emgu.CV.UI.ImageBox();
            this.startButton = new System.Windows.Forms.Button();
            this.dimensions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xpos = new System.Windows.Forms.Label();
            this.ypos = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.pickedValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.captureImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // captureImage
            // 
            this.captureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.captureImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.captureImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.captureImage.Location = new System.Drawing.Point(0, 0);
            this.captureImage.Margin = new System.Windows.Forms.Padding(6);
            this.captureImage.Name = "captureImage";
            this.captureImage.Size = new System.Drawing.Size(640, 480);
            this.captureImage.TabIndex = 2;
            this.captureImage.TabStop = false;
            this.captureImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.captureImage_MouseClick);
            this.captureImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.captureImage_MouseMove);
            // 
            // treatedImage
            // 
            this.treatedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treatedImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treatedImage.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.treatedImage.Location = new System.Drawing.Point(0, 0);
            this.treatedImage.Margin = new System.Windows.Forms.Padding(6);
            this.treatedImage.Name = "treatedImage";
            this.treatedImage.Size = new System.Drawing.Size(639, 480);
            this.treatedImage.TabIndex = 2;
            this.treatedImage.TabStop = false;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 501);
            this.startButton.Margin = new System.Windows.Forms.Padding(6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(194, 69);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start/Stop";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // dimensions
            // 
            this.dimensions.AutoSize = true;
            this.dimensions.Location = new System.Drawing.Point(275, 522);
            this.dimensions.Name = "dimensions";
            this.dimensions.Size = new System.Drawing.Size(19, 26);
            this.dimensions.TabIndex = 4;
            this.dimensions.Text = "-";
            this.dimensions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(648, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y:";
            // 
            // xpos
            // 
            this.xpos.AutoSize = true;
            this.xpos.Location = new System.Drawing.Point(687, 501);
            this.xpos.Name = "xpos";
            this.xpos.Size = new System.Drawing.Size(19, 26);
            this.xpos.TabIndex = 7;
            this.xpos.Text = "-";
            this.xpos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ypos
            // 
            this.ypos.AutoSize = true;
            this.ypos.Location = new System.Drawing.Point(687, 527);
            this.ypos.Name = "ypos";
            this.ypos.Size = new System.Drawing.Size(19, 26);
            this.ypos.TabIndex = 8;
            this.ypos.Text = "-";
            this.ypos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.captureImage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.treatedImage);
            this.splitContainer1.Size = new System.Drawing.Size(1280, 480);
            this.splitContainer1.SplitterDistance = 640;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(983, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Value:";
            // 
            // pickedValue
            // 
            this.pickedValue.AutoSize = true;
            this.pickedValue.Location = new System.Drawing.Point(1063, 528);
            this.pickedValue.Name = "pickedValue";
            this.pickedValue.Size = new System.Drawing.Size(19, 26);
            this.pickedValue.TabIndex = 11;
            this.pickedValue.Text = "-";
            // 
            // ColorTrack
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1374, 617);
            this.Controls.Add(this.pickedValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ypos);
            this.Controls.Add(this.xpos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dimensions);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ColorTrack";
            this.Text = "Color Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.captureImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treatedImage)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox captureImage;
        private Emgu.CV.UI.ImageBox treatedImage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label dimensions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xpos;
        private System.Windows.Forms.Label ypos;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pickedValue;
    }
}

