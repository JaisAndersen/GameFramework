using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interfaces
{
    public interface IWorld
    {
        int MaxX { get; set; }
        int MaxY { get; set; }
        string ToString();
    }
}
