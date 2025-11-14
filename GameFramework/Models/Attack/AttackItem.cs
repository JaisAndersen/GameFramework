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
    /// <summary>
    /// Represents an item that can be used to perform an attack in the game world.
    /// </summary>
    /// <para>The <see cref="AttackItem"/> class provides properties to define the name, hit value, and
    /// range of the attack item.  It inherits from <see cref="WorldObject"/> and implements the <see
    /// cref="IAttackItem"/> interface.</para>
    public class AttackItem : WorldObject, IAttackItem
    {
        public string Name { get; set; }
        public int Hit { get; set; }
        public int Range { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttackItem"/> class with default values.
        /// </summary>
        /// <para>The default values are: <list type="bullet"> <item> <description><see cref="Name"/>
        /// is initialized to an empty string.</description> </item> <item> <description><see cref="Hit"/> is
        /// initialized to 0.</description> </item> <item> <description><see cref="Range"/> is initialized to
        /// 0.</description> </item> </list></para>
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
