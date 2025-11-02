using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class WorldConfig
    {
        private static WorldConfig _instance = new();
        public static WorldConfig Instance { get { return _instance; } }

        public int MaxX { get; set; }
        public int MaxY { get; set; }
        public Dificulty Dificulty { get; set; }

        private WorldConfig()
        {
            MaxX = 20;
            MaxY = 20;
            Dificulty = Dificulty.Medium;
        }
    }
}
