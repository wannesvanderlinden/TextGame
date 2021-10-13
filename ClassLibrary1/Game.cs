using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Game
    {


        Player player;
        World world;
        Boolean gameOver;
        Boolean gameWon;


        public string gameOverMessage()
        {
            return "gameover";
        }

       public void FindItemInRoom(Iitem item,Room currentRoom, Player player)
        {
            if(item.names[0] == currentRoom.name)
            {
                player.Inventory.Add(item);
            }
            else
            {
                Console.WriteLine("Doesn't excist");
            }

        }
    }
}
