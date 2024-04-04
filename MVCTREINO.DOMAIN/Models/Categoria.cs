using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTREINO.DOMAIN.Models
{
    public record Categoria : ClassBase
    {
        public string Nome { get; set; } = default!;
        public string Descricao { get; set; } = default!;

        public Usuario Usuario { get; set; } = default!;
        public Guid IdUsuario { get; set; }

        public ICollection<Produto>? Produto { get; set; }
    }
}
