using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClinicaApp
{
    static class NPaciente
    {
        private static List<Paciente> pacientes = new List<Paciente>();
        public static void Inserir(Paciente p)
        {
            Abrir();
            int id = 0;
            foreach (Paciente obj in pacientes)
            {
                if (obj.Id > id) id = obj.Id;
            }
            p.Id = id + 1;
            pacientes.Add(p);
            Salvar();
        }
        public static List<Paciente> Listar()
        {
            Abrir();
            return pacientes;
        }
        public static void Atualizar(Paciente p)
        {
            Abrir();
            foreach (Paciente obj in pacientes)
                if (obj.Id == p.Id)
                {
                    obj.Nome = p.Nome;
                    obj.Idade = p.Idade;
                    obj.Enfermidade = p.Enfermidade;
                }
            Salvar();
        }
        public static void Excluir(Paciente p)
        {
            Abrir();
            Paciente q = null;
            foreach (Paciente obj in pacientes)
                if (obj.Id == p.Id)
                {
                    q = obj;
                }
            if (q != null)
            {
                pacientes.Remove(q);
            }
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Paciente>));
                f = new StreamReader("./pacientes.xml");
                pacientes = (List<Paciente>)xml.Deserialize(f);
            }
            catch
            {
                pacientes = new List<Paciente>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Paciente>));
            StreamWriter f = new StreamWriter("./pacientes.xml", false);
            xml.Serialize(f, pacientes);
            f.Close();
        }
    }
}
