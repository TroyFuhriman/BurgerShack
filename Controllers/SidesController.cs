using System;
using System.Collections.Generic;
using BurgerShack.Models;
using BurgerShack.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class SidesController : ControllerBase
  {
    private readonly SideService _service;
    private readonly ComboService _comboService;


    public SidesController(SideService service, ComboService cs)
    {
      _service = service;
      _comboService = cs;
    }

    [HttpGet]  // GETALL
    public ActionResult<IEnumerable<Side>> Get()
    {
      try
      {
        return Ok(_service.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")] // GETBYID
    public ActionResult<Side> Get(int id)
    {
      try
      {
        return Ok(_service.Get(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost] // POST
    public ActionResult<Side> Create([FromBody] Side newSide)
    {
      try
      {
        return Ok(_service.Create(newSide));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")] // PUT

    public ActionResult<Side> Edit([FromBody] Side editSide, int id)
    {
      try
      {
        editSide.Id = id;
        return Ok(_service.Edit(editSide));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")] // DELETE
    public ActionResult<Side> Delete(int id)
    {
      try
      {
        return Ok(_service.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}