using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS.Entidades
{
    public class Producto
    {
        public int Id_Producto { get; set; }
        public DateTime Fecha_Creacion { get; set; }
        public string Nombre_Producto { get; set; }
        public string Dificultad { get; set; }
        public int Cant_Clases { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }
    }
}

