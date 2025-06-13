using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Veterinario
    {
        int IdVeterinario { get; set; }
        int Dni { get; set; }
        string Apellido { get; set; }
        string Nombre { get; set; }
        string Direccion { get; set; }
        int Telefono { get; set; }
        string email { get; set; }
        int MatriculaN { get; set; }
        int MatriculaP { get; set; }
        int IdEspecialidad { get; set; }
        DateTime FechaRegistro { get; set; }
        bool Activo { get; set; }
    }
}
