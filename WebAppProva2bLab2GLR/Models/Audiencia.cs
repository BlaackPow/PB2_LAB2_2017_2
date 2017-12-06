using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2GLR.Models
{
    public class Audiencia
    {
        public  int AudienciaId { get; set; }
        public DateTime Data { get; set; }
        public string Detalhes { get; set; }
        public List<Processo>processo { get; set; }

    }
}