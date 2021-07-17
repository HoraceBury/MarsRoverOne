using System.Threading.Tasks.Dataflow;
using System;
using System.Collections.Generic;

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

        public bool AddBlock()
        {
            // set grid location to block
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
                    // render character:
                    switch (Grid[rowIndex][colIndex].ToString())
                    {
                        // empty = ☼
                        case "MarsLib.MarsEmpty":
                            Console.Write("☼");
                            break;
                        // rover = @
                        case "MarsLib.MarsRover":
                            Console.Write("@");
                            break;
                        // block = #
                        case "MarsLib.MarsBlock":
                            Console.Write("#");
                            break;
                        // target = ☻
                        case "MarsLib.MarsTarget":
                            Console.Write("☻");
                            break;
                    }
                }

                // render new line for the next row
                Console.WriteLine();
            }
        }
    }
}
