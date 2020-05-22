using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Interface
{
    public interface IRepositoryBaseStoredProcedure<TEntity> where TEntity : class
    {      
        IEnumerable<TEntity> ExecuteReader(string storedProcedureName, SqlParameter[] parameters = null);
        IEnumerable<TEntity> ExecWithStoreProcedure(string query, params object[] parameters);
        IEnumerable<TEntity> ExecWithStoreProcedure(string query);
        bool ExecuteWithStoreProcedure(string query, params object[] parameters);
    }
}
