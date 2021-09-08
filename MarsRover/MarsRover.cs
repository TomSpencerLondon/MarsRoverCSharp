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
                    _direction = turn();
                }
            }
            
            return $"0:0:{_direction.ToString()}";
        }

        private Direction turn()
        {
            if (_direction == Direction.N)
            {
                return Direction.E;
            }else if (_direction == Direction.E)
            {
                return Direction.S;
            }else if (_direction == Direction.S)
            {
                return Direction.W;
            }else
            {
                return Direction.W;
            }
        }
    }
}