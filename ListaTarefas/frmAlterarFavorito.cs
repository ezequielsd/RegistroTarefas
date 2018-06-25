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
    public partial class frmAlterarFavorito : MetroForm
    {
        int id;
        FavoritoBLL favoritofaBLL = new FavoritoBLL();

        public frmAlterarFavorito(int pId)
        {
            InitializeComponent();
            id = pId;
        }

        private void frmAlterarFavorito_Load(object sender, EventArgs e)
        {
            Favorito favorito = favoritofaBLL.BuscarFavorito(id);

            txtTitulo.Text = favorito.Descricao;
            txtLink.Text = favorito.Link;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Favorito favorito = new Favorito();

            favorito.Descricao = txtTitulo.Text;
            favorito.Link = txtLink.Text;
            favorito.Id = id;

            favoritofaBLL.AlterarFavorito(favorito);

            Close();
        }
    }
}
