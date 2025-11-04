using GameFramework.Models.Defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Decorators
{
    public class LowerDefenceItemDecorator : DefenceItemDecorator
    {
        private int LowerAmount { get; set; }
        public LowerDefenceItemDecorator(DefenceItem defenceItem, int lowerAmount) : base(defenceItem)
        {
            LowerAmount = lowerAmount;
        }
        public override int ReduceHitPoint
        {
            get { return base.ReduceHitPoint - LowerAmount; }
        }
    }
}
