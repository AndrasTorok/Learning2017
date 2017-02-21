using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCSharp.Refactoring
{
    public class AccountInitial : AccountBase
    {
        public AccountInitial(AccountType type)
        {
            this.type = type;
        }        

        public override int CalculateRewardPoints(decimal amount)
        {
            int points;
            switch (type)
            {
                case AccountType.Silver:
                    points = (int)decimal.Floor(amount / SilverTransactionCostPerPoint);
                    break;
                case AccountType.Gold:
                    points = (int)decimal.Floor((Balance / GoldBalanceCostPerPoint) + (amount
                    / GoldTransactionCostPerPoint));
                    break;
                case AccountType.Platinum:
                    points = (int)decimal.Ceiling((Balance / PlatinumBalanceCostPerPoint) +
                    (amount / PlatinumTransactionCostPerPoint));
                    break;
                default:
                    points = 0;
                    break;
            }
            return Math.Max(points, 0);
        }
        private const int SilverTransactionCostPerPoint = 10;
        private const int GoldTransactionCostPerPoint = 5;
        private const int PlatinumTransactionCostPerPoint = 2;
        private const int GoldBalanceCostPerPoint = 2000;
        private const int PlatinumBalanceCostPerPoint = 1000;

        private readonly AccountType type;
    }
}
