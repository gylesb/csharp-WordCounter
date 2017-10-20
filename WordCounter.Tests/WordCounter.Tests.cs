using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatWordTest
  {

    [TestMethod]
    public void RepeatWord_DoesntAppear_0()
    {
      RepeatWord newWord = new RepeatWord("a", "c");
      int expected = 0;
      int actual = newWord.WordCount();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RepeatWord_AppearsOneTime()
    {
      RepeatWord newWord = new RepeatWord("a", "a b");
      int expected = 1;
      int actual = newWord.WordCount();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RepearWord_AppearsTwice()
    {
      RepeatWord newWord = new RepeatWord("a", "a a c");
      int expected = 2;
      int actual = newWord.WordCount();
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void RepearWord_AppearsWithCaps()
    {
      RepeatWord newWord = new RepeatWord("A", "A A c aa Aa A");
      int expected = 3;
      int actual = newWord.WordCount();
      Assert.AreEqual(expected, actual);
    }
  }
}
