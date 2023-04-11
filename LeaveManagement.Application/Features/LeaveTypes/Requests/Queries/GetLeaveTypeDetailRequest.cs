using LeaveManagement.Application.DTOs.LeaveType;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<LeaveTypeDTO>
    {
        public int Id { get; set; }
    }
}
