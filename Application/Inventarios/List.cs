using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Model;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Inventarios
{
    public class List
    {
        public class Query : IRequest<List<Inventario>> { }

        public class Handler : IRequestHandler<Query, List<Inventario>>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
                _context = context;
            }

            public async Task<List<Inventario>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities = await _context.Inventarios.ToListAsync();

                return activities;
            }
        }
    }
}