using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
namespace SettlementDataVisualisation1
{
    class Location
    {
        String name;
        List<Sublocation> regionlist = new List<Sublocation>();
        public Location()
        {
            
        }

        public String getName()
        {
            return name;
        }
        public Location(String stateName)
        {
            name = stateName;
        }
        public void addJobData(String region, String jobarea, String jobrole)
        {
            if (!regionExists( region, jobarea, jobrole))
            {
                Sublocation location = new Sublocation(region);
                addData(location, jobarea, jobrole);
                regionlist.Add(location);
            }
        }



        public Boolean regionExists(String region, String jobarea, String jobrole)
        {
            foreach (Sublocation location in regionlist)
            {
                if (location.getName().Equals(region))
                {
                    addData(location, jobarea, jobrole);
                    return true;
                }
            }
            return false;


        }
        public void addData(Sublocation location, String jobarea, String jobrole)
        {
            location.addJobData(jobarea, jobrole);
        }


        public void test()
        {
            foreach (Sublocation location in regionlist)
            {
                location.test();
            }


        }

        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap)
        {
            foreach (Sublocation location in regionlist)
            {
                location.markLocations(markersOverlay, gmap,name);
            }

        }
        public String getDetails(String state, String region)
        {
            foreach (Sublocation location in regionlist)
            {
                if (location.getName().Equals(region))
                {
                    return location.getDetails(state);
                }
            }
            return "Not Found";
        }
    }
}
