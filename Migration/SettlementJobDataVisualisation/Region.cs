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
    class Region
    {
        String name;
        Migrants migrants;
        public Region(String regionName)
        {
            name = regionName;
            migrants = new Migrants();
        }

        public Boolean nameMatches(String regionname)
        {
            return name.Equals(regionname);
        }

        public void addMigrant(String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
           migrants.addMigrantData(mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand);
        }

        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap, String state)
        {
            String location = name + ", " + state + ", Australia";
            gmap.SetPositionByKeywords(location);
            PointLatLng point = gmap.Position;
            int migrantNumbers = migrants.getMigrantCount();

            GMarkerGoogle marker;
            if (migrantNumbers < 200)
            {
              marker = new GMarkerGoogle(point,
              GMarkerGoogleType.green_small);
            }
            else if ((migrantNumbers >= 200) && (migrantNumbers < 500))
            {
              marker = new GMarkerGoogle(point,
              GMarkerGoogleType.purple_small);
            }
            else if ((migrantNumbers >= 500) && (migrantNumbers < 2000))
            {
              marker = new GMarkerGoogle(point,
              GMarkerGoogleType.brown_small);
            }
            
            else if ((migrantNumbers >= 2000) && (migrantNumbers < 5000))
            {
              marker = new GMarkerGoogle(point,
              GMarkerGoogleType.yellow_small);
            }
            else if ((migrantNumbers >= 5000) && (migrantNumbers <= 10000))
            {
              marker = new GMarkerGoogle(point,
              GMarkerGoogleType.orange_small);
            }
            else if ((migrantNumbers > 10000))
            {
              marker = new GMarkerGoogle(point,
              GMarkerGoogleType.red_small);
            }
            else
            {
              marker = new GMarkerGoogle(point,
              GMarkerGoogleType.black_small);
            }
            marker.ToolTipText = getBaseDetails(state);
            markersOverlay.Markers.Add(marker);
        }

        public String getName()
        {
            return name;
        }

        public String getRegionDetails(String state)
        {
            return getDetails(state);
        }

        private String getBaseDetails(String state)
        {
            String baseDetails = "State: " + state + "\r\n";
            baseDetails += "Local Government Area: " + name + "\r\n";
            baseDetails += "\r\n";
            int migrantNumbers = migrants.getMigrantCount();
            baseDetails += "Migrant Numbers: " + migrantNumbers + "\r\n\r\n";
            return baseDetails;
        }

        private String getDetails(String state)
        {
            String information = getBaseDetails(state);
            information += "English Proficiency:\r\n";
            information += migrants.getMigrantEnglishProficiency();
            information += "Migrant Genders\r\n";
            information += migrants.getMigrantGender();
            information += "Migrant Age Range\r\n";
            information += migrants.getMigrantAgeRange() + "\r\n";
            information += "Migrant Visa Stream\r\n";
            information += migrants.getMigrantStream();
            return information;
        }
    }
}
