using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        // GET: /<controller>/
        [Route("/skills")]
        public IActionResult DisplaySkills()
        {
            string html = "<h1>Skills Tracker</h1>" +
                "<h2>Coding skills to learn:</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>Python</li>" +
                "</ol>";

            return Content(html, "text/html");
        }

        //order list
        [HttpGet]
        [Route("/skills/form2")]
        public IActionResult DisplayFormOrderedList()
        {
            string html = "<form method='post' action= '/skills/form2>" +
                       "<h1> Ordered list form </h1>" +
                       "<ol>" +
                       "<li>Date:</li>" +
                       "<input type = 'date' name = 'date' />" +
                       "<li>C#:</li>" +
                       "<select name = 'csharp'>" +
                       "<option value = 'learning basics'>Learning basics</option>" +
                       "<option value = 'making apps'>Making apps</option>" +
                       "<option value = 'master coder'>C# coding star</option>" +
                       "</select>" +
                       "<li>JavaScript:</li>" +
                       "<select name = 'javascript'>" +
                       "<option value = 'learning basics'>Learning basics</option>" +
                       "<option value = 'making apps'>Making apps</option>" +
                       "<option value = 'master coder'>JavaScript genius</option>" +
                       "</select>" +
                       "<li>Python:</li>" +
                       "<select name = 'python'>" +
                       "<option value = 'learning basics'>Learning basics</option>" +
                       "<option value = 'making apps'>Making apps</option>" +
                       "<option value = 'master coder'>Python preeminence</option>" +
                       "</select>" +
                       "<input type = 'submit' value = 'Submit' />" +
                       "</form>";

            return Content(html, "text/html");
        }

        //table using <br>
        [HttpGet]
        [Route("/skills/form3")]
        public IActionResult DisplayFormBRTable()
        {
            string html = "<form method='post' action= '/skills/form3>" +
                       "<h1> BR elements form </h1>" +
                       "Date:<br>" +
                       "<input type = 'date' name = 'date' />" +
                       "<br>C#:<br>" +
                       "<select name = 'csharp'>" +
                       "<option value = 'learning basics'>Learning basics</option>" +
                       "<option value = 'making apps'>Making apps</option>" +
                       "<option value = 'master coder'>C# coding star</option>" +
                       "</select>" +
                       "<br>JavaScript:<br>" +
                       "<select name = 'javascript'>" +
                       "<option value = 'learning basics'>Learning basics</option>" +
                       "<option value = 'making apps'>Making apps</option>" +
                       "<option value = 'master coder'>JavaScript genius</option>" +
                       "</select>" +
                       "<br>Python:<br>" +
                       "<select name = 'python'>" +
                       "<option value = 'learning basics'>Learning basics</option>" +
                       "<option value = 'making apps'>Making apps</option>" +
                       "<option value = 'master coder'>Python preeminence</option>" +
                       "</select><br>" +
                       "<input type = 'submit' value = 'Submit' />" +
                       "</form>";

            return Content(html, "text/html");

        }

        //table
        [HttpGet]
        [Route("/skills/form1")]
        public IActionResult DisplayFormTable()
        {
            string html = "<form method='post' action= '/skills/form1>" +
                       "<h1> Table form </h1>" +
                       "<table border = '1'>" +
                       "<table>" +
                       "<tr>" +
                       "<td>Date:</td>" +
                       "<td>" +
                       "<input type = 'date' name = 'date' />" +
                       "</td>" +
                       "</tr>" +
                       "<tr>" +
                       "<td>C#:</td>" +
                       "<td>" +
                       "<select name = 'csharp'>" +
                       "<option value = 'learning basics'>Learning basics</option>" +
                       "<option value = 'making apps'>Making apps</option>" +
                       "<option value = 'master coder'>C# coding star</option>" +
                       "</select>" +
                       "</td>" +
                       "<tr>" +
                       "<td>JavaScript:</td>" +
                       "<td>" +
                       "<select name = 'javascript'>" +
                       "<option value = 'learning basics'>Learning basics</option>" +
                       "<option value = 'making apps'>Making apps</option>" +
                       "<option value = 'master coder'>JavaScript genius</option>" +
                       "</select>" +
                       "</td>" +
                       "<tr>" +
                       "<td>Python:</td>" +
                       "<td>" +
                       "<select name = 'python'>" +
                       "<option value = 'learning basics'>Learning basics</option>" +
                       "<option value = 'making apps'>Making apps</option>" +
                       "<option value = 'master coder'>Python preeminence</option>" +
                       "</select>" +
                       "</td>" +
                       "</table>" +
                       "<input type = 'submit' value = 'Submit' />" +
                       "</form>";

            return Content(html, "text/html");
        }


        //fieldset
        [HttpGet]
        [Route("/skills/form4")]
        public IActionResult DisplayFormFieldset()
        {
            string html = "<form method='post' action= '/skills/form4>" +
                           "<h1> Fieldset form </h1>" +
                           "<fieldset>" +
                           //some cell padding or something here maybe...
                           "<legend>Date:</legend>" +
                           "<input type = 'date' name = 'date' />" +
                           "</fieldset>" +
                           "<fieldset>" +
                           "<legend>C#:</legend>" +
                           "<select name = 'csharp'>" +
                           "<option value = 'learning basics'>Learning basics</option>" +
                           "<option value = 'making apps'>Making apps</option>" +
                           "<option value = 'master coder'>C# coding star</option>" +
                           "</select>" +
                           "</fieldset>" +
                           "<fieldset>" +
                           "<legend>JavaScript:</legend>" +
                           "<select name = 'javascript'>" +
                           "<option value = 'learning basics'>Learning basics</option>" +
                           "<option value = 'making apps'>Making apps</option>" +
                           "<option value = 'master coder'>JavaScript genius</option>" +
                           "</select>" +
                           "</fieldset>" +
                           "<fieldset> " +
                           "<legend>Python:</legend>" +
                           "<select name = 'python'>" +
                           "<option value = 'learning basics'>Learning basics</option>" +
                           "<option value = 'making apps'>Making apps</option>" +
                           "<option value = 'master coder'>Python preeminence</option>" +
                           "</select>" +
                           "</fieldset>" +
                           "<input type = 'submit' value = 'Submit' />" +
                           "</form>";

            return Content(html, "text/html");
        }

        //[HttpPost]
        //[Route("/skills/form")]
        //public IActionResult NamePage(string date, string csharp, string javasript, string python)
        //{
        //    string html = "<h1>" + date + "</h1>" +
        //                "<ol>" +
        //                "<li>C#: " + csharp + "</li>" +
        //                "<li>JavaScript: " + javascript + "</li>" +
        //                "<li>Python: " + python + "</li>" +
        //                "</ol>";
        //    return Content(html, "text/html");

        //}

    }
}
