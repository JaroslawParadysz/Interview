using IndustrialFactory.Core.DTO;
using IndustrialFactory.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace IndustrialFactory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeasurementController : ControllerBase
    {
        private IIndustrialFactoryService Service { get; }

        public MeasurementController(IIndustrialFactoryService service)
        {
            Service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<MeasurementDetailsDto>> Get([FromRoute] Guid id)
        {
            var dto = await Service.GetAsync(id);
            return Ok(dto);
        }
    }
}
