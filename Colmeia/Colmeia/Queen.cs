using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colmeia
{
    class Queen : Bee
    {
        private Worker[] workers;
        private int shiftNumber = 0;

        //Construtor
        public Queen(Worker[] worker) : base (275)
        {
            this.Workers = worker;
        }

        //Getters e Setters
        public Worker[] Workers
        {
            get { return this.workers; }
            set { workers = value; }
        }

        public int ShiftNumber
        {
            get { return shiftNumber; }
            set { shiftNumber = value; }
        }

        //Métodos
        public bool AssignWork(string job, int shift)
        {
            for(int i = 0; i < Workers.Length; i++)
            {

                if (workers[i].DoThisJob(job, shift))
                {
                    workers[i].ShiftsToWork += 1;
                    return true;
                }
                
            }
            return false;
        }

        public string WorkTheNextShift()
        {
            ShiftNumber++;
            string status = "Relatório para turno # "+ShiftNumber+"\r\n";
            for(int i = 0; i< workers.Length; i++)
            {
                if(workers[i].WorkOneShift())
                    status += "A abelha # " + (i+1) + " Terminou o trabalho\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    status += "A abelha # " + (i + 1) + " não está trabalhando\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                    status += "A abelha #" + (i + 1) + " fará " + workers[i].CurrentJob + " por " + workers[i].ShiftsLeft + " mais turnos\r\n";
                else
                    status += "A abelha #" + (i + 1) + " terminará " + workers[i].CurrentJob + " após este turno\r\n";

            }
            return status;
        }
    }
}
