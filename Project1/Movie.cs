﻿using System;
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
        public override void Info()
        {
            Console.WriteLine("Name: {0}\n\nDirector: {1}\nLength: {2}\nSupply: {3}\n",
                 name, Director, Length, Supply);
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
