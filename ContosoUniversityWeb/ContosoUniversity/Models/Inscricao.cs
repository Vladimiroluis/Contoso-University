using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Inscricao
    {
        public int IDInscricao { get; set; }
        public int IDCurso { get; set; }
        public int IDEstudante { get; set; }
        public Grade? Grade { get; set; }

        public virtual Curso curso { get; set; }
        public virtual Estudante estudante { get; set; }
    }
}