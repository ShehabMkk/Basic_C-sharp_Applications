namespace Assignment_01_EF;

public class Course
{
    public int Id { get; set; }
    public string? Duration { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Top_Id { get; set; }
    
    public Topic Topic { get; set; }
    public ICollection<Stud_Course> Stud_Courses { get; set; }
    public ICollection<Course_Inst> Course_Insts { get; set; }
}
