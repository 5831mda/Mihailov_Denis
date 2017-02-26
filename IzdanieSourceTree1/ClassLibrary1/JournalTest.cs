using NUnit.Framework;
using IzdanieModel;


namespace TestJournalClass
{
    [TestFixture]
    public class TestJournal
    {
        [Test]
        [TestCase("Nuton", "ivanov", "F.D","DROFA", 2017, 234, 334, true,
            "ivanov, F.D. DROFA/ F.D. ivanov//Nuton - 2017. - №234 - С.334.",
            TestName = "правильная строка")]
        [TestCase("Nuton", "ivanov", "F.D", "DROFA", 2017, 234, 334, false,
            "ivanov, F.D. DROFA / F.D. ivanov//Nuton -2017. - №234 - С.334.",
            TestName = "неправильная строка")]
        public void TestJournalInform(string nameIz, string surname, string initials, string title, 
            int year, int page, int number, bool shouldEquals, string inform)
        {
            var testJournal = new Journal();
            testJournal.Nameiz = "Nuton";
            testJournal.Surname = "ivanov";
            testJournal.Initials = "F.D.";
            testJournal.Title = "DROFA";
            testJournal.Year = 2017;
            testJournal.Page = 234;
            testJournal.Number = 334;
            if (shouldEquals)
            {
                Assert.AreEqual(inform, testJournal.Inform);
            }
            else
            {
                Assert.AreNotEqual(inform, testJournal.Inform);
            }

        }
    }
}
