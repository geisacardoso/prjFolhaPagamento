using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjFolhaPagamento2J
{
    class MainClass
    {
        static List<ICalcularSalario> Empregados;
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Empregados = new List<ICalcularSalario>();
            Empregados.Add(new CaculoSalarioEmpregado(1, "JOAQUIM DA SILVA", 200));
            Empregados.Add(new CalculoSalarioAposentado(2, "JORGE ANTONIO"));
            Empregados.Add(new CalculoSalarioEstagiario(3, "ASPIRA DE OLIVEIRA", 170, 150));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Empregados.ForEach(i => Imprimir(i));
            Console.ReadKey();
        }
        public static void Imprimir(ICalcularSalario emp)
        {
            emp.imprimir();
            Console.WriteLine("Salario Bruto: {0:C2}\n", emp.Calcular(18));
        }
    }
}