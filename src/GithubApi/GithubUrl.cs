using System;

namespace GithubApi
{
	public class GithubUrl
	{
		private string _protocol = null;
		private string _format = null;
		private string _userAgent = null;
		private int _port = -1;
		private int _timeout = 10;
		private string _login = null;
		private string _token = null;
		private string _path = null;
		
		public GithubUrl()
		{
		}

		public string Format
		{
			get { return this._format; }
			set { _format = value; }
		}

		public string Login 
		{
			get { return this._login; }
			set { _login = value; }
		}

		public int Port 
		{
			get { return this._port; }
			set { _port = value; }
		}

		public string Protocol 
		{
			get { return this._protocol; }
			set { _protocol = value; }
		}

		public int Timeout 
		{
			get { return this._timeout; }
			set { _timeout = value; }
		}

		public string Token 
		{
			get { return this._token; }
			set { _token = value; }
		}

		public string UserAgent 
		{
			get { return this._userAgent; }
			set { _userAgent = value; }
		}

		public string Path 
		{
			get { return this._path; }
			set { _path = value; }
		}
		
		public static GithubUrl Copy(GithubUrl source)
		{
			GithubUrl url = null;
			
			if (source != null)
			{
				url = new GithubUrl();
				url.Protocol = source.Protocol;
				url.Format = source.Format;
				url.UserAgent = source.UserAgent;
				url.Port = source.Port;
				url.Timeout = source.Timeout;
				url.Login = source.Login;
				url.Token = source.Token;
				url.Path = source.Path;
			}
			
			return url;			
		}
		
		public string GetURL()
		{
			string url = string.Empty;
			
			if (!string.IsNullOrWhiteSpace(Protocol))
				url += Protocol;
			else
				url += "https";
			
			url += "://api.github.com/";
			
			/*if (!string.IsNullOrWhiteSpace(Format))
				url += Format + "/";
			else
				url += "json/";*/
			
			if (!string.IsNullOrWhiteSpace(Path))
				url += Path;
			
			return url;
		}
	}
}

