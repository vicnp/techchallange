﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TC_DataTransfer.Contatos.Reponses
{
    public class ContatoResponse
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public int? DDD { get; set; }
        public string? Telefone { get; set; }

    }
}
