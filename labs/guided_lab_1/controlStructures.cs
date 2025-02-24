namespace Fundamentals.labs.guided_lab_1
{
    class controlStructures
    {
        public static void testAge()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if ( age >= 18 )
            {
                Console.WriteLine("You are elegible to vote");
            }
            else
            {
                Console.WriteLine("You are not elegible to vote");
            }
        }
    }
}
