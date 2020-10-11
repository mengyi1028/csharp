using System;
using System.Collections.Generic;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        //throw new NotImplementedException("Waiting to be implemented.");
        
        HashSet<int> hs = new HashSet<int>();
        int complement =0;
        
        for(int i=0; i<list.Count; i++)
        {
            complement = sum - list[i];
            if (hs.Contains(complement))
            {
                return new Tuple<int, int>(list.IndexOf(complement), i);
            }
            
            // add into hashset
            hs.Add(list[i]);
        }
        
        return null;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);
        if(indices != null) 
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }
    }
}
