namespace ListaTarefas
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.tabSplitterContainer1 = new Syncfusion.Windows.Forms.Tools.TabSplitterContainer();
            this.tabSplitterPageTarefas = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnMarcarFinalizado = new Syncfusion.Windows.Forms.ButtonAdv();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAtivos = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.txtInserirTarefa = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.dtGridViewPendentes = new System.Windows.Forms.DataGridView();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.tabPageConcluidos = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.dataGridViewConcluidos = new System.Windows.Forms.DataGridView();
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.lblRemoveLista = new System.Windows.Forms.Label();
            this.lblAddLista = new System.Windows.Forms.Label();
            this.treeViewAdvTarefas = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.tabSplitterPageFavoritos = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.btnCadastrarFavorito = new System.Windows.Forms.Button();
            this.btnApagarFavorito = new System.Windows.Forms.Button();
            this.btnAlterarFavorito = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.dtGridViewFavoritos = new System.Windows.Forms.DataGridView();
            this.tabSplitterPageDetalheTarefa = new Syncfusion.Windows.Forms.Tools.TabSplitterPage();
            this.txtEdicaoLink = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.autoLabel5 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel4 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtAdicionaNota = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLista = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.link = new System.Windows.Forms.LinkLabel();
            this.autoLabel3 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.txtTitulotarefa = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNavegar = new System.Windows.Forms.Button();
            this.commandBar1 = new Syncfusion.Windows.Forms.Tools.CommandBar();
            this.barItemTipoTarefa = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.flowLayout1 = new Syncfusion.Windows.Forms.Tools.FlowLayout(this.components);
            this.tabSplitterContainer1.SuspendLayout();
            this.tabSplitterPageTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAtivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInserirTarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPendentes)).BeginInit();
            this.tabPageConcluidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcluidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdvTarefas)).BeginInit();
            this.tabSplitterPageFavoritos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewFavoritos)).BeginInit();
            this.tabSplitterPageDetalheTarefa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdicaoLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdicionaNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulotarefa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabSplitterContainer1
            // 
            this.tabSplitterContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSplitterContainer1.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterContainer1.Name = "tabSplitterContainer1";
            this.tabSplitterContainer1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tabSplitterContainer1.PrimaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.tabSplitterPageTarefas,
            this.tabSplitterPageFavoritos});
            this.tabSplitterContainer1.SecondaryPages.AddRange(new Syncfusion.Windows.Forms.Tools.TabSplitterPage[] {
            this.tabSplitterPageDetalheTarefa});
            this.tabSplitterContainer1.Size = new System.Drawing.Size(1455, 755);
            this.tabSplitterContainer1.SplitterBackColor = System.Drawing.SystemColors.ControlLight;
            this.tabSplitterContainer1.SplitterPosition = 847;
            this.tabSplitterContainer1.TabIndex = 17;
            this.tabSplitterContainer1.Text = "tabSplitterContainer1";
            // 
            // tabSplitterPageTarefas
            // 
            this.tabSplitterPageTarefas.AutoScroll = true;
            this.tabSplitterPageTarefas.BackColor = System.Drawing.Color.White;
            this.tabSplitterPageTarefas.Controls.Add(this.buttonAdv1);
            this.tabSplitterPageTarefas.Controls.Add(this.btnMarcarFinalizado);
            this.tabSplitterPageTarefas.Controls.Add(this.tabControlAdv1);
            this.tabSplitterPageTarefas.Controls.Add(this.splitContainerAdv1);
            this.tabSplitterPageTarefas.Hide = false;
            this.tabSplitterPageTarefas.Image = ((System.Drawing.Image)(resources.GetObject("tabSplitterPageTarefas.Image")));
            this.tabSplitterPageTarefas.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterPageTarefas.Name = "tabSplitterPageTarefas";
            this.tabSplitterPageTarefas.Size = new System.Drawing.Size(847, 755);
            this.tabSplitterPageTarefas.TabIndex = 1;
            this.tabSplitterPageTarefas.Tag = "";
            this.tabSplitterPageTarefas.Text = "Tarefas";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.White;
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(62, 23);
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(692, 720);
            this.buttonAdv1.MetroColor = System.Drawing.Color.LightCoral;
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(62, 23);
            this.buttonAdv1.TabIndex = 43;
            this.buttonAdv1.Text = "Apagar";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // btnMarcarFinalizado
            // 
            this.btnMarcarFinalizado.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.btnMarcarFinalizado.BackColor = System.Drawing.Color.White;
            this.btnMarcarFinalizado.BeforeTouchSize = new System.Drawing.Size(62, 23);
            this.btnMarcarFinalizado.ForeColor = System.Drawing.Color.White;
            this.btnMarcarFinalizado.IsBackStageButton = false;
            this.btnMarcarFinalizado.Location = new System.Drawing.Point(760, 720);
            this.btnMarcarFinalizado.MetroColor = System.Drawing.Color.DarkSeaGreen;
            this.btnMarcarFinalizado.Name = "btnMarcarFinalizado";
            this.btnMarcarFinalizado.Size = new System.Drawing.Size(62, 23);
            this.btnMarcarFinalizado.TabIndex = 42;
            this.btnMarcarFinalizado.Text = "Finalizar";
            this.btnMarcarFinalizado.UseVisualStyle = true;
            this.btnMarcarFinalizado.Click += new System.EventHandler(this.btnMarcarFinalizado_Click_1);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.BeforeTouchSize = new System.Drawing.Size(669, 667);
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabControlAdv1.CloseButtonForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonHoverForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.CloseButtonPressedForeColor = System.Drawing.Color.Empty;
            this.tabControlAdv1.Controls.Add(this.tabPageAtivos);
            this.tabControlAdv1.Controls.Add(this.tabPageConcluidos);
            this.tabControlAdv1.FocusOnTabClick = false;
            this.tabControlAdv1.Location = new System.Drawing.Point(167, 47);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(669, 667);
            this.tabControlAdv1.TabIndex = 37;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White;
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererMetro);
            this.tabControlAdv1.ThemesEnabled = true;
            this.tabControlAdv1.SelectedIndexChanged += new System.EventHandler(this.tabControlAdv1_SelectedIndexChanged);
            // 
            // tabPageAtivos
            // 
            this.tabPageAtivos.Controls.Add(this.txtInserirTarefa);
            this.tabPageAtivos.Controls.Add(this.dtGridViewPendentes);
            this.tabPageAtivos.Controls.Add(this.autoLabel1);
            this.tabPageAtivos.Image = null;
            this.tabPageAtivos.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageAtivos.Location = new System.Drawing.Point(2, 23);
            this.tabPageAtivos.Name = "tabPageAtivos";
            this.tabPageAtivos.ShowCloseButton = true;
            this.tabPageAtivos.Size = new System.Drawing.Size(665, 642);
            this.tabPageAtivos.TabIndex = 1;
            this.tabPageAtivos.Text = "Ativos";
            this.tabPageAtivos.ThemesEnabled = true;
            // 
            // txtInserirTarefa
            // 
            this.txtInserirTarefa.BeforeTouchSize = new System.Drawing.Size(549, 29);
            this.txtInserirTarefa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInserirTarefa.Location = new System.Drawing.Point(8, 31);
            this.txtInserirTarefa.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtInserirTarefa.Name = "txtInserirTarefa";
            this.txtInserirTarefa.Size = new System.Drawing.Size(651, 20);
            this.txtInserirTarefa.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtInserirTarefa.TabIndex = 35;
            this.txtInserirTarefa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInserirTarefa_KeyDown);
            // 
            // dtGridViewPendentes
            // 
            this.dtGridViewPendentes.AllowUserToAddRows = false;
            this.dtGridViewPendentes.AllowUserToDeleteRows = false;
            this.dtGridViewPendentes.AllowUserToResizeColumns = false;
            this.dtGridViewPendentes.AllowUserToResizeRows = false;
            this.dtGridViewPendentes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtGridViewPendentes.BackgroundColor = System.Drawing.Color.White;
            this.dtGridViewPendentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtGridViewPendentes.CausesValidation = false;
            this.dtGridViewPendentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtGridViewPendentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewPendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtGridViewPendentes.ColumnHeadersHeight = 25;
            this.dtGridViewPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtGridViewPendentes.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGridViewPendentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtGridViewPendentes.EnableHeadersVisualStyles = false;
            this.dtGridViewPendentes.Location = new System.Drawing.Point(8, 64);
            this.dtGridViewPendentes.Margin = new System.Windows.Forms.Padding(0);
            this.dtGridViewPendentes.MultiSelect = false;
            this.dtGridViewPendentes.Name = "dtGridViewPendentes";
            this.dtGridViewPendentes.ReadOnly = true;
            this.dtGridViewPendentes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtGridViewPendentes.RowHeadersVisible = false;
            this.dtGridViewPendentes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtGridViewPendentes.RowTemplate.Height = 27;
            this.dtGridViewPendentes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtGridViewPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtGridViewPendentes.ShowEditingIcon = false;
            this.dtGridViewPendentes.Size = new System.Drawing.Size(651, 568);
            this.dtGridViewPendentes.TabIndex = 34;
            this.dtGridViewPendentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewPendentes_CellClick_1);
            // 
            // autoLabel1
            // 
            this.autoLabel1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.autoLabel1.Location = new System.Drawing.Point(8, 11);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(101, 13);
            this.autoLabel1.TabIndex = 36;
            this.autoLabel1.Text = "Adicione uma tarefa";
            // 
            // tabPageConcluidos
            // 
            this.tabPageConcluidos.Controls.Add(this.dataGridViewConcluidos);
            this.tabPageConcluidos.Image = null;
            this.tabPageConcluidos.ImageSize = new System.Drawing.Size(16, 16);
            this.tabPageConcluidos.Location = new System.Drawing.Point(2, 23);
            this.tabPageConcluidos.Name = "tabPageConcluidos";
            this.tabPageConcluidos.ShowCloseButton = true;
            this.tabPageConcluidos.Size = new System.Drawing.Size(665, 642);
            this.tabPageConcluidos.TabIndex = 2;
            this.tabPageConcluidos.Text = "Concluidos";
            this.tabPageConcluidos.ThemesEnabled = true;
            // 
            // dataGridViewConcluidos
            // 
            this.dataGridViewConcluidos.AllowUserToAddRows = false;
            this.dataGridViewConcluidos.AllowUserToDeleteRows = false;
            this.dataGridViewConcluidos.AllowUserToResizeColumns = false;
            this.dataGridViewConcluidos.AllowUserToResizeRows = false;
            this.dataGridViewConcluidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewConcluidos.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewConcluidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewConcluidos.CausesValidation = false;
            this.dataGridViewConcluidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewConcluidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConcluidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewConcluidos.ColumnHeadersHeight = 25;
            this.dataGridViewConcluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewConcluidos.ColumnHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewConcluidos.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewConcluidos.EnableHeadersVisualStyles = false;
            this.dataGridViewConcluidos.Location = new System.Drawing.Point(7, 37);
            this.dataGridViewConcluidos.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewConcluidos.MultiSelect = false;
            this.dataGridViewConcluidos.Name = "dataGridViewConcluidos";
            this.dataGridViewConcluidos.ReadOnly = true;
            this.dataGridViewConcluidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewConcluidos.RowHeadersVisible = false;
            this.dataGridViewConcluidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewConcluidos.RowTemplate.Height = 27;
            this.dataGridViewConcluidos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewConcluidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConcluidos.ShowEditingIcon = false;
            this.dataGridViewConcluidos.Size = new System.Drawing.Size(651, 568);
            this.dataGridViewConcluidos.TabIndex = 35;
            this.dataGridViewConcluidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConcluidos_CellClick);
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerAdv1.BeforeTouchSize = 7;
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            this.splitContainerAdv1.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.Controls.Add(this.lblRemoveLista);
            this.splitContainerAdv1.Panel1.Controls.Add(this.lblAddLista);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.Controls.Add(this.treeViewAdvTarefas);
            this.splitContainerAdv1.Size = new System.Drawing.Size(161, 755);
            this.splitContainerAdv1.SplitterDistance = 59;
            this.splitContainerAdv1.TabIndex = 16;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            // 
            // lblRemoveLista
            // 
            this.lblRemoveLista.AutoSize = true;
            this.lblRemoveLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.lblRemoveLista.Location = new System.Drawing.Point(3, 41);
            this.lblRemoveLista.Name = "lblRemoveLista";
            this.lblRemoveLista.Size = new System.Drawing.Size(75, 13);
            this.lblRemoveLista.TabIndex = 1;
            this.lblRemoveLista.Text = "Remover Lista";
            this.lblRemoveLista.Click += new System.EventHandler(this.lblRemoveLista_Click);
            // 
            // lblAddLista
            // 
            this.lblAddLista.AutoSize = true;
            this.lblAddLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.lblAddLista.Location = new System.Drawing.Point(3, 24);
            this.lblAddLista.Name = "lblAddLista";
            this.lblAddLista.Size = new System.Drawing.Size(51, 13);
            this.lblAddLista.TabIndex = 0;
            this.lblAddLista.Text = "Add Lista";
            this.lblAddLista.Click += new System.EventHandler(this.lblAddLista_Click);
            // 
            // treeViewAdvTarefas
            // 
            this.treeViewAdvTarefas.BackColor = System.Drawing.Color.Transparent;
            this.treeViewAdvTarefas.BeforeTouchSize = new System.Drawing.Size(161, 689);
            this.treeViewAdvTarefas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewAdvTarefas.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.treeViewAdvTarefas.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdvTarefas.HelpTextControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdvTarefas.HelpTextControl.Name = "helpText";
            this.treeViewAdvTarefas.HelpTextControl.Size = new System.Drawing.Size(49, 15);
            this.treeViewAdvTarefas.HelpTextControl.TabIndex = 0;
            this.treeViewAdvTarefas.HelpTextControl.Text = "help text";
            this.treeViewAdvTarefas.InactiveSelectedNodeForeColor = System.Drawing.SystemColors.ControlText;
            this.treeViewAdvTarefas.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdvTarefas.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.treeViewAdvTarefas.MetroScrollBars = true;
            this.treeViewAdvTarefas.Name = "treeViewAdvTarefas";
            this.treeViewAdvTarefas.SelectedNodeForeColor = System.Drawing.SystemColors.HighlightText;
            this.treeViewAdvTarefas.Size = new System.Drawing.Size(161, 689);
            this.treeViewAdvTarefas.TabIndex = 15;
            this.treeViewAdvTarefas.Text = "treeViewAdv1";
            this.treeViewAdvTarefas.ThemesEnabled = true;
            // 
            // 
            // 
            this.treeViewAdvTarefas.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdvTarefas.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdvTarefas.ToolTipControl.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdvTarefas.ToolTipControl.Name = "toolTip";
            this.treeViewAdvTarefas.ToolTipControl.Size = new System.Drawing.Size(41, 15);
            this.treeViewAdvTarefas.ToolTipControl.TabIndex = 1;
            this.treeViewAdvTarefas.ToolTipControl.Text = "toolTip";
            this.treeViewAdvTarefas.NodeMouseClick += new Syncfusion.Windows.Forms.Tools.TreeNodeAdvMouseClickArgs(this.treeViewAdvTarefas_NodeMouseClick);
            // 
            // tabSplitterPageFavoritos
            // 
            this.tabSplitterPageFavoritos.AutoScroll = true;
            this.tabSplitterPageFavoritos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabSplitterPageFavoritos.Controls.Add(this.btnCadastrarFavorito);
            this.tabSplitterPageFavoritos.Controls.Add(this.btnApagarFavorito);
            this.tabSplitterPageFavoritos.Controls.Add(this.btnAlterarFavorito);
            this.tabSplitterPageFavoritos.Controls.Add(this.btnApagar);
            this.tabSplitterPageFavoritos.Controls.Add(this.dtGridViewFavoritos);
            this.tabSplitterPageFavoritos.Hide = false;
            this.tabSplitterPageFavoritos.Image = ((System.Drawing.Image)(resources.GetObject("tabSplitterPageFavoritos.Image")));
            this.tabSplitterPageFavoritos.Location = new System.Drawing.Point(0, 0);
            this.tabSplitterPageFavoritos.Name = "tabSplitterPageFavoritos";
            this.tabSplitterPageFavoritos.Size = new System.Drawing.Size(847, 755);
            this.tabSplitterPageFavoritos.TabIndex = 3;
            this.tabSplitterPageFavoritos.Text = "Favoritos";
            this.tabSplitterPageFavoritos.Paint += new System.Windows.Forms.PaintEventHandler(this.tabSplitterPageFavoritos_Paint);
            // 
            // btnCadastrarFavorito
            // 
            this.btnCadastrarFavorito.BackColor = System.Drawing.Color.Violet;
            this.btnCadastrarFavorito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarFavorito.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFavorito.Location = new System.Drawing.Point(172, 646);
            this.btnCadastrarFavorito.Name = "btnCadastrarFavorito";
            this.btnCadastrarFavorito.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarFavorito.TabIndex = 24;
            this.btnCadastrarFavorito.Text = "Cadastrar";
            this.btnCadastrarFavorito.UseVisualStyleBackColor = false;
            this.btnCadastrarFavorito.Click += new System.EventHandler(this.btnCadastrarFavorito_Click);
            // 
            // btnApagarFavorito
            // 
            this.btnApagarFavorito.BackColor = System.Drawing.Color.DarkOrange;
            this.btnApagarFavorito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagarFavorito.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarFavorito.Location = new System.Drawing.Point(12, 646);
            this.btnApagarFavorito.Name = "btnApagarFavorito";
            this.btnApagarFavorito.Size = new System.Drawing.Size(75, 23);
            this.btnApagarFavorito.TabIndex = 23;
            this.btnApagarFavorito.Text = "Apagar";
            this.btnApagarFavorito.UseVisualStyleBackColor = false;
            this.btnApagarFavorito.Click += new System.EventHandler(this.btnApagarFavorito_Click);
            // 
            // btnAlterarFavorito
            // 
            this.btnAlterarFavorito.BackColor = System.Drawing.Color.Gold;
            this.btnAlterarFavorito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlterarFavorito.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarFavorito.Location = new System.Drawing.Point(91, 646);
            this.btnAlterarFavorito.Name = "btnAlterarFavorito";
            this.btnAlterarFavorito.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarFavorito.TabIndex = 22;
            this.btnAlterarFavorito.Text = "Alterar";
            this.btnAlterarFavorito.UseVisualStyleBackColor = false;
            this.btnAlterarFavorito.Click += new System.EventHandler(this.btnAlterarFavorito_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(-360, 646);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 20;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // dtGridViewFavoritos
            // 
            this.dtGridViewFavoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewFavoritos.Location = new System.Drawing.Point(12, 27);
            this.dtGridViewFavoritos.Name = "dtGridViewFavoritos";
            this.dtGridViewFavoritos.ReadOnly = true;
            this.dtGridViewFavoritos.Size = new System.Drawing.Size(945, 613);
            this.dtGridViewFavoritos.TabIndex = 18;
            // 
            // tabSplitterPageDetalheTarefa
            // 
            this.tabSplitterPageDetalheTarefa.AutoScroll = true;
            this.tabSplitterPageDetalheTarefa.BackColor = System.Drawing.Color.White;
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.txtEdicaoLink);
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.autoLabel5);
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.autoLabel4);
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.txtAdicionaNota);
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.flowLayoutPanel1);
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.lblLista);
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.link);
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.autoLabel3);
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.autoLabel2);
            this.tabSplitterPageDetalheTarefa.Controls.Add(this.txtTitulotarefa);
            this.tabSplitterPageDetalheTarefa.Hide = false;
            this.tabSplitterPageDetalheTarefa.Image = ((System.Drawing.Image)(resources.GetObject("tabSplitterPageDetalheTarefa.Image")));
            this.tabSplitterPageDetalheTarefa.Location = new System.Drawing.Point(867, 0);
            this.tabSplitterPageDetalheTarefa.Name = "tabSplitterPageDetalheTarefa";
            this.tabSplitterPageDetalheTarefa.Size = new System.Drawing.Size(588, 755);
            this.tabSplitterPageDetalheTarefa.TabIndex = 2;
            this.tabSplitterPageDetalheTarefa.Text = "Detalhes Tarefa";
            // 
            // txtEdicaoLink
            // 
            this.txtEdicaoLink.BeforeTouchSize = new System.Drawing.Size(549, 29);
            this.txtEdicaoLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEdicaoLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdicaoLink.Location = new System.Drawing.Point(54, 104);
            this.txtEdicaoLink.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtEdicaoLink.Name = "txtEdicaoLink";
            this.txtEdicaoLink.Size = new System.Drawing.Size(509, 29);
            this.txtEdicaoLink.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtEdicaoLink.TabIndex = 46;
            this.txtEdicaoLink.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEdicaoLink_KeyDown);
            // 
            // autoLabel5
            // 
            this.autoLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.autoLabel5.Location = new System.Drawing.Point(14, 132);
            this.autoLabel5.Name = "autoLabel5";
            this.autoLabel5.Size = new System.Drawing.Size(34, 13);
            this.autoLabel5.TabIndex = 45;
            this.autoLabel5.Text = "Editar";
            this.autoLabel5.Click += new System.EventHandler(this.autoLabel5_Click);
            // 
            // autoLabel4
            // 
            this.autoLabel4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.autoLabel4.Location = new System.Drawing.Point(14, 198);
            this.autoLabel4.Name = "autoLabel4";
            this.autoLabel4.Size = new System.Drawing.Size(30, 13);
            this.autoLabel4.TabIndex = 44;
            this.autoLabel4.Text = "Nota";
            // 
            // txtAdicionaNota
            // 
            this.txtAdicionaNota.BeforeTouchSize = new System.Drawing.Size(549, 29);
            this.txtAdicionaNota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdicionaNota.Location = new System.Drawing.Point(14, 214);
            this.txtAdicionaNota.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtAdicionaNota.Name = "txtAdicionaNota";
            this.txtAdicionaNota.Size = new System.Drawing.Size(560, 20);
            this.txtAdicionaNota.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtAdicionaNota.TabIndex = 43;
            this.txtAdicionaNota.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdicionaNota_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 245);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(560, 484);
            this.flowLayoutPanel1.TabIndex = 42;
            // 
            // lblLista
            // 
            this.lblLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblLista.Location = new System.Drawing.Point(72, 85);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(33, 15);
            this.lblLista.TabIndex = 40;
            this.lblLista.Text = "Lista";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(69, 112);
            this.link.MaximumSize = new System.Drawing.Size(500, 0);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(55, 13);
            this.link.TabIndex = 39;
            this.link.TabStop = true;
            this.link.Text = "linkLabel1";
            this.link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_LinkClicked);
            // 
            // autoLabel3
            // 
            this.autoLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.autoLabel3.Location = new System.Drawing.Point(14, 112);
            this.autoLabel3.Name = "autoLabel3";
            this.autoLabel3.Size = new System.Drawing.Size(23, 15);
            this.autoLabel3.TabIndex = 38;
            this.autoLabel3.Text = "Url";
            // 
            // autoLabel2
            // 
            this.autoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.autoLabel2.Location = new System.Drawing.Point(14, 85);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(33, 15);
            this.autoLabel2.TabIndex = 37;
            this.autoLabel2.Text = "Lista";
            // 
            // txtTitulotarefa
            // 
            this.txtTitulotarefa.BeforeTouchSize = new System.Drawing.Size(549, 29);
            this.txtTitulotarefa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulotarefa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulotarefa.Location = new System.Drawing.Point(14, 41);
            this.txtTitulotarefa.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.txtTitulotarefa.Name = "txtTitulotarefa";
            this.txtTitulotarefa.Size = new System.Drawing.Size(549, 29);
            this.txtTitulotarefa.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Default;
            this.txtTitulotarefa.TabIndex = 36;
            this.txtTitulotarefa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitulotarefa_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(676, 21);
            this.button1.TabIndex = 21;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnNavegar
            // 
            this.btnNavegar.BackColor = System.Drawing.Color.LightBlue;
            this.btnNavegar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNavegar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavegar.Location = new System.Drawing.Point(0, 22);
            this.btnNavegar.Name = "btnNavegar";
            this.btnNavegar.Size = new System.Drawing.Size(676, 21);
            this.btnNavegar.TabIndex = 19;
            this.btnNavegar.Text = "Navegar";
            this.btnNavegar.UseVisualStyleBackColor = false;
            this.btnNavegar.Click += new System.EventHandler(this.btnNavegar_Click);
            // 
            // commandBar1
            // 
            this.commandBar1.ChevronColor = System.Drawing.SystemColors.ControlText;
            this.commandBar1.DockState = Syncfusion.Windows.Forms.Tools.CommandBarDockState.Top;
            this.commandBar1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.commandBar1.MaxLength = 200;
            this.commandBar1.MinHeight = 32;
            this.commandBar1.MinLength = 50;
            this.commandBar1.Name = "commandBar1";
            this.commandBar1.RowIndex = 0;
            this.commandBar1.RowOffset = 0;
            this.commandBar1.TabIndex = 0;
            this.commandBar1.TabStop = false;
            this.commandBar1.Text = "commandBar1";
            // 
            // barItemTipoTarefa
            // 
            this.barItemTipoTarefa.BarName = "barItemTipoTarefa";
            this.barItemTipoTarefa.ID = "item";
            this.barItemTipoTarefa.ShowToolTipInPopUp = false;
            this.barItemTipoTarefa.SizeToFit = true;
            this.barItemTipoTarefa.Text = "Tipos de tarefas";
            this.barItemTipoTarefa.Tooltip = "Tipos de tarefas";
            this.barItemTipoTarefa.Click += new System.EventHandler(this.barItemTipoTarefa_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.CaptionButtonColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.White;
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.Image = ((System.Drawing.Image)(resources.GetObject("captionImage1.Image")));
            captionImage1.Name = "CaptionImage1";
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(1455, 755);
            this.Controls.Add(this.tabSplitterContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.ShowMaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Tarefas";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabSplitterContainer1.ResumeLayout(false);
            this.tabSplitterPageTarefas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAtivos.ResumeLayout(false);
            this.tabPageAtivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInserirTarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewPendentes)).EndInit();
            this.tabPageConcluidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConcluidos)).EndInit();
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel1.PerformLayout();
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdvTarefas)).EndInit();
            this.tabSplitterPageFavoritos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewFavoritos)).EndInit();
            this.tabSplitterPageDetalheTarefa.ResumeLayout(false);
            this.tabSplitterPageDetalheTarefa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdicaoLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdicionaNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitulotarefa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowLayout1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPageTarefas;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPageDetalheTarefa;
        private Syncfusion.Windows.Forms.Tools.TabSplitterPage tabSplitterPageFavoritos;
        private System.Windows.Forms.DataGridView dtGridViewFavoritos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnNavegar;
        private System.Windows.Forms.Button btnAlterarFavorito;
        private System.Windows.Forms.Button btnApagarFavorito;
        public Syncfusion.Windows.Forms.Tools.TabSplitterContainer tabSplitterContainer1;
        private System.Windows.Forms.Button btnCadastrarFavorito;
        private Syncfusion.Windows.Forms.Tools.CommandBar commandBar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItemTipoTarefa;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdvTarefas;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private System.Windows.Forms.DataGridView dtGridViewPendentes;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtInserirTarefa;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel3;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtTitulotarefa;
        private Syncfusion.Windows.Forms.Tools.AutoLabel lblLista;
        private System.Windows.Forms.LinkLabel link;
        private Syncfusion.Windows.Forms.Tools.FlowLayout flowLayout1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtAdicionaNota;
        private Syncfusion.Windows.Forms.ButtonAdv btnMarcarFinalizado;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAtivos;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageConcluidos;
        private System.Windows.Forms.DataGridView dataGridViewConcluidos;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt txtEdicaoLink;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel5;
        private System.Windows.Forms.Label lblAddLista;
        private System.Windows.Forms.Label lblRemoveLista;
    }
}

