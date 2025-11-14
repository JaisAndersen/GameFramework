using GameFramework.Interfaces;
using GameFramework.Models.Creatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Strategys
{
    /// <summary>
    /// Provides the default implementation for handling hit point reduction when a creature receives damage.
    /// </summary>
    /// <remarks>This strategy ensures that a creature's hit points are reduced by the specified amount, with
    /// a lower bound of zero. It is designed to prevent negative hit points and ignores damage values less than or
    /// equal to zero.</remarks>
    public class DefaultRecieveHitStrategy : IRecieveHitStrategy
    {
        /// <summary>
        /// Reduces the hit points of the specified creature by the given amount.
        /// </summary>
        /// <remarks>If the resulting hit points are less than zero, they are set to zero.  This method
        /// has no effect if <paramref name="hit"/> is less than or equal to zero.</remarks>
        /// <param name="creature">The creature whose hit points will be reduced. Cannot be null.</param>
        /// <param name="hit">The amount of damage to apply. Must be greater than zero.</param>
        public void RecieveHit(Creature creature, int hit)
        {
            if (hit <= 0) return;

            int newHp = creature.hitPoint - hit;
            creature.hitPoint = newHp < 0 ? 0 : newHp;
        }
    }
}
