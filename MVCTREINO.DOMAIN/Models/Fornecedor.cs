using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTREINO.DOMAIN.Models
{
    public record Fornecedor : ClassBase
    {
        public string Name { get; set; } = default!;
        public int Avaliacao { get; set; }
        public string Localizacao { get; set; } = default!;
        public string? Contato { get; set; }
        public string? Instagram { get; set; }
        public string? Facebook { get; set; }

        public Produto? Produto { get; set; }
        public Guid IdProduto { get; set; }

    }
}
