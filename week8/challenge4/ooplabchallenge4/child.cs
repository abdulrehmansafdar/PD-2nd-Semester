using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplabchallenge4
{
    internal class child : Account
    {
        private int limit=5000;
        public child(int id, int amount, int limit) : base(id, amount)
        {
            this.limit = limit;
            this.amount = amount;
            this.Id = id;
        }
        public bool setdeposit(int amount)
        {
            if (amount < limit)
            { this.amount = amount; return true; }
            else
                return false;
        }
    }
}
