using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SettlementDataVisualisation1
{
    class JobRole
    {
        String jobrole;
        int count = 0;
        public void increaseCount()
        {

            count++;
        }
        public JobRole(String name)
        {
            jobrole = name;
        }
        public String getName()
        {
            return jobrole;
        }
        
        public int getCount()
        {
            return count;
        }
    }
}
