using Educar.Backend.Infrastructure.Data;

namespace Educar.Backend.Domain.Entities;

public class QuestStepMedia : ISoftDelete
{
    public Guid QuestStepId { get; set; }
    public QuestStep QuestStep { get; set; } = null!;

    public Guid MediaId { get; set; }
    public Media Media { get; set; } = null!;

    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
}