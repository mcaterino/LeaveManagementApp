using LeaveManagement.Application.DTOs.LeaveAllocation;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationDetailRequest : IRequest<LeaveAllocationDTO>
    {
        public int Id { get; set; }
    }
}
