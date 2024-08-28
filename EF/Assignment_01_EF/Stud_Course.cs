using Microsoft.EntityFrameworkCore;

namespace Assignment_01_EF;
[Keyless]
public class Stud_Course
{
    public int Stud_Id { get; set; }
    public int Course_Id { get; set; }
    public string? Grade { get; set; }

    public Student Student { get; set; }
    public Course Course { get; set; }
}
