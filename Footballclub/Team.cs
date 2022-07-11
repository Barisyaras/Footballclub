namespace Footballclub
{
    public class Team
    {
        string[] nameList = { "Ahmet", "Mehmet", "Burak", "Emre", "Abuzer", "Mert", "Caner", "Umut", };
        string[] surnameList = { "Zaman", "Alçak", "Karaoğlan", "Yılmaz", "Kömürcü", "Kanun", "Taklacı", "Ermiş" };
        
        public string Name { get; set; }
        public int Value { get; set; }
        public List<Player> Players { get; set; }

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
            GeneratePlayers();
        }

        private void GeneratePlayers()
        {
            int teamValue = 0;
            for (int i = 0; i < 5; i++)
            {
                Random rnd = new Random();
                var namernd = rnd.Next(nameList.Length);
                var surnamernd = rnd.Next(surnameList.Length);
                var valuernd = rnd.Next(25000,500000);

                var value = valuernd - (valuernd % 1000);

                Player player = new Player();
                player.Name = nameList[namernd];
                player.Surname = surnameList[surnamernd];
                player.Value = value;
                Players.Add(player);
                teamValue+=value;
            }
            Value = teamValue;
        }


        public void WriteTeam()
        {
            Console.WriteLine($"Takım Adı: {Name}");

            Console.WriteLine(Value);

            foreach (var item in Players)
            {
                Console.Write("Futbolcu :");
                var text = $"{item.Name} {item.Surname} {item.Value}";
                Console.WriteLine(text);
            }
        }



    }
}
