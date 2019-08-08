using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class Cao
    {
        [Key]
        public int CachorroId { get; set; }
        [Display(Name = "Nome:")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Porfavor selecione um dono")]
        [Display(Name = "Dono:")]
        public int DonoId { get; set; }

        public virtual Dono Dono { get; set; }
    }
}
