using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Estudante
    {
        public int ID { get; set; }
        public string UltimoNome { get; set; }
        public string PrimeiroNome { get; set; }
        public DateTime DataInscricao { get; set; }

        public virtual ICollection<Inscricao> Inscricoes { get; set; }
    }
}