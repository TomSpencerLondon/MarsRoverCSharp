using System;

namespace MarsRover
{
    public class MarsRover
    {
        private readonly Grid _grid;
        private Direction _direction;

        public MarsRover(Grid grid)
        {
            _grid = grid;
            _direction = Direction.N;
        }

        public String execute(string input)
        {
            var commands = input.ToCharArray();
            Console.WriteLine(commands);
            foreach (var c in commands)
            {
                
                if (c.Equals('R'))
                {
                    _direction = turnRight();
                }
            }
            
            return $"0:0:{_direction.ToString()}";
        }

        private Direction turnRight()
        {
            switch (_direction)
            {
                case Direction.N:
                    return Direction.E;
                case Direction.E:
                    return Direction.S;
                case Direction.S:
                    return Direction.W;
                default:
                    return Direction.N;
            }
        }
    }
}