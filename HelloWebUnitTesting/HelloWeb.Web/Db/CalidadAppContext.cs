using HelloWeb.Web.Db.Maps;
using HelloWeb.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWeb.Web.Db
{
    public class CalidadAppContext: DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public CalidadAppContext(DbContextOptions<CalidadAppContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
