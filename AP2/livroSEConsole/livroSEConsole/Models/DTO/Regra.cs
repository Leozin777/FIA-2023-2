namespace livroSEConsole.Models.DTO;

public class Regra
{
    public string Nome { get; set; }
    public List<Variavel> Variaveis { get; set; }
    public Livro Livro { get; set; }
}
