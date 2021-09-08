using System;

namespace MarsRover
{
    public class MarsRover
    {
        private readonly Grid _grid;
        private Direction _direction;
        private Position _position;
        public MarsRover(Grid grid)
        {
            _grid = grid;
            _direction = Direction.N;
            _position = new Position(0, 0);
        }

        public String execute(string input)
        {
            var commands = input.ToCharArray();
            Console.WriteLine(commands);
            foreach (var c in commands)
            {
                follow(c);
            }
            
            return $"{_position.X}:{_position.Y}:{_direction.ToString()}";
        }

        private void follow(char c)
        {
            if (c.Equals('R'))
            {
                _direction = turnRight();
            }
            else if (c.Equals('L'))
            {
                _direction = turnLeft();
            }
            else if (c.Equals('M'))
            {
                _position = _grid.move(_position, _direction);
            }
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