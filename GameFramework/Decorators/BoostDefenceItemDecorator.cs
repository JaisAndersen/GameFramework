using GameFramework.Models.Defence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameFramework.Decorators
{
    public class BoostDefenceItemDecorator : DefenceItemDecorator
    {
        private int BoostAmount { get; set; }
        public BoostDefenceItemDecorator(DefenceItem defenceItem, int boostAmount) : base(defenceItem)
        {
            BoostAmount = boostAmount;
        }
        public override int ReduceHitPoint
        {
            get { return base.ReduceHitPoint + BoostAmount; }
        }
    }
}
