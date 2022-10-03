using Assignment_1;

namespace Assignment_4.Managers
{
    public class FootballPlayersManager
    {
        private static int _nextId = 1;

        private FootballPlayer validPlayer = new FootballPlayer { Id = 1, Name = "James", Age = 21, ShirtNumber = 11 };

        private static readonly List<FootballPlayer> Data = new List<FootballPlayer>
        {
            new FootballPlayer { Id = 1, Name = "James", Age = 21, ShirtNumber = 11 },
            new FootballPlayer { Id = 2, Name = "k", Age = 23, ShirtNumber = 7 },
            new FootballPlayer { Id = 3, Name = null, Age = 23, ShirtNumber = 7 },
            new FootballPlayer { Id = 4, Name = "Laika", Age = 19, ShirtNumber = -54 },
            new FootballPlayer { Id = 5, Name = "Franky", Age = 37, ShirtNumber = 307 }
        };

        public List<FootballPlayer> GetAll()
        {
            return new List<FootballPlayer>(Data);
        }

        public FootballPlayer GetById(int id)
        {
            return Data.Find(ipa => ipa.Id == id);
        }

        public FootballPlayer Add(FootballPlayer newIPA)
        {
            newIPA.Id = _nextId++;
            Data.Add(newIPA);
            return newIPA;
        }

        public FootballPlayer Update(int id, FootballPlayer updates)
        {
            FootballPlayer player = Data.Find(player => player.Id == id);
            if (player == null) return null;
            player.Age = updates.Age;
            player.Name = updates.Name;
            player.ShirtNumber = updates.ShirtNumber;
            return player;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer player = Data.Find(player => player.Id == id);
            if (player == null) return null;
            Data.Remove(player);
            return player;
        }

    }
}
