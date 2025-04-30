using Microsoft.AspNetCore.Mvc;
using People.API.Models;

namespace People.API.Controllers;

[ApiController]
[Route("api/pessoas")]
public class PeopleController : ControllerBase
{
    private readonly List<Person> _pessoas;

    public PeopleController()
    {
        // Lista mockada com 30 registros
        _pessoas = [];

        // Nomes e sobrenomes para gerar dados aleatórios
        string[] names =
            ["Ana", "Carlos", "Mariana", "João", "Pedro", "Luciana", "Rafael", "Fernanda", "Bruno", "Camila"];
        string[] surnames =
        [
            "Silva", "Santos", "Oliveira", "Pereira", "Souza", "Costa", "Ferreira", "Rodrigues", "Almeida", "Carvalho"
        ];
        string[] genders = ["Masculino", "Feminino"];
        string[] streets = ["Rua das Flores", "Av. Paulista", "Rua 7 de Setembro", "Av. Brasil", "Rua XV de Novembro"];
        string[] cities =
            ["São Paulo", "Campinas", "Santos", "Ribeirão Preto", "São José dos Campos", "Sorocaba"];
        string[] states = ["SP", "RJ", "MG", "PR", "SC", "RS"];

        var random = new Random();

        for (var i = 0; i < 30; i++)
        {
            var nome = names[random.Next(names.Length)];
            var surname = surnames[random.Next(surnames.Length)];
            var gender = genders[random.Next(genders.Length)];
            var age = random.Next(20, 60);
            var street = streets[random.Next(streets.Length)] + ", " + random.Next(1, 1000);
            var city = cities[random.Next(cities.Length)];
            var state = states[random.Next(states.Length)];

            // Gera CPF aleatório (apenas para exemplo - não é um CPF válido)
            var cpf = string.Empty;
            for (var j = 0; j < 11; j++) cpf += random.Next(0, 10).ToString();

            _pessoas.Add(new Person
            {
                Cpf = cpf,
                Nome = $"{nome} {surname}",
                Genero = gender,
                Endereco = street,
                Idade = age,
                Municipio = city,
                Estado = state
            });
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<Person>> Get()
    {
        return Ok(_pessoas);
    }
}