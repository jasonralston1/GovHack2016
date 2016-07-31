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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DataPort dataport;
        GMapOverlay markersOverlay;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataport = new DataPort();
            
            
            stateDropdown.Show();
            stateDropdown.Enabled = false;
            regionDropdown.Show();
            regionDropdown.Text = "Select Region";
            stateDropdown.Text = "Select State";
            regionDropdown.Enabled = false;
            List<String> states = dataport.getStates();
            foreach (String state in states)
            {

                stateDropdown.Items.Add(state);
            }

            
            dataport.markLocations(markersOverlay, gmap);
            stateDropdown.Enabled = true;
            
            gmap.SetPositionByKeywords("New South Wales, Australia");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataport.getResults();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
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

        private void gMapControl1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gmap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            //gmap.SetCurrentPositionByKeywords("New South, Mozambique");
            gmap.SetPositionByKeywords("New South Wales, Australia");
            
            markersOverlay = new GMapOverlay("markers");

           
            

            
         
            stateDropdown.Hide();
            regionDropdown.Hide();

        }

        private void gmap_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void regionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            String location = stateDropdown.Text + ", " + regionDropdown.Text + ", Australia";
            gmap.SetPositionByKeywords(location);
            furtherInfo.Text = dataport.getRegionDetails(stateDropdown.Text, regionDropdown.Text);
        }

        private void gmap_OnMapDrag()
        {

        }

        private void gmap_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            furtherInfo.Clear();
            furtherInfo.Text = item.ToolTipText;
        }
    }
}
