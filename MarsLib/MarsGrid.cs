using System;
using System.Collections.Generic;
using Console = Colorful.Console;

namespace MarsLib
{
    public class MarsGrid
    {
        private List<List<IGridItem>> Grid { get; set; }

        public MarsGrid()
        {
            // create grid array
            Grid = new List<List<IGridItem>>();

            // populate default grid
            PopulateGrid(10, 10);
        }

        private void PopulateGrid(int rows, int cols)
        {
            // loop through rows
            for (var rowIndex=0; rowIndex<rows; rowIndex++)
            {
                // add row
                Grid.Add(new List<IGridItem>());

                // loop through columns
                for (var colIndex=0; colIndex<cols; colIndex++)
                {
                    Grid[rowIndex].Add(new MarsEmpty());
                }
            }
        }

        public bool AddRover(int x, int y)
        {
            // get current rover location
            // if not hasRover then add rover, return true
            Grid[y][x] = new MarsRover();

            // if hasRover then return false
            return false;
        }

        public bool AddBlock(int x, int y)
        {
            // set grid location to block
            Grid[y][x] = new MarsBlock();
            
            return false;
        }

        public bool AddTarget(int x, int y)
        {
            // set grid location to block
            Grid[y][x] = new MarsTarget();
            
            return false;
        }

        public void DisplayMarsMapGrid()
        {
            // clear display
            Console.Clear();

            // set cursor to 0,0
            Console.SetCursorPosition(0, 0);

            // loop through rows
            for (var rowIndex=0; rowIndex<Grid.Count; rowIndex++)
            {
                // loop through columns
                for (var colIndex=0; colIndex<Grid[rowIndex].Count; colIndex++)
                {
                    // current grid item
                    var item = Grid[rowIndex][colIndex];

                    // get item type
                    var itemType = item.GetType().ToString();

                    // colour to print with
                    var colour = itemType == "MarsLib.MarsEmpty" ? ConsoleColor.Gray : ConsoleColor.Red;

                    // render character:
                    switch (itemType)
                    {
                        // empty = ☼
                        case "MarsLib.MarsEmpty":
                            Console.Write("☼", colour);
                            break;
                        // rover = @
                        case "MarsLib.MarsRover":
                            Console.Write(item.ToString(), colour);
                            break;
                        // block = #
                        case "MarsLib.MarsBlock":
                            Console.Write("#", colour);
                            break;
                        // target = ☻
                        case "MarsLib.MarsTarget":
                            Console.Write("☻", colour);
                            break;
                    }
                }

                // render new line for the next row
                Console.WriteLine();
            }
        }
    }
}
