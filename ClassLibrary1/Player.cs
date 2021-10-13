using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Player
    {
        string Name;

        public Player(string name)
        {
            Name = name;
            Inventory =new List<Iitem>();
        }

        public Player(string name, List<Iitem> inventory) : this(name)
        {
            Inventory = inventory;
        }

        public List<Iitem> Inventory { get; set; }

    }
}
