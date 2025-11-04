using GameFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework
{
    public class GameNotifier : IGameNotifier
    {
        public void Update(string hitStatus)
        {
            Console.WriteLine($"GameNotifier received update: {hitStatus}");
        }
    }
}
