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

        [Fact]
        public void Duration_isZero_ShouldThrowException()
        {
            //Arrange
            MachinePowerCalculator machinePowerCalculator = new MachinePowerCalculator();

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() => machinePowerCalculator.GetPowerConsumption("machineType", 0, false));

            //Assert
            Assert.Equal("Duration must be greater than zero.", exception.Message);
        }

        [Fact]
        public void Duration_isNegative_ShouldThrowException()
        {
            //Arrange
            MachinePowerCalculator machinePowerCalculator = new MachinePowerCalculator();

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() => machinePowerCalculator.GetPowerConsumption("machineType", -1, false));

            //Assert
            Assert.Equal("Duration must be greater than zero.", exception.Message);
        }

        [Fact]
        public void MachineType_isMillingMachine_ShouldReturn5Duration()
        {
            //Arrange
            MachinePowerCalculator machinePowerCalculator = new MachinePowerCalculator();

            //Act
            double result1 = machinePowerCalculator.GetPowerConsumption("MillingMachine", 1, false);
            double result2 = machinePowerCalculator.GetPowerConsumption("MillingMachine", 4, false);
            double result3 = machinePowerCalculator.GetPowerConsumption("MillingMachine", 10, false);

            //Assert
            Assert.Equal(5, result1);
            Assert.Equal(10, result2);
            Assert.Equal(50, result3);
        }

        public void MachineType_isPress_ShouldReturn5Duration()
        {
            //Arrange
            MachinePowerCalculator machinePowerCalculator = new MachinePowerCalculator();

            //Act
            double result1 = machinePowerCalculator.GetPowerConsumption("Press", 1, false);
            double result2 = machinePowerCalculator.GetPowerConsumption("Press", 4, false);
            double result3 = machinePowerCalculator.GetPowerConsumption("Press", 10, false);

            //Assert
            Assert.Equal(7.2, result1);
            Assert.Equal(7.2*4, result2);
            Assert.Equal(7.2*10, result3);
        }

        public void MachineType_isUnknown_ShouldThrowException()
        {
            //Arrange
            MachinePowerCalculator machinePowerCalculator = new MachinePowerCalculator();

            //Act
            ArgumentException exception = Assert.Throws<ArgumentException>(() => machinePowerCalculator.GetPowerConsumption("unknownType", 1, false));

            //Assert
            Assert.Equal("Invalid machine type.", exception.Message);
        }
    }
}