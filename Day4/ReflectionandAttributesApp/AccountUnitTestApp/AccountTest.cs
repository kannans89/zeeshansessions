using AccountConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountUnitTestApp
{
    [TestClass]
    public class AccountTest
    {

        [TestMethod]
        public void AccountWithNameAndAccnoConstructorShouldReturnBalanceOf500() {

            //Arrange
            Account acc = new Account("Zeeshan", 101);
            double expectedBalance = 500;
            //Act
            double actualBalacne = acc.Balance;
            //Assert

            Assert.IsTrue(expectedBalance==actualBalacne);
        }

        [TestMethod]
        public void CheckIfWithDrawWorksCorreclty()
        {

        }
    }
}
