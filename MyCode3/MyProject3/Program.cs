// See https://aka.ms/new-console-template for more information
using System;
namespace MyProject3
{
    class Program
    {
        static void Main(string[] args)
        {
                double rate=25;
                Vegitable vegi =new Vegitable("Cabbage", "Colombo",29.75);
                
                Vegitable vegi2 =new Vegitable("Carrot", "Kandy",rate);

                

                Console.WriteLine(vegi.Name+ " grown in  " +vegi.growingArea + " price of 1Kg cost Rs " + vegi.price);
                vegi2.price =2*rate;

               Console.WriteLine(vegi2.Name+ " grown in  " +vegi2.growingArea + " price of 1Kg cost Rs " + vegi2.price);

                
        }

    }

}





