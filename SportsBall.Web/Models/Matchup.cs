using Newtonsoft.Json;

namespace SportsBall.Web.Controllers
{
    [JsonObject(Title = "matchup")]
    public class Matchup
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}