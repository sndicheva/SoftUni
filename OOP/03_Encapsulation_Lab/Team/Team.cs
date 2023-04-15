
namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        public Team(string name)
        {
            Name = name;
            firstTeam = new List<Person>();
            reserveTeam = new List<Person>();
        }
        public IReadOnlyCollection<Person> FirstTeam { get => this.firstTeam.AsReadOnly(); }
        public IReadOnlyCollection<Person> ReserveTeam { get => this.reserveTeam.AsReadOnly(); }
        public string Name { get; private set; } // private set

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                firstTeam.Add(person);
            }
            else
            {
                reserveTeam.Add(person);
            }
        }
        public override string ToString()
        {
            return $"First team has {firstTeam.Count} players.{Environment.NewLine}Reserve team has {reserveTeam.Count} players.";
        }
    }
}
