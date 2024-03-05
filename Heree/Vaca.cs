using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heree
{
    internal class Vaca: Mamifero
    {
        private double LitLeche { get; set; }

        public Vaca() : base("", 0)
        {
            Console.WriteLine("Ingrese los litros de leche");
            LitLeche = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el peso");
            peso = double.Parse(Console.ReadLine());
        }

        public Vaca(string n, double p, int l) : base(n, p)
        {
            this.LitLeche = l;
        }

        public void CalcularCanComida()
        {
            double kiloscomida = 0;
            kiloscomida = peso / (2 * LitLeche);
            Console.WriteLine("La cantidad de comida es:" + kiloscomida);

        }
        public void mostrarvaca()
        {
            Console.WriteLine("Clase Vaca");
            Console.WriteLine("Peso: " + peso);
            Console.WriteLine("Litros de leche: " + LitLeche);
        }
    }
}
