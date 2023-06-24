using ATM;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ATMTest
{
    public class UnitTest1
    {
       
        [Fact]
        public void TestWithdraw2()
        {
            decimal x = 0;
            decimal result = ATM.Program.Withdraw(x);
            Assert.Equal(result, 10);
        }
        [Fact]
        public void TestWithdraw3()
        {
            decimal x = 5;
            decimal result = ATM.Program.Withdraw(x);
            Assert.Equal(result, 5);
        }

        [Fact]
        public void Deposit()
        {
            decimal x = 10;
            var result = ATM.Program.Deposit(x);
            Assert.Equal(result, 20);
        }

        [Fact]
        public void Deposit2()
        {
            decimal x = 5;
            var result = ATM.Program.Deposit(x);
            Assert.Equal(result, 15);
        }

        [Fact]
        public void view()
        {
            var result = ATM.Program.ViewBalance;
            Assert.Equal(result, result);
        }
        [Fact]
        public void Deposit3()
        {
            decimal x = 3;
            var result = ATM.Program.Deposit(x);
            Assert.Equal(result,13);
        }
        [Fact]
        public void TestWithdraw()
        {
            decimal x = 9;
            decimal result = ATM.Program.Withdraw(x);
            Assert.Equal(result, 1);
        }

    }
}