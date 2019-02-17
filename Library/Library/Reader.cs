using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Reader
    {
        private string Name;
        private string Number;
        private string Address;

        public Reader()
        {
            this.Name = "NULL";
            this.Number = "NULL";
            this.Address = "NULL";
        }

        public Reader(string n, string num, string a)
        {
            this.Name = n;
            this.Number = num;
            this.Address = a;
        }

        public string getName() { return this.Name; }
        public string getNumber() { return this.Number; }
        public string getAddress() { return this.Address; }
    }
}
