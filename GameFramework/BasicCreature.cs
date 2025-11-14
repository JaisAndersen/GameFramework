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
    /// <summary>
    /// Represents a basic creature in the game world, capable of attacking, defending, and interacting with lootable
    /// objects.
    /// </summary>
    /// <para>This class provides fundamental behaviors for a creature, including handling attacks,
    /// receiving damage, and looting items. It extends the <see cref="Creature"/> class and implements the <see
    /// cref="IBasicCreature"/> interface.</para>
    public class BasicCreature : Creature, IBasicCreature
    {
        /// <summary>
        /// Executes an attack and calculates the resulting hit value.
        /// </summary>
        /// <para>The hit value is determined by the <see cref="Creature.Attack"/> property. If <see
        /// cref="Creature.Attack"/> is null, the hit value defaults to 0.</para>
        public override void Hit()
        {
            var hit = Attack?.Hit ?? 0;
        }
        /// <summary>
        /// Processes an incoming hit by reducing the hit points based on the defense value.
        /// </summary>
        /// <para>The actual damage applied is reduced by the defense value, if available. The hit
        /// points are then decreased by the resulting damage, but will not drop below zero.</para>
        /// <param name="hit">The amount of damage to be applied to the entity.</param>
        public override void RecieveHit(int hit)
        {
            var reduced = Math.Max(0, hit - (Defence?.ReduceHitPoint ?? 0));
            hitPoint = Math.Max(0, hitPoint - reduced);
        }
        /// <summary>
        /// Attempts to loot the specified <see cref="WorldObject"/> and assigns it to the appropriate category if it is
        /// lootable.
        /// </summary>
        /// <para>If the <paramref name="worldObject"/> is an <see cref="AttackItem"/>, it is assigned
        /// to the <c>Attack</c> property. If it is a <see cref="DefenceItem"/>, it is assigned to the <c>Defence</c>
        /// property. No action is taken if the object is not lootable or is <see langword="null"/>.</para>
        /// <param name="worldObject">The <see cref="WorldObject"/> to loot. Must not be <see langword="null"/> and must be lootable.</param>
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
