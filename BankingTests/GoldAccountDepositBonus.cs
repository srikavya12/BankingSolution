using BankingDomain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class GoldAccountDepositBonus
    {
        [Fact]
        public void GoldAccountsGetABonusOnDeposits() 
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;
            account.Type = AccountType.Gold;

            account.Deposit(amountToDeposit);

            Assert.Equal(openingBalance+amountToDeposit+10,account.GetBalance());

        }

    }
}
