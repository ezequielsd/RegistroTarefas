using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{        
    public class FavoritoBLL
    {
        FavoritoDAL dal = new FavoritoDAL();

        /// <summary>
        /// Lista de favoritos cadastrados
        /// </summary>
        /// <returns></returns>
        public List<Favorito> ListarFavoritos()
        {
            return dal.ListarFavoritos();
        }

        /// <summary>
        /// Cadastrar favorito
        /// </summary>
        /// <param name="pInfo">objeto com os dados do favorito</param>
        public void CadastrarFavorito(Favorito pInfo)
        {
            dal.CadastrarFavorito(pInfo);
        }

        /// <summary>
        /// Buscar um favorito
        /// </summary>
        /// <param name="pId">Id do favorito</param>
        /// <returns></returns>
        public Favorito BuscarFavorito(int pId)
        {
            return dal.BuscarFavorito(pId);
        }

        /// <summary>
        /// Alterar favorito
        /// </summary>
        /// <param name="pInfo">objeto com tipo de dados do favorito</param>
        public void AlterarFavorito(Favorito pInfo)
        {
            dal.AlterarFavorito(pInfo);
        }

        /// <summary>
        /// Método apagar favorito
        /// </summary>
        /// <param name="pId">Id do favorito</param>
        public void ApagarFavorito(int pId)
        {
            dal.ApagarFavorito(pId);
        }
    }
}
