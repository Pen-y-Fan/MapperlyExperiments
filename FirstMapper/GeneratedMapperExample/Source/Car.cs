namespace FirstMapper.GeneratedMapperExample.Source;

public class Car
{
    public string Name { get; set; } = string.Empty;

    public int NumberOfSeats { get; set; }

    public CarColor Color { get; set; }

    public Manufacturer? Manufacturer { get; set; }

    public List<Tire> Tires { get; } = [];
}
