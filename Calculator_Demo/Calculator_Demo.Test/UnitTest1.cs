namespace Calculator_Demo.Test
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void TwoInput_Addition_AddedResult()
        {
            // Arrange
            float input1 = 10;
            float input2 = 5;
            float expectedAnswer = 15;
            Calculator calci = new Calculator();

            // Act
            var answer = calci.Addition(input1, input2);

            // Assert
            Assert.Equal(15,answer);
        }

        [Fact]
        public void TwoInput_Subtraction_SutractedResult()
        {
            // Arrange
            float input1 = 10;
            float input2 = 5;
            float expectedAnswer = 5;
            Calculator calci = new Calculator();

            // Act
            var answer = calci.Subtraction(input1, input2);

            // Assert
            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void TwoInput_Multiplication_MultipliedResult()
        {
            // Arrange
            float x = 10;
            float y = 5;
            float expectedAnswer = 50;
            Calculator calci = new Calculator();

            // Act
            var answer = calci.Multiplication(x, y);

            // Assert
            Assert.Equal(expectedAnswer, answer);
        }

        [Fact]
        public void TwoInput_Division_DividedResult()
        {
            // Arrange
            float x = 10;
            float y = 5;
            float expectedAnswer = 2;
            Calculator calci = new Calculator();

            // Act
            var answer = calci.Division(x, y);

            // Assert
            Assert.Equal(expectedAnswer, answer);
        }
    }
}