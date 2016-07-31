using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.IO;
using System.Text.RegularExpressions;
using System.Timers;

namespace SettlementJobDataVisualisation1
{
    public partial class Form1 : Form
    {
        private DataPort dataport;
        GMapOverlay markersOverlay;
        Boolean processed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            regionDropdown.Items.Clear();
            String location = stateDropdown.Text + ", Australia";
            gmap.SetPositionByKeywords(location);

            List<String> regions = dataport.getRegionsForState(stateDropdown.Text);
            foreach (String region in regions)
            {
                regionDropdown.Items.Add(region);
            }
            regionDropdown.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.SetPositionByKeywords("Australia");
            markersOverlay = new GMapOverlay("markers");
            status.Text = "Status: Loading Data...";
            stateDropdown.Enabled = false;
            regionDropdown.Enabled = false;
        }

        private void processData()
        {
            status.Text = "Status: Processing Data...";
            status.Update();
            if (!processed)
            {
                dataport = new DataPort();
                
                regionDropdown.Show();
                regionDropdown.Text = "Select Region";
                stateDropdown.Text = "Select State";
                regionDropdown.Enabled = false;
                List<String> states = dataport.getStates();
                foreach (String state in states)
                {
                    stateDropdown.Items.Add(state);
                }

                status.Text = "Status: Updating Map...";
                status.Update();
                gmap.Hide();

                dataport.markLocations(markersOverlay, gmap);

                gmap.SetPositionByKeywords("Australia");
                gmap.Show();
                stateDropdown.Enabled = true;

                processed = true;
                furtherInfo.Text = "Select a region to view further information here.";
                status.Text = "Status: Processing Complete";
            }
            else
            {
                MessageBox.Show("Data already processed");
            }
        }

        private void regionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            String location = stateDropdown.Text + ", " + regionDropdown.Text + ", Australia";
            gmap.Zoom = 12;
            gmap.SetPositionByKeywords(location);
            furtherInfo.Text = dataport.getRegionDetails(stateDropdown.Text, regionDropdown.Text);  
        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            furtherInfo.Clear();
            
            String locationText = item.ToolTipText;

            using (StringReader reader = new StringReader(locationText))
            {
                string line;
                line = reader.ReadLine();
                string[] words = Regex.Split(line, ": ");
                String state = words[1];
                line = reader.ReadLine();
                string[] words2 = Regex.Split(line, ": ");
                String region = words2[1];
                furtherInfo.Text = dataport.getRegionDetails(state, region);
                if (furtherInfo.Text.Equals("State not found"))
                { 
                    furtherInfo.Text = dataport.getJobDetails(state, region);
                }
            }      
    }

        private void Form1_Shown(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            processData();
        }

    }
}
