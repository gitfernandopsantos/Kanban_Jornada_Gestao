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

        [HttpGet("GetAllActivityById/{idAtividade}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Atividade>> GetAllActivityById(int idAtividade)
        {
            try
            {
                var service = _applicationService;
                if (service != null)
                {
                    var byIdActivity = await service.GetAllActivityById(idAtividade);
                    return byIdActivity;
                }
                return BadRequest(500);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpPost("AddActivity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Atividade>> AddActivity([FromBody] AtividadeDTO atividade)
        {
            try
            {
                var service = _applicationService;
                if (service == null)
                {
                    return BadRequest(500);

                }
                else
                {
                    var addActivity = await service.AddActivity(atividade);
                    return Created("Atividade criada com sucesso.",addActivity);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        [HttpPut("UpdateActivity")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<AtividadeDTO>> UpdateActivity([FromBody] AtividadeDTO atividadeDto, int idAtividade)
        {
            try
            {
                var service = _applicationService;
                if (service == null)
                {
                    return BadRequest(500);
                }
                else
                {

                    var updateActivity = await service.UpdateActivity(atividadeDto, idAtividade);
                    return Ok(updateActivity);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpDelete("DeleteActivity{idAtividade}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<bool>> DeleteActivity(int idAtividade)
        {
            try
            {
                var service = _applicationService;
                if (service == null)
                {
                    return BadRequest(500);
                }
                else
                {

                    var deleteActivity = await service.DeleteActivity(idAtividade);
                    return Ok(deleteActivity==true);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Methods Column
        [HttpGet("GetAllColumns")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Coluna>>> GetAllColumns()
        {
            try
            {
                var service = _applicationService;
                if (service != null)
                {
                    var allColumns = await service.GetAllColumns();
                    return Ok(allColumns);
                }
                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetColumnById/{idColuna}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Coluna>> GetColumnById(int idColuna)
        {
            try
            {
                var service = _applicationService;
                if (service != null)
                {
                    var column = await service.GetColumnById(idColuna);
                    if (column != null)
                    {
                        return Ok(column);
                    }
                    return NotFound();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("AddColumn")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<Coluna>> AddColumn([FromBody] ColunaDTO colunaDto)
        {
            try
            {
                var service = _applicationService;
                if (service == null)
                {
                    return BadRequest();
                }
                else
                {
                    var newColumn = await service.AddColumn(colunaDto);
                    return Created("Atividade criada com sucesso.", newColumn);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("UpdateColumn/{idColuna}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<ColunaDTO>> UpdateColumn([FromBody] ColunaDTO colunaDto, int idColuna)
        {
            try
            {
                var service = _applicationService;
                if (service == null)
                {
                    return BadRequest();
                }
                else
                {
                    var updatedColumn = await service.UpdateColumn(colunaDto, idColuna);
                    if (updatedColumn != null)
                    {
                        return Ok(updatedColumn);
                    }
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("DeleteColumn/{idColuna}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<bool>> DeleteColumn(int idColuna)
        {
            try
            {
                var service = _applicationService;
                if (service == null)
                {
                    return BadRequest();
                }
                else
                {
                    var result = await service.DeleteColumn(idColuna);
                    if (result)
                    {
                        return Ok(result);
                    }
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        #endregion

        #region Methods Column X Activity
        [HttpGet("GetAllColunaXAtividades")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ColunaXAtividadeDTO>>> GetAllColunaXAtividades()
        {
            try
            {
                var service = _applicationService;
                if (service != null)
                {
                    var allColunaXAtividades = await service.GetAllColumnsXActivity();
                    return Ok(allColunaXAtividades);
                }
                return StatusCode(500);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("GetColunaXAtividadeById/{idColunaXAtividade}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ColunaXAtividadeDTO>> GetColunaXAtividadeById(int idColunaXAtividade)
        {
            try
            {
                var service = _applicationService;
                if (service != null)
                {
                    var colunaXAtividade = await service.GetColunaXAtividadeById(idColunaXAtividade);
                    if (colunaXAtividade != null)
                    {
                        return Ok(colunaXAtividade);
                    }
                    return NotFound();
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("AddColunaXAtividade")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<ColunaXAtividadeDTO>> AddColunaXAtividade([FromBody] ColunaXAtividadeDTO colunaXAtividadeDto)
        {
            try
            {
                var service = _applicationService;
                if (service == null)
                {
                    return BadRequest();
                }
                else
                {
                    var newColunaXAtividade = await service.AddColumnXActivity(colunaXAtividadeDto);
                    return Created("Atividade associada a uma coluna", newColunaXAtividade);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut("UpdateColunaXAtividade/{idColunaXAtividade}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<ColunaXAtividadeDTO>> UpdateColunaXAtividade([FromBody] ColunaXAtividadeDTO colunaXAtividadeDto, int idColunaXAtividade)
        {
            try
            {
                var service = _applicationService;
                if (service == null)
                {
                    return BadRequest();
                }
                else
                {
                    var updatedColunaXAtividade = await service.UpdateColumnXActivity(colunaXAtividadeDto, idColunaXAtividade);
                    if (updatedColunaXAtividade != null)
                    {
                        return Ok(updatedColunaXAtividade);
                    }
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete("DeleteColunaXAtividade/{idColunaXAtividade}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<bool>> DeleteColunaXAtividade(int idColunaXAtividade)
        {
            try
            {
                var service = _applicationService;
                if (service == null)
                {
                    return BadRequest();
                }
                else
                {
                    var result = await service.DeleteColumnXActivity(idColunaXAtividade);
                    if (result)
                    {
                        return Ok(result);
                    }
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        #endregion
    }
}
