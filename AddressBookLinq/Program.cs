
using System;
using System.Linq;

namespace AddressBookLinq
{
    class Program
    {
        public static AddressBookData Person { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book using linq progrmas");

            AddressBook address = new AddressBook();
            address.InsertIntoDataTable(Person);
            address.ModifyDataTableUsingName("Bhagi", Person);
            address.DisplayDataTable();
        }
    }
}
