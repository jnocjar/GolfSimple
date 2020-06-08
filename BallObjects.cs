using System;
using GolfObjects;

public class BallObject : GolfObject
{
    public BallObject(string ballTypeName = "Base") : base("Ball")
    {
        _ballTypeName = ballTypeName;
        SetBallAttributes(0,0,0);
    }

    public virtual void Fly()
    {
        Console.WriteLine($"Flying {ToString()}");
    }

    public virtual void Roll()
    {
        Console.WriteLine($"Rolling {ToString()}");
    }

    public string get_name() { return base._name;}

    // Use ToString to identify the type.
    public override string ToString()
    {   
        return $"{_ballTypeName} {get_name()}";

    protected string _ballTypeName;

    protected int _hardness;
    protected int _touch;
    protected int _spin;

    public void SetBallAttributes(int hardness = 5, int touch = 5, int spin = 5)
    {
        _hardness = hardness;
        _touch = touch;
        _spin = spin;
    }
}

public class BallObjectMaxfli : BallObject
{
    public BallObjectMaxfli() : base("Maxfli") 
    {
        base.SetBallAttributes(9, 1, 7);
    }

}

public class BallObjectSrixon : BallObject
{
    public BallObjectSrixon() : base("Srixon")
    {
        base.SetBallAttributes(4, 8, 9);
    }

}

public class BallObjectTitleist : BallObject
{
    public BallObjectTitleist() : base("Titleist") 
    {
        base.SetBallAttributes(9, 9, 8);
    }

}