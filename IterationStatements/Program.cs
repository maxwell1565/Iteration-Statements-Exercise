namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintNumbers()
        {
            int i = 0;

            while (i > -1000)
            {
                i--;
                Console.WriteLine(i);
            }
            while (i < 1000)
            {
                i++;
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void CountBy3()
        {
            var listOfNumbers = new List<int>();


            for (int i = 3; i <= 999; i += 3)
            {
                listOfNumbers.Add(i);
            }

            foreach (int item in listOfNumbers)

            {
                Console.WriteLine($"{item}");
            }
        }

        //Write a method to accept two integers as parameters and check whether they are equal or not

        public static void NumberEqualityChecker()
        {
            Console.WriteLine("Please type any number.");
            var num1 = Console.ReadLine();
            Console.WriteLine("Please type another number.");
            var num2 = Console.ReadLine();

            while (num1 == num2)
            {
                Console.WriteLine("Yay! These numbers are equal.");
                break;
            }

            while (num1 != num2)
            {
                Console.WriteLine("These numbers are not equal.");
                break;
            }

        }

        //Write a method to check whether a given number is even or odd

        public static void OddOrEvenChecker()
        {
            Console.WriteLine("Please enter a number.");
            var userInput = Console.ReadLine();
            var num = double.Parse(userInput);
            if (num % 2 == 0)
            { 
                Console.WriteLine("That's an even number.");
            }
            else
            {
                Console.WriteLine("Thats an odd number");
            }

        }

        //Write a method to check whether a given number is positive or negative

        public static void PosOrNegChecker()
        {
            Console.WriteLine("Please enter a number.");
            var userInput = Console.ReadLine();
            var num = double.Parse(userInput);
            if (num >= 1)
            {
                Console.WriteLine("That's a positive number");
            }
            else if (num == 0)
            {
                Console.WriteLine("Thats zero");
            }
            else
            {
                Console.WriteLine("Thats a negative number");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static bool VotingAgeChecker()
        {
            Console.WriteLine("Please enter your age.");
            var userInput = Console.ReadLine();
            var age = double.Parse(userInput);
            if (age >= 18)
            {
                Console.WriteLine("You're old enought to vote.");
                return true;
            }
            else
            {
                Console.WriteLine("Sorry you have to be 18 to vote.");
                return false;
            }

        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static bool RangeChecker()
        {
            Console.WriteLine("Please enter a number. It can be positive or negative.");
            var userInput = Console.ReadLine();
            var num = double.Parse(userInput);
            if (num <= 10 && num >= -10)
            {
                Console.WriteLine($"{num} is in the range");
                return true;
            }

            Console.WriteLine($"{num} is out of the range");
            return false;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultiplicationTable()
        {
            Console.WriteLine("Please input any integer");
            var userInput = Console.ReadLine();
            var numToMultiply = double.Parse(userInput);

            var listOfNumbers = new List<int>();

            for (int i = 1; i <= 12; i++)
            {
                listOfNumbers.Add(i);
            }

            foreach (int item in listOfNumbers)

            {
                Console.WriteLine($"{item}");
            }
            
        }



        //Call the methods to test them in the Main method below
        static void Main (string[] args)
            {
            PrintNumbers();
            CountBy3();
            NumberEqualityChecker();
            OddOrEvenChecker();
            PosOrNegChecker();
            VotingAgeChecker();
            RangeChecker();
            MultiplicationTable();
            }
        
    }
}