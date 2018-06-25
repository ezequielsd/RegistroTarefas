using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTarefas
{
    public class NotaTarefa
    {
        public long Id { get; set; }

        public string Nota { get; set; }

        public long TarefaId { get; set; }
    }
}
