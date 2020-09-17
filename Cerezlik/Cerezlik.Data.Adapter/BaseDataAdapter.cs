using Cerezlik.Data.Adapter.Session;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using NPoco;
using NPoco.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cerezlik.Data.Adapter
{
    public class BaseDataAdapter : IDisposable
    {
        protected IDatabase Db;

        protected readonly ILogger Logger;
        public static IConfiguration Config;
        protected BaseDataAdapter(DbSession _session = null)
        {
            Db = new Database("Data Source=localhost;Initial Catalog=BUNDLETEST; User Id=sa;Password=123;", DatabaseType.SqlServer2012, System.Data.SqlClient.SqlClientFactory.Instance);
        }

        protected BaseDataAdapter(ILogger logger)
        {
            Logger = logger;
            Db = new Database(Config.GetConnectionString("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BUNDLETEST; User Id=sa;Password=123;"), DatabaseType.SqlServer2012, System.Data.SqlClient.SqlClientFactory.Instance);
        }

        public void Save<T>(T model)
        {
            if (Db.IsNew<T>(model))
            {

            }
            Db.Save<T>(model);
        }

        public void Insert<T>(T model)
        {
            Db.Insert<T>(model);
        }

        public void Update<T>(T model) 
        {
            Db.Update(model);
        }

        public T FirstOrDefault<T>(System.Linq.Expressions.Expression<Func<T, bool>> filter = null) 
        {
            T ret = Db.Query<T>().FirstOrDefault(filter);
            return ret;
        }

        protected IQueryProviderWithIncludes<T> Query<T>()
        {
            return Db.Query<T>();
        }

        public List<T> List<T>()
        {
            //filter = BuildFilter(filter);
            return Db.Fetch<T>();
        }

        public List<T> List<T>(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            List<T> lst = Db.Query<T>().Where(filter).ToList();
            return lst;
        }

        protected List<T> ListByCmd<T>(Sql sqlCmd)
        {
            if (sqlCmd == null)
                return Db.Fetch<T>().ToList();
            else
                return Db.Fetch<T>(sqlCmd).ToList();
        }

        public T SingleByCmd<T>(Sql sqlCmd)
        {
            if (sqlCmd == null)
                throw new Exception("sqlCmd can not be empty");

            return Db.SingleOrDefault<T>(sqlCmd);
        }

        public T SingleByIdTest<T>(string id)
        {
            return Db.SingleOrDefaultById<T>(id);
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (Db != null)
            {
                Db.Dispose();
                Db = null;
            }
            GC.SuppressFinalize(this);
        }
    }
}
