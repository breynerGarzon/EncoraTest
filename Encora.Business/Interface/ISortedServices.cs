using System.Collections.Generic;
using Encora.Model.DataCountLetter;

namespace Encora.Business.Interface
{
    public interface ISortedServices
    {
        string SortingOperations(string inputData);
        IEnumerable<DataCountLetter> GetLettersByCount(string inputData);
    }
}