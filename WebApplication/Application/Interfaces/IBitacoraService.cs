using System;

namespace WebApplication.Application.Interfaces
{
    public interface IBitacoraService
    {
        Task RegistrarEventoAsync(
            string tabla,
            string tipoEvento,
            object datosAnteriores,
            object datosPosteriores,
            string descripcion = "",
            string strackTrace = ""
            
         );
    }
}
