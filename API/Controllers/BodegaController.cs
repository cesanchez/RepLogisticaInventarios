using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Bodegas;
using Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodegaController
    {
        private readonly IMediator _mediator;
        public BodegaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Bodega>>> List()
        {
            return await _mediator.Send(new List.Query());
            //return await _mediator.Send(new List.Query());
        }
        
    }
}