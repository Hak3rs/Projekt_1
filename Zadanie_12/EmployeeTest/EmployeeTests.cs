using Zadanie_12;

namespace EmployeeTest
{
    public class Tests
    {
        [Test]
        public void WhenIndicatorOnTheSameShouldTrue()
        {
            var emp1 = new Employee("Kamil", "Milczewski");
            var emp2 = new Employee("Adam", "Markowski");
            var emp3 = emp1;

            Assert.AreEqual(emp1, emp3);
        }

        [Test]
        public void WhenGiveGradesShouldShowAverage()
        {
            var emp4 = new Employee("Anna", "Milczewska");
            emp4.AddGrade(1);
            emp4.AddGrade(2);
            emp4.AddGrade(3);
            emp4.AddGrade(4);

            var statemp4 = emp4.GetStatistics();
            Assert.AreEqual(2.5, statemp4.Average);
        }

        [Test]
        public void WhenGiveGradesShouldShowMinValueAndMaxValue()
        {
            var emp5 = new Employee("Karol", "Rachwal");
            emp5.AddGrade(1);
            emp5.AddGrade(2);
            emp5.AddGrade(3);
            emp5.AddGrade(4);
            emp5.AddGrade(5);
            emp5.AddGrade(6);
            emp5.AddGrade(7);
            emp5.AddGrade(8);
            emp5.AddGrade(9);


            var statemp5 = emp5.GetStatistics();

            Assert.AreEqual(9, statemp5.Max);
            Assert.AreEqual(1, statemp5.Min);
        }

        [Test]
        public void WhenGiveNewPersonShouldShowNewPersonDatails_()
        {
            var emp6 = new Employee("Roman", "Kwiatkowski");
            var person = emp6.Name + " " + emp6.Surname;
            Assert.AreEqual("Roman Kwiatkowski", person);
        }

        [Test]
        public void WhenGiveNewValueCharAndStringShouldAverageDetails()
        {
            var emp7 = new Employee("Jacek", "Milosz");
            emp7.AddGrade('a');
            emp7.AddGrade('B');
            emp7.AddGrade('c');
            emp7.AddGrade('D');
            emp7.AddGrade("2");
            emp7.AddGrade("ola");

            var statemp7 = emp7.GetStatistics();

            Assert.AreEqual(6, statemp7.Average);
        }

        [Test]
        public void WhenGiveNewValueCharAndStringShouldAverageLetter()
        {
            var emp7 = new Employee("Jacek", "Milosz");
            emp7.AddGrade('a');
            emp7.AddGrade('B');
            emp7.AddGrade('c');
            emp7.AddGrade('D');
            emp7.AddGrade("2");
            emp7.AddGrade("ola");

            var statemp7 = emp7.GetStatistics();

            Assert.AreEqual('B', statemp7.AverageLetter);
        }
    }
}