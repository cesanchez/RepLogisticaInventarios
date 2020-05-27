using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.CentrosLogisticos
{
    public class Edit
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string Nombre { get; set; }
            public string Codigo { get; set; }
            public double Latitud { get; set; }
            public double Longitud { get; set; }
            public string Dependencia { get; set; }
            public string Bodegas { get; set; }
            public double AreaBodegas { get; set; }
            public string Patios { get; set; }
            public double AreaPatios { get; set; }
            public string CuartosFrios { get; set; }
            public double AreaCFrios { get; set; }
            public string CuartosQuimicos { get; set; }
            public double AreaCQuimicos { get; set; }
            public string CentrosProdAtiendad { get; set; }
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var cen_log = await _context.CentroLogisticos.FindAsync(request.Id);    

                if (cen_log == null)
                    throw new Exception("Could not find activity");

                cen_log.Nombre= request.Nombre ?? cen_log.Nombre;
                cen_log.Codigo= request.Codigo ?? cen_log.Codigo;
                cen_log.Latitud= request.Latitud;
                cen_log.Longitud= request.Longitud;
                cen_log.Dependencia= request.Dependencia ?? cen_log.Dependencia;
                cen_log.Bodegas= request.Bodegas ?? cen_log.Bodegas;
                cen_log.AreaBodegas= request.AreaBodegas;
                cen_log.Patios= request.Patios ?? cen_log.Patios;
                cen_log.AreaPatios= request.AreaPatios;
                cen_log.CuartosFrios= request.CuartosFrios ?? cen_log.CuartosFrios;
                cen_log.AreaCFrios= request.AreaCFrios;
                cen_log.CuartosQuimicos= request.CuartosQuimicos ?? cen_log.CuartosQuimicos;
                cen_log.AreaCQuimicos= request.AreaCQuimicos;
                cen_log.CentrosProdAtiendad= request.CentrosProdAtiendad ?? cen_log.CentrosProdAtiendad;         

                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}