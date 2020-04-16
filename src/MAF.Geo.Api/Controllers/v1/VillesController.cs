using AutoMapper;
using MAF.Geo.Api.Dto;
using MAF.Geo.Domain.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MAF.Geo.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/pays/{paysId}/[controller]")]
    [ApiController]
    public class VillesController : ControllerBase
    {
        private readonly IVilleService _villeService;
        private readonly IMapper _mapper;
        private readonly ILogger<VillesController> _logger;

        public VillesController(IVilleService villeService, IMapper mapper, ILogger<VillesController> logger)
        {
            _villeService = villeService;
            _mapper = mapper;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<VilleDto>>> Search(int paysId, string codePostal, string codeInsee, string autoComplete)
        {

            var result = _mapper.Map<List<VilleDto>>(await _villeService.GetVillesByAutocomplete(paysId, autoComplete));

            return Ok(result);
        }

        [HttpGet]
        [Route("autocomplete")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<List<VilleDto>>> AutoComplete(int paysId, string filter)
        {
            var searchResult = await _villeService.GetVillesByAutocomplete(paysId, filter);

            if (searchResult.Count == 0)
                return NotFound("Ville not found");

            var result = _mapper.Map<List<VilleDto>>(searchResult);

            return Ok(result);
        }


    }
}