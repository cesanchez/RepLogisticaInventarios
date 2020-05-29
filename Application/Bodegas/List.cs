using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Bodegas
{
    public class List
    {
         public class Query : IRequest<List<Bodega>> { }

         public class Handler : IRequestHandler<Query, List<Bodega>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Bodega>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await _context.Bodegas.ToListAsync();

                return activities;
            }
        }

    }
}