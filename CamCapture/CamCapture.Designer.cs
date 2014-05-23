namespace Camcaputure
{
    partial class CamCapture
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
            this.imgBox = new Emgu.CV.UI.ImageBox();
            this.captureBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.captureInfos = new System.Windows.Forms.Label();
            this.maskBox = new Emgu.CV.UI.ImageBox();
            this.blobBox = new Emgu.CV.UI.ImageBox();
            this.bThreshBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.gThreshBar = new System.Windows.Forms.TrackBar();
            this.rThreshBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bTval = new System.Windows.Forms.Label();
            this.gTval = new System.Windows.Forms.Label();
            this.rTval = new System.Windows.Forms.Label();
            this.bMaxBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.bMval = new System.Windows.Forms.Label();
            this.gMval = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gMaxBar = new System.Windows.Forms.TrackBar();
            this.rMval = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rMaxBar = new System.Windows.Forms.TrackBar();
            this.smoothBox = new System.Windows.Forms.CheckBox();
            this.threshBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blobBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bThreshBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gThreshBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rThreshBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMaxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMaxBar)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox
            // 
            this.imgBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imgBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imgBox.Location = new System.Drawing.Point(12, 41);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(640, 480);
            this.imgBox.TabIndex = 2;
            this.imgBox.TabStop = false;
            // 
            // captureBtn
            // 
            this.captureBtn.Location = new System.Drawing.Point(12, 12);
            this.captureBtn.Name = "captureBtn";
            this.captureBtn.Size = new System.Drawing.Size(75, 23);
            this.captureBtn.TabIndex = 3;
            this.captureBtn.Text = "Start/Stop";
            this.captureBtn.UseVisualStyleBackColor = true;
            this.captureBtn.Click += new System.EventHandler(this.captureBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width/Height:";
            // 
            // captureInfos
            // 
            this.captureInfos.AutoSize = true;
            this.captureInfos.Location = new System.Drawing.Point(173, 17);
            this.captureInfos.Name = "captureInfos";
            this.captureInfos.Size = new System.Drawing.Size(10, 13);
            this.captureInfos.TabIndex = 5;
            this.captureInfos.Text = "-";
            this.captureInfos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maskBox
            // 
            this.maskBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.maskBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.maskBox.Location = new System.Drawing.Point(662, 41);
            this.maskBox.Name = "maskBox";
            this.maskBox.Size = new System.Drawing.Size(640, 480);
            this.maskBox.TabIndex = 6;
            this.maskBox.TabStop = false;
            // 
            // blobBox
            // 
            this.blobBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.blobBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.blobBox.Location = new System.Drawing.Point(662, 527);
            this.blobBox.Name = "blobBox";
            this.blobBox.Size = new System.Drawing.Size(640, 480);
            this.blobBox.TabIndex = 7;
            this.blobBox.TabStop = false;
            // 
            // bThreshBar
            // 
            this.bThreshBar.Location = new System.Drawing.Point(96, 527);
            this.bThreshBar.Maximum = 255;
            this.bThreshBar.Name = "bThreshBar";
            this.bThreshBar.Size = new System.Drawing.Size(300, 45);
            this.bThreshBar.TabIndex = 8;
            this.bThreshBar.Scroll += new System.EventHandler(this.bThreshBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 527);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Blue Threshold";
            // 
            // gThreshBar
            // 
            this.gThreshBar.Location = new System.Drawing.Point(96, 578);
            this.gThreshBar.Maximum = 255;
            this.gThreshBar.Name = "gThreshBar";
            this.gThreshBar.Size = new System.Drawing.Size(300, 45);
            this.gThreshBar.TabIndex = 10;
            this.gThreshBar.Scroll += new System.EventHandler(this.gThreshBar_Scroll);
            // 
            // rThreshBar
            // 
            this.rThreshBar.Location = new System.Drawing.Point(96, 629);
            this.rThreshBar.Maximum = 255;
            this.rThreshBar.Name = "rThreshBar";
            this.rThreshBar.Size = new System.Drawing.Size(300, 45);
            this.rThreshBar.TabIndex = 11;
            this.rThreshBar.Scroll += new System.EventHandler(this.rThreshBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 578);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Green Threshold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 629);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Red Threshold";
            // 
            // bTval
            // 
            this.bTval.AutoSize = true;
            this.bTval.Location = new System.Drawing.Point(403, 528);
            this.bTval.Name = "bTval";
            this.bTval.Size = new System.Drawing.Size(35, 13);
            this.bTval.TabIndex = 14;
            this.bTval.Text = "label5";
            // 
            // gTval
            // 
            this.gTval.AutoSize = true;
            this.gTval.Location = new System.Drawing.Point(402, 578);
            this.gTval.Name = "gTval";
            this.gTval.Size = new System.Drawing.Size(35, 13);
            this.gTval.TabIndex = 15;
            this.gTval.Text = "label5";
            // 
            // rTval
            // 
            this.rTval.AutoSize = true;
            this.rTval.Location = new System.Drawing.Point(402, 629);
            this.rTval.Name = "rTval";
            this.rTval.Size = new System.Drawing.Size(35, 13);
            this.rTval.TabIndex = 16;
            this.rTval.Text = "label5";
            // 
            // bMaxBar
            // 
            this.bMaxBar.Location = new System.Drawing.Point(96, 680);
            this.bMaxBar.Maximum = 255;
            this.bMaxBar.Name = "bMaxBar";
            this.bMaxBar.Size = new System.Drawing.Size(300, 45);
            this.bMaxBar.TabIndex = 17;
            this.bMaxBar.Scroll += new System.EventHandler(this.bMaxBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 680);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Blue Max Val";
            // 
            // bMval
            // 
            this.bMval.AutoSize = true;
            this.bMval.Location = new System.Drawing.Point(403, 680);
            this.bMval.Name = "bMval";
            this.bMval.Size = new System.Drawing.Size(35, 13);
            this.bMval.TabIndex = 19;
            this.bMval.Text = "label5";
            // 
            // gMval
            // 
            this.gMval.AutoSize = true;
            this.gMval.Location = new System.Drawing.Point(403, 731);
            this.gMval.Name = "gMval";
            this.gMval.Size = new System.Drawing.Size(35, 13);
            this.gMval.TabIndex = 22;
            this.gMval.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 731);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Green Max Val";
            // 
            // gMaxBar
            // 
            this.gMaxBar.Location = new System.Drawing.Point(96, 731);
            this.gMaxBar.Maximum = 255;
            this.gMaxBar.Name = "gMaxBar";
            this.gMaxBar.Size = new System.Drawing.Size(300, 45);
            this.gMaxBar.TabIndex = 20;
            this.gMaxBar.Scroll += new System.EventHandler(this.gMaxBar_Scroll);
            // 
            // rMval
            // 
            this.rMval.AutoSize = true;
            this.rMval.Location = new System.Drawing.Point(403, 782);
            this.rMval.Name = "rMval";
            this.rMval.Size = new System.Drawing.Size(35, 13);
            this.rMval.TabIndex = 25;
            this.rMval.Text = "label5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 782);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Red Max Val";
            // 
            // rMaxBar
            // 
            this.rMaxBar.Location = new System.Drawing.Point(96, 782);
            this.rMaxBar.Maximum = 255;
            this.rMaxBar.Name = "rMaxBar";
            this.rMaxBar.Size = new System.Drawing.Size(300, 45);
            this.rMaxBar.TabIndex = 23;
            this.rMaxBar.Scroll += new System.EventHandler(this.rMaxBar_Scroll);
            // 
            // smoothBox
            // 
            this.smoothBox.AutoSize = true;
            this.smoothBox.Location = new System.Drawing.Point(499, 551);
            this.smoothBox.Name = "smoothBox";
            this.smoothBox.Size = new System.Drawing.Size(109, 17);
            this.smoothBox.TabIndex = 26;
            this.smoothBox.Text = "Gaussian Smooth";
            this.smoothBox.UseVisualStyleBackColor = true;
            this.smoothBox.CheckedChanged += new System.EventHandler(this.smoothBox_CheckedChanged);
            // 
            // threshBox
            // 
            this.threshBox.AutoSize = true;
            this.threshBox.Location = new System.Drawing.Point(499, 528);
            this.threshBox.Name = "threshBox";
            this.threshBox.Size = new System.Drawing.Size(73, 17);
            this.threshBox.TabIndex = 27;
            this.threshBox.Text = "Threshold";
            this.threshBox.UseVisualStyleBackColor = true;
            this.threshBox.CheckedChanged += new System.EventHandler(this.threshBox_CheckedChanged);
            // 
            // CamCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 1022);
            this.Controls.Add(this.threshBox);
            this.Controls.Add(this.smoothBox);
            this.Controls.Add(this.rMval);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rMaxBar);
            this.Controls.Add(this.gMval);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gMaxBar);
            this.Controls.Add(this.bMval);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bMaxBar);
            this.Controls.Add(this.rTval);
            this.Controls.Add(this.gTval);
            this.Controls.Add(this.bTval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rThreshBar);
            this.Controls.Add(this.gThreshBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bThreshBar);
            this.Controls.Add(this.blobBox);
            this.Controls.Add(this.maskBox);
            this.Controls.Add(this.captureInfos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captureBtn);
            this.Controls.Add(this.imgBox);
            this.Name = "CamCapture";
            this.Text = "CamCapture";
            this.Load += new System.EventHandler(this.CamCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maskBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blobBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bThreshBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gThreshBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rThreshBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMaxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gMaxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMaxBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBox;
        private System.Windows.Forms.Button captureBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label captureInfos;
        private Emgu.CV.UI.ImageBox maskBox;
        private Emgu.CV.UI.ImageBox blobBox;
        private System.Windows.Forms.TrackBar bThreshBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar gThreshBar;
        private System.Windows.Forms.TrackBar rThreshBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label bTval;
        private System.Windows.Forms.Label gTval;
        private System.Windows.Forms.Label rTval;
        private System.Windows.Forms.TrackBar bMaxBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bMval;
        private System.Windows.Forms.Label gMval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar gMaxBar;
        private System.Windows.Forms.Label rMval;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar rMaxBar;
        private System.Windows.Forms.CheckBox smoothBox;
        private System.Windows.Forms.CheckBox threshBox;
    }
}

