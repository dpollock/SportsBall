using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using SportszBall.Web.Models;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(SportsBall.Web.App_Start.EmberJSWebApiPackage), "PostStart")]
namespace SportsBall.Web.App_Start
{

    public static class EmberJSWebApiPackage
    {
        public static void PostStart()
        {
            var formatters = GlobalConfiguration.Configuration.Formatters;
            formatters.Insert(0, new EmberJsonMediaTypeFormatter());
            var jsonFormatter = formatters.OfType<EmberJsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            jsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

        }
    }

}
