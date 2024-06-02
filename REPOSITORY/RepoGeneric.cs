using DATA;
using Microsoft.EntityFrameworkCore;
using REPOSITORY.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY
{
    public class RepoGeneric<TMODELS> : IGeneryicRepository<TMODELS> where TMODELS : class
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<TMODELS> _dbSet;

        public RepoGeneric(ApplicationDbContext dbContext )
        {
            _dbContext = dbContext;
            _dbSet =  dbContext.Set<TMODELS>();

        }

        public async Task<TMODELS> Create(TMODELS modelo )
        {
            try
            {
                await _dbContext.Set<TMODELS>().AddAsync(modelo);
                await _dbContext.SaveChangesAsync();
                return modelo;
            }
            catch (Exception ex)
            {
                // Manejo de errores // cambiar prodcuto 
                throw new Exception("Error al crear el Producto.", ex);
            }

        }

        public async Task<bool> Delete(TMODELS modelo)
        {
            try
            {
                _dbContext.Set<TMODELS>().Remove(modelo);
                await _dbContext.SaveChangesAsync() ;
                return true;

            }
            catch(Exception ex) 
            {
                throw new Exception("No se puedo eliminar el producto.", ex);
            }
        }

        public async Task<IEnumerable<TMODELS>> Obtener()
        {
            try
            {
                return await _dbContext.Set<TMODELS>().ToListAsync();
            }
            catch (Exception ex)
            {
                // Manejo de errores
                throw new Exception("Error al obtener todos los modelos.", ex);
            }
        }



        public async Task<bool> Update(TMODELS modelo)
        {
            _dbSet.Attach(modelo);
            _dbContext.Entry(modelo).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() > 0;
        }



       

    }
}
