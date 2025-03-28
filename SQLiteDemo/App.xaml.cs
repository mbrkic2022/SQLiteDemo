using SQLiteDemo.Repositories;
using SQLiteDemo.Views;

namespace SQLiteDemo
{
    public partial class App : Application
    {
        public static CustomerRepository CustomerRepo { get; set; }
        public App(CustomerRepository repo)
        {
            InitializeComponent();
            CustomerRepo = repo;
            MainPage = new CustomerView();
        }
    }
}
