using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpPost("results")]
    public ActionResult Results()
    {
      RepeatWord newWord = new RepeatWord (Request.Form["inputWord"], Request.Form["inputSentence"]);

      string Word = newWord.GetWord();
      string Sentence = newWord.GetSentence();
      int repeats = newWord.WordCount();
      string Repeats = repeats.ToString();

      Dictionary<string, string> WordCount = new Dictionary<string, string> () {{"Word", Word}, {"Sentence", Sentence}, {"Repeats", Repeats}};

      return View (newWord);


    }
  }
}
