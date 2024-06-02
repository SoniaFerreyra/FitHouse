using MODELS.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Mvc;
using REPOSITORY.Repositorios;
using SERVICES.InterfacesServices;
using MODELS.Entidades;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using MODELS.Logger;
using System.Net;

namespace FitHouseV1.Controllers
{

    [Microsoft.AspNetCore.Components.Route("api/[ControllerProducto]")]
    [ApiController]

    public class ProductoController : ControllerBase
    {
        private readonly IProductoServices _Iproducto;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductoController> _logger;
        //protected APIResponse _apiResponse;



        public ProductoController(IProductoServices producto, IMapper mapper, ILogger<ProductoController> logger)
        {
            _Iproducto = producto;
            _mapper = mapper;
            _logger = logger;
           // _apiResponse = new APIResponse();
        }


        [HttpGet("Obtener")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]


        public async Task<IEnumerable<Producto>> Obtener()
        {
            try
            {
                _logger.LogInformation("obtener todos los productos");
                var ProductosList = await _Iproducto.Obtener();
                return _mapper.Map<IEnumerable<Producto>>(ProductosList);
            
                //_apiResponse.Resultado = _mapper.Map<IEnumerable<Producto>>(ProductosList);
                //_apiResponse.statusCode = HttpStatusCode.OK;
                //_apiResponse.IsExitoso = true;


            }
            catch (Exception ex)
            {
                _logger.LogError("Error al obtener los productos: {Message}", ex.Message);
                throw;
                //    _apiResponse.statusCode = HttpStatusCode.InternalServerError;
                //    _apiResponse.IsExitoso= false;
                
            }

        }



        [HttpDelete("{Id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int Id_Producto)
        {
            if (Id_Producto == 0)
            {
                return BadRequest();
            }
            var producto = await _Iproducto.Obtener(producto => producto.Id == Id_Producto);
            if (producto != null)
            {
                return NotFound();
            }
           
            _Iproducto.Remove(producto);
            return NoContent();




        }
        

    }
}
