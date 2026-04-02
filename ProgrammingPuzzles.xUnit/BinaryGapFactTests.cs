using BinaryGap;

namespace ProgrammingPuzzles.xUnit
{
    public class BinaryGapFactTests
    {
        [Fact]
        public void solution_ValueOf11_Returns1()
        {
            // Arrange
            var solution = new Solution();
            // Act
            var result = solution.solution(11);
            // Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void solution_ValueOf1041_Returns5()
        {
            // Arrange
            var solution = new Solution();
            // Act
            var result = solution.solution(1041);
            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void solution_ValueOf15_Returns0()
        {
            // Arrange
            var solution = new Solution();
            // Act
            var result = solution.solution(15);
            // Assert
            Assert.Equal(0, result);
        }

    }
}
