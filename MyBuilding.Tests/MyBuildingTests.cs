using MyBuilding;

namespace MyBuilding.Tests
{
    public class MyBuildingTests
    {
        [Fact]
        public void BaseHelper1_CalculateTotalCost_ReturnsCorrectValue()
        {
            // Arrange
            var building = new BaseHelper1();
            building.Init(100, 10);

            // Act
            var totalCost = building.CalculateTotalCost();

            // Assert
            Assert.Equal(1000, totalCost);
        }

        [Fact]
        public void DerivedHelper1_CalculateTotalCost_ReturnsCorrectValue()
        {
            // Arrange
            var building = new DerivedHelper1();
            building.Init(100, 10, 5);

            // Act
            var totalCost = building.CalculateTotalCost();

            // Assert
            Assert.Equal(1000, totalCost);
        }

        [Fact]
        public void BaseHelper2_CalculateTotalCost_ReturnsCorrectValue()
        {
            // Arrange
            var building = new BaseHelper2();
            building.Init(100, 10);

            // Act
            var totalCost = building.CalculateTotalCost();

            // Assert
            Assert.Equal(1000, totalCost);
        }

        [Fact]
        public void DerivedHelper2_CalculateTotalCost_ReturnsCorrectValue()
        {
            // Arrange
            var building = new DerivedHelper2();
            building.Init(100, 10, 5);

            // Act
            var totalCost = building.CalculateTotalCost();

            // Assert
            Assert.Equal(1000, totalCost);
        }

        [Fact]
        public void DerivedBuilding1_CalculateTotalCost_ReturnsCorrectValue()
        {
            // Arrange
            var building = new DerivedBuilding1();
            building.Init(100, 10);

            // Act
            var totalCost = building.CalculateTotalCost();

            // Assert
            Assert.Equal(1000, totalCost);
        }

        [Fact]
        public void DerivedBuilding2_CalculateTotalCost_ReturnsCorrectValue()
        {
            // Arrange
            var building = new DerivedBuilding2();
            building.Init(100, 10);

            // Act
            var totalCost = building.CalculateTotalCost();

            // Assert
            Assert.Equal(1000, totalCost);
        }

        [Fact]
        public void DerivedBuilding3_CalculateTotalCost_ReturnsCorrectValue()
        {
            // Arrange
            var building = new DerivedBuilding3();
            building.Init(100, 10);

            // Act
            var totalCost = building.CalculateTotalCost();

            // Assert
            Assert.Equal(1000, totalCost);
        }

        [Fact]
        public void BaseHelper1_Display_WritesToConsole()
        {
            // Arrange
            var building = new BaseHelper1();
            building.Init(100, 10);

            // Act & Assert
            Assert.Null(Record.Exception(() => building.Display()));
        }

        [Fact]
        public void DerivedHelper1_Display_WritesToConsole()
        {
            // Arrange
            var building = new DerivedHelper1();
            building.Init(100, 10, 5);

            // Act & Assert
            Assert.Null(Record.Exception(() => building.Display()));
        }

        [Fact]
        public void BaseHelper2_Display_WritesToConsole()
        {
            // Arrange
            var building = new BaseHelper2();
            building.Init(100, 10);

            // Act & Assert
            Assert.Null(Record.Exception(() => building.Display()));
        }
    }
}