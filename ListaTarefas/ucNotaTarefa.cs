using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTarefas
{
    public partial class ucNotaTarefa : UserControl
    {       
        long tarefaId;

        public ucNotaTarefa(NotaTarefa pInfo)
        {
            InitializeComponent();
            txtNota.Text = pInfo.Nota;            
            tarefaId = pInfo.TarefaId;
        }               
    }
}
