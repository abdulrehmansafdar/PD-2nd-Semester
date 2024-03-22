using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplabchallenge2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Abdul Rehman", "Gulberg", "Computer Science", 4, 5000);
            Console.WriteLine(s.getName());
            Console.WriteLine(s.getProgram());
            Console.WriteLine(s.getAdress());
            Console.WriteLine(s.getyear());
            Console.WriteLine(s.getfee());
            Console.WriteLine();
            s.setAdress("Rajan pur");
            s.setfee(6000);
            s.setProgram("cs");
            
           
            Console.WriteLine(s.getProgram());
            Console.WriteLine(s.getAdress());
           
            Console.WriteLine(s.getfee());


            Console.WriteLine();

            Staff st = new Staff("Sir Laeeq", "Mianwali", "UET", 10000000);

            Console.WriteLine();
            Console.WriteLine(st.getName());
            Console.WriteLine(st.getAdress());
            Console.WriteLine(st.getSchool());
            Console.WriteLine(st.getpay());
            Console.ReadLine();





        }
    }
}
