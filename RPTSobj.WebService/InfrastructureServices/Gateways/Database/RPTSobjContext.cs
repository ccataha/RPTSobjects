using Microsoft.EntityFrameworkCore;
using RPTSobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

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
            FillTestData(modelBuilder);
        }
        private void FillTestData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<rptsobj>().HasData(
                new
                {
                    Id = 1L,
                    Name = "Успенский собор",
                    Address = "Кремль",
                    MetroStation = "Библиотека имени Ленина",
                    MetroLine = "Сокольническая линия",
                    WebSite = "http://assumption-cathedral.kreml.ru/",
                },
                new
                {
                    Id = 2L,
                    Name = "Архангельский собор",
                    Address = "Кремль",
                    MetroStation = "Библиотека имени Ленина",
                    MetroLine = "Сокольническая линия",
                    WebSite = "http://archangel-cathedral.kreml.ru/",

                },
                new
                {
                    Id = 3L,
                    Name = "Благовещенский собор",
                    Address = "Кремль",
                    MetroStation = "Библиотека имени Ленина",
                    MetroLine = "Сокольническая линия",
                    WebSite = "http://annunciation-cathedral.kreml.ru/",

                },
                new
                {
                    Id = 4L,
                    Name = "Патриаршие палаты с церковью Двенадцати апостолов",
                    Address = "Кремль",
                    MetroStation = "Библиотека имени Ленина",
                    MetroLine = "Сокольническая линия",
                    WebSite = "http://www.kreml.ru/visit-to-kremlin/what-to-see/patriarshie-palaty-s-tserkovyu-dvenadtsati-apostolov",

                }
               
            );
        }
    }
}
