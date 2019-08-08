using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public ICollection<Mensagem> Mensagens { get; set; }
    }
}
