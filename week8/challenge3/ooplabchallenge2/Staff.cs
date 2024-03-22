using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ooplabchallenge2
{
    internal class Staff:Person
    {
        private string school;
        private double pay;

        public Staff(string name,string adress,string school, double pay) :base(name, adress)
        {
            this.school = school;
            this.pay = pay;
            this.Name=name;
            Adress=adress;
        }
        public void setSchool(string school)
        { this.school = school; }
        public void setpay(double pay)
            { this.pay = pay; }
        public string getSchool()
            { return this.school; }
        public double getpay()
            { return this.pay; }

    }
}
