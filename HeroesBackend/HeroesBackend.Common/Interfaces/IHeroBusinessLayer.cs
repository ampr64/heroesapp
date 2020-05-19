using System.Collections.Generic;
using HeroesBackend.Common.Pagging;
using HeroesBackend.Entities;

namespace HeroesBackend.Common.Interfaces
{
    public interface IHeroBusinessLayer
    {
        List<Hero> GetAll();
        Hero GetOne(int id);
        PagedListResult<Hero> GetPaginated(int pageNumber, int pageSize, string sortby, SortDirection sortDirection);
        bool Save(Hero hero);
        List<Hero> SearchHeroByName(string term);
    }
}