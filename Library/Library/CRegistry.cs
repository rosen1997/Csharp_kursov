using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class CRegistry
    {
        private int Book_ID;
        private int Reader_ID;

        public CRegistry(int bID, int rID)
        {
            this.Book_ID = bID;
            this.Reader_ID = rID;
        }

        public int getBookID() { return this.Book_ID; }
        public int getReaderID() { return this.Reader_ID; }

        public void setBookID(int bID) { this.Book_ID = bID; }
        public void setReaderID(int rID) { this.Reader_ID = rID; }
    }
}
