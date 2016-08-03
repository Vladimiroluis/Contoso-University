using ContosoUniversity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversity.DAL
{
    public class InicianteNaEscola : System.Data.Entity. DropCreateDatabaseIfModelChanges<DadosEscolares>
    {
        protected override void Seed(DadosEscolares dados)
        {
            var estudantes = new List<Estudante>
            {
             new Estudante {PrimeiroNome="Carson", UltimoNome="Alexander", DataInscricao=DateTime.Parse("2005-09-01") },
             new Estudante {PrimeiroNome="Meredith", UltimoNome="Alonso", DataInscricao=DateTime.Parse("2002-09-01") },
             new Estudante {PrimeiroNome="Arturo", UltimoNome="Anand", DataInscricao=DateTime.Parse("2003-09-01") },
             new Estudante {PrimeiroNome="Gytis", UltimoNome="Barzdukas", DataInscricao=DateTime.Parse("2002-09-01") },
             new Estudante {PrimeiroNome="Yan", UltimoNome="Li", DataInscricao=DateTime.Parse("2002-09-01") },
             new Estudante {PrimeiroNome="Peggy", UltimoNome="Justice", DataInscricao=DateTime.Parse("2001-09-01") },
             new Estudante {PrimeiroNome="Laura", UltimoNome="Norman", DataInscricao=DateTime.Parse("2003-09-01") },
             new Estudante {PrimeiroNome="Nino", UltimoNome="Olivetto", DataInscricao=DateTime.Parse("2005-09-01") }
            };
 
            estudantes.ForEach(s => dados.Estudante.Add(s));
            dados.SaveChanges();
            var cursos = new List<Curso>
            {
            new Curso{IDCurso=1050,Titulo="Química",Credito=3,},
            new Curso{IDCurso=4022,Titulo="Microeconomias",Credito=3,},
            new Curso{IDCurso=4041,Titulo="Macroeconomias",Credito=3,},
            new Curso{IDCurso=1045,Titulo="Cálculo",Credito=4,},
            new Curso{IDCurso=3141,Titulo="Trigonometria",Credito=4,},
            new Curso{IDCurso=2021,Titulo="Composição",Credito=3,},
            new Curso{IDCurso=2042,Titulo="Literatura",Credito=4,}
            };
            cursos.ForEach(s => dados.Curso.Add(s));
            dados.SaveChanges();
            var inscricoes = new List<Inscricao>
            {
                new Inscricao { IDEstudante = 1, IDCurso = 1050, Grade = Grade.A },
                new Inscricao { IDEstudante = 1, IDCurso = 4022, Grade = Grade.C },
                new Inscricao { IDEstudante = 1, IDCurso = 4041, Grade = Grade.B },
                new Inscricao { IDEstudante = 2, IDCurso = 1045, Grade = Grade.B },
                new Inscricao { IDEstudante = 2, IDCurso = 3141, Grade = Grade.F },
                new Inscricao { IDEstudante = 2, IDCurso = 2021, Grade = Grade.F },
                new Inscricao { IDEstudante = 3, IDCurso = 1050 },
                new Inscricao { IDEstudante = 4, IDCurso = 1050, },
                new Inscricao { IDEstudante = 4, IDCurso = 4022, Grade = Grade.F },
                new Inscricao { IDEstudante = 5, IDCurso = 4041, Grade = Grade.C },
                new Inscricao { IDEstudante = 6, IDCurso = 1045 },
                new Inscricao { IDEstudante = 7, IDCurso = 3141, Grade = Grade.A },
            };
            inscricoes.ForEach(s => dados.Inscricao.Add(s));
            dados.SaveChanges();
        }
    }
}