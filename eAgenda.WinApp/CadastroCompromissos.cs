using eAgenda.Dominio.Entidades;
using eAgenda.Repositorio;
using System;
using System.Linq;
using System.Windows.Forms;

namespace eAgenda.WinApp
{
    public partial class CadastroCompromissos : Form
    {
        private Compromisso compromisso;
        private readonly RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso();
        private readonly RepositorioContato repositorioContato = new RepositorioContato();


        public CadastroCompromissos(Compromisso compromisso)
        {
            Compromisso = compromisso;
            InitializeComponent();

            var nomeContatos = repositorioContato.SelecionarTodos().Select(x => x.Nome).ToList();
            nomeContatos.Insert(0, " -- ");
            cboxContato.DataSource = nomeContatos;

            CarregarTela();
        }

        private void CarregarTela()
        {
            if (compromisso != null)
            {
                if (!string.IsNullOrEmpty(compromisso.Assunto))
                {
                    txtAssunto.Text = compromisso.Assunto;
                    txtLocal.Text = compromisso.Local;
                    dtData.Value = compromisso.Data;
                    dtHoraInicial.Value = compromisso.HoraInicio;
                    dtHoraFinal.Value = compromisso.HoraFinal;

                    if (compromisso.Contato == null)
                        cboxContato.SelectedIndex = 0;
                    else
                        cboxContato.SelectedItem = compromisso.Contato?.Nome;
                }
            }
        }

        public Compromisso Compromisso
        {
            get { return compromisso; }
            set { compromisso = value; }
        }

        public void btnGravar_Click(object sender, EventArgs e)
        {
            if (CompromissoEhValido())
            {
                compromisso.Assunto = txtAssunto.Text;
                compromisso.Local = txtLocal.Text;
                compromisso.Data = dtData.Value;
                
                compromisso.HoraInicio = new DateTime(dtData.Value.Year, dtData.Value.Month, dtData.Value.Day, 
                    dtHoraInicial.Value.Hour, dtHoraInicial.Value.Minute, dtHoraInicial.Value.Second);
                
                compromisso.HoraFinal = new DateTime(dtData.Value.Year, dtData.Value.Month, dtData.Value.Day,
                    dtHoraFinal.Value.Hour, dtHoraFinal.Value.Minute, dtHoraFinal.Value.Second);

                if (cboxContato.SelectedValue != null)
                {
                    var contato = repositorioContato.BuscarPeloNome(cboxContato.SelectedValue.ToString());
                    compromisso.Contato = contato;
                }

                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.None;
            }

        }

        public bool CompromissoEhValido()
        {
            if (txtAssunto.Text == "")
            {
                MessageBox.Show("Insira um assunto.",
                    "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (txtLocal.Text == "")
            {
                MessageBox.Show("Insira um local.",
                    "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (dtData.Value < new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0 ,0))
            {
                MessageBox.Show("Data inválida.",
                    "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            var dataFinal = new DateTime(dtData.Value.Year, dtData.Value.Month, dtData.Value.Day,
                dtHoraFinal.Value.Hour, dtHoraFinal.Value.Minute, dtHoraFinal.Value.Second);

            if (dataFinal < DateTime.Now)
            {
                MessageBox.Show("Não é possível adicionar um compromisso com horário retroativo.",
                    "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            var compromissosDia = repositorioCompromisso.SelecionarTodosDoDia(dtData.Value);
            if (compromissosDia.Any(x => dtHoraFinal.Value > x.HoraInicio))
            {
                MessageBox.Show("Já existe um compromisso nesse horário.",
                    "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (dtHoraFinal.Value < dtHoraInicial.Value)
            {
                MessageBox.Show("O Horário final não pode ser antes do horário inicial",
                    "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
