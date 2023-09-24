namespace UnneededContext;

public class User
{
    public User()
    {
        new User
        {
            Id = 1,
            Name = "Raja",
            Email = "Raja@gmail.com"
        };
    }
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; }= string.Empty;
    public override string ToString()=> $"Id={Id},Name={Name},Email={Email}";
}
