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

        [Fact]
        public void L_turns_leaves_0_0_East()
        {
            var position = _marsRover.execute("R");
            
            Assert.Equal("0:0:E", position);
        }
    }
}