using System;
using System.Collections.Generic;


namespace Uses_of_Yield_Keyword
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> randomIntegerList = new List<int>
                                           {
                                               23,84,99,67,92,14,78,43,28
                                           };

            var evenNumberList = GetEvenNumber(randomIntegerList);

            foreach (var number in evenNumberList)
            {
                Console.WriteLine(number);
            }

            MergeTwoLists mergeTwoList = new MergeTwoLists();
            mergeTwoList.Merge();
        }

        public static IEnumerable<int> GetEvenNumber(List<int> randomIntegerList)
        {
            foreach (var number in randomIntegerList)
            {
                if (number % 2 == 0)
                    yield return number;
            }
        }
    }
}
