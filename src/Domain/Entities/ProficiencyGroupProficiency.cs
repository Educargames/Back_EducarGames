using Educar.Backend.Infrastructure.Data;

namespace Educar.Backend.Domain.Entities;

public class ProficiencyGroupProficiency: ISoftDelete
{
    public Guid ProficiencyGroupId { get; set; }
    public ProficiencyGroup ProficiencyGroup { get; set; } = null!;

    public Guid ProficiencyId { get; set; }
    public Proficiency Proficiency { get; set; } = null!;
    
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}