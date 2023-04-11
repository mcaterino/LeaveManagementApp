using AutoMapper;
using LeaveManagement.Application.DTOs.LeaveRequest;
using LeaveManagement.Application.Features.LeaveRequest.Requests.Queries;
using LeaveManagement.Application.Persistance.Contracts;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestListHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestDTO>>
    {
        private readonly ILeaveRequestRepository _repository;
        private readonly IMapper _mapper;

        public GetLeaveRequestListHandler(ILeaveRequestRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<LeaveRequestDTO>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _repository.GetLeaveRequestsWithDetails();
            return _mapper.Map<List<LeaveRequestDTO>>(leaveRequests);
        }
    }

}
