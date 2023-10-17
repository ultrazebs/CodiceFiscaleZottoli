using static Person.Person;
using System.Globalization;

Person.Person myPerson;



// test parameters constructor
myPerson = new Person.Person("Riccardo", "Zottoli", new DateTime(2003, 6, 27), "Scandiano", "RE", Person.Person.GenderType.Male);
Console.WriteLine(myPerson.FirstName);

Console.WriteLine(myPerson.FiscalCode());

int choice;

do
{
    choice = myPerson.menu();
    switch (choice)
    {
        case 1:
            Console.WriteLine("case 1");
            myPerson = Registration();
            break;
        case 2:
            Console.WriteLine(myPerson.FiscalCode());
            break;
        case 3:
            Console.WriteLine(myPerson.Age());
            break;
        case 4:
            myPerson.Print() ;
            break;
        case 0:
            break;
    }
}
while (choice != 0);




/// <summary>
/// Method for registration of new Person
/// </summary>
Person.Person Registration()
{
    string FirstName;
    string LastName;
    DateTime BirthDate;
    string BirthCity;
    string BirthCountry;
    GenderType Gender;


    Console.WriteLine("Enter First Name: ");
    FirstName = Console.ReadLine();
    Console.WriteLine("Enter Second Name: ");
    LastName = Console.ReadLine();
    Console.WriteLine("Enter Birth date in the following format (yyyy/mm/dd): ");
    BirthDate = DateTime.ParseExact(Console.ReadLine(), "yyyy/mm/dd", CultureInfo.InvariantCulture);
    Console.WriteLine("Birth City: ");
    BirthCity = Console.ReadLine();
    Console.WriteLine("Birth Country: ");
    BirthCountry = Console.ReadLine();
    Gender = giveGender();

    Person.Person p1 = new Person.Person(FirstName, LastName, BirthDate, BirthCity, BirthCountry, Gender);

    return p1;
}

/// <summary>
/// emthod that takes a string ads an input and returns the gender
/// </summary>
/// <returns></returns>
GenderType giveGender()
{
    GenderType gender;
    string answer;
    Console.WriteLine("Male(M) of Female(F)?");
    answer = Console.ReadLine();
    if (answer == "M")
        gender = GenderType.Male;
    else
        gender = GenderType.Female;

    return gender;


}