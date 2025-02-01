using Riok.Mapperly.Abstractions;

namespace FirstMapper;

[Mapper]
public partial class CarMapper
{
    public partial CarDto CarToCarDto(Car car);
}