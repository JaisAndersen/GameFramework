using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public struct CordsControl
    {
        public int XCord { get; set; }
        public int YCord { get; set; }

        public CordsControl(int xCord, int yCord)
        {
            XCord = xCord;
            YCord = yCord;
        }
        public static CordsControl operator +(CordsControl currentCord, CordsControl newCord)
        {
            return new CordsControl(currentCord.XCord + newCord.XCord, currentCord.YCord + newCord.YCord);
        }
        public static CordsControl operator -(CordsControl currentCord, CordsControl newCord)
        {
            return new CordsControl(currentCord.XCord - newCord.XCord, currentCord.YCord - newCord.YCord);
        }
        public override string ToString()
        {
            return $"{(XCord, YCord)}";
        }
    }
}
