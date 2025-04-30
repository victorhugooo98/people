namespace People.API.Models;

public class Person
{
    public string Cpf { get; set; } = null!;
    public string Nome { get; set; } = null!;
    public string Genero { get; set; } = null!;
    public string Endereco { get; set; } = null!;
    public int Idade { get; set; }
    public string Municipio { get; set; } = null!;
    public string Estado { get; set; } = null!;
}