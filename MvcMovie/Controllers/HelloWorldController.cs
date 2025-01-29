using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    //
    //GET: /HelloWorld/
 /*   public string Index()
    {
        return "This is my default action...";
    }
 */
    //
    //GET: /HelloWorld/Welcome
    //public string Welcome(string name, int numTimes = 1) //don't forget to put additional parameters
    //{
    //    //return "This is the Welcome action method...";
    //    return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");

    //}

/*    public string Welcome (string name, int ID = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
    }
*/

    //This is the new method using the IActionResult to return the new View
    // remember there is also a dup Index method...need to comment it out.
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome (string name, int numTimes =1 )
    {
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}