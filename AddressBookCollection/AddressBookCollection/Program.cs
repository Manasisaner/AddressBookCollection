// See https://aka.ms/new-console-template for more information
using System;

namespace AddressBookCollection
{
  class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Address Book Program");
            Person person = new Person("Manasi", "Saner", "Nashik", "Maharashtra", "422010", "7020648548", "snehasonwane01@gmail.com");
            Console.WriteLine(person.getName());
            Console.WriteLine(person.getlastName());
            Console.WriteLine(Person.getaddress());
            Console.WriteLine(person.getcity());
            Console.WriteLine(person.getstate());
            Console.WriteLine(person.getzip());
            Console.WriteLine(person.getphone());
            Console.WriteLine(person.getemail());
            Console.Read();
        }
    }
}