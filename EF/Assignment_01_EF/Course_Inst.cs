using Microsoft.EntityFrameworkCore;

namespace Assignment_01_EF;
[Keyless]
public class Course_Inst
{
    public int Inst_Id { get; set; }
    public int Course_Id { get; set; }
    public string? Evaluate { get; set; }
    
    public Instructor Instructor { get; set; }
    public Course Course { get; set; }
    
}
