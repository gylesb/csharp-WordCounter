using System.Collections.Generic;
using System;

namespace WordCounter.Models
{
  public class RepeatWord
  {
    private string _wordInput;
    private string _sentenceInput;

    public RepeatWord (string wordInput, string sentenceInput)
    {
      _wordInput = wordInput;
      _sentenceInput = sentenceInput;
    }

    public string GetSentence()
    {
      return _sentenceInput;
    }

    public string GetWord()
    {
      return _wordInput;
    }

    public int WordCount()
    {
      int Counter = 0;
      string word = _wordInput.ToLower();
      string sentence = _sentenceInput.ToLower();


      string [] splitSentence = sentence.Split();

      if (word.Length == 0 || splitSentence.Length == 0)
      {
        Counter = 0;
      }
      else
      {
        for (int i = 0; i < splitSentence.Length; i+= 1)
        {
          if (splitSentence[i] == word)
          {
            Counter += 1;
          }
          else
          {
            Counter += 0;
          }
        }
      }
       return Counter;
    }
  }
}
