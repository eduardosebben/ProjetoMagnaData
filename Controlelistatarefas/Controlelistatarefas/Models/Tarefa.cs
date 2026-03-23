using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlelistatarefas.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; }
        public DateTime? DataConclusao { get; set; }
        [NotMapped]
        public bool Concluida => DataConclusao.HasValue;
    }
}
