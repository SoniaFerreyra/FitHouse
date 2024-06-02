using MODELS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY.Repositorios
{
    public interface IProducto : IGeneryicRepository<Producto>
    {

        Task<IEnumerable<Producto>> Obtener();

        Task<Producto> Create(Producto modelo);

        Task<bool> Delete(Producto modelo);
    }
}
