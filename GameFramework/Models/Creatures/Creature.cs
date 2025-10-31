using GameFramework.Models.Attack;
using GameFramework.Models.Defence;
using GameFramework.Worlds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Models.Creatures
{
    public class Creature
    {
        public string Name { get; set; }
        public int hitPoint { get; set; }

        public AttackItem? Attack { get; set; }
        public DefenceItem? Defence { get; set; }

        public Creature()
        {
            Name = string.Empty;
            hitPoint = 100;

            Attack = null;
            Defence = null;
        }

        public int Hit()
        {
            throw new NotImplementedException();
        }

        public void RecieveHit(int hit)
        {
            throw new NotImplementedException();
        }
        public void Loot (WorldObject worldObject)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(hitPoint)}={hitPoint.ToString()}, {nameof(Attack)}={Attack}, {nameof(Defence)}={Defence}}}";
        }
    }
}
