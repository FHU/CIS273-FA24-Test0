using ParameterModifiers;

namespace UnitTests
{
    [TestClass]
    public class ParameterModifiersTests
    {
        // UNIT TESTS ARE UNFINISHED!

        // Questions:
        // Maybe add a test that checks if the input has a first or last name?

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

            input = "David Powell";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("", title);
        }

        [TestMethod]
        public void TestSplitNameIntoPartsSuffix()
        {
            string input = "Comic Sans, Jr.";
            string first, middle, last, title, suffix;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Jr.", suffix);

            input = "Mr. Comic Sans I";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("I", suffix);

            input = "Brother Comic Sans II";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("II", suffix);

            input = "Dr. Comic O. Sans III";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("III", suffix);

            input = "Comic S. Sans IV";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("IV", suffix);

            input = "Sister Comic Sans V";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("V", suffix);

            input = "Sans Comic, Sr.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Sr.", suffix);

            input = "Mr. Comic P. Sans, Esq.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Esq.", suffix);

            input = "Comic Sans";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("", suffix);

            input = "Mr. Comic J. Sans";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("", suffix);
        }

        [TestMethod]
        public void TestSplitNameIntoPartsFirst()
        {
            string input = "Miles Morales";
            string first, middle, last, title, suffix;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Miles", first);

            input = "Ms. Gwendolyn Stacy";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Gwendolyn", first);

            input = "Mr. Miguel O'Hara, Sr.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Miguel", first);

            input = "Hobart Brown IV";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Hobart", first);

            input = "Brother Peter Parker, Jr.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Peter", first);

            input = "Ms. Peni Parker";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Peni", first);

            input = "Brother Pavitr Prabhakar";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Pavitr", first);

            input = "Mr. Aaron Davis, Sr.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Aaron", first);
        }

        [TestMethod]
        public void TestSplitNameIntoPartsLast()
        {
            string input = "Miles Morales";
            string first, middle, last, title, suffix;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Morales", last);

            input = "Ms. Gwendolyn Stacy";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Stacy", last);

            input = "Mr. Miguel O'Hara, Sr.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("O'Hara", last);

            input = "Hobart Brown IV";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Brown", last);

            input = "Brother Peter Parker";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Parker", last);

            input = "Ms. Peni Parker";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Parker", last);

            input = "Brother Pavitr Prabhakar";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Prabhakar", last);

            input = "Mr. Aaron Davis, Sr.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("Davis", last);
        }

        [TestMethod]
        public void TestSplitNameIntoPartsMiddle()
        {
            string input = "Miles A. Morales";
            string first, middle, last, title, suffix;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("A.", middle);

            input = "Ms. Gwendolyn D. Stacy";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("D.", middle);

            input = "Mr. Miguel C. O'Hara, Sr.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("C.", middle);

            input = "Hobart L. Brown IV";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("L.", middle);

            input = "Brother Peter A. Parker";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("A.", middle);

            input = "Ms. Peni T. Parker";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("T.", middle);

            input = "Brother Pavitr S. Prabhakar";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("S.", middle);

            input = "Mr. Aaron Davis, Sr.";
            first = null; middle = null; last = null; title = null; suffix = null;
            Program.SplitNameIntoParts(input, out title, out first, out middle, out last, out suffix);
            Assert.AreEqual("", middle);
        }

        [TestMethod]
        public void TestReverseInPlace()
        {
            // I'm not exactly sure how to write out this test. Void is a nightmare to work with.

            //string s = "Papyrus is not a good font.";
            //Program.ReverseInPlace(s);
            //Assert.AreEqual(".tnof doog a ton si surypaP", Program.ReverseInPlace(s));
        }
    }
}
