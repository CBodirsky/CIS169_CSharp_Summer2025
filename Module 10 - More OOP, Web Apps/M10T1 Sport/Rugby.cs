public class Rugby : Sport
{
    //constructors
    public Rugby(string name, string equipment, int numberOfPlayers)
        : base(name, equipment, numberOfPlayers)
    {

    }


    //Override abstract method of Play(), return sentence describing the play of the game
    public override string Play()
    {
        return $"{name} is a full contact sport involving running, tackling, and carrying the ball by the opponent's goal line.";
    }
    //add method to FormTeam() that returns # of players needed for team
    public int FormTeam()
    {
        return numberOfPlayers;
    }

}