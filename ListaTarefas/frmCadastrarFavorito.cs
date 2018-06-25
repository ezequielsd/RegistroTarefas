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
    public partial class frmCadastrarFavorito : MetroForm
    {
        FavoritoBLL favoritofaBLL = new FavoritoBLL();

        public frmCadastrarFavorito()
        {
            InitializeComponent();                        
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Favorito favorito = new Favorito();

            favorito.Descricao = txtTitulo.Text;
            favorito.Link = txtLink.Text;

            favoritofaBLL.CadastrarFavorito(favorito);

            Close();
        }
    }
}
