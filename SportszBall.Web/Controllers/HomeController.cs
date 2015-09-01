using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Web.Mvc;
using SendGrid;

namespace SportsBall.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var test = "<script>alert('hello!');</script>";

            
            //var myMessage = new SendGridMessage
            //{
            //    From = new MailAddress("daniel@theironyard.com"),
            //    Subject = "Testing the SendGrid Library",
            //    Html = "<p>Hello World!</p>",
            //    Text = "Hello World plain text!"
            //};

            //var recipients = new List<string>
            //{
            //    @"Brandon Goza <brgoza@gmail.com>",
            //    @"Daniel Pollock <daniellpollock@gmail.com>",
            //    @"Daniel Pollock <daniel@theironyard.com>",

            //};

            //myMessage.AddTo(recipients);

           
            //var credentials = new NetworkCredential(
            //    ConfigurationManager.AppSettings["sendGrid.Username"],
            //    ConfigurationManager.AppSettings["sendGrid.Password"]);
            //var transportWeb = new SendGrid.Web(credentials);
            //transportWeb.DeliverAsync(myMessage);

            return View((object)test);
        }

      
        public void BackGroundJobToRun(int number)
        {
            //DO SOMETHING
            Thread.Sleep(30);
        }
    }
}