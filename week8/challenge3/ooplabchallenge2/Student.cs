using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ooplabchallenge2
{
    internal class Student : Person
    {
        private string Program;
        private int year;
        private double fee;
        public Student(string name,string adress,string program, int year, double fee):base(name,adress)
        {
            Program = program;
            this.year = year;
            this.fee = fee;
            this.Name= name;
            Adress= adress;
        }
        public void setProgram(string program)
            { this.Program = program; }

        public void setYear(int year)
        { this.year = year; }

        public void setfee(double fee)
        { this.fee = fee; }


        public string getProgram()
            { return Program; }
        public int getyear()
        { return year; }
        public double getfee()
        { return fee; }

    }
}
