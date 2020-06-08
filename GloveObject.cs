using System;
using GolfObjects;


public class GloveObject : GolfObject
{
    public GloveObject(string gloveTypeName = "Base") : base("Glove")
    {
        _gloveTypeName = gloveTypeName;
    }

    public virtual void Grip()
    {
        Console.WriteLine($"Gripping {ToString()}");
    }

    public string get_name() { return base._name;}

    // Use ToString to identify the type.
    public override string ToString(){ return _gloveTypeName + " " + get_name(); }

    protected string _gloveTypeName {get;}
}

public class GloveObjectCalloway : GloveObject
{
    public GloveObjectCalloway() : base("Calloway") {}

}

public class GloveObjectFootjoy : GloveObject
{
    public GloveObjectFootjoy() : base("Footjoy") {}

}

public class GloveObjectNike : GloveObject
{
    public GloveObjectNike() : base("Nike") {}

}