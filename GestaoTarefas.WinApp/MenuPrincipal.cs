using System;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnContatos_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            var controlContato = new UserControlContato();
            panelPrincipal.Controls.Add(controlContato);
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            var controlTarefa = new UserControlTarefa();
            panelPrincipal.Controls.Add(controlTarefa);
        }

        private void btnCompromissos_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            var controlCompromisso = new UserControlCompromisso();
            panelPrincipal.Controls.Add(controlCompromisso);
        }
    }
}
