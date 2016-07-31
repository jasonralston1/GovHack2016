namespace SettlementJobDataVisualisation1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.stateDropdown = new System.Windows.Forms.ComboBox();
            this.regionDropdown = new System.Windows.Forms.ComboBox();
            this.furtherInfo = new System.Windows.Forms.TextBox();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stateDropdown
            // 
            this.stateDropdown.FormattingEnabled = true;
            this.stateDropdown.Location = new System.Drawing.Point(12, 71);
            this.stateDropdown.Name = "stateDropdown";
            this.stateDropdown.Size = new System.Drawing.Size(163, 21);
            this.stateDropdown.Sorted = true;
            this.stateDropdown.TabIndex = 3;
            this.stateDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // regionDropdown
            // 
            this.regionDropdown.FormattingEnabled = true;
            this.regionDropdown.Location = new System.Drawing.Point(12, 127);
            this.regionDropdown.Name = "regionDropdown";
            this.regionDropdown.Size = new System.Drawing.Size(163, 21);
            this.regionDropdown.Sorted = true;
            this.regionDropdown.TabIndex = 4;
            this.regionDropdown.SelectedIndexChanged += new System.EventHandler(this.regionDropdown_SelectedIndexChanged);
            // 
            // furtherInfo
            // 
            this.furtherInfo.AcceptsReturn = true;
            this.furtherInfo.Location = new System.Drawing.Point(10, 154);
            this.furtherInfo.Multiline = true;
            this.furtherInfo.Name = "furtherInfo";
            this.furtherInfo.ReadOnly = true;
            this.furtherInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.furtherInfo.Size = new System.Drawing.Size(227, 341);
            this.furtherInfo.TabIndex = 5;
            // 
            // gmap
            // 
            this.gmap.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(243, 12);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 18;
            this.gmap.MinZoom = 0;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(861, 608);
            this.gmap.TabIndex = 6;
            this.gmap.Zoom = 5D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "State";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Region";
            // 
            // status
            // 
            this.status.Enabled = false;
            this.status.Location = new System.Drawing.Point(15, 12);
            this.status.Multiline = false;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.status.Size = new System.Drawing.Size(173, 29);
            this.status.TabIndex = 9;
            this.status.Text = "Status: Idle";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(572, 635);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 58);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 648);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Key: The Number of  \r\nMigrants per Region area";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 505);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 182);
            this.label4.TabIndex = 12;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 696);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.furtherInfo);
            this.Controls.Add(this.regionDropdown);
            this.Controls.Add(this.stateDropdown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Settlement and Job Data Extract Visualisation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox stateDropdown;
        private System.Windows.Forms.ComboBox regionDropdown;
        private System.Windows.Forms.TextBox furtherInfo;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox status;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

