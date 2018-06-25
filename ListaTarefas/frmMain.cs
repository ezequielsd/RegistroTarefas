using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;

namespace ListaTarefas
{
    public partial class frmMain : MetroForm
    {
        TarefaBLL tarefaBLL = new TarefaBLL();
        ListaTarefaBLL listaTarefaBLL = new ListaTarefaBLL();
        FavoritoBLL favoritofaBLL = new FavoritoBLL();
        NotaTarefaBLL notaTarefaBLL = new NotaTarefaBLL();
        Tarefa tarefa = new Tarefa();
        string nodeSelecionado;
        ToolTipAdv tooltip = null;

        public frmMain()
        {
            InitializeComponent();
            //toolTip usado no sistema
            tooltip = new ToolTipAdv(this);
            tooltip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));


            //adiciona eventos as images do form configurados pelo recurso do MetroForm
            foreach (CaptionImage image in this.CaptionImages)
            {
                image.ImageMouseDown += new CaptionImage.MouseDown(ImageMouseDown);
                image.ImageMouseLeave += new CaptionImage.MouseLeave(ImageMouseLeave);
                image.ImageMouseMove += new CaptionImage.MouseMove(ImageMouseMove);
                this.Resize += new EventHandler(FormResize);
            }

            InicializaTreeViewListasTarefas();
        }

        /// <summary>
        /// Método delegate para click na image de configuração do formulario MetroForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseDown(object sender, ImageMouseDownEventArgs e)
        {
            if ((sender as CaptionImage).Name == "CaptionImage1")
            {
                //frmConfiguracoes frmConfig = new frmConfiguracoes();
                //frmConfig.ShowDialog();
            }
        }

        /// <summary>
        /// Evento quando o mouse se move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseMove(object sender, ImageMouseMoveEventArgs e)
        {
            if ((sender as CaptionImage).Name == "CaptionImage1")
            {
                tooltip.Text = "Configurações";
                Point pt = new Point(e.Location.X, e.Location.Y - 35);
                tooltip.ShowPopup(PointToScreen(pt));
            }
        }

        /// <summary>
        /// Evento quando o mouse sair do objeto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ImageMouseLeave(object sender, ImageMouseLeaveEventArgs e)
        {
            this.tooltip.HidePopup();
        }

        /// <summary>
        /// Evento no resize do formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void FormResize(object sender, EventArgs e)
        {
            this.tooltip.HidePopup();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Combobox status
            //cmbStatus.DataSource = Enum.GetValues(typeof(Status));
            //cmbStatus.SelectedIndex = 1;

            //atualiza dados nos datagridview           
            //Enum.TryParse<Status>(cmbStatus.SelectedValue.ToString(), out status);
            //statusTarefa = (int)status;

            dtGridViewPendentes.DataSource = tarefaBLL.ListarTarefas((int)Status.Pendente);
            FormartarDataGridViewPendentes();

            tabSplitterContainer1.Collapsed = true;

            txtEdicaoLink.Visible = false;
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            //Status status;
            //Enum.TryParse<Status>(cmbStatus.SelectedValue.ToString(), out status);
            //statusTarefa = (int)status;
            ////atualiza dados nos datagridview
            //dtGridViewPendentes.DataSource = tarefaBLL.ListarTarefas(statusTarefa);
            //FormartarDataGridViewPendentes();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }


        #region Tarefas

        /// <summary>
        /// Evento click label adiciona lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblAddLista_Click(object sender, EventArgs e)
        {
            frmAddLista frmConfig = new frmAddLista();
            frmConfig.ShowDialog();
            AtualizaTreeViewListasTarefas();
        }

        /// <summary>
        /// Evento click label remove lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblRemoveLista_Click(object sender, EventArgs e)
        {
            if (nodeSelecionado != string.Empty)
            {
                if (MessageBox.Show($"Confirma a exclusão da lista {nodeSelecionado}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        listaTarefaBLL.ApagarListaTarefa(nodeSelecionado);
                        AtualizaTreeViewListasTarefas();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Falha ao apagar lista", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Selecione uma lista primeiro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Evento click na celula do datagrid tarefas ativas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtGridViewPendentes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //limpa campos
            txtEdicaoLink.Clear();

            if (!string.IsNullOrEmpty(tarefa.Titulo))
            {
                SalvarFecharDetalhesTarefa();
            }

            int id = Convert.ToInt32(dtGridViewPendentes.Rows[dtGridViewPendentes.CurrentRow.Index].Cells[0].Value);

            tarefa = tarefaBLL.BuscarTarefa(id);

            txtTitulotarefa.Text = tarefa.Titulo;
            link.Text = tarefa.Link;
            lblLista.Text = tarefa.TipoTarefa;
            tabSplitterContainer1.Collapsed = false;

            //Busca e monta as notas da tarefa
            List<NotaTarefa> notas = notaTarefaBLL.ListaNotasTarefa(tarefa.Id);

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    flowLayoutPanel1.Controls.Remove(item);
                }
            }

            flowLayoutPanel1.Refresh();

            foreach (NotaTarefa notaItem in notas)
            {
                ucNotaTarefa nota = new ucNotaTarefa(notaItem);
                flowLayoutPanel1.Controls.Add(nota);
            }

        }

        /// <summary>
        /// Evento click celular do datagrid tarefas concluidas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewConcluidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //limpa campos
            txtEdicaoLink.Clear();

            int id = Convert.ToInt32(dataGridViewConcluidos.Rows[dataGridViewConcluidos.CurrentRow.Index].Cells[0].Value);

            tarefa = tarefaBLL.BuscarTarefa(id);

            txtTitulotarefa.Text = tarefa.Titulo;
            link.Text = tarefa.Link;
            lblLista.Text = tarefa.TipoTarefa;
            tabSplitterContainer1.Collapsed = false;

            //Busca e monta as notas da tarefa
            List<NotaTarefa> notas = notaTarefaBLL.ListaNotasTarefa(tarefa.Id);

            if (flowLayoutPanel1.Controls.Count > 0)
            {
                foreach (Control item in flowLayoutPanel1.Controls)
                {
                    flowLayoutPanel1.Controls.Remove(item);
                }
            }

            flowLayoutPanel1.Refresh();

            foreach (NotaTarefa notaItem in notas)
            {
                ucNotaTarefa nota = new ucNotaTarefa(notaItem);
                flowLayoutPanel1.Controls.Add(nota);
            }
        }

        private void link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(link.Text);
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtGridViewPendentes.Rows[dtGridViewPendentes.CurrentRow.Index].Cells[0].Value);

            if (MessageBox.Show("Confirma excluir?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    tarefaBLL.ApagarTarefa(id);
                    MessageBox.Show("Tarefa apagada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //atualiza grid
                    dtGridViewPendentes.DataSource = tarefaBLL.ListarTarefas(1);
                    FormartarDataGridViewPendentes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void btnMarcarFinalizado_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtGridViewPendentes.Rows[dtGridViewPendentes.CurrentRow.Index].Cells[0].Value);

            tarefaBLL.ConcluirTarefa(id);

            dtGridViewPendentes.DataSource = tarefaBLL.ListarTarefaTipo(nodeSelecionado, (int)Status.Pendente);
            FormartarDataGridViewPendentes();

            MessageBox.Show("Tarefa finalizada com sucesso!", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barItemTipoTarefa_Click(object sender, EventArgs e)
        {
            frmTipoTarefas frmTipoTarefas = new frmTipoTarefas();
            frmTipoTarefas.ShowDialog();
        }

        private void treeViewAdvTarefas_NodeMouseClick(object sender, TreeViewAdvMouseClickEventArgs e)
        {
            nodeSelecionado = e.Node.Text;

            if (nodeSelecionado != string.Empty)
            {
                AtualizaDataGrids();
            }
        }

        /// <summary>
        /// Evento inserir uma tarefa se a tecla enter for pressionada no textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInserirTarefa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtInserirTarefa.Text) && !string.IsNullOrWhiteSpace(txtInserirTarefa.Text))
            {
                Tarefa tarefa = new Tarefa();
                tarefa.Titulo = txtInserirTarefa.Text;
                tarefa.TipoTarefa = nodeSelecionado;
                tarefa.DataInclusao = DateTime.Now.ToShortDateString();

                tarefaBLL.CadastrarTarefa(tarefa);

                AtualizaDataGrids();

                dtGridViewPendentes.FirstDisplayedScrollingRowIndex = dtGridViewPendentes.Rows.Count - 1;
                dtGridViewPendentes.Rows[dtGridViewPendentes.Rows.Count - 1].Selected = true;
          
                txtInserirTarefa.Clear();
            }
        }

        /// <summary>
        /// Evento editar link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEdicaoLink_KeyDown(object sender, KeyEventArgs e)
        {
            //se for pressionado a tecla Enter
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtEdicaoLink.Text) && !string.IsNullOrWhiteSpace(txtEdicaoLink.Text))
            {
                link.Text = txtEdicaoLink.Text;
                tarefa.Link = txtEdicaoLink.Text;
                txtEdicaoLink.Visible = false;
            }
            //se for pressionado a tecla ESC 
            if (e.KeyCode == Keys.Escape)
            {
                txtEdicaoLink.Visible = false;
            }
        }

        private void txtTitulotarefa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtTitulotarefa.Text) && !string.IsNullOrWhiteSpace(txtTitulotarefa.Text))
            {
                tarefa.Titulo = txtTitulotarefa.Text;
            }
        }

        /// <summary>
        /// Evento click editar link
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void autoLabel5_Click(object sender, EventArgs e)
        {
            txtEdicaoLink.Visible = true;
        }

        /// <summary>
        /// Evento tecla pressionada txt adiciona nota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAdicionaNota_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtAdicionaNota.Text) && !string.IsNullOrWhiteSpace(txtAdicionaNota.Text))
            {
                NotaTarefa notaTare = new NotaTarefa();
                notaTare.Nota = txtAdicionaNota.Text;
                notaTare.TarefaId = tarefa.Id;

                notaTarefaBLL.AdicionarNota(notaTare);

                AtualizaDataGrids();

                txtAdicionaNota.Clear();

                AdicionaNotaTarefa(notaTare);
            }

        }

        /// <summary>
        /// Evento select tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlAdv1.SelectedTab.Name)
            {
                case "tabPageAtivos":
                    dtGridViewPendentes.DataSource = tarefaBLL.ListarTarefaTipo(nodeSelecionado, (int)Status.Pendente);
                    FormartarDataGridViewPendentes();
                    btnMarcarFinalizado.Visible = true;
                    break;
                case "tabPageConcluidos":
                    dataGridViewConcluidos.DataSource = tarefaBLL.ListarTarefaTipo(nodeSelecionado, (int)Status.Finalizado);
                    FormartarDataGridViewFinalizados();
                    btnMarcarFinalizado.Visible = false;
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Favoritos

        private void tabSplitterPageFavoritos_Paint(object sender, PaintEventArgs e)
        {
            dtGridViewFavoritos.DataSource = favoritofaBLL.ListarFavoritos();
            FormartarDataGridViewFavoritos();
        }

        private void btnApagarFavorito_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtGridViewFavoritos.Rows[dtGridViewFavoritos.CurrentRow.Index].Cells[0].Value);

            if (MessageBox.Show("Tem certeza que deseja apagar o favorito?", "Confirmação", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                favoritofaBLL.ApagarFavorito(id);

                dtGridViewFavoritos.DataSource = favoritofaBLL.ListarFavoritos();
                FormartarDataGridViewPendentes();
            }
        }

        private void btnAlterarFavorito_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtGridViewFavoritos.Rows[dtGridViewFavoritos.CurrentRow.Index].Cells[0].Value);

            frmAlterarFavorito frmAlterarFavorito = new ListaTarefas.frmAlterarFavorito(id);
            frmAlterarFavorito.Show();
        }

        private void btnCadastrarFavorito_Click(object sender, EventArgs e)
        {
            frmCadastrarFavorito frmCadastrarFavorito = new frmCadastrarFavorito();
            frmCadastrarFavorito.Show();
        }

        /// <summary>
        /// Navegar no favorito
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNavegar_Click(object sender, EventArgs e)
        {
            string link = dtGridViewFavoritos.Rows[dtGridViewFavoritos.CurrentRow.Index].Cells[2].Value.ToString();

            Process.Start(link);
        }

        #endregion

        #region Métodos Privados

        /// <summary>
        /// Monta o treeview da listas de tarefas
        /// </summary>
        private void InicializaTreeViewListasTarefas()
        {
            treeViewAdvTarefas.Name = "ListaTarefas";

            List<TipoTarefa> listaTarefas = listaTarefaBLL.ListaTipoTarefas();

            //Cria o nó principal
            TreeNodeAdv nodePrincipal = new TreeNodeAdv("Listas");

            //adiciona as listas em nó filhos da principal
            foreach (TipoTarefa item in listaTarefas)
            {
                nodePrincipal.Nodes.Add(new TreeNodeAdv(item.Nome));
            }
            //adiciona o nó na treeview
            treeViewAdvTarefas.Nodes.Add(nodePrincipal);
            //expande todos os nós
            treeViewAdvTarefas.ExpandAll();

        }

        /// <summary>
        /// Método atualiza o treeview com novo item
        /// </summary>
        private void AtualizaTreeViewListasTarefas()
        {
            if (treeViewAdvTarefas.Nodes.Count > 0)
            {

                treeViewAdvTarefas.Nodes.RemoveRange(0, treeViewAdvTarefas.Nodes.Count);

                List<TipoTarefa> listaTarefas = listaTarefaBLL.ListaTipoTarefas();

                //Cria o nó principal
                TreeNodeAdv nodePrincipal = new TreeNodeAdv("Listas");

                //adiciona as listas em nó filhos da principal
                foreach (TipoTarefa item in listaTarefas)
                {
                    nodePrincipal.Nodes.Add(new TreeNodeAdv(item.Nome));
                }
                //adiciona o nó na treeview
                treeViewAdvTarefas.Nodes.Add(nodePrincipal);
                //expande todos os nós
                treeViewAdvTarefas.ExpandAll();
            }
        }

        /// <summary>
        /// Método atualiza datagrids
        /// </summary>
        private void AtualizaDataGrids()
        {
            switch (tabControlAdv1.SelectedTab.Name)
            {
                case "tabPageAtivos":
                    dtGridViewPendentes.DataSource = tarefaBLL.ListarTarefaTipo(nodeSelecionado, (int)Status.Pendente);
                    FormartarDataGridViewPendentes();
                    break;
                case "tabPageConcluidos":
                    dataGridViewConcluidos.DataSource = tarefaBLL.ListarTarefaTipo(nodeSelecionado, (int)Status.Finalizado);
                    FormartarDataGridViewFinalizados();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Formata o DatagridView Pendentes
        /// </summary>
        private void FormartarDataGridViewPendentes()
        {
            //esconde as colunas desnecessárias
            dtGridViewPendentes.Columns["Id"].Visible = false;
            dtGridViewPendentes.Columns["TipoTarefa"].Visible = false;
            dtGridViewPendentes.Columns["Link"].Visible = false;
            dtGridViewPendentes.Columns["DataFinalizado"].Visible = false;
            dtGridViewPendentes.Columns["Pendente"].Visible = false;
            dtGridViewPendentes.Columns["Descricao"].Visible = false;
            dtGridViewPendentes.Columns["DataInclusao"].Visible = false;


            //ajusta lagura da coluna           
            dtGridViewPendentes.Columns["Titulo"].Width = 651;

            //ajusta o texto header do grid
            //dtGridViewPendentes.Columns["Descricao"].HeaderText = "Descrição";

        }

        /// <summary>
        /// Formata o DataGridView Finalizados
        /// </summary>
        private void FormartarDataGridViewFinalizados()
        {
            //esconde as colunas desnecessárias
            dataGridViewConcluidos.Columns["Id"].Visible = false;
            dataGridViewConcluidos.Columns["TipoTarefa"].Visible = false;
            dataGridViewConcluidos.Columns["Link"].Visible = false;
            dataGridViewConcluidos.Columns["DataFinalizado"].Visible = false;
            dataGridViewConcluidos.Columns["Pendente"].Visible = false;
            dataGridViewConcluidos.Columns["Descricao"].Visible = false;
            dataGridViewConcluidos.Columns["DataInclusao"].Visible = false;


            //ajusta lagura da coluna           
            dataGridViewConcluidos.Columns["Titulo"].Width = 651;

            //ajusta o texto header do grid
            //dtGridViewPendentes.Columns["Descricao"].HeaderText = "Descrição";
        }

        /// <summary>
        /// Formata o DatagridView
        /// </summary>
        private void FormartarDataGridViewFavoritos()
        {
            //esconde as colunas desnecessárias
            //dtGridViewFavoritos.Columns["Link"].Visible = false;

            //ajusta lagura da coluna
            dtGridViewFavoritos.Columns["Id"].Width = 50;
            dtGridViewFavoritos.Columns["Descricao"].Width = 250;
            dtGridViewFavoritos.Columns["Link"].Width = 600;

            //ajusta o texto header do grid
            dtGridViewFavoritos.Columns["Descricao"].HeaderText = "Descrição";
        }

        private void AdicionaNotaTarefa(NotaTarefa pNota)
        {
            ucNotaTarefa nota = new ucNotaTarefa(pNota);
            flowLayoutPanel1.Controls.Add(nota);

            flowLayoutPanel1.Refresh();
        }

        /// <summary>
        /// Método salva e fecha o detalhe da tarefa
        /// </summary>
        private void SalvarFecharDetalhesTarefa()
        {
            tarefa.Titulo = txtTitulotarefa.Text;
            tarefa.Link = link.Text;
            txtTitulotarefa.Clear();
            link.Text = " ";
            lblLista.Text = " ";
            tabSplitterContainer1.Collapsed = true;
            tarefaBLL.AlterarTarefa(tarefa);
        }




        #endregion


    }
}
