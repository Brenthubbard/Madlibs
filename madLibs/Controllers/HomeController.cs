using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlibSheet")]
    public ActionResult MadlibSheet(string nouns, string adverb, string adjective, string verb, string exclamations)
    {
      MadlibVariable myMadlibVariable = new MadlibVariable();
      myMadlibVariable.Nouns = nouns;
      myMadlibVariable.Adverb = adverb;
      myMadlibVariable.Adjective = adjective;
      myMadlibVariable.Verb = verb;
      myMadlibVariable.Exclamations = exclamations;
      return View(myMadlibVariable);
    }
  }
}