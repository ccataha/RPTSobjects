using RPTSobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using RPTSobj.ApplicationServices.Ports.Gateways.Database;

namespace RPTSobj.InfrastructureServices.Gateways.Database
{
    public class RPTSobjEFSqliteGateway : IRPTSobjDatabaseGateway
    {
        private readonly RPTSobjContext _rptsObjContext;

        public RPTSobjEFSqliteGateway(RPTSobjContext rptsObjContext)
            => _rptsObjContext = rptsObjContext;

        public async Task<DomainObjects.RPTSobj> GetRPTSobj(long id)
           => await _rptsObjContext.RPTSobjs.FirstOrDefaultAsync();

        public async Task<IEnumerable<DomainObjects.RPTSobj>> GetAllRPTSobj()
            => await _rptsObjContext.RPTSobjs.ToListAsync();
          
        public async Task<IEnumerable<DomainObjects.RPTSobj>> QueryRPTSobj(Expression<Func<DomainObjects.RPTSobj, bool>> filter)
            => await _rptsObjContext.RPTSobjs.Where(filter).ToListAsync();

        public async Task AddRPTSobj(DomainObjects.RPTSobj rptsObj)
        {
            _rptsObjContext.RPTSobjs.Add(rptsObj);
            await _rptsObjContext.SaveChangesAsync();
        }

        public async Task UpdateRPTSobj(DomainObjects.RPTSobj rptsobj)
        {
            _rptsObjContext.Entry(rptsobj).State = EntityState.Modified;
            await _rptsObjContext.SaveChangesAsync();
        }

        public async Task RemoveRPTSobj(DomainObjects.RPTSobj rptsobj)
        {
            _rptsObjContext.RPTSobjs.Remove(rptsobj);
            await _rptsObjContext.SaveChangesAsync();
        }


       
    }
}
