using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SettlementDataVisualisation1
{
    class JobArea
    {
        String jobarea;
        List<JobRole> jobsRoles = new List<JobRole>();
        public JobArea(String name)
        {
            jobarea = name;
        }
        public String getName()
        {
            return jobarea;
        }





        public void addJobData(String jobrole)
        {
            if (!jobRoleExists( jobrole))
            {
                JobRole job = new JobRole(jobrole);
                increaseCount(job) ;
                jobsRoles.Add(job);
            }
        }



        public Boolean jobRoleExists(String jobrole)
        {
            foreach (JobRole job in jobsRoles)
            {
                if (job.getName().Equals(jobrole))
                {
                    increaseCount(job);
                    return true;
                }
            }
            return false;


        }
        public void increaseCount(JobRole job)
        {
            job.increaseCount();
        }

        public String test()
        {
            String result = "";
            foreach (JobRole job in jobsRoles)
            {
                result += job.getName() + ": " + job.getCount() ;
                //result += "There were " + job.getCount() + " jobs offered as a " + job.getName() + "\r\n";
                //result += "Job Area: " + job.getName() + " had " + job.getCount() + " roles. \r\n";
                if (job.getCount() == 1)
                {
                    result += " role. \r\n\r\n";
                }
                else
                {
                    result += " roles. \r\n\r\n";
                }
                
            }

            return result;
        }
    }
}
