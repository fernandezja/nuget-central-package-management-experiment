namespace Starwars.ConsoleApp1.Tests
{
    public class GalaxyManagerTest
    {
        [Fact]
        public void ToJson_Test()
        {
            var galaxyManager = new GalaxyManager();
            var result = galaxyManager.ToJson("Skyriver Galaxy");

            Assert.Equal("{\"galaxy\":\"Skyriver Galaxy\"}", result);
        }
    }
}