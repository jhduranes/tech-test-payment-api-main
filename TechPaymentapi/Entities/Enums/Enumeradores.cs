using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Enums
{
    public class Enumeradores
    {
        public enum EStatusVenda
        {
            [StringValue("Pagamento aprovado")]
            PagamentoAprovado,
            [StringValue("Enviado para transportadora")]
            EnviadoParaTransportadora,
            [StringValue("Entregue")]
            Entregue,
            [StringValue("Cancelada")]
            Cancelada
        }
    }
}
