using Domain.Interfaces.Repository;
using Entities;
using Entities.Generics;

namespace Infrastructure.Repository
{
    public class ProdutosRepository : IProdutosRepository
    {
        public MensagemViewModel Create(Produtos produtos)
        {
            throw new NotImplementedException();
        }

        public MensagemViewModel Update(Produtos produtos)
        {
            throw new NotImplementedException();
        }       

        public Task<Produtos> get(int id, string parteDescricao)
        {
            throw new NotImplementedException();
        }

        public MensagemViewModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Produtos GetPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
