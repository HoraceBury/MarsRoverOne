using System;

namespace MarsLib
{
    public class MarsGrid
    {
        public MarsGrid()
        {
            // create grid array
            var grid = new IGridItem[10,10];
        }

        public bool AddRover()
        {
            // get current rover location
            // if not hasRover then add rover, return true
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
            // set cursor to 0,0
            // loop through rows
                // loop through columns
                    // render character:
                        // empty = •
                        // rover = □
                        // block = #
                        // target = ☻
        }
    }
}
