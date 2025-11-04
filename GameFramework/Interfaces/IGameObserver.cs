using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Interfaces
{
    public interface IGameObserver
    {
        public void Attach(IGameNotifier observer);
        public void Detach(IGameNotifier observer);
        public void Notify(string hitStatus);
    }
}
