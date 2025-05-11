using EmployeesAPP.ViewModels;

namespace EmployeesAPP.Views;

public partial class EmployeesListPage : ContentPage
{
    public EmployeesListPage(EmployeesListPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
    }
}