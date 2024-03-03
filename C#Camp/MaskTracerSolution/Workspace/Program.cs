
using Business.Concrete;
using Entities.Concrete;
// you can try it with real national identity information
Person person1 = new Person();
person1.Name = "DENEME";
person1.Surname = "DENEME";
person1.NationalIdentity = 2132141242;
person1.DateOfBirthYear = 2005;

Person person2 = new Person();
person2.Name = "ahmet";
Person[] persons = new Person[] { person1, person2 };
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);
Console.ReadLine();