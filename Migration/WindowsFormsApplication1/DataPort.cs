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

namespace SettlementDataVisualisation1
{
    class DataPort
    {
        private States states = new States();
        private JobLocations joblocations = new JobLocations();
        public DataPort()
        {

           extractSettlementData();
           extractJobAustraliaData();
        }
        public void extractSettlementData()
        {
            using (TextFieldParser parser = new TextFieldParser(@"Settlement-Data-Extract-colon.csv"))

            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(":");
                parser.HasFieldsEnclosedInQuotes = false;
                parser.ReadFields();
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    String currentState = fields[0];
                    String localGovernmentArea = fields[1];
                    String mainLanguage = fields[2];
                    String englishProficient = fields[3];
                    String countryOfBirth = fields[4];
                    String gender = fields[5];
                    String migrationStream = fields[6];
                    String ageBand = fields[7];
                    addSettlementData(currentState, localGovernmentArea, mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand);
                }

            }
            
        }

        public void extractJobAustraliaData()
        {
            using (TextFieldParser parser = new TextFieldParser(@"JPO-coded2.csv"))

            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(":");
                parser.HasFieldsEnclosedInQuotes = false;
                parser.ReadFields();
                while (!parser.EndOfData)
                { 
                    string[] fields = parser.ReadFields();
                    String jobarea = fields[3];
                    String jobrole = fields[4];
                    String region = fields[9];
                    String state = fields[10];
                    addJobAustraliaData(state, region, jobarea, jobrole);
                    
                }
                joblocations.test();
            }

        }
        private void addJobAustraliaData(String state, String region, String jobarea, String jobrole  )
        {
            joblocations.addJobData(state,region,jobarea,jobrole);
        }


        private void addSettlementData(String currentState, String localGovernmentArea, String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
            states.addMigrantData(currentState, localGovernmentArea, mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand);
        }

        public List<String> getStates()
        {
            return states.getStates();
        }
        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap)
        {
            states.markLocations(markersOverlay, gmap);
            joblocations.markLocations(markersOverlay, gmap);
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
        public String getJobDetails(String state, String region)
        {
            return joblocations.getDetails(state, region);
        }
    }
}
