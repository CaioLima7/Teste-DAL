using System;
using Business;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class ClienteTestes
    {
        private readonly Cliente cmd;

        [TestMethod]
        public void TestePesquisar()
        {
            var qtd = 1;

            var teste = cmd.Pesquisar();

            if(teste.Count != qtd)
            {

            }

            var resultadoEsperado = "Marcos";

            Assert.AreEqual(teste[0].Nome, resultadoEsperado);
            
        }
    }
}
