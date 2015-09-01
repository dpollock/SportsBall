using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.ModelBinding;

namespace SportsBall.Web.Controllers
{
    public class ValuesController : ApiController
    {
        [Route("api/matchup/{id}")]
        [HttpGet]
        public Matchup GetMatchUp(int id)
        {
            return new Matchup
            {
                Id = id,
                FirstName = "Daniel",
                LastName= "Pollock",
            };
        }

        [Route("api/matchup/{id}")]
        [HttpPost]
        public int PostCustomer(Matchup matchup)
        {
            return matchup.Id;
        }
    }
}
