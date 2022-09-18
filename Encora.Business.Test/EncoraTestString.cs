using Encora.Business.Implement;
using Encora.Business.Interface;
using Xunit;

namespace Encora.Business.Test
{
    public class EncoraTestString
    {
        [Theory]
        [InlineData("abaccadcc", "ccccaaabd")]//Test Case 1
        [InlineData("xyzxy", "xxyyz")]//Test Case 1
        [InlineData("dulgvgzwqg", "gggdlquvwz")]//Test Case 2
        [InlineData("gxtjtmtywr", "tttgjmrwxy")]//Test Case 2
        [InlineData("hnlnxiupgt", "nnghilptux")]//Test Case 2
        [InlineData("gzjotckivp", "cgijkoptvz")]//Test Case 2
        [InlineData("dpwwsdptae", "ddppwwaest")]//Test Case 2
        [InlineData("pcscpilknb", "ccppbiklns")]//Test Case 2
        [InlineData("btvyhhmflf", "ffhhblmtvy")]//Test Case 2
        [InlineData("artrtnqxcr", "rrrttacnqx")]//Test Case 2
        [InlineData("nrtcmcoadn", "ccnnadmort")]//Test Case 2
        [InlineData("fkdsgnekft", "ffkkdegnst")]//Test Case 2
        [InlineData("wzenwebuau", "eeuuwwabnz")]//Test Case 3
        [InlineData("vokfxzynwl", "fklnovwxyz")]//Test Case 3
        [InlineData("neldfeyrxk", "eedfklnrxy")]//Test Case 3
        [InlineData("wqadfiodgs", "ddafgioqsw")]//Test Case 3
        [InlineData("ykiuvzfcbc", "ccbfikuvyz")]//Test Case 3
        [InlineData("qakmc", "ackmq")]//Test Case 4
        [InlineData("rrtbk", "rrbkt")]//Test Case 4
        [InlineData("vaixn", "ainvx")]//Test Case 4
        [InlineData("wmpnj", "jmnpw")]//Test Case 4
        [InlineData("uproi", "iopru")]//Test Case 4
        [InlineData("btska", "abkst")]//Test Case 4
        [InlineData("ejqwr", "ejqrw")]//Test Case 4
        [InlineData("elwlg", "llegw")]//Test Case 4
        [InlineData("oaoiy", "ooaiy")]//Test Case 4
        [InlineData("hrqkn", "hknqr")]//Test Case 4
        [InlineData("pzjim", "ijmpz")]//Test Case 5
        [InlineData("njnfq", "nnfjq")]//Test Case 5
        [InlineData("xyohs", "hosxy")]//Test Case 5
        [InlineData("xqycs", "cqsxy")]//Test Case 6
        [InlineData("beoax", "abeox")]//Test Case 6
        [InlineData("afkso", "afkos")]//Test Case 6
        [InlineData("bldit", "bdilt")]//Test Case 6
        [InlineData("gwrys", "grswy")]//Test Case 6
        public void TestStringReordering(string inputData, string expectedValue)
        {
            ISortedServices sortedServices = new SortedServices();
            string outPut = sortedServices.SortingOperations(inputData);
            Assert.True(outPut.Equals(expectedValue));
        }
    }
}
