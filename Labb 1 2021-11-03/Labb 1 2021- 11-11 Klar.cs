using System;

namespace Labb_1_2021_11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
             

            Circle Cir1 = new Circle(5);
            Circle Cir2 = new Circle(6);

            Console.WriteLine("Arean på en cirkel med radie" + Cir2._Radius + " är " + Cir2.getArea());
            Console.WriteLine("Arean på en cirkel med radie" + Cir1._Radius + " är " + Cir1.getArea());



        }
    }
}
