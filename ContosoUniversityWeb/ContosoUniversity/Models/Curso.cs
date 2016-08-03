using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public class Curso
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDCurso { get; set; }
        public string Titulo { get; set; }
        public int Credito { get; set; }

        public virtual ICollection<Inscricao> Incricoes { get; set; }
    }
}