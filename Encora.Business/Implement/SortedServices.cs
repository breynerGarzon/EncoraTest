using System.Collections.Generic;
using System.Linq;
using Encora.Business.Interface;
using Encora.Model.StringReorderer;

namespace Encora.Business.Implement
{
    public class SortedServices : ISortedServices
    {
        public IEnumerable<DataCountLetter> GetLettersByCount(string inputData)
        {
            return inputData
                    .GroupBy(letter => letter)
                    .Select(letter => new DataCountLetter()
                    {
                        CountChart = letter.Count(),
                        Letter = letter.Key
                    });
        }

        public string SortingOperations(string inputData)
        {
            IEnumerable<DataCountLetter> dataGroup = this.GetLettersByCount(inputData);
            string outPut = string.Empty;
            dataGroup
                    .OrderByDescending(letter => letter.CountChart)
                    .ThenBy(letter => letter.Letter)
                    .ToList()
                    .ForEach(letter =>
                            {
                                for (int count = 0; count < letter.CountChart; count++)
                                    outPut += letter.Letter;
                            }
                    );
            return outPut;
        }
    }
}