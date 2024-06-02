using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Dtos
{
    public class ProductoDtos
    {

        public string Nombre_Producto { get; set; }
        public string Dificultad { get; set; }
        public int Cant_Clases { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }
    }
}
