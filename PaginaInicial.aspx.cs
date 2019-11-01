using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto25._10
{
    public partial class PaginaInicial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadGrid();
            }
        }

        protected void btnAluno_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CadastroAluno.aspx");
        }

        private void loadGrid()
        {
            FaculdadeEntities3 context = new FaculdadeEntities3();

            var dados = (from m in context.Matriculas_abertas
                         from p in context.Professor.Where(x => x.Id == m.Professor)
                         select new
                         {
                             Curso = m.Curso,
                             Professor = p.Nome,
                             Horario = m.Horario
                         }).ToList();

            GVMatricula.DataSource = dados;
            GVMatricula.DataBind();
        }

        protected void txtLogar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CadastroAluno.aspx");
        }
    }
}