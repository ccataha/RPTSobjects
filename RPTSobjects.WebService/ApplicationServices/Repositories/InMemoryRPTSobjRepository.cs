using RPTSobj.DomainObjects;
using RPTSobj.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RPTSobj.ApplicationServices.Repositories
{
    public class InMemoryRPTSobjRepository : IReadOnlyRPTSobjRepository,
                                             IRPTSobjRepository 
    {
        private readonly List<DomainObjects.RPTSobj> _rptsObjs = new List<DomainObjects.RPTSobj>();

        public InMemoryRPTSobjRepository(IEnumerable<DomainObjects.RPTSobj> rptsObjs = null)
        {
            if (rptsObjs != null)
            {
                _rptsObjs.AddRange(rptsObjs);
            }
        }

        public Task AddRPTSobj(DomainObjects.RPTSobj rptsObj)
        {
            _rptsObjs.Add(rptsObj);
            return Task.CompletedTask;
        }

        public Task<IEnumerable<DomainObjects.RPTSobj>> GetAllRPTSobjs()
        {
            return Task.FromResult(_rptsObjs.AsEnumerable());
        }

        public Task<DomainObjects.RPTSobj> GetRPTSobj(long id)
        {
            return Task.FromResult(_rptsObjs.Where(r => r.Id == id).FirstOrDefault());
        }

        public Task<IEnumerable<DomainObjects.RPTSobj>> QueryRPTSobj(ICriteria<DomainObjects.RPTSobj> criteria)
        {
            return Task.FromResult(_rptsObjs.Where(criteria.Filter.Compile()).AsEnumerable());
        }

        public Task RemoveRPTSobj(DomainObjects.RPTSobj rptsObj)
        {
            _rptsObjs.Remove(rptsObj);
            return Task.CompletedTask;
        }

        public Task UpdateRPTSobj(DomainObjects.RPTSobj rptsObj)
        {
            var foundRPTSobj = GetRPTSobj(rptsObj.Id).Result;
            if (foundRPTSobj == null)
            {
                AddRPTSobj(rptsObj);
            }
            else
            {
                if (foundRPTSobj != rptsObj)
                {
                    _rptsObjs.Remove(foundRPTSobj);
                    _rptsObjs.Add(rptsObj);
                }
            }
            return Task.CompletedTask;
        }
    }
}
