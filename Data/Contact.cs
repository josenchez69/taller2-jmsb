using Core;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Data
{
    public class Contact
    {
        protected readonly DataContext _dbContext;
        
        public Contact()
        {

        }

        public Contact(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Registrar entity)
        {
            _dbContext.Set<Registrar>().Add(entity);
            _dbContext.SaveChanges();            
        }

        public async Task<IReadOnlyList<Registrar>> ListAllAsync()
        {
            return await _dbContext.Set<Registrar>().ToListAsync();
        }
    }
}
