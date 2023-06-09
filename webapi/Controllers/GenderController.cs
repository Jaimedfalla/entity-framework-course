using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Persistence.Database;
using webapi.DTOs;
using Domain.Entities;
using AutoMapper.QueryableExtensions;

namespace webapi.Controllers;

[ApiController]
[Route("api/gender")]
public class GenderController:ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GenderController(ApplicationDbContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<GenderDto>>> Get()
    {
        return await _context.Genders
            .ProjectTo<GenderDto>(_mapper.ConfigurationProvider)
            .OrderBy(g => g.Name).ToListAsync();
    }   

    [HttpPost]
    public async Task<IActionResult> Post(GenderDto gender)
    {
        bool existGender = await _context.Genders.AnyAsync(g => g.Name.Equals(gender.Name));

        if(existGender) return BadRequest("Gender already exists!!!");

        Gender g = _mapper.Map<Gender>(gender);

        _context.Add(g);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPost("many")]
    public async Task<IActionResult> Post(GenderDto[] gendersDto)
    {
        Gender[] genders = _mapper.Map<Gender[]>(gendersDto);
        _context.AddRange(genders);
        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("{id:int}/nombre2")]
    public async Task<IActionResult> Put(int id){
        //Actualización modelo conectado
        //Con el método AsTracking sobre escribimos el AsNoTracking configurado en program y así poder utilizar el SaveChanges
        Gender gender = await _context.Genders.AsTracking().FirstOrDefaultAsync(g => g.Id==id);

        if(gender is null) return NotFound();

        gender.Name = $"{gender.Name}2";

        await _context.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> Put(int id,GenderDto genderDto){
        //Actualización modelo desconectado
        Gender gender = _mapper.Map<Gender>(genderDto);
        gender.Id = id;
        _context.Update(gender);

        await _context.SaveChangesAsync();

        return Ok();
    }

    //El siguiente endpoint es la nueva forma de eliminar registros en .Net 7
    [HttpDelete("{id:int}/new")]
    public async  Task<IActionResult> Delete(int id){
        int rowsAffected = await _context.Genders.Where(g => g.Id==id).ExecuteDeleteAsync();

        if(rowsAffected ==0 ) return NotFound();

        return NoContent();
    }

    [HttpDelete("{id:int}/old")]
    public async  Task<IActionResult> DeleteOld(int id){
        Gender gender = await _context.Genders.FirstOrDefaultAsync(g => g.Id==id);

        if(gender is null ) return NotFound();

        _context.Remove(gender);

        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpPost("{id:int}/restore")]
    public async  Task<IActionResult> Restore(int id){
        Gender gender = await _context.Genders
        .AsTracking()
        //Con el siguiente método se ignoran o no tienen en cuenta los filtros configurados en el Api Fluent
        .IgnoreQueryFilters()
        .FirstOrDefaultAsync(g => g.Id==id);

        if(gender is null ) return NotFound();

        gender.IsDeleted = false;
        await _context.SaveChangesAsync();

        return NoContent();
    }
}