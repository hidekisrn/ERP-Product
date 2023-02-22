using System;
using ERP.Product.Domain.Commands.Requests;
using ERP.Product.Domain.Interfaces.Commands.Handlers;
using Microsoft.AspNetCore.Mvc;

namespace ERP.Product.API.Controllers
{
    [ApiController]
    [Route("metadata")]
    public class MetadataController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public IActionResult Create([FromServices] ICreateMetadataHandler handler, [FromBody] CreateMetadataRequest command)
        {
            var response = handler.Handle(command);
            return Ok(response);
        }
    }
}

