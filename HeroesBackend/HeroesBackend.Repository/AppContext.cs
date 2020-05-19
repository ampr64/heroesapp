using HeroesBackend.Repository.Mappers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesBackend.Repository
{
    public class AppContext : DbContext
    {
        private string connectionString;

        public AppContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {           
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new HeroMapper());
            modelBuilder.ApplyConfiguration(new HeroHomeMapper());
        }
    }
}