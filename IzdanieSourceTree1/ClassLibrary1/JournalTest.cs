using NUnit.Framework;
using IzdanieModel;


namespace TestJournalClass
{
    [TestFixture]
    public class TestJournal
    {
        [Test]
        public void TestJournalInform()
        {
            var testJournal = new Journal();
            testJournal.Nameiz = "Nuton";
            testJournal.Surname = "ivanov";
            testJournal.Initials = "F.D.";
            testJournal.Title = "DROFA";
            testJournal.Year = 2017;
            testJournal.Page = 234;
            testJournal.Number = 334;

            Assert.AreEqual("ivanov, F.D. DROFA/ F.D. ivanov//Nuton - 2017. - №234 - С.334.",
                testJournal.Inform);
            Assert.AreNotEqual("ivanov, FD DROFA/ F.D. ivanov//Nuton - 2017. - №234 - С.334.",
                testJournal.Inform);

        }
    }
}
