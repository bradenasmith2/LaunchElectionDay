using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        }

        public void RegisterCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }

        public void GetCandidateInfo()
        {
            foreach(var candidate in Candidates)
            {
                var name = candidate.Name;
                var votes = candidate.Votes;
            }
        }
    }
}
