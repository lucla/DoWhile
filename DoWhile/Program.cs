using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*A partir del dinero que tienes, 
 * y el interes que te van a dar
 marca tu objetivo y tendrás los
 años que tendrás que esperar.*/
namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance, porcentajeInteres, objetivo;
            Console.WriteLine("¿Cuánto dinero tienes?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Cuál es el % de interés anual?");
            porcentajeInteres = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("¿Cuánto dinero queires obtener?");
            objetivo = Convert.ToDouble(Console.ReadLine());
            int anosTotales = 0;
            do
            {
                balance *= porcentajeInteres;
                ++anosTotales;
            }
            while (balance < objetivo);
            //realizar una comprobación para ver si es singular o plural la palabra años
            Console.WriteLine($"En {anosTotales} año{(anosTotales == 1 ?"": "s")} tu tendrás un saldo de {balance}.");
            Console.ReadKey();
        }
    }
}
