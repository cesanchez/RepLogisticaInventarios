using System;
using System.Threading;
using System.Threading.Tasks;
using Model;
using MediatR;
using Persistence;

namespace Application.CentrosLogisticos
{
    public class Details
    {
        public class Query : IRequest<CentroLogistico>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, CentroLogistico>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                this._context = context;
            }

            public async Task<CentroLogistico> Handle(Query request, CancellationToken cancellationToken)
            {
                var centro_log = await _context.CentroLogisticos.FindAsync(request.Id);

                return centro_log;
            }
        }
    }
}