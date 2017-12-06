using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2GLR.Models
{
    public class Processo
    {
        public  int ProcessoId { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public Boolean Situacao{ get; set; }
        public Pessoa Pessoa { get; set; }     
        public List<Tipo>Tipo{ get; set; }
    }
}