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
    class Migrants
    {
        List<Migrant> migrantList = new List<Migrant>();
        
        public void addMigrantData(String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
            migrantList.Add(new Migrant(mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand));
        }

        public int getMigrantCount()
        {
            return migrantList.Count;
        }

        public String getMigrantEnglishProficiency()
        {
            String proficiency = "";
            int verygood = 0;
            int good = 0;
            int poor = 0;
            int notrecorded = 0;
            foreach (Migrant migrant in migrantList)
            {
                String profiencyResult = migrant.getProficiency();
                if(profiencyResult.Equals("Very Good"))
                {
                    verygood++;
                }
                else if (profiencyResult.Equals("Good"))
                {
                    good++;
                }
                else if (profiencyResult.Equals("Poor"))
                {
                    poor++;
                }
                else
                {
                    notrecorded++;
                }
            }
            proficiency = "Very good: " + verygood + "\r\n";
            proficiency += "Good: " + good + "\r\n"; ;
            proficiency += "Poor: " + poor + "\r\n";
            proficiency += "Not Recorded: " + notrecorded + "\r\n";
            proficiency += "\r\n";
            return proficiency;
        }

        public String getMigrantAgeRange()
        {
            String ageString = "";
            int baby = 0; //00-05
            int youth = 0; //06-11
            int teenager = 0; //12-15
            int youngadult = 0; //16-17 
            int adult = 0; //18-24
            int middleage = 0; //25-34
            int mature = 0; //35-44
            int maturer = 0; //45-54
            int senior = 0; //55-64
            int elderly = 0; //65+
            int unknown = 0;

            foreach (Migrant migrant in migrantList)
            {
                String ageband = migrant.getAgeBand();
                if (ageband.Equals("00-05"))
                {
                    baby++;
                }

                else if (ageband.Equals("06-11"))
                {
                    youth++;
                }
                else if (ageband.Equals("12-15"))
                {
                    teenager++;
                }
                else if (ageband.Equals("16-17"))
                {
                    youngadult++;
                }
                else if (ageband.Equals("18-24"))
                {
                    adult++;
                }
                else if (ageband.Equals("25-34"))
                {
                    middleage++;
                }
                else if (ageband.Equals("35-44"))
                {
                    mature++;
                }
                else if (ageband.Equals("45-54"))
                {
                    maturer++;
                }
                else if (ageband.Equals("55-64"))
                {
                    senior++;
                }
                
                else if (ageband.Equals("65+"))
                {
                    elderly++;
                }
                else
                {
                    unknown++;
                    Console.WriteLine(ageband);
                }
            }
            ageString += ageStringGen("00-05", baby);
            ageString += ageStringGen("06-11", youth);
            ageString += ageStringGen("12-15", teenager);
            ageString += ageStringGen("16-17", youngadult);
            ageString += ageStringGen("18-24", adult);
            ageString += ageStringGen("25-34", middleage);
            ageString += ageStringGen("35-44", mature);
            ageString += ageStringGen("45-54", maturer);
            ageString += ageStringGen("55-64", senior);
            ageString += ageStringGen("65+", elderly);
            ageString += ageStringGen("Unknown", unknown);
          
            return ageString;
        }

        private String ageStringGen(String agerange, int count)
        {
            return agerange + ": " + count + "\r\n";
        }

        public String getMigrantGender()
        {
            String genderString = "";
            int male = 0;
            int female = 0;
            int other = 0;
            
            foreach (Migrant migrant in migrantList)
            {
                String gender = migrant.getGender();
                if (gender.Equals("Male"))
                {
                    male++;
                }
                
                else if (gender.Equals("Female"))
                {
                    female++;
                }
                else
                {
                    other++;
                }
            }
            genderString = "Male: " + male + "\r\n";
            genderString += "Female: " + female + "\r\n"; ;
            genderString += "Other: " + other + "\r\n";
            genderString += "\r\n";
            return genderString;
        }

        public String getMigrantStream()
        {
            String streamString = "";
            int skilled = 0;
            int family = 0;
            int humanitarian = 0;
            int other = 0;

            foreach (Migrant migrant in migrantList)
            {
                String stream = migrant.getMigrationStream();
                if (stream.Equals("Skilled"))
                {
                    skilled++;
                }

                else if (stream.Equals("Family"))
                {
                    family++;
                }
                else if (stream.Equals("Humanitarian"))
                {
                    humanitarian++;
                }
                
                else
                {
                    other++;
                }
            }
            streamString = "Skilled: " + skilled + "\r\n";
            streamString += "Family: " + family + "\r\n"; ;
            streamString += "Humanitarian: " + humanitarian + "\r\n";
            streamString += "Other: " + other + "\r\n";
            streamString += "\r\n";
            return streamString;
        }
    }
}
