using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAPP.Models
{
    public class LeaveApplication
    {
        public int Id { get; set; }
        public int LeaveTypeId { get; set; }
        public string LeaveType { get; set; }
        public decimal NofDays { get; set; }
    }
}
