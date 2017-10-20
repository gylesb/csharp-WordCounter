using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace Find.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("/wordcounter/results")]
    public ActionResult Results()
    {
      RepeatWord newWord = new RepeatWord (Request.Form["inputWord"], Request.Form["inputSentence"]);
      return View (newWord);
    }
  }
}
