using livroSEConsole.Models.DTO;
using System.Diagnostics;
using System.Linq.Expressions;

namespace livroSEConsole.Models.Acoes;

public class Acoes
{

    public Variavel CM_CriarVariavel(string p_nome, List<string> p_valores)
    {
        if (string.IsNullOrEmpty(p_nome) || p_valores == null)
            throw new Exception();

        Variavel c_variavel = new ();

        c_variavel.Nome = p_nome;
        c_variavel.Valores = p_valores;

        return c_variavel;
    }

    public void CM_CriarRegra(string p_nome, List<Variavel> p_variaveis, string p_condicao)
    {
        if (string.IsNullOrEmpty(p_nome) || p_variaveis == null)
            throw new Exception();

        Regra c_regra= new();
        c_regra.Nome = p_nome;
        c_regra.Variaveis = p_variaveis;

        int i = 0;

        Console.WriteLine("Escolha uma variavel:");
        foreach (var variavel in p_variaveis)
        {
            Console.WriteLine($"{i++} - {variavel.Nome}\n");
        }

        int m_indiceVariavel = 0;

        if (!int.TryParse(Console.ReadLine(), out m_indiceVariavel) || m_indiceVariavel < 1 || m_indiceVariavel > p_variaveis.Count)
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
            return;
        }

    }
}
