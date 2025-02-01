using Riok.Mapperly.Abstractions;
using FirstMapper.GeneratedMapperExample.Source;
using FirstMapper.GeneratedMapperExample.TargetDto;

namespace FirstMapper.GeneratedMapperExample.Mapper;

// Enums of source and target have different numeric values -> use ByName strategy to map them
[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName)]
public static partial class CarMapper
{
    // Map property with a different name in the target type
    [MapProperty(nameof(Car.Manufacturer),nameof(CarDto.Producer))]
    public static partial CarDto MapCarToDto(Car car);
}
