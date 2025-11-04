using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interfaces
{
    public interface IAttackItem : IWorldObject
    {        
        int Hit { get; set; }
        int Range { get; set; }

        string ToString();
    }
}
