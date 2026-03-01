using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class ComercioBussines
    {
        private readonly IComercioRepository _repo;

        public ComercioBussines(IComercioRepository repo)
        {
            _repo = repo;
        }

        ////////////////////// LISTAR //////////////////////
        public List<Comercio> Listar()
        {
            return _repo.ObtenerTodos();
        }

        ////////////////////// REGISTRAR //////////////////////
        public void Registrar(Comercio comercio)
        {
            comercio.FechaDeRegistro = DateTime.Now;
            comercio.Estado = true;

            _repo.Agregar(comercio);
        }

        ////////////////////// EDITAR //////////////////////
        public void Editar(Comercio comercio)
        {
            comercio.FechaDeModificacion = DateTime.Now;

            _repo.Actualizar(comercio);
        }

        public Comercio Obtener(int id)
        {
            return _repo.ObtenerPorId(id);
        }
    }
}
