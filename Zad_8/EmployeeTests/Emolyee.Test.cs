using Zad_8;

namespace EmployeTests
{
    public class Tests
    {
        [Test]
        public void WhenAddPoints_ShouldBeSummary()
        {
            //arrange
            var pr5 = new Employee("Krzysztof", "Markowski", 28);
            pr5.DodajPKT(2);
            pr5.DodajPKT(3);
            pr5.DodajPKT(4);

            //act
            var result = pr5.suma_pkt;

            //assert
            Assert.AreEqual(9, result);
        }

        [Test]
        public void WhenAddNewEmployee_ShouldBeHisDetails()
        {
            //arrange
            var pr6 = new Employee("Maciek", "Markowski", 35);
            //act
            var osoba = pr6.imie + " " + pr6.nazwisko + " " + pr6.wiek;

            //assert
            Assert.That(osoba, Is.EqualTo("Maciek Markowski 35"));
        }

        [Test]
        public void WhenAddNegativePoints_ShouldTrueSummary()
        {
            //arrange
            var pr5 = new Employee("Krzysztof", "Markowski", 28);
            pr5.DodajPKT(2);
            pr5.DodajPKT(-3);
            pr5.DodajPKT(4);

            //act
            var result = pr5.suma_pkt;

            //assert
            Assert.AreEqual(3, result);
        }
    }
       
}