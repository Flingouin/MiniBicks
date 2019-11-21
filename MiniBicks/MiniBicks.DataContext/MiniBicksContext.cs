using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MiniBicks.Entities;


namespace MiniBicks.EntityFramework
{
    public class MiniBicksContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Conge> Conges { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<DureeConge> DureeConges { get; set; }
        public DbSet<Frai> Frais { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
