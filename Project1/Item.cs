using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    abstract class Item
    {
        private string Name;
        private string Type;
        public int Supply = 0;

        public abstract void Restock(int amount);
        public abstract void Sell(int amount);
        public abstract void Info();

        public Item()
            :this("No name", "No type") { }

        public Item(string name)
            : this(name, "No type") { }

        public Item(string name, string type)
        {
            Name = name;
            Type = type;
            Supply++;
        }

        public string name
        {
            get { return Name; }
            set
            {
                if(value == "")
                {
                    Name = "No name";
                }
                Name = value;
            }
        }

        public string type
        {
            get { return Type; }
            set
            {
                if(value == "")
                {
                    Type = "No Type";
                }
                Type = value;
            }
        }

    }
}
