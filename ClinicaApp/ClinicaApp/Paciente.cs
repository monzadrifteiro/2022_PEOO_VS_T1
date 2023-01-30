using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Enfermidade { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Idade} - {Enfermidade}";
        }
    }
}
