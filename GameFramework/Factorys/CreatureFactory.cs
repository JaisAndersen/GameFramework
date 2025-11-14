using GameFramework.Interfaces;
using GameFramework.Models.Attack;
using GameFramework.Models.Creatures;
using GameFramework.Models.Defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Factorys
{
    public class CreatureFactory : ObjectFactory, ICreatureFactory
    {
        public Creature Create(string name, int hitPoint, AttackItem attack = null, DefenceItem defence = null)
        {
            var creature = new BasicCreature
            {
                Name = name,
                hitPoint = hitPoint,
                Attack = attack,
                Defence = defence
            };
            return creature;
        }
    }
}
