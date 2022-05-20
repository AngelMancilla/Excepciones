using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadLine();

            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }
            catch (FormatException e)
            {
                Console.Write(e.Message);
                Console.ReadLine();
            }

        }
    }
}