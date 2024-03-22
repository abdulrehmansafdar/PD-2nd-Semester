using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ooplabchallenge2
{
    internal class Person
    {
        protected string Name;
        protected string Adress;

        public Person(string name, string adress)
        {
            Name = name;
            Adress = adress;
        }
        public void setAdress(string adress)
        {
            this.Adress = adress;
        }
        public string getName()
            { return this.Name; }
        public string getAdress()
            { return this.Adress; }
        public string tostring()
        {
            return $"Person[name={Name},adress={Adress}";
        }

    }
}
