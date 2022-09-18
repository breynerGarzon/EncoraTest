using Encora.Business.Implement;
using Encora.Business.Interface;
using Xunit;

namespace Encora.Business.Test
{
    public class EncoraTestString
    {
        [Theory]
        [InlineData("abaccadcc", "ccccaaabd")]
        [InlineData("xyzxy", "xxyyz")]
        [InlineData("dulgvgzwqg", "gggdlquvwz")]
        [InlineData("gxtjtmtywr", "tttgjmrwxy")]
        [InlineData("hnlnxiupgt", "nnghilptux")]
        [InlineData("gzjotckivp", "cgijkoptvz")]
        [InlineData("dpwwsdptae", "ddppwwaest")]
        [InlineData("pcscpilknb", "ccppbiklns")]
        [InlineData("btvyhhmflf", "ffhhblmtvy")]
        [InlineData("artrtnqxcr", "rrrttacnqx")]
        [InlineData("nrtcmcoadn", "ccnnadmort")]
        [InlineData("fkdsgnekft", "ffkkdegnst")]
        [InlineData("wzenwebuau", "eeuuwwabnz")]
        [InlineData("vokfxzynwl", "fklnovwxyz")]
        [InlineData("neldfeyrxk", "eedfklnrxy")]
        [InlineData("wqadfiodgs", "ddafgioqsw")]
        [InlineData("ykiuvzfcbc", "ccbfikuvyz")]
        [InlineData("qakmc", "ackmq")]
        [InlineData("rrtbk", "rrbkt")]
        [InlineData("vaixn", "ainvx")]
        [InlineData("wmpnj", "jmnpw")]
        [InlineData("uproi", "iopru")]
        [InlineData("btska", "abkst")]
        [InlineData("ejqwr", "ejqrw")]
        [InlineData("elwlg", "llegw")]
        [InlineData("oaoiy", "ooaiy")]
        [InlineData("hrqkn", "hknqr")]
        [InlineData("pzjim", "ijmpz")]
        [InlineData("njnfq", "nnfjq")]
        [InlineData("xyohs", "hosxy")]
        [InlineData("xqycs", "cqsxy")]
        [InlineData("beoax", "abeox")]
        [InlineData("afkso", "afkos")]
        [InlineData("bldit", "bdilt")]
        [InlineData("gwrys", "grswy")]
        public void TestStringReordering(string inputData, string expectedValue)
        {
            ISortedServices sortedServices = new SortedServices();
            string outPut = sortedServices.SortingOperations(inputData);
            Assert.True(outPut.Equals(expectedValue));
        }
    }
}
