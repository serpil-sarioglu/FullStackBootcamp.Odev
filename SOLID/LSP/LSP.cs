namespace SOLID.LSP;

public interface IFlyable
{
    void Fly();
}

public abstract class Bird
{
    public abstract void Eat();    
    public abstract void Move();
    //public abstract void Fly();
   
}

public class Sparrow : Bird, IFlyable
{
    public override void Eat()
    {
        Console.WriteLine("Serçe yemek yiyor");
    }
    public void Fly()
    {
        Console.WriteLine("Serçe uçuyor");
    }

    public override void Move()
    {
        Fly();
    }
}

public class Ostrich : Bird
{
    public override void Eat()
    {
        Console.WriteLine("Devekuşu yemek yiyor");
    }
    public override void Move()
    {
        Console.WriteLine("Devekuşu koşuyor");
    }
}

public class BirdService
{
    public void MakeBirdFly(IFlyable bird)
    {
        bird.Fly();
    }
}

