using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveCSharp.Refactoring
{
    public abstract class AccountWithInheritance :AccountBase
    {
        public static AccountBase CreateAccount(AccountType type)
        {
            AccountBase account = null;
            switch (type)
            {
                case AccountType.Silver:
                    account = new SilverAccount();
                    break;
                case AccountType.Gold:
                    account = new GoldAccount();
                    break;
                case AccountType.Platinum:
                    account = new PlatinumAccount();
                    break;
            }
            return account;
        }
    }
}
