namespace WindowsFormsApplication1
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
            this.button1 = new System.Windows.Forms.Button();
            this.stateDropdown = new System.Windows.Forms.ComboBox();
            this.regionDropdown = new System.Windows.Forms.ComboBox();
            this.furtherInfo = new System.Windows.Forms.TextBox();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ProcessData";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stateDropdown
            // 
            this.stateDropdown.FormattingEnabled = true;
            this.stateDropdown.Location = new System.Drawing.Point(12, 111);
            this.stateDropdown.Name = "stateDropdown";
            this.stateDropdown.Size = new System.Drawing.Size(163, 21);
            this.stateDropdown.Sorted = true;
            this.stateDropdown.TabIndex = 3;
            this.stateDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // regionDropdown
            // 
            this.regionDropdown.FormattingEnabled = true;
            this.regionDropdown.Location = new System.Drawing.Point(12, 167);
            this.regionDropdown.Name = "regionDropdown";
            this.regionDropdown.Size = new System.Drawing.Size(163, 21);
            this.regionDropdown.TabIndex = 4;
            this.regionDropdown.SelectedIndexChanged += new System.EventHandler(this.regionDropdown_SelectedIndexChanged);
            // 
            // furtherInfo
            // 
            this.furtherInfo.AcceptsReturn = true;
            this.furtherInfo.Location = new System.Drawing.Point(10, 272);
            this.furtherInfo.Multiline = true;
            this.furtherInfo.Name = "furtherInfo";
            this.furtherInfo.ReadOnly = true;
            this.furtherInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.furtherInfo.Size = new System.Drawing.Size(227, 271);
            this.furtherInfo.TabIndex = 5;
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(243, 111);
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
            this.gmap.Size = new System.Drawing.Size(833, 522);
            this.gmap.TabIndex = 6;
            this.gmap.Zoom = 5D;
            this.gmap.OnMarkerClick += new GMap.NET.WindowsForms.MarkerClick(this.gmap_OnMarkerClick);
            this.gmap.OnMapDrag += new GMap.NET.MapDrag(this.gmap_OnMapDrag);
            this.gmap.Load += new System.EventHandler(this.gmap_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 753);
            this.Controls.Add(this.gmap);
            this.Controls.Add(this.furtherInfo);
            this.Controls.Add(this.regionDropdown);
            this.Controls.Add(this.stateDropdown);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Settlement Data Extract Visualisation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox stateDropdown;
        private System.Windows.Forms.ComboBox regionDropdown;
        private System.Windows.Forms.TextBox furtherInfo;
        private GMap.NET.WindowsForms.GMapControl gmap;
    }
}

