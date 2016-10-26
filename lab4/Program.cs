using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Boolean cont = false;
            do
            {
                Boolean check = false;
                do
                {
                    Console.WriteLine("Enter an integer between 1 and 16");
                    input = Console.ReadLine();
                    int n;
                    check = int.TryParse(input, out n);
                    if (n < 1 || n > 16)
                    {
                        check = false;
                    }

                } while (check == false);
                int num = int.Parse(input);
                int sum = num;
                for (int i=num-1; i>1;i--)
                {
                    sum = sum*i;
                }
                Console.WriteLine(num+"! is equal to "+sum);










                Console.WriteLine("Do you want to continue? (y/n)");
                string inpt = Console.ReadLine();
                if (inpt == "y" || inpt == "Y")
                {
                    cont = true;
                }
            } while (cont == true);
            
        }
    }
}
