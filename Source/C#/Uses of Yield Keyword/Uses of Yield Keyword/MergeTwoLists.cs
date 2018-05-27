using System;
using System.Collections.Generic;

namespace Uses_of_Yield_Keyword
{
    public class MergeTwoLists
    {
        List<string> MarutiCars = new List<string>
                                           {
                                               "WagonR", "Celerio", "Alto K10"
                                           };

        List<string> HyundaiCars = new List<string>
                                           {
                                               "EON", "i10", "i20", "Verna"
                                           };
        public void Merge()
        {
            var allModels = AllCarModelsEfficientMerge(MarutiCars, HyundaiCars);

            foreach (var model in allModels)
            {
                Console.WriteLine(model);
            }
        }

        static IEnumerable<string> AllCarModelsEfficientMerge(List<string> marutiCars, List<string> hyundaiCars)
        {
            foreach (var m in marutiCars)
                yield return m;

            foreach (var h in hyundaiCars)
                yield return h;
        }

    }
}
