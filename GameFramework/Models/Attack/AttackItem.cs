using GameFramework.Interfaces;
using GameFramework.Worlds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Models.Attack
{
    public class AttackItem : WorldObject, IAttackItem
    {
        public string Name { get; set; }
        public int Hit { get; set; }
        public int Range { get; set; }

        public AttackItem()
        {
            Name = string.Empty;
            Hit = 0;
            Range = 0;
        }
        public override string ToString()
        {
            return $"{{{nameof(Name)}={Name}, {nameof(Hit)}={Hit.ToString()}, {nameof(Range)}={Range.ToString()}}}";
        }
    }
}
