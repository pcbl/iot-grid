using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IotGrid.OpcClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IotGrid.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpcUaController : ControllerBase
    {

        private readonly ILogger<OpcUaController> _logger;

        public OpcUaController(ILogger<OpcUaController> logger)
        {
            _logger = logger;
        }

        [HttpGet,Route("current/{nodeId}")]
        public ActionResult<string> Current(string nodeId)
        {
            ValueQuery query = new ValueQuery();
            return Ok(query.CurrentValue(nodeId));
        }
    }
}
