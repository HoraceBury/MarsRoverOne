using System;
using MarsLib;

namespace MarsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // new MarsGrid
            var grid = new IGridItem[10,10];

            // display grid
            DisplayMarsMapGrid(grid);

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

        // MarsLib.MarsGrid >>>
        /*public static MarsGrid()
        {
            // create grid array
        }*/

        public static bool AddRover()
        {
            // get current rover location
            // if not hasRover then add rover, return true
            // if hasRover then return false
            return false;
        }

        public static bool AddBlock()
        {
            // set grid location to block
            return false;
        }

        public static void DisplayMarsMapGrid(IGridItem[,] grid)
        {
            // clear display
            // set cursor to 0,0
            // loop through rows
                // loop through columns
                    // render character:
                        // empty = •
                        // rover = □
                        // block = #
                        // target = ☻
        }
        // <<< MarsLib.MarsGrid

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
