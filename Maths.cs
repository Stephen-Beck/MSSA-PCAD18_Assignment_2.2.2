/*
Overloading: Write a simple Maths class ( don’t use the keyword Math, it will be a conflict with standard class from system). 
    Write overloaded methods with logic and give choice to user to call different methods :
a. Add(int num1, int num2)
b. Add(decimal num1, decimal num2, decimal num3)
c. Multiply(float num1, float num2)
d. Multiply( float num1, float num2, float num3)
Declare these methods as public and static.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2._2
{
    public class Maths
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1 = 0, decimal num2 = 0, decimal num3 = 0)
        {
            return num1 + num2 + num3;
        }

        public static float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public static float Multiply(float num1 = 1, float num2 = 1, float num3 = 1)
        {
            return num1 * num2 * num3;
        }

        public static decimal GetUserNumber(string dataType)
        {
            int userInteger;
            decimal userNumber;
            bool validEntry = true;

            if (dataType == "int")
                Console.Write("Please enter an integer: ");
            else Console.Write("Please enter a number: ");

            do
            {
                string userInput = Console.ReadLine();
                switch (dataType)
                {
                    case "int":
                        if (int.TryParse(userInput, out userInteger))
                        {
                            validEntry = true;
                            return userInteger;
                        }
                        else
                        {
                            Console.Write("Invalid entry. Please enter an integer: ");
                            validEntry = false;
                        }
                        break;

                    case "decimal":
                    case "float":
                        if (Decimal.TryParse(userInput, out userNumber))
                        {
                            validEntry = true;
                            return userNumber;
                        }
                        else
                        {
                            Console.Write("Invalid entry. Please enter a number: ");
                            validEntry = false;
                        }
                        break;
                }
            } while (!validEntry);
            return 0;
        }
    }
}
