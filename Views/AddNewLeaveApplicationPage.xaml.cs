using EmployeesAPP.ViewModels;

namespace EmployeesAPP.Views;

public partial class AddNewLeaveApplicationPage : ContentPage
{
	public AddNewLeaveApplicationPage(AddNewLeaveApplicationPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
    }
}