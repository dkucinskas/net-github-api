using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace GithubApi.ObjectModel
{
	public class GithubObject : IDisposable
	{
		private bool _disposed = false;

		public GithubObject()
		{
		}
		
		public virtual void ReadJson(JObject obj)
		{
		}
		
		public bool IsDisposed
		{
			get { return _disposed; }
			private set { _disposed = value; }
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!IsDisposed) 
			{
				if (disposing) 
				{
				}

				IsDisposed = true;
			}
		}

		public void Dispose()
		{
			Dispose (true);
			GC.SuppressFinalize (this);
		}

		~GithubObject()
		{
			Dispose (false);
		}
	}
}
