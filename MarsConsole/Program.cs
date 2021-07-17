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

            // display grid
            grid.DisplayMarsMapGrid();

            // loop
                // listen for input:
                    // q = quit
                    // m = add rover
                    // ↑↓→← = N/S/E/W
                    // b = block
                    // t = target
                    // g = go
                // add item to map grid
                // quit if required
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
