using ApiKanbanGestao.Dtos;
using ApiKanbanGestao.Entity;
using ApiKanbanGestao.Interfaces.IService;
using Microsoft.AspNetCore.Mvc;

namespace ApiKanbanGestao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KanbanGestaoController : ControllerBase
    {
        private readonly IApplicationService _applicationService;

        public KanbanGestaoController(IApplicationService applicationService)
        {
            _applicationService = applicationService;

        }
        #region Method Activity
        [HttpGet("GetAllActivity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Atividade>>> GetAllActivity()
        {
            try
            {
               
                var service = _applicationService;
                if (service != null)
                {
                    var allActivity = await service.GetAllActivity();
                    return allActivity;
                }
                return StatusCode(500);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpGet("GetAllActivity/{idActivity}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Atividade>> GetAllActivityById(int idActivity)
        {
            try
            {
                var service = _applicationService;
                if (service != null)
                {
                    var allActivity = await service.GetAllActivityById(idActivity);
                    return allActivity;
                }
                return BadRequest(500);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpPost("GetAllActivity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Atividade>> AddActivity([FromBody] Atividade atividade)
        {
            try
            {
                var service = _applicationService;
                if (service != null)
                {
                    var allActivity = await service.AddActivity(atividade);
                    return allActivity;
                }
                return BadRequest(500);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        #endregion
    }
}
