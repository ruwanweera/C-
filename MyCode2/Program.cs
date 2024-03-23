namespace MyProject
{
    class Program
    {
        static void Main (string[] args)
        {
            string vegitable;
            int price;
            vegitable="Cabbage" +" Onion";
            price=100;
            Console.WriteLine("Vegitable name  " + vegitable + "  price is " +price);
            Console.WriteLine(vegitable.ToUpper());
            Console.WriteLine(vegitable.ToLower());
            Console.WriteLine(vegitable.Contains("Onion"));

        }
        
  


    }
}