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
        [InlineData("RR", "S")]
        [InlineData("RRR", "W")]
        [InlineData("RRRR", "N")]
        [InlineData("RRRRR", "E")]
        public void R_turns_leaves_0_0_East(string command, string direction)
        {
            var position = _marsRover.execute(command);
            
            Assert.Equal($"0:0:{direction}", position);
        }

        [Theory]
        [InlineData("L", "W")]
        [InlineData("LL", "S")]
        [InlineData("LLL", "E")]
        [InlineData("LLLL", "N")]
        [InlineData("LLLLL", "W")]
        public void L_turns_changes_direction(string command, string direction)
        {
            var position = _marsRover.execute(command);
            
            Assert.Equal($"0:0:{direction}", position);
        }

        [Theory]
        [InlineData("MMMMMMMMMM", "0:0:N")]
        [InlineData("LMMMM", "6:0:W")]
        public void ten_moves_returns_back_to_start(string command, string expected)
        {
            var position = _marsRover.execute(command);
            
            Assert.Equal(expected, position);
        }
    }
}