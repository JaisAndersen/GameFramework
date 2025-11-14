using GameFramework.Interfaces;
using GameFramework.Models.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Strategys
{
    public class DefaultRecieveHitStrategy : IRecieveHitStrategy
    {
        public void RecieveHit(Creature creature, int hit)
        {
            if (hit <= 0) return;

            int newHp = creature.hitPoint - hit;
            creature.hitPoint = newHp < 0 ? 0 : newHp;
        }
    }
}
