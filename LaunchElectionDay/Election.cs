using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LaunchElectionDay
{
    public class Election
    {
        public string Year;
        public List<Race> Races = new List<Race>();

        public Election(string year)
        {
            Year = year;
        }

        public string GetYear()
        {
            return $"{Year}";
        }

        public void AddRace(Race race)
        {
            Races.Add(race);
        }

        public List<Race> GetRaces()
        {
            foreach(var race in Races)
            {
                Console.WriteLine(race.Office);
            }
            return Races;
        }

        public void GetAllCandidates()
        {
            foreach(var race in Races)
            {
                foreach(var candidate in race.Candidates)
                {
                    Console.WriteLine(candidate.Name);
                }
            }
        }

        public void GetVoteCounts(Race race)
        {
            var CandidateAndVotes = new Dictionary<string, int>();

            foreach (var race1 in Races)
            {
                foreach (var candidate1 in race.Candidates)
                {
                    CandidateAndVotes.Add(candidate1.Name, candidate1.Votes);
                }
            }
            foreach(var cv in CandidateAndVotes)
            {
                Console.WriteLine(cv);
            }
        }
    }
}
