// .NET Framework
// unit test code
using System;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using NUnit.Framework;

namespace BankTests
{
    [TestFixture]
    public class BankAccountTests
    {
        // unit test code
        [TestCase]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            // arrange
            double beginningBalance = 11.99;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

            // act
            account.Debit(debitAmount);

            // assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
    }
}