using Entities;
using Entities.Generics;

namespace Domain.Interfaces.Service
{
    public interface IVendedoresService
    {
        MensagemViewModel Create(Vendedores vendedores);
        MensagemViewModel Update(Vendedores vendedores);
        MensagemViewModel Delete(string id);
        Task<Vendedores> get(int id, string parteNome);
    }
}
