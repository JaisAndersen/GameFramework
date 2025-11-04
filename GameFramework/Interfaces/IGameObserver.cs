using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interfaces
{
    public interface IGameObserver
    {
        public void Attach(IGameObserver observer);
        public void Detach(IGameObserver observer);
        public void Notify(string hitStatus);
    }
}
