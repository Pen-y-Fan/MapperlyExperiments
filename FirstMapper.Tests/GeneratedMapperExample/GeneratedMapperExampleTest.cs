using FirstMapper.GeneratedMapperExample.Source;
using FirstMapper.GeneratedMapperExample.TargetDto;
using FirstMapper.GeneratedMapperExample.Mapper;
using Shouldly;

namespace FirstMapper.Tests.GeneratedMapperExample;

public class GeneratedMapperExampleTest
{
    [Fact]
    public void MapCarToDto_ShouldCorrectlyMapCarWithBlackColor()
    {
        // Arrange
        const CarColor color = CarColor.Black;
        var manufacturer = new Manufacturer(id: 1, name: "Ford");

        var car = new Car
        {
            Name = "Fiesta",
            NumberOfSeats = 5,
            Color = color,
            Manufacturer = manufacturer,
        };

        // Act
        var dto = CarMapper.MapCarToDto(car);

        // Assert
        dto.Color.ShouldBe(CarColorDto.Black, "The color in the Car should correctly map to the DTO.");
        dto.Name.ShouldBe("Fiesta", "The name in the Car should correctly map to the DTO.");
        dto.Producer!.Name.ShouldBe("Ford", "The manufacture name in the Car should correctly map to the DTO.");
        dto.NumberOfSeats.ShouldBe(5, "The number of seats in the Car should correctly map to the DTO.");
    }

    [Fact]
    public void MapCarToDto_ShouldThrowForWhiteColor()
    {
         // Arrange
        const CarColor color = CarColor.White;
        var car = new Car { Color = color };

        // Act & Assert
        Should.Throw<ArgumentException>(() => CarMapper.MapCarToDto(car))
            .Message.ShouldStartWith("The value of enum CarColor is not supported (Parameter 'source'");
    }
}
