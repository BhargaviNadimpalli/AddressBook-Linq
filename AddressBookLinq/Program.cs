
using System;
using System.Data;
using System.Linq;

namespace AddressBookLinq
{
    class Program
    {
        public static AddressBookData Person { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to address book using linq progrmas");

            AddressBook addressBook = new AddressBook();

            DataTable dataTable = addressBook.AddAddressBookData();
           
            addressBook.DeleteContact(dataTable);
            
        }
    }
}
