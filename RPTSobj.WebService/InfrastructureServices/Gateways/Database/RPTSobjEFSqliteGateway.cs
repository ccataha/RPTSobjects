using RPTSobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using RPTSobj.ApplicationServices.Ports.Gateways.Database;
using System.Net;
using RPTSobj.WebService.InfrastructureServices.Gateways;
using System.Text;
using Newtonsoft.Json;

namespace RPTSobj.InfrastructureServices.Gateways.Database
{
    public class RPTSobjEFSqliteGateway : IRPTSobjDatabaseGateway
    {
        private readonly RPTSobjContext _rptsobjContext;

        public RPTSobjEFSqliteGateway(RPTSobjContext RPTSobjContext)
            => _rptsobjContext = RPTSobjContext;

        public async Task<rptsobj> GetRPTSobj(long id)
           => await _rptsobjContext.RPTSobjs.Where(b => b.Id == id).FirstOrDefaultAsync();

        public async Task<IEnumerable<rptsobj>> GetAllRPTSobjs()
            => await _rptsobjContext.RPTSobjs.ToListAsync();
          
        public async Task<IEnumerable<rptsobj>> QueryRPTSobjs(Expression<Func<rptsobj, bool>> filter)
            => await _rptsobjContext.RPTSobjs.Where(filter).ToListAsync();

        public async Task AddRPTSobj(rptsobj rptsobj)
        {
            _rptsobjContext.RPTSobjs.Add(rptsobj);
            await _rptsobjContext.SaveChangesAsync();
        }

        public async Task UpdateRPTSobj(rptsobj rptsobj)
        {
            _rptsobjContext.Entry(rptsobj).State = EntityState.Modified;
            await _rptsobjContext.SaveChangesAsync();
        }

        public async Task RemoveRPTSobj(rptsobj rptsobj)
        {
            _rptsobjContext.RPTSobjs.Remove(rptsobj);
            await _rptsobjContext.SaveChangesAsync();
        }
        public async Task ParseAndPush()
        {
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString("https://apidata.mos.ru/v1/datasets/593/rows?$top=7&api_key=fee68e1ff9da6aa97c7deb04d48c82d1");
            List<ResultFromServer> resultServer = JsonConvert.DeserializeObject<List<ResultFromServer>>(result);
            var optionsBuilder = new DbContextOptionsBuilder<RPTSobjContext>();
            optionsBuilder.UseSqlite("Data Source=D:/всякое/3_Курс/2_СЕМ/ООП/lab8-testbuid/RPTSobj.WebService/RPTSobj.db"); ;
            var context = new RPTSobjContext(options: optionsBuilder.Options);
            context.Database.ExecuteSqlRaw("DELETE FROM Products");
            using (context)
            {
                foreach (var item in resultServer)
                {
                    DomainObjects.rptsobj rptsobj= new DomainObjects.rptsobj();
                    rptsobj.Name = item.Cells.Name;
                    rptsobj.Address = item.Cells.Address;
                    rptsobj.MetroStation = item.Cells.MetroStation;
                    rptsobj.MetroLine = item.Cells.MetroLine;
                    rptsobj.WebSite = item.Cells.WebSite;
                    context.Entry(rptsobj).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            await Task.CompletedTask;
        }

    }
}
