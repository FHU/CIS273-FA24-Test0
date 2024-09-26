using ParameterModifiers;

namespace UnitTests
{
    [TestClass]
    public class ParameterModifiersTests
    {
        // UNIT TESTS ARE UNFINISHED!

        [TestMethod]
        public void TestSplitNameIntoPartsTitle()
        {
            string input = "Dr. David Powell";
            string first, middle, last, title, suffix;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Dr.", title);

            input = "Mr. David Powell";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Mr.", title);

            input = "Mrs. Cathy Powell";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Mrs.", title);

            input = "Ms. Cathy Powell";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Ms.", title);

            input = "Brother David Powell";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Brother", title);

            input = "Sister Cathy Powell";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Sister", title);
        }

        [TestMethod]
        public void TestSplitNameIntoPartsSuffix()
        {
            string input = "Comic Sans, Jr.";
            string first, middle, last, title, suffix;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Jr.", suffix);

            input = "Comic Sans I";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("I", suffix);

            input = "Comic Sans II";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("II", suffix);

            input = "Comic Sans III";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("III", suffix);

            input = "Comic Sans IV";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("IV", suffix);

            input = "Comic Sans V";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("V", suffix);

            input = "Comic Sans, Sr.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Sr.", suffix);


            input = "Comic Sans, Esq.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Esq.", suffix);
        }
    }
}
