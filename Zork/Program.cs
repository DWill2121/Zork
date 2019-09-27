using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Zork
{

    class Program
    {

        static void Main(string[] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFilename] : defaultGameFilename);

            Game game = Game.Load(gameFilename);
            Console.WriteLine("Welcome to Zork");
            Console.WriteLine("Thank you for Playing!");
        }

        private enum CommandLineArguments
        { 
            GameFilename = 0
        }

          

    }
    public enum Commands
    {
        QUIT,
        LOOK,
        NORTH,
        SOUTH,
        EAST,
        WEST,
        UNKNOWN
    }

    public enum Directions
    {
        NORTH,
        SOUTH,
        EAST,
        WEST
    }

    public enum Fields
    {
        Name = 0,
        Description
    }

    public enum CommandLineArguments
    {
        RoomsFilename = 0
    }








}
