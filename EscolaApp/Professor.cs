﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaApp
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Area { get; set; }
        public override string ToString()
        {
            return $"{Id} - {Nome} - {Matricula} - {Area}";
        }
    }
}
