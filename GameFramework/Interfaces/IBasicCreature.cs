using GameFramework.Worlds;

namespace GameFramework.Interfaces
{
    public interface IBasicCreature
    {
        void Hit();
        void Loot(WorldObject worldObject);
        void RecieveHit(int hit);
    }
}