using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplabchallenge4
{
    internal class salaryAccount:Account
    {
        public salaryAccount(int id,int amount):base(id,amount)
        { }
        public float calculateTax( int tax, int amount)
{
            {
                return tax* amount;
            }
        }
    }
}
