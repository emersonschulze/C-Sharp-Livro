    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmeia
{
    class Worker : Bee
    {

        private string currentJob = "";
        private int shiftsLeft;

        private string[] jobsICanDo;
        private int shiftsToWork;
        private int shiftsWorked;

        //Construtor
        public Worker(string[] jobsICanDo, int weight) : base (weight)
        {
            this.JobsICanDo = jobsICanDo;
        }

        //Getters e Setters
        public override int ShiftsLeft
        {
            get { return ShiftsToWork - shiftsWorked; }
        }

        public string[] JobsICanDo
        {
            get { return this.jobsICanDo; }
            set { this.jobsICanDo = value; }
        }

        public int ShiftsToWork
        {
            get { return this.shiftsToWork; }
            set { this.shiftsToWork = value; }
        }

        public int ShiftsWorked
        {
            get { return this.shiftsWorked; }
            set { this.shiftsWorked = value; }
        }

        public string CurrentJob
        {
            get { return currentJob; }
            set { currentJob = value; }
        }

        //Métodos
        public bool DoThisJob(string job, int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(CurrentJob))
                return false;
                for (int i = 0; i < JobsICanDo.Length; i++)
                    if(job == JobsICanDo[i])
                    {
                        CurrentJob = job;
                        this.ShiftsToWork = numberOfShifts;
                        shiftsWorked = 0;
                        return true;
                    }
                return false;
        }

        public bool WorkOneShift()
        {
            if (String.IsNullOrEmpty(CurrentJob))
                return false;
            ShiftsToWork += 1;
            if(shiftsWorked > shiftsToWork)
            {
                ShiftsWorked = 0;
                ShiftsToWork = 0;
                CurrentJob = "";
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
