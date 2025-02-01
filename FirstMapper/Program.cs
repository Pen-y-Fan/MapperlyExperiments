using FirstMapper;

const int numberOfSeats = 4;

var car = new Car { NumberOfSeats = numberOfSeats };
var mapper = new CarMapper();
var dto = mapper.CarToCarDto(car);

Console.WriteLine($"The number of seats in the car is {car.NumberOfSeats} is the same as the DTO {dto.NumberOfSeats}");
