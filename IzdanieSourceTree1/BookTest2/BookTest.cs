using NUnit.Framework;
using IzdanieModel;

namespace BookTestClass
{
    public class TestBook
    {
        [Test]
        public void TestBookInform()
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
            //testBook.Number = 334;

            Assert.AreEqual("ivanov, F.D. DROFA : Phisics / F.D. ivanov. – Kemerovo : fairy tales, 2017. – 234 с. ",
                testBook.Inform);
            Assert.AreNotEqual("ivanov, F.D. DROFA : Phisics / F.D. ivanov. – Kemerovo : fairy tales, 2017. – 234с. ",
                testBook.Inform);

        }
    }
}
