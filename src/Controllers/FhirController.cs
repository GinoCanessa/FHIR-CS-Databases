using Microsoft.AspNetCore.Mvc;

namespace fhir_cs_databases.Controllers;

// "/[base]/[type]/[id]
// "/  fhir/"

[ApiController]
[Route("[controller]")]
public class FhirController : ControllerBase
{
    private readonly ILogger<FhirController> _logger;

    public FhirController(ILogger<FhirController> logger)
    {
        _logger = logger;
    }

    [HttpGet("metadata", Name="GetMetadata")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [Produces("application/fhir+json")]
    public ActionResult GetMetadata()
    {
      return Ok();
    }

    [HttpGet("{resourceName}/{id}", Name="InstanceRead")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult GetTypeId([FromRoute] string resourceName, [FromRoute] string id)
    {
      return NotFound();
    }

    [HttpDelete("{resourceName}/{id}", Name="InstanceDelete")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult DeleteTypeId([FromRoute] string resourceName, [FromRoute] string id)
    {
      return NotFound();
    }

    [HttpPost("{resourceName}", Name="TypeCreate")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult PostType([FromRoute] string resourceName)
    {
      return BadRequest();
    }

    [HttpPut("{resourceName}/{id}", Name="InstanceUpdateOrCreate")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult PutTypeId([FromRoute] string resourceName, [FromRoute] string id)
    {
      return BadRequest();
    }

    [HttpGet("{resourceName}", Name="GetTypeSearch")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult GetTypeSearch([FromRoute] string resourceName)
    {
      return BadRequest();
    }

    [HttpPost("{resourceName}/_search", Name="PostTypeSearch")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [Produces("application/fhir+json")]
    public ActionResult PostTypeSearch()
    {
      return BadRequest();
    }
}
