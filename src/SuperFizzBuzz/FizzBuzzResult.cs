using System;

namespace Headspring.FizzBuzz
{
  public class FizzBuzzResult
  {
    public int Start { get; set; }
    public int End { get; set; }
    public string[] Items { get; set; }
    
    public FizzBuzzResult(int start, int end) {
      var size = end - start + 1;
      Items = new string[size];
      Start = start;
      End = end;
    }

    public override string ToString() {
      if(Items == null)
      {
        return null;
      }

      var targetArray = new string[Items.Length];
      Items.CopyTo(targetArray, 0);

      for(int i = 0; i < targetArray.Length; i++) 
      {
        if(string.IsNullOrEmpty(targetArray[i]))
        {
          targetArray[i] = (Start + i).ToString();
        }
      }

      return string.Join(",", targetArray);
    }
  }
}