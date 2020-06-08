using System;
using GolfObjects;


public class BallObject : GolfObject
{
    public BallObject(string ballTypeName = "Base") : base("Ball")
    {
        _ballTypeName = ballTypeName;
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
    public override string ToString(){ return _ballTypeName + " " + get_name(); }

    protected string _ballTypeName {get;}
}

public class BallObjectMaxfli: BallObject
{
    public BallObjectMaxfli() : base("Maxfli") {}

}

public class BallObjectSrixon: BallObject
{
    public BallObjectSrixon() : base("Srixon") {}

}

public class BallObjectTitleist: BallObject
{
    public BallObjectTitleist() : base("Titleist") {}

}