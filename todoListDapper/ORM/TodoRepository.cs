using Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Dapper;

namespace ORM.Interfaces
{
    public class TodoRepository :RepositoryConnector, Interfaces.ITodoRepository
    {
        public TodoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public void Add(ToDo obj)
        {
            throw new NotImplementedException();
        }

        public ToDo Get(int id)
        {
            
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo> GetAll()
        {
            IEnumerable<ToDo> retorno;
            string sql = "SELECT * FROM Todo ";
            using (var connection = new SqlConnection(base.GetConection()))
            {
                retorno = connection.Query<ToDo>(sql);
            }

            return retorno;
        }

        public void Remove(ToDo o)
        {
            throw new NotImplementedException();
        }

        public void Update(ToDo o)
        {
            throw new NotImplementedException();
        }
    }
}
