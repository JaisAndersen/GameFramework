using GameFramework.Models.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interfaces
{
    public interface IAttackItemFactory : IObjectFactory
    {
        AttackItem Create(string name, int hit, int range, bool lootable = true, bool removeable = true);
    }
}
