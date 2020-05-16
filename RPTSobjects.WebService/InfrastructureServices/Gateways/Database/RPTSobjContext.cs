using Microsoft.EntityFrameworkCore;
using RPTSobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace RPTSobj.InfrastructureServices.Gateways.Database
{
    public class RPTSobjContext : DbContext
    {
        public DbSet<DomainObjects.RPTSobj> RPTSobjs { get; set; }


        public RPTSobjContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DomainObjects.RPTSobj>().HasData(
              new DomainObjects.RPTSobj()
              {
                  Id = 1L,
                  Name = "Успенский собор",
                  Address = "Кремль",
                  MetroStation = "Библиотека имени Ленина",
                  MetroLine = "Сокольническая линия",
                  WebSite = "http://assumption-cathedral.kreml.ru/"
              }
           );
        }      
    }
}
