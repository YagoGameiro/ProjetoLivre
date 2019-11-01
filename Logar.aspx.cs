using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto25._10
{
    public partial class Logar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FaculdadeEntities3 context = new FaculdadeEntities3();

                var dados = (from c in context.Curso.Where(x => x.Id == 340)//Pega o curso q o aluno 
                             from a in context.Aluno.Where(x => x.Curso == c.Id)// cadastrou
                             select new
                             {
                                 NomeCurso = c.Nome,
                                 NomeAluno = a.Nome
                             }).ToList();

                GVLogar.DataSource = dados;
                GVLogar.DataBind();
            }
        }
    }
}