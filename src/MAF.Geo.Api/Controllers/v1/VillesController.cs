using MAF.Geo.Api.Dto;
using MAF.Geo.Domain.Service.Ville;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace MAF.Geo.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class VillesController : ControllerBase
    {
        private readonly IVilleService _villeService;
        private readonly ILogger<VillesController> _logger;

        public VillesController(IVilleService villeService, ILogger<VillesController> logger)
        {
            _villeService = villeService;
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<VilleDto>> Get([FromQuery] string codePostal)
        {
            var result = new List<VilleDto>()
            {
                new VilleDto
                {
                    CodePostal = "94230",
                    NomVille = "Cachan"
                }
            };

            return result;
        }


    }
}