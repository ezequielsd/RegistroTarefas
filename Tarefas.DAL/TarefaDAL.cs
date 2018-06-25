using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    public class TarefaDAL
    {
        /// <summary>
        /// Lista de tarefas cadastrados
        /// </summary>
        /// <returns></returns>
        public List<Tarefa> ListarTarefas(int pPendencia)
        {
            using (var ctx = new Context())
            {
                return ctx.Tarefas.Where(c => c.Pendente == pPendencia).ToList();
            }
        }      

        /// <summary>
        /// Listar tarefas pelo tipo
        /// </summary>
        /// <param name="pTipo"></param>
        /// <returns></returns>
        public List<Tarefa> ListarTarefaTipo(string pTipo, int pStatusTarefa)
        {
            using (var ctx = new Context())
            {
                return ctx.Tarefas.Where(c => c.TipoTarefa == pTipo && c.Pendente == pStatusTarefa).ToList();
            }
        }

        /// <summary>
        /// Cadastrar tarefa
        /// </summary>
        /// <param name="pInfo">objeto com os dados da tarefa</param>
        public void CadastrarTarefa(Tarefa pInfo)
        {
            using (var ctx = new Context())
            {
                Tarefa tarefa = new Tarefa();

                tarefa.Titulo = pInfo.Titulo;
                tarefa.Descricao = pInfo.Descricao;
                tarefa.Link = pInfo.Link;
                tarefa.TipoTarefa = pInfo.TipoTarefa;
                tarefa.DataInclusao = pInfo.DataInclusao;
                tarefa.DataFinalizado = pInfo.DataFinalizado;
                tarefa.Pendente = pInfo.Pendente;


                ctx.Tarefas.Add(tarefa);
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Buscar uma tarefa
        /// </summary>
        /// <param name="pId">Id da tarefa</param>
        /// <returns></returns>
        public Tarefa BuscarTarefa(int pId)
        {
            using (var ctx = new Context())
            {
               return ctx.Tarefas.Find(pId);               
            }
        }

        /// <summary>
        /// Alterar tarefa
        /// </summary>
        /// <param name="pInfo">objeto com tipo de dados da tarefa</param>
        public void AlterarTarefa(Tarefa pInfo)
        {
            using (var ctx = new Context())
            {
                Tarefa tarefa = ctx.Tarefas.Find(pInfo.Id);
                
                tarefa.Titulo = pInfo.Titulo;
                tarefa.Descricao = pInfo.Descricao;
                tarefa.Link = pInfo.Link;
                tarefa.TipoTarefa = pInfo.TipoTarefa;
                tarefa.DataInclusao = pInfo.DataInclusao;
                tarefa.DataFinalizado = pInfo.DataFinalizado;
                                          
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Método marca como tarefa concluida
        /// </summary>
        /// <param name="Id"></param>
        public void ConcluirTarefa(int Id)
        {
            using (var ctx = new Context())
            {
                Tarefa tarefa = ctx.Tarefas.Find(Id);

                tarefa.Pendente = 0;
              
                ctx.SaveChanges();
            }
        }

        /// <summary>
        /// Método apagar tarefa
        /// </summary>
        /// <param name="pId">Id da tarefa</param>
        public void ApagarTarefa(int pId)
        {
            using (var ctx = new Context())
            {
                var info = ctx.Tarefas.Find(pId);

                ctx.Tarefas.Remove(info);
                ctx.SaveChanges();
            }
        }
    }
}
