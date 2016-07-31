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
    class Migrants
    {

        List<Migrant> migrantList = new List<Migrant>();
        public Migrants()
        {

        }
        public void addMigrantData(String mainLanguage, String englishProficient, String countryOfBirth, String gender, String migrationStream, String ageBand)
        {
           
                migrantList.Add(new Migrant(mainLanguage, englishProficient, countryOfBirth, gender, migrationStream, ageBand));
            

        }

        public void toString()
        {
            
            
            Console.WriteLine("Migrants: " + migrantList.Count());
            
            Console.WriteLine();
        }
        public int getMigrantCount()
        {
            return migrantList.Count();
        }
        public int getMigrantEnglishProficiency()
        {

            return 0;
        }
        public int getMigrantAgeRange()
        {

            return 0;
        }
        public int getMigrantGender()
        {

            return 0;
        }

    }
}
