using Educar.Backend.Application.Queries.Class;
using Educar.Backend.Application.Queries.Client;
using Educar.Backend.Application.Queries.School;
using Educar.Backend.Domain.Enums;

namespace Educar.Backend.Application.Queries.Account;

public class AccountDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? RegistrationNumber { get; set; }
    public decimal AverageScore { get; set; }
    public decimal EventAverageScore { get; set; }
    public int Stars { get; set; }

    public ClientCleanDto? Client { get; set; }
    public UserRole Role { get; set; }
    public SchoolDto? School { get; set; }
    public IList<ClassDto> Classes { get; set; } = new List<ClassDto>();

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Domain.Entities.Account, AccountDto>()
                .ForMember(dest => dest.Classes, opt => opt.MapFrom(src => src.AccountClasses
                    .OrderBy(ac => ac.Class.Name)
                    .Take(20) //limit to only 20 results to avoid performance issues
                    .Select(ac => ac.Class)));
        }
    }
}