namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void PrintMilli()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintThrees()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool IsEqual(int a, int b)
        {
            var check = a == b ? true : false;
            return check;
        }

        //Write a method to check whether a given number is even or odd

        public static void OddOrEven(int a)

        {
            if (a % 2 == 0) 
            { Console.WriteLine("even"); }
            else { Console.WriteLine("odd"); }
        }
        //Write a method to check whether a given number is positive or negative

        public static void PosOrNeg(int a)
        {
            if (a < 0) 
            {
                Console.WriteLine("Negative");
            }
            else { Console.WriteLine("Positive"); }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void VoteAge(int a)
        {
            if (a >= 18)
            { Console.WriteLine("You can Vote"); }
            else { Console.WriteLine("You can't vote yet"); }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void ValueTen(int a)
        {
            if (a <= 10 && a >= -10)
            {
                Console.WriteLine($" {a} is Withen range");
            }
            else { Console.WriteLine($" {a} is Not withen range"); }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void TimesTable(int a)
        {
           for(int i = 1; i < 12; i++) 
            {
                Console.WriteLine(a * i);
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            ValueTen(11);
            PrintMilli();
            PrintThrees();
            IsEqual(1, 2);
            OddOrEven(0);
            PosOrNeg(0);
            VoteAge(21);
            TimesTable(21);
        }
    }
}
