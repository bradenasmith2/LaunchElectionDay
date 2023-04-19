using LaunchElectionDay;

var diana = new Candidate("Diana D", "Democrat");
var race = new Race("City Council District 10");  //Objects
var election = new Election("1990");

Console.WriteLine(diana.Name);//Candidate Class
Console.WriteLine(diana.Party);
diana.VoteFor();
diana.VoteFor();
diana.VoteFor();
Console.WriteLine(diana.Votes);
race.RegisterCandidate(diana);

Console.WriteLine(race.Office);
foreach(var candidate in race.Candidates)//Race Class
{ 
    Console.WriteLine(candidate.Name);
}

Console.WriteLine(election.GetYear());//Election Class
election.AddRace(race);
election.GetRaces();
election.GetAllCandidates();
election.GetVoteCounts(race);


