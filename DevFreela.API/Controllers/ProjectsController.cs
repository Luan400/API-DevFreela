using DevFreela.API.Model;
using DevFreela.Application.Commands.CreateComment;
using DevFreela.Application.Commands.CreateProject;
using DevFreela.Application.Commands.Delete;
using DevFreela.Application.Commands.Finish;
using DevFreela.Application.Commands.Start;
using DevFreela.Application.Commands.Update;
using DevFreela.Application.InputModels;
using DevFreela.Application.Queries.GetAllProject;
using DevFreela.Application.Queries.GetProjectById;
using MediatR;
using Microsoft.AspNetCore.Mvc;



namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
      
        private readonly IMediator _mediator;
        public ProjectsController(IMediator mediator)
        {

            
            _mediator = mediator;
        }

        // api/projects?query=net core
        [HttpGet]
        public async Task<IActionResult> Get(string query)
        {
            // Buscar todos ou filtrar

            

            var getAll = new GetAllProjectQuery(query);

            var project = await _mediator.Send(getAll);

            return Ok(project);
        }

        // api/projects/2
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetProjectByIdQuery(id);

          var project = await _mediator.Send(query);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }


        [HttpPost] 

        public async Task<IActionResult> Post([FromBody] CreateProjectCommand command)
        {

            var id =  await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        // api/project/2
        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, [FromBody] UpdateCommand  command)
        {
            

            await _mediator.Send(command);

            return NoContent();
        }

        //api/project/3

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteCommand(id);

           await _mediator.Send(command);

            return NoContent();
        }
        
        //api/projects/1/comments
        [HttpPost("{id}/comments")]

        public async Task<IActionResult> PostComment(int id, [FromBody] CreateCommentCommand command)
        {

            await _mediator.Send(command);


            return NoContent();
        }

        //api/projects/1/start
        [HttpPut("{id}/start")]

        public async Task<IActionResult> Start(int id)
        {
            var command = new StartCommand(id);

            await _mediator.Send(command);
            return NoContent();
        }

        //api/projects/1/finish
        [HttpPut("{id}/finish")]

        public async Task<IActionResult> Finish(int id)
        {
            var command = new FinishCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }

        
    }
}
