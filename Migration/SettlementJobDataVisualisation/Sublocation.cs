using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace SettlementJobDataVisualisation1
{
    class Sublocation
    {
        List<JobArea> jobsArea = new List<JobArea>();
        String regionName;

        public Sublocation(String name)
        {
            regionName = name;
        }

        public String getName()
        {
            return regionName;
        }

        public void addJobData(String jobarea, String jobrole)
        {
            if (!jobAreaExists( jobarea, jobrole))
            {
                JobArea job = new JobArea(jobarea);
                addData(job, jobrole);
                jobsArea.Add(job);
            }
        }

        private Boolean jobAreaExists(String jobarea, String jobrole)
        {
            foreach (JobArea jobareaname in jobsArea)
            {
                if (jobareaname.getName().Equals(jobarea))
                {
                    addData(jobareaname, jobrole);
                    return true;
                }
            }
            return false;
        }

        public void addData(JobArea jobareaname,  String jobrole)
        {
            jobareaname.addJobData( jobrole);
        }

        public void getJobDetails()
        {
            foreach (JobArea jobAreaName in jobsArea)
            {
                jobAreaName.getJobDetails();
            }
        }

        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap, String state)
        {
            String location = regionName + ", Australia";
            gmap.SetPositionByKeywords(location);
            PointLatLng point = gmap.Position;
            GMarkerGoogle marker;
            marker = new GMarkerGoogle(point,
            GMarkerGoogleType.lightblue_pushpin);
            String tooltip = getBaseDetails(state);
            marker.ToolTipText = tooltip;
            markersOverlay.Markers.Add(marker);
        }

        private String getBaseDetails(String state)
        {
            String baseDetails = "State: " + state + "\r\n";
            baseDetails += "Local Government Area: " + regionName + "\r\n";
            baseDetails += "\r\n";

            baseDetails += "Positions available. Click for details.\r\n\r\n";
            
            return baseDetails;
        }

        public String getDetails(String state)
        {
            String information = getBaseDetails(state);
            foreach (JobArea jobAreaName in jobsArea)
            {
                information += jobAreaName.getJobDetails();
            }
            return information;
        }
    }
}
