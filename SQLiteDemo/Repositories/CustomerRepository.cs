using SQLite;
using SQLiteDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.Repositories
{
    public class CustomerRepository
    {
        SQLiteConnection connection;
        string StatusMessage;

        public CustomerRepository()
        {
            connection = new SQLiteConnection(Constants.DataBasePath, Constants.Flags);
            connection.CreateTable<Customer>();
        }

        public void Add(Customer newCustomer)
        {
            int result = 0;
            try
            {
                result = connection.Insert(newCustomer);
                StatusMessage = $"{result} row(s) added!";
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
        }

        public  List<Customer> GetAll()
        {
            try
            {

                return connection.Table<Customer>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage = $"Error: {ex.Message}";
            }
            return null;
        }
    }
}
