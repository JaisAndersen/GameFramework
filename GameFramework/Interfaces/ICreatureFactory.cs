using GameFramework.Models.Attack;
using GameFramework.Models.Creatures;
using GameFramework.Models.Defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interfaces
{
    public interface ICreatureFactory : IObjectFactory
    {
        Creature Create(string name, int hitPoint, AttackItem attack = null, DefenceItem defence = null);
    }
}
