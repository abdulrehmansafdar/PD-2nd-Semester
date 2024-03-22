using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplabchallenge4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            salaryAccount s = new salaryAccount(1, 4000);
            Console.WriteLine(s.calculateTax(20,4000));
            child c = new child(4,3000, 5000);
            int c1 = int.Parse(Console.ReadLine());
            if(c.setdeposit(c1))
            {
                Console.WriteLine("Transaction ok");
            }
            else
            {
                Console.WriteLine("Cannot deposit greater than 5000!");

            }
            saving s1 = new saving();
            Console.WriteLine(s1.increase(20000,1000));
            Console.ReadLine();
        }
    }
}
