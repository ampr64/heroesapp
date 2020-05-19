using HeroesBackend.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroesBackend.Common
{
    public class StorageConfiguration : IStorageConfiguration
    {
        string _connectionString;
        public string ConnectionString { get => _connectionString; }

        public StorageConfiguration(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }
    }
}
