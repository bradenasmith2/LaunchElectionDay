using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Race
    {
        public string Office;
        public List<Candidate> Candidates { get; set; } = new List<Candidate>();

        public Race(string office)
        {
            Office = office;
            List<Candidate> Candidates = new List<Candidate>();
        }

        public void RegisterCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }
    }
}
