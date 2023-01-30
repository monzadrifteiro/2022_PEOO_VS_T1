using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaApp
{
    public class Medico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }
        public string Telefone { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Area} - {Telefone}";
        }
    }
}
