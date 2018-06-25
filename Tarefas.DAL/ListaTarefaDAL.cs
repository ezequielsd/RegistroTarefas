using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    public class ListaTarefaDAL
    {
        /// <summary>
        /// Lista os tipos de tarefas cadastrados
        /// </summary>
        /// <returns></returns>
        public List<TipoTarefa> ListaTipoTarefas()
        {
            using (var ctx = new Context())
            {
                return ctx.TipoTarefas.ToList();
            }
        }

        /// <summary>
        /// Cadastrar tipo de tarefa
        /// </summary>
        /// <param name="pInfo">objeto com tipo de dados da tarefa</param>
        public void CadstrarTipoTarefa(TipoTarefa pInfo)
        {
            using (var ctx = new Context())
            {
                TipoTarefa tarefa = new TipoTarefa();

                tarefa.Nome = pInfo.Nome;

                ctx.TipoTarefas.Add(tarefa);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Método apagar tipo de tarefa
        /// </summary>
        /// <param name="pId">Id do tipo</param>
        public void ApagarTipoTarefa(int pId)
        {
            using (var ctx = new Context())
            {
                var info = ctx.TipoTarefas.Find(pId);

                ctx.TipoTarefas.Remove(info);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Método remove a lista de tarefa pelo nome
        /// </summary>
        /// <param name="pListaSelecionada"></param>
        public void ApagarListaTarefa(string pListaSelecionada)
        {
            using (var ctx = new Context())
            {
                TipoTarefa listaTarefa = ctx.TipoTarefas.Where(ta => ta.Nome == pListaSelecionada).FirstOrDefault();
                List<Tarefa> tarefas = ctx.Tarefas.Where(tare => tare.TipoTarefa == listaTarefa.Nome).ToList();

                foreach (Tarefa item in tarefas)
                {
                    ctx.Tarefas.Remove(item);
                }

                ctx.TipoTarefas.Remove(listaTarefa);
                ctx.SaveChanges();                
            }
        }

        /// <summary>
        /// Método seleciona a lista de tarefa conforme no nome passado
        /// </summary>
        /// <param name="pNode"> nome</param>
        /// <returns>objeto tipotarefa</returns>
        public TipoTarefa BuscarListaTarefaSelecionada(string pNode)
        {
            using (var ctx = new Context())
            {
                return ctx.TipoTarefas.Where(t => t.Nome == pNode).SingleOrDefault();
            }
        }
    }
}
