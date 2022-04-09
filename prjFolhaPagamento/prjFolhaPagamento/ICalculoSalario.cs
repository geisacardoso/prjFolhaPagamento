using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace prjFolhaPagamento2J
{
    public interface ICalcularSalario
    {
        double Calcular(double SalarioHora); // assinattura
         void imprimir(); // assinatura
    }
}