using Domain.Interfaces.Repository;
using Entities;
using Entities.Generics;

namespace Infrastructure.Repository
{
    public class VendedoresRepository : IVendedoresRepository
    {
        public MensagemViewModel Create(Vendedores vendedores)
        {
            throw new NotImplementedException();
        }
        public MensagemViewModel Update(Vendedores vendedores)
        {
            throw new NotImplementedException();
        }
           
        public Task<Vendedores> get(int id, string parteNome)
        {
            throw new NotImplementedException();
        }

        public MensagemViewModel Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Vendedores GetPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
