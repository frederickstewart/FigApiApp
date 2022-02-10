﻿using FigApiApp.Models;

namespace FigApiApp.Repositories
{
   public interface ITeamRepository
   {
      Task<IEnumerable<Team>> Get();
      Task<Team> Get(int id);
      Task<Team> Create(Team team);
      Task Update(Team team);
      Task Delete(int id);
   }
}