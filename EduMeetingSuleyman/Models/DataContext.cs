using EduMeetingSuleyman.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing;

namespace EduMeetingSuleyman.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) //veritabanı nesnesi oluşturduk..
        {
        }


         //normalde burada bekir hocanın fluent apisi var.. bekir h dosyasında eski halinin ss'i var.


        //tabloların oluşturulması
        public DbSet<Service> Service { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Message> Message { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
                new Service { Id = 4, Name = "elma",  Decription = "Acikla", Icon = "images/service-icon-01.png" },
                new Service { Id = 5, Name = "armut", Decription = "Acikla", Icon = "images/service-icon-03.png" },
                new Service { Id = 6, Name = "ayva",  Decription = "Acikla", Icon = "images/service-icon-01.png" },
                new Service { Id = 7, Name = "karpuz",Decription = "Acikla", Icon = "images/service-icon-02.png" },
                new Service { Id = 8, Name = "erik",  Decription = "Acikla", Icon = "images/service-icon-01.png" },
                new Service { Id = 9, Name = "muz",   Decription = "Acikla", Icon = "images/service-icon-03.png" }
            );

        }

         







    }
}
