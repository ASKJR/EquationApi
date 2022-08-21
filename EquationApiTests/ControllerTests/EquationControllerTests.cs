using EquationApi.Controllers;
using Microsoft.Extensions.Logging;
using NSubstitute;

namespace EquationApiTests.ControllerTests
{
    public class EquationControllerTests
    {
        [Fact(DisplayName = "mainFlow")]
        public void Should_EquationController_Run_Main_Flow()
        {
            //Arrange
            var logger = Substitute.For<ILogger<EquationController>>();
            var controller = new EquationController(logger);
            var expectedNumberOfEquations = 12;

            //Act
            var actualNumberOfEquations = controller.Get(expectedNumberOfEquations);

            //Assert
            Assert.Equal(expectedNumberOfEquations, actualNumberOfEquations.Count());
        }
    }
}
