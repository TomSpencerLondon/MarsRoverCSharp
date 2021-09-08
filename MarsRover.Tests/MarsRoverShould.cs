using System;
using System.Security.Principal;
using Xunit;

namespace MarsRover.Tests
{
    public class MarsRoverShould
    {
        private readonly MarsRover _marsRover;

        public MarsRoverShould()
        {
            var grid = new Grid();
            _marsRover = new MarsRover(grid);
        }


        [Fact]
        public void empty_command_leaves_0_0_facing_north()
        {
            var position = _marsRover.execute("");
            
            Assert.Equal("0:0:N", position);
        }

        [Theory]
        [InlineData("R", "E")]
        public void L_turns_leaves_0_0_East(string command, string direction)
        {
            var position = _marsRover.execute(command);
            
            Assert.Equal($"0:0:{direction}", position);
        }
    }
}