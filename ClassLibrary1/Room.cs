using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Room
    {
      public string name { get; set; }
        public string beschrijving { get; set; }
      
        public List<Iitem> items { get; set; }

        public Room(string name,string beschrijving)
        {
            this.name = name;
            this.beschrijving = beschrijving;
           
        }
       
    }
}
