using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjFolhaPagamento2J
{
    class CalculoSalarioEstagiario : ICalcularSalario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double HorasTrabalhadas { get; set; }
        public double Auxilio { get; set; }
        public CalculoSalarioEstagiario(int Cod, string Nome, double HorasTrabalhadas,
            double Auxilio)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.HorasTrabalhadas = HorasTrabalhadas;
            this.Auxilio = Auxilio;
        }
        public double Calcular(double SalarioHora)
        {
            if (HorasTrabalhadas > 80)
            {
                HorasTrabalhadas = 80;
            }
            SalarioHora = SalarioHora * 0.5;
            return (HorasTrabalhadas * SalarioHora) + Auxilio;
        }
        public void imprimir()
        {
            Console.WriteLine("CODIGO DO FUNCIONARIO: {0}", Cod);
            Console.WriteLine("NOME DO ESTAGIÁRIO:   {0}", Nome);
            Console.WriteLine("NUM DE HORAS TRABALHADAS:   {0} HORAS", HorasTrabalhadas);
            Console.WriteLine("AUXILIO TRANSPORTE:   {0:C2}", Auxilio);
        }
    }
}