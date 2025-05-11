using CommunityToolkit.Mvvm.Input;
using EmployeesAPP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAPP.ViewModels
{
    public partial class LeaveApplicationListPageViewModel
    {
        public LeaveApplicationListPageViewModel()
        {
            
        }

        [RelayCommand]
        public async Task AddNewLeaveApplication()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddNewLeaveApplicationPage(new AddNewLeaveApplicationPageViewModel()));
        }
    }
}
