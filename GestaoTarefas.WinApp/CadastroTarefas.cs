using System;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroTarefas : Form
    {
        private Tarefa tarefa;

        public CadastroTarefas()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            get { return tarefa; }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.Numero.ToString();
                txtTitulo.Text = tarefa.Titulo;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = txtTitulo.Text;
        }
    }
}
