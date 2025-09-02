﻿using ConceitosBasicos.uteis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class TesteSomaDoisNumeros
    {
        [TestMethod]
        public void TestSomar()
        {
            //cenário
            int num1 = 20;
            int num2 = 22;
            int resultado = 42;
            SomaDoisNumeros somador = new SomaDoisNumeros();
            //ação
            resultado = somador.Somar(num1, num2);

            //verificação
            Assert.AreEqual(42, resultado);
        }
    }
}
