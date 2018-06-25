namespace ListaTarefas
{
    partial class frmConfiguracoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracoes));
            this.tabBarSplitterControl1 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.tabBarPageTipoTarefas = new Syncfusion.Windows.Forms.TabBarPage();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescricaoTipoTarefa = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTipoTarefas = new System.Windows.Forms.DataGridView();
            this.tabBarSplitterControl1.SuspendLayout();
            this.tabBarPageTipoTarefas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBarSplitterControl1
            // 
            this.tabBarSplitterControl1.ActivePageBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(217)))));
            this.tabBarSplitterControl1.BeforeTouchSize = new System.Drawing.Size(352, 429);
            this.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPageTipoTarefas);
            this.tabBarSplitterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.tabBarSplitterControl1.Location = new System.Drawing.Point(0, 0);
            this.tabBarSplitterControl1.Name = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.Resizable = false;
            this.tabBarSplitterControl1.ScrollButtons = Syncfusion.Windows.Forms.DisplayArrowButtons.None;
            this.tabBarSplitterControl1.ShowVerticalScrollBar = false;
            this.tabBarSplitterControl1.Size = new System.Drawing.Size(352, 429);
            this.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Metro;
            this.tabBarSplitterControl1.TabFolderDelta = 11;
            this.tabBarSplitterControl1.TabIndex = 0;
            this.tabBarSplitterControl1.Text = "tabBarSplitterControl1";
            // 
            // tabBarPageTipoTarefas
            // 
            this.tabBarPageTipoTarefas.Controls.Add(this.btnApagar);
            this.tabBarPageTipoTarefas.Controls.Add(this.label3);
            this.tabBarPageTipoTarefas.Controls.Add(this.groupBox1);
            this.tabBarPageTipoTarefas.Controls.Add(this.dataGridViewTipoTarefas);
            this.tabBarPageTipoTarefas.Location = new System.Drawing.Point(0, 0);
            this.tabBarPageTipoTarefas.Name = "tabBarPageTipoTarefas";
            this.tabBarPageTipoTarefas.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPageTipoTarefas.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPageTipoTarefas.TabBarColor = System.Drawing.Color.Empty;
            this.tabBarPageTipoTarefas.TabMaxWidth = 100;
            this.tabBarPageTipoTarefas.Text = "Tipos de tarefas";
            this.tabBarPageTipoTarefas.ThemesEnabled = false;
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Bisque;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApagar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(244, 264);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipos de tarefas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescricaoTipoTarefa);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 300);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 90);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar nova tarefa";
            // 
            // txtDescricaoTipoTarefa
            // 
            this.txtDescricaoTipoTarefa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricaoTipoTarefa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoTipoTarefa.Location = new System.Drawing.Point(10, 51);
            this.txtDescricaoTipoTarefa.Name = "txtDescricaoTipoTarefa";
            this.txtDescricaoTipoTarefa.Size = new System.Drawing.Size(191, 22);
            this.txtDescricaoTipoTarefa.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.PowderBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(207, 50);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição da nova tarefa";
            // 
            // dataGridViewTipoTarefas
            // 
            this.dataGridViewTipoTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTipoTarefas.Location = new System.Drawing.Point(25, 34);
            this.dataGridViewTipoTarefas.Name = "dataGridViewTipoTarefas";
            this.dataGridViewTipoTarefas.Size = new System.Drawing.Size(294, 224);
            this.dataGridViewTipoTarefas.TabIndex = 7;
            // 
            // frmConfiguracoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 429);
            this.Controls.Add(this.tabBarSplitterControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguracoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações";
            this.Load += new System.EventHandler(this.frmConfiguracoes_Load);
            this.tabBarSplitterControl1.ResumeLayout(false);
            this.tabBarPageTipoTarefas.ResumeLayout(false);
            this.tabBarPageTipoTarefas.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTipoTarefas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Syncfusion.Windows.Forms.TabBarPage tabBarPageTipoTarefas;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricaoTipoTarefa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewTipoTarefas;
        private Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl1;
    }
}