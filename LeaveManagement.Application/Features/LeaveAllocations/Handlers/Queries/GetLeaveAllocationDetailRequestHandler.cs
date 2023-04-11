using AutoMapper;
using LeaveManagement.Application.DTOs.LeaveAllocation;
using LeaveManagement.Application.Features.LeaveAllocations.Requests.Queries;
using LeaveManagement.Application.Persistance.Contracts;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveAllocations.Handlers.Queries
{
    internal class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDTO>
    {
        private readonly ILeaveAllocationRepository _repository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<LeaveAllocationDTO> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _repository.Get(request.Id);
            return _mapper.Map<LeaveAllocationDTO>(leaveAllocation);
        }
    }
}
