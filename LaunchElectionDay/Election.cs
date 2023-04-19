using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaunchElectionDay
{
    public class Election
    {
        public string Year;
        public List<Race> Races = new List<Race>();

        public Election(string year)
        {
            Year = year;
            List<Race> Races = new List<Race>();
        }

        public string GetYear()
        {
            return $"{Year}";
        }

        public List<Race> GetRaces()
        {

        }
    }
}
