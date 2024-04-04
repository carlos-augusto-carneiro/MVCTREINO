using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTREINO.DOMAIN.Models
{
    public record Usuario : ClassBase
    {
        public string Nome { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Senha { private get; set; } = default!;
        public DateTime DataCriacao { get; set; }

        public ICollection<Categoria>? Categoria { get; set; }
    }
}
