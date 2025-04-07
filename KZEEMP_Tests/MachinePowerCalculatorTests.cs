using KZEEMP;

namespace KZEEMP_Tests
{
    public class MachinePowerCalculatorTests
    {
        [Fact]
        public void MachineType_isNull_ShouldThrowException()
        {
            //Arrange
            MachinePowerCalculator machinePowerCalculator = new MachinePowerCalculator();

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() => machinePowerCalculator.GetPowerConsumption(null, 0, false));

            //Assert
            Assert.Equal("Machine type cannot be empty.", exception.Message);
        }

        [Fact]
        public void MachineType_isEmpty_ShouldThrowException()
        {
            //Arrange
            MachinePowerCalculator machinePowerCalculator = new MachinePowerCalculator();

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() => machinePowerCalculator.GetPowerConsumption("", 0, false));

            //Assert
            Assert.Equal("Machine type cannot be empty.", exception.Message);
        }
    }
}