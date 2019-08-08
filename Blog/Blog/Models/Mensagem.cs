using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Mensagem
    {
       [Key]
        public int MensagemId { get; set; }
        [Display(Name = "Título")]
        public string Título { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Data da mensagem")]
        public DateTime DataMensagem { get; set; }
        [Display(Name = "Categoria")]
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        

    }
}
