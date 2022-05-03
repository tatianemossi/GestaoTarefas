using GestaoTarefas.WinApp.Extensions;
using System;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroTarefas : Form
    {
        private Tarefa tarefa;
        private readonly RepositorioTarefa repositorioTarefa = new RepositorioTarefa();

        public CadastroTarefas()
        {
            InitializeComponent();
            cBoxPrioridade.DataSource = Utilitario.EnumToList<PrioridadeEnum>();
        }

        public Tarefa Tarefa
        {
            get { return tarefa; }
            set
            {
                tarefa = value;
                txtNumero.Text = tarefa.Numero.ToString();
                txtTitulo.Text = tarefa.Titulo;
                cBoxPrioridade.SelectedItem = tarefa.Prioridade;
            }
        }

        public void btnGravar_Click(object sender, EventArgs e)
        {
            if (repositorioTarefa.TarefaJaExiste(txtTitulo.Text))
            {
                MessageBox.Show("Não é possível inserir, pois a tarefa já existe.",
                    "Adicionando Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
            }
            else if (txtTitulo.Text == "")
            {
                MessageBox.Show("Insira um título para a tarefa.",
                    "Adicionando Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                DialogResult = DialogResult.None;
            }
            else
            {
                tarefa.Titulo = txtTitulo.Text;
                tarefa.Prioridade = (PrioridadeEnum)cBoxPrioridade.SelectedValue;
                DialogResult = DialogResult.OK;
            }            
        }
    }
}
