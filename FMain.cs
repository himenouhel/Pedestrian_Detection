using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Imaging;
using AForge.Vision.Motion;

using Emgu.CV;                  //
using Emgu.CV.CvEnum;           // usual Emgu Cv imports
using Emgu.CV.Structure;        //
using Emgu.CV.UI;               //

using System.Windows.Media;


namespace PIF6004_ProjetSession_DSP_ET
{
    public partial class FMain : Form
    {
        FilterInfoCollection fic;
        VideoCaptureDevice device;
        MotionDetector motiondetector;
        Timer timerVideo;
        Bitmap bitmapPlayed;
        bool needUpdate = false;
        bool needUpdateCamera = false;
        Timer timerCamera;

        public FMain()
        {
            InitializeComponent();

            motiondetector = new MotionDetector(new TwoFramesDifferenceDetector(), new MotionAreaHighlighting());
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo item in fic)
            {
                cbDevices.Items.Add(item.Name);
            }
            if (cbDevices.Items.Count > 0)
            {
                cbDevices.SelectedIndex = 0;
            }
            else
            {
                btnCaptureVideoStart.Enabled = false;
                btnArreterCapture.Enabled = false;
            }

            timerVideo = new Timer();
            timerVideo.Stop();
            timerVideo.Interval = 1000;
            timerVideo.Tick += timerVideo_tick;

            timerCamera = new Timer();
            timerCamera.Stop();
            timerCamera.Interval = 1000;
            timerCamera.Tick += timerCamera_tick;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult drChosenFile;

            OpenFileDialog ofd = new OpenFileDialog();

            drChosenFile = ofd.ShowDialog();

            if (drChosenFile != DialogResult.OK || ofd.FileName == "")
            {
                lblChosenFile.Text = "file not chosen";
                return;
            }
            else
            {
                lblChosenFile.Text = ofd.FileName;
            }

            Mat imgOriginal;

            try
            {
                imgOriginal = new Mat(ofd.FileName, LoadImageType.Color);
            }
            catch (Exception ex)
            {
                lblChosenFile.Text = "unable to open image, error: " + ex.Message;
                return;
            }

            if (imgOriginal == null)
            {
                lblChosenFile.Text = "unable to open image";
                return;
            }

            Mat imgGrayscale = new Mat(imgOriginal.Size, DepthType.Cv8U, 1);
            Mat imgBlurred = new Mat(imgOriginal.Size, DepthType.Cv8U, 1);
            Mat imgCanny = new Mat(imgOriginal.Size, DepthType.Cv8U, 1);

            CvInvoke.CvtColor(imgOriginal, imgGrayscale, ColorConversion.Bgr2Gray);

            CvInvoke.GaussianBlur(imgGrayscale, imgBlurred, new Size(5, 5), 1.5);

            CvInvoke.Canny(imgBlurred, imgCanny, 100, 200);

            ibOriginal.Image = imgOriginal;
            ibCanny.Image = imgCanny;

            ProcessImageAndUpdateGUI();
        }

        private void ProcessImageAndUpdateGUI()
        {
            Image<Bgr, Byte> imgImage = new Image<Bgr, Byte>(lblChosenFile.Text);
            //Image<Bgr, Byte> imgBlank = null;
            HOGDescriptor hogd = new HOGDescriptor();
            MCvObjectDetection[] mObj;
            //ibDetectionPietonImage.Image = imgBlank;
            Application.DoEvents();

            hogd.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
            mObj = hogd.DetectMultiScale(imgImage);

            foreach(MCvObjectDetection obj in mObj)
            {
                imgImage.Draw(obj.Rect, new Bgr(System.Drawing.Color.Yellow), 2);    
            }

            ibDetectionPietonImage.Image = imgImage;


        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void axPlayerVideo_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            /*object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) {
                if (e.newState == 8)
                {
                    this.wmedia.currentPlaylist.clear();
                    this.showFini = true;
                }*/
        }

