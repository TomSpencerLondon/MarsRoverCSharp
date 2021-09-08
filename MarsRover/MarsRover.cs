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
                }else if (c.Equals('L'))
                {
                    _direction = turnLeft();
                }
            }
            
            return $"0:0:{_direction.ToString()}";
        }

        private Direction turnLeft()
        {
            switch (_direction)
            {
                case Direction.N:
                    return Direction.W;
                case Direction.W:
                    return Direction.S;
                case Direction.S:
                    return Direction.E;
                default:
                    return Direction.N;
            }
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