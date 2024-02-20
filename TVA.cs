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

public class TVA
{
    private double taux ;
    public TVA(double taux2)
    {
        this.taux = taux2;
    }
    public void setTaux(double taux3)
    {
        this.taux = taux3;
    }
    public double getTaux()
    {
        return this.taux;
    }
}