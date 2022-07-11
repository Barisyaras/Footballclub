using Footballclub;


Team firstTeam = new Team("Fenerbahçe");
Team secondTeam = new Team("Galatasaray");
SportSimulation simulation = new SportSimulation();

firstTeam.WriteTeam();
secondTeam.WriteTeam();

//int firstTeamOdds = 100 * ((double)firstTeam.Value) / (firstTeam.Value + secondTeam.Value);
int v=simulation.Simulate(firstTeam,secondTeam);
Console.WriteLine("İlk takımın kazanma ihtimali %" + v);
Console.WriteLine("İkinci takımın kazanma ihtimali %"+(100 - v));

simulation.SimulateMatch(firstTeam, secondTeam);
