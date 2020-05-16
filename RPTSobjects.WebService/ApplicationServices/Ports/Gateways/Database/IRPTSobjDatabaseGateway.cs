using RPTSobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RPTSobj.ApplicationServices.Ports.Gateways.Database
{
    public interface IRPTSobjDatabaseGateway
    {
        Task AddRPTSobj(DomainObjects.RPTSobj rptsObj);

        Task RemoveRPTSobj(DomainObjects.RPTSobj rptsObj);

        Task UpdateRPTSobj(DomainObjects.RPTSobj rptsObj);

        Task<DomainObjects.RPTSobj> GetRPTSobj(long id);

        Task<IEnumerable<DomainObjects.RPTSobj>> GetAllRPTSobj();

        Task<IEnumerable<DomainObjects.RPTSobj>> QueryRPTSobj(Expression<Func<DomainObjects.RPTSobj, bool>> filter);

    }
}
