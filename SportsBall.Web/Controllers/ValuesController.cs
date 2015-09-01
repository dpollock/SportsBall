using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.ModelBinding;

namespace SportsBall.Web.Controllers
{
    public class ValuesController : ApiController
    {

        [Route("api/matchup")]
        [HttpGet]
        public IEnumerable<Matchup> GetMatchUp()
        {
            var results = new List<Matchup>();
            results.Add(new Matchup
            {
                Id = 10,
                FirstName = "Daniel",
                LastName = "Pollock",
            });

            results.Add(new Matchup
            {
                Id = 11,
                FirstName = "Ryan",
                LastName = "Tablada",
            });

            return results;
        }


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
