using NUnit.Framework;
using IzdanieModel;

namespace BookTestClass
{
    [TestFixture]
    public class TestBook
    {
        [Test]
        [TestCase("fairy tales", "ivanov", "F.D", "DROFA", "Phisics", "Kemerovo", 2017, 234, true,
            "ivanov, F.D. DROFA : Phisics / F.D. ivanov. – Kemerovo : fairy tales, 2017. – 234 с. ",
            TestName = "правильная строка")]
        [TestCase("fairy tales", "ivanov", "F.D", "DROFA", "Phisics", "Kemerovo", 2017, 234, false,
            "ivanov, F.D. DROFA : Phisics/F.D. ivanov. – Kemerovo : fairy tales, 2017. – 234 с. ",
            TestName = "неправильная строка")]
        public void TestBookInform(string nameIz, string surname, string initials, string title, string oblast, string city,
            int year, int page, bool shouldEquals, string inform)
        {
            var testBook = new Book();
            testBook.Nameiz = "fairy tales";
            testBook.Surname = "ivanov";
            testBook.Initials = "F.D.";
            testBook.Title = "DROFA";
            testBook.Oblast = "Phisics";
            testBook.City = "Kemerovo";
            testBook.Year = 2017;
            testBook.Page = 234;
            if (shouldEquals)
            {
                Assert.AreEqual(inform, testBook.Inform);
            }
            else
            {
                Assert.AreNotEqual(inform, testBook.Inform);
            }
        }
    }
}

