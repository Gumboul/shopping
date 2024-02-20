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
public class Produit
{
    private string nom ;
    public Produit(string Produit2)
    {
        this.nom=Produit2;
    }
    public void setProduit (string Produit3)
    {
        this.nom=Produit3;
    }
    public string getProduit()
    {
        return this.nom;
    }
}