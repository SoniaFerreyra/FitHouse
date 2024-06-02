using DATA;
using Microsoft.EntityFrameworkCore;
using MODELS.Entidades;
using REPOSITORY.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY
{
    public class RepoProducto : RepoGeneric<Producto>, IProducto
    {

        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<Producto> _dbSet;

        public RepoProducto(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<Producto>();
        }

        public Task<Producto> Obtener(Producto modelo)
        {
            throw new NotImplementedException();
        }

        public async Task<Producto> Create(Producto modelo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(Producto modelo)
        {
            throw new NotImplementedException();
        }


    }
}
