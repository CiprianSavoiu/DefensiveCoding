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
            decimal result = 0;

            var goalStepCount = Convert.ToDecimal(goalSteps);
            if (goalStepCount>0)
            {
                result = (Convert.ToDecimal(actualSteps) / goalStepCount) * 100;
            }

            return result;
        }
    }
}
