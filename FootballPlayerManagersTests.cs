

namespace FootballPlayerRestTestProject
{
    [TestClass()]
    public class FootballsManagerTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            FootballPlayersManager _playerManager = new FootballPlayersManager();
            var footballPlayers = _playerManager.GetAll();
            Assert.AreEqual(footballPlayers.Count, 6);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            FootballPlayersManager _playerManager = new FootballPlayersManager();
            int id = 5;
            var result = _playerManager.GetById(id);
            Assert.IsTrue(result.Name == "Franky");
        }

        [TestMethod()]
        public void UpdateTest()
        {
            FootballPlayersManager _playerManager = new FootballPlayersManager();
            FootballPlayer footballPlayer = new FootballPlayer(6, "Jeremy", 34, 14);
            int id = 1;
            string expectedNewName = "Jeremy";
            var result = _playerManager.Update(2, footballPlayer);
            Assert.AreEqual(expectedNewName, result.Name);
        }

        [TestMethod()]
        public void AddTest()
        {
            FootballPlayersManager _playerManager = new FootballPlayersManager();
            FootballPlayer footballPlayer = new FootballPlayer(6, "Jeremy", 34, 14);
            string expectedName = "Jeremy";
            var result = _playerManager.Add(footballPlayer);

            Assert.AreEqual(expectedName, result.Name);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            FootballPlayersManager _playerManager = new FootballPlayersManager();
            int id = 4;
            string expectedNameToBeDeleted = "Laika";
            var result = _playerManager.Delete(id);
            Assert.AreEqual(expectedNameToBeDeleted, result.Name);
        }


    }
}