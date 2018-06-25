namespace ListaTarefas
{
    partial class ucNotaTarefa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucNotaTarefa));
            this.linkExcluir = new System.Windows.Forms.LinkLabel();
            this.linkEditar = new System.Windows.Forms.LinkLabel();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // linkExcluir
            // 
            this.linkExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkExcluir.AutoSize = true;
            this.linkExcluir.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkExcluir.Location = new System.Drawing.Point(496, 71);
            this.linkExcluir.Name = "linkExcluir";
            this.linkExcluir.Size = new System.Drawing.Size(38, 13);
            this.linkExcluir.TabIndex = 1;
            this.linkExcluir.TabStop = true;
            this.linkExcluir.Text = "Excluir";
            // 
            // linkEditar
            // 
            this.linkEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkEditar.AutoSize = true;
            this.linkEditar.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkEditar.Location = new System.Drawing.Point(452, 71);
            this.linkEditar.Name = "linkEditar";
            this.linkEditar.Size = new System.Drawing.Size(34, 13);
            this.linkEditar.TabIndex = 2;
            this.linkEditar.TabStop = true;
            this.linkEditar.Text = "Editar";
            // 
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.Color.LightYellow;
            this.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNota.Location = new System.Drawing.Point(16, 14);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ReadOnly = true;
            this.txtNota.Size = new System.Drawing.Size(518, 54);
            this.txtNota.TabIndex = 5;
            // 
            // ucNotaTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.linkEditar);
            this.Controls.Add(this.linkExcluir);
            this.Name = "ucNotaTarefa";
            this.Size = new System.Drawing.Size(550, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkExcluir;
        private System.Windows.Forms.LinkLabel linkEditar;
        private System.Windows.Forms.TextBox txtNota;
    }
}
