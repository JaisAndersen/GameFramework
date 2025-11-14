using GameFramework.Models.Creatures;

namespace GameFramework.Interfaces
{
    public interface IRecieveHitStrategy
    {
        void RecieveHit(Creature creature, int hit);
    }
}