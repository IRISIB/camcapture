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
        private Hsv hsvPicked;
        bool bPicked = false;
        private Image<Bgr, Byte> originalImage;
        private Image<Bgr, Byte> maskImage;
        private Image<Hsv, Byte> hsvMaskImage;

        public ColorTrack()
        {
            InitializeComponent();
            try
            {
                _capture = new Capture(0);

                _capture.ImageGrabbed += ProcessFrame;
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show("Error: "+ excpt.Message);
            }
            originalImage = _capture.RetrieveBgrFrame();
            maskImage = _capture.RetrieveBgrFrame();
        }

        private void ProcessFrame(Object sender, EventArgs args)
        {
            originalImage = _capture.RetrieveBgrFrame();
            

            if (bPicked)
            {
                if (distanceMethod.Checked)
                {
                    maskImage = Distance(originalImage, 35);
                    captureImage.Image = originalImage;
                    treatedImage.Image = maskImage;
                }
                else if (geometryMethod.Checked)
                {
                    hsvMaskImage = Track(originalImage,(int)toleranceValue.Value);
                    captureImage.Image = hsvMaskImage;
                }
            }
                    
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
            hsvPicked = originalImage.Convert<Hsv,byte>()[e.Y,e.X];
            maskImage = originalImage.Clone();
            pickedValue.Text = picked.Blue.ToString() + "|" + picked.Green.ToString() + "|" + picked.Red.ToString();
            bPicked = true;
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

        private Image<Hsv, Byte> Track(Image<Bgr, Byte> img, int tolerance)
        {
            Image<Hsv, Byte> resultImage = img.Convert<Hsv,Byte>();
            Image<Gray, Byte> mask = new Image<Gray, Byte>(resultImage.Width, resultImage.Height);
            CvInvoke.cvInRangeS(resultImage,new MCvScalar(hsvPicked.Hue - tolerance -1, hsvPicked.Satuation - tolerance, 0), new MCvScalar(hsvPicked.Hue + tolerance -1, hsvPicked.Satuation + tolerance,255),mask);
            IntPtr _ptr = CvInvoke.cvCreateStructuringElementEx(4,4,0,0,Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_ELLIPSE,mask);
            CvInvoke.cvErode(mask, mask, _ptr, 2);
            CvInvoke.cvDilate(mask, mask, _ptr, 2);
            treatedImage.Image = mask;

            try
            {
                Contour<Point> countour = mask.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_LINK_RUNS,Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST);
                Rectangle rect = countour.BoundingRectangle;
                Cross2DF cross = new Cross2DF(new Point((int)(rect.X+rect.Width/2),(int)(rect.Y+rect.Height/2)),5,5);
                resultImage.Draw(cross, new Hsv(180, 255, 255), 1);
                resultImage.Draw(rect, new Hsv(180, 127, 255), 2);
            }
            catch
            {

            }
          
            //treatedImage.Image = mask;
            return resultImage;
        }






    }
}
