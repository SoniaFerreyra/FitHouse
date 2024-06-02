using MODELS.Dtos;
using MODELS.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES.InterfacesServices
{
    public interface IProductoServices
    {
        //Task Create(ProductoDtos productoDtos);

        //Task Update(ProductoDtos productoDtos);

        Task <IEnumerable<Producto>> Obtener();

        //Task Delete(ProductoDtos  productoDtos);


    }
}
