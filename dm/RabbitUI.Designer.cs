namespace dm
{
    partial class RabbitUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RabbitUI));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Label7 = new System.Windows.Forms.Label();
            this.dirChooser = new System.Windows.Forms.LinkLabel();
            this.preSize = new System.Windows.Forms.Label();
            this.buttonQueryCompact = new System.Windows.Forms.Button();
            this.chosenDirDisplay = new System.Windows.Forms.Label();
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.compressX4 = new System.Windows.Forms.RadioButton();
            this.compressLZX = new System.Windows.Forms.RadioButton();
            this.compressX8 = new System.Windows.Forms.RadioButton();
            this.compressX16 = new System.Windows.Forms.RadioButton();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Label8 = new System.Windows.Forms.Label();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.checkForceCompression = new System.Windows.Forms.CheckBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.checkHiddenFiles = new System.Windows.Forms.CheckBox();
            this.checkRecursiveScan = new System.Windows.Forms.CheckBox();
            this.buttonCompress = new System.Windows.Forms.Button();
            this.compactprogressbar = new System.Windows.Forms.ProgressBar();
            this.progressPageLabel = new System.Windows.Forms.Label();
            this.returnArrow = new System.Windows.Forms.Label();
            this.progresspercent = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.compRatioLabel = new System.Windows.Forms.Label();
            this.PicShow = new System.Windows.Forms.PictureBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.checkShowConOut = new System.Windows.Forms.CheckBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.FlowLayoutPanel1.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(474, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FlowLayoutPanel1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.chosenDirDisplay);
            this.tabPage1.Controls.Add(this.buttonQueryCompact);
            this.tabPage1.Controls.Add(this.preSize);
            this.tabPage1.Controls.Add(this.dirChooser);
            this.tabPage1.Controls.Add(this.Label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(466, 572);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RabbitPage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LogTextBox);
            this.tabPage3.Controls.Add(this.checkShowConOut);
            this.tabPage3.Controls.Add(this.progresspercent);
            this.tabPage3.Controls.Add(this.returnArrow);
            this.tabPage3.Controls.Add(this.progressPageLabel);
            this.tabPage3.Controls.Add(this.compactprogressbar);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(466, 572);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "RabbitProgressPage";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Button1);
            this.tabPage2.Controls.Add(this.TextBox1);
            this.tabPage2.Controls.Add(this.PicShow);
            this.tabPage2.Controls.Add(this.compRatioLabel);
            this.tabPage2.Controls.Add(this.Label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(466, 572);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "RabbitAboutPage";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label7.Location = new System.Drawing.Point(16, 24);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(25, 18);
            this.Label7.TabIndex = 21;
            this.Label7.Text = "→ ";
            // 
            // dirChooser
            // 
            this.dirChooser.ActiveLinkColor = System.Drawing.Color.Red;
            this.dirChooser.AutoSize = true;
            this.dirChooser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dirChooser.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.dirChooser.Location = new System.Drawing.Point(43, 22);
            this.dirChooser.Name = "dirChooser";
            this.dirChooser.Size = new System.Drawing.Size(109, 21);
            this.dirChooser.TabIndex = 22;
            this.dirChooser.TabStop = true;
            this.dirChooser.Text = "Progress View";
            this.dirChooser.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            // 
            // preSize
            // 
            this.preSize.AutoSize = true;
            this.preSize.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.preSize.Location = new System.Drawing.Point(44, 92);
            this.preSize.Name = "preSize";
            this.preSize.Size = new System.Drawing.Size(55, 13);
            this.preSize.TabIndex = 24;
            this.preSize.Text = "(๑•̀ㅂ•́)و✧";
            this.preSize.Visible = false;
            // 
            // buttonQueryCompact
            // 
            this.buttonQueryCompact.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonQueryCompact.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonQueryCompact.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonQueryCompact.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQueryCompact.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonQueryCompact.Location = new System.Drawing.Point(274, 92);
            this.buttonQueryCompact.Name = "buttonQueryCompact";
            this.buttonQueryCompact.Size = new System.Drawing.Size(144, 25);
            this.buttonQueryCompact.TabIndex = 25;
            this.buttonQueryCompact.Text = "Multithreading";
            this.buttonQueryCompact.UseVisualStyleBackColor = false;
            this.buttonQueryCompact.Visible = false;
            // 
            // chosenDirDisplay
            // 
            this.chosenDirDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chosenDirDisplay.AutoEllipsis = true;
            this.chosenDirDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chosenDirDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chosenDirDisplay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chosenDirDisplay.Location = new System.Drawing.Point(44, 54);
            this.chosenDirDisplay.MaximumSize = new System.Drawing.Size(0, 25);
            this.chosenDirDisplay.MinimumSize = new System.Drawing.Size(374, 25);
            this.chosenDirDisplay.Name = "chosenDirDisplay";
            this.chosenDirDisplay.Padding = new System.Windows.Forms.Padding(5);
            this.chosenDirDisplay.Size = new System.Drawing.Size(374, 25);
            this.chosenDirDisplay.TabIndex = 26;
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowLayoutPanel1.AutoSize = true;
            this.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowLayoutPanel1.Controls.Add(this.Panel4);
            this.FlowLayoutPanel1.Controls.Add(this.Panel3);
            this.FlowLayoutPanel1.Controls.Add(this.buttonCompress);
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(19, 153);
            this.FlowLayoutPanel1.MaximumSize = new System.Drawing.Size(700, 0);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(423, 332);
            this.FlowLayoutPanel1.TabIndex = 27;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.Label2);
            this.Panel4.Controls.Add(this.Label6);
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.Label3);
            this.Panel4.Controls.Add(this.compressX4);
            this.Panel4.Controls.Add(this.compressLZX);
            this.Panel4.Controls.Add(this.compressX8);
            this.Panel4.Controls.Add(this.compressX16);
            this.Panel4.Location = new System.Drawing.Point(3, 3);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(262, 126);
            this.Panel4.TabIndex = 24;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label2.ForeColor = System.Drawing.Color.DimGray;
            this.Label2.Location = new System.Drawing.Point(20, 5);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(214, 21);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Select OnmyojiGame Method";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.ForeColor = System.Drawing.Color.DimGray;
            this.Label6.Location = new System.Drawing.Point(141, 104);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(89, 12);
            this.Label6.TabIndex = 19;
            this.Label6.Text = "（ 殴打兔子 ）";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.ForeColor = System.Drawing.Color.DimGray;
            this.Label5.Location = new System.Drawing.Point(141, 83);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(89, 12);
            this.Label5.TabIndex = 19;
            this.Label5.Text = "（ 殴打兔子 ）";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.ForeColor = System.Drawing.Color.DimGray;
            this.Label4.Location = new System.Drawing.Point(141, 60);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(89, 12);
            this.Label4.TabIndex = 19;
            this.Label4.Text = "（ 殴打兔子 ）";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.ForeColor = System.Drawing.Color.DimGray;
            this.Label3.Location = new System.Drawing.Point(141, 39);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(89, 12);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "（ 殴打兔子 ）";
            // 
            // compressX4
            // 
            this.compressX4.AutoSize = true;
            this.compressX4.ForeColor = System.Drawing.Color.DimGray;
            this.compressX4.Location = new System.Drawing.Point(35, 37);
            this.compressX4.Name = "compressX4";
            this.compressX4.Size = new System.Drawing.Size(101, 16);
            this.compressX4.TabIndex = 9;
            this.compressX4.Text = "Beat the hare";
            this.compressX4.UseVisualStyleBackColor = true;
            // 
            // compressLZX
            // 
            this.compressLZX.AutoSize = true;
            this.compressLZX.ForeColor = System.Drawing.Color.DimGray;
            this.compressLZX.Location = new System.Drawing.Point(35, 102);
            this.compressLZX.Name = "compressLZX";
            this.compressLZX.Size = new System.Drawing.Size(101, 16);
            this.compressLZX.TabIndex = 12;
            this.compressLZX.Text = "Beat the hare";
            this.compressLZX.UseVisualStyleBackColor = true;
            // 
            // compressX8
            // 
            this.compressX8.AutoSize = true;
            this.compressX8.Checked = true;
            this.compressX8.ForeColor = System.Drawing.Color.DimGray;
            this.compressX8.Location = new System.Drawing.Point(35, 58);
            this.compressX8.Name = "compressX8";
            this.compressX8.Size = new System.Drawing.Size(101, 16);
            this.compressX8.TabIndex = 10;
            this.compressX8.TabStop = true;
            this.compressX8.Text = "Beat the hare";
            this.compressX8.UseVisualStyleBackColor = true;
            // 
            // compressX16
            // 
            this.compressX16.AutoSize = true;
            this.compressX16.ForeColor = System.Drawing.Color.DimGray;
            this.compressX16.Location = new System.Drawing.Point(35, 79);
            this.compressX16.Name = "compressX16";
            this.compressX16.Size = new System.Drawing.Size(101, 16);
            this.compressX16.TabIndex = 11;
            this.compressX16.Text = "Beat the hare";
            this.compressX16.UseVisualStyleBackColor = true;
            // 
            // Panel3
            // 
            this.Panel3.Controls.Add(this.Label8);
            this.Panel3.Controls.Add(this.CheckBox1);
            this.Panel3.Controls.Add(this.checkForceCompression);
            this.Panel3.Controls.Add(this.Label14);
            this.Panel3.Controls.Add(this.checkHiddenFiles);
            this.Panel3.Controls.Add(this.checkRecursiveScan);
            this.Panel3.Location = new System.Drawing.Point(3, 135);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(417, 138);
            this.Panel3.TabIndex = 23;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Label8.ForeColor = System.Drawing.Color.DimGray;
            this.Label8.Location = new System.Drawing.Point(20, 10);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(207, 21);
            this.Label8.TabIndex = 18;
            this.Label8.Text = "Select Additional Arguments";
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Enabled = false;
            this.CheckBox1.ForeColor = System.Drawing.Color.DimGray;
            this.CheckBox1.Location = new System.Drawing.Point(35, 108);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(102, 16);
            this.CheckBox1.TabIndex = 17;
            this.CheckBox1.Text = "Beat the hare";
            this.CheckBox1.UseVisualStyleBackColor = true;
            // 
            // checkForceCompression
            // 
            this.checkForceCompression.AutoSize = true;
            this.checkForceCompression.ForeColor = System.Drawing.Color.DimGray;
            this.checkForceCompression.Location = new System.Drawing.Point(35, 66);
            this.checkForceCompression.Name = "checkForceCompression";
            this.checkForceCompression.Size = new System.Drawing.Size(102, 16);
            this.checkForceCompression.TabIndex = 7;
            this.checkForceCompression.Text = "Beat the hare";
            this.checkForceCompression.UseVisualStyleBackColor = true;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Label14.Location = new System.Drawing.Point(140, 64);
            this.Label14.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(22, 17);
            this.Label14.TabIndex = 32;
            this.Label14.Text = "(?)";
            // 
            // checkHiddenFiles
            // 
            this.checkHiddenFiles.AutoSize = true;
            this.checkHiddenFiles.ForeColor = System.Drawing.Color.DimGray;
            this.checkHiddenFiles.Location = new System.Drawing.Point(35, 87);
            this.checkHiddenFiles.Name = "checkHiddenFiles";
            this.checkHiddenFiles.Size = new System.Drawing.Size(102, 16);
            this.checkHiddenFiles.TabIndex = 6;
            this.checkHiddenFiles.Text = "Beat the hare";
            this.checkHiddenFiles.UseVisualStyleBackColor = true;
            // 
            // checkRecursiveScan
            // 
            this.checkRecursiveScan.AutoSize = true;
            this.checkRecursiveScan.Checked = true;
            this.checkRecursiveScan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRecursiveScan.ForeColor = System.Drawing.Color.DimGray;
            this.checkRecursiveScan.Location = new System.Drawing.Point(35, 44);
            this.checkRecursiveScan.Name = "checkRecursiveScan";
            this.checkRecursiveScan.Size = new System.Drawing.Size(102, 16);
            this.checkRecursiveScan.TabIndex = 5;
            this.checkRecursiveScan.Text = "Beat the hare";
            this.checkRecursiveScan.UseVisualStyleBackColor = true;
            // 
            // buttonCompress
            // 
            this.buttonCompress.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCompress.Enabled = false;
            this.buttonCompress.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCompress.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompress.ForeColor = System.Drawing.Color.DarkGray;
            this.buttonCompress.Location = new System.Drawing.Point(8, 279);
            this.buttonCompress.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            this.buttonCompress.Name = "buttonCompress";
            this.buttonCompress.Size = new System.Drawing.Size(390, 50);
            this.buttonCompress.TabIndex = 3;
            this.buttonCompress.Text = "Start";
            this.buttonCompress.UseVisualStyleBackColor = false;
            // 
            // compactprogressbar
            // 
            this.compactprogressbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.compactprogressbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.compactprogressbar.Location = new System.Drawing.Point(40, 66);
            this.compactprogressbar.MaximumSize = new System.Drawing.Size(374, 25);
            this.compactprogressbar.Name = "compactprogressbar";
            this.compactprogressbar.Size = new System.Drawing.Size(374, 25);
            this.compactprogressbar.Step = 2;
            this.compactprogressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.compactprogressbar.TabIndex = 25;
            // 
            // progressPageLabel
            // 
            this.progressPageLabel.AutoSize = true;
            this.progressPageLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressPageLabel.ForeColor = System.Drawing.Color.DimGray;
            this.progressPageLabel.Location = new System.Drawing.Point(36, 28);
            this.progressPageLabel.Name = "progressPageLabel";
            this.progressPageLabel.Size = new System.Drawing.Size(222, 21);
            this.progressPageLabel.TabIndex = 31;
            this.progressPageLabel.Text = "Progress, execution: TaskName";
            // 
            // returnArrow
            // 
            this.returnArrow.AutoSize = true;
            this.returnArrow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnArrow.ForeColor = System.Drawing.Color.SteelBlue;
            this.returnArrow.Location = new System.Drawing.Point(11, 32);
            this.returnArrow.Name = "returnArrow";
            this.returnArrow.Size = new System.Drawing.Size(25, 18);
            this.returnArrow.TabIndex = 32;
            this.returnArrow.Text = "← ";
            this.returnArrow.Visible = false;
            // 
            // progresspercent
            // 
            this.progresspercent.BackColor = System.Drawing.Color.Transparent;
            this.progresspercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progresspercent.Location = new System.Drawing.Point(337, 28);
            this.progresspercent.Name = "progresspercent";
            this.progresspercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progresspercent.Size = new System.Drawing.Size(77, 19);
            this.progresspercent.TabIndex = 33;
            this.progresspercent.Text = "0%";
            this.progresspercent.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Label10.Location = new System.Drawing.Point(13, 12);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(136, 25);
            this.Label10.TabIndex = 24;
            this.Label10.Text = "Rabbit About";
            // 
            // compRatioLabel
            // 
            this.compRatioLabel.AutoSize = true;
            this.compRatioLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.compRatioLabel.Location = new System.Drawing.Point(74, 58);
            this.compRatioLabel.Name = "compRatioLabel";
            this.compRatioLabel.Size = new System.Drawing.Size(299, 21);
            this.compRatioLabel.TabIndex = 28;
            this.compRatioLabel.Text = "本软件一切解释权归小兔兔所有！！！";
            this.compRatioLabel.Visible = false;
            // 
            // PicShow
            // 
            this.PicShow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PicShow.Image = ((System.Drawing.Image)(resources.GetObject("PicShow.Image")));
            this.PicShow.Location = new System.Drawing.Point(39, 299);
            this.PicShow.Name = "PicShow";
            this.PicShow.Size = new System.Drawing.Size(376, 246);
            this.PicShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicShow.TabIndex = 29;
            this.PicShow.TabStop = false;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(49, 193);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(340, 21);
            this.TextBox1.TabIndex = 30;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(340, 237);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 21);
            this.Button1.TabIndex = 31;
            this.Button1.Text = "兔子按钮";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(74, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "本软件一切解释权归小兔兔所有！！！";
            this.label1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(74, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(299, 21);
            this.label9.TabIndex = 32;
            this.label9.Text = "本软件一切解释权归小兔兔所有！！！";
            this.label9.Visible = false;
            // 
            // checkShowConOut
            // 
            this.checkShowConOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkShowConOut.AutoSize = true;
            this.checkShowConOut.ForeColor = System.Drawing.Color.DimGray;
            this.checkShowConOut.Location = new System.Drawing.Point(258, 105);
            this.checkShowConOut.Name = "checkShowConOut";
            this.checkShowConOut.Size = new System.Drawing.Size(156, 16);
            this.checkShowConOut.TabIndex = 34;
            this.checkShowConOut.Text = "Show Detailed Progress";
            this.checkShowConOut.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(40, 127);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(374, 439);
            this.LogTextBox.TabIndex = 35;
            this.LogTextBox.Text = "展示程序日志：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(385, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // RabbitUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 613);
            this.Controls.Add(this.tabControl1);
            this.Name = "RabbitUI";
            this.Text = "RabbitUI";
            this.Load += new System.EventHandler(this.RabbitUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.RadioButton compressX4;
        internal System.Windows.Forms.RadioButton compressLZX;
        internal System.Windows.Forms.RadioButton compressX8;
        internal System.Windows.Forms.RadioButton compressX16;
        internal System.Windows.Forms.Panel Panel3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.CheckBox CheckBox1;
        internal System.Windows.Forms.CheckBox checkForceCompression;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.CheckBox checkHiddenFiles;
        internal System.Windows.Forms.CheckBox checkRecursiveScan;
        internal System.Windows.Forms.Button buttonCompress;
        internal System.Windows.Forms.Label chosenDirDisplay;
        internal System.Windows.Forms.Button buttonQueryCompact;
        internal System.Windows.Forms.Label preSize;
        internal System.Windows.Forms.LinkLabel dirChooser;
        internal System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TabPage tabPage3;
        internal System.Windows.Forms.Label progresspercent;
        internal System.Windows.Forms.Label returnArrow;
        internal System.Windows.Forms.Label progressPageLabel;
        internal System.Windows.Forms.ProgressBar compactprogressbar;
        private System.Windows.Forms.TabPage tabPage2;
        internal System.Windows.Forms.Label compRatioLabel;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox1;
        private System.Windows.Forms.PictureBox PicShow;
        private System.Windows.Forms.TextBox LogTextBox;
        internal System.Windows.Forms.CheckBox checkShowConOut;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}