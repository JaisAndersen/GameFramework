using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Worlds
{
    public class World
    {
        public int MaxX { get; set; }
        public int MaxY { get; set; }

        private List<WorldObject> _worldObjects;
        private List<Creature> _creatures;
    }
}
