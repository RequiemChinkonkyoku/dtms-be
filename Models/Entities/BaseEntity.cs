using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Entities;

public class BaseEntity
{
    protected BaseEntity()
    {
        Id = Guid.NewGuid().ToString("N");
        CreatedTime = LastUpdatedTime = GetCurrentTime();
    }
    
    [Key]
    public string Id { get; set; }
    public DateTimeOffset CreatedTime { get; set; }
    public DateTimeOffset LastUpdatedTime { get; set; }
    
    protected DateTimeOffset GetCurrentTime()
    {
        DateTime serverTime = DateTime.UtcNow;
        TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Asia/Ho_Chi_Minh");
        DateTime _localTime = TimeZoneInfo.ConvertTimeFromUtc(serverTime, vietnamTimeZone);
        return _localTime;
    }
}