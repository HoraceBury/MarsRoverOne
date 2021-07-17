using System;

namespace MarsLib
{
    public class MarsTarget : IGridItem
    {
        public MarsTarget()
        {
        }

        public int X { get ; set ; } = 0;
        public int Y { get ; set ; } = 0;

        public bool IsEmpty  { get; set ; } = true;
    }
}
