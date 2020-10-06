using DescorjedAPI.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DescorjedAPI.DAL
{
    public class DescorjedDbContext : DbContext
    {
        public DescorjedDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Server> Servers { get; set; }



    }
}
