using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/letter")]
    public ActionResult MadLib(string relative, string adjOne, string adjTwo, string adjThree, string name, string adjFour, string adjFive, string verbEd, string bodyPart, string verbIng, string nounPlural, string noun, string adverb, string verbOne, string verbTwo, string relativeTwo, string personInRoom)
    {
      MadLib madlib = new MadLib();
      madlib.Relative = relative;
      madlib.AdjectiveOne = adjOne;
      madlib.AdjectiveTwo = adjTwo;
      madlib.AdjectiveThree = adjThree;
      madlib.Name = name;
      madlib.AdjectiveFour = adjFour;
      madlib.AdjectiveFive = adjFive;
      madlib.VerbinEd = verbEd;
      madlib.BodyPart = bodyPart;
      madlib.VerbinIng = verbIng;
      madlib.NounPlural = nounPlural;
      madlib.Noun = noun;
      madlib.Adverb = adverb;
      madlib.VerbOne = verbOne;
      madlib.VerbTwo = verbTwo;
      madlib.RelativeTwo = relativeTwo;
      madlib.PersonInRoom = personInRoom;
      return View(madlib);
    }
  }
}