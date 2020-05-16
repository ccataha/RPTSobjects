using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RPTSobj.DomainObjects;
using RPTSobj.ApplicationServices.GetRPTSobjListUseCase;
using RPTSobj.InfrastructureServices.Presenters;

namespace RPTSobj.InfrastructureServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RPTSobjController : ControllerBase
    {
        private readonly ILogger<RPTSobjController> _logger;
        private readonly IGetRPTSobjListUseCase _getRPTSobjListUseCase;

        public RPTSobjController(ILogger<RPTSobjController> logger,
                                IGetRPTSobjListUseCase getRPTSobjListUseCase)
        {
            _logger = logger;
            _getRPTSobjListUseCase = getRPTSobjListUseCase;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllRPTSobj()
        {
            var presenter = new RPTSobjListPresenter();
            await _getRPTSobjListUseCase.Handle(GetRPTSobjListUseCaseRequest.CreateAllRPTSobjRequest(), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("{rptsObjId}")]
        public async Task<ActionResult> GetRPTSobj(long rptsObjId)
        {
            var presenter = new RPTSobjListPresenter();
            await _getRPTSobjListUseCase.Handle(GetRPTSobjListUseCaseRequest.CreateRPTSobjRequest(rptsObjId), presenter);
            return presenter.ContentResult;
        }

        [HttpGet("MetroLines/{metroLine}")]
        public async Task<ActionResult> GetMetroLineFilter(string metroLine)
        {
            var presenter = new RPTSobjListPresenter();
            await _getRPTSobjListUseCase.Handle(GetRPTSobjListUseCaseRequest.CreateMetroLineRPTSobjRequest(metroLine), presenter);
            return presenter.ContentResult;
        }
    }
}
