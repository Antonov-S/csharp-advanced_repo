using NUnit.Framework;
using System;

namespace BankAccount.Test
{
    [TestFixture]

    public class BankAccountTest
    {
        [Test]
        public void AccountInitializeWithPositiveValue()
        {
            BankAccount bAcc = new BankAccount(2000m);
            Assert.That(bAcc.Amount, Is.EqualTo(2000m));
        }

        [Test]
        public void DepositShoudAddMoneyToAcc()
        {
            // Arrange
            BankAccount account = new BankAccount(0m);

            // Act
            account.Deposit(50m);

            //Assert
            Assert.That(account.Amount, Is.EqualTo(50m));

        }
    }
}
