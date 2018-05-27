using System;
using System.Collections.Generic;

namespace Uses_of_Yield_Keyword
{
    public class EvenNumber
    {
        private List<int> randomIntegerList;

        public EvenNumber()
        {
            randomIntegerList = new List<int>
                                           {
                                               23,84,99,67,92,14,78,43,28
                                           };
        }

        public void PrintEvenNumber()
        {
            var evenNumberList = GetEvenNumber(randomIntegerList);

            foreach (var number in evenNumberList)
            {
                Console.WriteLine(number);
            }
        }
        
        private static IEnumerable<int> GetEvenNumber(List<int> randomIntegerList)
        {
            foreach (var number in randomIntegerList)
            {
                if (number % 2 == 0)
                    yield return number;
            }
        }

    }
}
