using RPTSobj.DomainObjects;
using RPTSobj.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPTSobj.ApplicationServices.GetRPTSobjListUseCase
{
    public class GetRPTSobjListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<DomainObjects.RPTSobj> RPTSobj { get; }

        public GetRPTSobjListUseCaseResponse(IEnumerable<DomainObjects.RPTSobj> rptsObj) => RPTSobj = rptsObj;
    }
}
