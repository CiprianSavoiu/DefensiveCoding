using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTests
{
    [TestClass]
    public class CustumerTest
    {
        [TestMethod]
        public void CalculatePercentageOfGoalStepsTestValid()
        {
            // - Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "2000";
            decimal expected = 40M;

            // - Act
            var actual = customer.CalculatePercentageOfGoalSteps(goalSteps, actualSteps);

            // - Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CalculatePercentageOfGoalStepsTestValidAndSame()
        {
            // - Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "5000";
            decimal expected = 100M;

            // - Act
            var actual = customer.CalculatePercentageOfGoalSteps(goalSteps, actualSteps);

            // - Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CalculatePercentageOfGoalStepsTestValidActualIsZero()
        {
            // -- Arrange
            var customer = new Customer();
            string goalSteps = "5000";
            string actualSteps = "0";
            decimal expected = 0M;

            // -- Act
            var actual = customer.CalculatePercentageOfGoalSteps(goalSteps, actualSteps);

            // -- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentageOfGoalStepsTestGoalIsNull()
        {
            // -- Arrange
            var customer = new Customer();
            string goalSteps = null;
            string actualSteps = "2000";

            // -- Act
            var actual = customer.CalculatePercentageOfGoalSteps(goalSteps, actualSteps);

            // -- Assert
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalculatePercentageOfGoalStepsTestGoalIsNotNumeric()
        {
            // -- Arrange
            var customer = new Customer();
            string goalSteps = "one";
            string actualSteps = "2000";

            // -- Act
            try
            {
                var actual = customer.CalculatePercentageOfGoalSteps(goalSteps, actualSteps);
            }
            catch (Exception e)
            {
               Assert.AreEqual("Goal must be numeric", e.Message);
                throw;
            }

            // -- Assert
        }

    }
}
