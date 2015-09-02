using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SportsBall.Web.Controllers
{
    public class Matchup
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [SerializeID()]
        public List<Comment> Comments { get; set; } 
    }

    public class SerializeIDAttribute : Attribute
    {
    }
}