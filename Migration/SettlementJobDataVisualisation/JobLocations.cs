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
    class JobLocations
    {
        List<Location> states;

        public JobLocations()
        {
            states = new List<Location>();
        }

        public void addJobData(String state, String region, String jobarea, String jobrole)
        {
            if (!stateExists(state,region,jobarea,jobrole))
            {
                Location location = new Location(state);
                addData(location,region,jobarea,jobrole);
                states.Add(location);
            }
        }

        private Boolean stateExists(String state, String region, String jobarea, String jobrole)
        {
            foreach (Location location in states)
            {
                if(location.getName().Equals(state))
                {
                    addData(location,region,jobarea,jobrole);
                    return true;
                }
            }
            return false;
        }

        public void addData(Location location, String region, String jobarea, String jobrole)
        {
            location.addJobData(region, jobarea, jobrole);
        }

        public void getJobDetails()
        {
            foreach (Location location in states)
            {
                location.getJobDetails();
            }
        }

        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap)
        {
            foreach (Location location in states)
            {
                location.markLocations(markersOverlay, gmap);
            }
        }

        public String getDetails(String state, String region)
        {
            foreach (Location location in states)
            {
                if (location.getName().Equals(state))
                {
                    return location.getDetails(state, region);
                } 
            }
            return "No Match Found";
        }
    }
}