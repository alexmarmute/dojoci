using System;
using System.Security.Cryptography.X509Certificates;

namespace com.br.k21.SistemaVendas.Testes
{
    public class CalculadoraComisao
    {
        const int choosenSaleValue = 10000;
        const double taxLow = 0.05;
        const double taxHigh = 0.06;

        public double CalculateComission(int saleValue)
        {
            if (saleValue <= choosenSaleValue)
            {
                return saleValue * taxLow;
            }
            else
            {
                return saleValue * taxHigh;
            }
        }
    }
}