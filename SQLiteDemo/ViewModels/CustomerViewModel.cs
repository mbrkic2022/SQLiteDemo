using Bogus;
using PropertyChanged;
using SQLiteDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SQLiteDemo.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class CustomerViewModel
    {
        public ObservableCollection<Customer> MyCollection { get; set; }

        public ICommand AddCommand { get; set; }

        public CustomerViewModel()
        {
            MyCollection = new ObservableCollection<Customer>(App.CustomerRepo.GetAll());
            AddCommand = new Command(() =>
            {
                var f = new Faker();
                Customer customer = new Customer
                {
                    Name = f.Name.FirstName(),
                    Surname = f.Name.LastName(),
                };
                MyCollection.Add(customer);
                App.CustomerRepo.Add(customer);
            });
        }
    }
}
