using System;
using MarsLib;

namespace MarsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // new MarsGrid
            var grid = new MarsGrid();

            // add rover
            grid.AddRover(5, 5);

            // add block
            grid.AddBlock(7, 7);

            // add target
            grid.AddTarget(9, 9);

            // display grid
            grid.DisplayMarsMapGrid();

            // loop
            var keepRunning = true;

            while (keepRunning)
            {
                // listen for input:
                var key = ListenForInput();

                switch (key)
                {
                    // q = quit
                    case ConsoleKey.Q:
                        keepRunning = false;
                        break;
                    // m = add rover
                    // ↑↓→← = N/S/E/W
                    // b = block
                    // t = target
                    // g = go
                }

                // add item to map grid
                // quit if required

                // display grid
                grid.DisplayMarsMapGrid();
            }

            Console.WriteLine("Good bye!");
        }

        // MarsLib.IGridItem
        // MarsLib.Rover
        // MarsLib.Block
        // MarsLib.Target
        // MarsLib.Empty

        // MarsLib.InputReader >>>
        public static ConsoleKey ListenForInput()
        {
            // read key input
            var key = Console.ReadKey();

            // return appropriate character
            return key.Key;
        }
        // <<< MarsLib.InputReader

        // MarsDriver.MarsRover >>>
        // <<< MarsDriver.MarsRover
    }
}
