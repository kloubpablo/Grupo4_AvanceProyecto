using WebApplication.Domain.Entities;
using System.Collections.Generic;

namespace WebApplication.Infraestructure.Repositories
{
    public interface IBitacoraRepository
    {
        void Add(BitacoraEvento evento);
        List<BitacoraEvento> GetAll();
    }
}
