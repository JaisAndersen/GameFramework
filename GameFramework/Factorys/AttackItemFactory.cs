using GameFramework.Interfaces;
using GameFramework.Models.Attack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Factorys
{
    public class AttackItemFactory : ObjectFactory, IAttackItemFactory
    {
        public AttackItem Create(string name, int hit, int range, bool lootable = true, bool removeable = true)
        {
            var item = new AttackItem
            {
                Hit = hit,
                Range = range
            };
            CreateWorldObjects(item, name, lootable, removeable);
            return item;
        }
    }
}
