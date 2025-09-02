using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class TesteCalculaAumento
    {
        [TestMethod]
        public void TestCalcular()
        {
            //cenario
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            float percentual = float.Parse(Console.ReadLine());
            decimal aumento;
            

            CalculaAumento calculador = new CalculaAumento();

            //ação
            aumento = calculador.Calcular(salario, percentual);

            //verificação
            

        }
    }
}
