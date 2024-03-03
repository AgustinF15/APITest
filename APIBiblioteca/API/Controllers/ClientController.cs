using API.Dtos;
using AutoMapper;
using Core.Entities;
using Core.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace API.Controllers
{
    public class ClientController : BaseApiController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClientController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ClientDto>>> Get()
        {
            var response = await _unitOfWork.Client.GetAllAsync();

            if (response is null)
            {
                return BadRequest();
            }

            return _mapper.Map<List<ClientDto>>(response);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ClientDto>> GetId(int id)
        {
            var response = await _unitOfWork.Client.GetByIdAsync(id);

            if(response is null)
            {
                return NotFound();
            }

            return _mapper.Map<ClientDto>(response);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Client>> Post([FromBody] Client client)
        {
            if(client is null)
            {
                return BadRequest();
            }

            _unitOfWork.Client.Add(client);
            await _unitOfWork.SaveAsync();

            return CreatedAtAction(nameof(Post), new { id = client.Id }, client);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Client>> Put(int id, [FromBody] Client client)
        {
            if(client is null)
            {
                return BadRequest();
            }

            var response = await _unitOfWork.Client.GetByIdAsync(id);

            if(response is null)
            {
                return NotFound();
            }

            _unitOfWork.Client.Update(client);
            await _unitOfWork.SaveAsync();
            return client;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var client = await _unitOfWork.Client.GetByIdAsync(id);

            if(client is null)
            {
                return NotFound();
            }

            _unitOfWork.Client.Remove(client);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }

    }
}
