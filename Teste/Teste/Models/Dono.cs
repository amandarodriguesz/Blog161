using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Teste.Models
{
    public class Dono
    {
        [Key]
        public int DonoId { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public virtual ICollection<Cao> Caes { get; set; }
    }
}
