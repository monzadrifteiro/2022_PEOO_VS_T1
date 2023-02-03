    using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClinicaApp
{
    static class NConsulta
    {
        private static List<Consulta> consultas = new List<Consulta>();
        public static void Inserir(Consulta c)
        {
            Abrir();
            int id = 0;
            foreach (Consulta obj in consultas)
            {
                if (obj.Id > id) id = obj.Id;
            }
            c.Id = id + 1;
            consultas.Add(c);
            Salvar();
        }
        public static List<Consulta> Listar()
        {
            Abrir();
            return consultas;
        }
        public static void Atualizar(Consulta c)
        {
            Abrir();
            foreach (Consulta obj in consultas)
                if (obj.Id == c.Id)
                {
                    obj.IdMedico = c.IdMedico;
                    obj.IdPaciente = c.IdPaciente;
                    obj.Data = c.Data;
                    obj.Horario = c.Horario;
                }
            Salvar();
        }
        public static void Excluir(Consulta c)
        {
            Abrir();
            Consulta v = null;
            foreach (Consulta obj in consultas)
                if (obj.Id == c.Id)
                {
                    v = obj;
                }
            if (v != null)
            {
                consultas.Remove(v);
            }
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Consulta>));
                f = new StreamReader("./consultas.xml");
                consultas = (List<Consulta>)xml.Deserialize(f);
            }
            catch
            {
                consultas = new List<Consulta>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Consulta>));
            StreamWriter f = new StreamWriter("./consultas.xml", false);
            xml.Serialize(f, consultas);
            f.Close();
        }
    }
}
