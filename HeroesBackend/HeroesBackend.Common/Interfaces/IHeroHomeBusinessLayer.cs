using System.Collections.Generic;
using HeroesBackend.Entities;

namespace HeroesBackend.Common.Interfaces
{
    public interface IHeroHomeBusinessLayer
    {
        List<HeroHome> GetAll();
    }
}