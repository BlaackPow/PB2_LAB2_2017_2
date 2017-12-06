using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2GLR.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Processo> Processo { get; set; }
        public Endereco Endereco { get; set; }

    }
}