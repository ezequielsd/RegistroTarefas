using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    public class NotaTarefaDAL
    {
        /// <summary>
        /// Lista os tipos de tarefas cadastrados
        /// </summary>
        /// <returns></returns>
        public List<NotaTarefa> ListaNotasTarefa(long pId)
        {
            using (var ctx = new Context())
            {
                return ctx.NotaTarefas.Where(n => n.TarefaId == pId).ToList();
            }
        }

        /// <summary>
        /// Método adiciona uma nota
        /// </summary>
        /// <param name="pInfo"></param>
        public void AdicionarNota(NotaTarefa pInfo)
        {
            using (var ctx = new Context())
            {
                NotaTarefa nota = new NotaTarefa();

                nota.Nota = pInfo.Nota;
                nota.TarefaId = pInfo.TarefaId;

                ctx.NotaTarefas.Add(nota);
                ctx.SaveChanges();
            }
        }
    }
}
