using System;

namespace _45_exer_propostos_classes_atributos_metodos
{
    class Program
    {
        static void Main(string[] args)
        {

            calculos j = new calculos();
            
            Console.WriteLine("Digite a altura do retangulo ");
            j.Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a largura do retangulo");
            j.Largura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Altura do retangulo: {0}", j.Altura);
            Console.WriteLine("Largura do retangulo: {0}", j.Largura);

            Console.WriteLine("Area: {0}",j.Area());
            Console.WriteLine("Perimetro: {0}",j.Perimetro());
            Console.WriteLine("Diagonal: {0}", j.Diagonal());



        }
    }
}
