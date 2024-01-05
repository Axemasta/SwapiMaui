using Riok.Mapperly.Abstractions;
using SwapiApp.Models.Dto;

namespace SwapiApp.Mappers;

[Mapper]
public partial class FilmMapper
{
    public static partial Film FromDto(FilmDto dto);

    public static partial List<Film> FromDtos(List<FilmDto> dtos);
}