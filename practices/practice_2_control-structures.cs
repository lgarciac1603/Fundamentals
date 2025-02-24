using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.practices
{
    class practice_2_control_structures
    {
        public static void problem_1()
        {
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the type of membership (basic/premium):");
            string membershipType = Console.ReadLine().ToLower();

            int fee = 0;

            if ( age < 18 )
            {
                if ( membershipType == "basic" )
                {
                    fee = 15;
                }
                else if ( membershipType == "premium" )
                {
                    fee = 25;
                }
            }
            else if ( age >= 18 && age <= 60 )
            {
                if ( membershipType == "basic" )
                {
                    fee = 30;
                }
                else if ( membershipType == "premium" )
                {
                    fee = 50;
                }
            }
            else if ( age > 60 )
            {
                if ( membershipType == "basic" )
                {
                    fee = 20;
                }
                else if ( membershipType == "premium" )
                {
                    fee = 35;
                }
            }

            Console.WriteLine("Your membership fee is: $" + fee);
        }

        public static void problem_2()
        {
            // Step 1: Prompt the user to enter the account type
            Console.WriteLine("What type of account are you opening? (savings/checking/business):");
            string accountType = Console.ReadLine().ToLower();

            // Step 2: Declare variables for interest rate and monthly fee
            double interestRate = 0;
            int monthlyFee = 0;

            // Step 3: Use switch statement to determine account details based on account type
            switch ( accountType )
            {
                case "savings":
                    // Handle savings account: Apply 2% interest rate
                    interestRate = 0.02;
                    Console.WriteLine("Interest rate is 2%");
                    break;

                case "checking":
                    // Handle checking account: Apply $10 monthly fee
                    monthlyFee = 10;
                    Console.WriteLine("Monthly fee is $10");
                    break;

                case "business":
                    // Handle business account: Apply 1% interest rate and $20 monthly fee
                    interestRate = 0.01;
                    monthlyFee = 20;
                    Console.WriteLine("Interest rate is 1% and monthly fee is $20");
                    break;

                default:
                    // Handle invalid account type
                    Console.WriteLine("Invalid account type");
                    break;
            }
        }
    }
}
