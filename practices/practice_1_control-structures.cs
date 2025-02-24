namespace Fundamentals.practices
{
    class practice_1_control_structures
    {
        public static void practice()
        {
            /*
                Objective:
                By the end of this activity, you will be able to apply if-else statements
                and switch cases to simulate decisions in a program related to booking tickets for
                different travel modes.
            */
            Console.WriteLine("Enter you age:");
            int age = int.Parse(Console.ReadLine());

            if ( age < 12 )
            {
                Console.WriteLine("Half price ticket");
            }
            else if ( age > 12 && age < 65 )
            {
                Console.WriteLine("Full price ticket");
            }
            else
            {
                Console.WriteLine("Senior discount ticket");
            }

            Console.Write("Enter your mode of travel: ");
            string mode = Console.ReadLine();

            switch (mode.ToLower())
            {
                case "bus":
                    Console.WriteLine("Booking a bus ticket");
                    break;
                case "train":
                    Console.WriteLine("Booking a train ticket");
                    break;
                case "flight":
                    Console.WriteLine("Booking a flight ticket");
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please choose Bus, Train, or Flight");
                    break;
            }

        }
    }
}
