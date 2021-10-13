using AdventureLib;
using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace TextGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            bool gameOver = false;
            string input;
            Player wannes = new Player("wannes");

            Room Cemetery = new Room("cemetery","Behold the place where the dead are living");
            Cemetery.items = new List<Iitem> { new Key()};
            Room Fontain = new Room("fontain","Here are the tears of the dead");
            Fontain.items = new List<Iitem> { new Door() };
            Room HauntedMansion = new Room("Haunted Mansion", "Screams from people");
            HauntedMansion.items = new List<Iitem> { new Can() };
            Room townHall = new Room("The townhall", "A abandonde building where the head of the city lived. The walls are bloody and is filthy");
            townHall.items = new List<Iitem> { new Key() };
            World world = new World(townHall);
            while (!gameOver)
            {
                Console.WriteLine(world.currentRoom.beschrijving);
                Console.WriteLine("What you want to do?");
                input = Console.ReadLine();
                switch (Parser.ParseCommand(input, out List<string> commandoList))
                {
                    case Parser.CommandType.Undefined:
                        Console.WriteLine("You fool do not make it funny!");
                        break;
                    case Parser.CommandType.Use:
                        break;
                    case Parser.CommandType.Take:
                        if(commandoList[0] == "key")
                        {
                            Key key = new Key();
                            Game game = new Game();
                            game.FindItemInRoom(key,world.currentRoom, wannes);
                        }
                        break;
                    case Parser.CommandType.Look:
                        break;
                    case Parser.CommandType.Move:
                        break;
                    case Parser.CommandType.Exit:
                        break;
                }


            }
        }

       
    }
}
