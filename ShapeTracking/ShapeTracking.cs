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
        private List<Triangle2DF> triangles;
        private List<LineSegment2DF> bases;

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

            // Find triangles
            triangles = FindShapes(_detectionImage);

            // Find each triangle base
            bases = FindBases(triangles);
            
            // Draw informations
            DrawShapes(_originalImage, triangles, bases);
            
            // Display
            captureBox.Image = _originalImage;
            detectBox.Image = _detectionImage;
   
        }

        private List<LineSegment2DF> FindBases(List<Triangle2DF> triangles)
        {
            // Gather triangles bases
            List<LineSegment2DF> bases = new List<LineSegment2DF>();

            // For each triangle find the base segment (has the lowest Y values)
            foreach (Triangle2DF triangle in triangles)
            {
                // Get all vertices
                List<PointF> vertices = new List<PointF>(triangle.GetVertices().AsEnumerable());
                // Order vertices by Y value (ascending) (0,0) is upper left corner
                vertices = vertices.OrderBy(vertex => vertex.Y).ToList();
                // remove the point with the lowest Y value
                vertices.RemoveAt(0);
                // Re-order based on X axis to prevent base point switching
                vertices = vertices.OrderByDescending(vertex => vertex.X).ToList();
                // Define the base segment
                LineSegment2DF b = new LineSegment2DF(vertices[0],vertices[1]);
                bases.Add(b);
            }
            return bases;
        }

        private List<Triangle2DF> FindShapes(Image<Gray, Byte> img)
        {
            // Gather triangles
            List<Triangle2DF> triangleList = new List<Triangle2DF>();
            MemStorage stor = new MemStorage();

            // Cycle through all contours found
            for (Contour<Point> contours = img.FindContours(CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, RETR_TYPE.CV_RETR_TREE, stor); contours != null; contours = contours.HNext)
            {
                Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, stor);

                // Area value based selection
                if (currentContour.Area > 400 && currentContour.Area < 4000 )
                {
                    // if contour has 3 vertices, it's a triangle
                    if (currentContour.Total == 3) //The contour has 3 vertices, it is a triangle
                    {
                        Point[] pts = currentContour.ToArray();
                        triangleList.Add(new Triangle2DF(pts[0], pts[1], pts[2]));
                    }
                }
            }
            return triangleList;
        }

        private void DrawShapes(Image<Bgr, Byte> img, List<Triangle2DF> triangles, List<LineSegment2DF> bases)
        {
            foreach (LineSegment2DF b in bases)
            {
                // Draw base segment
                img.Draw(b, new Bgr(Color.Red), 2);
                // Draw cross at base point
                Cross2DF basePoint = new Cross2DF(b.P1,10,10);
                img.Draw(basePoint, new Bgr(Color.DarkMagenta), 2);
                // Add text indicating (X,Y) Angle
                MCvFont f = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_PLAIN, 1.0, 1.0);
                double angle = Math.Round(Math.Atan(b.Direction.Y / b.Direction.X)*360/(Math.PI*2),2);
                string baseText = "(" + b.P1.X.ToString() + "," + b.P1.Y.ToString() + ")" + " " + angle.ToString();
                img.Draw(baseText, ref f, new Point((int)b.P1.X, (int)b.P1.Y), new Bgr(255,255, 255));
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
