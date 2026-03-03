using System.Text.Json;
using WebApplication.Application.Interfaces;
using WebApplication.Infrastructure.Data;

namespace WebApplication.Application.Services
{
    public class BitacoraService : IBitacoraService
    {
        private readonly AppDbContext _context;

        public BitacoraService(AppDbContext context)
        {
            _context = context;
        }

        public async Task RegistrarEventoAsync(
            string tabla,
            string tipoEvento,
            object datosAnteriores,
            object datosPosteriores,
            string descripcion = "",
            string strackTrace = ""
        )
        {
            var evento = new Domain.Entities.BitacoraEvento
            {
                TablaDeEvento = tabla,
                TipoDeEvento = tipoEvento,
                FechaDeEvento = DateTime.UtcNow,
                DescripcionDeEvento = descripcion,
                StrackTrace = strackTrace,
                DatosAnteriores = JsonSerializer.Serialize(datosAnteriores),
                DatosPosteriores = JsonSerializer.Serialize(datosPosteriores)
            };
            await _context.BITACORA_EVENTOS.AddAsync(evento);
            await _context.SaveChangesAsync();

        }
    }
}