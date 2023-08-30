using FurnitureApp.Entities;
using FurnitureApp.Models;
using FurnitureApp.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FurnitureApp.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ChairController : Controller
{
    public required IChairRepository ChairRepository;

    public ChairController(IChairRepository chairRepository)
    {
        ChairRepository = chairRepository;
    }

    // GET: api/chair
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        List<Chair> chairs = await ChairRepository.GetAllAsync();
        Console.WriteLine(chairs.Count+" chairs found");
        // var chairModelList = chairs.Select(c => new ChairViewModel(c)
        // {
        //     Name = c.Name ?? "",
        // }).ToList();
        return Ok(chairs);
    }
}