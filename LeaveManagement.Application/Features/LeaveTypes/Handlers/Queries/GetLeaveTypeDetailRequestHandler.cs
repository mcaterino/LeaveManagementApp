using AutoMapper;
using LeaveManagement.Application.DTOs.LeaveType;
using LeaveManagement.Application.Features.LeaveTypes.Requests.Queries;
using LeaveManagement.Application.Persistance.Contracts;
using MediatR;

namespace LeaveManagement.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDTO>
    {
        private readonly ILeaveTypeRepository _repository;
        private readonly IMapper _mapper;

        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<LeaveTypeDTO> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveType = await _repository.Get(request.Id);
            return _mapper.Map<LeaveTypeDTO>(leaveType);
        }
    }
}
