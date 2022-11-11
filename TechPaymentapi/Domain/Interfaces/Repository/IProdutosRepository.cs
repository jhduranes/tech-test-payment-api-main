using Entities;
using Entities.Generics;

namespace Domain.Interfaces.Repository
{
    public interface IProdutosRepository
    {
        MensagemViewModel Create(Produtos produtos);
        MensagemViewModel Update(Produtos produtos);
        MensagemViewModel Delete(int id);
        Produtos GetPorId(int id);
        Task<Produtos> get(int id, string parteDescricao);
    }
}
