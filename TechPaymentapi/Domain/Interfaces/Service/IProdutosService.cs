using Entities;
using Entities.Generics;

namespace Domain.Interfaces.Service
{
    public interface IProdutosService
    {
        MensagemViewModel Create(Produtos produtos);
        MensagemViewModel Update(Produtos produtos);
        MensagemViewModel Delete(string id);
        Task<Produtos> get(int id, string parteDescricao);
    }
}
