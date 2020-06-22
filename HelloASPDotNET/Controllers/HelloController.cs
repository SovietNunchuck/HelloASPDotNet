using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]
    public class HelloController : Controller
    {
        // GET: /<controller>/

        [HttpGet]
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
                "<input type='text' name='name'/>" +
                "<select name='language'>" +
                    "<option value='english'>English</option>" +
                    "<option value='spanish'>Spanish</option>" +
                    "<option value='french'>French</option>" +
                    "<option value='german'>German</option>" +
                    "<option value='japanese'>Japanese</option>" +
                "</select>" +
                "<input type='submit' value='Greet Me!' />" +
                "</form>";
            return Content(html, "text/html");
        }

        // POST: /hello/welcome

        [HttpGet("welcome/{name?}/{language?}")]
        [HttpPost]
        public IActionResult Welcome(string name, string language)
        {
            string greeting = CreateMessage(name, language);
            return Content(greeting, "text/html");
        }

        public static string CreateMessage(string name = "", string language = "")
        {
            //string greeting = "";
            if (language == "english")
            {
                return "<h1>Welcome to my app, " + name + "!</h1>";
            }
            else if (language == "spanish")
            {
                return "<h1>Hola, " + name + "!</h1>";
            }
            else if (language == "french")
            {
                return "<h1>Bonjour, " + name + "!</h1>";
            }
            else if (language == "german")
            {
                return "<h1>Hallo, " + name + "!</h1>";
            }
            else if (language == "japanese")
            {
                return "<h1>Kon'nichiwa, " + name + "!</h1>";
            }
            else
            {
                return "<h1>Welcome to my app, World!</h1>";
            }
        }
    }
}
