using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Turno
    {
        int IdTurno { get; set; }
        DateTime FechaHoraTurno { get; set; }
        int NroHistoriaClinica { get; set; }
        int IdVeterinario { get; set; }
        string MotivoConsulta { get; set; }
        int IdEstadoTurno { get; set; }
        DateTime FechaRegistro { get; set; }
        bool Activo { get; set; }
    }
}
