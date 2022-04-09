using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjFolhaPagamento2J
{
    class CalculoSalarioAposentado : ICalcularSalario
    {
        public int Cod { get; set; }
        public string Nome { get; set; }
        public CalculoSalarioAposentado(int Cod, string Nome)
        {
            this.Cod = Cod;
            this.Nome = Nome;
        }
        public double Calcular(double SalarioHora)
        {
            return 200 * SalarioHora;
        }
        public void imprimir()
        {
            Console.WriteLine("CODIGO DO INATIVO: {0}", Cod);
            Console.WriteLine("NOME DO FUNCIONARIO:   {0}", Nome);
        }
    }
}