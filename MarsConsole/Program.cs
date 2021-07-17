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
                var key = Console.ReadKey();
                
                    // q = quit
                    // m = add rover
                    // ↑↓→← = N/S/E/W
                    // b = block
                    // t = target
                    // g = go
                // add item to map grid
                // quit if required

                // display grid
                grid.DisplayMarsMapGrid();
            }
        }

        // MarsLib.IGridItem
        // MarsLib.Rover
        // MarsLib.Block
        // MarsLib.Target
        // MarsLib.Empty

        // MarsLib.InputReader >>>
        public void ListenForInput()
        {
            // read key input
            // return appropriate character
        }
        // <<< MarsLib.InputReader

        // MarsDriver.MarsRover >>>
        // <<< MarsDriver.MarsRover
    }
}
