using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Links.Tests
{
    [TestClass]
    public class PersistenceTest<TContext> : UnitTest where TContext : DbContext, new()
    {
        private readonly TContext _context;

        private DbContextTransaction _transaction;

        public PersistenceTest()
        {
            _context = new TContext();
        }
            
        [TestInitialize]
        public void TestInitialize()
        {
            _transaction = _context.Database.BeginTransaction();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            _transaction.Rollback();
        }

        protected T Insert<T>(T item) where T : class
        {
            var entity = _context.Set<T>().Add(item);
            _context.SaveChanges();
            return entity;
        }

        public T SingleOrDefault<T>(Expression<Func<T, bool>> match) where T : class
        {
            return _context.Set<T>().SingleOrDefault(match);
        }
    }
}