using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo7
{
    public interface IStingPatrol
    {
        int AlertLevel { get; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}
