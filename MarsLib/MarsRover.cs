using System;

namespace MarsLib
{
    public enum FacingDirection
    {
        North,
        South,
        East,
        West
    }
    
    public class MarsRover : IGridItem
    {
        public FacingDirection Direction { get; set; } = FacingDirection.North;
        
        public MarsRover()
        {
        }

        public int X { get ; set ; } = 0;
        public int Y { get ; set ; } = 0;

        public bool IsEmpty  { get; set ; } = true;

        public override string ToString()
        {
            switch (Direction)
            {
                case FacingDirection.North:
                    return "↑";
                case FacingDirection.South:
                    return "↓";
                case FacingDirection.East:
                    return "→";
                default:
                    return "←";
            }
        }
    }
}
