using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RPTSobj.InfrastructureServices.Gateways.Database;
using RPTSobj.WebService.InfrastructureServices.Gateways;
using RPTSobj.WebService.Scheduler;
using System.IO;

namespace RPTSobj.WebService.Scheduler
{
    public class ScheduleTask : ScheduledProcessor
    {

        public ScheduleTask(IServiceScopeFactory serviceScopeFactory) : base(serviceScopeFactory)
        {
        }

        protected override string Schedule => "*/1 * * * *";

        public override Task ProcessInScope(IServiceProvider serviceProvider)
        {

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string result = client.DownloadString("https://apidata.mos.ru/v1/datasets/2624/rows?api_key=b830358d40b1d55aa8d34b4f33b5f6c6");
            List<ResultFromServer> resultServer = JsonConvert.DeserializeObject<List<ResultFromServer>>(result);
            var optionsBuilder = new DbContextOptionsBuilder<RPTSobjContext>();
            string newPath = System.IO.Path.GetFullPath(System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"..\"));
            string newnewpath = System.IO.Path.Combine(newPath, "RPTSobj.WebService", "RPTSobj.db");
            optionsBuilder.UseSqlite($"Data Source={newnewpath}");
            var context = new RPTSobjContext(options: optionsBuilder.Options);
            context.Database.ExecuteSqlRaw("DELETE FROM RPTSobj");
            using (context)
            {
                foreach (var item in resultServer)
                {
                    DomainObjects.rptsobj rptsobj = new DomainObjects.rptsobj();
                    rptsobj.Name = item.Cells.Name;
                    rptsobj.Address = item.Cells.Address;
                    rptsobj.MetroStation = item.Cells.MetroStation;
                    rptsobj.MetroLine = item.Cells.MetroLine;
                    rptsobj.WebSite = item.Cells.WebSite;
                    context.Entry(rptsobj).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
        
            
            Console.WriteLine("Database was updated");
            return Task.CompletedTask;
        }
    }
}
