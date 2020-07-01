//Passo 1: Escrever um teste para obter um "vermelho"
//Passo 2: Escrever uma solução mínima para obter um "verde"
//Passo 3: Melhorar código para continuar no "verde" e retornar ao passo 1

//Critérios de Aceitação:
//Se a venda for menor ou igual a 10000, comissão de 5%
//Se a venda for maior que 10000, comissão de 6%

//Tiago Fernandos
// Ruben
// Margarida
// Luis
// Ana
// Pedro
// Ruben


using NUnit.Framework;

namespace com.br.k21.SistemaVendas.Testes
{
    public class TestesCalculadoraComissao
    {
        [Test]
        public void umaVendaDe8000RetornaComissaoDe400()
        {
            int valorVenda = 8000;
            double valorComissao = 400;

            double comissaoEsperado = new CalculadoraComisao().CalculateComission(valorVenda);

            Assert.AreEqual(valorComissao, comissaoEsperado);
        }

        [Test]
        public void umaVendaDe12000RetornaComissaoDe720()
        {
            int valorVenda = 12000;
            double valorComissao = 720;

            double comissaoEsperado = new CalculadoraComisao().CalculateComission(valorVenda);

            Assert.AreEqual(valorComissao, comissaoEsperado);
        }
    }
}
