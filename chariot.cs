using System;

public class Helloworld
{
    public static void Main(string[] args)
    {
        TVA t5 = new TVA(5);
        Console.WriteLine (t5);
        TVA t10 = new TVA(10);
        Console.WriteLine (t10);
        TVA t20 = new TVA(20);
        Console.WriteLine (t20);
    }
}
public class Chariot 
{
    private Produit[] sommeprod ;
    public Chariot()
    {
        this.sommeprod=new Produit[50];
    }
}