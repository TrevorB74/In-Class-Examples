// Trevor Bryant
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, num3;
            num1 = 28;
            num2 = 482.2;
            num3 = 382.222;
            double result = Add(5, 17.5);
            Console.WriteLine($"5 + 17.5 = {result.ToString("N2")}");
            result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} + {num3} = {result}");

            double[] nums = { num1, num2, num3 };
           // nums = new double[3];
           // nums[0] = num1;
           // nums[1] = num2;
           // nums[2] = num3;
          //  nums[3] = ERROR: INDEX OUT OF BOUNDS
          

            Console.ReadKey();

        }

        static double Add(double[] numbersToAddUp)
        {

            double r = 0;

            int counter = 0;
            while (counter < numbersToAddUp.Length)
            {
                var number = numbersToAddUp[counter];
                r += number;
                // r = r + number;
                counter++;

            }

            for (counter = 0; counter < numbersToAddUp.Length; counter++)
            {
                var number = numbersToAddUp[counter];
                r += number;
            }


            foreach (var number in numbersToAddUp)
            {

                r += number;



            }

            return r;

        }

        /// <summary>
        /// sums up 2 numbers and porvides the result
        /// </summary>
        /// <param name="val1">The lefthand operand of the operation</param>
        /// <param name="val2">The righthand operand of the operation</param>
        /// <returns>the sum of val1 and val2</returns>



        static double Add(double val1, double val2)
        {

            double sum = val1 + val2; 

            return sum;


        }








    }
}
