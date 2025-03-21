using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace to_do_list.Models
{
    public class Tarefa
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TarefaId { get; set; }
        [Required(ErrorMessage = "Informe a descrição da tarefa")]
        public string Descricao { get; set; }
        public bool Concluida { get; set; } = false;
        public bool Urgencia { get; set; } = false;
        public Tarefa() { }
        public Tarefa(string descricao)
        {
            Descricao = descricao;
        }
          public Tarefa(string descricao, bool urgencia)
        {
            Descricao = descricao;
            Urgencia = urgencia;
            Concluida = false;
        }

    }
}