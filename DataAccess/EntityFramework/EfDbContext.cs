using DataAccess.Configurations;
using DataAccess.Seeds;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfDbContext:DbContext
    {
        public EfDbContext(DbContextOptions<EfDbContext> options) : base(options)
        {

        }
        public DbSet<ContactInfo> ContactInfos;
        public DbSet<Person> Persons;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region ApplyEntiyConfiguration
            modelBuilder.ApplyConfiguration(new ContactInfoConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            #endregion

            #region ApplyEntitySeed
            modelBuilder.ApplyConfiguration(new PersonSeed(new Guid[] { new Guid("e98a2570-92e7-435e-a289-e5702987fa8e") }));
            modelBuilder.ApplyConfiguration(new ContactInfoSeed(new Guid[] { new Guid("e98a2570-92e7-435e-a289-e5702987fa8e") }));
            #endregion


        }


    }
}
