using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class World
    {

       public  Room currentRoom { get; set; }

        public World(Room currentRoom)
        {
            this.currentRoom = currentRoom;
        }

    }
}
