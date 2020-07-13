using System;
using System.Collections.Generic;
using BurgerShack.Models;
using BurgerShack.Services;
using Microsoft.AspNetCore.Mvc;

namespace BurgerShack.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CombosController : ControllerBase
  {
    private readonly ComboService _comboService;


    public CombosController(ComboService cs)
    {
      _comboService = cs;
    }

    [HttpGet]  // GETALL
    public ActionResult<IEnumerable<DbCombo>> Get()
    {
      try
      {
        return Ok(_comboService.Get());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpGet("{id}")] // GETBYID
    public ActionResult<DbCombo> Get(int id)
    {
      try
      {
        return Ok(_comboService.Get(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost] // POST
    public ActionResult<DbCombo> Create([FromBody] DbCombo newCombo)
    {
      try
      {
        return Ok(_comboService.Create(newCombo));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpPut("{id}")] // PUT

    public ActionResult<DbCombo> Edit([FromBody] DbCombo editCombo, int id)
    {
      try
      {
        editCombo.Id = id;
        return Ok(_comboService.Edit(editCombo));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
    [HttpDelete("{id}")] // DELETE
    public ActionResult<DbCombo> Delete(int id)
    {
      try
      {
        return Ok(_comboService.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}