using GameFramework.Interfaces;
using GameFramework.Models.Attack;
using GameFramework.Models.Creatures;
using GameFramework.Models.Defence;
using GameFramework.Worlds;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class BasicCreature : Creature, IBasicCreature
    {
        public override void Hit()
        {
            var hit = Attack?.Hit ?? 0;
        }
        public override void RecieveHit(int hit)
        {
            var reduced = Math.Max(0, hit - (Defence?.ReduceHitPoint ?? 0));
            hitPoint = Math.Max(0, hitPoint - reduced);
        }
        public override void Loot(WorldObject worldObject)
        {
            if (worldObject == null || !worldObject.Lootable) return;

            if (worldObject is AttackItem attackItem)
            {
                Attack = attackItem;
            }
            else if (worldObject is DefenceItem defenceItem)
            {
                Defence = defenceItem;
            }
        }
    }
}
