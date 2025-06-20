using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejrc_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,suma;
            Console.WriteLine("Ingrese un numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            suma = num1;
            while (num1!=0)
            {
                Console.WriteLine("Ingrese otro numero: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                suma=suma + num1;
            }
            Console.WriteLine("La suma es:{0} " , suma);
        }
    }
}
