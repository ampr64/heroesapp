using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesBackend.Common.Interfaces
{
    public interface IStorageConfiguration
    {
        string ConnectionString { get; }
    }
}
