using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTREINO.DOMAIN.Models
{
    public record Produto : ClassBase
    {
        public string Nome { get; set; } = default!;
        public string Descricao { get; set; } = default!;
        public decimal PrecoCompra { get; set; }
        public decimal PrecoFrete { get; set; }
        public decimal PorcentagemLucro { get; set; }

        public Categoria Categoria { get; set; } = default!;
        public Guid IdCategoria { get; set; }

        public ICollection<Fornecedor>? Fornecedor { get; set; }

    }
}
