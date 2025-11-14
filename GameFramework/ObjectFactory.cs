using GameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public abstract class ObjectFactory : IObjectFactory
    {
        public void CreateWorldObjects(IWorldObject worldObject, string name, bool lootable, bool removeable)
        {
            worldObject.Name = name;
            worldObject.Lootable = lootable;
            worldObject.Removeable = removeable;
        }
    }
}
