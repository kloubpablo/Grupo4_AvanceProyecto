using WebApplication.Application.Interfaces;
using WebApplication.Domain.Entities;
using WebApplication.Infrastructure.Repositories;
using System;
using System.Text.Json;


namespace WebApplication.Application.Services
{
    public class BitacoraService : IBitacoraService
    {
        private readonly IBitacoraRepository _repository;

        public BitacoraService(IBitacoraRepository repository)
        {
            _repository = repository;
        }

        public void RegistrarEvento(string modulo, string accion, string datosAntes, string datosDespues, string usuario)
        {
            var evento = new BitacoraEvento
            {
                Modulo = modulo,
                Accion = accion,
                DatosAntes = datosAntes,
                DatosDespues = datosDespues != null ? JsonSerializer.Serialize(datosAntes) : null,
                Fecha = DateTime.UtcNow,
                Usuario = usuario
            };
            _repository.Add(evento);
        }
    }
}
