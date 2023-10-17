using System.Reflection;

namespace testCF
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Person.Person myPerson;

            // test no parameters constructor
            myPerson = new Person.Person();

            // test parameters constructor
            //myPerson = new Person.Person("Riccardo", "Zottoli", new DateTime(2003, 6, 27), "Roma");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Person.Person myPerson;

            // test no parameters constructor
            myPerson = new Person.Person();

            // test parameters constructor
            myPerson = new Person.Person("Riccardo", "Zottoli", new DateTime(2003, 6, 27), "Scandiano", "RE", 0);

            if(myPerson.FiscalCode() != "ZTTRCR03H27I496U")
            {
                throw new Exception("Errato");
            }
        }

        [TestMethod]
        public void TestMethod3()
        {
            Person.Person myPerson;

            // test no parameters constructor
            myPerson = new Person.Person();

            // test parameters constructor
            myPerson = new Person.Person("Riccardo", "Zottoli", new DateTime(2003, 6, 27), "Scandiano", "RE", 0);

            if (myPerson.Age() != 20)
            {
                throw new Exception("Errato");
            }
        }
    }
}