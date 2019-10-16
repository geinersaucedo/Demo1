using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiNetCoreEnterpriseLibrary
{
    public class Usuario
    {
        public String CodRol { get; set; }
        public String CodFuncion { get; set; }
        public String DescripRol { get; set; }
        public String EstadoRol { get; set; }
        public String UsuarioCreacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public String UsuarioEdicion { get; set; }
        public DateTime FechaEdicion { get; set; }
    }
}
