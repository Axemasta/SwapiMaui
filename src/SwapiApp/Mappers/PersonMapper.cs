using Riok.Mapperly.Abstractions;
using SwapiApp.Models.Dto;

namespace SwapiApp.Mappers;

[Mapper]
public partial class PersonMapper
{
    public static partial Person FromDto(PeopleDto dto);
}