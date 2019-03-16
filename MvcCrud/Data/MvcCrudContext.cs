using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcCrud.Models
{
    public class MvcCrudContext : DbContext
    {
        public MvcCrudContext (DbContextOptions<MvcCrudContext> options)
            : base(options)
        {
        }

        public DbSet<MvcCrud.Models.Cliente> Cliente { get; set; }
    }
}
