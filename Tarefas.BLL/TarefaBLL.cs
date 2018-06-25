using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    public class TarefaBLL
    {
        TarefaDAL dal = new TarefaDAL();

        /// <summary>
        /// Lista os tipos de tarefas cadastrados
        /// </summary>
        /// <returns></returns>
        public List<Tarefa> ListarTarefas(int pendencia)
        {
            return dal.ListarTarefas(pendencia);
        }

        /// <summary>
        /// Listar tarefas pelo tipo
        /// </summary>
        /// <param name="pTipo"></param>
        /// <returns></returns>
        public List<Tarefa> ListarTarefaTipo(string pTipo, int pStatusTarefa)
        {
            return dal.ListarTarefaTipo(pTipo, pStatusTarefa);
        }

        /// <summary>
        /// Cadastrar tarefa
        /// </summary>
        /// <param name="info">objeto com dados do tipo de tarefa</param>
        public void CadastrarTarefa(Tarefa info)
        {
            try
            {
                info.Pendente = 1;

                dal.CadastrarTarefa(info);
            }
            catch (Exception)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Buscar uma tarefa
        /// </summary>
        /// <param name="Id">Id da tarefa</param>
        /// <returns></returns>
        public Tarefa BuscarTarefa(int Id)
        {
            return dal.BuscarTarefa(Id);
        }

        /// <summary>
        /// Alterar tarefa
        /// </summary>
        /// <param name="info">objeto com tipo de dados da tarefa</param>
        public void AlterarTarefa(Tarefa info)
        {
            try
            {
                dal.AlterarTarefa(info);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Método marca como tarefa concluida
        /// </summary>
        /// <param name="Id"></param>
        public void ConcluirTarefa(int Id)
        {
            dal.ConcluirTarefa(Id);
        }

        /// <summary>
        /// Método apagar tipo de tarefa
        /// </summary>
        /// <param name="Id">Id do tipo</param>
        public void ApagarTarefa(int Id)
        {
            try
            {
                dal.ApagarTarefa(Id);
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
