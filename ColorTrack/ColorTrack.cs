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
        private Gray picked;
        bool bPicked = false;
        private Image<Bgr, Byte> originalImage;
        private Image<Gray, Byte> intensityImage;
        private Image<Gray, Byte> maskImage;

        public ColorTrack()
        {
            InitializeComponent();
            try
            {
                _capture = new Capture(1);
                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
            intensityImage = _capture.RetrieveGrayFrame();
        }

        private void ProcessFrame(Object sender, EventArgs args)
        {
            originalImage = _capture.RetrieveBgrFrame();
            Image<Hsv, Byte> hsvframe = originalImage.Convert<Hsv, Byte>();
            Image<Gray, Byte>[] channels = hsvframe.Split();
            intensityImage = channels[2];
            maskImage = intensityImage.Clone();
            if (bPicked)
            {
                /*Image<Gray, Byte> tmpImage = maskImage.SmoothGaussian(5);
                pickedValue.Text = picked.Intensity.ToString();
                CircleF[] circles = tmpImage.HoughCircles(
                    new Gray(picked.Intensity),
                    new Gray(50),
                    2,
                    25,
                    20, 50)[0]

                foreach (CircleF cir in circles)
                {
                    originalImage.Draw(cir, new Bgr(Color.Red), 2);
                }*/

                threshold(60,80,originalImage);

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
            picked = intensityImage[e.Y, e.X];
            pickedValue.Text = picked.Intensity.ToString();
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


    }
}
