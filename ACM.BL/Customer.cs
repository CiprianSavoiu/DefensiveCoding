using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    /// <summary>
    /// Manage a single CUSTOMER
    /// </summary>
    public class Customer
    {
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ValidateEmail()
        {
            // -- Send an email receipt --
            // If the user requested a receipt
            // Get the customer data
            // Ensure a valid email address was provided.
            // If not,
            // request an email address from the user.
        }

        public decimal CalculatePercentageOfGoalSteps(string goalSteps, string actualSteps)
        {
            decimal goalStepsCount = 0;
            decimal actualStepsCount = 0;

            if(string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal must be entered", "goalSteps");
            if(!decimal.TryParse(goalSteps, out goalStepsCount)) throw new ArgumentException("Goal must be numer", "goalSteps");

            if(string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Actual step must be entered", "actualSteps");
            if(!decimal.TryParse(actualSteps, out actualStepsCount)) throw new ArgumentException("Actual steps must be numeric", "actualSteps");
           
            return CalculatePercentageOfGoalSteps(goalStepsCount, actualStepsCount);
        }
        public decimal CalculatePercentageOfGoalSteps(decimal goalStepCount, decimal actualStepsCount)
        {
            if (goalStepCount <= 0) throw new ArgumentException("Goal must be greater then zero", "goalSteps");
            return (Convert.ToDecimal(actualStepsCount) / goalStepCount) * 100;
        }
    }
}
