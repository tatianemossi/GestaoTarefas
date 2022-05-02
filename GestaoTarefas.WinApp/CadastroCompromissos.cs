using System;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class CadastroCompromissos : Form
    {
        private Compromisso compromisso;
        private readonly RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso();

        public CadastroCompromissos()
        {
            InitializeComponent();
        }
         
        public Compromisso Compromisso
        {
            get { return compromisso; }
            set
            {
                compromisso = value;
                txtAssunto.Text = compromisso.Assunto;
                txtLocal.Text = compromisso.Local;
                dtData.Value = compromisso.Data.Date;
                dtHoraInicial.Value = compromisso.HoraInicio;
                dtHoraFinal.Value = compromisso.HoraFinal;
            }
        }

        public void btnGravar_Click(object sender, EventArgs e)
        {
            if (CompromissoEhValido())
            {
                compromisso.Assunto = txtAssunto.Text;
                compromisso.Local = txtLocal.Text;
                compromisso.Data = dtData.Value;
                compromisso.HoraInicio = dtHoraInicial.Value;
                compromisso.HoraFinal = dtHoraFinal.Value;

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
            if (dtData == null)
            {
                MessageBox.Show("Insira uma data.",
                    "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (dtHoraInicial == null)
            {
                MessageBox.Show("Insira um horário inicial.",
                    "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (dtHoraFinal == null)
            {
                MessageBox.Show("Insira um horário final.",
                    "Adicionando Compromisso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
