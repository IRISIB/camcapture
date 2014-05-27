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

namespace ShapeTracking
{
    public partial class ShapeTracking : Form
    {

        private bool _captureRunning = false;               // Used to sets captureButton text
        private Capture _capture = null;                    // Capture object
        private Image<Bgr, Byte> _originalImage = null;     // Image directly grabed from camera
        private Image<Gray, Byte> _detectionImage = null;
        private Contour<Point> contours;

        public ShapeTracking()
        {
            InitializeComponent();

            try
            {
                _capture = new Capture(0);                  // Initialize camera capture
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
            _detectionImage = _originalImage.Convert<Gray, Byte>();

            PrepareImage();
            DrawShapes(_originalImage, FindShapes(_detectionImage));


            // Display
            captureBox.Image = _originalImage;
            detectBox.Image = _detectionImage;

           
        }

        private List<Triangle2DF> FindShapes(Image<Gray, Byte> img)
        {
            List<Triangle2DF> triangleList = new List<Triangle2DF>();
            MemStorage stor = new MemStorage();
            //Contour<Point> allcontours = img.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, RETR_TYPE.CV_RETR_TREE, stor);
            for (Contour<Point> contours = img.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, RETR_TYPE.CV_RETR_TREE, stor); contours != null; contours = contours.HNext)
            {
                Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, stor);

                if (currentContour.Area > 400 && currentContour.Area < 4000 )
                {
                    if (currentContour.Total == 3) //The contour has 3 vertices, it is a triangle
                    {
                        Point[] pts = currentContour.ToArray();
                        triangleList.Add(new Triangle2DF(pts[0], pts[1], pts[2]));
                    }
                }
            }
            return triangleList;
        }

        private void DrawShapes(Image<Bgr, Byte> img, List<Triangle2DF> triangles)
        {
            foreach (Triangle2DF triangle in triangles)
            {
                img.Draw(triangle, new Bgr(Color.Red), 2);
                MCvFont f = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_PLAIN, 0.8, 0.8);
                img.Draw(triangle.Area.ToString(), ref f, new Point((int)triangle.Centeroid.X,(int)triangle.Centeroid.Y), new Bgr(255, 255, 0));
            }
        }

        private void PrepareImage()
        {
            _detectionImage._SmoothGaussian(5);
            _detectionImage = _detectionImage.Canny((double)threshValue.Value,(double)threshLinkValue.Value);
            _detectionImage._Dilate(1);
            _detectionImage._Erode(1);
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
