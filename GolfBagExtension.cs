public class GolfBagWeekender : GolfBag
{
    public GolfBagWeekender() : base("Weekender")
    {
        _club = new ClubObjectGraphite();
        _ball = new BallObjectMaxfli();
        _glove = new GloveObjectNike();
    }
    
}