using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_01_EF;

public class Instructor
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Salary { get; set; }
    public string? Address { get; set; }
    public double HourRate { get; set; }
    public int? Dept_Id { get; set; }
    
    public Department Department { get; set; }
    public ICollection<Course_Inst> Course_Insts { get; set; }
}
