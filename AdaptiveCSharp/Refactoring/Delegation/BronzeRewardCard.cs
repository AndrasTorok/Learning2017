using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCSharp.Refactoring
{
    public class BronzeRewardCard : IRewardCard
    {
        public int RewardPoints { get; private set; }

        public int CalculateRewardPoints(decimal transactionAmount, decimal accountBalance)
        {
            RewardPoints += Math.Max((int)decimal.Floor(transactionAmount /
            BronzeTransactionCostPerPoint), 0);

            return RewardPoints;
        }

        private const int BronzeTransactionCostPerPoint = 20;
    }
}
