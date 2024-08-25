using MaiaIO.FactoryWatch.Domain.UseCases.CRUD.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MaiaIO.FactoryWatch.Infra.Context
{
    public class BaseContext : DbContext
    {

       public DbSet<ProcessLine> Lines;
       public DbSet<Machine> Machines;
       public DbSet<Device> Devices;

        public BaseContext(DbContextOptions options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Assembly assembly = typeof(BaseContext).Assembly;
            //modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            modelBuilder.Entity<ProcessLine>(c =>
            {
                c.ToTable("ProcessLines");

                c.HasKey(p => new { p.lineCode, p.lineSeq });

                c.HasMany(p => p.machines);

            });

            modelBuilder.Entity<Machine>(c =>
            {

                c.ToTable("Machines");

                c.HasKey(c => c.codeId);

                c.HasMany(d => d.devices);

            });


            modelBuilder.Entity<Device>(c =>
            {
                c.ToTable("Devices");

                c.HasKey(c => new { c.vendor, c.codeId });

            });


            base.OnModelCreating(modelBuilder);
        }

    }
}
