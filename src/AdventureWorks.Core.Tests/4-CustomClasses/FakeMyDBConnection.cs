﻿using AdventureWorks.Core.Domain.Entities;
using Harbin.Infrastructure.Database.Connection;
using Harbin.Infrastructure.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace AdventureWorks.Core.Tests.CustomClasses
{
    public class FakeMyDBConnection : MyDBConnection
    {
        public FakeMyDBConnection() : base(null)
        {
        }

        #region DbCommands
        public override void CalculateBestCustomers(IDbTransaction transaction = null, int? commandTimeout = null)
        {
            return; // do nothing! (we don't even have a real underlying IDbConnection)
        }
        #endregion

        #region Custom Repositories
        public override IReadWriteDbRepository<TEntity> GetReadWriteRepository<TEntity>()
        {
            if (typeof(TEntity) == typeof(Person))
                return (IReadWriteDbRepository<TEntity>) new FakePersonRepository(this);
            return base.GetReadWriteRepository<TEntity>();
        }
        #endregion
    }
}
