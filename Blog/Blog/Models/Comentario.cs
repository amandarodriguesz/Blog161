using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Comentario
    {
        [Key]
        public int ComentarioId { get; set; }
        [Display(Name = "Título")]
        public string Titulo { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        [Display(Name = "Data Comentário")]
        public DateTime DataComentario { get; set; }
        [Display(Name = "Autor")]
        public string Autor { get; set; }
        [ForeignKey("Mensagem")]
        [Display(Name = "Mensagem")]
        public int MensagemId { get; set; }
        public ICollection<Mensagem> Mensagens { get; set; }
    }
}
