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
    class Regions
    {
        List<Region> regionList = new List<Region>();
        public void addMigrantData(String localGovernmentArea, String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
            if (!regionExists(localGovernmentArea, mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand))
            {
                Region newregion = new Region(localGovernmentArea);
                newregion.addMigrant( mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand);
                regionList.Add(newregion);
            }
        }
        private Boolean regionExists(String localGovernmentArea, String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
            foreach (Region region in regionList)
            {
                if (region.nameMatches(localGovernmentArea))
                {
                    region.addMigrant( mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand);
                    return true;
                }
            }
            return false;
        }
        
        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap, String state)
        {
            foreach (Region region in regionList)
            {
                region.markLocations(markersOverlay, gmap, state);
            }
        }

        public List<String> getRegionsForState()
        {
            List<String> regions = new List<String>();
            foreach (Region region in regionList)
            {
                regions.Add(region.getName());
            }
            return regions;
        }
        public String getRegionDetails(String regionName, String state)
        {
            foreach (Region region in regionList)
            {
                if(region.getName().Equals(regionName))
                {
                    return region.getRegionDetails(state);
                }
            }
            return "Region not found";
        }
    }
}
