using Entities;
using Entities.Generics;

namespace Domain.Interfaces.Repository
{
    public interface IVendedoresRepository
    {
        MensagemViewModel Create(Vendedores vendedores);
        MensagemViewModel Update(Vendedores vendedores);
        MensagemViewModel Delete(int id);
        Vendedores GetPorId(int id);
        Task<Vendedores> get(int id, string parteNome);
    }
}
