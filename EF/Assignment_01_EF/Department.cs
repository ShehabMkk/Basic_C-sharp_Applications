using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Assignment_01_EF;

public class Department
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime HiringDate { get; set; }

    public Instructor Instructor { get; set; }
    public ICollection<Student> Students { get; set; }
}
