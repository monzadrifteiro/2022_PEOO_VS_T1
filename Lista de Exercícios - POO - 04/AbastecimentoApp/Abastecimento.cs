using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastecimentoApp
{
    internal class Abastecimento
    {
        private double valorLitro, valorPago, kmRodados;
        public void SetValorLitro(double vl)
        {
            if (vl > 0) valorLitro = vl;
        }
        public void SetValorPago(double vp)
        {
            if (vp > 0) valorPago = vp;
        }
        public void SetKmRodados(double kr)
        {
            if (kr > 0) kmRodados = kr;
        }
        public double MediaKmLitro() => kmRodados / (valorPago / valorLitro);
        public double MediaReaisKm() => valorPago / kmRodados;

    }
}