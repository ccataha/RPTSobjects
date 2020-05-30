using RPTSobj.ApplicationServices.Ports.Cache;
using RPTSobj.DomainObjects;
using RPTSobj.DomainObjects.Ports;
using RPTSobj.DomainObjects.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RPTSobj.InfrastructureServices.Repositories
{
    public class CachedReadOnlyRPTSobjRepository : ReadOnlyRPTSobjtRepositoryDecorator
    {
        private readonly IDomainObjectsCache<RPTSobjt> _rptsobjsCache;

        public CachedReadOnlyRPTSobjRepository(IReadOnlyRPTSobjtRepository rptsobjRepository, 
                                             IDomainObjectsCache<RPTSobjt> rptsobjsCache)
            : base(rptsobjRepository)
            => _rptsobjsCache = rptsobjsCache;

        public async override Task<RPTSobj> GetRPTSobjt(long id)
            => _rptsobjsCache.GetObject(id) ?? await base.GetRPTSobj(id);

        public async override Task<IEnumerable<RPTSobj>> GetAllRPTSobjs()
            => _rptsobjsCache.GetObjects() ?? await base.GetAllRPTSobjs();

        public async override Task<IEnumerable<RPTSobj>> QueryRPTSobjs(ICriteria<RPTSobj> criteria)
            => _rptsobjsCache.GetObjects()?.Where(criteria.Filter.Compile()) ?? await base.QueryRPTSobjs(criteria);

    }
}
