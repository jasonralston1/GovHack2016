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
    class Migrant
    {
        String mainLanguage;
        String englishProficient;
        String countryOfBirth;
        String gender;
        String migrationStream;
        String ageBand;

        public Migrant(String mainLanguage2, String englishProficient2, String countryOfBirth2, String gender2, String migrationStream2, String ageBand2)
        {
            mainLanguage = mainLanguage2;
            englishProficient = englishProficient2;
            countryOfBirth = countryOfBirth2;
            gender = gender2;
            migrationStream = migrationStream2;
            ageBand = ageBand2;
        }
        public String getProficiency()
        {
            return englishProficient;
        }
        public String getGender()
        {
            return gender;
        }
        public String getAgeBand()
        {
            return ageBand;
        }

        public String getMigrationStream()
        {
            return migrationStream;
        }
    }
}
