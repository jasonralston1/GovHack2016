using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace WindowsFormsApplication1
{
    class DataPort
    {
        private States states = new States();
        public DataPort()
        {

            extractData();
        }
        public void extractData()
        {
            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\Jason\Desktop\govhack\data\Settlement-Data-Extract.csv"))
           // using (TextFieldParser parser = new TextFieldParser(@"N:\govhack\data\subset.csv"))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = false;
                parser.ReadFields();
                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();
                   
                     
                        String currentState = fields[0];
                        String localGovernmentArea = fields[1];
                        String mainLanguage = fields[2];
                        String englishProficient = fields[3];
                        String countryOfBirth = fields[4];
                        String gender = fields[5];
                        String migrationStream = fields[6];
                        String ageBand = fields[7];



                    addData(currentState, localGovernmentArea, mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand);
                }
                Console.WriteLine("Processing complete");
            }

        }
        private void addData(String currentState, String localGovernmentArea, String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
            states.addMigrantData(currentState, localGovernmentArea,mainLanguage,englishProficient,countryOfBirth,gender,migrationStream,ageBand);
        }
        public void getResults()
        {
            states.toString();
        }
        public List<String> getStates()
        {
            return states.getStates();
        }
        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap)
        {
            states.markLocations(markersOverlay, gmap);
            gmap.Overlays.Add(markersOverlay);
        }
       public List<String> getRegionsForState(String state)
        {

            return states.getRegionsForState(state);
        }
        public String getRegionDetails(String state, String region)
        {
            return states.getRegionDetails(state, region);

        }
    }
}
