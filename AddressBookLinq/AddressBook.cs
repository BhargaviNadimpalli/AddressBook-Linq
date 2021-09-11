using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                table.Rows.Add("Bhagi", "latha", "ap", "ap", "ap", 1223098987, 966080, "bhagi@gmail.com");
            table.Rows.Add("Manu", "y", "ap", "mp", "ma", 189865345, 345678, "manu@gmail.com");
            table.Rows.Add("Tanu", "t", "Hyd", "ap", "ppq", 1219862744, 456788, "tanu@gmail.com");
            table.Rows.Add("Prethi", "tbms", "tyvb", "uaa", "khd", 983459623, 987654, "preethi@gmail.com");
            table.Rows.Add("Kumar", "s", "mu", "tum", "kncs", 527652345, 798833, "kumar@gmail.com");
            }
        public void ModifyDataTableUsingName(string name, AddressBookData Person)
        {
            string output = string.Empty;
            //insert into table
            InsertIntoDataTable(Person);
            var res = (from person in dataTable.AsEnumerable() where person.Field<string>("FirstName").Equals(name) select person).LastOrDefault();//returns last element satisfies the condition or default value
            if (res != null)
            {
                res["LastName"] = "NN";
                //display after its modified
                Console.WriteLine("After Modification");
                DisplayDataTable();
                output = "success";
            }
            
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
