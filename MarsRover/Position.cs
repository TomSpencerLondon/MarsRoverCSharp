namespace MarsRover
{
    
    public class Position
    {
        private readonly int _x;
        private readonly int _y;

        public Position(int x, int y)
        {
            _x = x < 0 ? 9 : x % 10;
            _y = y < 0 ? 9 : y % 10;
        }

        public int X => _x;

        public int Y => _y;
    }
}