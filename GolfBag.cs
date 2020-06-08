using GolfObjects;

public abstract class GolfBag : GolfObject
{
    public GolfBag(string name) : base(name) { _golfBagName = name; }

    public override string ToString()
    {
        return $"{_golfBagName}: [Club:{_club.ToString()}], [Ball:{_ball.ToString()}], [Glove:{_glove.ToString()}]";
    }

    protected ClubObject _club;
    protected BallObject _ball;
    protected private GloveObject _glove;

    private string _golfBagName;
}

public class GolfBagAggressive : GolfBag
{
    public GolfBagAggressive() : base("Aggressive")
    {
        _club = new ClubObjectSteel();
        _ball = new BallObjectTitleist();
        _glove = new GloveObjectCalloway();
    }
}

public class GolfBagAmateur : GolfBag
{
    public GolfBagAmateur() : base("Amateur")
    {
        _club = new ClubObjectWood();
        _ball = new BallObjectSrixon();
        _glove = new GloveObjectFootjoy();
    }

}