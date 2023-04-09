using LeaveManagement.Application.DTOs.Common;

namespace LeaveManagement.Application.DTOs.LeaveType
{
    public class LeaveTypeDTO : BaseDTO
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
