using SQLiteDemo.ViewModels;

namespace SQLiteDemo.Views;

public partial class CustomerView : ContentPage
{
	public CustomerView()
	{
		InitializeComponent();
		BindingContext = new CustomerViewModel();
	}
}