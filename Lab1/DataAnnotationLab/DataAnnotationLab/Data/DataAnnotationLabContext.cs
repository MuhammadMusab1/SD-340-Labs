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

        public DbSet<Client> Client { get; set; }
        public DbSet<Room> Room { get; set; }
    }
}
