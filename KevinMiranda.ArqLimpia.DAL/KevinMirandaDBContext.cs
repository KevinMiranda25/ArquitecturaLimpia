using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KevinMiranda.ArqLimpia.EN;
using Microsoft.EntityFrameworkCore;

namespace KevinMiranda.ArqLimpia.DAL
{
    public class KevinMirandaDBContext: DbContext
    {
        public KevinMirandaDBContext(DbContextOptions<KevinMirandaDBContext> options) : base(options) { }
        public DbSet<User> User { get; set; }
    }
}
