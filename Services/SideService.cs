using System;
using System.Collections.Generic;
using BurgerShack.Models;
using BurgerShack.Repositories;

namespace BurgerShack.Services
{
  public class SideService
  {
    private readonly SideRepository _repo;
    public SideService(SideRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Side> Get()
    {
      return _repo.GetAll();
    }

    internal Side Get(int id)
    {
      Side found = _repo.GetById(id);
      if (found == null)
      {
        throw new Exception("Invalid Side Id");
      }
      return found;
    }

    internal Side Create(Side newSide)
    {
      _repo.Create(newSide);
      return newSide;
    }

    internal Side Edit(Side editSide)
    {
      Side original = Get(editSide.Id);
      original.Name = editSide.Name.Length > 0 ? editSide.Name : original.Name;
      original.Description = editSide.Description.Length > 0 ? editSide.Description : original.Description;
      original.Price = editSide.Price > 0 ? editSide.Price : original.Price;

      _repo.Edit(original);
      return original;

    }

    internal Side Delete(int id)
    {
      Side sideToDelete = Get(id);
      _repo.Delete(sideToDelete);
      return sideToDelete;
    }
  }
}