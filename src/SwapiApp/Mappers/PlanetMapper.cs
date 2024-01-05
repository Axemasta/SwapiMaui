using Riok.Mapperly.Abstractions;
using SwapiApp.Models.Dto;

namespace SwapiApp.Mappers;

[Mapper]
public partial class PlanetMapper
{
    public static partial Planet FromDto(PlanetDto dto);
}