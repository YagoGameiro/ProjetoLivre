using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projeto25._10
{
    public partial class CadastroAluno : System.Web.UI.Page
    {
        static int curso;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDDL();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            FaculdadeEntities3 context = new FaculdadeEntities3();
           
            int idCurso = int.Parse(ListCurso.SelectedValue.ToString());
            curso = idCurso;
            int raAluno;
            if (context.Aluno.Any())
            {
                raAluno = context.Aluno.OrderByDescending(x => x.RA).FirstOrDefault().RA + 10;
            }
            else
                raAluno = 1000;


            string raNovo = raAluno + '-'.ToString() + idCurso.ToString();

            Telefone telefone = new Telefone()
            {
                Codigo = raNovo,
                Telefone1 = txtTelefone.Text
            };

            Aluno aluno = new Aluno()
            {
                RA = raAluno,
                Curso = idCurso,
                Nome = txtNome.Text,
                CodigoTelefone = telefone.Codigo,
                Endereco = txtEndereco.Text
            };

            context.Telefone.Add(telefone);
            context.Aluno.Add(aluno);
            context.SaveChanges();
            sendMessage("Registro Concluido!");
        }

        private void sendMessage(string txt)
        {
            lblMsg.Text = txt;
        }

        private void loadDDL()
        {
            ListCurso.DataSource = new FaculdadeEntities3().Curso.ToList<Curso>();
            ListCurso.DataTextField = "Nome";
            ListCurso.DataValueField = "Id";
            ListCurso.DataBind();
        }
    }
}