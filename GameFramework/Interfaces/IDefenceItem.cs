using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interfaces
{
    public interface IDefenceItem : IWorldObject
    {
        int ReduceHitPoint { get; set; }
        string ToString();
    }
}
