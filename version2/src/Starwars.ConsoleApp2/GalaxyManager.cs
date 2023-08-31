using Newtonsoft.Json;

namespace Starwars.ConsoleApp1
{
    public class GalaxyManager
    {
        public string ToJson(string galaxyName) {
            return JsonConvert.SerializeObject(new { galaxy = galaxyName });
        }
    }
}
