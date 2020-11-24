using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pbd_29_UbayaFriedChicken
{
    public class RewardNotaJual
    {
        private Reward reward;

        public RewardNotaJual(Reward reward)
        {
            this.Reward = reward;
        }

        public Reward Reward { get => reward; set => reward = value; }
    }
}