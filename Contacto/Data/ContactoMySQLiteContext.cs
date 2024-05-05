using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Contacto.Models;

namespace Contacto.Data
{
    public class ContactoMySQLiteContext : DbContext
    {
        public ContactoMySQLiteContext (DbContextOptions<ContactoMySQLiteContext> options)
            : base(options)
        {
        }

        public DbSet<Contacto.Models.info> info { get; set; } = default!;
    }
}
