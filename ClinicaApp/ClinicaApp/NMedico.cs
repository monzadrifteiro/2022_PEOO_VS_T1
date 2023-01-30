using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClinicaApp
{
    static class NMedico
    {
        private static List<Medico> medicos = new List<Medico>();
        public static void Inserir(Medico m)
        {
            Abrir();
            int id = 0;
            foreach (Medico obj in medicos)
            {
                if (obj.Id > id) id = obj.Id;
            }
            m.Id = id + 1;
            medicos.Add(m);
            Salvar();
        }
        public static List<Medico> Listar()
        {
            Abrir();
            return medicos;
        }
        public static void Atualizar(Medico m)
        {
            Abrir();
            foreach(Medico obj in medicos)
                if(obj.Id == m.Id)
                {
                    obj.Nome = m.Nome;
                    obj.Area = m.Area;
                    obj.Telefone = m.Telefone;
                }
            Salvar();
        }
        public static void Excluir(Medico m)
        {
            Abrir();
            Medico w = null;
            foreach(Medico obj in medicos)
                if(obj.Id == m.Id)
                {
                    w = obj;
                }
            if(w != null)
            {
                medicos.Remove(w);
            }
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Medico>));
                f = new StreamReader("./medicos.xml");
                medicos = (List<Medico>)xml.Deserialize(f);
            }
            catch
            {
                medicos = new List<Medico>();
            }
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Medico>));
            StreamWriter f = new StreamWriter("./medicos.xml", false);
            xml.Serialize(f, medicos);
            f.Close();
        }
    }
}
