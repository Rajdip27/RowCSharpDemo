namespace ListData.model;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; }=string.Empty;
    public Student()
    {
        Id = 1;
        Name = "Rajdip";
        Description = "Asp Dot Net";
    }
}
