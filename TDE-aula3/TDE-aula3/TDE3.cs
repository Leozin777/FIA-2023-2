using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDE_aula3
{
    public class TDE3
    {
        public void ex1()
        {
            Console.WriteLine("Digite a primeira entrada:");
            var ent1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda entrada:");
            var ent2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira entrada:");
            var ent3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro peso");
            var pes1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo peso");
            var pes2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro peso");
            var pes3 = double.Parse(Console.ReadLine());

            ResolveEquacao(ent1, ent2, ent3, pes1, pes2, pes3);
        }

        public void ex2()
        {
            Console.WriteLine("Digite a primeira entrada:");
            var ent1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro peso");
            var pes1 = double.Parse(Console.ReadLine());

            ResolveEquacao(ent1, pes1);
        }

        public void ex3()
        {
            Console.WriteLine("Esse metodo serve para resolver N entradas");

            Console.WriteLine("Quantas entradas vc deseja resolver ?");
            var numEntradas = int.Parse(Console.ReadLine());
            double resultadoSoma = 0;
            double ent = 0;
            double pes = 0;
            for (var i = 0; i < numEntradas; i++)
            {
                Console.WriteLine($"Digite a entrada numero {i + 1}");
                ent = double.Parse(Console.ReadLine());

                Console.WriteLine($"Digite o peso numero {i + 1}");
                pes = double.Parse(Console.ReadLine());

                resultadoSoma += Soma(ent , pes);
            }

            var ResultLS1 = LS(resultadoSoma);
            var ResultFR1 = FR(resultadoSoma);
            var ResultFS1 = FS(resultadoSoma);

            Console.WriteLine();
            Console.WriteLine($"""
                               Resultado da primeira parte:
                               SOMA = {resultadoSoma}
                               LS = {ResultLS1}
                               FR = {ResultFR1}
                               FS:{ResultFS1}
                               """);
        }

        void ResolveEquacao(double p_entrada1, double p_entrada2, double p_entrada3, double p_peso1, double p_peso2, double p_peso3)
        {
            double resultadoSoma = Soma(p_entrada1, p_entrada2, p_entrada3, p_peso1, p_peso2, p_peso3);

            var ResultLS = LS(resultadoSoma);
            var ResultFR = FR(resultadoSoma);
            var ResultFS = FS(resultadoSoma);

            Console.WriteLine();
            Console.WriteLine($"""
                       Resultados: 
                       SOMA = {resultadoSoma}
                       LS = {ResultLS}
                       FR = {ResultFR}
                       FS:{ResultFS}
                       """);
        }

        void ResolveEquacao(double p_entrada1, double p_peso1)
        {
            double resultadoSoma = Soma(p_entrada1, p_peso1);

            var ResultLS1 = LS(resultadoSoma);
            var ResultFR1 = FR(resultadoSoma);
            var ResultFS1 = FS(resultadoSoma);

            Console.WriteLine();
            Console.WriteLine($"""
                               Resultado da primeira parte:
                               SOMA = {resultadoSoma}
                               LS = {ResultLS1}
                               FR = {ResultFR1}
                               FS:{ResultFS1}
                               """);

            var ResultLS2 = LS(ResultLS1);
            var ResultFR2 = FR(ResultFR1);
            var ResultFS2 = FS(ResultFS1);

            Console.WriteLine();
            Console.WriteLine($"""
                               Resultado da primeira parte:
                               SOMA = {resultadoSoma}
                               LS = {ResultLS2}
                               FR = {ResultFR2}
                               FS:{ResultFS2}
                               """);

        }


        double LS(double s)
        {
            if (s <= 0)
                return -1;
            else
                return 1;
        }

        double FR(double s)
        {
            if (s < 0)
                return 0;
            else if (0 <= s && s <= 1)
                return s;
            else
                return 1;
        }

        double FS(double s)
        {
            if (s >= 0)
                return 1 - 1 / (1 + s);
            else
                return -1 + 1 / (1 - s);
        }

        double Soma(double p_entrada1, double p_entrada2, double p_entrada3, double p_peso1, double p_peso2, double p_peso3)
        {
            return (p_entrada1 * p_peso1) + (p_entrada2 * p_peso2) + (p_entrada3 * p_peso3);
        }

        double Soma(double p_entrada1, double p_peso1)
        {
            return (p_entrada1 * p_peso1);
        }

    }
}
