using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    public class Tarefa
    {
        public long Id { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string Link { get; set; }

        public string TipoTarefa { get; set; }

        public string DataInclusao { get; set; }

        public string DataFinalizado { get; set; }

        public int Pendente { get; set; }
    }
}
