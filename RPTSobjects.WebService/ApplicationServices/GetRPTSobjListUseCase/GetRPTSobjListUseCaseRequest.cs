using RPTSobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPTSobj.ApplicationServices.GetRPTSobjListUseCase
{
    public class GetRPTSobjListUseCaseRequest : IUseCaseRequest<GetRPTSobjListUseCaseResponse>
    {
        public string MetroLine { get; private set; }
        public long? RPTSobjId { get; private set; }

        private GetRPTSobjListUseCaseRequest()
        { }

        public static GetRPTSobjListUseCaseRequest CreateAllRPTSobjRequest()
        {
            return new GetRPTSobjListUseCaseRequest();
        }

        public static GetRPTSobjListUseCaseRequest CreateRPTSobjRequest(long rptsObjId)
        {
            return new GetRPTSobjListUseCaseRequest() { RPTSobjId = rptsObjId };
        }
        public static GetRPTSobjListUseCaseRequest CreateMetroLineRPTSobjRequest(string rptsObjs)
        {
            return new GetRPTSobjListUseCaseRequest() { MetroLine = rptsObjs };
        }
    }
}
