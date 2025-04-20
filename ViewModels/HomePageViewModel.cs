using EmployeesAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAPP.ViewModels
{
    public partial class HomePageViewModel
    {
        public List<LeaveApplication> Data { get; set; }
        public HomePageViewModel()
        {
             Data = new List<LeaveApplication>()
            {
                new LeaveApplication(){LeaveType = "Annual Leave", NofDays = 15},
                new LeaveApplication(){LeaveType = "Sick Leave", NofDays = 3},
                new LeaveApplication(){LeaveType = "Study Leave", NofDays = 5},
                new LeaveApplication(){LeaveType = "Paternity Leave", NofDays = 15},
                new LeaveApplication(){LeaveType = "Maternity Leave", NofDays = 10},
            };
        }
    }
}
