using EmployeesAPP.ViewModels;

namespace EmployeesAPP.Views;

public partial class LeaveApplicationListPage : ContentPage
{
	public LeaveApplicationListPage(LeaveApplicationListPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
    }
}