using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// EMGU
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
//using Emgu.CV.Structure;
using Emgu.CV.VideoSurveillance;

namespace Camcaputure
{
    public partial class CamCapture : Form
    {
        private Capture _capture = null;
        private bool _captureInProgress;
        private Int32 captureWidth = 0;
        private Int32 captureHeight = 0;
        private static BlobTrackerAuto<Bgr> _tracker;
        private static FGDetector<Bgr> _detector;

        private int bThresh = 127;
        private int gThresh = 127;
        private int rThresh = 127;
        private int bMax = 255;
        private int gMax = 255;
        private int rMax = 255;

        private int smooth = 3;
        private bool smoothActive = false;

        private bool threshActive = false;

        private bool noisefilterActive = false;

        public CamCapture()
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
            BlobTrackerAutoParam<Bgr> param = new BlobTrackerAutoParam<Bgr>();
            param.FGTrainFrames = 5;
            _detector = new FGDetector<Bgr>(FORGROUND_DETECTOR_TYPE.MOG);
            param.FGDetector = _detector;
            _tracker = new BlobTrackerAuto<Bgr>(param);

      }

      private void ProcessFrame(object sender, EventArgs arg)
      {
          Image<Bgr, Byte> origframe = _capture.RetrieveBgrFrame();
          Image<Bgr, Byte> frame = origframe.Copy();
          if (threshActive)
          {
              frame = frame.ThresholdBinary(new Bgr(bThresh, gThresh, rThresh), new Bgr(bMax, gMax, rMax));
          }
          if (smoothActive)
          {
              frame = frame.SmoothGaussian(smooth);
              
          }
          if (noisefilterActive)
          {
              frame = frame.PyrUp().PyrDown();
          }

         _detector.Update(frame);
         Image<Gray, Byte> forgroundMask = _detector.ForegroundMask;

         _tracker.Process(frame, forgroundMask);

         foreach (MCvBlob blob in _tracker)
         {
             
             origframe.Draw((Rectangle)blob, new Bgr(255.0, 255.0, 255.0), 2);
         }

         imgBox.Image = frame;
         maskBox.Image = forgroundMask;
         blobBox.Image = origframe;
       

      }

      private void CamCapture_Load(object sender, EventArgs e)
      {
          bThreshBar.Value = bThresh;
          gThreshBar.Value = gThresh;
          rThreshBar.Value = rThresh;

          smoothBox.Checked = smoothActive;
          threshBox.Checked = threshActive;

          bMaxBar.Value = bMax;
          gMaxBar.Value = gMax;
          rMaxBar.Value = rMax;
          bMval.Text = bMax.ToString();
          gMval.Text = gMax.ToString();
          rMval.Text = rMax.ToString();
          bTval.Text = bThresh.ToString();
          gTval.Text = gThresh.ToString();
          rTval.Text = rThresh.ToString();

      }

      private void captureBtn_Click(object sender, EventArgs e)
      {
          if (_capture != null)
          {
              if (_captureInProgress)
              {  //stop the capture
                  _capture.Pause();
                  captureInfos.Text = "-";
              }
              else
              {
                  //start the capture
                  _capture.Start();
                  captureWidth = _capture.Width;
                  captureHeight = _capture.Height;
                  captureInfos.Text = captureWidth.ToString() + "x" + captureHeight.ToString() + "px";
              }

              _captureInProgress = !_captureInProgress;
          }
      }

      private void bThreshBar_Scroll(object sender, EventArgs e)
      {
          bThresh = bThreshBar.Value;
          bTval.Text = bThresh.ToString();
      }

      private void gThreshBar_Scroll(object sender, EventArgs e)
      {
          gThresh = gThreshBar.Value;
          gTval.Text = gThresh.ToString();
      }

      private void rThreshBar_Scroll(object sender, EventArgs e)
      {
          rThresh = rThreshBar.Value;
          rTval.Text = rThresh.ToString();
      }

      private void bMaxBar_Scroll(object sender, EventArgs e)
      {
          bMax = bMaxBar.Value;
          bMval.Text = bMax.ToString();
      }

      private void gMaxBar_Scroll(object sender, EventArgs e)
      {
          gMax = gMaxBar.Value;
          gMval.Text = gMax.ToString();
      }

      private void rMaxBar_Scroll(object sender, EventArgs e)
      {
          rMax = rMaxBar.Value;
          rMval.Text = rMax.ToString();
      }

      private void smoothBox_CheckedChanged(object sender, EventArgs e)
      {
          smoothActive = smoothBox.Checked;
      }

      private void threshBox_CheckedChanged(object sender, EventArgs e)
      {
          threshActive = threshBox.Checked;
      }




    }
}
