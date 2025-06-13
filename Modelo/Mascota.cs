using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Mascota
    {
        int NroHistoriaClinica { get; set; }
        int IDDueño { get; set; }
        int IDRaza { get; set; }
        string Nombre { get; set; }
        string Sexo { get; set; }
        string Color { get; set; }
        decimal Peso { get; set; }
        DateTime FechaRegistro { get; set; }
        bool Activo { get; set; }
    }
}
