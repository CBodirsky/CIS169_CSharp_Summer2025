public class ShotPut : Sport
{
    //constructors
    public ShotPut(string name, string equipment, int numberOfPlayers)
        : base(name, equipment, numberOfPlayers)
    {

    }
    //override method Play(), return one sentence describing play of the game
    public override string Play()
    {
        return $"{name} is a sport where athletes propel a heavy ball as far as possible from a throwing circle.";
    }
}