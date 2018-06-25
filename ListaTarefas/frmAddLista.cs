using Syncfusion.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTarefas
{
    public partial class frmAddLista : MetroForm
    {
        ListaTarefaBLL bll = new ListaTarefaBLL();

        public frmAddLista()
        {
            InitializeComponent();
        }

        private void txtAddLista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtAddLista.Text) && !string.IsNullOrWhiteSpace(txtAddLista.Text))
            {
                TipoTarefa info = new TipoTarefa();
                info.Nome = txtAddLista.Text;

                bll.CadstrarTipoTarefa(info);

                Close();
            }
        }
    }
}
