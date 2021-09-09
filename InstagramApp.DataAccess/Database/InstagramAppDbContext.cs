using InstagramApp.DataEntity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InstagramApp.DataAccess.Database
{
    public class InstagramAppDbContext : DbContext
    {
        public InstagramAppDbContext(DbContextOptions<InstagramAppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.Load("InstagramApp.DataEntity").GetTypes().
              Where(type => !string.IsNullOrEmpty(type.Namespace)).
              Where(type => type.GetInterface(typeof(IEntityTypeConfiguration<>).FullName) != null);

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);

            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
