using GameFramework.Models.Defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interfaces
{
    public interface IDefenceItemFactory : IObjectFactory
    {
        DefenceItem Create(string name, int ReduceHitPoint, bool lootable = true, bool removeable = true);
    }
}
