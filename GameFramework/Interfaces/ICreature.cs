using GameFramework.Models.Attack;
using GameFramework.Models.Defence;
using GameFramework.Worlds;

namespace GameFramework.Interfaces
{
    public interface ICreature
    {
        AttackItem? Attack { get; set; }
        DefenceItem? Defence { get; set; }
        int hitPoint { get; set; }
        string Name { get; set; }

        void Hit();
        void Loot(WorldObject worldObject);
        void RecieveHit(int hit);
        string ToString();
    }
}