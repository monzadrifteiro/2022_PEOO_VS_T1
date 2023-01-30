using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp
{
    public class Consulta
    {
        public int Id { get; set; }
        public int IdMedico { get; set; }
        public int IdPaciente { get; set; }
        public string Data { get; set; }
        public string Horario { get; set; }
        public override string ToString()
        {
            return $"{Id} - {IdMedico} - {IdPaciente} - {Data} - {Horario}";
        }
    }
}
