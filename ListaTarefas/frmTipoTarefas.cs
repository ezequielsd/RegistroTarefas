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
    public partial class frmTipoTarefas : MetroForm
    {
        ListaTarefaBLL bll = new ListaTarefaBLL();

        public frmTipoTarefas()
        {
            InitializeComponent();
        }

        private void frmTipoTarefas_Load(object sender, EventArgs e)
        {           
            dataGridViewTipoTarefas.DataSource = bll.ListaTipoTarefas();
            FormartarDataGridView();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TipoTarefa info = new TipoTarefa();
            info.Nome = txtDescricaoTipoTarefa.Text;

            bll.CadstrarTipoTarefa(info);

            //limpa campo
            txtDescricaoTipoTarefa.Clear();

            //atualiza grid
            dataGridViewTipoTarefas.DataSource = bll.ListaTipoTarefas();
            FormartarDataGridView();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewTipoTarefas.Rows[dataGridViewTipoTarefas.CurrentRow.Index].Cells[0].Value);

            if (MessageBox.Show("Confirma excluir?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    bll.ApagarTipoTarefa(id);
                    MessageBox.Show("Tipo excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //atualiza grid
                    dataGridViewTipoTarefas.DataSource = bll.ListaTipoTarefas();
                    FormartarDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void FormartarDataGridView()
        {
            //esconde as colunas desnecessárias
           // dtgridParticipantes.Columns["Endereco"].Visible = false;
           
            //ajusta lagura da coluna
            dataGridViewTipoTarefas.Columns["Id"].Width = 50;
            dataGridViewTipoTarefas.Columns["Nome"].Width = 201;

            //ajusta o texto header do grid
            dataGridViewTipoTarefas.Columns["Nome"].HeaderText = "Nome";

        }

       
    }
}
