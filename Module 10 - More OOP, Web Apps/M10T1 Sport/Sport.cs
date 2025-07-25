public abstract class Sport
{
    public string name;
    public string equipment;
    public int numberOfPlayers;

    public Sport(string name, string equipment, int numberOfPlayers)
    {
        this.name = name;
        this.equipment = equipment;
        this.numberOfPlayers = numberOfPlayers;
    }

    public abstract string Play();
    public override string ToString()
    {
        return $"{name} requires {numberOfPlayers} players, and {equipment}.";
    }
}