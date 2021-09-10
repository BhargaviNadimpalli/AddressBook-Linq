using System;

namespace AddressBookLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book using linq progrmas");

            AddressBook address = new AddressBook();
            address.AddressBookDataTable();
        }
    }
}
