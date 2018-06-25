using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    public class ListaTarefaBLL
    {
        ListaTarefaDAL dal = new ListaTarefaDAL();

        /// <summary>
        /// Lista os tipos de tarefas cadastrados
        /// </summary>
        /// <returns></returns>
        public List<TipoTarefa> ListaTipoTarefas()
        {
            return dal.ListaTipoTarefas();
        }

        /// <summary>
        /// Cadastrar tarefa
        /// </summary>
        /// <param name="pInfo">objeto com dados do tipo de tarefa</param>
        public void CadstrarTipoTarefa(TipoTarefa pInfo)
        {
            dal.CadstrarTipoTarefa(pInfo);
        }

        /// <summary>
        /// Método apagar tipo de tarefa
        /// </summary>
        /// <param name="pId">Id do tipo</param>
        public void ApagarTipoTarefa(int pId)
        {
            try
            {
                dal.ApagarTipoTarefa(pId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Apagar lista de tarefa
        /// </summary>
        /// <param name="pListaSelecionada"></param>
        public void ApagarListaTarefa(string pListaSelecionada)
        {
            try
            {
                dal.ApagarListaTarefa(pListaSelecionada);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Método seleciona a lista de tarefa conforme o nome passado
        /// </summary>
        /// <param name="pNode">nome da lista</param>
        /// <returns></returns>
        public TipoTarefa BuscarListaTarefaSelecionada(string pNode)
        {
            return dal.BuscarListaTarefaSelecionada(pNode);
        }
    }
}
