using EquationApi.Repositories;

namespace EquationApiTests.RepositoryTests
{
    public class EquationRepositoryTests
    {
        [Fact(DisplayName = "GetEquationsWithinThreshold")]
        public void Should_GetEquations_Provide_A_Certain_Number_Of_Questions()
        {
            //Arrange
            var equation = new EquationRepository();
            var expectedNumberOfEquations = 17;

            //Act
            var actualNumberOfEquations = equation.GetEquations(expectedNumberOfEquations).Count();

            //Assert
            Assert.Equal(expectedNumberOfEquations, actualNumberOfEquations);
        }

        [Fact(DisplayName = "GetEquationsAboveThreshold")]
        public void Should_GetEquations_Provide_A_Certain_Number_Of_Questions_When_Take_Is_Above_Threshold()
        {
            //Arrange
            var equation = new EquationRepository();
            var expectedNumberOfEquations = 10;
            var take = 899;

            //Act
            var actualNumberOfEquations = equation.GetEquations(take).Count();

            //Assert
            Assert.Equal(expectedNumberOfEquations, actualNumberOfEquations);
        }
    }
}
