using Dapper;
using Dapper.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DIWebApiTest.Models
{
    public class Repository<T> : IRepository<T>
    {
        private readonly IDbConnection _connection;
        private readonly IQuery<T> _query;

        public Repository(IDbConnection connection, 
            IQuery<T> query)
        {
            _connection = connection;
            _query = query;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public T GetById(string id)
        {
            return _connection.Query<T>(_query.QueryText).FirstOrDefault();
        }

        public void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}