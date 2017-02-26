using NUnit.Framework;
using IzdanieModel;

namespace ThesisTest
{
    [TestFixture]
    public class TestThesis
    {
        [Test]
        public void TestThesisInform()
        {
            var testThesis = new Thesis();
            testThesis.Patronymic = "Andreevich";
            testThesis.Surname = "Mikhailov";
            testThesis.Initials = "D.A.";
            testThesis.Position = "Bachelor";
            testThesis.City = "Kemerovo";
            testThesis.Year = 234;
            testThesis.Number = 334;

            Assert.AreEqual("Mikhailov Andreevich : Bachelor / Mikhailov D.A. Andreevich - Kemerovo, 334. - 234c.",
                testThesis.Inform);
            Assert.AreNotEqual("Mikhailov Andreevich  BachelorMikhailov D. Andreevich - Kemerovo, 334. - 234c.",
                testThesis.Inform);

        }
    }
}
