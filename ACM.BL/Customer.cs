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
          if(string.IsNullOrWhiteSpace(this.EmailAddress)) throw new ArgumentException("Email address is null");

            var isValidFormat = true;
            //code here that validates the format of the email
            //using Regular Expressions
            if(!isValidFormat) throw new ArgumentException("Email address is not in a correct format");

            var isRealDomain = true;
            //Code here that confirms whether domain exists
            if(!isRealDomain) throw new ArgumentException("Email address does not include a valid domain");

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
