namespace Footballclub
{
    public class SportSimulation 
    {

        public int Edge { get; set; }

        public int Simulate(Team team1,Team team2) 
        {
            var result = ((double)team1.Value) / (team1.Value + team2.Value) * 100;
            return(int)Math.Round(result);


        }


        public void SimulateMatch(Team team1,Team team2) 
        {
            Random rnd = new Random();
            var posability = rnd.Next(1, 100);

            SportSimulation simulation = new SportSimulation();
            int edgeValue = simulation.Simulate(team1, team2);
            if (posability < edgeValue)
            {
                Console.WriteLine(team1.Name + " Kazandı");
                Console.WriteLine(edgeValue);
            }

            else if (posability == edgeValue)
            {
                Console.WriteLine("Beraberlik");
            }

            else
            {
                Console.WriteLine(team2.Name + " Kazandı");
            }

        }
         



    }
}
