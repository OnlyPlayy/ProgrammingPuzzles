using CyclicRotationsNamespace;

namespace ProgrammingPuzzles.xUnit
{
    public class CyclicRotationFactTests
    {
        [Fact]
        public void solution_ValueOf3_8_9_7_6_Mod3_Returns9_7_6_3_8()
        {
            // Arrange
            var cyclicRotations = new CyclicRotations();
            var input = new int[] { 3, 8, 9, 7, 6 };
            int mod = 3;
            // Act
            var result = cyclicRotations.solution(input, mod);
            // Assert
            Assert.Equal(new int[] { 9, 7, 6, 3, 8 }, result);
        }

        [Fact]
        public void solution_ValueOf1_2_3_4_Mod4_Returns1_2_3_4()
        {
            // Arrange
            var cyclicRotations = new CyclicRotations();
            var input = new int[] { 1, 2, 3, 4 };
            int mod = 4;
            // Act
            var result = cyclicRotations.solution(input, mod);
            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4 }, result);
        }

        [Fact]
        public void solution_ValueOf0_0_0_Mod1_Returns0_0_0()
        {
            // Arrange
            var cyclicRotations = new CyclicRotations();
            var input = new int[] { 0, 0, 0 };
            int mod = 1;
            // Act
            var result = cyclicRotations.solution(input, mod);
            // Assert
            Assert.Equal(new int[] { 0, 0, 0 }, result);
        }

        [Fact]
        public void solution_ValueOf1_2_3_4_5_Mod4_Returns2_3_4_5_1()
        {
            // Arrange
            var cyclicRotations = new CyclicRotations();
            var input = new int[] { 1, 2, 3, 4, 5 };
            int mod = 4;
            // Act
            var result = cyclicRotations.solution(input, mod);
            // Assert
            Assert.Equal(new int[] { 2, 3, 4, 5, 1 }, result);
        }
    }
}
