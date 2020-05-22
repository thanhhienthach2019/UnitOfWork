using Data;
using Repository.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Infrastructure.Implement
{
    public class RepositoryBaseStoredProcedure<TEntity> : IRepositoryBaseStoredProcedure<TEntity> where TEntity : class
    {
        private ISBEntities _dbContext;

        public RepositoryBaseStoredProcedure(ISBEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<TEntity> ExecuteReader(string storedProcedureName, SqlParameter[] parameters = null)
        {
            if (parameters != null && parameters.Any())
            {
                var parameterBuilder = new StringBuilder();
                parameterBuilder.Append(string.Format("EXEC {0} ", storedProcedureName));

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].SqlDbType == SqlDbType.VarChar
                        || parameters[i].SqlDbType == SqlDbType.NVarChar
                        || parameters[i].SqlDbType == SqlDbType.Char
                        || parameters[i].SqlDbType == SqlDbType.NChar
                        || parameters[i].SqlDbType == SqlDbType.Text
                        || parameters[i].SqlDbType == SqlDbType.NText)
                    {
                        parameterBuilder.Append(string.Format("{0}='{1}'", parameters[i].ParameterName,
                            string.IsNullOrEmpty(parameters[i].Value.ToString())
                            ? string.Empty : parameters[i].Value.ToString()));
                    }
                    else if (parameters[i].SqlDbType == SqlDbType.BigInt
                       || parameters[i].SqlDbType == SqlDbType.Int
                       || parameters[i].SqlDbType == SqlDbType.TinyInt
                       || parameters[i].SqlDbType == SqlDbType.Decimal
                       || parameters[i].SqlDbType == SqlDbType.Float
                       || parameters[i].SqlDbType == SqlDbType.Money
                       || parameters[i].SqlDbType == SqlDbType.SmallInt
                       || parameters[i].SqlDbType == SqlDbType.SmallMoney)
                    {
                        parameterBuilder.Append(string.Format("{0}={1}", parameters[i].ParameterName
                            , parameters[i].Value));
                    }
                    else if (parameters[i].SqlDbType == SqlDbType.Bit)
                    {
                        parameterBuilder.Append(string.Format("{0}={1}", parameters[i].ParameterName,
                            Convert.ToBoolean(parameters[i].Value)));
                    }

                    if (i < parameters.Length - 1)
                    {
                        parameterBuilder.Append(",");
                    }
                }

                var query = parameterBuilder.ToString();
                var result = _dbContext.Database.SqlQuery<TEntity>(query);
                return result.ToList();
            }
            else
            {
                var result = _dbContext.Database.SqlQuery<TEntity>(string.Format("EXEC {0}", storedProcedureName));
                return result.ToList();
            }
        }

        public bool ExecuteWithStoreProcedure(string query, params object[] parameters)
        {
            bool checkComman;
            if(_dbContext.Database.ExecuteSqlCommand(query, parameters) > 0)
            {
                checkComman = true;
            }else
            {
                checkComman = false;
            }
            return checkComman;
        }

        public IEnumerable<TEntity> ExecWithStoreProcedure(string query)
        {
            return _dbContext.Database.SqlQuery<TEntity>(query);
        }

        public IEnumerable<TEntity> ExecWithStoreProcedure(string query, params object[] parameters)
        {
            return _dbContext.Database.SqlQuery<TEntity>(query, parameters);
        }

    }
}
