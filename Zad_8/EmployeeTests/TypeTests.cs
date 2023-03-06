using Zad_8;

namespace EmployeeTests
{
    public class TypeTests
    {
        [Test]
        public void ComparsionPersonTypeRef()
        {
            //arrange
            var user1 = new Employee("Adam", "Nowak", 28);
            var user2 = new Employee("Adam", "Nowak", 28);

            //assert
            Assert.AreNotEqual(user1, user2);
        }

        [Test]
        public void ComparsionPersonTypeRef2() 
        {
            var pr1 = new Employee("Maciek");
            var pr2 = new Employee("Adam");
            var pr3 = pr1;

            Assert.AreEqual(pr1, pr3);
        }

        [Test]
        public void ComparsionNumberTypeValue()
        {
            int nr1 = 1;
            int nr2 = 1;

            Assert.AreEqual(nr1, nr2);
        }

        [Test]
        public void ComparsionStringTypeValue()
        {
            string name1 = "Dominik";
            string name2 = "Dominik";

            Assert.AreEqual(name1.ToString(), name2.ToString());
        }

        [Test]
        public void ComparsionDoubleTypeValue()
        {
            double nr1 = 8;
            double nr2 = 5;
            
            Assert.AreNotEqual(nr1, nr2);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
