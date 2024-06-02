using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace REPOSITORY.Repositorios
{
    public interface IGeneryicRepository <TMODELS> where TMODELS : class
    {

        Task<IEnumerable<TMODELS>> Obtener();

        Task <TMODELS> Create(TMODELS modelo);

        Task<bool> Update(TMODELS modelo);

        Task <bool> Delete (TMODELS modelo);
        

    }
}

