using HeroesBackend.Common.Interfaces;
using HeroesBackend.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesBackend.BusinessLayer
{
    public class HeroHomeBusinessLayer : IHeroHomeBusinessLayer
    {
        private IGenericRepository<HeroHome> repository;

        public HeroHomeBusinessLayer(IGenericRepository<HeroHome> repository)
        {
            this.repository = repository;
        }

        public List<HeroHome> GetAll()
        {
            return this.repository.GetAll();
        }
    }
}
