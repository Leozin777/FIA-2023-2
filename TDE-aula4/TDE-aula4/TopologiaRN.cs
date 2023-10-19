namespace TDE_aula4;

public class TopologiaRN
{
    const int c = 1;
    double[] entrada1 = { 1, 1 };
    double[] entrada2 = { 1, 0 };
    double[] entrada3 = { 0, 1 };
    double[] entrada4 = { 0, 0 };

    double[] saida1 = { 1 };
    double[] saida2 = { 1 };
    double[] saida3 = { 0 };
    double[] saida4 = { 0 };

    double[] pesos = { -1, -1 };

    public double FuncaoRampa(double valor)
    {
        if (valor <= 0)
            return 0;
        else if (valor >= 1)
            return 1;
        else
            return valor;
    }

    public double Soma(double[] entradas, double[] pesos)
    {
        double soma = 0;
        for (var i = 0; i < entradas.Length; i++)
        {
            soma += entradas[i] * pesos[i];
        }

        return soma;
    }

    public double Erro(double saida, double resultado)
    {
        return saida * resultado;
    }

    public void treinamento()
    {
        var soma1 = Soma(entrada1, pesos);
        var resultado1 = FuncaoRampa(soma1);
        
    }
}

