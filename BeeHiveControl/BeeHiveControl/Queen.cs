using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveControl
{
    class Queen:Bee
    {
        //Constructor Queen
        public Queen(Worker[] workers):base(275)
        {
            this.workers = workers;
        }

        //var
        private Worker[] workers;
        private int shiftNumber = 0;


        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job,numberOfShifts))
                    return true;
            return false;
        }

        public override double GetHoneyConsumption()
        {
            double consumption = 0;
            double largestWorkerConsumption = 0;
            int workersDoingJobs = 0;
            
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption = workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    workersDoingJobs++;
            }

            consumption += largestWorkerConsumption;
            if (workersDoingJobs >= 3)
                consumption += 30;
            else
                consumption += 20;
           
            return consumption;
        }

        public string WorkTheNextShift()
        {
            double totalConsumption = 0;
            for (int i = 0; i < workers.Length; i++)
                totalConsumption += workers[i].GetHoneyConsumption();
            totalConsumption += GetHoneyConsumption();

            shiftNumber++;
            string report = "Report for shift#" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Worker #" + (i + 1) + " finished the work\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Worker #" + (i + 1) + " is free\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                    report += "Worker #" + (i + 1) + " is working on " + workers[i].CurrentJob
                    + " for " + workers[i].ShiftsLeft + " shifts\r\n";
                else
                    report += "Worker #" + (i + 1) + " will finish " + workers[i].CurrentJob + " next shift\r\n";
            }
            report += "Summary honey consumtion: " + totalConsumption + " points";
            return report;
        }
    }
}
