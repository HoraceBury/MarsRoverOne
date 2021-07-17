using System;

namespace MarsLib
{
    public class MarsBlock : IGridItem
    {
        public MarsBlock()
        {
        }

        public int X { get ; set ; } = 0;
        public int Y { get ; set ; } = 0;

        public bool IsEmpty  { get; set ; } = true;
    }
}
