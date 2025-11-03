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
        public Difficulty Difficulty { get; set; }

        private WorldConfig()
        {
            MaxX = 20;
            MaxY = 20;
            Difficulty = Difficulty.Medium;
        }
    }
}
