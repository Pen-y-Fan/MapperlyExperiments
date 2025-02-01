using FirstMapper;
using Xunit;
using Shouldly;

namespace FirstMapper.Tests

    public class CarMapperTests
    {
        [Fact]
        public void CarToCarDto_ShouldMapNumberOfSeatsCorrectly()
        {
            // Arrange
            const int numberOfSeats = 4;
            var car = new Car { NumberOfSeats = numberOfSeats };
            var mapper = new CarMapper();

            // Act
            var dto = mapper.CarToCarDto(car);

            // Assert
            dto.NumberOfSeats.ShouldBe(numberOfSeats, "The number of seats in the Car should match the DTO.");
        }
    }
