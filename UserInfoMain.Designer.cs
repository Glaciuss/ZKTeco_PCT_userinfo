namespace UserInfo
{
    partial class UserInfoMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tab1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lvDownload = new System.Windows.Forms.ListView();
            this.ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uploadSQL = new System.Windows.Forms.Button();
            this.addDemo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpload9 = new System.Windows.Forms.Button();
            this.btnDownloadTmp = new System.Windows.Forms.Button();
            this.btnBatchUpdate = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lvFace = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.cbUserID3 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnGetUserFace = new System.Windows.Forms.Button();
            this.btnDelUserFace = new System.Windows.Forms.Button();
            this.btnDownLoadFace = new System.Windows.Forms.Button();
            this.btnUploadFace = new System.Windows.Forms.Button();
            this.Tab3 = new System.Windows.Forms.TabPage();
            this.lbRTShow = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.cbUserIDDE = new System.Windows.Forms.ComboBox();
            this.btnDeleteEnrollData = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.cbBackupDE = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSSR_DelUserTmpExt = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFingerIndex = new System.Windows.Forms.ComboBox();
            this.cbUserIDTmp = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearAdministrators = new System.Windows.Forms.Button();
            this.btnClearDataTmps = new System.Windows.Forms.Button();
            this.btnClearDataUserInfo = new System.Windows.Forms.Button();
            this.UserIDTimer = new System.Windows.Forms.Timer(this.components);
            this.lblState = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rtTimer = new System.Windows.Forms.Timer(this.components);
            this.btnDownloadFace_SQL = new System.Windows.Forms.Button();
            this.btnUploadFace_SQL = new System.Windows.Forms.Button();
            this.tab1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.Tab3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tabPage4);
            this.tab1.Controls.Add(this.tabPage5);
            this.tab1.Controls.Add(this.Tab3);
            this.tab1.Controls.Add(this.tabPage1);
            this.tab1.Location = new System.Drawing.Point(475, 39);
            this.tab1.Name = "tab1";
            this.tab1.SelectedIndex = 0;
            this.tab1.Size = new System.Drawing.Size(496, 418);
            this.tab1.TabIndex = 89;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lvDownload);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(488, 392);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Fingerprint Tmps";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lvDownload
            // 
            this.lvDownload.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2,
            this.ch3,
            this.ch4,
            this.ch5,
            this.ch6,
            this.ch7,
            this.ch8});
            this.lvDownload.GridLines = true;
            this.lvDownload.HideSelection = false;
            this.lvDownload.Location = new System.Drawing.Point(11, 11);
            this.lvDownload.Name = "lvDownload";
            this.lvDownload.Size = new System.Drawing.Size(466, 262);
            this.lvDownload.TabIndex = 10;
            this.lvDownload.UseCompatibleStateImageBehavior = false;
            this.lvDownload.View = System.Windows.Forms.View.Details;
            // 
            // ch1
            // 
            this.ch1.Text = "UserID";
            this.ch1.Width = 54;
            // 
            // ch2
            // 
            this.ch2.Text = "Name";
            this.ch2.Width = 51;
            // 
            // ch3
            // 
            this.ch3.Text = "FingerIndex";
            this.ch3.Width = 71;
            // 
            // ch4
            // 
            this.ch4.Text = "tmpData";
            this.ch4.Width = 65;
            // 
            // ch5
            // 
            this.ch5.Text = "Privilege";
            this.ch5.Width = 77;
            // 
            // ch6
            // 
            this.ch6.Text = "Password";
            this.ch6.Width = 40;
            // 
            // ch7
            // 
            this.ch7.Text = "Enabled";
            this.ch7.Width = 68;
            // 
            // ch8
            // 
            this.ch8.Text = "Flag";
            this.ch8.Width = 40;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uploadSQL);
            this.groupBox4.Controls.Add(this.addDemo);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnUpload9);
            this.groupBox4.Controls.Add(this.btnDownloadTmp);
            this.groupBox4.Controls.Add(this.btnBatchUpdate);
            this.groupBox4.Location = new System.Drawing.Point(12, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(467, 103);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fingerprint Templates of 9.0&&10.0 Arithmetic";
            // 
            // uploadSQL
            // 
            this.uploadSQL.Location = new System.Drawing.Point(370, 48);
            this.uploadSQL.Name = "uploadSQL";
            this.uploadSQL.Size = new System.Drawing.Size(91, 23);
            this.uploadSQL.TabIndex = 78;
            this.uploadSQL.Text = "UploadTo(SQL)";
            this.uploadSQL.UseVisualStyleBackColor = true;
            this.uploadSQL.Click += new System.EventHandler(this.uploadSQL_Click);
            // 
            // addDemo
            // 
            this.addDemo.Location = new System.Drawing.Point(346, 19);
            this.addDemo.Name = "addDemo";
            this.addDemo.Size = new System.Drawing.Size(115, 23);
            this.addDemo.TabIndex = 77;
            this.addDemo.Text = "DownloadFrom(SQL)";
            this.addDemo.UseVisualStyleBackColor = true;
            this.addDemo.Click += new System.EventHandler(this.addDemo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(149, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(201, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Upload Fingerprint Templates one by one";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Crimson;
            this.label8.Location = new System.Drawing.Point(148, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "Upload Fingerprint Templates in batches.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(113, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "Download Fingerprint Templates one by one.";
            // 
            // btnUpload9
            // 
            this.btnUpload9.Location = new System.Drawing.Point(7, 72);
            this.btnUpload9.Name = "btnUpload9";
            this.btnUpload9.Size = new System.Drawing.Size(134, 23);
            this.btnUpload9.TabIndex = 73;
            this.btnUpload9.Text = "UploadFPTmp(common)";
            this.btnUpload9.UseVisualStyleBackColor = true;
            this.btnUpload9.Click += new System.EventHandler(this.btnUploadTmp_Click);
            // 
            // btnDownloadTmp
            // 
            this.btnDownloadTmp.Location = new System.Drawing.Point(7, 20);
            this.btnDownloadTmp.Name = "btnDownloadTmp";
            this.btnDownloadTmp.Size = new System.Drawing.Size(94, 23);
            this.btnDownloadTmp.TabIndex = 2;
            this.btnDownloadTmp.Text = "DownloadFPTmp";
            this.btnDownloadTmp.UseVisualStyleBackColor = true;
            this.btnDownloadTmp.Click += new System.EventHandler(this.btnDownloadTmp_Click);
            // 
            // btnBatchUpdate
            // 
            this.btnBatchUpdate.Location = new System.Drawing.Point(7, 46);
            this.btnBatchUpdate.Name = "btnBatchUpdate";
            this.btnBatchUpdate.Size = new System.Drawing.Size(134, 23);
            this.btnBatchUpdate.TabIndex = 5;
            this.btnBatchUpdate.Text = "UploadFPTmp(batch)";
            this.btnBatchUpdate.UseVisualStyleBackColor = true;
            this.btnBatchUpdate.Click += new System.EventHandler(this.btnBatchUpdate_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnUploadFace_SQL);
            this.tabPage5.Controls.Add(this.btnDownloadFace_SQL);
            this.tabPage5.Controls.Add(this.lvFace);
            this.tabPage5.Controls.Add(this.groupBox11);
            this.tabPage5.Controls.Add(this.btnDownLoadFace);
            this.tabPage5.Controls.Add(this.btnUploadFace);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(488, 392);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Face Tmps";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lvFace
            // 
            this.lvFace.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.lvFace.GridLines = true;
            this.lvFace.HideSelection = false;
            this.lvFace.Location = new System.Drawing.Point(8, 8);
            this.lvFace.Name = "lvFace";
            this.lvFace.Size = new System.Drawing.Size(467, 242);
            this.lvFace.TabIndex = 68;
            this.lvFace.UseCompatibleStateImageBehavior = false;
            this.lvFace.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "UserID";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Name";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Password";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Privilege";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "FaceIndex";
            this.columnHeader11.Width = 42;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "TmpData";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Length";
            this.columnHeader13.Width = 40;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Enabled";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.cbUserID3);
            this.groupBox11.Controls.Add(this.label26);
            this.groupBox11.Controls.Add(this.btnGetUserFace);
            this.groupBox11.Controls.Add(this.btnDelUserFace);
            this.groupBox11.Location = new System.Drawing.Point(8, 319);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(467, 58);
            this.groupBox11.TabIndex = 71;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Get or Delete Binary Face Templates";
            // 
            // cbUserID3
            // 
            this.cbUserID3.FormattingEnabled = true;
            this.cbUserID3.Location = new System.Drawing.Point(77, 23);
            this.cbUserID3.Name = "cbUserID3";
            this.cbUserID3.Size = new System.Drawing.Size(100, 21);
            this.cbUserID3.TabIndex = 10;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(30, 27);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 13);
            this.label26.TabIndex = 4;
            this.label26.Text = "UserID";
            // 
            // btnGetUserFace
            // 
            this.btnGetUserFace.Location = new System.Drawing.Point(330, 22);
            this.btnGetUserFace.Name = "btnGetUserFace";
            this.btnGetUserFace.Size = new System.Drawing.Size(106, 23);
            this.btnGetUserFace.TabIndex = 3;
            this.btnGetUserFace.Text = "GetUserFace";
            this.btnGetUserFace.UseVisualStyleBackColor = true;
            this.btnGetUserFace.Click += new System.EventHandler(this.btnGetUserFace_Click);
            // 
            // btnDelUserFace
            // 
            this.btnDelUserFace.Location = new System.Drawing.Point(201, 22);
            this.btnDelUserFace.Name = "btnDelUserFace";
            this.btnDelUserFace.Size = new System.Drawing.Size(97, 23);
            this.btnDelUserFace.TabIndex = 9;
            this.btnDelUserFace.Text = "DelUserFace";
            this.btnDelUserFace.UseVisualStyleBackColor = true;
            this.btnDelUserFace.Click += new System.EventHandler(this.btnDelUserFace_Click);
            // 
            // btnDownLoadFace
            // 
            this.btnDownLoadFace.Location = new System.Drawing.Point(8, 256);
            this.btnDownLoadFace.Name = "btnDownLoadFace";
            this.btnDownLoadFace.Size = new System.Drawing.Size(142, 23);
            this.btnDownLoadFace.TabIndex = 70;
            this.btnDownLoadFace.Text = "DownLoadFace (machine)";
            this.btnDownLoadFace.UseVisualStyleBackColor = true;
            this.btnDownLoadFace.Click += new System.EventHandler(this.btnDownLoadFace_Click);
            // 
            // btnUploadFace
            // 
            this.btnUploadFace.Location = new System.Drawing.Point(8, 285);
            this.btnUploadFace.Name = "btnUploadFace";
            this.btnUploadFace.Size = new System.Drawing.Size(130, 23);
            this.btnUploadFace.TabIndex = 69;
            this.btnUploadFace.Text = "UploadFace (machine)";
            this.btnUploadFace.UseVisualStyleBackColor = true;
            this.btnUploadFace.Click += new System.EventHandler(this.btnUploadFace_Click);
            // 
            // Tab3
            // 
            this.Tab3.Controls.Add(this.lbRTShow);
            this.Tab3.Location = new System.Drawing.Point(4, 22);
            this.Tab3.Name = "Tab3";
            this.Tab3.Padding = new System.Windows.Forms.Padding(3);
            this.Tab3.Size = new System.Drawing.Size(488, 392);
            this.Tab3.TabIndex = 2;
            this.Tab3.Text = "RTEvents";
            this.Tab3.UseVisualStyleBackColor = true;
            // 
            // lbRTShow
            // 
            this.lbRTShow.FormattingEnabled = true;
            this.lbRTShow.Location = new System.Drawing.Point(6, 6);
            this.lbRTShow.Name = "lbRTShow";
            this.lbRTShow.Size = new System.Drawing.Size(445, 277);
            this.lbRTShow.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 392);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Setting Time";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox7);
            this.groupBox5.Controls.Add(this.groupBox1);
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Location = new System.Drawing.Point(8, 177);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(461, 280);
            this.groupBox5.TabIndex = 88;
            this.groupBox5.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.label25);
            this.groupBox7.Controls.Add(this.cbUserIDDE);
            this.groupBox7.Controls.Add(this.btnDeleteEnrollData);
            this.groupBox7.Controls.Add(this.label24);
            this.groupBox7.Controls.Add(this.cbBackupDE);
            this.groupBox7.Location = new System.Drawing.Point(7, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(444, 88);
            this.groupBox7.TabIndex = 78;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Delete Enrolled Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(9, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(241, 13);
            this.label14.TabIndex = 76;
            this.label14.Text = "Delete enrolled data according to bakcupnumber.";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 13);
            this.label25.TabIndex = 18;
            this.label25.Text = "UserID";
            // 
            // cbUserIDDE
            // 
            this.cbUserIDDE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserIDDE.FormattingEnabled = true;
            this.cbUserIDDE.Location = new System.Drawing.Point(58, 52);
            this.cbUserIDDE.Name = "cbUserIDDE";
            this.cbUserIDDE.Size = new System.Drawing.Size(61, 21);
            this.cbUserIDDE.TabIndex = 16;
            // 
            // btnDeleteEnrollData
            // 
            this.btnDeleteEnrollData.Location = new System.Drawing.Point(279, 51);
            this.btnDeleteEnrollData.Name = "btnDeleteEnrollData";
            this.btnDeleteEnrollData.Size = new System.Drawing.Size(141, 23);
            this.btnDeleteEnrollData.TabIndex = 15;
            this.btnDeleteEnrollData.Text = "SSR_DeleteEnrollData";
            this.btnDeleteEnrollData.UseVisualStyleBackColor = true;
            this.btnDeleteEnrollData.Click += new System.EventHandler(this.btnDeleteEnrollData_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(127, 56);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "BackupNumber";
            // 
            // cbBackupDE
            // 
            this.cbBackupDE.FormattingEnabled = true;
            this.cbBackupDE.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbBackupDE.Location = new System.Drawing.Point(208, 52);
            this.cbBackupDE.Name = "cbBackupDE";
            this.cbBackupDE.Size = new System.Drawing.Size(48, 21);
            this.cbBackupDE.TabIndex = 17;
            this.cbBackupDE.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnSSR_DelUserTmpExt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbFingerIndex);
            this.groupBox1.Controls.Add(this.cbUserIDTmp);
            this.groupBox1.Location = new System.Drawing.Point(7, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 80);
            this.groupBox1.TabIndex = 77;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Delete User\'s Fingerprint Templates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "UserID";
            // 
            // btnSSR_DelUserTmpExt
            // 
            this.btnSSR_DelUserTmpExt.Location = new System.Drawing.Point(279, 33);
            this.btnSSR_DelUserTmpExt.Name = "btnSSR_DelUserTmpExt";
            this.btnSSR_DelUserTmpExt.Size = new System.Drawing.Size(115, 23);
            this.btnSSR_DelUserTmpExt.TabIndex = 33;
            this.btnSSR_DelUserTmpExt.Text = "SSR_DelUserTmpExt";
            this.btnSSR_DelUserTmpExt.UseVisualStyleBackColor = true;
            this.btnSSR_DelUserTmpExt.Click += new System.EventHandler(this.btnSSR_DelUserTmpExt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "FingerIndex";
            // 
            // cbFingerIndex
            // 
            this.cbFingerIndex.FormattingEnabled = true;
            this.cbFingerIndex.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "13"});
            this.cbFingerIndex.Location = new System.Drawing.Point(208, 34);
            this.cbFingerIndex.Name = "cbFingerIndex";
            this.cbFingerIndex.Size = new System.Drawing.Size(48, 21);
            this.cbFingerIndex.TabIndex = 29;
            // 
            // cbUserIDTmp
            // 
            this.cbUserIDTmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserIDTmp.Location = new System.Drawing.Point(58, 34);
            this.cbUserIDTmp.Name = "cbUserIDTmp";
            this.cbUserIDTmp.Size = new System.Drawing.Size(61, 21);
            this.cbUserIDTmp.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClearAdministrators);
            this.groupBox3.Controls.Add(this.btnClearDataTmps);
            this.groupBox3.Controls.Add(this.btnClearDataUserInfo);
            this.groupBox3.Location = new System.Drawing.Point(7, 207);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(443, 64);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clear Templates/UsersInfo/Administrator Privilege";
            // 
            // btnClearAdministrators
            // 
            this.btnClearAdministrators.Location = new System.Drawing.Point(279, 24);
            this.btnClearAdministrators.Name = "btnClearAdministrators";
            this.btnClearAdministrators.Size = new System.Drawing.Size(131, 23);
            this.btnClearAdministrators.TabIndex = 72;
            this.btnClearAdministrators.Text = "ClearAdministrators";
            this.btnClearAdministrators.UseVisualStyleBackColor = true;
            this.btnClearAdministrators.Click += new System.EventHandler(this.btnClearAdministrators_Click);
            // 
            // btnClearDataTmps
            // 
            this.btnClearDataTmps.Location = new System.Drawing.Point(10, 24);
            this.btnClearDataTmps.Name = "btnClearDataTmps";
            this.btnClearDataTmps.Size = new System.Drawing.Size(99, 23);
            this.btnClearDataTmps.TabIndex = 64;
            this.btnClearDataTmps.Text = "ClearTmpsData";
            this.btnClearDataTmps.UseVisualStyleBackColor = true;
            this.btnClearDataTmps.Click += new System.EventHandler(this.btnClearDataTmps_Click);
            // 
            // btnClearDataUserInfo
            // 
            this.btnClearDataUserInfo.Location = new System.Drawing.Point(135, 24);
            this.btnClearDataUserInfo.Name = "btnClearDataUserInfo";
            this.btnClearDataUserInfo.Size = new System.Drawing.Size(121, 23);
            this.btnClearDataUserInfo.TabIndex = 63;
            this.btnClearDataUserInfo.Text = "ClearUserInfoData";
            this.btnClearDataUserInfo.UseVisualStyleBackColor = true;
            this.btnClearDataUserInfo.Click += new System.EventHandler(this.btnClearDataUserInfo_Click);
            // 
            // UserIDTimer
            // 
            this.UserIDTimer.Enabled = true;
            this.UserIDTimer.Tick += new System.EventHandler(this.UserIDTimer_Tick);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.Color.Crimson;
            this.lblState.Location = new System.Drawing.Point(150, 125);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(138, 13);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "Current State:Disconnected";
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Location = new System.Drawing.Point(6, 20);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(449, 102);
            this.tabControl3.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.txtPort);
            this.tabPage3.Controls.Add(this.txtIP);
            this.tabPage3.Controls.Add(this.btnConnect);
            this.tabPage3.ForeColor = System.Drawing.Color.DarkBlue;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(441, 76);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "TCP/IP";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(257, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(87, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "IP";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(300, 11);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(53, 20);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "4370";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(118, 11);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(95, 20);
            this.txtIP.TabIndex = 6;
            this.txtIP.Text = "192.168.88.11";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(181, 42);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(78, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl3);
            this.groupBox2.Controls.Add(this.lblState);
            this.groupBox2.Location = new System.Drawing.Point(8, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 146);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication with Device";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInfo.Properties.Resources.top;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(981, 30);
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // rtTimer
            // 
            this.rtTimer.Enabled = true;
            this.rtTimer.Interval = 5000;
            this.rtTimer.Tick += new System.EventHandler(this.rtTimer_Tick);
            // 
            // btnDownloadFace_SQL
            // 
            this.btnDownloadFace_SQL.Location = new System.Drawing.Point(333, 256);
            this.btnDownloadFace_SQL.Name = "btnDownloadFace_SQL";
            this.btnDownloadFace_SQL.Size = new System.Drawing.Size(142, 23);
            this.btnDownloadFace_SQL.TabIndex = 72;
            this.btnDownloadFace_SQL.Text = "DownLoadFace (SQL)";
            this.btnDownloadFace_SQL.UseVisualStyleBackColor = true;
            this.btnDownloadFace_SQL.Click += new System.EventHandler(this.btnDownloadFace_SQL_Click);
            // 
            // btnUploadFace_SQL
            // 
            this.btnUploadFace_SQL.Location = new System.Drawing.Point(345, 285);
            this.btnUploadFace_SQL.Name = "btnUploadFace_SQL";
            this.btnUploadFace_SQL.Size = new System.Drawing.Size(130, 23);
            this.btnUploadFace_SQL.TabIndex = 73;
            this.btnUploadFace_SQL.Text = "UploadFace (SQL)";
            this.btnUploadFace_SQL.UseVisualStyleBackColor = true;
            this.btnUploadFace_SQL.Click += new System.EventHandler(this.btnUploadFace_SQL_Click);
            // 
            // UserInfoMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(979, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tab1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserInfoMain";
            this.Text = "UserInfo";
            this.tab1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.Tab3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tab1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvDownload;
        private System.Windows.Forms.ColumnHeader ch1;
        private System.Windows.Forms.ColumnHeader ch2;
        private System.Windows.Forms.ColumnHeader ch3;
        private System.Windows.Forms.ColumnHeader ch4;
        private System.Windows.Forms.ColumnHeader ch5;
        private System.Windows.Forms.ColumnHeader ch6;
        private System.Windows.Forms.ColumnHeader ch7;
        private System.Windows.Forms.ColumnHeader ch8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpload9;
        private System.Windows.Forms.Button btnDownloadTmp;
        private System.Windows.Forms.Button btnBatchUpdate;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListView lvFace;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox cbUserID3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnGetUserFace;
        private System.Windows.Forms.Button btnDelUserFace;
        private System.Windows.Forms.Button btnDownLoadFace;
        private System.Windows.Forms.Button btnUploadFace;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cbUserIDDE;
        private System.Windows.Forms.Button btnDeleteEnrollData;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbBackupDE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSSR_DelUserTmpExt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFingerIndex;
        private System.Windows.Forms.ComboBox cbUserIDTmp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClearAdministrators;
        private System.Windows.Forms.Button btnClearDataTmps;
        private System.Windows.Forms.Button btnClearDataUserInfo;
        private System.Windows.Forms.Timer UserIDTimer;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Tab3;
        private System.Windows.Forms.ListBox lbRTShow;
        private System.Windows.Forms.Timer rtTimer;
        private System.Windows.Forms.Button addDemo;
        private System.Windows.Forms.Button uploadSQL;
        private System.Windows.Forms.Button btnDownloadFace_SQL;
        private System.Windows.Forms.Button btnUploadFace_SQL;
    }
}

