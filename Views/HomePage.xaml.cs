using EmployeesAPP.Helpers;
using EmployeesAPP.ViewModels;
using EmployeesAPP.Views;

namespace EmployeesAPP.Views;

public partial class HomePage : ContentPage
{
    private HomePageViewModel vm;
    public HomePage()
	{
		InitializeComponent();
        if (Settings.IsLoggedIn)
        {
            BindingContext = vm = new HomePageViewModel();
            Navigation.PushAsync(new HomePage());
        }
        else
        {
            Navigation.PushAsync(new LoginPage());
        }
    }
}