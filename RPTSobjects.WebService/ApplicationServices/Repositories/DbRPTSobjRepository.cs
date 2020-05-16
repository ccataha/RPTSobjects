using RPTSobj.ApplicationServices.Ports.Gateways.Database;
using RPTSobj.DomainObjects;
using RPTSobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RPTSobj.ApplicationServices.Repositories
{
    public class DbRPTSobjRepository : IReadOnlyRPTSobjRepository,
                                     IRPTSobjRepository
    {
        private readonly IRPTSobjDatabaseGateway _databaseGateway;

        public DbRPTSobjRepository(IRPTSobjDatabaseGateway databaseGateway)
            => _databaseGateway = databaseGateway;

        public async Task<DomainObjects.RPTSobj> GetRPTSobj(long id)
            => await _databaseGateway.GetRPTSobj(id);

        public async Task<IEnumerable<DomainObjects.RPTSobj>> GetAllRPTSobjs()
            => await _databaseGateway.GetAllRPTSobj();

        public async Task<IEnumerable<DomainObjects.RPTSobj>> QueryRPTSobj(ICriteria<DomainObjects.RPTSobj> criteria)
            => await _databaseGateway.QueryRPTSobj(criteria.Filter);

        public async Task AddRPTSobj(DomainObjects.RPTSobj rptsObj)
            => await _databaseGateway.AddRPTSobj(rptsObj);

        public async Task RemoveRPTSobj(DomainObjects.RPTSobj rptsObj)
            => await _databaseGateway.RemoveRPTSobj(rptsObj);

        public async Task UpdateRPTSobj(DomainObjects.RPTSobj rptsObj)
            => await _databaseGateway.UpdateRPTSobj(rptsObj);
    }
}
