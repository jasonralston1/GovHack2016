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
        public void toString()
        {
            Console.WriteLine(name);
            migrants.toString();
        }

        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap, String state)
        {
            String location = name + ", " + state + ", Australia";
            gmap.SetPositionByKeywords(location);
            PointLatLng point = gmap.Position;

            int migrantNumbers = migrants.getMigrantCount();

            
            GMarkerGoogle marker;
            if (migrantNumbers < 50)
            {

                marker = new GMarkerGoogle(point,
              GMarkerGoogleType.green_small);
            }
            else if ((migrantNumbers >= 50) && (migrantNumbers < 200))
            {
              marker = new GMarkerGoogle(point,
              GMarkerGoogleType.blue_small);
            }
            else if ((migrantNumbers >= 200) && (migrantNumbers < 500))
            {
                marker = new GMarkerGoogle(point,
              GMarkerGoogleType.gray_small);
            }
            else if ((migrantNumbers >= 500) && (migrantNumbers < 1000))
            {
                marker = new GMarkerGoogle(point,
              GMarkerGoogleType.brown_small);
            }
            else if ((migrantNumbers >= 1000) && (migrantNumbers < 5000))
            {
              marker = new GMarkerGoogle(point,
              GMarkerGoogleType.purple_small);
            }
            else if ((migrantNumbers >= 5000) && (migrantNumbers < 10000))
            {
             marker = new GMarkerGoogle(point,
              GMarkerGoogleType.yellow_small);
            }
            else if ((migrantNumbers >= 10000) && (migrantNumbers < 25000))
            {
               marker = new GMarkerGoogle(point,
              GMarkerGoogleType.orange_small);
            }
            else if ((migrantNumbers >= 25000) && (migrantNumbers < 50000))
            {
                marker = new GMarkerGoogle(point,
              GMarkerGoogleType.red_small);
            }
            else
            {
                Console.WriteLine(name + " " + migrantNumbers);
                marker = new GMarkerGoogle(point,
              GMarkerGoogleType.black_small);
            }
            marker.ToolTipText = "Location Name: " + location +"\n";
            marker.ToolTipText += "Migrant Numbers: " + migrantNumbers + "\n";
            marker.ToolTipText += "Number of English Speakers: 2\n";
            marker.ToolTipText += "Number of males: 37000 \n";
            marker.ToolTipText += "Number of females: 240900 \n";

            markersOverlay.Markers.Add(marker);
            

        }
        public String getName()
        {
            return name;
        }
        public String getRegionDetails(String state)
        {
            String location = name + ", " + state + ", Australia";
            String information = "Location Name: " + location + "\r\n";
            int migrantNumbers = migrants.getMigrantCount();
            information += "Migrant Numbers: " + migrantNumbers + "\r\n";
            information += "Number of English Speakers: 2\r\n";
            information += "Number of males: 37000 \r\n";
            information += "Number of females: 240900 \r\n";
            return information;
        }
    }
    
}
