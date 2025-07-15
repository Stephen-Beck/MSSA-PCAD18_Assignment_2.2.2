/*
Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). 
    Write overloaded methods with logic and give choice to user to call different methods :
a. Add(int num1, int num2)
b. Add(decimal num1, decimal num2, decimal num3)
c. Multiply(float num1, float num2)
d. Multiply( float num1, float num2, float num3)
Declare these methods as public and static.
 */

namespace Assignment_2._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            decimal num1;
            decimal num2;
            decimal num3;

            while (!exit)
            {
                bool validEntry = true;

                Console.WriteLine("a. Add two numbers (integer) together.");
                Console.WriteLine("b. Add three numbers (decimal) together.");
                Console.WriteLine("c. Multiply two numbers (float) together.");
                Console.WriteLine("d. Multiply three numbers (float) together.");
                Console.Write("Please select one of the four options or enter 'e' to exit: ");

                do
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        case "a":
                            num1 = Maths.GetUserNumber("int");
                            num2 = Maths.GetUserNumber("int");
                            Console.WriteLine("The answer is: "+Maths.Add(Convert.ToInt32(num1), Convert.ToInt32(num2)));
                            validEntry = true;
                            break;
                        case "b":
                            num1 = Maths.GetUserNumber("decimal");
                            num2 = Maths.GetUserNumber("decimal");
                            num3 = Maths.GetUserNumber("decimal");
                            Console.WriteLine("The answer is: " + Maths.Add(Convert.ToDecimal(num1), Convert.ToDecimal(num2), Convert.ToDecimal(num3)));
                            validEntry = true;
                            break;
                        case "c":
                            num1 = Maths.GetUserNumber("float");
                            num2 = Maths.GetUserNumber("float");
                            Console.WriteLine("The answer is: " + Maths.Multiply(Convert.ToSingle(num1), Convert.ToSingle(num2)));
                            validEntry = true;
                            break;
                        case "d":
                            num1 = Maths.GetUserNumber("float");
                            num2 = Maths.GetUserNumber("float");
                            num3 = Maths.GetUserNumber("float");
                            Console.WriteLine("The answer is: " + Maths.Multiply(Convert.ToSingle(num1), Convert.ToSingle(num2), Convert.ToSingle(num3)));
                            validEntry = true;
                            break;
                        case "e":
                            exit = true;
                            validEntry = true;
                            break;
                        default:
                            Console.Write("Please select a valid option: ");
                            validEntry = false;
                            break;
                    }
                } while (!validEntry);
            }
        }
    }
}
