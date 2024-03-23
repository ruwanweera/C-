namespace MyProject3;

public class Vegitable
{
    public string Name;
    public string growingArea;
    public double price;
    
    public Vegitable (string argName,string arggrowingArea,double argPrice)
    {
        Name = argName;
        growingArea = arggrowingArea;
        price = argPrice;

        Console.WriteLine("The vegitable  "+Name + " grow in  "+ growingArea+ "/n");
    }   


}
