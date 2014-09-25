using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();
            phonebook.AddContact("Lebohang", "Danster", "0747111234");
            phonebook.AddContact("Musa", "Baloyi", "0747111234");
            Console.WriteLine(phonebook.DisplayContacts());
            Console.ReadLine();
        }
    }
}