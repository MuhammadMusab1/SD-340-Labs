#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAnnotationLab.Models;

namespace DataAnnotationLab.Data
{
    public class DataAnnotationLabContext : DbContext
    {
        public DataAnnotationLabContext (DbContextOptions<DataAnnotationLabContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<Client>().HasKey(client => client.Id);
            //builder.Entity<Room>().HasKey(room => room.Id);

            //builder.Entity<Room>()
            //    .HasOne(room => room.CurrentClient)
            //    .WithOne(client => client.CurrentRoom)
            //    .HasForeignKey<Room>(room => room.CurrentClientId);
            //builder.Entity<Room>()
            //    .HasOne(room => room.PreviousClient)
            //    .WithOne(client => client.PreviousRoom)
            //    .HasForeignKey<Room>(room => room.PreviousClientId);

            //builder.Entity<Client>()
            //    .HasOne(client => client.CurrentRoom)
            //    .WithOne(room => room.CurrentClient)
            //    .HasForeignKey<Client>(client => client.CurrentRoomId);
            //builder.Entity<Client>()
            //    .HasOne(client => client.PreviousRoom)
            //    .WithOne(room => room.PreviousClient)
            //    .HasForeignKey<Client>(client => client.PreviousRoomId);

        }
        public DbSet<Client> Client { get; set; }
        public DbSet<Room> Room { get; set; }
    }
}
