using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace ColorTrack
{
    public partial class ColorTrack : Form
    {

        private Capture _capture = null;
        private bool _running;
        private Bgr picked;
        bool bPicked = false;
        private Image<Bgr, Byte> originalImage;
        private Image<Bgr, Byte> maskImage;

        public ColorTrack()
        {
            InitializeComponent();
            try
            {
                _capture = new Capture(-1);
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            maskImage = _capture.RetrieveBgrFrame();
        }

        private void ProcessFrame(Object sender, EventArgs args)
        {
            originalImage = _capture.RetrieveBgrFrame();
            

            if (bPicked)
            {
                maskImage = Distance(originalImage, 35);
                
            }
           

            captureImage.Image = originalImage;
            treatedImage.Image = maskImage;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                _capture.Start();
                dimensions.Text = _capture.Width.ToString() + "x" + _capture.Height.ToString() + "px";
            }
            else
            {
                _capture.Pause();
            }
            _running = !_running;
        }

        private void captureImage_MouseMove(object sender, MouseEventArgs e)
        {
            xpos.Text = e.X.ToString();
            ypos.Text = e.Y.ToString();
            
            
           
        }

        private void captureImage_MouseClick(object sender, MouseEventArgs e)
        {
            picked = originalImage[e.Y, e.X];
            maskImage = originalImage.Clone();
            pickedValue.Text = picked.Blue.ToString() + "|" + picked.Green.ToString() + "|" + picked.Red.ToString();
            bPicked = true;

        }

        private void threshold(int min, int max, Image<Bgr, Byte> img)
        {
            Image<Gray,Byte> channelRed = img.Split()[2];
            for (int i = 0; i < img.Height; i++)
                for (int j = 0; j < img.Width; j++)
                    if (channelRed[i, j].Intensity < min || channelRed[i, j].Intensity > max)
                        img[i, j] = new Bgr(0, 0, 0);
         }
        
        private Image<Bgr,Byte> Distance(Image<Bgr, Byte> img, double thresh)
        {
            Image<Bgr, Byte> resultImage = img.Clone();
            resultImage = resultImage.Resize(0.5, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR); // Scales 50% to reduce processing time
            resultImage._Erode(2);
            resultImage._Dilate(2);


            for ( int i=0; i<resultImage.Height; i++ )
                for (int j = 0; j < resultImage.Width; j++)
                {
                    Bgr point = resultImage[i,j];
                    double distB = Math.Abs(picked.Blue - point.Blue);
                    double distG = Math.Abs(picked.Green - point.Green);
                    double distR = Math.Abs(picked.Red - point.Red);
                    double dist = Math.Sqrt(Math.Pow(Math.Sqrt(Math.Pow(distB,2) + Math.Pow(distG,2)),2) + Math.Pow(distR,2));
                    if (dist > thresh) resultImage[i, j] = new Bgr(0, 0, 0);

                }
            return resultImage;
        }


    }
}
