using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjFolhaPagamento2J
{
    class CaculoSalarioEmpregado : ICalcularSalario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public double HorasTrabalhadas { get; set; }
        public CaculoSalarioEmpregado(int Cod, string Nome, double HorasTrabalhadas)
        {
            this.Cod = Cod;
            this.Nome = Nome;
            this.HorasTrabalhadas = HorasTrabalhadas;
        }
        public double Calcular(double SalarioHora)
        {
            return HorasTrabalhadas * SalarioHora;
        }
        public void imprimir()
        {
            Console.WriteLine("CODIGO DO FUNCIONARIO: {0}", Cod);
            Console.WriteLine("NOME DO FUNCIONARIO:   {0}", Nome);
            Console.WriteLine("NUM DE HORAS TRABALHADAS:   {0} HORAS", HorasTrabalhadas);
        }
    }
}