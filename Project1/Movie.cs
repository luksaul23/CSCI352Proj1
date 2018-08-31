using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Movie : Item
    {

        public string Director;
        public string Length;
        public int Supply = 0;
        public override void Info()
        {
            Console.WriteLine("Name: {0}\nType: {1}\nDirector: {2}\nLength: {3}\nSupply: {4}",
                 name, type, Director, Length, Supply);
        }

        public override void Restock(int amount)
        {
            throw new NotImplementedException();
        }

        public override void Sell(int amount)
        {
            throw new NotImplementedException();
        }
    }
}
