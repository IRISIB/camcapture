using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// EMGU Needed libraries
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;

namespace BlobTracking
{
    public partial class BlobTracking : Form
    {

        private bool _captureRunning = false;               // Used to sets captureButton text
        private Capture _capture = null;                    // Capture object
        private Image<Bgr, Byte> _originalImage = null;     // Image directly grabed from camera

        public BlobTracking()
        {
            InitializeComponent();
            try
            {
                _capture = new Capture(0);                 // Initialize camera capture
                _capture.ImageGrabbed += ProcessFrame;      // Image treatement when grabbed
                
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            _originalImage = _capture.RetrieveBgrFrame();
            Image<Gray, Byte> _detectImage = _originalImage.Convert<Gray, Byte>();                  // Converts image to GrayScale
            _detectImage = _detectImage.ThresholdBinary(new Gray(250), new Gray(255));              // Binary Threshold to keep only high values (near white)
            _detectImage = _detectImage.Canny(new Gray(255).Intensity, new Gray(255).Intensity);    // Border tracing
            _detectImage = _detectImage.Dilate(2).Erode(2);                                         // Smooth for cleaner contours detection


            MemStorage stor = new MemStorage();
            Contour<Point> contours = _detectImage.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, RETR_TYPE.CV_RETR_TREE, stor);  // Detect contours

            Bgr bgrRed = new Bgr(Color.Red);
            while (contours != null)
            {
                // For each contour detected, draw a box and a cross at its center
                if (contours.BoundingRectangle.Width > 10 && contours.BoundingRectangle.Height > 10)
                {
                    Rectangle rect = contours.BoundingRectangle;
                    PointF baryCenter = new PointF(rect.X + rect.Width / 2, rect.Y + rect.Height / 2);
                    Cross2DF cross = new Cross2DF(baryCenter,5,5);
                    _originalImage.Draw(cross, bgrRed, 1);
                    _originalImage.Draw(rect, bgrRed, 2);
                }

                contours = contours.HNext;
            }


            maskImage.Image = _detectImage;
            captureImage.Image = _originalImage;
        }


        private void captureButton_Click(object sender, EventArgs e)
        {
            if (_captureRunning)
            {
                _capture.Stop();
                captureButton.Text = "Start Capture";
            }
            else
            {
                _capture.Start();
                captureButton.Text = "Stop Capture";
            }
            _captureRunning = !_captureRunning;
        }









  
    }
}
