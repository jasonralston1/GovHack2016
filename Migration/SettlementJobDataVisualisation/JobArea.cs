using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SettlementJobDataVisualisation1
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

        private Boolean jobRoleExists(String jobrole)
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

        private void increaseCount(JobRole job)
        {
            job.increaseCount();
        }

        public String getJobDetails()
        {
            String result = "";
            foreach (JobRole job in jobsRoles)
            {
                result += job.getName() + ": " + job.getCount() ;
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
