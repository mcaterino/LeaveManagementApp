using LeaveManagement.Application.DTOs.LeaveRequest;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestListRequest : IRequest<List<LeaveRequestListDTO>>
    {
    }
}
