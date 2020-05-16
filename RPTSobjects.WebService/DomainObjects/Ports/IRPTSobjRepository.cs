using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace RPTSobj.DomainObjects.Ports
{
    public interface IReadOnlyRPTSobjRepository
    {
        Task<RPTSobj> GetRPTSobj(long id);

        Task<IEnumerable<RPTSobj>> GetAllRPTSobjs();

        Task<IEnumerable<RPTSobj>> QueryRPTSobj(ICriteria<RPTSobj> criteria);

    }

    public interface IRPTSobjRepository
    {
        Task AddRPTSobj(RPTSobj rptsObj);

        Task RemoveRPTSobj(RPTSobj rptsObj);

        Task UpdateRPTSobj(RPTSobj rptsObj);
    }
}
