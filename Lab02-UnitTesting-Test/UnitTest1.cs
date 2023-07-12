using Lab02ATM; // Add this to connect from one program file to another

namespace Lab02UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ViewBalanceTest()
        {

            // Arrange
            Program.Balance = 100;

            // Act
            decimal result = Program.ViewBalance();

            // Assert
            Assert.Equal(100, result);
        }

        [Fact]
        public void WithdrawTest()
        {

            // Arrange
            Program.Balance = 100;

            // Act
            decimal result = Program.Withdraw(60);

            // Assert
            Assert.Equal(40, result);
        }

        [Fact]
        public void DepositTest()
        {
            // Arrange
            Program.Balance = 100;

            // Act
            decimal result = Program.Deposit(60);

            // Assert
            Assert.Equal(160, result);
        }
    }
}
