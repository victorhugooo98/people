namespace People.API.Models;

public class Person
{
    public string Cpf { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Gender { get; set; } = null!;
    public string Address { get; set; } = null!;
    public int Age { get; set; }
    public string City { get; set; } = null!;
    public string State { get; set; } = null!;
}