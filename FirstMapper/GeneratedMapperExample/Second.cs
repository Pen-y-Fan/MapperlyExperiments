using FirstMapper.GeneratedMapperExample.Mapper;
using FirstMapper.GeneratedMapperExample.Source;

namespace FirstMapper.GeneratedMapperExample;

public class Second
{
    public static void Execute()
    {
        const CarColor color = CarColor.Black;
        var manufacturer = new Manufacturer(id: 1, name: "Ford");

        var car = new Car
        {
            Name = "Fiesta",
            NumberOfSeats = 5,
            Color = color,
            Manufacturer = manufacturer,
        };

        var dto = CarMapper.MapCarToDto(car);

        Console.WriteLine($"The number of seats in the car is {car.NumberOfSeats} is the same as the DTO {dto.NumberOfSeats}");
        Console.WriteLine($"The name of the car is {car.Name} is the same as the DTO {dto.Name}");
        Console.WriteLine($"The colour of the car is {car.Color.ToString()} is the same as the DTO {dto.Color.ToString()}");
        Console.WriteLine($"The manufacturer of the car is {car.Manufacturer.Name} is the same as the DTO {dto.Producer!.Name}");

    }
}
