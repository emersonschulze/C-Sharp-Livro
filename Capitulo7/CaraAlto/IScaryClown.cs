using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaraAlto
{
    public interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScaryLittleChildren();

    }
}