        private void btnOuvrirVideo_Click(object sender, EventArgs e)
        {
            DialogResult drChosenFile;

            OpenFileDialog ofd = new OpenFileDialog();

            drChosenFile = ofd.ShowDialog();

            if (drChosenFile != DialogResult.OK || ofd.FileName == "")
            {
                lblPathVideo.Text = "file not chosen";
                return;
            }
            else
            {
                FileVideoSource videoSource = new FileVideoSource(ofd.FileName);
                videoSource.NewFrame += new AForge.Video.NewFrameEventHandler(video_NewFrame);
                lblPathVideo.Text = ofd.FileName;
                videoSourcePlayerVideo.VideoSource = videoSource;
                videoSource.Start();
                
                timerVideo.Start();
            }   
        }

        // New frame event handler, which is invoked on each new available video frame
        private void video_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            // get new frame
            bitmapPlayed = eventArgs.Frame;
            if (needUpdate)
            {
                needUpdate = false;
                Image<Bgr, Byte> img = null;
                if (bitmapPlayed != null)
                {
                    img = new Image<Bgr, Byte>(bitmapPlayed);

                    Image<Bgr, Byte> imgBlank = null;
                    HOGDescriptor hogd = new HOGDescriptor();
                    MCvObjectDetection[] mObj;
                    ibVideoPieton.Image = imgBlank;
                    Application.DoEvents();

                    hogd.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
                    mObj = hogd.DetectMultiScale(img);
                    
                    

                    foreach (MCvObjectDetection obj in mObj)
                    {
                        img.Draw(obj.Rect, new Bgr(System.Drawing.Color.Yellow), 2);
                    }

                    

                    ibVideoPieton.Image = img;
                }
                
            }


            //motiondetector.ProcessFrame(eventArgs.Frame);


            // process the frame
        }

        private void timerVideo_tick(object sender, EventArgs e)
        {
            needUpdate = true;

        }

        private void timerCamera_tick(object sender, EventArgs e)
        {
            needUpdateCamera = true;

        }

        private void lireFrame()
        {
        
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpInner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCaptureVideoStart_Click(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(fic[cbDevices.SelectedIndex].MonikerString);
            videoSourcePlayerCamera.VideoSource = device;
            videoSourcePlayerCamera.Start();
            timerCamera.Start();
        }

        private void btnArreterCapture_Click(object sender, EventArgs e)
        {
            timerCamera.Stop();
            videoSourcePlayerCamera.Stop();
        }

        private void videoSourcePlayerCamera_NewFrame(object sender, ref Bitmap image)
        {
            // get new frame
            if (needUpdateCamera)
            {
                needUpdateCamera = false;
                Image<Bgr, Byte> img = null;
                if (image != null)
                {
                    img = new Image<Bgr, Byte>(image);

                    //Image<Bgr, Byte> imgBlank = null;
                    HOGDescriptor hogd = new HOGDescriptor();
                    MCvObjectDetection[] mObj;
                    //ibVideoPieton.Image = imgBlank;
                    Application.DoEvents();

                    hogd.SetSVMDetector(HOGDescriptor.GetDefaultPeopleDetector());
                    mObj = hogd.DetectMultiScale(img, 0, new Size(4,4), new Size(8,8), 1.05);
                    
                    //mObj = hogd.DetectMultiScale(img);

                    foreach (MCvObjectDetection obj in mObj)
                    {
                        img.Draw(obj.Rect, new Bgr(System.Drawing.Color.Yellow), 2);
                    }



                    ibCameraDetection.Image = img;
                }

            }

            //motiondetector.ProcessFrame(image);
        }

        private void FMain_Leave(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void axPlayerVideo_StatusChange(object sender, EventArgs e)
        {
        }

        private void axPlayerVideo_PositionChange_1(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {

        }

        private void axPlayerVideo_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                timerVideo.Stop();
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
