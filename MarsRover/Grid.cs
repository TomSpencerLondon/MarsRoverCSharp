using System.Collections;

namespace MarsRover
{
    public class Grid
    {
        public Position move(Position position, Direction direction)
        {
            switch(direction)
            {
                case Direction.N:
                    return new Position(position.X, position.Y + 1);
                case Direction.E:
                    return new Position(position.X + 1, position.Y);
                case Direction.S:
                    return new Position(position.X, position.Y - 1);
                default:
                    return new Position(position.X - 1, position.Y);
            }
        }
    }
}