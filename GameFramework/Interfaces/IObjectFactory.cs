using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interfaces
{
    public interface IObjectFactory
    {
        void CreateWorldObjects(IWorldObject worldObject, string name, bool lootable, bool removeable);
    }
}
