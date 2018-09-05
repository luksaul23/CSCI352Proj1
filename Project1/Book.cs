using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Book : Item
    {
        public string Author;
        public string NumPages;
        public int Supply = 0;

        public override void Info()
        {
            Console.WriteLine("Name: {0}\nType: {1}\nAuthor: {2}\nNumber of Pages: {3}\nSupply: {4}",
                name, type, Author, NumPages, Supply);
        }

        public override void Restock( int amount)
        {
            Supply = Supply + amount;
        }

        public override void Sell(int amount)
        {
            Supply = Supply - amount;
        }
    }
}
