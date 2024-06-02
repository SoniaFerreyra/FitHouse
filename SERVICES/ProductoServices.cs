using AutoMapper;
using MODELS.Dtos;
using MODELS.Entidades;
using REPOSITORY.Repositorios;
using SERVICES.InterfacesServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICES
{
    public class ProductoServices : IProductoServices
    {

        private readonly IGeneryicRepository<Producto> _generyicRepo;
        private readonly IMapper _mapper;

        public ProductoServices(IGeneryicRepository<Producto> generyicRepository, IMapper mapper)
        {
            _generyicRepo = generyicRepository;
            _mapper = mapper;

        }

       
        public async Task<IEnumerable<Producto>> Obtener()
        {
            return await _generyicRepo.Obtener();
        }
    }
}
