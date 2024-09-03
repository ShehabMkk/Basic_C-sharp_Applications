namespace Company.Data.Models;

public class BaseEntity
{
    public int Id { get; set; }
    public DateTime IsCreated { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; }
}