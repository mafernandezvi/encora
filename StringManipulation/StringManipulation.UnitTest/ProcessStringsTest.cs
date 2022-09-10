using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringManipulation.UnitTest
{
    [TestClass]
    public class ProcessStringsTest
    {
        [TestMethod]
        [DataRow(2, "abaccadcc", "xyzxy")]
        public void TestMethod1(int number, params string[] array)
        {
            var result = ProcessStrings.SortingOperations(array);
            Assert.IsNotNull(result);
            Assert.AreEqual(number, result.Count);
            Assert.AreEqual("ccccaaabd", result[0]);
            Assert.AreEqual("xxyyz", result[1]);
        }

        [TestMethod]
        [DataRow(10, "dulgvgzwqg", "gxtjtmtywr", "hnlnxiupgt", "gzjotckivp", "dpwwsdptae", "pcscpilknb", "btvyhhmflf", "artrtnqxcr", "nrtcmcoadn", "fkdsgnekft")]
        public void TestMethod2(int number, params string[] array)
        {
            var result = ProcessStrings.SortingOperations(array);
            Assert.IsNotNull(result);
            Assert.AreEqual(number, result.Count);
            Assert.AreEqual("gggdlquvwz", result[0]);
            Assert.AreEqual("tttgjmrwxy", result[1]);
            Assert.AreEqual("nnghilptux", result[2]);
            Assert.AreEqual("cgijkoptvz", result[3]);
            Assert.AreEqual("ddppwwaest", result[4]);
            Assert.AreEqual("ccppbiklns", result[5]);
            Assert.AreEqual("ffhhblmtvy", result[6]);
            Assert.AreEqual("rrrttacnqx", result[7]);
            Assert.AreEqual("ccnnadmort", result[8]);
            Assert.AreEqual("ffkkdegnst", result[9]);
        }

        [TestMethod]
        [DataRow(5, "wzenwebuau", "vokfxzynwl", "neldfeyrxk", "wqadfiodgs", "ykiuvzfcbc")]
        public void TestMethod3(int number, params string[] array)
        {
            var result = ProcessStrings.SortingOperations(array);
            Assert.IsNotNull(result);
            Assert.AreEqual(number, result.Count);
            Assert.AreEqual("eeuuwwabnz", result[0]);
            Assert.AreEqual("fklnovwxyz", result[1]);
            Assert.AreEqual("eedfklnrxy", result[2]);
            Assert.AreEqual("ddafgioqsw", result[3]);
            Assert.AreEqual("ccbfikuvyz", result[4]);
        }

        [TestMethod]
        [DataRow(10, "qakmc", "rrtbk", "vaixn", "wmpnj", "uproi", "btska", "ejqwr", "elwlg", "oaoiy", "hrqkn")]
        public void TestMethod4(int number, params string[] array)
        {
            var result = ProcessStrings.SortingOperations(array);
            Assert.IsNotNull(result);
            Assert.AreEqual(number, result.Count);
            Assert.AreEqual("ackmq", result[0]);
            Assert.AreEqual("rrbkt", result[1]);
            Assert.AreEqual("ainvx", result[2]);
            Assert.AreEqual("jmnpw", result[3]);
            Assert.AreEqual("iopru", result[4]);
            Assert.AreEqual("abkst", result[5]);
            Assert.AreEqual("ejqrw", result[6]);
            Assert.AreEqual("llegw", result[7]);
            Assert.AreEqual("ooaiy", result[8]);
            Assert.AreEqual("hknqr", result[9]);
        }

        [TestMethod]
        [DataRow(3, "pzjim", "njnfq", "xyohs")]
        public void TestMethod5(int number, params string[] array)
        {
            var result = ProcessStrings.SortingOperations(array);
            Assert.IsNotNull(result);
            Assert.AreEqual(number, result.Count);
            Assert.AreEqual("ijmpz", result[0]);
            Assert.AreEqual("nnfjq", result[1]);
            Assert.AreEqual("hosxy", result[2]);
        }

        [TestMethod]
        [DataRow(5, "xqycs", "beoax", "afkso", "bldit", "gwrys")]
        public void TestMethod6(int number, params string[] array)
        {
            var result = ProcessStrings.SortingOperations(array);
            Assert.IsNotNull(result);
            Assert.AreEqual(number, result.Count);
            Assert.AreEqual("cqsxy", result[0]);
            Assert.AreEqual("abeox", result[1]);
            Assert.AreEqual("afkos", result[2]);
            Assert.AreEqual("bdilt", result[3]);
            Assert.AreEqual("grswy", result[4]);
        }
    }
}