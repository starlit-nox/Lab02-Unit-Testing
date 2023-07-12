using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Lab02_UnitTesting_Test
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalanceTest()
        {
            Program.Balance = 100;
            decimal result = Program.ViewBalance();
            Assert.Equal(100, result);
        }
        [Fact]
        public void WithdrawTest()
        {
            Program.Balance = 100;
            decimal result = Program.Withdraw(60);
            Assert.Equal(40, result);
        }
        [Fact]
        public void DepositTest()
        {
            Program.Balance = 100;
            decimal result = Program.Deposit(60);
            Assert.Equal(160, result);


        }
    }
}