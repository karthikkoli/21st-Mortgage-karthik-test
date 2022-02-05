using System;
using System.Collections.Generic;
using System.Text;

namespace _21stMortgageInterviewApplication.Helper
{
    public class StringtoIntArray
    {
      public static int[] StringToIntArrayMap(string myNumbers)
        {
            List<int> myIntegers = new List<int>();
            Array.ForEach(myNumbers.Split(",".ToCharArray()), s =>
            {
                int currentInt;
                if (Int32.TryParse(s, out currentInt))
                    myIntegers.Add(currentInt);
            });
            return myIntegers.ToArray();
        }
    }
}
