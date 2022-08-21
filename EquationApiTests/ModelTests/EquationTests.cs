using EquationApi.Models;

namespace EquationApiTests.ModelTests
{
    public class EquationTests
    {

        [Fact(DisplayName = "ValidEquation")]
        public void Equation_Model_Should_Provide_A_Valid_Equation()
        {
            //Arrange
            var equation = new Equation();

            //Act
            var actualAnswer = equation.Operator switch
            {
                "+" => equation.NumberOne + equation.NumberTwo,
                "-" => equation.NumberOne - equation.NumberTwo,
                "*" => equation.NumberOne * equation.NumberTwo,
                _ => -1,
            };

            //Assert
            Assert.Equal(equation.Answer, actualAnswer);
        }

    }
}
