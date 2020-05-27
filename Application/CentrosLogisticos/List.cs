using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.CentrosLogisticos
{
    public class List
    {
        public class Query : IRequest<List<CentroLogistico>> { }

        public class Handler : IRequestHandler<Query, List<CentroLogistico>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<CentroLogistico>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await _context.CentroLogisticos.ToListAsync();

                return activities;
            }
        }
    }
}