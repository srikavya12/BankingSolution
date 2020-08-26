using System;
using System.Collections.Generic;
using System.Text;

namespace BankingDomain
{
    public class GoldAccount: BankAccount
    {
        public override void Deposit(decimal amountToDeposit) 
        {
            base.Deposit(amountToDeposit * 1.10M);
        }
    }
}
