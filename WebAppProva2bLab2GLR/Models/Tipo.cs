using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2GLR.Models
{
    public class Tipo
    {
        public  int TipoId { get; set; }
        public string Descricao { get; set; }
        public Processo Processo { get; set; }
        public List<Audiencia>Audiencia { get; set; }

    }
}