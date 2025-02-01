namespace FirstMapper.FirstMapper;

public class FirstRun
{
    private const int NumberOfSeats = 4;

    public static void Execute()
    {
        var car = new Car { NumberOfSeats = NumberOfSeats };
        var mapper = new CarMapper();
        var dto = mapper.CarToCarDto(car);

        Console.WriteLine($"The number of seats in the car is {car.NumberOfSeats} is the same as the DTO {dto.NumberOfSeats}");
    }
}
