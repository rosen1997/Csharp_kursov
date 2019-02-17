using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string Title;
        private string Author;
        private string Publisher;
        private bool Available;

        public Book(string t, string a, string p, bool av)
        {
            this.Title = t;
            this.Author = a;
            this.Publisher = p;
            this.Available = av;
        }

        public Book()
        {
            this.Title = "NULL";
            this.Author = "NULL";
            this.Publisher = "NULL";
            this.Available = false;
        }

        public string getTitle() { return this.Title; }
        public string getAuthor() { return this.Author; }
        public string getPublisher() { return this.Publisher; }
        public bool getAvailable() { return this.Available; }

        public void setTitle(string t) { this.Title = t; }
        public void setAuthor(string a) { this.Author = a; }
        public void setPublisher(string p) { this.Publisher = p; }
        public void setAvailable(bool av) { this.Available = av; }

    }
}
