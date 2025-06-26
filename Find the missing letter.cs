using System.Collections.Generic;
using System;
using System.Linq;
public class Kata
{
  public static char FindMissingLetter(char[] array)
  {
    
    //Create a dictionary of letter
    Dictionary<char,int> alphabet = new Dictionary<char,int>(){
    
    {'a', 1}, {'b', 2}, {'c', 3}, {'d', 4}, {'e', 5}, {'f', 6}, {'g', 7},
    {'h', 8}, {'i', 9}, {'j', 10}, {'k', 11}, {'l', 12}, {'m', 13}, {'n', 14},
    {'o', 15}, {'p', 16}, {'q', 17}, {'r', 18}, {'s', 19}, {'t', 20}, {'u', 21},
    {'v', 22}, {'w', 23}, {'x', 24}, {'y', 25}, {'z', 26},

    {'A', 27}, {'B', 28}, {'C', 29}, {'D', 30}, {'E', 31}, {'F', 32}, {'G', 33},
    {'H', 34}, {'I', 35}, {'J', 36}, {'K', 37}, {'L', 38}, {'M', 39}, {'N', 40},
    {'O', 41}, {'P', 42}, {'Q', 43}, {'R', 44}, {'S', 45}, {'T', 46}, {'U', 47},
    {'V', 48}, {'W', 49}, {'X', 50}, {'Y', 51}, {'Z', 52}

    };
    int sum1=0;
    int sum2=0;
    int valueOfLetter=0;
   
    for(int i=0;i<array.Length-1;i++)
    {
      sum1 = alphabet[array[i]];
      sum2 = alphabet[array[i+1]];
      if((sum2-sum1)!=1)
      {
        Console.WriteLine("Here is the mistake between the letter " + array[i] + " and  "+ array[i+1]);
        valueOfLetter = alphabet[array[i]]+1;
       
      }
     
    }
     return alphabet.FirstOrDefault(x=>x.Value==valueOfLetter).Key;;
      
    }
      
}
