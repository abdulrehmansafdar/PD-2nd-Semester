using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplabchallenge4
{
    internal class Account
    {
        protected int Id;
        protected int amount;

        public Account(int id, int amount)
        {
            Id = id;
            this.amount = amount;
        }
        public string tostring()
        {
            return $"Info[id={Id},amount={amount}"; 
        }
    }
}
