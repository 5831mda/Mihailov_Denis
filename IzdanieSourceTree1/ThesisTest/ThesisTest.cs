using NUnit.Framework;
using IzdanieModel;

namespace ThesisTest
{
    [TestFixture]
    public class TestThesis
    {
        [Test]
        [TestCase("Andreevich", "Mikhailov", "D.A.", "Bachelor", "Kemerovo", 234, 334, true,
           "Mikhailov Andreevich : Bachelor / Mikhailov D.A. Andreevich - Kemerovo, 334. - 234c.",
            TestName = "правильная строка")]
        [TestCase("Andreevich", "Mikhailov", "D.A.", "Bachelor", "Kemerovo", 234, 334, false,
           "Mikhailov Andreevich:BachelorMikhailovD.A. Andreevich - Kemerovo, 334. - 234c.",
            TestName = "неправильная строка")]
        public void TestThesisInform(string patronymic, string surname, string initials, string position,
            string city, int year, int number, bool shouldEquals, string inform)
        {
            var testThesis = new Thesis();
            testThesis.Patronymic = "Andreevich";
            testThesis.Surname = "Mikhailov";
            testThesis.Initials = "D.A.";
            testThesis.Position = "Bachelor";
            testThesis.City = "Kemerovo";
            testThesis.Year = 234;
            testThesis.Number = 334;
            if (shouldEquals)
            {
                Assert.AreEqual(inform, testThesis.Inform);
            }
            else
            {
                Assert.AreNotEqual(inform, testThesis.Inform);
            }
        }
    }
}
