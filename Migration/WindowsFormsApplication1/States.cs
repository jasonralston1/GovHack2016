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
    class States
    {
        List<State> stateList = new List<State>();
        public States()
        {

        }
        public void addMigrantData(String currentState, String localGovernmentArea, String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
            if (!stateExists(currentState, localGovernmentArea, mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand))
            {
                State newstate = new State(currentState);
                newstate.addMigrant(localGovernmentArea, mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand);
                stateList.Add(newstate);
            } 
        }
        private Boolean stateExists(String currentState, String localGovernmentArea, String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
            foreach (State state in stateList)
            {
                if (state.nameMatches(currentState))
                {
                    state.addMigrant(localGovernmentArea, mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand);
                    return true;
                }
            }
            return false;
        }
       
       public List<String> getStates()
        {
            List<String> states = new List<String>();
            foreach (State state in stateList)
            {
                states.Add(state.getName());
            }
            return states;
        }
        public void markLocations(GMapOverlay markersOverlay, GMapControl gmap)
        {
            foreach (State state in stateList)
            {
                state.markLocations(markersOverlay, gmap);
            }
        }
        public List<String> getRegionsForState(String stateName)
        {

            foreach (State state in stateList)
            {
                if (state.getName().Equals(stateName))
                {
                    return state.getRegionsForState();
                }
            }
            return new List<string>();   
        }

        public String getRegionDetails(String stateName, String region)
        {
            foreach (State state in stateList)
            {
                if (state.getName().Equals(stateName))
                {
                    return state.getRegionDetails(region);
                }
            }
            return "State not found";
        }
    }

}
