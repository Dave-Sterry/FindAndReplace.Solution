using System;
using System.Collections.Generic;

namespace FindAndReplace.Models
{
  public class Find
  {

    public static string Replace(string userPhrase, string wordToReplace, string replaceWith) 
    { 
      if (userPhrase.Contains(wordToReplace))
      {
        string returnString = ""; 
        string[] phraseArr = userPhrase.Split(" ");
        for (int i = 0; i < 1; i++) 
        {
          if (phraseArr[i] == wordToReplace)
          {
            phraseArr[i] = replaceWith;
            returnString = string.Join(" ", phraseArr);
          }
          else 
          {
           //do nothing
          }
        } 
        return returnString;
      }
      if (userPhrase == wordToReplace)
      {
        return replaceWith;
      }
      else
      {
        return userPhrase;
      }
    } 
  }
}