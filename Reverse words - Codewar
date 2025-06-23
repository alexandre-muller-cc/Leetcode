using System;
using System.Collections.Generic;


public static class Kata
{
  public static string ReverseWords(string str)
  {
    //Place the string into a List
    
    string[] sentence =  str.Split(" "); //Split the String by space
    List<string> finalSentence = new List<string>();
    foreach(string element in sentence)
    {
      //Reverse the word here
      List<string> word = new List<string>();
      for(int i=(element.Length)-1;i>=0;i--)
      {
        word.Add(element[i].ToString());
 
      }
    finalSentence.Add(string.Join("",word)); 
    }
    
    //Write your code here
    return string.Join(" ",finalSentence);
  }
}
