using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo7
{
    class Bee : IStingPatrol
    {
        public int AlertLevel => throw new NotImplementedException();

        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int length)
        {
            return 1;
        }
    }
}
