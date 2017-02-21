using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCSharp.Refactoring
{
    public class AccountWithDelegation :AccountBase
    {
        public AccountWithDelegation(IRewardCard rewardCard)
        {
            this.rewardCard = rewardCard;
        }        

        public override int CalculateRewardPoints(decimal amount)
        {
            return rewardCard.CalculateRewardPoints(amount, Balance);
        }

        private readonly IRewardCard rewardCard;
    }
}
