using LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestDetailRequest : IRequest<LeaveRequestDTO>
    {
        public int Id { get; set; }
    }
}
