using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace WindowsFormsApplication1
{
    class State
    {
        String name;
        Regions regions;
        public State(String stateName)
        {
            regions =  new Regions();
            name = stateName;
        }
        public Boolean nameMatches(String statename)
        {
            return name.Equals(statename);
        }
        public void addMigrant(String localGovernmentArea, String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
            regions.addMigrantData(localGovernmentArea, mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand);
        }
        public String getName()
        {
            return name;
        }
        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap)
        {
            regions.markLocations(markersOverlay, gmap, name);

        }
        public List<String> getRegionsForState()
        {

            return regions.getRegionsForState();
        }
        public String getRegionDetails(String region)
        {
            return regions.getRegionDetails(region,name);
        }
    }
}
