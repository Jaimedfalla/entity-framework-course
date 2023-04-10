using AutoMapper;
using AutoMapper.QueryableExtensions;
using ef7_example.Domain.Entities;
using ef7_example.DTOs;
using ef7_example.Infraestructure.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ef7_example.Controllers;

[ApiController]
[Route("api/actors")]
public class ActorController:ControllerBase
{
    public readonly ApplicationDbContext _context;
    public readonly IMapper _mapper;

    public ActorController(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actor>>> Get()
    {
        return await _context.Actors.OrderByDescending(a => a.BirthDate).ToListAsync();
    }

    [HttpGet("name")]
    public async Task<ActionResult<IEnumerable<Actor>>> Get(string nombre)
    {
        // Versión 1
        return await _context.Actors
            .Where(a => a.Name == nombre)
            .OrderBy(a => a.Name)
            .ThenByDescending(a => a.BirthDate)
            .ToListAsync();
    }

    [HttpGet("idynombre")]
        public async Task<ActionResult<IEnumerable<SimpleActorDTO>>> Getidynombre()
        {
            return await _context.Actors
                .ProjectTo<SimpleActorDTO>(_mapper.ConfigurationProvider)//Forma interesante de mapear objetos
                .ToListAsync();
        }

    [HttpPost]
    public async Task<ActionResult> Post(ActorDto actorDto)
    {
        Actor actor = _mapper.Map<Actor>(actorDto);
        _context.Add(actor);
        await _context.SaveChangesAsync();

        return Ok();
    }
}