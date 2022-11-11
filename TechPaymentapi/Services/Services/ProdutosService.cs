using Domain.Interfaces.Service;
using Entities;
using Entities.Generics;

namespace Services.Services
{
    public class ProdutosService : IProdutosService
    {
        public MensagemViewModel Create(Produtos produtos)
        {
            throw new NotImplementedException();
        }

        public MensagemViewModel Update(Produtos produtos)
        {
            throw new NotImplementedException();
        }

        public MensagemViewModel Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Produtos> get(int id, string parteDescricao)
        {
            throw new NotImplementedException();
        }       
    }
}
