// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Person.Person myPerson;

// test no parameters constructor
myPerson = new Person.Person();

// test parameters constructor
myPerson = new Person.Person("Riccardo", "Zottoli", new DateTime(2003, 6, 27), "Scandiano", "RE", 0);

Console.WriteLine(myPerson.FiscalCode());