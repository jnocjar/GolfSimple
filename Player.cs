
public class Player 
{
    public Player(string name, GolfBag bag)
    {
        _name = name;
        _bag = bag;
    }

    public void Play() {}

    public override string ToString()
    {
        return $"Player: {_name} {_bag.ToString()}";
    }

    string _name;

    private GolfBag _bag;


} /* end Class */
