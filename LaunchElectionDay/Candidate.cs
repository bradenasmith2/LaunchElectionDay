namespace LaunchElectionDay
{
    public class Candidate
    {
        public string Name;
        public string Party;
        public int Votes;

        public Candidate(string name, string party)
        {
            Name = name;
            Party = party;

            int votes = Votes;
        }

        public void VoteFor()
        {
            Votes++;
        }
    }

}
