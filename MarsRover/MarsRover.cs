using System;

namespace MarsRover
{
    public class MarsRover
    {
        private readonly Grid _grid;

        public MarsRover(Grid grid)
        {
            _grid = grid;
        }

        public String execute(string command)
        {
            if (command == "R")
            {
                return "0:0:E";
            }
            return "0:0:N";
        }
    }
}