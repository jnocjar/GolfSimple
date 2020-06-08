using System;
using GolfObjects;


public class ClubObject : GolfObject
{
    public ClubObject(string clubTypeName = "Base") : base("Club")
    {
        _clubTypeName = clubTypeName;
    }

    public virtual void Swing()
    {
        Console.WriteLine($"Swinging {ToString()}");
    }

    public string get_name() { return base._name;}

    // Use ToString to identify the type.
    public override string ToString(){ return _clubTypeName + " " + get_name(); }

    protected string _clubTypeName {get;}
}

public class ClubObjectWood : ClubObject
{
    public ClubObjectWood() : base("Wood") {}

}

public class ClubObjectGraphite: ClubObject
{
    public ClubObjectGraphite() : base("Graphite") {}

}

public class ClubObjectSteel: ClubObject
{
    public ClubObjectSteel() : base("Steel") {}

}