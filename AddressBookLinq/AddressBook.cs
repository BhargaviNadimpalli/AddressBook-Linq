using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AddressBookLinq
{
    public class AddressBook
    {
        DataTable dataTable;
        DataTable table = new DataTable("AddressBook");

        public void AddressBookData()
        {
            dataTable = new DataTable();
            

            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));
        }
            public void InsertIntoDataTable(AddressBookData Person)
            {
                table.Rows.Add("Bhagi", "latha", "ap", "ap", "ap", 966080, "122345098987", "bhagi@gmail.com");
            table.Rows.Add("Manu", "y", "ap", "mp", "ma", 345678, "189865345", "manu@gmail.com");
            table.Rows.Add("Tanu", "t", "Hyd", "ap", "ppq", 456788, "12319862744", "tanu@gmail.com");
            table.Rows.Add("Prethi", "tbms", "tyvb", "uaa", "khd", 987654, "9283459623", "preethi@gmail.com");
            table.Rows.Add("Kumar", "s", "mu", "tum", "kncs", 798833, "527652345", "kumar@gmail.com");

            

        }

        public void DisplayDataTable()
        {
           
            foreach (DataRow row in table.Rows)
            {

                Console.WriteLine($"{row["FirstName"]} | { row["LastName"]} | {row["Address"]} | {row["City"]} | {row["State"]} | {row["ZipCode"]} | {row["PhoneNumber"]} | {row["Email"]}\n");
            }
        }
    }

}
