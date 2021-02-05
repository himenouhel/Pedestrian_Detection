namespace PIF6004_ProjetSession_DSP_ET
{
    partial class FMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.videoSourcePlayerVideo = new AForge.Controls.VideoSourcePlayer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOuvrirVideo = new System.Windows.Forms.Button();
            this.lblPathVideo = new System.Windows.Forms.Label();
            this.ibVideoPieton = new Emgu.CV.UI.ImageBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpOuter = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInner = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.lblChosenFile = new System.Windows.Forms.Label();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabImagePremierTraitement = new System.Windows.Forms.TabPage();
            this.ibCanny = new Emgu.CV.UI.ImageBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ibDetectionPietonImage = new Emgu.CV.UI.ImageBox();
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCaptureVideoStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.btnArreterCapture = new System.Windows.Forms.Button();
            this.ibCameraDetection = new Emgu.CV.UI.ImageBox();
            this.videoSourcePlayerCamera = new AForge.Controls.VideoSourcePlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibVideoPieton)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tlpOuter.SuspendLayout();
            this.tlpInner.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabImagePremierTraitement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibCanny)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibDetectionPietonImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibCameraDetection)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1057, 579);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vidéo";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.videoSourcePlayerVideo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ibVideoPieton, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1049, 571);
            this.tableLayoutPanel1.TabIndex = 4;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // videoSourcePlayerVideo
            // 
            this.videoSourcePlayerVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayerVideo.Location = new System.Drawing.Point(4, 63);
            this.videoSourcePlayerVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videoSourcePlayerVideo.Name = "videoSourcePlayerVideo";
            this.videoSourcePlayerVideo.Size = new System.Drawing.Size(516, 504);
            this.videoSourcePlayerVideo.TabIndex = 6;
            this.videoSourcePlayerVideo.Text = "videoSourcePlayer1";
            this.videoSourcePlayerVideo.VideoSource = null;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnOuvrirVideo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblPathVideo, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1041, 51);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnOuvrirVideo
            // 
            this.btnOuvrirVideo.AutoSize = true;
            this.btnOuvrirVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuvrirVideo.Location = new System.Drawing.Point(4, 4);
            this.btnOuvrirVideo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOuvrirVideo.Name = "btnOuvrirVideo";
            this.btnOuvrirVideo.Size = new System.Drawing.Size(173, 43);
            this.btnOuvrirVideo.TabIndex = 1;
            this.btnOuvrirVideo.Text = "Ouvrif fichier";
            this.btnOuvrirVideo.UseVisualStyleBackColor = true;
            this.btnOuvrirVideo.Click += new System.EventHandler(this.btnOuvrirVideo_Click);
            // 
            // lblPathVideo
            // 
            this.lblPathVideo.AutoSize = true;
            this.lblPathVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPathVideo.Location = new System.Drawing.Point(185, 0);
            this.lblPathVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPathVideo.Name = "lblPathVideo";
            this.lblPathVideo.Size = new System.Drawing.Size(852, 51);
            this.lblPathVideo.TabIndex = 2;
            this.lblPathVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ibVideoPieton
            // 
            this.ibVideoPieton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibVideoPieton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibVideoPieton.Enabled = false;
            this.ibVideoPieton.Location = new System.Drawing.Point(528, 63);
            this.ibVideoPieton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibVideoPieton.Name = "ibVideoPieton";
            this.ibVideoPieton.Size = new System.Drawing.Size(517, 504);
            this.ibVideoPieton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibVideoPieton.TabIndex = 4;
            this.ibVideoPieton.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlpOuter);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1057, 579);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Image";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpOuter
            // 
            this.tlpOuter.ColumnCount = 2;
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.80892F));
            this.tlpOuter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.19108F));
            this.tlpOuter.Controls.Add(this.tlpInner, 0, 0);
            this.tlpOuter.Controls.Add(this.tabControl2, 1, 1);
            this.tlpOuter.Controls.Add(this.ibOriginal, 0, 1);
            this.tlpOuter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpOuter.Location = new System.Drawing.Point(4, 4);
            this.tlpOuter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpOuter.Name = "tlpOuter";
            this.tlpOuter.RowCount = 2;
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpOuter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpOuter.Size = new System.Drawing.Size(1049, 571);
            this.tlpOuter.TabIndex = 3;
            // 
            // tlpInner
            // 
            this.tlpInner.AutoSize = true;
            this.tlpInner.ColumnCount = 2;
            this.tlpOuter.SetColumnSpan(this.tlpInner, 2);
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpInner.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInner.Controls.Add(this.button2, 0, 0);
            this.tlpInner.Controls.Add(this.lblChosenFile, 1, 0);
            this.tlpInner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInner.Location = new System.Drawing.Point(4, 4);
            this.tlpInner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tlpInner.Name = "tlpInner";
            this.tlpInner.RowCount = 1;
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInner.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpInner.Size = new System.Drawing.Size(1041, 51);
            this.tlpInner.TabIndex = 3;
            this.tlpInner.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpInner_Paint);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 43);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ouvrir Fichier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblChosenFile
            // 
            this.lblChosenFile.AutoSize = true;
            this.lblChosenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChosenFile.Location = new System.Drawing.Point(196, 0);
            this.lblChosenFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChosenFile.Name = "lblChosenFile";
            this.lblChosenFile.Size = new System.Drawing.Size(841, 51);
            this.lblChosenFile.TabIndex = 2;
            this.lblChosenFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabImagePremierTraitement);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(526, 63);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(519, 504);
            this.tabControl2.TabIndex = 4;
            // 
            // tabImagePremierTraitement
            // 
            this.tabImagePremierTraitement.Controls.Add(this.ibCanny);
            this.tabImagePremierTraitement.Location = new System.Drawing.Point(4, 34);
            this.tabImagePremierTraitement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabImagePremierTraitement.Name = "tabImagePremierTraitement";
            this.tabImagePremierTraitement.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabImagePremierTraitement.Size = new System.Drawing.Size(511, 466);
            this.tabImagePremierTraitement.TabIndex = 0;
            this.tabImagePremierTraitement.Text = "Premier traitement";
            this.tabImagePremierTraitement.UseVisualStyleBackColor = true;
            // 
            // ibCanny
            // 
            this.ibCanny.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibCanny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibCanny.Enabled = false;
            this.ibCanny.Location = new System.Drawing.Point(4, 4);
            this.ibCanny.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibCanny.Name = "ibCanny";
            this.ibCanny.Size = new System.Drawing.Size(503, 458);
            this.ibCanny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibCanny.TabIndex = 3;
            this.ibCanny.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ibDetectionPietonImage);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(509, 465);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Détection piéton";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ibDetectionPietonImage
            // 
            this.ibDetectionPietonImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibDetectionPietonImage.Location = new System.Drawing.Point(4, 4);
            this.ibDetectionPietonImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibDetectionPietonImage.Name = "ibDetectionPietonImage";
            this.ibDetectionPietonImage.Size = new System.Drawing.Size(501, 457);
            this.ibDetectionPietonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibDetectionPietonImage.TabIndex = 2;
            this.ibDetectionPietonImage.TabStop = false;
            // 
            // ibOriginal
            // 
            this.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibOriginal.Enabled = false;
            this.ibOriginal.Location = new System.Drawing.Point(4, 63);
            this.ibOriginal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(514, 504);
            this.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 617);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tableLayoutPanel3);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1057, 579);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Caméra";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ibCameraDetection, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.videoSourcePlayerCamera, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1057, 579);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel3.SetColumnSpan(this.tableLayoutPanel4, 2);
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnCaptureVideoStart, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbDevices, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnArreterCapture, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1049, 85);
            this.tableLayoutPanel4.TabIndex = 3;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // btnCaptureVideoStart
            // 
            this.btnCaptureVideoStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCaptureVideoStart.AutoSize = true;
            this.btnCaptureVideoStart.Location = new System.Drawing.Point(21, 45);
            this.btnCaptureVideoStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCaptureVideoStart.Name = "btnCaptureVideoStart";
            this.btnCaptureVideoStart.Size = new System.Drawing.Size(231, 36);
            this.btnCaptureVideoStart.TabIndex = 6;
            this.btnCaptureVideoStart.Text = "Démarrer capture";
            this.btnCaptureVideoStart.UseVisualStyleBackColor = true;
            this.btnCaptureVideoStart.Click += new System.EventHandler(this.btnCaptureVideoStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(260, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(785, 41);
            this.label1.TabIndex = 2;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbDevices
            // 
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(4, 4);
            this.cbDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(248, 33);
            this.cbDevices.TabIndex = 7;
            // 
            // btnArreterCapture
            // 
            this.btnArreterCapture.AutoSize = true;
            this.btnArreterCapture.Location = new System.Drawing.Point(260, 45);
            this.btnArreterCapture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnArreterCapture.Name = "btnArreterCapture";
            this.btnArreterCapture.Size = new System.Drawing.Size(201, 36);
            this.btnArreterCapture.TabIndex = 8;
            this.btnArreterCapture.Text = "Arrêter capture";
            this.btnArreterCapture.UseVisualStyleBackColor = true;
            this.btnArreterCapture.Click += new System.EventHandler(this.btnArreterCapture_Click);
            // 
            // ibCameraDetection
            // 
            this.ibCameraDetection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ibCameraDetection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibCameraDetection.Enabled = false;
            this.ibCameraDetection.Location = new System.Drawing.Point(532, 97);
            this.ibCameraDetection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ibCameraDetection.Name = "ibCameraDetection";
            this.ibCameraDetection.Size = new System.Drawing.Size(521, 478);
            this.ibCameraDetection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibCameraDetection.TabIndex = 4;
            this.ibCameraDetection.TabStop = false;
            // 
            // videoSourcePlayerCamera
            // 
            this.videoSourcePlayerCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoSourcePlayerCamera.Location = new System.Drawing.Point(4, 97);
            this.videoSourcePlayerCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videoSourcePlayerCamera.Name = "videoSourcePlayerCamera";
            this.videoSourcePlayerCamera.Size = new System.Drawing.Size(520, 478);
            this.videoSourcePlayerCamera.TabIndex = 5;
            this.videoSourcePlayerCamera.Text = "videoSourcePlayer1";
            this.videoSourcePlayerCamera.VideoSource = null;
            this.videoSourcePlayerCamera.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayerCamera_NewFrame);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 617);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PIF6004 - Détection de piéton par Daniel St-Pierre et Emmanuel Tshitoko";
            this.Leave += new System.EventHandler(this.FMain_Leave);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibVideoPieton)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tlpOuter.ResumeLayout(false);
            this.tlpOuter.PerformLayout();
            this.tlpInner.ResumeLayout(false);
            this.tlpInner.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabImagePremierTraitement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibCanny)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibDetectionPietonImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibCameraDetection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tlpOuter;
        private System.Windows.Forms.TableLayoutPanel tlpInner;
        private System.Windows.Forms.Label lblChosenFile;
        private Emgu.CV.UI.ImageBox ibOriginal;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabImagePremierTraitement;
        private Emgu.CV.UI.ImageBox ibCanny;
        private System.Windows.Forms.TabPage tabPage3;
        private Emgu.CV.UI.ImageBox ibDetectionPietonImage;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOuvrirVideo;
        private System.Windows.Forms.Label lblPathVideo;
        private Emgu.CV.UI.ImageBox ibVideoPieton;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private Emgu.CV.UI.ImageBox ibCameraDetection;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayerCamera;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCaptureVideoStart;
        private System.Windows.Forms.ComboBox cbDevices;
        private System.Windows.Forms.Button btnArreterCapture;
        private System.Windows.Forms.Timer timer1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayerVideo;
    }
}