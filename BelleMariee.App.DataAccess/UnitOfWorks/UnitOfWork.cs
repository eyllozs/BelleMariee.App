using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BelleMariee.App.DataAccess.Contexts;
using BelleMariee.App.DataAccess.Repositories;
using BelleMariee.App.Entity.Repositories;
using BelleMariee.App.Entity.UnitOfWorks;

namespace BelleMariee.App.DataAccess.UnitOfWorks
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly BelleDbContext _context;
		private bool disposed = false;
		public UnitOfWork(BelleDbContext context)
		{
			_context = context;
		}
		public IRepository<T> GetRepository<T>() where T : class, new()
		{
			return new Repository<T>(_context);
		}
		public void Commit()
		{
			_context.SaveChanges();
		}
		public async Task CommitAsync()
		{
			await _context.SaveChangesAsync();
		}
		public virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
			this.disposed = true;
		}
		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);      //GC - Garbage Collector
		}

	}
}
