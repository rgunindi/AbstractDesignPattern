using FurnitureApp.Entities;
using FurnitureApp.Models;
using FurnitureApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChairController : ControllerBase
{
    private readonly IChairRepository _chairRepository;

    public ChairController(IChairRepository chairRepository)
    {
        _chairRepository = chairRepository;
    }

    // GET: api/chair
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var chairs = await _chairRepository.GetAllAsync();
        Console.WriteLine(chairs.Count + " chairs found");
        var chairModelList = chairs.Select(c => new ChairViewModel(c)).ToList();
        return Ok(chairModelList);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Chair chair)
    {
        var newChair = await _chairRepository.AddAsync(chair);
        return Ok(newChair);
    }
}