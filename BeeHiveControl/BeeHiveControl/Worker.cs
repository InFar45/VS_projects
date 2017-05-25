using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveControl
{
    class Worker : Bee
    {
        //Constractor
        public Worker(string[] jobsICanDo, int weight) : base(weight)
        {
            this.jobsICanDo = jobsICanDo;
        }

        //List of jobs Bee can do
        private string[] jobsICanDo;
        private string currentJob = "";
        public string CurrentJob
        {
            get
            {
                return currentJob;
            }
        }


        //count of shifts
        private int shiftsToWork;
        private int shiftsWorked;
        public override int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        //Assign the job to bee
        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(currentJob))
                return false;
            for (int i = 0; i < jobsICanDo.Length; i++)
                if (jobsICanDo[i] == job)
                {
                    currentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            return false;
        }

        //Work shift
        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(currentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsToWork = 0;
                shiftsWorked = 0;
                currentJob = "";
                return true;
            }
            else
                return false;
        }
    }
}
