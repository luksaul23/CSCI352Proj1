using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Magazine : Item
    {
        public string Month;
        public string MainStor;

        public override void Info()
        {
            Console.WriteLine("Name: {0}\nMonth: {1}\nMain Story:{2}\nSupply: {3}\n",
                name, Month, MainStor, Supply);
        }

        public override void Restock(int amount)
        {
            Supply = Supply + amount;
        }

        public override void Sell(int amount)
        {
            Supply = Supply - amount;
        }
    }
}
