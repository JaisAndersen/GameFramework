using GameFramework.Interfaces;
using GameFramework.Models.Defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class DefenceItemFactory : ObjectFactory, IDefenceItemFactory
    {
        public DefenceItem Create(string name, int ReduceHitPoint, bool lootable = true, bool removeable = true)
        {
            var item = new DefenceItem
            {
                ReduceHitPoint = ReduceHitPoint
            };
            CreateWorldObjects(item, name, lootable, removeable);
            return item;
        }
    }
}
