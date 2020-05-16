using System.Threading.Tasks;
using System.Collections.Generic;
using RPTSobj.DomainObjects;
using RPTSobj.DomainObjects.Ports;
using RPTSobj.ApplicationServices.Ports;

namespace RPTSobj.ApplicationServices.GetRPTSobjListUseCase
{
    public class GetRPTSobjListUseCase : IGetRPTSobjListUseCase
    {
        private readonly IReadOnlyRPTSobjRepository _readOnlyRPTSobjRepository;

        public GetRPTSobjListUseCase(IReadOnlyRPTSobjRepository readOnlyRPTSobjRepository) 
            => _readOnlyRPTSobjRepository = readOnlyRPTSobjRepository;

        public async Task<bool> Handle(GetRPTSobjListUseCaseRequest request, IOutputPort<GetRPTSobjListUseCaseResponse> outputPort)
        {
            IEnumerable<DomainObjects.RPTSobj> rptsObjs = null;
            if (request.RPTSobjId != null)
            {
                var rptsObj = await _readOnlyRPTSobjRepository.GetRPTSobj(request.RPTSobjId.Value);
                rptsObjs = (rptsObj != null) ? new List<DomainObjects.RPTSobj>() { rptsObj } : new List<DomainObjects.RPTSobj>();
                
            }
            else if (request.MetroLine != null)
            {
                rptsObjs = await _readOnlyRPTSobjRepository.QueryRPTSobj(new MetroLineCriteria(request.MetroLine));
            }
            else
            {
                rptsObjs = await _readOnlyRPTSobjRepository.GetAllRPTSobjs();
            }
            outputPort.Handle(new GetRPTSobjListUseCaseResponse(rptsObjs));
            return true;
        }
    }
}
