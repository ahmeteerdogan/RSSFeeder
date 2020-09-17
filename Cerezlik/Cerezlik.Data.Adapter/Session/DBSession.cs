using NPoco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cerezlik.Data.Adapter.Session
{
    public class DbSession : IDisposable
    {
        private readonly IDatabase _database;
        private readonly ITransaction _transaction;

        private int tranlevel;
        private int scopelevel;
        public DbSession(IDatabase db, bool transactional, bool strict = false)
        {
            _database = db;
            if (transactional)
            {
                if (strict)
                    _transaction = _database.GetTransaction(IsolationLevel.ReadCommitted);
                else
                    _transaction = _database.GetTransaction(IsolationLevel.ReadUncommitted);
            }
        }

        public void AddLevel(bool transactional)
        {
            scopelevel++;

            if (_transaction != null && transactional)
                tranlevel++;
        }


        public IDatabase Database
        {
            get
            {
                return _database;
            }
        }

        public void SaveChanges()
        {
            if (_transaction == null)
                throw new Exception("This method can not be invoced in nonTransactional sessions");

            tranlevel--;
            if (tranlevel == 0)
                _transaction.Complete();
        }

        public bool Disposed { get; set; }
        public void Dispose()
        {
            scopelevel--;
            if (scopelevel == 0)
            {
                if (_transaction != null)
                    _transaction.Dispose(); // bu db yi de dispose ediyor sanırım.
                else
                    _database.Dispose();

                Disposed = true;
            }
            GC.SuppressFinalize(this);
        }
    }
}
