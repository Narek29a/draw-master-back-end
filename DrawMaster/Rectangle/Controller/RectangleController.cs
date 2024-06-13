using DrawMaster.Rectangle.Models;
using DrawMaster.Rectangle.Service;
using Microsoft.AspNetCore.Mvc;
namespace DrawMaster.Rectangle.Controller;

[ApiController]
[Route("[controller]")]
public class RectangleController : ControllerBase
{
    
    private readonly IRectangleService _rectangleService;

    public RectangleController(IRectangleService rectangleService)
    {
        _rectangleService = rectangleService;
    }

    [HttpGet]
    public async Task<ActionResult<RectangleDimension>> Get()
    {
        var dimensions = await _rectangleService.Get();
        return Ok(dimensions);
    }

    
    [HttpPut]
    public async Task<ActionResult<RectangleDimension>> Update([FromBody] RectangleDimension rectangle)
    {
        var dimensions = await _rectangleService.Update(rectangle);
        return Ok(dimensions);
    }
    
    

}