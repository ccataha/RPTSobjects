using Microsoft.EntityFrameworkCore;
using RPTSobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using RPTSobj.ApplicationServices.Synchronization;
namespace RPTSobj.InfrastructureServices.Gateways.Database
{
    public class RPTSobjContext : DbContext
    {
        public DbSet<rptsobj> RPTSobjs { get; set; }

        public RPTSobjContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var v = new UseCaseRPTSobj();

            modelBuilder.Entity<rptsobj>().HasData(v.rptsobjs);
        }
    }
}
