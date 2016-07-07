using Nancy;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NumberToWord.Objects
{
  public class NumberConverter
  {

    public string ConvertToWord(int inputNumber)
    {
      string stringNumber = inputNumber.ToString();
      string finalOutput="";
      // for(int i=stringNumber.Length, i>0, i--)
      // {
      //   array[array.Length-(1+i)]
      // }
      List<string> ordersOfMagnitude = new List<string> {"", " thousand ", " million ", " billion "};
      for(int i=0;i<=((stringNumber.Length-1)/3);i++)
      {
        int upperThreshold = Convert.ToInt32(Math.Pow(10,3*(i+1)));
        int lowerThreshold = Convert.ToInt32(Math.Pow(10,3*(i)));
        int thisPart=(inputNumber%upperThreshold)/lowerThreshold;
        if(inputNumber==0 || thisPart!=0)
        {
          finalOutput=ConvertSmallNumberToWord(thisPart)+ordersOfMagnitude[i]+finalOutput;
        }
      }
      return finalOutput;
    }
    public string ConvertSmallNumberToWord(int inputNumber)
    {
      List<string> zeroThroughNineteen = new List<string> {"", "one", "dos", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "once", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
      List<string> twentyThroughNinety = new List<string> {"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
      string hundreds="";
      string ones="";
      if(inputNumber>99)
      {
        hundreds=zeroThroughNineteen[inputNumber/100]+" hundred";
        if(inputNumber%100!=0)
        {
          hundreds=hundreds+" and ";
        }
      }
      string tens=twentyThroughNinety[(inputNumber%100)/10];
      if(inputNumber>19)
      {
        if(inputNumber%10!=0)
        {
          tens=tens+" ";
        }
        ones=zeroThroughNineteen[inputNumber%10];
      }
      else
      {
        if(inputNumber==0)
        {
          ones="zero";
        }
        else
        {
          ones=zeroThroughNineteen[inputNumber];
        }
      }
      string outputWord = hundreds + tens + ones;
      return outputWord;
    }
  }
}
