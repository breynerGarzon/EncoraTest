using Encora.Business.Implement;
using Encora.Business.Interface;
using Xunit;

namespace Encora.Business.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("abaccadcc", "ccccaaabd")]
        [InlineData("xyzxy", "xxyyz")]
        [InlineData("dulgvgzwqg", "gggdlquvwz")]
        [InlineData("hnlnxiupgt", "nnghilptux")]
        [InlineData("wzenwebuau", "eeuuwwabnz")]
        [InlineData("vokfxzynwl", "fklnovwxyz")]
        [InlineData("qakmc", "ackmq")]
        public void Test1(string inputData, string expectedValue)
        {
            ISortedServices sortedServices = new SortedServices();
            string outPut = sortedServices.SortingOperations(inputData);
            Assert.True(outPut.Equals(expectedValue));
        }
    }
}
