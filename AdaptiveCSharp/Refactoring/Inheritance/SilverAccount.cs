using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCSharp.Refactoring
{
    public class SilverAccount : AccountWithInheritance
    {
        public override int CalculateRewardPoints(decimal amount)
        {
            return (int)decimal.Floor(amount / SilverTransactionCostPerPoint);
        }

        private const int SilverTransactionCostPerPoint = 10;
    }
}
