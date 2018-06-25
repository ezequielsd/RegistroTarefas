using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    public class FavoritoDAL
    {
        /// <summary>
        /// Lista de favoritos cadastrados
        /// </summary>
        /// <returns></returns>
        public List<Favorito> ListarFavoritos()
        {
            using (var ctx = new Context())
            {
                return ctx.Favoritos.ToList();
            }
        }
               
        /// <summary>
        /// Cadastrar favorito
        /// </summary>
        /// <param name="pInfo">objeto com os dados do favorito</param>
        public void CadastrarFavorito(Favorito pInfo)
        {
            using (var ctx = new Context())
            {
                Favorito favorito = new Favorito();
                               
                favorito.Descricao = pInfo.Descricao;
                favorito.Link = pInfo.Link;
                
                ctx.Favoritos.Add(favorito);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Buscar um favorito
        /// </summary>
        /// <param name="pId">Id do favorito</param>
        /// <returns></returns>
        public Favorito BuscarFavorito(int pId)
        {
            using (var ctx = new Context())
            {
                return ctx.Favoritos.Find(pId);
            }
        }

        /// <summary>
        /// Alterar favorito
        /// </summary>
        /// <param name="pInfo">objeto com tipo de dados do favorito</param>
        public void AlterarFavorito(Favorito pInfo)
        {
            using (var ctx = new Context())
            {
                Favorito favorito = ctx.Favoritos.Find(pInfo.Id);
                                
                favorito.Descricao = pInfo.Descricao;
                favorito.Link = pInfo.Link;
                

                ctx.SaveChanges();
            }
        }
               
        /// <summary>
        /// Método apagar favorito
        /// </summary>
        /// <param name="pId">Id do favorito</param>
        public void ApagarFavorito(int pId)
        {
            using (var ctx = new Context())
            {
                var info = ctx.Favoritos.Find(pId);

                ctx.Favoritos.Remove(info);
                ctx.SaveChanges();
            }
        }
    }
}
