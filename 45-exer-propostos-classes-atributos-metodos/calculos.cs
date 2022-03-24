using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_exer_propostos_classes_atributos_metodos
{
    class calculos
    {

        public double Altura;
        public double Largura;

        public double Area()
        {

            return Altura * Largura;

        } 

        public double Perimetro()
        {

            return 2 * (Altura + Largura);

        }

        public double Diagonal()
        {

            return Math.Sqrt(Altura * Altura + Largura * Largura);

        }

    }
}
