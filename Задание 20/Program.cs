using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        

        delegate double MуDelegate(double r);
        static void Main(string[] args)
        {

            MуDelegate mуDelegate = CircArea;
            Console.WriteLine(mуDelegate(5));

             mуDelegate = CircleLength;
            Console.WriteLine(mуDelegate(5));

             mуDelegate = SphereVolume;
            Console.WriteLine(mуDelegate(5));

            Console.ReadKey();
        }

        static double CircArea(double r)
              
        {
           Console.WriteLine("Длина окружности");
           return 2 *r*Math.PI;
                
        }
        static double CircleLength(double r)

        {
            Console.WriteLine("Площадь круга");
            return Math.Pow(r, 2) * Math.PI;

        }
        static double SphereVolume (double r)

        {
            Console.WriteLine("Объем шара");
            return Math.Pow(r, 3) * (4/3) * Math.PI;

        }
    }
    

        
}
