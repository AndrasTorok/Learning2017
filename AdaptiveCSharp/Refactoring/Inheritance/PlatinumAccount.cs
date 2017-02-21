using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCSharp.Refactoring
{
    public class PlatinumAccount : AccountWithInheritance
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Ceiling((Balance / PlatinumBalanceCostPerPoint) + (amount / PlatinumTransactionCostPerPoint));
        }

        private const int PlatinumTransactionCostPerPoint = 2;
        private const int PlatinumBalanceCostPerPoint = 1000;
    }
}
