using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    public class NotaTarefaBLL
    {
        NotaTarefaDAL dal = new NotaTarefaDAL();

        /// <summary>
        /// Lista os tipos de tarefas cadastrados
        /// </summary>
        /// <returns></returns>
        public List<NotaTarefa> ListaNotasTarefa(long pId)
        {
            return dal.ListaNotasTarefa(pId);
        }

        /// <summary>
        /// Método adiciona uma nota
        /// </summary>
        /// <param name="pInfo"></param>
        public void AdicionarNota(NotaTarefa pInfo)
        {
            dal.AdicionarNota(pInfo);
        }
     }
}
