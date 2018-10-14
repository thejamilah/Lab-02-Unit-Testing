using Bank_ATM;
using System;
using Xunit;
using static Bank_ATM.Program;

namespace BankTest
{
    public class BankTest
    {
        [Theory]
        [InlineData(1, 9999)]
        [InlineData(5, 9995)]
        public void CanWithdraw(decimal value, decimal expectedResult)
        {
            //Act-resetting balance to 10000 because of global balance
            Balance = 10000;
            //Arrange
            decimal remainingBalance = WithdrawalFromBalance(value);
            //Assert
            Assert.Equal(remainingBalance, expectedResult);
        }
    }
}
