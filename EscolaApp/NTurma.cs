using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{
    static class NTurma
    {
        private static List<Turma> turmas = new List<Turma>();
        public static void Inserir(Turma t)
        {
            Abrir();
            // Procurar o maior ID
            int id = 0;
            foreach (Turma obj in turmas)
            {
                if (obj.Id > id) id = obj.Id;
            }
            t.Id = id + 1;
            turmas.Add(t);
            Salvar();
        }
        public static List<Turma> Listar()
        {
            Abrir();
            return turmas;
        }
        public static void Atualizar(Turma t)
        {
            Abrir();
            // Percorrer a lista de turma procurando o id informado (t.Id)
            foreach(Turma obj in turmas)
                if(obj.Id == t.Id)
                {
                    obj.Curso = t.Curso;
                    obj.Descricao = t.Descricao;
                    obj.AnoLetivo = t.AnoLetivo;
                    obj.IdProfessor = t.IdProfessor;
                }
            Salvar();
        }
        public static void Excluir(Turma t)
        {
            Abrir();
            Turma x = null;
            // Percorrer a lista de turma procurando o id informado (t.Id)
            foreach (Turma obj in turmas)
                if (obj.Id == t.Id)
                {
                    x = obj;
                }
            if(x != null)
            {
                turmas.Remove(x);
            }
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                // Objeto que transforma uma lista de turmas em um texto em Xml
                XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
                // Objeto que abre texto em um arquivo
                f = new StreamReader("./turmas.xml");
                // Chama a operação de desserialização informando o destino do texto XML
                turmas = (List<Turma>)xml.Deserialize(f);
            }
            catch
            {
                turmas = new List<Turma>();
            }
            // Fecha o arquivo
            if(f != null) f.Close();
        }
        public static void Salvar()
        {
            // Objeto que transforma uma lista de turmas em um texto em Xml
            XmlSerializer xml = new XmlSerializer(typeof(List<Turma>));
            // Objeto que grava um texto em um arquivo
            StreamWriter f = new StreamWriter("./turmas.xml", false);
            // Chama a operação de serialização informando o destino do texto XML
            xml.Serialize(f, turmas);
            // Fecha o arquivo
            f.Close();
        }
        public static void CadastrarProfessor(Professor p, Turma t)
        {
            t.IdProfessor = p.Id;
            Atualizar(t);
        }
    }
}
