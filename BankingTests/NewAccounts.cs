using BankingDomain;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using Xunit;

namespace BankingTests
{
    public class NewAccounts
    {
        [Fact]

        public void NewAcountsHaveCorrectOpeningBalance() 
        {
            //Given
            var account = new BankAccount();

            //When
            decimal balance = account.GetBalance();

            //Then
            Assert.Equal(1000M, balance);
        }
    }

}
