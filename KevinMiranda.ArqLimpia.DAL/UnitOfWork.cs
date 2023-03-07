using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KevinMiranda.ArqLimpia.EN.Interfaces;

namespace KevinMiranda.ArqLimpia.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly KevinMirandaDBContext dbContext;
        public UnitOfWork(KevinMirandaDBContext pDbContext)
        {
            dbContext = pDbContext;
        }
        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();
        }
    }
}
