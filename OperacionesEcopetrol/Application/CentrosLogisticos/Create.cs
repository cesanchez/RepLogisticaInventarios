using System;
using System.Threading;
using System.Threading.Tasks;
using Model;
using MediatR;
using Persistence;

namespace Application.CentrosLogisticos
{
    public class Create
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
                var centro_log = new CentroLogistico
                {
                    Id = request.Id,
                    Nombre = request.Nombre,
                    Codigo =request.Codigo,
                    Latitud = request.Latitud,
                    Longitud = request.Longitud,
                    Dependencia = request.Dependencia,
                    Bodegas = request.Bodegas,
                    AreaBodegas = request.AreaBodegas,
                    Patios = request.Patios,
                    AreaPatios = request.AreaPatios,
                    CuartosFrios = request.CuartosFrios,
                    AreaCFrios = request.AreaCFrios,
                    CuartosQuimicos = request.CuartosQuimicos,
                    AreaCQuimicos = request.AreaCQuimicos,
                    CentrosProdAtiendad = request.CentrosProdAtiendad

                };

                _context.CentroLogisticos.Add(centro_log);
                var success = await _context.SaveChangesAsync() > 0;

                if (success) return Unit.Value;

                throw new Exception("Problem saving changes");
            }
        }
    }
}