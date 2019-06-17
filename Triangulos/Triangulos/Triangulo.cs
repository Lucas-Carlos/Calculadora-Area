using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    class Triangulo
    {
        //Atributos da calculadora relacionada à triângulos.
        private double ladoA;
        private double ladoB;
        private double ladoC;

        //Encapsulação dos atributos.
        public double LadoA { get => ladoA; set => ladoA = value; }
        public double LadoB { get => ladoB; set => ladoB = value; }
        public double LadoC { get => ladoC; set => ladoC = value; }

        /*Métodos da calculadora de triângulos.*/
        //Método de calcular a área do triângulo.
        public double CalcularArea()
        {
            double p = (ladoA + ladoB + ladoC) / 2;
            double area = Math.Sqrt(((p * p) - (p * ladoA)) * ((p * p - p * ladoC) - (ladoB * p) + (ladoB * ladoC)));

            return (area);
        }

        //Método de calcular o perímetro do triângulo.
        public double CalcularPerimetro()
        {
            return (this.ladoA + this.ladoB + this.ladoC);
        }
    }
}
