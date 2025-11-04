using GameFramework.Models.Defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Decorators
{
    public abstract class DefenceItemDecorator: DefenceItem
    {
        protected readonly DefenceItem _defenceItem;

        protected DefenceItemDecorator(DefenceItem defenceItem)
        {
            _defenceItem = defenceItem;
        }
        public virtual int ReduceHitPoint
        {
            get { return _defenceItem.ReduceHitPoint; }
        }
    }
}
