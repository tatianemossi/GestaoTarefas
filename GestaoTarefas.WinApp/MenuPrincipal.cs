using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var controlTarefas = new Button();
            controlTarefas.Text = "MUAHAHAHAHAHAHA";
            panelPrincipal.Controls.Add(controlTarefas);
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            var controlTarefas = new UserControlTarefa();
            panelPrincipal.Controls.Add(controlTarefas);
        }
    }
}
