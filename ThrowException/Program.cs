using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThrowException
{

    class NumberOutOfRangeException : Exception
    {
        public NumberOutOfRangeException(string message) : base(message) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int n = Convert.ToInt32(Console.ReadLine());


                //Console.WriteLine(n);
                numberrange(n);

                Console.WriteLine("Valid input");


            }
            catch (NumberOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void numberrange(int n)
        {
            if(n < 0 ||  n > 1000)
            {
                throw new NumberOutOfRangeException("Number out of range exception");
            }
        }
    }
}
