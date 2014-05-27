namespace ShapeTracking
{
    partial class ShapeTracking
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
            this.captureBox = new Emgu.CV.UI.ImageBox();
            this.detectBox = new Emgu.CV.UI.ImageBox();
            this.captureButton = new System.Windows.Forms.Button();
            this.threshValue = new System.Windows.Forms.NumericUpDown();
            this.threshLinkValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cannyParams = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshLinkValue)).BeginInit();
            this.cannyParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // captureBox
            // 
            this.captureBox.Location = new System.Drawing.Point(12, 12);
            this.captureBox.Name = "captureBox";
            this.captureBox.Size = new System.Drawing.Size(640, 480);
            this.captureBox.TabIndex = 2;
            this.captureBox.TabStop = false;
            // 
            // detectBox
            // 
            this.detectBox.Location = new System.Drawing.Point(663, 12);
            this.detectBox.Name = "detectBox";
            this.detectBox.Size = new System.Drawing.Size(640, 480);
            this.detectBox.TabIndex = 3;
            this.detectBox.TabStop = false;
            // 
            // captureButton
            // 
            this.captureButton.Location = new System.Drawing.Point(12, 498);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(100, 100);
            this.captureButton.TabIndex = 4;
            this.captureButton.Text = "Start Capture";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // threshValue
            // 
            this.threshValue.Location = new System.Drawing.Point(129, 27);
            this.threshValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.threshValue.Name = "threshValue";
            this.threshValue.Size = new System.Drawing.Size(65, 20);
            this.threshValue.TabIndex = 5;
            this.threshValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.threshValue.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // threshLinkValue
            // 
            this.threshLinkValue.Location = new System.Drawing.Point(129, 68);
            this.threshLinkValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.threshLinkValue.Name = "threshLinkValue";
            this.threshLinkValue.Size = new System.Drawing.Size(65, 20);
            this.threshLinkValue.TabIndex = 6;
            this.threshLinkValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.threshLinkValue.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Threshold:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cannyParams
            // 
            this.cannyParams.Controls.Add(this.label2);
            this.cannyParams.Controls.Add(this.label1);
            this.cannyParams.Controls.Add(this.threshLinkValue);
            this.cannyParams.Controls.Add(this.threshValue);
            this.cannyParams.Location = new System.Drawing.Point(119, 498);
            this.cannyParams.Name = "cannyParams";
            this.cannyParams.Size = new System.Drawing.Size(200, 100);
            this.cannyParams.TabIndex = 8;
            this.cannyParams.TabStop = false;
            this.cannyParams.Text = "Canny Parameters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Threshold Linking:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShapeTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 608);
            this.Controls.Add(this.cannyParams);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.detectBox);
            this.Controls.Add(this.captureBox);
            this.Name = "ShapeTracking";
            this.Text = "Shape Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.captureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threshLinkValue)).EndInit();
            this.cannyParams.ResumeLayout(false);
            this.cannyParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox captureBox;
        private Emgu.CV.UI.ImageBox detectBox;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.NumericUpDown threshValue;
        private System.Windows.Forms.NumericUpDown threshLinkValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox cannyParams;
        private System.Windows.Forms.Label label2;
    }
}

